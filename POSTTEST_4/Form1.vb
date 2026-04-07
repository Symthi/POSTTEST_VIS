Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi MaskedTextBox
        mtbNoTelp.Mask = "0000-0000-0000"
        ' Set default tab aktif
        TabControl1.SelectedTab = TabPage1

        ' Load data dari CurrentMember jika ada (misal setelah buka file)
        If CurrentMember.Nama <> "" Then
            LoadDataKeForm()
        End If
    End Sub

    Private Sub LoadDataKeForm()
        tbNama.Text = CurrentMember.Nama
        tbId.Text = CurrentMember.ID
        dtpTanggalLahir.Value = CurrentMember.TanggalLahir
        ' Jenis kelamin
        If CurrentMember.JenisKelamin = "Laki-laki" Then
            rbLakiLaki.Checked = True
        ElseIf CurrentMember.JenisKelamin = "Perempuan" Then
            rbPerempuan.Checked = True
        End If
        cboDivisi.Text = CurrentMember.Divisi
        mtbNoTelp.Text = CurrentMember.Telepon
        tbEmail.Text = CurrentMember.Email
        tbAlamat.Text = CurrentMember.Alamat
        ' Peran
        Select Case CurrentMember.Peran
            Case "Ketua Umum" : rbKetum.Checked = True
            Case "Wakil Ketua Umum" : rbWaketum.Checked = True
            Case "Sekretaris" : rbSekre.Checked = True
            Case "Bendahara" : rbBendahara.Checked = True
            Case "Anggota" : rbSnggota.Checked = True
        End Select
        ' Hobi (cocokkan dengan text checkbox)
        For Each hobi In CurrentMember.HobiList
            If hobi = "Gamer" Then cboGamer.Checked = True
            If hobi = "Desginer" Then cboDesginer.Checked = True
            If hobi = "Baca Buku" Then cboBaca.Checked = True
            If hobi = "Memancing" Then cboMemancing.Checked = True
            If hobi = "Musik" Then cboMusik.Checked = True
            If hobi = "Lari" Then cboLari.Checked = True
            If hobi = "Coding" Then cboCoding.Checked = True
            If hobi = "Memasak" Then cboMemasak.Checked = True
        Next
        ' Foto
        If File.Exists(CurrentMember.FotoPath) Then
            PictureBox1.Image = Image.FromFile(CurrentMember.FotoPath)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    ' Validasi nama hanya huruf (KeyPress)
    Private Sub tbNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Fungsi validasi semua input
    Private Function ValidasiSemuaInput() As Boolean
        ErrorProvider1.Clear()
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(tbNama.Text) Then
            ErrorProvider1.SetError(tbNama, "Nama tidak boleh kosong")
            isValid = False
        End If
        If String.IsNullOrWhiteSpace(tbId.Text) Then
            ErrorProvider1.SetError(tbId, "ID Anggota tidak boleh kosong")
            isValid = False
        End If
        If Not rbLakiLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Pilih jenis kelamin.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            isValid = False
        End If
        If cboDivisi.SelectedIndex = -1 Then
            MessageBox.Show("Pilih divisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            isValid = False
        End If
        If Not mtbNoTelp.MaskCompleted Then
            ErrorProvider1.SetError(mtbNoTelp, "Nomor telepon harus lengkap (format 0812-3456-7890)")
            isValid = False
        End If
        If String.IsNullOrWhiteSpace(tbEmail.Text) Then
            ErrorProvider1.SetError(tbEmail, "Email tidak boleh kosong")
            isValid = False
        End If
        If String.IsNullOrWhiteSpace(tbAlamat.Text) Then
            ErrorProvider1.SetError(tbAlamat, "Alamat tidak boleh kosong")
            isValid = False
        End If
        ' Cek peran (RadioButton di GroupBox)
        If Not rbKetum.Checked AndAlso Not rbWaketum.Checked AndAlso Not rbSekre.Checked AndAlso Not rbBendahara.Checked AndAlso Not rbSnggota.Checked Then
            MessageBox.Show("Pilih salah satu peran.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            isValid = False
        End If
        ' Cek minimal 1 checkbox hobi tercentang
        Dim hobiChecked As Boolean = False
        For Each ctl As Control In gbHobi.Controls
            If TypeOf ctl Is CheckBox AndAlso DirectCast(ctl, CheckBox).Checked Then
                hobiChecked = True
                Exit For
            End If
        Next
        If Not hobiChecked Then
            MessageBox.Show("Pilih minimal satu hobi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            isValid = False
        End If
        If String.IsNullOrWhiteSpace(CurrentMember.FotoPath) OrElse Not File.Exists(CurrentMember.FotoPath) Then
            MessageBox.Show("Upload foto profil terlebih dahulu.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            isValid = False
        End If

        Return isValid
    End Function

    ' Tombol Browse untuk upload foto (Anda belum punya tombol browse, tambahkan)
    ' Karena di designer tidak ada tombol browse, Anda harus menambahkan satu Button di Tab3, misal btnBrowse.
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.Title = "Pilih Foto Profil"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim destFolder As String = Path.Combine(Application.StartupPath, "FotoAnggota")
            If Not Directory.Exists(destFolder) Then Directory.CreateDirectory(destFolder)
            Dim destFile As String = Path.Combine(destFolder, Guid.NewGuid().ToString() & Path.GetExtension(OpenFileDialog1.FileName))
            File.Copy(OpenFileDialog1.FileName, destFile, True)
            CurrentMember.FotoPath = destFile
            PictureBox1.Image = Image.FromFile(destFile)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    ' Tombol Simpan & Cetak Kartu (yang akan Anda tambahkan)
    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If Not ValidasiSemuaInput() Then Return

        ' Kumpulkan data ke CurrentMember
        CurrentMember.Nama = tbNama.Text.Trim()
        CurrentMember.ID = tbId.Text.Trim()
        CurrentMember.TanggalLahir = dtpTanggalLahir.Value
        ' Hitung umur (opsional)
        Dim today As Date = Date.Today
        Dim age = today.Year - CurrentMember.TanggalLahir.Year
        If CurrentMember.TanggalLahir > today.AddYears(-age) Then age -= 1
        CurrentMember.Umur = age

        CurrentMember.JenisKelamin = If(rbLakiLaki.Checked, "Laki-laki", "Perempuan")
        CurrentMember.Divisi = cboDivisi.Text
        CurrentMember.Telepon = mtbNoTelp.Text
        CurrentMember.Email = tbEmail.Text.Trim()
        CurrentMember.Alamat = tbAlamat.Text.Trim()

        If rbKetum.Checked Then CurrentMember.Peran = "Ketua Umum"
        If rbWaketum.Checked Then CurrentMember.Peran = "Wakil Ketua Umum"
        If rbSekre.Checked Then CurrentMember.Peran = "Sekretaris"
        If rbBendahara.Checked Then CurrentMember.Peran = "Bendahara"
        If rbSnggota.Checked Then CurrentMember.Peran = "Anggota"

        CurrentMember.HobiList.Clear()
        For Each ctl As Control In gbHobi.Controls
            If TypeOf ctl Is CheckBox AndAlso DirectCast(ctl, CheckBox).Checked Then
                CurrentMember.HobiList.Add(ctl.Text)
            End If
        Next

        ' Konfirmasi cetak
        Dim result As DialogResult = MessageBox.Show("Data berhasil disimpan. Apakah ingin mencetak kartu?", "Konfirmasi Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim kartu As New FormKartu()
            kartu.ShowDialog()
        End If
    End Sub

    ' ========== MENUSTRIP ==========
    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        ' Bisa reset form atau pindah ke tab pertama
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        If CurrentMember.Nama = "" Then
            MessageBox.Show("Belum ada data anggota. Silakan input data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim kartu As New FormKartu()
        kartu.ShowDialog()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        If CurrentMember.Nama = "" Then
            MessageBox.Show("Tidak ada data yang disimpan. Input data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        SaveFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
        SaveFileDialog1.Title = "Simpan Data Anggota"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            If SimpanDataKeFile(SaveFileDialog1.FileName) Then
                MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Gagal menyimpan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
        OpenFileDialog1.Title = "Buka Data Anggota"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            If BukaDataDariFile(OpenFileDialog1.FileName) Then
                LoadDataKeForm()
                MessageBox.Show("Data berhasil dimuat.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Gagal memuat data. Format file tidak sesuai.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
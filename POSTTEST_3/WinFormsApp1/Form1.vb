Imports System.IO

Public Class Form1
    Private fotoPath As String = ""

    Private Sub FormCetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default radio button
        RadioButtonLaki.Checked = True
    End Sub

    ' Validasi angka untuk TextBox Umur
    Private Sub TextBoxUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Validasi huruf (dan spasi) untuk TextBox Nama
    Private Sub TextBoxNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Tombol Browse untuk upload foto
    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        If String.IsNullOrWhiteSpace(TextBoxNama.Text) Then
            MessageBox.Show("Nama harus diisi terlebih dahulu untuk menyimpan foto.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            ofd.Title = "Pilih Foto Profil"
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If
                Dim namaFile As String = TextBoxNama.Text.Trim() & Path.GetExtension(ofd.FileName)
                Dim destinationPath As String = Path.Combine(folderPath, namaFile)
                ' Salin file (timpa jika sudah ada)
                File.Copy(ofd.FileName, destinationPath, True)
                fotoPath = destinationPath
                ' Tampilkan di PictureBox
                PictureBoxFoto.Image = Image.FromFile(destinationPath)
                PictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom
                MessageBox.Show("Foto berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    ' Tombol Cetak Kartu
    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        ' Validasi input
        If String.IsNullOrWhiteSpace(TextBoxNama.Text) Then
            MessageBox.Show("Nama harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxNama.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(TextBoxUmur.Text) Then
            MessageBox.Show("Umur harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxUmur.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(TextBoxNoTelp.Text) Then
            MessageBox.Show("Nomor telepon harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxNoTelp.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(TextBoxAlamat.Text) Then
            MessageBox.Show("Alamat harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxAlamat.Focus()
            Return
        End If
        If String.IsNullOrEmpty(fotoPath) Then
            MessageBox.Show("Foto harus diupload!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ambil jenis kelamin
        Dim jenisKelamin As String = If(RadioButtonLaki.Checked, "Laki-laki", "Perempuan")

        ' Ambil hobby yang dipilih
        Dim hobbyList As New List(Of String)
        For Each ctrl As Control In GroupBoxHobby.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                hobbyList.Add(DirectCast(ctrl, CheckBox).Text)
            End If
        Next
        Dim hobby As String = String.Join(", ", hobbyList)

        ' Tanggal lahir (untuk keperluan tampilan, bisa dikirim)
        Dim tglLahir As String = DateTimePicker1.Value.ToShortDateString()

        ' Kirim data ke FormHasil
        Dim formHasil As New Form2()
        formHasil.SetData(TextBoxNama.Text, TextBoxUmur.Text, TextBoxNoTelp.Text,
                          TextBoxAlamat.Text, jenisKelamin, hobby, tglLahir, fotoPath)
        formHasil.ShowDialog() ' Tampilkan form hasil
    End Sub

    Private Sub Musik_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Memasak_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged

    End Sub
End Class
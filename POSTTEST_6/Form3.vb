Public Class Form3

    Private modeEdit As Boolean = False
    Private kodeEdit As String = ""

    Private Sub FormPelatih_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectedTab = tabData
        IsiComboKlub()
        TampilData()
        BersihkanInput()
    End Sub

    Private Sub IsiComboKlub()
        Dim dt As DataTable = GetAllKlub()
        cboKlub.DataSource = dt
        cboKlub.DisplayMember = "namaKlub"
        cboKlub.ValueMember = "kodeKlub"
        cboKlub.SelectedIndex = -1
    End Sub

    Private Sub TampilData()
        dgvPelatih.DataSource = GetAllPelatih()
    End Sub

    Private Sub BersihkanInput()
        txtKodePelatih.Clear()
        txtNamaPelatih.Clear()
        cboPosisi.SelectedIndex = -1
        nudPengalaman.Value = 0
        cboKlub.SelectedIndex = -1
        ErrorProvider1.Clear()
        modeEdit = False
        kodeEdit = ""
        txtKodePelatih.ReadOnly = False
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        BersihkanInput()
        modeEdit = False
        txtKodePelatih.ReadOnly = False
        TabControl1.SelectedTab = tabInput
        txtKodePelatih.Focus()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If dgvPelatih.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang akan diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim row As DataGridViewRow = dgvPelatih.SelectedRows(0)
        kodeEdit = row.Cells("kodePelatih").Value.ToString()
        txtKodePelatih.Text = kodeEdit
        txtNamaPelatih.Text = row.Cells("namaPelatih").Value.ToString()
        cboPosisi.Text = row.Cells("posisi").Value.ToString()
        nudPengalaman.Value = Convert.ToInt32(row.Cells("pengalaman").Value)
        cboKlub.SelectedValue = row.Cells("kodeKlub").Value.ToString()
        modeEdit = True
        txtKodePelatih.ReadOnly = True
        ErrorProvider1.Clear()
        TabControl1.SelectedTab = tabInput
        txtNamaPelatih.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidasiPelatih(ErrorProvider1, txtKodePelatih, txtNamaPelatih, cboPosisi, cboKlub) Then Exit Sub

        Dim kode As String = txtKodePelatih.Text.Trim()
        Dim nama As String = txtNamaPelatih.Text.Trim()
        Dim posisi As String = cboPosisi.Text
        Dim pengalaman As Integer = CInt(nudPengalaman.Value)
        Dim kodeKlub As String = If(cboKlub.SelectedValue IsNot Nothing, cboKlub.SelectedValue.ToString(), "")

        If modeEdit Then
            If UbahPelatih(kodeEdit, nama, posisi, pengalaman, kodeKlub) Then
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                TabControl1.SelectedTab = tabData
                BersihkanInput()
            End If
        Else
            If KodePelatihSudahAda(kode) Then
                MessageBox.Show("Kode Pelatih sudah terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtKodePelatih.Focus()
                Exit Sub
            End If
            If SimpanPelatih(kode, nama, posisi, pengalaman, kodeKlub) Then
                MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                TabControl1.SelectedTab = tabData
                BersihkanInput()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        TabControl1.SelectedTab = tabData
        BersihkanInput()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvPelatih.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim kode As String = dgvPelatih.SelectedRows(0).Cells("kodePelatih").Value.ToString()
        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusPelatih(kode) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        TampilData()
        txtSearch.Clear()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        LakukanPencarian()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LakukanPencarian()
    End Sub

    Private Sub LakukanPencarian()
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvPelatih.DataSource = SearchPelatih(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub txtNamaPelatih_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaPelatih.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub dgvPelatih_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPelatih.CellDoubleClick
        If e.RowIndex >= 0 Then btnUbah.PerformClick()
    End Sub

End Class
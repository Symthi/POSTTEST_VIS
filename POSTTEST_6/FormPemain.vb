Public Class FormPemain

    Private modeEdit As Boolean = False
    Private kodeEdit As String = ""

    Private Sub FormPemain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        dgvPemain.DataSource = GetAllPemain()
    End Sub

    Private Sub BersihkanInput()
        txtKodePemain.Clear()
        txtNamaPemain.Clear()
        cboPosisi.SelectedIndex = -1
        nudTinggi.Value = 190
        nudBerat.Value = 90
        cboKlub.SelectedIndex = -1
        ErrorProvider1.Clear()
        modeEdit = False
        kodeEdit = ""
        txtKodePemain.ReadOnly = False
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        BersihkanInput()
        modeEdit = False
        txtKodePemain.ReadOnly = False
        TabControl1.SelectedTab = tabInput
        txtKodePemain.Focus()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If dgvPemain.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang akan diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim row As DataGridViewRow = dgvPemain.SelectedRows(0)
        kodeEdit = row.Cells("kodePemain").Value.ToString()
        txtKodePemain.Text = kodeEdit
        txtNamaPemain.Text = row.Cells("namaPemain").Value.ToString()
        cboPosisi.Text = row.Cells("posisi").Value.ToString()
        nudTinggi.Value = Convert.ToInt32(row.Cells("tinggi").Value)
        nudBerat.Value = Convert.ToInt32(row.Cells("berat").Value)
        cboKlub.SelectedValue = row.Cells("kodeKlub").Value.ToString()
        modeEdit = True
        txtKodePemain.ReadOnly = True
        ErrorProvider1.Clear()
        TabControl1.SelectedTab = tabInput
        txtNamaPemain.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidasiPemain(ErrorProvider1, txtKodePemain, txtNamaPemain, cboPosisi, cboKlub) Then Exit Sub
        Dim kode As String = txtKodePemain.Text.Trim()
        Dim nama As String = txtNamaPemain.Text.Trim()
        Dim posisi As String = cboPosisi.Text
        Dim tinggi As Integer = CInt(nudTinggi.Value)
        Dim berat As Integer = CInt(nudBerat.Value)
        Dim kodeKlub As String = If(cboKlub.SelectedValue IsNot Nothing, cboKlub.SelectedValue.ToString(), "")
        If modeEdit Then
            If UbahPemain(kodeEdit, nama, posisi, tinggi, berat, kodeKlub) Then
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                TabControl1.SelectedTab = tabData
                BersihkanInput()
            End If
        Else
            If KodePemainSudahAda(kode) Then
                MessageBox.Show("Kode Pemain sudah terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtKodePemain.Focus()
                Exit Sub
            End If
            If SimpanPemain(kode, nama, posisi, tinggi, berat, kodeKlub) Then
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
        If dgvPemain.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim kode As String = dgvPemain.SelectedRows(0).Cells("kodePemain").Value.ToString()
        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusPemain(kode) Then
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
            dgvPemain.DataSource = SearchPemain(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub txtNamaPemain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaPemain.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub dgvPemain_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPemain.CellDoubleClick
        If e.RowIndex >= 0 Then btnUbah.PerformClick()
    End Sub

End Class
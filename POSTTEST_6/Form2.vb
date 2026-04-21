Public Class FormKlub

    Private modeEdit As Boolean = False
    Private kodeEdit As String = ""

    Private Sub FormKlub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectedTab = tabData
        TampilData()
        BersihkanInput()
    End Sub

    Private Sub TampilData()
        dgvKlub.DataSource = GetAllKlub()
    End Sub

    Private Sub BersihkanInput()
        txtKodeKlub.Clear()
        txtNamaKlub.Clear()
        txtKota.Clear()
        dtpTahunBerdiri.Value = DateTime.Now
        ErrorProvider1.Clear()
        modeEdit = False
        kodeEdit = ""
        txtKodeKlub.ReadOnly = False
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        BersihkanInput()
        modeEdit = False
        txtKodeKlub.ReadOnly = False
        TabControl1.SelectedTab = tabInput
        txtKodeKlub.Focus()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If dgvKlub.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang akan diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim row As DataGridViewRow = dgvKlub.SelectedRows(0)
        kodeEdit = row.Cells("kodeKlub").Value.ToString()
        txtKodeKlub.Text = kodeEdit
        txtNamaKlub.Text = row.Cells("namaKlub").Value.ToString()
        txtKota.Text = row.Cells("kota").Value.ToString()
        Dim thn As Integer = Convert.ToInt32(row.Cells("tahunBerdiri").Value)
        dtpTahunBerdiri.Value = New DateTime(thn, 1, 1)

        modeEdit = True
        txtKodeKlub.ReadOnly = True
        ErrorProvider1.Clear()
        TabControl1.SelectedTab = tabInput
        txtNamaKlub.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSImpan.Click
        ErrorProvider1.Clear()
        If Not ValidasiKlub(ErrorProvider1, txtKodeKlub, txtNamaKlub, txtKota) Then Exit Sub

        Dim kode As String = txtKodeKlub.Text.Trim()
        Dim nama As String = txtNamaKlub.Text.Trim()
        Dim kota As String = txtKota.Text.Trim()
        Dim tahun As Integer = dtpTahunBerdiri.Value.Year

        If modeEdit Then
            If UbahKlub(kodeEdit, nama, kota, tahun) Then
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                TabControl1.SelectedTab = tabData
                BersihkanInput()
            End If
        Else
            If KodeKlubSudahAda(kode) Then
                MessageBox.Show("Kode Klub sudah terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtKodeKlub.Focus()
                Exit Sub
            End If
            If SimpanKlub(kode, nama, kota, tahun) Then
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
        If dgvKlub.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim kode As String = dgvKlub.SelectedRows(0).Cells("kodeKlub").Value.ToString()
        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusKlub(kode) Then
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
            dgvKlub.DataSource = SearchKlub(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub txtNamaKlub_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaKlub.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtKota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKota.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub dgvKlub_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKlub.CellDoubleClick
        If e.RowIndex >= 0 Then
            btnUbah.PerformClick()
        End If
    End Sub

End Class
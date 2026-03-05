Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDaftar()
    End Sub

    Private Sub RefreshDaftar()
        lstDaftar.Items.Clear()
        For Each buku In ModuleBuku.daftarBuku
            lstDaftar.Items.Add(buku)
        Next
    End Sub

    Private Sub TambahBuku(ByVal judul As String, ByVal genre As String)
        Dim bukuBaru As String = judul & " (" & genre & ")"
        ReDim Preserve ModuleBuku.daftarBuku(ModuleBuku.daftarBuku.Length)
        ModuleBuku.daftarBuku(ModuleBuku.daftarBuku.Length - 1) = bukuBaru
        RefreshDaftar()
    End Sub

    Private Function CariIndeks(ByVal judulCari As String) As Integer
        For i As Integer = 0 To ModuleBuku.daftarBuku.Length - 1
            Dim parts() As String = ModuleBuku.daftarBuku(i).Split("(")
            If parts.Length > 0 Then
                Dim judulBuku As String = parts(0).Trim()
                If judulBuku.Equals(judulCari, StringComparison.OrdinalIgnoreCase) Then
                    Return i
                End If
            End If
        Next
        Return -1
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtJudul.Text.Trim()
        Dim genre As String = txtGenre.Text.Trim()

        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul dan genre harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        TambahBuku(judul, genre)

        txtJudul.Clear()
        txtGenre.Clear()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judulHapus As String = txtHapus.Text.Trim()

        If judulHapus = "" Then
            MessageBox.Show("Masukkan judul buku yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim indeks As Integer = CariIndeks(judulHapus)

        If indeks = -1 Then
            MessageBox.Show("Buku dengan judul '" & judulHapus & "' tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim arrayBaru() As String = {}
        For i As Integer = 0 To ModuleBuku.daftarBuku.Length - 1
            If i <> indeks Then
                ReDim Preserve arrayBaru(arrayBaru.Length)
                arrayBaru(arrayBaru.Length - 1) = ModuleBuku.daftarBuku(i)
            End If
        Next
        ModuleBuku.daftarBuku = arrayBaru

        RefreshDaftar()
        txtHapus.Clear()
    End Sub

    Private Sub txtJudul_TextChanged(sender As Object, e As EventArgs) Handles txtJudul.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub lstDaftar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDaftar.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
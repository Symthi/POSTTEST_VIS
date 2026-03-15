Public Class Form2
    ' Method untuk menerima data dari FormCetak
    Public Sub SetData(nama As String, umur As String, noTelp As String,
                       alamat As String, jenisKelamin As String, hobby As String,
                       tglLahir As String, fotoPath As String)
        lblNama.Text = "Nama    : " & nama
        lblUmur.Text = "Umur    : " & umur
        lblNoTelp.Text = "No. Telepon   : " & noTelp
        lblAlamat.Text = "Alamat    : " & alamat
        lblJenisKelamin.Text = "Jenis Kelamin   : " & jenisKelamin
        lblHobby.Text = "Hobby  : " & hobby

        ' Tampilkan foto jika file ada
        If IO.File.Exists(fotoPath) Then
            PictureBoxFoto.Image = Image.FromFile(fotoPath)
            PictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNama.Click

    End Sub

    Private Sub lblNoTelp_Click(sender As Object, e As EventArgs) Handles lblNoTelp.Click

    End Sub
End Class
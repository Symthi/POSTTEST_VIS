Imports System.IO

Public Class FormKartu
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanKartu()
    End Sub

    Private Sub TampilkanKartu()
        ' Cek apakah ada data
        If CurrentMember.Nama = "" Then
            MessageBox.Show("Data anggota kosong. Silakan input data terlebih dahulu.",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Return
        End If

        ' Tampilkan foto
        If File.Exists(CurrentMember.FotoPath) Then
            PictureBox1.Image = Image.FromFile(CurrentMember.FotoPath)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If

        ' Isi label-label dengan data dari CurrentMember
        ' Karena label di designer hanya satu label per baris, kita set teksnya menjadi "Nama: xxx"
        lblNamaKartu.Text = "Nama: " & CurrentMember.Nama
        lblIDKartu.Text = "ID: " & CurrentMember.ID
        lblDivisiKartu.Text = "Divisi: " & CurrentMember.Divisi
        lblKontakKartu.Text = "Kontak: " & CurrentMember.Telepon & " | " & CurrentMember.Email
        lblPeranKartu.Text = "Peran: " & CurrentMember.Peran

        ' (Opsional) Jika ingin tambah hobi, silakan tambahkan label baru di designer
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub lblIDKartu_Click(sender As Object, e As EventArgs) Handles lblIDKartu.Click

    End Sub
End Class
Public Class FormMenuUtama

    Private Sub btnKlub_Click(sender As Object, e As EventArgs) Handles btnKlub.Click
        Dim frm As New FormKlub()
        frm.Show()
    End Sub

    Private Sub btnPemain_Click(sender As Object, e As EventArgs) Handles btnPemain.Click
        Dim frm As New FormPemain()
        frm.Show()
    End Sub

    Private Sub btnPelatih_Click(sender As Object, e As EventArgs) Handles btnPelatih.Click
        Dim frm As New Form3()
        frm.Show()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ipSemester As Double

        If Double.TryParse(txtIPSemester.Text, ipSemester) Then
            If ipSemester >= 0 And ipSemester <= 4 Then
                totalIP = totalIP + ipSemester
                jumlahSemester = jumlahSemester + 1

                Dim ipk As Double
                ipk = totalIP / jumlahSemester

                txtIPK.Text = ipk.ToString("F2")

                If ipk >= 3.01 Then
                    lblPredikat.Text = "Sangat Memuaskan"
                ElseIf ipk >= 2.76 Then
                    lblPredikat.Text = "Memuaskan"
                ElseIf ipk >= 2.0 Then
                    lblPredikat.Text = "Cukup"
                Else
                    lblPredikat.Text = "Kurang"
                End If

                txtIPSemester.Text = ""
                txtIPSemester.Focus()

            Else
                MessageBox.Show("IP harus antara 0 - 4!")
            End If
        Else
            MessageBox.Show("Input harus angka!")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0
        txtIPSemester.Text = ""
        txtIPK.Text = ""
        lblPredikat.Text = ""
        txtIPSemester.Focus()
    End Sub
End Class

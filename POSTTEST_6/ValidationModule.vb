Imports System.Windows.Forms

Module ValidationModule
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiKlub(ep As ErrorProvider, txtKode As TextBox, txtNama As TextBox, txtKota As TextBox) As Boolean
        Dim kodeValid = ValidasiTextBox(ep, txtKode, "Kode Klub tidak boleh kosong")
        Dim namaValid = ValidasiTextBox(ep, txtNama, "Nama Klub tidak boleh kosong")
        Dim kotaValid = ValidasiTextBox(ep, txtKota, "Kota tidak boleh kosong")
        Return kodeValid AndAlso namaValid AndAlso kotaValid
    End Function

    Public Function ValidasiPemain(ep As ErrorProvider, txtKode As TextBox, txtNama As TextBox, cboPosisi As ComboBox, cboKlub As ComboBox) As Boolean
        Dim kodeValid = ValidasiTextBox(ep, txtKode, "Kode Pemain tidak boleh kosong")
        Dim namaValid = ValidasiTextBox(ep, txtNama, "Nama Pemain tidak boleh kosong")
        Dim posisiValid As Boolean = True
        If cboPosisi.SelectedIndex = -1 Then
            ep.SetError(cboPosisi, "Pilih posisi")
            posisiValid = False
        Else
            ep.SetError(cboPosisi, "")
        End If
        Dim klubValid As Boolean = True
        If cboKlub.SelectedIndex = -1 Then
            ep.SetError(cboKlub, "Pilih klub")
            klubValid = False
        Else
            ep.SetError(cboKlub, "")
        End If
        Return kodeValid AndAlso namaValid AndAlso posisiValid AndAlso klubValid
    End Function
    Public Function ValidasiPelatih(ep As ErrorProvider, txtKode As TextBox, txtNama As TextBox, cboPosisi As ComboBox, cboKlub As ComboBox) As Boolean
        Dim kodeValid = ValidasiTextBox(ep, txtKode, "Kode Pelatih tidak boleh kosong")
        Dim namaValid = ValidasiTextBox(ep, txtNama, "Nama Pelatih tidak boleh kosong")
        Dim posisiValid As Boolean = True
        If cboPosisi.SelectedIndex = -1 Then
            ep.SetError(cboPosisi, "Pilih posisi pelatih")
            posisiValid = False
        Else
            ep.SetError(cboPosisi, "")
        End If
        Dim klubValid As Boolean = True
        If cboKlub.SelectedIndex = -1 Then
            ep.SetError(cboKlub, "Pilih klub")
            klubValid = False
        Else
            ep.SetError(cboKlub, "")
        End If
        Return kodeValid AndAlso namaValid AndAlso posisiValid AndAlso klubValid
    End Function

End Module
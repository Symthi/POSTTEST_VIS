Imports System.IO
Imports System.Text

Module ModuleData
    Public CurrentMember As New Member()

    Public Function SimpanDataKeFile(filePath As String) As Boolean
        Try
            Dim sb As New StringBuilder()
            With CurrentMember
                sb.AppendLine($"{ .Nama}|{ .ID}|{ .TanggalLahir:yyyy-MM-dd}|{ .Umur}|{ .JenisKelamin}|{ .Divisi}|{ .Telepon}|{ .Email}|{ .Alamat}|{ .Peran}|{String.Join(",", .HobiList)}|{ .FotoPath}")
            End With
            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function BukaDataDariFile(filePath As String) As Boolean
        Try
            Dim lines As String() = File.ReadAllLines(filePath, Encoding.UTF8)
            If lines.Length = 0 Then Return False
            Dim parts As String() = lines(0).Split("|"c)
            If parts.Length >= 12 Then
                CurrentMember.Nama = parts(0)
                CurrentMember.ID = parts(1)
                CurrentMember.TanggalLahir = Date.Parse(parts(2))
                CurrentMember.Umur = Integer.Parse(parts(3))
                CurrentMember.JenisKelamin = parts(4)
                CurrentMember.Divisi = parts(5)   ' <-- pakai Divisi
                CurrentMember.Telepon = parts(6)
                CurrentMember.Email = parts(7)
                CurrentMember.Alamat = parts(8)
                CurrentMember.Peran = parts(9)
                CurrentMember.HobiList = parts(10).Split(","c).ToList()
                CurrentMember.FotoPath = parts(11)
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module

Public Class Member
    Public Property Nama As String = ""
    Public Property ID As String = ""
    Public Property TanggalLahir As Date = Date.Today
    Public Property Umur As Integer = 0
    Public Property JenisKelamin As String = ""
    Public Property Divisi As String = ""   ' <-- pakai Divisi, hapus Komunitas jika ada
    Public Property Telepon As String = ""
    Public Property Email As String = ""
    Public Property Alamat As String = ""
    Public Property Peran As String = ""
    Public Property HobiList As New List(Of String)
    Public Property FotoPath As String = ""
End Class
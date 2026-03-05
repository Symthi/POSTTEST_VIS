<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label2 = New Label()
        txtJudul = New TextBox()
        txtGenre = New TextBox()
        btnTambah = New Button()
        txtHapus = New TextBox()
        btnHapus = New Button()
        lstDaftar = New ListBox()
        Label1 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(20, 24)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 15)
        Label2.TabIndex = 1
        Label2.Text = "Tambah Buku"
        ' 
        ' txtJudul
        ' 
        txtJudul.BackColor = SystemColors.Window
        txtJudul.Location = New Point(91, 54)
        txtJudul.Margin = New Padding(4, 3, 4, 3)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(174, 23)
        txtJudul.TabIndex = 2
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(91, 83)
        txtGenre.Margin = New Padding(4, 3, 4, 3)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(174, 23)
        txtGenre.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(90, 112)
        btnTambah.Margin = New Padding(4, 3, 4, 3)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(175, 27)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(356, 54)
        txtHapus.Margin = New Padding(4, 3, 4, 3)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(174, 23)
        txtHapus.TabIndex = 6
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(355, 86)
        btnHapus.Margin = New Padding(4, 3, 4, 3)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(175, 27)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' lstDaftar
        ' 
        lstDaftar.FormattingEnabled = True
        lstDaftar.Location = New Point(20, 177)
        lstDaftar.Margin = New Padding(4, 3, 4, 3)
        lstDaftar.Name = "lstDaftar"
        lstDaftar.Size = New Size(303, 109)
        lstDaftar.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(20, 57)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 10
        Label1.Text = "Judul Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(20, 86)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 11
        Label3.Text = "Genre"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(285, 24)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 15)
        Label5.TabIndex = 12
        Label5.Text = "Hapus Buku"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(20, 159)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 13
        Label4.Text = "Daftar Buku"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(285, 57)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 15)
        Label6.TabIndex = 14
        Label6.Text = "Judul Buku"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(555, 319)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(lstDaftar)
        Controls.Add(btnHapus)
        Controls.Add(txtHapus)
        Controls.Add(btnTambah)
        Controls.Add(txtGenre)
        Controls.Add(txtJudul)
        Controls.Add(Label2)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Posttest 2"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents lstDaftar As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
End Class
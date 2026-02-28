<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtIPSemester = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        txtIPK = New TextBox()
        Label2 = New Label()
        lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(150, 129)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 0
        Label1.Text = "IP Semster"
        ' 
        ' txtIPSemester
        ' 
        txtIPSemester.Location = New Point(218, 126)
        txtIPSemester.Name = "txtIPSemester"
        txtIPSemester.Size = New Size(156, 23)
        txtIPSemester.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = SystemColors.ActiveBorder
        btnTambah.FlatStyle = FlatStyle.Popup
        btnTambah.Location = New Point(218, 155)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = SystemColors.ActiveBorder
        btnReset.FlatStyle = FlatStyle.Popup
        btnReset.Location = New Point(299, 155)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 23)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(218, 184)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(156, 23)
        txtIPK.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(140, 192)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 5
        Label2.Text = "IP Kumulatif"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(218, 210)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(12, 15)
        lblPredikat.TabIndex = 6
        lblPredikat.Text = "-"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(537, 327)
        Controls.Add(lblPredikat)
        Controls.Add(Label2)
        Controls.Add(txtIPK)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPSemester)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIPSemester As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPredikat As Label

End Class

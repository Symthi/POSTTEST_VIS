<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBoxFoto = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblNoTelp = New Label()
        lblJenisKelamin = New Label()
        lblHobby = New Label()
        lblAlamat = New Label()
        CType(PictureBoxFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxFoto
        ' 
        PictureBoxFoto.Location = New Point(102, 230)
        PictureBoxFoto.Name = "PictureBoxFoto"
        PictureBoxFoto.Size = New Size(163, 250)
        PictureBoxFoto.TabIndex = 0
        PictureBoxFoto.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(303, 173)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(104, 45)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Font = New Font("Segoe UI", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUmur.Location = New Point(303, 230)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(99, 45)
        lblUmur.TabIndex = 2
        lblUmur.Text = "Umur"
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.Font = New Font("Segoe UI", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNoTelp.Location = New Point(303, 429)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(128, 45)
        lblNoTelp.TabIndex = 3
        lblNoTelp.Text = "No.Telp"
        ' 
        ' lblJenisKelamin
        ' 
        lblJenisKelamin.AutoSize = True
        lblJenisKelamin.Font = New Font("Segoe UI", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJenisKelamin.Location = New Point(303, 293)
        lblJenisKelamin.Name = "lblJenisKelamin"
        lblJenisKelamin.Size = New Size(211, 45)
        lblJenisKelamin.TabIndex = 4
        lblJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Font = New Font("Segoe UI", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHobby.Location = New Point(303, 492)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(115, 45)
        lblHobby.TabIndex = 5
        lblHobby.Text = "Hobby"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Segoe UI", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAlamat.Location = New Point(303, 361)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(120, 45)
        lblAlamat.TabIndex = 6
        lblAlamat.Text = "Alamat"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1009, 671)
        Controls.Add(lblAlamat)
        Controls.Add(lblHobby)
        Controls.Add(lblJenisKelamin)
        Controls.Add(lblNoTelp)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(PictureBoxFoto)
        Name = "Form2"
        Text = "FormHasil"
        CType(PictureBoxFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBoxFoto As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblAlamat As Label
End Class

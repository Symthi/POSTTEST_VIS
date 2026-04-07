<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKartu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKartu))
        PictureBox1 = New PictureBox()
        lblNamaKartu = New Label()
        lblIDKartu = New Label()
        lblDivisiKartu = New Label()
        lblKontakKartu = New Label()
        lblPeranKartu = New Label()
        btnTutup = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(579, 76)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(209, 347)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblNamaKartu
        ' 
        lblNamaKartu.AutoSize = True
        lblNamaKartu.Font = New Font("Segoe UI", 36.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNamaKartu.Location = New Point(74, 136)
        lblNamaKartu.Name = "lblNamaKartu"
        lblNamaKartu.Size = New Size(153, 65)
        lblNamaKartu.TabIndex = 1
        lblNamaKartu.Text = "Nama"
        ' 
        ' lblIDKartu
        ' 
        lblIDKartu.AutoSize = True
        lblIDKartu.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblIDKartu.Location = New Point(74, 299)
        lblIDKartu.Name = "lblIDKartu"
        lblIDKartu.Size = New Size(37, 32)
        lblIDKartu.TabIndex = 2
        lblIDKartu.Text = "ID"
        ' 
        ' lblDivisiKartu
        ' 
        lblDivisiKartu.AutoSize = True
        lblDivisiKartu.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDivisiKartu.Location = New Point(74, 391)
        lblDivisiKartu.Name = "lblDivisiKartu"
        lblDivisiKartu.Size = New Size(71, 32)
        lblDivisiKartu.TabIndex = 3
        lblDivisiKartu.Text = "Divisi"
        ' 
        ' lblKontakKartu
        ' 
        lblKontakKartu.AutoSize = True
        lblKontakKartu.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblKontakKartu.Location = New Point(74, 348)
        lblKontakKartu.Name = "lblKontakKartu"
        lblKontakKartu.Size = New Size(87, 32)
        lblKontakKartu.TabIndex = 4
        lblKontakKartu.Text = "Kontak"
        ' 
        ' lblPeranKartu
        ' 
        lblPeranKartu.AutoSize = True
        lblPeranKartu.Font = New Font("Segoe UI", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPeranKartu.Location = New Point(74, 60)
        lblPeranKartu.Name = "lblPeranKartu"
        lblPeranKartu.Size = New Size(99, 45)
        lblPeranKartu.TabIndex = 5
        lblPeranKartu.Text = "Peran"
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(665, 12)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(123, 36)
        btnTutup.TabIndex = 6
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(btnTutup)
        Controls.Add(lblPeranKartu)
        Controls.Add(lblKontakKartu)
        Controls.Add(lblDivisiKartu)
        Controls.Add(lblIDKartu)
        Controls.Add(lblNamaKartu)
        Controls.Add(PictureBox1)
        Name = "FormKartu"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNamaKartu As Label
    Friend WithEvents lblIDKartu As Label
    Friend WithEvents lblDivisiKartu As Label
    Friend WithEvents lblKontakKartu As Label
    Friend WithEvents lblPeranKartu As Label
    Friend WithEvents btnTutup As Button
End Class

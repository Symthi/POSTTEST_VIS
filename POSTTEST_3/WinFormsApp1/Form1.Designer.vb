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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBoxFoto = New PictureBox()
        ButtonBrowse = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBoxNama = New TextBox()
        TextBoxUmur = New TextBox()
        TextBoxNoTelp = New TextBox()
        TextBoxAlamat = New TextBox()
        RadioButtonLaki = New RadioButton()
        GroupBoxJenisKelamin = New GroupBox()
        RadioButtonPerempuan = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        GroupBoxHobby = New GroupBox()
        CheckBox10 = New CheckBox()
        CheckBox9 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        ButtonCetak = New Button()
        CType(PictureBoxFoto, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxJenisKelamin.SuspendLayout()
        GroupBoxHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBoxFoto
        ' 
        PictureBoxFoto.Location = New Point(56, 240)
        PictureBoxFoto.Name = "PictureBoxFoto"
        PictureBoxFoto.Size = New Size(171, 227)
        PictureBoxFoto.TabIndex = 0
        PictureBoxFoto.TabStop = False
        ' 
        ' ButtonBrowse
        ' 
        ButtonBrowse.Location = New Point(103, 473)
        ButtonBrowse.Name = "ButtonBrowse"
        ButtonBrowse.Size = New Size(75, 23)
        ButtonBrowse.TabIndex = 1
        ButtonBrowse.Text = "Browser"
        ButtonBrowse.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(273, 242)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 2
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(273, 272)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 15)
        Label2.TabIndex = 3
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(273, 374)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 15)
        Label3.TabIndex = 4
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(273, 340)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 5
        Label4.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(273, 306)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 15)
        Label5.TabIndex = 6
        Label5.Text = "No. Telpon"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(577, 521)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 15)
        Label6.TabIndex = 7
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.Location = New Point(374, 239)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.Size = New Size(161, 23)
        TextBoxNama.TabIndex = 8
        ' 
        ' TextBoxUmur
        ' 
        TextBoxUmur.Location = New Point(374, 272)
        TextBoxUmur.Name = "TextBoxUmur"
        TextBoxUmur.Size = New Size(161, 23)
        TextBoxUmur.TabIndex = 9
        ' 
        ' TextBoxNoTelp
        ' 
        TextBoxNoTelp.Location = New Point(374, 303)
        TextBoxNoTelp.Name = "TextBoxNoTelp"
        TextBoxNoTelp.Size = New Size(161, 23)
        TextBoxNoTelp.TabIndex = 10
        ' 
        ' TextBoxAlamat
        ' 
        TextBoxAlamat.Location = New Point(374, 337)
        TextBoxAlamat.Name = "TextBoxAlamat"
        TextBoxAlamat.Size = New Size(161, 23)
        TextBoxAlamat.TabIndex = 11
        ' 
        ' RadioButtonLaki
        ' 
        RadioButtonLaki.AutoSize = True
        RadioButtonLaki.Location = New Point(6, 22)
        RadioButtonLaki.Name = "RadioButtonLaki"
        RadioButtonLaki.Size = New Size(70, 19)
        RadioButtonLaki.TabIndex = 12
        RadioButtonLaki.TabStop = True
        RadioButtonLaki.Text = "Laki Laki"
        RadioButtonLaki.UseVisualStyleBackColor = True
        ' 
        ' GroupBoxJenisKelamin
        ' 
        GroupBoxJenisKelamin.Controls.Add(RadioButtonPerempuan)
        GroupBoxJenisKelamin.Controls.Add(RadioButtonLaki)
        GroupBoxJenisKelamin.Location = New Point(273, 419)
        GroupBoxJenisKelamin.Name = "GroupBoxJenisKelamin"
        GroupBoxJenisKelamin.Size = New Size(200, 76)
        GroupBoxJenisKelamin.TabIndex = 13
        GroupBoxJenisKelamin.TabStop = False
        GroupBoxJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' RadioButtonPerempuan
        ' 
        RadioButtonPerempuan.AutoSize = True
        RadioButtonPerempuan.Location = New Point(6, 47)
        RadioButtonPerempuan.Name = "RadioButtonPerempuan"
        RadioButtonPerempuan.Size = New Size(86, 19)
        RadioButtonPerempuan.TabIndex = 13
        RadioButtonPerempuan.TabStop = True
        RadioButtonPerempuan.Text = "Perempuan"
        RadioButtonPerempuan.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(374, 368)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(161, 23)
        DateTimePicker1.TabIndex = 14
        ' 
        ' GroupBoxHobby
        ' 
        GroupBoxHobby.Controls.Add(CheckBox10)
        GroupBoxHobby.Controls.Add(CheckBox9)
        GroupBoxHobby.Controls.Add(CheckBox8)
        GroupBoxHobby.Controls.Add(CheckBox7)
        GroupBoxHobby.Controls.Add(CheckBox6)
        GroupBoxHobby.Controls.Add(CheckBox5)
        GroupBoxHobby.Controls.Add(CheckBox4)
        GroupBoxHobby.Controls.Add(CheckBox3)
        GroupBoxHobby.Controls.Add(CheckBox2)
        GroupBoxHobby.Controls.Add(CheckBox1)
        GroupBoxHobby.Location = New Point(565, 242)
        GroupBoxHobby.Name = "GroupBoxHobby"
        GroupBoxHobby.Size = New Size(274, 163)
        GroupBoxHobby.TabIndex = 14
        GroupBoxHobby.TabStop = False
        GroupBoxHobby.Text = "Hobby"
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(110, 126)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(91, 19)
        CheckBox10.TabIndex = 9
        CheckBox10.Text = "CheckBox10"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(110, 101)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(85, 19)
        CheckBox9.TabIndex = 8
        CheckBox9.Text = "CheckBox9"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(110, 76)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(85, 19)
        CheckBox8.TabIndex = 7
        CheckBox8.Text = "CheckBox8"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(110, 51)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(68, 19)
        CheckBox7.TabIndex = 6
        CheckBox7.Text = "Menulis"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(110, 26)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(77, 19)
        CheckBox6.TabIndex = 5
        CheckBox6.Text = "Memasak"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(8, 126)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(73, 19)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "Ngoding"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(8, 101)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(68, 19)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Gaming"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(8, 76)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(77, 19)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Shopping"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(8, 51)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(76, 19)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Travelling"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(8, 26)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(58, 19)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Musik"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' ButtonCetak
        ' 
        ButtonCetak.Location = New Point(401, 539)
        ButtonCetak.Name = "ButtonCetak"
        ButtonCetak.Size = New Size(230, 23)
        ButtonCetak.TabIndex = 15
        ButtonCetak.Text = "Cetak ID"
        ButtonCetak.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1008, 679)
        Controls.Add(ButtonCetak)
        Controls.Add(GroupBoxHobby)
        Controls.Add(DateTimePicker1)
        Controls.Add(GroupBoxJenisKelamin)
        Controls.Add(TextBoxAlamat)
        Controls.Add(TextBoxNoTelp)
        Controls.Add(TextBoxUmur)
        Controls.Add(TextBoxNama)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ButtonBrowse)
        Controls.Add(PictureBoxFoto)
        Name = "Form1"
        Text = "FormCetak"
        CType(PictureBoxFoto, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxJenisKelamin.ResumeLayout(False)
        GroupBoxJenisKelamin.PerformLayout()
        GroupBoxHobby.ResumeLayout(False)
        GroupBoxHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBoxFoto As PictureBox
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents TextBoxUmur As TextBox
    Friend WithEvents TextBoxNoTelp As TextBox
    Friend WithEvents TextBoxAlamat As TextBox
    Friend WithEvents RadioButtonLaki As RadioButton
    Friend WithEvents GroupBoxJenisKelamin As GroupBox
    Friend WithEvents RadioButtonPerempuan As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBoxHobby As GroupBox
    Friend WithEvents ButtonCetak As Button
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox

End Class

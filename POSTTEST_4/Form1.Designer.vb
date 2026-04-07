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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        lblSivisi = New Label()
        lblJenisKelamin = New Label()
        lblTglLahir = New Label()
        lblId = New Label()
        lblNama = New Label()
        cboDivisi = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLakiLaki = New RadioButton()
        dtpTanggalLahir = New DateTimePicker()
        tbId = New TextBox()
        tbNama = New TextBox()
        TabPage2 = New TabPage()
        lblAlamat = New Label()
        lblEmail = New Label()
        mtbNoTelp = New MaskedTextBox()
        lblNoTelp = New Label()
        tbAlamat = New TextBox()
        tbEmail = New TextBox()
        TabPage3 = New TabPage()
        btnBrowse = New Button()
        btnSimpanCetak = New Button()
        gbHobi = New GroupBox()
        cboGamer = New CheckBox()
        cboDesginer = New CheckBox()
        cboBaca = New CheckBox()
        cboMemancing = New CheckBox()
        cboMusik = New CheckBox()
        cboLari = New CheckBox()
        cboCoding = New CheckBox()
        cboMemasak = New CheckBox()
        gbPeran = New GroupBox()
        rbSnggota = New RadioButton()
        rbBendahara = New RadioButton()
        rbSekre = New RadioButton()
        rbWaketum = New RadioButton()
        rbKetum = New RadioButton()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        SaveFileDialog1 = New SaveFileDialog()
        lblUkm = New Label()
        PictureBox2 = New PictureBox()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        gbHobi.SuspendLayout()
        gbPeran.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(74, 20)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(76, 20)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(86, 20)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(72, 20)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(52, 20)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(139, 114)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(490, 324)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(lblSivisi)
        TabPage1.Controls.Add(lblJenisKelamin)
        TabPage1.Controls.Add(lblTglLahir)
        TabPage1.Controls.Add(lblId)
        TabPage1.Controls.Add(lblNama)
        TabPage1.Controls.Add(cboDivisi)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(rbLakiLaki)
        TabPage1.Controls.Add(dtpTanggalLahir)
        TabPage1.Controls.Add(tbId)
        TabPage1.Controls.Add(tbNama)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(482, 296)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' lblSivisi
        ' 
        lblSivisi.AutoSize = True
        lblSivisi.Location = New Point(64, 225)
        lblSivisi.Name = "lblSivisi"
        lblSivisi.Size = New Size(35, 15)
        lblSivisi.TabIndex = 9
        lblSivisi.Text = "Divisi"
        ' 
        ' lblJenisKelamin
        ' 
        lblJenisKelamin.AutoSize = True
        lblJenisKelamin.Location = New Point(64, 181)
        lblJenisKelamin.Name = "lblJenisKelamin"
        lblJenisKelamin.Size = New Size(78, 15)
        lblJenisKelamin.TabIndex = 8
        lblJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' lblTglLahir
        ' 
        lblTglLahir.AutoSize = True
        lblTglLahir.Location = New Point(64, 144)
        lblTglLahir.Name = "lblTglLahir"
        lblTglLahir.Size = New Size(77, 15)
        lblTglLahir.TabIndex = 7
        lblTglLahir.Text = "Tanggal Lahir"
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Location = New Point(64, 95)
        lblId.Name = "lblId"
        lblId.Size = New Size(67, 15)
        lblId.TabIndex = 6
        lblId.Text = "ID Anggota"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(64, 52)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(39, 15)
        lblNama.TabIndex = 6
        lblNama.Text = "Nama"
        ' 
        ' cboDivisi
        ' 
        cboDivisi.FormattingEnabled = True
        cboDivisi.Items.AddRange(New Object() {"Divisi Media", "Divisi Humas", "Divisi Kepelatihan", "Divisi Pertandingan"})
        cboDivisi.Location = New Point(261, 217)
        cboDivisi.Name = "cboDivisi"
        cboDivisi.Size = New Size(184, 23)
        cboDivisi.TabIndex = 5
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(359, 179)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(86, 19)
        rbPerempuan.TabIndex = 4
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLakiLaki
        ' 
        rbLakiLaki.AutoSize = True
        rbLakiLaki.Location = New Point(261, 179)
        rbLakiLaki.Name = "rbLakiLaki"
        rbLakiLaki.Size = New Size(78, 19)
        rbLakiLaki.TabIndex = 3
        rbLakiLaki.TabStop = True
        rbLakiLaki.Text = "Laki - Laki"
        rbLakiLaki.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(261, 136)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(184, 23)
        dtpTanggalLahir.TabIndex = 2
        ' 
        ' tbId
        ' 
        tbId.Location = New Point(261, 87)
        tbId.Name = "tbId"
        tbId.Size = New Size(184, 23)
        tbId.TabIndex = 1
        ' 
        ' tbNama
        ' 
        tbNama.Location = New Point(261, 44)
        tbNama.Name = "tbNama"
        tbNama.Size = New Size(184, 23)
        tbNama.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(lblAlamat)
        TabPage2.Controls.Add(lblEmail)
        TabPage2.Controls.Add(mtbNoTelp)
        TabPage2.Controls.Add(lblNoTelp)
        TabPage2.Controls.Add(tbAlamat)
        TabPage2.Controls.Add(tbEmail)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(482, 296)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(44, 153)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(45, 15)
        lblAlamat.TabIndex = 6
        lblAlamat.Text = "Alamat"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(44, 106)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(36, 15)
        lblEmail.TabIndex = 5
        lblEmail.Text = "Email"
        ' 
        ' mtbNoTelp
        ' 
        mtbNoTelp.Location = New Point(279, 47)
        mtbNoTelp.Name = "mtbNoTelp"
        mtbNoTelp.Size = New Size(161, 23)
        mtbNoTelp.TabIndex = 4
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.Location = New Point(44, 55)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(89, 15)
        lblNoTelp.TabIndex = 3
        lblNoTelp.Text = "Nomor Telepon"
        ' 
        ' tbAlamat
        ' 
        tbAlamat.Location = New Point(279, 150)
        tbAlamat.Name = "tbAlamat"
        tbAlamat.Size = New Size(161, 23)
        tbAlamat.TabIndex = 2
        ' 
        ' tbEmail
        ' 
        tbEmail.Location = New Point(279, 98)
        tbEmail.Name = "tbEmail"
        tbEmail.Size = New Size(161, 23)
        tbEmail.TabIndex = 1
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(btnSimpanCetak)
        TabPage3.Controls.Add(gbHobi)
        TabPage3.Controls.Add(gbPeran)
        TabPage3.Controls.Add(PictureBox1)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(482, 296)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(40, 212)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(75, 23)
        btnBrowse.TabIndex = 12
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.Location = New Point(175, 259)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(286, 23)
        btnSimpanCetak.TabIndex = 11
        btnSimpanCetak.Text = "Simpan dan Cetak Kartu"
        btnSimpanCetak.UseVisualStyleBackColor = True
        ' 
        ' gbHobi
        ' 
        gbHobi.Controls.Add(cboGamer)
        gbHobi.Controls.Add(cboDesginer)
        gbHobi.Controls.Add(cboBaca)
        gbHobi.Controls.Add(cboMemancing)
        gbHobi.Controls.Add(cboMusik)
        gbHobi.Controls.Add(cboLari)
        gbHobi.Controls.Add(cboCoding)
        gbHobi.Controls.Add(cboMemasak)
        gbHobi.Location = New Point(175, 161)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(286, 92)
        gbHobi.TabIndex = 10
        gbHobi.TabStop = False
        gbHobi.Text = "Hobi"
        ' 
        ' cboGamer
        ' 
        cboGamer.AutoSize = True
        cboGamer.Location = New Point(20, 15)
        cboGamer.Name = "cboGamer"
        cboGamer.Size = New Size(61, 19)
        cboGamer.TabIndex = 9
        cboGamer.Text = "Gamer"
        cboGamer.UseVisualStyleBackColor = True
        ' 
        ' cboDesginer
        ' 
        cboDesginer.AutoSize = True
        cboDesginer.Location = New Point(93, 40)
        cboDesginer.Name = "cboDesginer"
        cboDesginer.Size = New Size(72, 19)
        cboDesginer.TabIndex = 8
        cboDesginer.Text = "Desginer"
        cboDesginer.UseVisualStyleBackColor = True
        ' 
        ' cboBaca
        ' 
        cboBaca.AutoSize = True
        cboBaca.Location = New Point(187, 40)
        cboBaca.Name = "cboBaca"
        cboBaca.Size = New Size(81, 19)
        cboBaca.TabIndex = 7
        cboBaca.Text = "Baca Buku"
        cboBaca.UseVisualStyleBackColor = True
        ' 
        ' cboMemancing
        ' 
        cboMemancing.AutoSize = True
        cboMemancing.Location = New Point(93, 65)
        cboMemancing.Name = "cboMemancing"
        cboMemancing.Size = New Size(90, 19)
        cboMemancing.TabIndex = 6
        cboMemancing.Text = "Memancing"
        cboMemancing.UseVisualStyleBackColor = True
        ' 
        ' cboMusik
        ' 
        cboMusik.AutoSize = True
        cboMusik.Location = New Point(20, 65)
        cboMusik.Name = "cboMusik"
        cboMusik.Size = New Size(58, 19)
        cboMusik.TabIndex = 5
        cboMusik.Text = "Musik"
        cboMusik.UseVisualStyleBackColor = True
        ' 
        ' cboLari
        ' 
        cboLari.AutoSize = True
        cboLari.Location = New Point(187, 15)
        cboLari.Name = "cboLari"
        cboLari.Size = New Size(45, 19)
        cboLari.TabIndex = 4
        cboLari.Text = "Lari"
        cboLari.UseVisualStyleBackColor = True
        ' 
        ' cboCoding
        ' 
        cboCoding.AutoSize = True
        cboCoding.Location = New Point(20, 40)
        cboCoding.Name = "cboCoding"
        cboCoding.Size = New Size(65, 19)
        cboCoding.TabIndex = 3
        cboCoding.Text = "Coding"
        cboCoding.UseVisualStyleBackColor = True
        ' 
        ' cboMemasak
        ' 
        cboMemasak.AutoSize = True
        cboMemasak.Location = New Point(93, 15)
        cboMemasak.Name = "cboMemasak"
        cboMemasak.Size = New Size(77, 19)
        cboMemasak.TabIndex = 2
        cboMemasak.Text = "Memasak"
        cboMemasak.UseVisualStyleBackColor = True
        ' 
        ' gbPeran
        ' 
        gbPeran.Controls.Add(rbSnggota)
        gbPeran.Controls.Add(rbBendahara)
        gbPeran.Controls.Add(rbSekre)
        gbPeran.Controls.Add(rbWaketum)
        gbPeran.Controls.Add(rbKetum)
        gbPeran.Location = New Point(175, 35)
        gbPeran.Name = "gbPeran"
        gbPeran.Size = New Size(286, 109)
        gbPeran.TabIndex = 1
        gbPeran.TabStop = False
        gbPeran.Text = "Peran"
        ' 
        ' rbSnggota
        ' 
        rbSnggota.AutoSize = True
        rbSnggota.Location = New Point(6, 72)
        rbSnggota.Name = "rbSnggota"
        rbSnggota.Size = New Size(71, 19)
        rbSnggota.TabIndex = 4
        rbSnggota.TabStop = True
        rbSnggota.Text = "Anggota"
        rbSnggota.UseVisualStyleBackColor = True
        ' 
        ' rbBendahara
        ' 
        rbBendahara.AutoSize = True
        rbBendahara.Location = New Point(187, 47)
        rbBendahara.Name = "rbBendahara"
        rbBendahara.Size = New Size(81, 19)
        rbBendahara.TabIndex = 3
        rbBendahara.TabStop = True
        rbBendahara.Text = "Bendahara"
        rbBendahara.UseVisualStyleBackColor = True
        ' 
        ' rbSekre
        ' 
        rbSekre.AutoSize = True
        rbSekre.Location = New Point(187, 22)
        rbSekre.Name = "rbSekre"
        rbSekre.Size = New Size(75, 19)
        rbSekre.TabIndex = 2
        rbSekre.TabStop = True
        rbSekre.Text = "Sekretaris"
        rbSekre.UseVisualStyleBackColor = True
        ' 
        ' rbWaketum
        ' 
        rbWaketum.AutoSize = True
        rbWaketum.Location = New Point(6, 47)
        rbWaketum.Name = "rbWaketum"
        rbWaketum.Size = New Size(127, 19)
        rbWaketum.TabIndex = 1
        rbWaketum.TabStop = True
        rbWaketum.Text = "Wakil Ketua Umum"
        rbWaketum.UseVisualStyleBackColor = True
        ' 
        ' rbKetum
        ' 
        rbKetum.AutoSize = True
        rbKetum.Location = New Point(6, 22)
        rbKetum.Name = "rbKetum"
        rbKetum.Size = New Size(95, 19)
        rbKetum.TabIndex = 0
        rbKetum.TabStop = True
        rbKetum.Text = "Ketua Umum"
        rbKetum.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(21, 46)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(114, 147)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' lblUkm
        ' 
        lblUkm.AutoSize = True
        lblUkm.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUkm.Location = New Point(219, 44)
        lblUkm.Name = "lblUkm"
        lblUkm.Size = New Size(474, 50)
        lblUkm.TabIndex = 2
        lblUkm.Text = "UKM BOLA BASKET UNMUL"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(139, 28)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(74, 80)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox2)
        Controls.Add(lblUkm)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cboDivisi As ComboBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLakiLaki As RadioButton
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents tbId As TextBox
    Friend WithEvents tbNama As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tbAlamat As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents gbPeran As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents rbKetum As RadioButton
    Friend WithEvents cboGamer As CheckBox
    Friend WithEvents cboDesginer As CheckBox
    Friend WithEvents cboBaca As CheckBox
    Friend WithEvents cboMemancing As CheckBox
    Friend WithEvents cboMusik As CheckBox
    Friend WithEvents cboLari As CheckBox
    Friend WithEvents cboCoding As CheckBox
    Friend WithEvents cboMemasak As CheckBox
    Friend WithEvents rbBendahara As RadioButton
    Friend WithEvents rbSekre As RadioButton
    Friend WithEvents rbWaketum As RadioButton
    Friend WithEvents lblSivisi As Label
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents lblTglLahir As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents mtbNoTelp As MaskedTextBox
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents lblUkm As Label
    Friend WithEvents rbSnggota As RadioButton
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBrowse As Button

End Class

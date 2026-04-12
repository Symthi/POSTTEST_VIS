<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPemain
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
        components = New ComponentModel.Container()
        TabControl1 = New TabControl()
        tabInput = New TabPage()
        btnBatal = New Button()
        btnSimpan = New Button()
        cboKlub = New ComboBox()
        nudBerat = New NumericUpDown()
        nudTinggi = New NumericUpDown()
        cboPosisi = New ComboBox()
        txtNamaPemain = New TextBox()
        txtKodePemain = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        tabData = New TabPage()
        btnRefresh = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnTambah = New Button()
        btnCari = New Button()
        dgvPemain = New DataGridView()
        txtSearch = New TextBox()
        Label7 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        btnKembali = New Button()
        TabControl1.SuspendLayout()
        tabInput.SuspendLayout()
        CType(nudBerat, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudTinggi, ComponentModel.ISupportInitialize).BeginInit()
        tabData.SuspendLayout()
        CType(dgvPemain, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabInput)
        TabControl1.Controls.Add(tabData)
        TabControl1.Location = New Point(12, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(776, 404)
        TabControl1.TabIndex = 0
        ' 
        ' tabInput
        ' 
        tabInput.Controls.Add(btnBatal)
        tabInput.Controls.Add(btnSimpan)
        tabInput.Controls.Add(cboKlub)
        tabInput.Controls.Add(nudBerat)
        tabInput.Controls.Add(nudTinggi)
        tabInput.Controls.Add(cboPosisi)
        tabInput.Controls.Add(txtNamaPemain)
        tabInput.Controls.Add(txtKodePemain)
        tabInput.Controls.Add(Label6)
        tabInput.Controls.Add(Label5)
        tabInput.Controls.Add(Label4)
        tabInput.Controls.Add(Label3)
        tabInput.Controls.Add(Label2)
        tabInput.Controls.Add(Label1)
        tabInput.Location = New Point(4, 24)
        tabInput.Name = "tabInput"
        tabInput.Padding = New Padding(3)
        tabInput.Size = New Size(768, 376)
        tabInput.TabIndex = 0
        tabInput.Text = "Input Data"
        tabInput.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(272, 343)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(64, 24)
        btnBatal.TabIndex = 13
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(100, 343)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(64, 24)
        btnSimpan.TabIndex = 12
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' cboKlub
        ' 
        cboKlub.FormattingEnabled = True
        cboKlub.Location = New Point(216, 294)
        cboKlub.Name = "cboKlub"
        cboKlub.Size = New Size(120, 23)
        cboKlub.TabIndex = 11
        ' 
        ' nudBerat
        ' 
        nudBerat.Location = New Point(216, 247)
        nudBerat.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        nudBerat.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        nudBerat.Name = "nudBerat"
        nudBerat.Size = New Size(120, 23)
        nudBerat.TabIndex = 10
        nudBerat.Value = New Decimal(New Integer() {50, 0, 0, 0})
        ' 
        ' nudTinggi
        ' 
        nudTinggi.Location = New Point(216, 201)
        nudTinggi.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
        nudTinggi.Minimum = New Decimal(New Integer() {150, 0, 0, 0})
        nudTinggi.Name = "nudTinggi"
        nudTinggi.Size = New Size(120, 23)
        nudTinggi.TabIndex = 9
        nudTinggi.Value = New Decimal(New Integer() {150, 0, 0, 0})
        ' 
        ' cboPosisi
        ' 
        cboPosisi.FormattingEnabled = True
        cboPosisi.Items.AddRange(New Object() {"Point Guard", "Shooting Guard", "Small Forward", "Power Forward", "Center"})
        cboPosisi.Location = New Point(215, 161)
        cboPosisi.Name = "cboPosisi"
        cboPosisi.Size = New Size(121, 23)
        cboPosisi.TabIndex = 8
        ' 
        ' txtNamaPemain
        ' 
        txtNamaPemain.Location = New Point(215, 124)
        txtNamaPemain.Name = "txtNamaPemain"
        txtNamaPemain.Size = New Size(121, 23)
        txtNamaPemain.TabIndex = 7
        ' 
        ' txtKodePemain
        ' 
        txtKodePemain.Location = New Point(215, 86)
        txtKodePemain.Name = "txtKodePemain"
        txtKodePemain.Size = New Size(121, 23)
        txtKodePemain.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(100, 302)
        Label6.Name = "Label6"
        Label6.Size = New Size(31, 15)
        Label6.TabIndex = 5
        Label6.Text = "Klub"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(100, 255)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 15)
        Label5.TabIndex = 4
        Label5.Text = "Berat Badan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(100, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 15)
        Label4.TabIndex = 3
        Label4.Text = "Tinggi Badan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(100, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 15)
        Label3.TabIndex = 2
        Label3.Text = "Posisi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(100, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nama Pemain"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(100, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 15)
        Label1.TabIndex = 0
        Label1.Text = "Kode Pemain"
        ' 
        ' tabData
        ' 
        tabData.Controls.Add(btnRefresh)
        tabData.Controls.Add(btnHapus)
        tabData.Controls.Add(btnUbah)
        tabData.Controls.Add(btnTambah)
        tabData.Controls.Add(btnCari)
        tabData.Controls.Add(dgvPemain)
        tabData.Controls.Add(txtSearch)
        tabData.Controls.Add(Label7)
        tabData.Location = New Point(4, 24)
        tabData.Name = "tabData"
        tabData.Padding = New Padding(3)
        tabData.Size = New Size(768, 376)
        tabData.TabIndex = 1
        tabData.Text = "Searching"
        tabData.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(395, 334)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(75, 23)
        btnRefresh.TabIndex = 7
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(300, 334)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 6
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(197, 334)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 23)
        btnUbah.TabIndex = 5
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(104, 334)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(363, 62)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(75, 23)
        btnCari.TabIndex = 3
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' dgvPemain
        ' 
        dgvPemain.BackgroundColor = Color.White
        dgvPemain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPemain.Location = New Point(104, 101)
        dgvPemain.Name = "dgvPemain"
        dgvPemain.Size = New Size(544, 214)
        dgvPemain.TabIndex = 2
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(197, 61)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(130, 23)
        txtSearch.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(104, 69)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 15)
        Label7.TabIndex = 0
        Label7.Text = "Cari Pemain"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(568, 418)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(75, 23)
        btnKembali.TabIndex = 1
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' FormPemain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKembali)
        Controls.Add(TabControl1)
        Name = "FormPemain"
        Text = "FormPemain"
        TabControl1.ResumeLayout(False)
        tabInput.ResumeLayout(False)
        tabInput.PerformLayout()
        CType(nudBerat, ComponentModel.ISupportInitialize).EndInit()
        CType(nudTinggi, ComponentModel.ISupportInitialize).EndInit()
        tabData.ResumeLayout(False)
        tabData.PerformLayout()
        CType(dgvPemain, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabInput As TabPage
    Friend WithEvents tabData As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboKlub As ComboBox
    Friend WithEvents nudBerat As NumericUpDown
    Friend WithEvents nudTinggi As NumericUpDown
    Friend WithEvents cboPosisi As ComboBox
    Friend WithEvents txtNamaPemain As TextBox
    Friend WithEvents txtKodePemain As TextBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents dgvPemain As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnKembali As Button
End Class

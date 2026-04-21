<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKlub
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
        btnSImpan = New Button()
        dtpTahunBerdiri = New DateTimePicker()
        txtKota = New TextBox()
        txtNamaKlub = New TextBox()
        txtKodeKlub = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        tabData = New TabPage()
        btnRefresh = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnTambah = New Button()
        dgvKlub = New DataGridView()
        btnCari = New Button()
        txtSearch = New TextBox()
        Label5 = New Label()
        btnKembali = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        TabControl1.SuspendLayout()
        tabInput.SuspendLayout()
        tabData.SuspendLayout()
        CType(dgvKlub, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabInput)
        TabControl1.Controls.Add(tabData)
        TabControl1.Location = New Point(13, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(776, 397)
        TabControl1.TabIndex = 0
        ' 
        ' tabInput
        ' 
        tabInput.Controls.Add(btnBatal)
        tabInput.Controls.Add(btnSImpan)
        tabInput.Controls.Add(dtpTahunBerdiri)
        tabInput.Controls.Add(txtKota)
        tabInput.Controls.Add(txtNamaKlub)
        tabInput.Controls.Add(txtKodeKlub)
        tabInput.Controls.Add(Label4)
        tabInput.Controls.Add(Label3)
        tabInput.Controls.Add(Label2)
        tabInput.Controls.Add(Label1)
        tabInput.Location = New Point(4, 24)
        tabInput.Name = "tabInput"
        tabInput.Padding = New Padding(3)
        tabInput.Size = New Size(768, 369)
        tabInput.TabIndex = 0
        tabInput.Text = "Input Data"
        tabInput.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(495, 231)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 9
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnSImpan
        ' 
        btnSImpan.Location = New Point(370, 231)
        btnSImpan.Name = "btnSImpan"
        btnSImpan.Size = New Size(75, 23)
        btnSImpan.TabIndex = 8
        btnSImpan.Text = "Simpan"
        btnSImpan.UseVisualStyleBackColor = True
        ' 
        ' dtpTahunBerdiri
        ' 
        dtpTahunBerdiri.CustomFormat = "yyyy"
        dtpTahunBerdiri.Location = New Point(370, 202)
        dtpTahunBerdiri.Name = "dtpTahunBerdiri"
        dtpTahunBerdiri.Size = New Size(200, 23)
        dtpTahunBerdiri.TabIndex = 7
        ' 
        ' txtKota
        ' 
        txtKota.Location = New Point(370, 173)
        txtKota.Name = "txtKota"
        txtKota.Size = New Size(200, 23)
        txtKota.TabIndex = 6
        ' 
        ' txtNamaKlub
        ' 
        txtNamaKlub.Location = New Point(370, 144)
        txtNamaKlub.Name = "txtNamaKlub"
        txtNamaKlub.Size = New Size(200, 23)
        txtNamaKlub.TabIndex = 5
        ' 
        ' txtKodeKlub
        ' 
        txtKodeKlub.Location = New Point(370, 115)
        txtKodeKlub.Name = "txtKodeKlub"
        txtKodeKlub.Size = New Size(200, 23)
        txtKodeKlub.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(185, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 15)
        Label4.TabIndex = 3
        Label4.Text = "Tahun Berdiri"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(185, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 2
        Label3.Text = "Asal Kota"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(185, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nama Klub"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(185, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 0
        Label1.Text = "Kode Klub"
        ' 
        ' tabData
        ' 
        tabData.Controls.Add(btnRefresh)
        tabData.Controls.Add(btnHapus)
        tabData.Controls.Add(btnUbah)
        tabData.Controls.Add(btnTambah)
        tabData.Controls.Add(dgvKlub)
        tabData.Controls.Add(btnCari)
        tabData.Controls.Add(txtSearch)
        tabData.Controls.Add(Label5)
        tabData.Location = New Point(4, 24)
        tabData.Name = "tabData"
        tabData.Padding = New Padding(3)
        tabData.Size = New Size(768, 369)
        tabData.TabIndex = 1
        tabData.Text = "Searching Data"
        tabData.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(515, 292)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(75, 23)
        btnRefresh.TabIndex = 8
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(392, 292)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(266, 292)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 23)
        btnUbah.TabIndex = 6
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(148, 292)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' dgvKlub
        ' 
        dgvKlub.BackgroundColor = Color.White
        dgvKlub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKlub.Location = New Point(148, 121)
        dgvKlub.Name = "dgvKlub"
        dgvKlub.Size = New Size(442, 165)
        dgvKlub.TabIndex = 4
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(522, 83)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(68, 25)
        btnCari.TabIndex = 3
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(224, 85)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(292, 23)
        txtSearch.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(148, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 0
        Label5.Text = "Cari Klub"
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(701, 415)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(84, 23)
        btnKembali.TabIndex = 1
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormKlub
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKembali)
        Controls.Add(TabControl1)
        Name = "FormKlub"
        Text = "Form2"
        TabControl1.ResumeLayout(False)
        tabInput.ResumeLayout(False)
        tabInput.PerformLayout()
        tabData.ResumeLayout(False)
        tabData.PerformLayout()
        CType(dgvKlub, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabInput As TabPage
    Friend WithEvents tabData As TabPage
    Friend WithEvents btnKembali As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpTahunBerdiri As DateTimePicker
    Friend WithEvents txtKota As TextBox
    Friend WithEvents txtNamaKlub As TextBox
    Friend WithEvents txtKodeKlub As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSImpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnCari As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvKlub As DataGridView
End Class

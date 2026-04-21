<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabInput = New System.Windows.Forms.TabPage()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.cboKlub = New System.Windows.Forms.ComboBox()
        Me.nudPengalaman = New System.Windows.Forms.NumericUpDown()
        Me.cboPosisi = New System.Windows.Forms.ComboBox()
        Me.txtNamaPelatih = New System.Windows.Forms.TextBox()
        Me.txtKodePelatih = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabData = New System.Windows.Forms.TabPage()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.dgvPelatih = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabInput.SuspendLayout()
        CType(Me.nudPengalaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabData.SuspendLayout()
        CType(Me.dgvPelatih, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabInput)
        Me.TabControl1.Controls.Add(Me.tabData)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 404)
        Me.TabControl1.TabIndex = 0
        '
        'tabInput
        '
        Me.tabInput.Controls.Add(Me.btnBatal)
        Me.tabInput.Controls.Add(Me.btnSimpan)
        Me.tabInput.Controls.Add(Me.cboKlub)
        Me.tabInput.Controls.Add(Me.nudPengalaman)
        Me.tabInput.Controls.Add(Me.cboPosisi)
        Me.tabInput.Controls.Add(Me.txtNamaPelatih)
        Me.tabInput.Controls.Add(Me.txtKodePelatih)
        Me.tabInput.Controls.Add(Me.Label5)
        Me.tabInput.Controls.Add(Me.Label4)
        Me.tabInput.Controls.Add(Me.Label3)
        Me.tabInput.Controls.Add(Me.Label2)
        Me.tabInput.Controls.Add(Me.Label1)
        Me.tabInput.Location = New System.Drawing.Point(4, 24)
        Me.tabInput.Name = "tabInput"
        Me.tabInput.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInput.Size = New System.Drawing.Size(768, 376)
        Me.tabInput.TabIndex = 0
        Me.tabInput.Text = "Input Data"
        Me.tabInput.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(476, 266)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(64, 24)
        Me.btnBatal.TabIndex = 13
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(354, 266)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(64, 24)
        Me.btnSimpan.TabIndex = 12
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'cboKlub
        '
        Me.cboKlub.FormattingEnabled = True
        Me.cboKlub.Location = New System.Drawing.Point(354, 237)
        Me.cboKlub.Name = "cboKlub"
        Me.cboKlub.Size = New System.Drawing.Size(186, 23)
        Me.cboKlub.TabIndex = 11
        '
        'nudPengalaman
        '
        Me.nudPengalaman.Location = New System.Drawing.Point(354, 179)
        Me.nudPengalaman.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudPengalaman.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nudPengalaman.Name = "nudPengalaman"
        Me.nudPengalaman.Size = New System.Drawing.Size(186, 23)
        Me.nudPengalaman.TabIndex = 10
        '
        'cboPosisi
        '
        Me.cboPosisi.FormattingEnabled = True
        Me.cboPosisi.Items.AddRange(New Object() {"Head Coach", "Assistant Coach", "Offensive Coordinator", "Defensive Coordinator"})
        Me.cboPosisi.Location = New System.Drawing.Point(354, 150)
        Me.cboPosisi.Name = "cboPosisi"
        Me.cboPosisi.Size = New System.Drawing.Size(186, 23)
        Me.cboPosisi.TabIndex = 8
        '
        'txtNamaPelatih
        '
        Me.txtNamaPelatih.Location = New System.Drawing.Point(354, 121)
        Me.txtNamaPelatih.Name = "txtNamaPelatih"
        Me.txtNamaPelatih.Size = New System.Drawing.Size(186, 23)
        Me.txtNamaPelatih.TabIndex = 7
        '
        'txtKodePelatih
        '
        Me.txtKodePelatih.Location = New System.Drawing.Point(354, 92)
        Me.txtKodePelatih.Name = "txtKodePelatih"
        Me.txtKodePelatih.Size = New System.Drawing.Size(186, 23)
        Me.txtKodePelatih.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(194, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Klub"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(194, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pengalaman (tahun)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Posisi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pelatih"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Pelatih"
        '
        'tabData
        '
        Me.tabData.Controls.Add(Me.btnRefresh)
        Me.tabData.Controls.Add(Me.btnHapus)
        Me.tabData.Controls.Add(Me.btnUbah)
        Me.tabData.Controls.Add(Me.btnTambah)
        Me.tabData.Controls.Add(Me.btnCari)
        Me.tabData.Controls.Add(Me.dgvPelatih)
        Me.tabData.Controls.Add(Me.txtSearch)
        Me.tabData.Controls.Add(Me.Label6)
        Me.tabData.Location = New System.Drawing.Point(4, 24)
        Me.tabData.Name = "tabData"
        Me.tabData.Padding = New System.Windows.Forms.Padding(3)
        Me.tabData.Size = New System.Drawing.Size(768, 376)
        Me.tabData.TabIndex = 1
        Me.tabData.Text = "Searching Data"
        Me.tabData.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(364, 305)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(283, 305)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 6
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(202, 305)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.TabIndex = 5
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(121, 305)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(590, 56)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 3
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'dgvPelatih
        '
        Me.dgvPelatih.BackgroundColor = System.Drawing.Color.White
        Me.dgvPelatih.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPelatih.Location = New System.Drawing.Point(121, 85)
        Me.dgvPelatih.Name = "dgvPelatih"
        Me.dgvPelatih.Size = New System.Drawing.Size(544, 214)
        Me.dgvPelatih.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(202, 56)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(382, 23)
        Me.txtSearch.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(125, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cari Pelatih"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(709, 418)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(75, 23)
        Me.btnKembali.TabIndex = 1
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'FormPelatih
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormPelatih"
        Me.Text = "Manajemen Pelatih"
        Me.TabControl1.ResumeLayout(False)
        Me.tabInput.ResumeLayout(False)
        Me.tabInput.PerformLayout()
        CType(Me.nudPengalaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabData.ResumeLayout(False)
        Me.tabData.PerformLayout()
        CType(Me.dgvPelatih, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabInput As TabPage
    Friend WithEvents tabData As TabPage
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents cboKlub As ComboBox
    Friend WithEvents nudPengalaman As NumericUpDown
    Friend WithEvents cboPosisi As ComboBox
    Friend WithEvents txtNamaPelatih As TextBox
    Friend WithEvents txtKodePelatih As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents dgvPelatih As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnKembali As Button
End Class
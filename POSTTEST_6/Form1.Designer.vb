<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenuUtama
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
        btnKlub = New Button()
        btnPemain = New Button()
        btnKeluar = New Button()
        btnPelatih = New Button()
        Me.SuspendLayout()
        '
        ' btnKlub
        '
        Me.btnKlub.Location = New System.Drawing.Point(180, 93)
        Me.btnKlub.Name = "btnKlub"
        Me.btnKlub.Size = New System.Drawing.Size(131, 23)
        Me.btnKlub.TabIndex = 0
        Me.btnKlub.Text = "Manajemen Klub"
        Me.btnKlub.UseVisualStyleBackColor = True
        '
        ' btnPemain
        '
        Me.btnPemain.Location = New System.Drawing.Point(180, 140)
        Me.btnPemain.Name = "btnPemain"
        Me.btnPemain.Size = New System.Drawing.Size(131, 23)
        Me.btnPemain.TabIndex = 1
        Me.btnPemain.Text = "Manajemen Pemain"
        Me.btnPemain.UseVisualStyleBackColor = True
        '
        ' btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(180, 230)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(131, 23)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        ' btnPelatih
        '
        Me.btnPelatih.Location = New System.Drawing.Point(180, 185)
        Me.btnPelatih.Name = "btnPelatih"
        Me.btnPelatih.Size = New System.Drawing.Size(131, 23)
        Me.btnPelatih.TabIndex = 2
        Me.btnPelatih.Text = "Manajemen Pelatih"
        Me.btnPelatih.UseVisualStyleBackColor = True
        '
        ' FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 321)
        Me.Controls.Add(Me.btnPelatih)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnPemain)
        Me.Controls.Add(Me.btnKlub)
        Me.Name = "FormMenuUtama"
        Me.Text = "Menu Utama"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnKlub As Button
    Friend WithEvents btnPemain As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnPelatih As Button
End Class
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
        SuspendLayout()
        ' 
        ' btnKlub
        ' 
        btnKlub.Location = New Point(180, 93)
        btnKlub.Name = "btnKlub"
        btnKlub.Size = New Size(131, 23)
        btnKlub.TabIndex = 0
        btnKlub.Text = "Manajemen Klub"
        btnKlub.UseVisualStyleBackColor = True
        ' 
        ' btnPemain
        ' 
        btnPemain.Location = New Point(180, 140)
        btnPemain.Name = "btnPemain"
        btnPemain.Size = New Size(131, 23)
        btnPemain.TabIndex = 1
        btnPemain.Text = "Manajemen Pemain"
        btnPemain.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(180, 189)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(131, 23)
        btnKeluar.TabIndex = 2
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' FormMenuUtama
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(516, 321)
        Controls.Add(btnKeluar)
        Controls.Add(btnPemain)
        Controls.Add(btnKlub)
        Name = "FormMenuUtama"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnKlub As Button
    Friend WithEvents btnPemain As Button
    Friend WithEvents btnKeluar As Button

End Class

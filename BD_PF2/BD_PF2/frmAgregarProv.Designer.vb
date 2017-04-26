<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarProv
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
        Dim NomEmpLabel As System.Windows.Forms.Label
        Me.txtNomProvA = New System.Windows.Forms.TextBox()
        Me.frmAceptarNProv = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        NomEmpLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomEmpLabel
        '
        NomEmpLabel.AutoSize = True
        NomEmpLabel.Location = New System.Drawing.Point(121, 13)
        NomEmpLabel.Name = "NomEmpLabel"
        NomEmpLabel.Size = New System.Drawing.Size(72, 24)
        NomEmpLabel.TabIndex = 31
        NomEmpLabel.Text = "Nombre:"
        '
        'txtNomProvA
        '
        Me.txtNomProvA.Location = New System.Drawing.Point(121, 40)
        Me.txtNomProvA.Name = "txtNomProvA"
        Me.txtNomProvA.Size = New System.Drawing.Size(198, 30)
        Me.txtNomProvA.TabIndex = 32
        '
        'frmAceptarNProv
        '
        Me.frmAceptarNProv.BackColor = System.Drawing.Color.LightSkyBlue
        Me.frmAceptarNProv.Location = New System.Drawing.Point(167, 96)
        Me.frmAceptarNProv.Name = "frmAceptarNProv"
        Me.frmAceptarNProv.Size = New System.Drawing.Size(91, 39)
        Me.frmAceptarNProv.TabIndex = 33
        Me.frmAceptarNProv.Text = "Aceptar"
        Me.frmAceptarNProv.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BD_PF2.My.Resources.Resources.proveedor
        Me.PictureBox1.Location = New System.Drawing.Point(2, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 182)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'frmAgregarProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(327, 189)
        Me.Controls.Add(Me.frmAceptarNProv)
        Me.Controls.Add(Me.txtNomProvA)
        Me.Controls.Add(NomEmpLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Architects Daughter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmAgregarProv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Proveedor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomProvA As System.Windows.Forms.TextBox
    Friend WithEvents frmAceptarNProv As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

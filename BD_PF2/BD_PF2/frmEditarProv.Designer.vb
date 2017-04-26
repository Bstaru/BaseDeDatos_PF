<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarProv
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
        Dim Label2 As System.Windows.Forms.Label
        Me.txtNomProvC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomProvBuscar = New System.Windows.Forms.TextBox()
        Me.btnAceptarBusC = New System.Windows.Forms.Button()
        Me.txtActivoProvC = New System.Windows.Forms.TextBox()
        Me.btnEditarProv = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        NomEmpLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomEmpLabel
        '
        NomEmpLabel.AutoSize = True
        NomEmpLabel.Location = New System.Drawing.Point(76, 61)
        NomEmpLabel.Name = "NomEmpLabel"
        NomEmpLabel.Size = New System.Drawing.Size(72, 24)
        NomEmpLabel.TabIndex = 34
        NomEmpLabel.Text = "Nombre:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(76, 97)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(59, 24)
        Label2.TabIndex = 66
        Label2.Text = "Activo:"
        '
        'txtNomProvC
        '
        Me.txtNomProvC.Location = New System.Drawing.Point(163, 58)
        Me.txtNomProvC.Name = "txtNomProvC"
        Me.txtNomProvC.Size = New System.Drawing.Size(198, 30)
        Me.txtNomProvC.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Buscar proveedor:"
        '
        'txtNomProvBuscar
        '
        Me.txtNomProvBuscar.Location = New System.Drawing.Point(163, 20)
        Me.txtNomProvBuscar.Margin = New System.Windows.Forms.Padding(6, 11, 6, 11)
        Me.txtNomProvBuscar.Name = "txtNomProvBuscar"
        Me.txtNomProvBuscar.Size = New System.Drawing.Size(198, 30)
        Me.txtNomProvBuscar.TabIndex = 64
        '
        'btnAceptarBusC
        '
        Me.btnAceptarBusC.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAceptarBusC.Location = New System.Drawing.Point(373, 20)
        Me.btnAceptarBusC.Margin = New System.Windows.Forms.Padding(6, 11, 6, 11)
        Me.btnAceptarBusC.Name = "btnAceptarBusC"
        Me.btnAceptarBusC.Size = New System.Drawing.Size(98, 30)
        Me.btnAceptarBusC.TabIndex = 63
        Me.btnAceptarBusC.Text = "Aceptar"
        Me.btnAceptarBusC.UseVisualStyleBackColor = False
        '
        'txtActivoProvC
        '
        Me.txtActivoProvC.Location = New System.Drawing.Point(163, 94)
        Me.txtActivoProvC.Name = "txtActivoProvC"
        Me.txtActivoProvC.Size = New System.Drawing.Size(198, 30)
        Me.txtActivoProvC.TabIndex = 67
        '
        'btnEditarProv
        '
        Me.btnEditarProv.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEditarProv.Location = New System.Drawing.Point(373, 128)
        Me.btnEditarProv.Margin = New System.Windows.Forms.Padding(6, 11, 6, 11)
        Me.btnEditarProv.Name = "btnEditarProv"
        Me.btnEditarProv.Size = New System.Drawing.Size(98, 30)
        Me.btnEditarProv.TabIndex = 68
        Me.btnEditarProv.Text = "Modificar"
        Me.btnEditarProv.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BD_PF2.My.Resources.Resources.file_edit
        Me.PictureBox1.Location = New System.Drawing.Point(385, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'frmEditarProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(480, 165)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEditarProv)
        Me.Controls.Add(Me.txtActivoProvC)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomProvBuscar)
        Me.Controls.Add(Me.btnAceptarBusC)
        Me.Controls.Add(Me.txtNomProvC)
        Me.Controls.Add(NomEmpLabel)
        Me.Font = New System.Drawing.Font("Architects Daughter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frmEditarProv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Proveedor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomProvC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomProvBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptarBusC As System.Windows.Forms.Button
    Friend WithEvents txtActivoProvC As System.Windows.Forms.TextBox
    Friend WithEvents btnEditarProv As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

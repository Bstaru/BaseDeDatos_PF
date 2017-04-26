<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarProv
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
        Dim Label2 As System.Windows.Forms.Label
        Dim NomEmpLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarProv))
        Me.txtActivoProvB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomProvBuscar = New System.Windows.Forms.TextBox()
        Me.btnAceptarBus = New System.Windows.Forms.Button()
        Me.txtNomProvB = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Label2 = New System.Windows.Forms.Label()
        NomEmpLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(84, 97)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(59, 24)
        Label2.TabIndex = 74
        Label2.Text = "Activo:"
        '
        'NomEmpLabel
        '
        NomEmpLabel.AutoSize = True
        NomEmpLabel.Location = New System.Drawing.Point(84, 61)
        NomEmpLabel.Name = "NomEmpLabel"
        NomEmpLabel.Size = New System.Drawing.Size(72, 24)
        NomEmpLabel.TabIndex = 69
        NomEmpLabel.Text = "Nombre:"
        '
        'txtActivoProvB
        '
        Me.txtActivoProvB.Location = New System.Drawing.Point(171, 94)
        Me.txtActivoProvB.Name = "txtActivoProvB"
        Me.txtActivoProvB.ReadOnly = True
        Me.txtActivoProvB.Size = New System.Drawing.Size(198, 30)
        Me.txtActivoProvB.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Buscar proveedor:"
        '
        'txtNomProvBuscar
        '
        Me.txtNomProvBuscar.Location = New System.Drawing.Point(171, 20)
        Me.txtNomProvBuscar.Margin = New System.Windows.Forms.Padding(6, 11, 6, 11)
        Me.txtNomProvBuscar.Name = "txtNomProvBuscar"
        Me.txtNomProvBuscar.Size = New System.Drawing.Size(198, 30)
        Me.txtNomProvBuscar.TabIndex = 72
        '
        'btnAceptarBus
        '
        Me.btnAceptarBus.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAceptarBus.Location = New System.Drawing.Point(381, 20)
        Me.btnAceptarBus.Margin = New System.Windows.Forms.Padding(6, 11, 6, 11)
        Me.btnAceptarBus.Name = "btnAceptarBus"
        Me.btnAceptarBus.Size = New System.Drawing.Size(98, 30)
        Me.btnAceptarBus.TabIndex = 71
        Me.btnAceptarBus.Text = "Aceptar"
        Me.btnAceptarBus.UseVisualStyleBackColor = False
        '
        'txtNomProvB
        '
        Me.txtNomProvB.Location = New System.Drawing.Point(171, 58)
        Me.txtNomProvB.Name = "txtNomProvB"
        Me.txtNomProvB.ReadOnly = True
        Me.txtNomProvB.Size = New System.Drawing.Size(198, 30)
        Me.txtNomProvB.TabIndex = 70
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(402, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 74)
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'frmBuscarProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(494, 144)
        Me.Controls.Add(Me.txtActivoProvB)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomProvBuscar)
        Me.Controls.Add(Me.btnAceptarBus)
        Me.Controls.Add(Me.txtNomProvB)
        Me.Controls.Add(NomEmpLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Architects Daughter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmBuscarProv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar proveedor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtActivoProvB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomProvBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptarBus As System.Windows.Forms.Button
    Friend WithEvents txtNomProvB As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

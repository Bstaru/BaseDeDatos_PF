<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarSubD
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
        Dim Label3 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim NomEmpLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarSubD))
        Me.txtActivoSubDB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomSubDBuscar = New System.Windows.Forms.TextBox()
        Me.btnAceptarBus = New System.Windows.Forms.Button()
        Me.txtNomSubDB = New System.Windows.Forms.TextBox()
        Me.txtEmpEnB = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Label3 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        NomEmpLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(160, 89)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(59, 24)
        Label3.TabIndex = 78
        Label3.Text = "Activo:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(3, 122)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(231, 24)
        Label1.TabIndex = 73
        Label1.Text = "Nombre empleado encargado:"
        '
        'NomEmpLabel
        '
        NomEmpLabel.AutoSize = True
        NomEmpLabel.Location = New System.Drawing.Point(161, 53)
        NomEmpLabel.Name = "NomEmpLabel"
        NomEmpLabel.Size = New System.Drawing.Size(72, 24)
        NomEmpLabel.TabIndex = 71
        NomEmpLabel.Text = "Nombre:"
        '
        'txtActivoSubDB
        '
        Me.txtActivoSubDB.Location = New System.Drawing.Point(238, 83)
        Me.txtActivoSubDB.Name = "txtActivoSubDB"
        Me.txtActivoSubDB.ReadOnly = True
        Me.txtActivoSubDB.Size = New System.Drawing.Size(198, 30)
        Me.txtActivoSubDB.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 24)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Buscar subdirección"
        '
        'txtNomSubDBuscar
        '
        Me.txtNomSubDBuscar.Location = New System.Drawing.Point(239, 3)
        Me.txtNomSubDBuscar.Margin = New System.Windows.Forms.Padding(6, 11, 6, 11)
        Me.txtNomSubDBuscar.Name = "txtNomSubDBuscar"
        Me.txtNomSubDBuscar.Size = New System.Drawing.Size(198, 30)
        Me.txtNomSubDBuscar.TabIndex = 76
        '
        'btnAceptarBus
        '
        Me.btnAceptarBus.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAceptarBus.Location = New System.Drawing.Point(449, 3)
        Me.btnAceptarBus.Margin = New System.Windows.Forms.Padding(6, 11, 6, 11)
        Me.btnAceptarBus.Name = "btnAceptarBus"
        Me.btnAceptarBus.Size = New System.Drawing.Size(98, 30)
        Me.btnAceptarBus.TabIndex = 75
        Me.btnAceptarBus.Text = "Aceptar"
        Me.btnAceptarBus.UseVisualStyleBackColor = False
        '
        'txtNomSubDB
        '
        Me.txtNomSubDB.Location = New System.Drawing.Point(239, 47)
        Me.txtNomSubDB.Name = "txtNomSubDB"
        Me.txtNomSubDB.ReadOnly = True
        Me.txtNomSubDB.Size = New System.Drawing.Size(198, 30)
        Me.txtNomSubDB.TabIndex = 72
        '
        'txtEmpEnB
        '
        Me.txtEmpEnB.Location = New System.Drawing.Point(238, 122)
        Me.txtEmpEnB.Name = "txtEmpEnB"
        Me.txtEmpEnB.ReadOnly = True
        Me.txtEmpEnB.Size = New System.Drawing.Size(198, 30)
        Me.txtEmpEnB.TabIndex = 80
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(471, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 74)
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'frmBuscarSubD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(553, 162)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtEmpEnB)
        Me.Controls.Add(Me.txtActivoSubDB)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomSubDBuscar)
        Me.Controls.Add(Me.btnAceptarBus)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtNomSubDB)
        Me.Controls.Add(NomEmpLabel)
        Me.Font = New System.Drawing.Font("Architects Daughter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmBuscarSubD"
        Me.Text = "Buscar Subdireccion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtActivoSubDB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomSubDBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptarBus As System.Windows.Forms.Button
    Friend WithEvents txtNomSubDB As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpEnB As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

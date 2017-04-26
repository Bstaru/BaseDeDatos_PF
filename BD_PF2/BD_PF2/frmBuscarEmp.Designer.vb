<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarEmp
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
        Dim APEmpLabel As System.Windows.Forms.Label
        Dim AMEmpLabel As System.Windows.Forms.Label
        Dim FeNacEmpLabel As System.Windows.Forms.Label
        Dim IdPuestoLabel As System.Windows.Forms.Label
        Dim IdSubDLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim ContEmpLabel As System.Windows.Forms.Label
        Dim NomEmpLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarEmp))
        Me.btnAceptarBus = New System.Windows.Forms.Button()
        Me.txtIDBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContB = New System.Windows.Forms.TextBox()
        Me.txtEmailB = New System.Windows.Forms.TextBox()
        Me.txtAMEmpB = New System.Windows.Forms.TextBox()
        Me.txtAPEmpB = New System.Windows.Forms.TextBox()
        Me.txtNomEmpB = New System.Windows.Forms.TextBox()
        Me.txtFeNacB = New System.Windows.Forms.TextBox()
        Me.txtFeIngB = New System.Windows.Forms.TextBox()
        Me.txtSubDB = New System.Windows.Forms.TextBox()
        Me.txtPuestoB = New System.Windows.Forms.TextBox()
        Me.txtRolB = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        APEmpLabel = New System.Windows.Forms.Label()
        AMEmpLabel = New System.Windows.Forms.Label()
        FeNacEmpLabel = New System.Windows.Forms.Label()
        IdPuestoLabel = New System.Windows.Forms.Label()
        IdSubDLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        ContEmpLabel = New System.Windows.Forms.Label()
        NomEmpLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'APEmpLabel
        '
        APEmpLabel.AutoSize = True
        APEmpLabel.Location = New System.Drawing.Point(12, 96)
        APEmpLabel.Name = "APEmpLabel"
        APEmpLabel.Size = New System.Drawing.Size(133, 24)
        APEmpLabel.TabIndex = 35
        APEmpLabel.Text = "Apellido Paterno:"
        '
        'AMEmpLabel
        '
        AMEmpLabel.AutoSize = True
        AMEmpLabel.Location = New System.Drawing.Point(12, 132)
        AMEmpLabel.Name = "AMEmpLabel"
        AMEmpLabel.Size = New System.Drawing.Size(136, 24)
        AMEmpLabel.TabIndex = 36
        AMEmpLabel.Text = "Apellido Materno:"
        '
        'FeNacEmpLabel
        '
        FeNacEmpLabel.AutoSize = True
        FeNacEmpLabel.Location = New System.Drawing.Point(12, 173)
        FeNacEmpLabel.Name = "FeNacEmpLabel"
        FeNacEmpLabel.Size = New System.Drawing.Size(168, 24)
        FeNacEmpLabel.TabIndex = 37
        FeNacEmpLabel.Text = "Fecha de Nacimiento:"
        '
        'IdPuestoLabel
        '
        IdPuestoLabel.AutoSize = True
        IdPuestoLabel.Location = New System.Drawing.Point(12, 249)
        IdPuestoLabel.Name = "IdPuestoLabel"
        IdPuestoLabel.Size = New System.Drawing.Size(64, 24)
        IdPuestoLabel.TabIndex = 38
        IdPuestoLabel.Text = "Puesto:"
        '
        'IdSubDLabel
        '
        IdSubDLabel.AutoSize = True
        IdSubDLabel.Location = New System.Drawing.Point(12, 321)
        IdSubDLabel.Name = "IdSubDLabel"
        IdSubDLabel.Size = New System.Drawing.Size(107, 24)
        IdSubDLabel.TabIndex = 39
        IdSubDLabel.Text = "Subdireccion:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(12, 362)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(49, 24)
        EmailLabel.TabIndex = 40
        EmailLabel.Text = "Email:"
        '
        'ContEmpLabel
        '
        ContEmpLabel.AutoSize = True
        ContEmpLabel.Location = New System.Drawing.Point(12, 400)
        ContEmpLabel.Name = "ContEmpLabel"
        ContEmpLabel.Size = New System.Drawing.Size(99, 24)
        ContEmpLabel.TabIndex = 41
        ContEmpLabel.Text = "Contraseña:"
        '
        'NomEmpLabel
        '
        NomEmpLabel.AutoSize = True
        NomEmpLabel.Location = New System.Drawing.Point(12, 60)
        NomEmpLabel.Name = "NomEmpLabel"
        NomEmpLabel.Size = New System.Drawing.Size(72, 24)
        NomEmpLabel.TabIndex = 50
        NomEmpLabel.Text = "Nombre:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 208)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(143, 24)
        Label2.TabIndex = 51
        Label2.Text = "Fecha de Ingreso:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(12, 286)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(37, 24)
        Label3.TabIndex = 52
        Label3.Text = "Rol:"
        '
        'btnAceptarBus
        '
        Me.btnAceptarBus.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAceptarBus.Location = New System.Drawing.Point(392, 4)
        Me.btnAceptarBus.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAceptarBus.Name = "btnAceptarBus"
        Me.btnAceptarBus.Size = New System.Drawing.Size(112, 30)
        Me.btnAceptarBus.TabIndex = 0
        Me.btnAceptarBus.Text = "Aceptar"
        Me.btnAceptarBus.UseVisualStyleBackColor = False
        '
        'txtIDBuscar
        '
        Me.txtIDBuscar.Location = New System.Drawing.Point(186, 4)
        Me.txtIDBuscar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtIDBuscar.Name = "txtIDBuscar"
        Me.txtIDBuscar.Size = New System.Drawing.Size(198, 30)
        Me.txtIDBuscar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar Empleado:"
        '
        'txtContB
        '
        Me.txtContB.Enabled = False
        Me.txtContB.Location = New System.Drawing.Point(186, 394)
        Me.txtContB.Name = "txtContB"
        Me.txtContB.ReadOnly = True
        Me.txtContB.Size = New System.Drawing.Size(200, 30)
        Me.txtContB.TabIndex = 49
        '
        'txtEmailB
        '
        Me.txtEmailB.Enabled = False
        Me.txtEmailB.Location = New System.Drawing.Point(186, 358)
        Me.txtEmailB.Name = "txtEmailB"
        Me.txtEmailB.ReadOnly = True
        Me.txtEmailB.Size = New System.Drawing.Size(200, 30)
        Me.txtEmailB.TabIndex = 48
        '
        'txtAMEmpB
        '
        Me.txtAMEmpB.Enabled = False
        Me.txtAMEmpB.Location = New System.Drawing.Point(186, 130)
        Me.txtAMEmpB.Name = "txtAMEmpB"
        Me.txtAMEmpB.ReadOnly = True
        Me.txtAMEmpB.Size = New System.Drawing.Size(198, 30)
        Me.txtAMEmpB.TabIndex = 47
        '
        'txtAPEmpB
        '
        Me.txtAPEmpB.Enabled = False
        Me.txtAPEmpB.Location = New System.Drawing.Point(186, 94)
        Me.txtAPEmpB.Name = "txtAPEmpB"
        Me.txtAPEmpB.ReadOnly = True
        Me.txtAPEmpB.Size = New System.Drawing.Size(198, 30)
        Me.txtAPEmpB.TabIndex = 46
        '
        'txtNomEmpB
        '
        Me.txtNomEmpB.Enabled = False
        Me.txtNomEmpB.Location = New System.Drawing.Point(186, 58)
        Me.txtNomEmpB.Name = "txtNomEmpB"
        Me.txtNomEmpB.ReadOnly = True
        Me.txtNomEmpB.Size = New System.Drawing.Size(198, 30)
        Me.txtNomEmpB.TabIndex = 45
        '
        'txtFeNacB
        '
        Me.txtFeNacB.Enabled = False
        Me.txtFeNacB.Location = New System.Drawing.Point(186, 173)
        Me.txtFeNacB.Name = "txtFeNacB"
        Me.txtFeNacB.ReadOnly = True
        Me.txtFeNacB.Size = New System.Drawing.Size(198, 30)
        Me.txtFeNacB.TabIndex = 53
        '
        'txtFeIngB
        '
        Me.txtFeIngB.Enabled = False
        Me.txtFeIngB.Location = New System.Drawing.Point(186, 209)
        Me.txtFeIngB.Name = "txtFeIngB"
        Me.txtFeIngB.ReadOnly = True
        Me.txtFeIngB.Size = New System.Drawing.Size(198, 30)
        Me.txtFeIngB.TabIndex = 54
        '
        'txtSubDB
        '
        Me.txtSubDB.Enabled = False
        Me.txtSubDB.Location = New System.Drawing.Point(186, 316)
        Me.txtSubDB.Name = "txtSubDB"
        Me.txtSubDB.ReadOnly = True
        Me.txtSubDB.Size = New System.Drawing.Size(198, 30)
        Me.txtSubDB.TabIndex = 55
        '
        'txtPuestoB
        '
        Me.txtPuestoB.Enabled = False
        Me.txtPuestoB.Location = New System.Drawing.Point(186, 246)
        Me.txtPuestoB.Name = "txtPuestoB"
        Me.txtPuestoB.ReadOnly = True
        Me.txtPuestoB.Size = New System.Drawing.Size(198, 30)
        Me.txtPuestoB.TabIndex = 56
        '
        'txtRolB
        '
        Me.txtRolB.Enabled = False
        Me.txtRolB.Location = New System.Drawing.Point(186, 280)
        Me.txtRolB.Name = "txtRolB"
        Me.txtRolB.ReadOnly = True
        Me.txtRolB.Size = New System.Drawing.Size(198, 30)
        Me.txtRolB.TabIndex = 57
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(422, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 74)
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'frmBuscarEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(509, 434)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtRolB)
        Me.Controls.Add(Me.txtPuestoB)
        Me.Controls.Add(Me.txtSubDB)
        Me.Controls.Add(Me.txtFeIngB)
        Me.Controls.Add(Me.txtFeNacB)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(NomEmpLabel)
        Me.Controls.Add(Me.txtContB)
        Me.Controls.Add(Me.txtEmailB)
        Me.Controls.Add(Me.txtAMEmpB)
        Me.Controls.Add(Me.txtAPEmpB)
        Me.Controls.Add(Me.txtNomEmpB)
        Me.Controls.Add(APEmpLabel)
        Me.Controls.Add(AMEmpLabel)
        Me.Controls.Add(FeNacEmpLabel)
        Me.Controls.Add(IdPuestoLabel)
        Me.Controls.Add(IdSubDLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(ContEmpLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIDBuscar)
        Me.Controls.Add(Me.btnAceptarBus)
        Me.Font = New System.Drawing.Font("Architects Daughter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmBuscarEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptarBus As System.Windows.Forms.Button
    Friend WithEvents txtIDBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtContB As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailB As System.Windows.Forms.TextBox
    Friend WithEvents txtAMEmpB As System.Windows.Forms.TextBox
    Friend WithEvents txtAPEmpB As System.Windows.Forms.TextBox
    Friend WithEvents txtNomEmpB As System.Windows.Forms.TextBox
    Friend WithEvents txtFeNacB As System.Windows.Forms.TextBox
    Friend WithEvents txtFeIngB As System.Windows.Forms.TextBox
    Friend WithEvents txtSubDB As System.Windows.Forms.TextBox
    Friend WithEvents txtPuestoB As System.Windows.Forms.TextBox
    Friend WithEvents txtRolB As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

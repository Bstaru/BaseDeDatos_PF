<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarEmp
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
        Me.components = New System.ComponentModel.Container()
        Dim NomEmpLabel As System.Windows.Forms.Label
        Dim APEmpLabel As System.Windows.Forms.Label
        Dim AMEmpLabel As System.Windows.Forms.Label
        Dim FeNacEmpLabel As System.Windows.Forms.Label
        Dim IdPuestoLabel As System.Windows.Forms.Label
        Dim ContEmpLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim IdSubDLabel As System.Windows.Forms.Label
        Me.cbPuestoNuevo = New System.Windows.Forms.ComboBox()
        Me.TblPuesto2BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Tablas = New BD_PF2.DataSet_Tablas()
        Me.TblPuesto2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSubDEmpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSubdireccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.frmAceptarNuevo = New System.Windows.Forms.Button()
        Me.dtpFeNacEmpA = New System.Windows.Forms.DateTimePicker()
        Me.txtNomEmpA = New System.Windows.Forms.TextBox()
        Me.txtAPEmpA = New System.Windows.Forms.TextBox()
        Me.txtAMEmpA = New System.Windows.Forms.TextBox()
        Me.TblPuesto2TableAdapter = New BD_PF2.DataSet_TablasTableAdapters.tblPuesto2TableAdapter()
        Me.TblSubdireccionTableAdapter = New BD_PF2.DataSet_TablasTableAdapters.tblSubdireccionTableAdapter()
        Me.TblSubD_EmpTableAdapter = New BD_PF2.DataSet_TablasTableAdapters.tblSubD_EmpTableAdapter()
        Me.cbSubDNuevo = New System.Windows.Forms.ComboBox()
        Me.txtEmailA = New System.Windows.Forms.TextBox()
        Me.txtContA = New System.Windows.Forms.TextBox()
        Me.rbEmpleadoA = New System.Windows.Forms.RadioButton()
        Me.rbContaA = New System.Windows.Forms.RadioButton()
        Me.rbAdminA = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TblEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmpleadoTableAdapter = New BD_PF2.DataSet_TablasTableAdapters.tblEmpleadoTableAdapter()
        Me.TblEmpleadoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        NomEmpLabel = New System.Windows.Forms.Label()
        APEmpLabel = New System.Windows.Forms.Label()
        AMEmpLabel = New System.Windows.Forms.Label()
        FeNacEmpLabel = New System.Windows.Forms.Label()
        IdPuestoLabel = New System.Windows.Forms.Label()
        ContEmpLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        IdSubDLabel = New System.Windows.Forms.Label()
        CType(Me.TblPuesto2BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Tablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPuesto2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSubDEmpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSubdireccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomEmpLabel
        '
        NomEmpLabel.AutoSize = True
        NomEmpLabel.Location = New System.Drawing.Point(244, 18)
        NomEmpLabel.Name = "NomEmpLabel"
        NomEmpLabel.Size = New System.Drawing.Size(72, 24)
        NomEmpLabel.TabIndex = 3
        NomEmpLabel.Text = "Nombre:"
        '
        'APEmpLabel
        '
        APEmpLabel.AutoSize = True
        APEmpLabel.Location = New System.Drawing.Point(183, 54)
        APEmpLabel.Name = "APEmpLabel"
        APEmpLabel.Size = New System.Drawing.Size(133, 24)
        APEmpLabel.TabIndex = 5
        APEmpLabel.Text = "Apellido Paterno:"
        '
        'AMEmpLabel
        '
        AMEmpLabel.AutoSize = True
        AMEmpLabel.Location = New System.Drawing.Point(180, 90)
        AMEmpLabel.Name = "AMEmpLabel"
        AMEmpLabel.Size = New System.Drawing.Size(136, 24)
        AMEmpLabel.TabIndex = 7
        AMEmpLabel.Text = "Apellido Materno:"
        '
        'FeNacEmpLabel
        '
        FeNacEmpLabel.AutoSize = True
        FeNacEmpLabel.Location = New System.Drawing.Point(148, 125)
        FeNacEmpLabel.Name = "FeNacEmpLabel"
        FeNacEmpLabel.Size = New System.Drawing.Size(168, 24)
        FeNacEmpLabel.TabIndex = 9
        FeNacEmpLabel.Text = "Fecha de Nacimiento:"
        '
        'IdPuestoLabel
        '
        IdPuestoLabel.AutoSize = True
        IdPuestoLabel.Location = New System.Drawing.Point(252, 167)
        IdPuestoLabel.Name = "IdPuestoLabel"
        IdPuestoLabel.Size = New System.Drawing.Size(64, 24)
        IdPuestoLabel.TabIndex = 13
        IdPuestoLabel.Text = "Puesto:"
        '
        'ContEmpLabel
        '
        ContEmpLabel.AutoSize = True
        ContEmpLabel.Location = New System.Drawing.Point(217, 360)
        ContEmpLabel.Name = "ContEmpLabel"
        ContEmpLabel.Size = New System.Drawing.Size(99, 24)
        ContEmpLabel.TabIndex = 23
        ContEmpLabel.Text = "Contraseña:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(267, 327)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(49, 24)
        EmailLabel.TabIndex = 21
        EmailLabel.Text = "Email:"
        '
        'IdSubDLabel
        '
        IdSubDLabel.AutoSize = True
        IdSubDLabel.Location = New System.Drawing.Point(209, 205)
        IdSubDLabel.Name = "IdSubDLabel"
        IdSubDLabel.Size = New System.Drawing.Size(107, 24)
        IdSubDLabel.TabIndex = 15
        IdSubDLabel.Text = "Subdireccion:"
        '
        'cbPuestoNuevo
        '
        Me.cbPuestoNuevo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblPuesto2BindingSource1, "IdPuesto", True))
        Me.cbPuestoNuevo.DataSource = Me.TblPuesto2BindingSource
        Me.cbPuestoNuevo.DisplayMember = "NomPuesto"
        Me.cbPuestoNuevo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.cbPuestoNuevo.FormattingEnabled = True
        Me.cbPuestoNuevo.Location = New System.Drawing.Point(322, 164)
        Me.cbPuestoNuevo.Name = "cbPuestoNuevo"
        Me.cbPuestoNuevo.Size = New System.Drawing.Size(198, 32)
        Me.cbPuestoNuevo.TabIndex = 25
        Me.cbPuestoNuevo.ValueMember = "IdPuesto"
        '
        'TblPuesto2BindingSource1
        '
        Me.TblPuesto2BindingSource1.DataMember = "tblPuesto2"
        Me.TblPuesto2BindingSource1.DataSource = Me.DataSet_Tablas
        '
        'DataSet_Tablas
        '
        Me.DataSet_Tablas.DataSetName = "DataSet_Tablas"
        Me.DataSet_Tablas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPuesto2BindingSource
        '
        Me.TblPuesto2BindingSource.DataMember = "tblPuesto2"
        Me.TblPuesto2BindingSource.DataSource = Me.DataSet_Tablas
        '
        'TblSubDEmpBindingSource
        '
        Me.TblSubDEmpBindingSource.DataMember = "tblSubD-Emp"
        Me.TblSubDEmpBindingSource.DataSource = Me.DataSet_Tablas
        '
        'TblSubdireccionBindingSource
        '
        Me.TblSubdireccionBindingSource.DataMember = "tblSubdireccion"
        Me.TblSubdireccionBindingSource.DataSource = Me.DataSet_Tablas
        '
        'frmAceptarNuevo
        '
        Me.frmAceptarNuevo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.frmAceptarNuevo.Location = New System.Drawing.Point(538, 348)
        Me.frmAceptarNuevo.Name = "frmAceptarNuevo"
        Me.frmAceptarNuevo.Size = New System.Drawing.Size(91, 39)
        Me.frmAceptarNuevo.TabIndex = 28
        Me.frmAceptarNuevo.Text = "Aceptar"
        Me.frmAceptarNuevo.UseVisualStyleBackColor = False
        '
        'dtpFeNacEmpA
        '
        Me.dtpFeNacEmpA.Location = New System.Drawing.Point(322, 126)
        Me.dtpFeNacEmpA.Name = "dtpFeNacEmpA"
        Me.dtpFeNacEmpA.Size = New System.Drawing.Size(198, 30)
        Me.dtpFeNacEmpA.TabIndex = 29
        '
        'txtNomEmpA
        '
        Me.txtNomEmpA.Location = New System.Drawing.Point(322, 12)
        Me.txtNomEmpA.Name = "txtNomEmpA"
        Me.txtNomEmpA.Size = New System.Drawing.Size(198, 30)
        Me.txtNomEmpA.TabIndex = 30
        '
        'txtAPEmpA
        '
        Me.txtAPEmpA.Location = New System.Drawing.Point(322, 48)
        Me.txtAPEmpA.Name = "txtAPEmpA"
        Me.txtAPEmpA.Size = New System.Drawing.Size(198, 30)
        Me.txtAPEmpA.TabIndex = 31
        '
        'txtAMEmpA
        '
        Me.txtAMEmpA.Location = New System.Drawing.Point(322, 84)
        Me.txtAMEmpA.Name = "txtAMEmpA"
        Me.txtAMEmpA.Size = New System.Drawing.Size(198, 30)
        Me.txtAMEmpA.TabIndex = 32
        '
        'TblPuesto2TableAdapter
        '
        Me.TblPuesto2TableAdapter.ClearBeforeFill = True
        '
        'TblSubdireccionTableAdapter
        '
        Me.TblSubdireccionTableAdapter.ClearBeforeFill = True
        '
        'TblSubD_EmpTableAdapter
        '
        Me.TblSubD_EmpTableAdapter.ClearBeforeFill = True
        '
        'cbSubDNuevo
        '
        Me.cbSubDNuevo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblSubDEmpBindingSource, "IdSubD", True))
        Me.cbSubDNuevo.DataSource = Me.TblSubdireccionBindingSource
        Me.cbSubDNuevo.DisplayMember = "NomSubD"
        Me.cbSubDNuevo.FormattingEnabled = True
        Me.cbSubDNuevo.Location = New System.Drawing.Point(322, 202)
        Me.cbSubDNuevo.Name = "cbSubDNuevo"
        Me.cbSubDNuevo.Size = New System.Drawing.Size(200, 32)
        Me.cbSubDNuevo.TabIndex = 26
        Me.cbSubDNuevo.ValueMember = "IdSubD"
        '
        'txtEmailA
        '
        Me.txtEmailA.Location = New System.Drawing.Point(322, 321)
        Me.txtEmailA.Name = "txtEmailA"
        Me.txtEmailA.Size = New System.Drawing.Size(200, 30)
        Me.txtEmailA.TabIndex = 33
        '
        'txtContA
        '
        Me.txtContA.Location = New System.Drawing.Point(322, 357)
        Me.txtContA.Name = "txtContA"
        Me.txtContA.Size = New System.Drawing.Size(200, 30)
        Me.txtContA.TabIndex = 34
        '
        'rbEmpleadoA
        '
        Me.rbEmpleadoA.AutoSize = True
        Me.rbEmpleadoA.Location = New System.Drawing.Point(6, 37)
        Me.rbEmpleadoA.Name = "rbEmpleadoA"
        Me.rbEmpleadoA.Size = New System.Drawing.Size(97, 28)
        Me.rbEmpleadoA.TabIndex = 0
        Me.rbEmpleadoA.TabStop = True
        Me.rbEmpleadoA.Text = "Empleado"
        Me.rbEmpleadoA.UseVisualStyleBackColor = True
        '
        'rbContaA
        '
        Me.rbContaA.AutoSize = True
        Me.rbContaA.Location = New System.Drawing.Point(98, 38)
        Me.rbContaA.Name = "rbContaA"
        Me.rbContaA.Size = New System.Drawing.Size(112, 28)
        Me.rbContaA.TabIndex = 1
        Me.rbContaA.TabStop = True
        Me.rbContaA.Text = "Contabilidad"
        Me.rbContaA.UseVisualStyleBackColor = True
        '
        'rbAdminA
        '
        Me.rbAdminA.AutoSize = True
        Me.rbAdminA.Location = New System.Drawing.Point(205, 38)
        Me.rbAdminA.Name = "rbAdminA"
        Me.rbAdminA.Size = New System.Drawing.Size(132, 28)
        Me.rbAdminA.TabIndex = 2
        Me.rbAdminA.TabStop = True
        Me.rbAdminA.Text = "Administración"
        Me.rbAdminA.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.rbAdminA)
        Me.GroupBox1.Controls.Add(Me.rbContaA)
        Me.GroupBox1.Controls.Add(Me.rbEmpleadoA)
        Me.GroupBox1.Location = New System.Drawing.Point(185, 243)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 72)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rol:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BD_PF2.My.Resources.Resources.empleado
        Me.PictureBox1.Location = New System.Drawing.Point(1, 197)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 187)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'TblEmpleadoBindingSource
        '
        Me.TblEmpleadoBindingSource.DataMember = "tblEmpleado"
        Me.TblEmpleadoBindingSource.DataSource = Me.DataSet_Tablas
        '
        'TblEmpleadoTableAdapter
        '
        Me.TblEmpleadoTableAdapter.ClearBeforeFill = True
        '
        'TblEmpleadoBindingSource1
        '
        Me.TblEmpleadoBindingSource1.DataMember = "tblEmpleado"
        Me.TblEmpleadoBindingSource1.DataSource = Me.DataSet_Tablas
        '
        'frmAgregarEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(641, 396)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtContA)
        Me.Controls.Add(Me.txtEmailA)
        Me.Controls.Add(Me.txtAMEmpA)
        Me.Controls.Add(Me.txtAPEmpA)
        Me.Controls.Add(Me.txtNomEmpA)
        Me.Controls.Add(Me.dtpFeNacEmpA)
        Me.Controls.Add(Me.frmAceptarNuevo)
        Me.Controls.Add(Me.cbSubDNuevo)
        Me.Controls.Add(Me.cbPuestoNuevo)
        Me.Controls.Add(NomEmpLabel)
        Me.Controls.Add(APEmpLabel)
        Me.Controls.Add(AMEmpLabel)
        Me.Controls.Add(FeNacEmpLabel)
        Me.Controls.Add(IdPuestoLabel)
        Me.Controls.Add(IdSubDLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(ContEmpLabel)
        Me.Font = New System.Drawing.Font("Architects Daughter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmAgregarEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Empleado"
        CType(Me.TblPuesto2BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Tablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPuesto2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSubDEmpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSubdireccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbPuestoNuevo As System.Windows.Forms.ComboBox
    Friend WithEvents frmAceptarNuevo As System.Windows.Forms.Button
    Friend WithEvents dtpFeNacEmpA As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNomEmpA As System.Windows.Forms.TextBox
    Friend WithEvents txtAPEmpA As System.Windows.Forms.TextBox
    Friend WithEvents txtAMEmpA As System.Windows.Forms.TextBox
    Friend WithEvents DataSet_Tablas As BD_PF2.DataSet_Tablas
    Friend WithEvents TblPuesto2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPuesto2TableAdapter As BD_PF2.DataSet_TablasTableAdapters.tblPuesto2TableAdapter
    Friend WithEvents TblPuesto2BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblSubdireccionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSubdireccionTableAdapter As BD_PF2.DataSet_TablasTableAdapters.tblSubdireccionTableAdapter
    Friend WithEvents TblSubDEmpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSubD_EmpTableAdapter As BD_PF2.DataSet_TablasTableAdapters.tblSubD_EmpTableAdapter
    Friend WithEvents cbSubDNuevo As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmailA As System.Windows.Forms.TextBox
    Friend WithEvents txtContA As System.Windows.Forms.TextBox
    Friend WithEvents rbEmpleadoA As System.Windows.Forms.RadioButton
    Friend WithEvents rbContaA As System.Windows.Forms.RadioButton
    Friend WithEvents rbAdminA As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TblEmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmpleadoTableAdapter As BD_PF2.DataSet_TablasTableAdapters.tblEmpleadoTableAdapter
    Friend WithEvents TblEmpleadoBindingSource1 As System.Windows.Forms.BindingSource
End Class

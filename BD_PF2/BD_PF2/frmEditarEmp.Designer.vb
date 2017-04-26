<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarEmp
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
        Dim IdSubDLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim ContEmpLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomEmpBuscar = New System.Windows.Forms.TextBox()
        Me.btnAceptarBusC = New System.Windows.Forms.Button()
        Me.txtAMEmpC = New System.Windows.Forms.TextBox()
        Me.txtAPEmpC = New System.Windows.Forms.TextBox()
        Me.txtNomEmpC = New System.Windows.Forms.TextBox()
        Me.dtpFeNacEmpC = New System.Windows.Forms.DateTimePicker()
        Me.cbPuestoC = New System.Windows.Forms.ComboBox()
        Me.TblPuesto2BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Tablas = New BD_PF2.DataSet_Tablas()
        Me.TblPuesto2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbAdminC = New System.Windows.Forms.RadioButton()
        Me.rbContaC = New System.Windows.Forms.RadioButton()
        Me.rbEmpleadoC = New System.Windows.Forms.RadioButton()
        Me.txtContC = New System.Windows.Forms.TextBox()
        Me.txtEmailC = New System.Windows.Forms.TextBox()
        Me.cbSubDC = New System.Windows.Forms.ComboBox()
        Me.TblSubdireccionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSubdireccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPuesto2TableAdapter = New BD_PF2.DataSet_TablasTableAdapters.tblPuesto2TableAdapter()
        Me.TblSubdireccionTableAdapter = New BD_PF2.DataSet_TablasTableAdapters.tblSubdireccionTableAdapter()
        Me.dtpFeIngEmpM = New System.Windows.Forms.DateTimePicker()
        Me.txtActivoM = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        NomEmpLabel = New System.Windows.Forms.Label()
        APEmpLabel = New System.Windows.Forms.Label()
        AMEmpLabel = New System.Windows.Forms.Label()
        FeNacEmpLabel = New System.Windows.Forms.Label()
        IdPuestoLabel = New System.Windows.Forms.Label()
        IdSubDLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        ContEmpLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.TblPuesto2BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Tablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPuesto2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblSubdireccionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSubdireccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomEmpLabel
        '
        NomEmpLabel.AutoSize = True
        NomEmpLabel.Location = New System.Drawing.Point(5, 44)
        NomEmpLabel.Name = "NomEmpLabel"
        NomEmpLabel.Size = New System.Drawing.Size(72, 24)
        NomEmpLabel.TabIndex = 63
        NomEmpLabel.Text = "Nombre:"
        '
        'APEmpLabel
        '
        APEmpLabel.AutoSize = True
        APEmpLabel.Location = New System.Drawing.Point(5, 83)
        APEmpLabel.Name = "APEmpLabel"
        APEmpLabel.Size = New System.Drawing.Size(133, 24)
        APEmpLabel.TabIndex = 64
        APEmpLabel.Text = "Apellido Paterno:"
        '
        'AMEmpLabel
        '
        AMEmpLabel.AutoSize = True
        AMEmpLabel.Location = New System.Drawing.Point(2, 125)
        AMEmpLabel.Name = "AMEmpLabel"
        AMEmpLabel.Size = New System.Drawing.Size(136, 24)
        AMEmpLabel.TabIndex = 65
        AMEmpLabel.Text = "Apellido Materno:"
        '
        'FeNacEmpLabel
        '
        FeNacEmpLabel.AutoSize = True
        FeNacEmpLabel.Location = New System.Drawing.Point(5, 163)
        FeNacEmpLabel.Name = "FeNacEmpLabel"
        FeNacEmpLabel.Size = New System.Drawing.Size(168, 24)
        FeNacEmpLabel.TabIndex = 69
        FeNacEmpLabel.Text = "Fecha de Nacimiento:"
        '
        'IdPuestoLabel
        '
        IdPuestoLabel.AutoSize = True
        IdPuestoLabel.Location = New System.Drawing.Point(5, 241)
        IdPuestoLabel.Name = "IdPuestoLabel"
        IdPuestoLabel.Size = New System.Drawing.Size(64, 24)
        IdPuestoLabel.TabIndex = 70
        IdPuestoLabel.Text = "Puesto:"
        '
        'IdSubDLabel
        '
        IdSubDLabel.AutoSize = True
        IdSubDLabel.Location = New System.Drawing.Point(385, 45)
        IdSubDLabel.Name = "IdSubDLabel"
        IdSubDLabel.Size = New System.Drawing.Size(107, 24)
        IdSubDLabel.TabIndex = 73
        IdSubDLabel.Text = "Subdireccion:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(387, 205)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(49, 24)
        EmailLabel.TabIndex = 74
        EmailLabel.Text = "Email:"
        '
        'ContEmpLabel
        '
        ContEmpLabel.AutoSize = True
        ContEmpLabel.Location = New System.Drawing.Point(387, 241)
        ContEmpLabel.Name = "ContEmpLabel"
        ContEmpLabel.Size = New System.Drawing.Size(99, 24)
        ContEmpLabel.TabIndex = 75
        ContEmpLabel.Text = "Contraseña:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(5, 201)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(143, 24)
        Label2.TabIndex = 80
        Label2.Text = "Fecha de Ingreso:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(387, 169)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(59, 24)
        Label3.TabIndex = 82
        Label3.Text = "Activo:"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEditar.Location = New System.Drawing.Point(600, 302)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(6, 11, 6, 11)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(98, 30)
        Me.btnEditar.TabIndex = 59
        Me.btnEditar.Text = "Modificar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Buscar Empleado:"
        '
        'txtNomEmpBuscar
        '
        Me.txtNomEmpBuscar.Location = New System.Drawing.Point(179, 6)
        Me.txtNomEmpBuscar.Margin = New System.Windows.Forms.Padding(6, 11, 6, 11)
        Me.txtNomEmpBuscar.Name = "txtNomEmpBuscar"
        Me.txtNomEmpBuscar.Size = New System.Drawing.Size(198, 30)
        Me.txtNomEmpBuscar.TabIndex = 61
        '
        'btnAceptarBusC
        '
        Me.btnAceptarBusC.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAceptarBusC.Location = New System.Drawing.Point(389, 6)
        Me.btnAceptarBusC.Margin = New System.Windows.Forms.Padding(6, 11, 6, 11)
        Me.btnAceptarBusC.Name = "btnAceptarBusC"
        Me.btnAceptarBusC.Size = New System.Drawing.Size(88, 30)
        Me.btnAceptarBusC.TabIndex = 60
        Me.btnAceptarBusC.Text = "Aceptar"
        Me.btnAceptarBusC.UseVisualStyleBackColor = False
        '
        'txtAMEmpC
        '
        Me.txtAMEmpC.Location = New System.Drawing.Point(179, 119)
        Me.txtAMEmpC.Name = "txtAMEmpC"
        Me.txtAMEmpC.Size = New System.Drawing.Size(198, 30)
        Me.txtAMEmpC.TabIndex = 68
        '
        'txtAPEmpC
        '
        Me.txtAPEmpC.Location = New System.Drawing.Point(179, 83)
        Me.txtAPEmpC.Name = "txtAPEmpC"
        Me.txtAPEmpC.Size = New System.Drawing.Size(198, 30)
        Me.txtAPEmpC.TabIndex = 67
        '
        'txtNomEmpC
        '
        Me.txtNomEmpC.Location = New System.Drawing.Point(179, 42)
        Me.txtNomEmpC.Name = "txtNomEmpC"
        Me.txtNomEmpC.Size = New System.Drawing.Size(198, 30)
        Me.txtNomEmpC.TabIndex = 66
        '
        'dtpFeNacEmpC
        '
        Me.dtpFeNacEmpC.Location = New System.Drawing.Point(179, 164)
        Me.dtpFeNacEmpC.Name = "dtpFeNacEmpC"
        Me.dtpFeNacEmpC.Size = New System.Drawing.Size(198, 30)
        Me.dtpFeNacEmpC.TabIndex = 72
        '
        'cbPuestoC
        '
        Me.cbPuestoC.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblPuesto2BindingSource1, "IdPuesto", True))
        Me.cbPuestoC.DataSource = Me.TblPuesto2BindingSource
        Me.cbPuestoC.DisplayMember = "NomPuesto"
        Me.cbPuestoC.ForeColor = System.Drawing.SystemColors.InfoText
        Me.cbPuestoC.FormattingEnabled = True
        Me.cbPuestoC.Location = New System.Drawing.Point(179, 238)
        Me.cbPuestoC.Name = "cbPuestoC"
        Me.cbPuestoC.Size = New System.Drawing.Size(198, 32)
        Me.cbPuestoC.TabIndex = 71
        Me.cbPuestoC.ValueMember = "IdPuesto"
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.rbAdminC)
        Me.GroupBox1.Controls.Add(Me.rbContaC)
        Me.GroupBox1.Controls.Add(Me.rbEmpleadoC)
        Me.GroupBox1.Location = New System.Drawing.Point(383, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 72)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rol:"
        '
        'rbAdminC
        '
        Me.rbAdminC.AutoSize = True
        Me.rbAdminC.Location = New System.Drawing.Point(205, 38)
        Me.rbAdminC.Name = "rbAdminC"
        Me.rbAdminC.Size = New System.Drawing.Size(132, 28)
        Me.rbAdminC.TabIndex = 2
        Me.rbAdminC.TabStop = True
        Me.rbAdminC.Text = "Administración"
        Me.rbAdminC.UseVisualStyleBackColor = True
        '
        'rbContaC
        '
        Me.rbContaC.AutoSize = True
        Me.rbContaC.Location = New System.Drawing.Point(98, 38)
        Me.rbContaC.Name = "rbContaC"
        Me.rbContaC.Size = New System.Drawing.Size(112, 28)
        Me.rbContaC.TabIndex = 1
        Me.rbContaC.TabStop = True
        Me.rbContaC.Text = "Contabilidad"
        Me.rbContaC.UseVisualStyleBackColor = True
        '
        'rbEmpleadoC
        '
        Me.rbEmpleadoC.AutoSize = True
        Me.rbEmpleadoC.Location = New System.Drawing.Point(6, 37)
        Me.rbEmpleadoC.Name = "rbEmpleadoC"
        Me.rbEmpleadoC.Size = New System.Drawing.Size(97, 28)
        Me.rbEmpleadoC.TabIndex = 0
        Me.rbEmpleadoC.TabStop = True
        Me.rbEmpleadoC.Text = "Empleado"
        Me.rbEmpleadoC.UseVisualStyleBackColor = True
        '
        'txtContC
        '
        Me.txtContC.Location = New System.Drawing.Point(500, 238)
        Me.txtContC.Name = "txtContC"
        Me.txtContC.Size = New System.Drawing.Size(200, 30)
        Me.txtContC.TabIndex = 78
        '
        'txtEmailC
        '
        Me.txtEmailC.Location = New System.Drawing.Point(500, 202)
        Me.txtEmailC.Name = "txtEmailC"
        Me.txtEmailC.Size = New System.Drawing.Size(200, 30)
        Me.txtEmailC.TabIndex = 77
        '
        'cbSubDC
        '
        Me.cbSubDC.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblSubdireccionBindingSource1, "IdSubD", True))
        Me.cbSubDC.DataSource = Me.TblSubdireccionBindingSource
        Me.cbSubDC.DisplayMember = "NomSubD"
        Me.cbSubDC.FormattingEnabled = True
        Me.cbSubDC.Location = New System.Drawing.Point(498, 41)
        Me.cbSubDC.Name = "cbSubDC"
        Me.cbSubDC.Size = New System.Drawing.Size(200, 32)
        Me.cbSubDC.TabIndex = 76
        Me.cbSubDC.ValueMember = "IdSubD"
        '
        'TblSubdireccionBindingSource1
        '
        Me.TblSubdireccionBindingSource1.DataMember = "tblSubdireccion"
        Me.TblSubdireccionBindingSource1.DataSource = Me.DataSet_Tablas
        '
        'TblSubdireccionBindingSource
        '
        Me.TblSubdireccionBindingSource.DataMember = "tblSubdireccion"
        Me.TblSubdireccionBindingSource.DataSource = Me.DataSet_Tablas
        '
        'TblPuesto2TableAdapter
        '
        Me.TblPuesto2TableAdapter.ClearBeforeFill = True
        '
        'TblSubdireccionTableAdapter
        '
        Me.TblSubdireccionTableAdapter.ClearBeforeFill = True
        '
        'dtpFeIngEmpM
        '
        Me.dtpFeIngEmpM.Location = New System.Drawing.Point(179, 202)
        Me.dtpFeIngEmpM.Name = "dtpFeIngEmpM"
        Me.dtpFeIngEmpM.Size = New System.Drawing.Size(198, 30)
        Me.dtpFeIngEmpM.TabIndex = 81
        '
        'txtActivoM
        '
        Me.txtActivoM.Location = New System.Drawing.Point(500, 166)
        Me.txtActivoM.Name = "txtActivoM"
        Me.txtActivoM.Size = New System.Drawing.Size(200, 30)
        Me.txtActivoM.TabIndex = 83
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BD_PF2.My.Resources.Resources.file_edit
        Me.PictureBox1.Location = New System.Drawing.Point(64, 268)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'frmEditarEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(722, 342)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtActivoM)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.dtpFeIngEmpM)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtContC)
        Me.Controls.Add(Me.txtEmailC)
        Me.Controls.Add(Me.cbSubDC)
        Me.Controls.Add(IdSubDLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(ContEmpLabel)
        Me.Controls.Add(Me.dtpFeNacEmpC)
        Me.Controls.Add(Me.cbPuestoC)
        Me.Controls.Add(FeNacEmpLabel)
        Me.Controls.Add(IdPuestoLabel)
        Me.Controls.Add(Me.txtAMEmpC)
        Me.Controls.Add(Me.txtAPEmpC)
        Me.Controls.Add(Me.txtNomEmpC)
        Me.Controls.Add(NomEmpLabel)
        Me.Controls.Add(APEmpLabel)
        Me.Controls.Add(AMEmpLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomEmpBuscar)
        Me.Controls.Add(Me.btnAceptarBusC)
        Me.Controls.Add(Me.btnEditar)
        Me.Font = New System.Drawing.Font("Architects Daughter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmEditarEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar"
        CType(Me.TblPuesto2BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Tablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPuesto2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblSubdireccionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSubdireccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomEmpBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptarBusC As System.Windows.Forms.Button
    Friend WithEvents txtAMEmpC As System.Windows.Forms.TextBox
    Friend WithEvents txtAPEmpC As System.Windows.Forms.TextBox
    Friend WithEvents txtNomEmpC As System.Windows.Forms.TextBox
    Friend WithEvents dtpFeNacEmpC As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbPuestoC As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbAdminC As System.Windows.Forms.RadioButton
    Friend WithEvents rbContaC As System.Windows.Forms.RadioButton
    Friend WithEvents rbEmpleadoC As System.Windows.Forms.RadioButton
    Friend WithEvents txtContC As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailC As System.Windows.Forms.TextBox
    Friend WithEvents cbSubDC As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet_Tablas As BD_PF2.DataSet_Tablas
    Friend WithEvents TblPuesto2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPuesto2TableAdapter As BD_PF2.DataSet_TablasTableAdapters.tblPuesto2TableAdapter
    Friend WithEvents TblPuesto2BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblSubdireccionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSubdireccionTableAdapter As BD_PF2.DataSet_TablasTableAdapters.tblSubdireccionTableAdapter
    Friend WithEvents TblSubdireccionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents dtpFeIngEmpM As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtActivoM As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

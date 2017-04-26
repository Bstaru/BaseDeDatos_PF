<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarSubD
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
        Dim Label1 As System.Windows.Forms.Label
        Dim NomEmpLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.cbEmpEncarC = New System.Windows.Forms.ComboBox()
        Me.TblEmpleadoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Tablas = New BD_PF2.DataSet_Tablas()
        Me.TblEmpleadoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAceptarSubDC = New System.Windows.Forms.Button()
        Me.txtNomSubDC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomSubDBuscar = New System.Windows.Forms.TextBox()
        Me.btnAceptarBusC = New System.Windows.Forms.Button()
        Me.TblEmpleadoTableAdapter = New BD_PF2.DataSet_TablasTableAdapters.tblEmpleadoTableAdapter()
        Me.txtActivoSubDC = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Label1 = New System.Windows.Forms.Label()
        NomEmpLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.TblEmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Tablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmpleadoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(0, 125)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(231, 24)
        Label1.TabIndex = 42
        Label1.Text = "Nombre empleado encargado:"
        '
        'NomEmpLabel
        '
        NomEmpLabel.AutoSize = True
        NomEmpLabel.Location = New System.Drawing.Point(158, 56)
        NomEmpLabel.Name = "NomEmpLabel"
        NomEmpLabel.Size = New System.Drawing.Size(72, 24)
        NomEmpLabel.TabIndex = 39
        NomEmpLabel.Text = "Nombre:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(157, 92)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(59, 24)
        Label3.TabIndex = 69
        Label3.Text = "Activo:"
        '
        'cbEmpEncarC
        '
        Me.cbEmpEncarC.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblEmpleadoBindingSource1, "IdEmp", True))
        Me.cbEmpEncarC.DataSource = Me.TblEmpleadoBindingSource2
        Me.cbEmpEncarC.DisplayMember = "NomEmp"
        Me.cbEmpEncarC.FormattingEnabled = True
        Me.cbEmpEncarC.Location = New System.Drawing.Point(235, 122)
        Me.cbEmpEncarC.Name = "cbEmpEncarC"
        Me.cbEmpEncarC.Size = New System.Drawing.Size(197, 32)
        Me.cbEmpEncarC.TabIndex = 43
        Me.cbEmpEncarC.ValueMember = "IdEmp"
        '
        'TblEmpleadoBindingSource1
        '
        Me.TblEmpleadoBindingSource1.DataMember = "tblEmpleado"
        Me.TblEmpleadoBindingSource1.DataSource = Me.DataSet_Tablas
        '
        'DataSet_Tablas
        '
        Me.DataSet_Tablas.DataSetName = "DataSet_Tablas"
        Me.DataSet_Tablas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblEmpleadoBindingSource2
        '
        Me.TblEmpleadoBindingSource2.DataMember = "tblEmpleado"
        Me.TblEmpleadoBindingSource2.DataSource = Me.DataSet_Tablas
        '
        'TblEmpleadoBindingSource
        '
        Me.TblEmpleadoBindingSource.DataMember = "tblEmpleado"
        Me.TblEmpleadoBindingSource.DataSource = Me.DataSet_Tablas
        '
        'btnAceptarSubDC
        '
        Me.btnAceptarSubDC.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAceptarSubDC.Location = New System.Drawing.Point(446, 159)
        Me.btnAceptarSubDC.Name = "btnAceptarSubDC"
        Me.btnAceptarSubDC.Size = New System.Drawing.Size(98, 34)
        Me.btnAceptarSubDC.TabIndex = 41
        Me.btnAceptarSubDC.Text = "Modificar"
        Me.btnAceptarSubDC.UseVisualStyleBackColor = False
        '
        'txtNomSubDC
        '
        Me.txtNomSubDC.Location = New System.Drawing.Point(236, 50)
        Me.txtNomSubDC.Name = "txtNomSubDC"
        Me.txtNomSubDC.Size = New System.Drawing.Size(198, 30)
        Me.txtNomSubDC.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 24)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Buscar subdirección"
        '
        'txtNomSubDBuscar
        '
        Me.txtNomSubDBuscar.Location = New System.Drawing.Point(236, 6)
        Me.txtNomSubDBuscar.Margin = New System.Windows.Forms.Padding(6, 11, 6, 11)
        Me.txtNomSubDBuscar.Name = "txtNomSubDBuscar"
        Me.txtNomSubDBuscar.Size = New System.Drawing.Size(198, 30)
        Me.txtNomSubDBuscar.TabIndex = 67
        '
        'btnAceptarBusC
        '
        Me.btnAceptarBusC.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAceptarBusC.Location = New System.Drawing.Point(446, 6)
        Me.btnAceptarBusC.Margin = New System.Windows.Forms.Padding(6, 11, 6, 11)
        Me.btnAceptarBusC.Name = "btnAceptarBusC"
        Me.btnAceptarBusC.Size = New System.Drawing.Size(98, 30)
        Me.btnAceptarBusC.TabIndex = 66
        Me.btnAceptarBusC.Text = "Aceptar"
        Me.btnAceptarBusC.UseVisualStyleBackColor = False
        '
        'TblEmpleadoTableAdapter
        '
        Me.TblEmpleadoTableAdapter.ClearBeforeFill = True
        '
        'txtActivoSubDC
        '
        Me.txtActivoSubDC.Location = New System.Drawing.Point(235, 86)
        Me.txtActivoSubDC.Name = "txtActivoSubDC"
        Me.txtActivoSubDC.Size = New System.Drawing.Size(198, 30)
        Me.txtActivoSubDC.TabIndex = 70
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BD_PF2.My.Resources.Resources.file_edit
        Me.PictureBox1.Location = New System.Drawing.Point(458, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'frmEditarSubD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(556, 205)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtActivoSubDC)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomSubDBuscar)
        Me.Controls.Add(Me.btnAceptarBusC)
        Me.Controls.Add(Me.cbEmpEncarC)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.btnAceptarSubDC)
        Me.Controls.Add(Me.txtNomSubDC)
        Me.Controls.Add(NomEmpLabel)
        Me.Font = New System.Drawing.Font("Architects Daughter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmEditarSubD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Subdireccion"
        CType(Me.TblEmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Tablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmpleadoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbEmpEncarC As System.Windows.Forms.ComboBox
    Friend WithEvents btnAceptarSubDC As System.Windows.Forms.Button
    Friend WithEvents txtNomSubDC As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomSubDBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptarBusC As System.Windows.Forms.Button
    Friend WithEvents DataSet_Tablas As BD_PF2.DataSet_Tablas
    Friend WithEvents TblEmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmpleadoTableAdapter As BD_PF2.DataSet_TablasTableAdapters.tblEmpleadoTableAdapter
    Friend WithEvents TblEmpleadoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txtActivoSubDC As System.Windows.Forms.TextBox
    Friend WithEvents TblEmpleadoBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

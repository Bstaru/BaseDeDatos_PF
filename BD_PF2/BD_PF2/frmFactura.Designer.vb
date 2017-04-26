<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactura
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
        Me.btnAceptarFac = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbIVA = New System.Windows.Forms.ComboBox()
        Me.TblImpuestoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Tablas = New BD_PF2.DataSet_Tablas()
        Me.TblImpuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblImpuestoTableAdapter = New BD_PF2.DataSet_TablasTableAdapters.tblImpuestoTableAdapter()
        Me.cbProv = New System.Windows.Forms.ComboBox()
        Me.TblProveedorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbEmp = New System.Windows.Forms.ComboBox()
        Me.TblEmpleadoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProveedorTableAdapter = New BD_PF2.DataSet_TablasTableAdapters.tblProveedorTableAdapter()
        Me.TblEmpleadoTableAdapter = New BD_PF2.DataSet_TablasTableAdapters.tblEmpleadoTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.TblImpuestoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Tablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblImpuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProveedorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptarFac
        '
        Me.btnAceptarFac.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAceptarFac.Location = New System.Drawing.Point(275, 168)
        Me.btnAceptarFac.Name = "btnAceptarFac"
        Me.btnAceptarFac.Size = New System.Drawing.Size(82, 32)
        Me.btnAceptarFac.TabIndex = 0
        Me.btnAceptarFac.Text = "Aceptar"
        Me.btnAceptarFac.UseVisualStyleBackColor = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(236, 10)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(121, 30)
        Me.txtCantidad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Proveedor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Empleado que realiza:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(178, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "IVA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "$"
        '
        'cbIVA
        '
        Me.cbIVA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblImpuestoBindingSource1, "IVAImp", True))
        Me.cbIVA.DataSource = Me.TblImpuestoBindingSource
        Me.cbIVA.DisplayMember = "IVAImp"
        Me.cbIVA.FormattingEnabled = True
        Me.cbIVA.Location = New System.Drawing.Point(236, 51)
        Me.cbIVA.Name = "cbIVA"
        Me.cbIVA.Size = New System.Drawing.Size(121, 32)
        Me.cbIVA.TabIndex = 8
        Me.cbIVA.ValueMember = "IVAImp"
        '
        'TblImpuestoBindingSource1
        '
        Me.TblImpuestoBindingSource1.DataMember = "tblImpuesto"
        Me.TblImpuestoBindingSource1.DataSource = Me.DataSet_Tablas
        '
        'DataSet_Tablas
        '
        Me.DataSet_Tablas.DataSetName = "DataSet_Tablas"
        Me.DataSet_Tablas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblImpuestoBindingSource
        '
        Me.TblImpuestoBindingSource.DataMember = "tblImpuesto"
        Me.TblImpuestoBindingSource.DataSource = Me.DataSet_Tablas
        '
        'TblImpuestoTableAdapter
        '
        Me.TblImpuestoTableAdapter.ClearBeforeFill = True
        '
        'cbProv
        '
        Me.cbProv.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblProveedorBindingSource1, "IdProv", True))
        Me.cbProv.DataSource = Me.TblProveedorBindingSource
        Me.cbProv.DisplayMember = "NomProv"
        Me.cbProv.FormattingEnabled = True
        Me.cbProv.Location = New System.Drawing.Point(236, 89)
        Me.cbProv.Name = "cbProv"
        Me.cbProv.Size = New System.Drawing.Size(121, 32)
        Me.cbProv.TabIndex = 9
        Me.cbProv.ValueMember = "IdProv"
        '
        'TblProveedorBindingSource1
        '
        Me.TblProveedorBindingSource1.DataMember = "tblProveedor"
        Me.TblProveedorBindingSource1.DataSource = Me.DataSet_Tablas
        '
        'TblProveedorBindingSource
        '
        Me.TblProveedorBindingSource.DataMember = "tblProveedor"
        Me.TblProveedorBindingSource.DataSource = Me.DataSet_Tablas
        '
        'cbEmp
        '
        Me.cbEmp.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblEmpleadoBindingSource1, "IdEmp", True))
        Me.cbEmp.DataSource = Me.TblEmpleadoBindingSource
        Me.cbEmp.DisplayMember = "NomEmp"
        Me.cbEmp.FormattingEnabled = True
        Me.cbEmp.Location = New System.Drawing.Point(236, 130)
        Me.cbEmp.Name = "cbEmp"
        Me.cbEmp.Size = New System.Drawing.Size(121, 32)
        Me.cbEmp.TabIndex = 10
        Me.cbEmp.ValueMember = "IdEmp"
        '
        'TblEmpleadoBindingSource1
        '
        Me.TblEmpleadoBindingSource1.DataMember = "tblEmpleado"
        Me.TblEmpleadoBindingSource1.DataSource = Me.DataSet_Tablas
        '
        'TblEmpleadoBindingSource
        '
        Me.TblEmpleadoBindingSource.DataMember = "tblEmpleado"
        Me.TblEmpleadoBindingSource.DataSource = Me.DataSet_Tablas
        '
        'TblProveedorTableAdapter
        '
        Me.TblProveedorTableAdapter.ClearBeforeFill = True
        '
        'TblEmpleadoTableAdapter
        '
        Me.TblEmpleadoTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BD_PF2.My.Resources.Resources.factura
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 108)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'frmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(369, 212)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbEmp)
        Me.Controls.Add(Me.cbProv)
        Me.Controls.Add(Me.cbIVA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.btnAceptarFac)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Architects Daughter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        CType(Me.TblImpuestoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Tablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblImpuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProveedorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptarFac As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbIVA As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet_Tablas As BD_PF2.DataSet_Tablas
    Friend WithEvents TblImpuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblImpuestoTableAdapter As BD_PF2.DataSet_TablasTableAdapters.tblImpuestoTableAdapter
    Friend WithEvents TblImpuestoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents cbProv As System.Windows.Forms.ComboBox
    Friend WithEvents cbEmp As System.Windows.Forms.ComboBox
    Friend WithEvents TblProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProveedorTableAdapter As BD_PF2.DataSet_TablasTableAdapters.tblProveedorTableAdapter
    Friend WithEvents TblProveedorBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmpleadoTableAdapter As BD_PF2.DataSet_TablasTableAdapters.tblEmpleadoTableAdapter
    Friend WithEvents TblEmpleadoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

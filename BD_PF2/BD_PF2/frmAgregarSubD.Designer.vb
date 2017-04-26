<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarSubD
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
        Dim Label1 As System.Windows.Forms.Label
        Me.btnAceptarSubDA = New System.Windows.Forms.Button()
        Me.txtNomSubDA = New System.Windows.Forms.TextBox()
        Me.cbEmpEncarA = New System.Windows.Forms.ComboBox()
        Me.TblEmpleadoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Tablas = New BD_PF2.DataSet_Tablas()
        Me.TblEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmpleadoTableAdapter = New BD_PF2.DataSet_TablasTableAdapters.tblEmpleadoTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        NomEmpLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.TblEmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Tablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomEmpLabel
        '
        NomEmpLabel.AutoSize = True
        NomEmpLabel.Location = New System.Drawing.Point(161, 9)
        NomEmpLabel.Name = "NomEmpLabel"
        NomEmpLabel.Size = New System.Drawing.Size(72, 24)
        NomEmpLabel.TabIndex = 34
        NomEmpLabel.Text = "Nombre:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(161, 69)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(231, 24)
        Label1.TabIndex = 37
        Label1.Text = "Nombre empleado encargado:"
        '
        'btnAceptarSubDA
        '
        Me.btnAceptarSubDA.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAceptarSubDA.Location = New System.Drawing.Point(272, 131)
        Me.btnAceptarSubDA.Name = "btnAceptarSubDA"
        Me.btnAceptarSubDA.Size = New System.Drawing.Size(91, 39)
        Me.btnAceptarSubDA.TabIndex = 36
        Me.btnAceptarSubDA.Text = "Aceptar"
        Me.btnAceptarSubDA.UseVisualStyleBackColor = False
        '
        'txtNomSubDA
        '
        Me.txtNomSubDA.Location = New System.Drawing.Point(165, 36)
        Me.txtNomSubDA.Name = "txtNomSubDA"
        Me.txtNomSubDA.Size = New System.Drawing.Size(227, 30)
        Me.txtNomSubDA.TabIndex = 35
        '
        'cbEmpEncarA
        '
        Me.cbEmpEncarA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblEmpleadoBindingSource1, "IdEmp", True))
        Me.cbEmpEncarA.DataSource = Me.TblEmpleadoBindingSource
        Me.cbEmpEncarA.DisplayMember = "NomEmp"
        Me.cbEmpEncarA.FormattingEnabled = True
        Me.cbEmpEncarA.Location = New System.Drawing.Point(166, 96)
        Me.cbEmpEncarA.Name = "cbEmpEncarA"
        Me.cbEmpEncarA.Size = New System.Drawing.Size(226, 32)
        Me.cbEmpEncarA.TabIndex = 38
        Me.cbEmpEncarA.ValueMember = "IdEmp"
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
        'TblEmpleadoBindingSource
        '
        Me.TblEmpleadoBindingSource.DataMember = "tblEmpleado"
        Me.TblEmpleadoBindingSource.DataSource = Me.DataSet_Tablas
        '
        'TblEmpleadoTableAdapter
        '
        Me.TblEmpleadoTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BD_PF2.My.Resources.Resources.subdireccion
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 169)
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'frmAgregarSubD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(412, 190)
        Me.Controls.Add(Me.cbEmpEncarA)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.btnAceptarSubDA)
        Me.Controls.Add(Me.txtNomSubDA)
        Me.Controls.Add(NomEmpLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Architects Daughter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmAgregarSubD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Subdirección"
        CType(Me.TblEmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Tablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptarSubDA As System.Windows.Forms.Button
    Friend WithEvents txtNomSubDA As System.Windows.Forms.TextBox
    Friend WithEvents cbEmpEncarA As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet_Tablas As BD_PF2.DataSet_Tablas
    Friend WithEvents TblEmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmpleadoTableAdapter As BD_PF2.DataSet_TablasTableAdapters.tblEmpleadoTableAdapter
    Friend WithEvents TblEmpleadoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

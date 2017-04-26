<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaEmp
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
        Me.DataSet_ViewsListas = New BD_PF2.DataSet_ViewsListas()
        Me.VwEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwEmpleadosTableAdapter = New BD_PF2.DataSet_ViewsListasTableAdapters.vwEmpleadosTableAdapter()
        Me.TableAdapterManager = New BD_PF2.DataSet_ViewsListasTableAdapters.TableAdapterManager()
        Me.VwEmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataSet_ViewsListas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwEmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet_ViewsListas
        '
        Me.DataSet_ViewsListas.DataSetName = "DataSet_ViewsListas"
        Me.DataSet_ViewsListas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwEmpleadosBindingSource
        '
        Me.VwEmpleadosBindingSource.DataMember = "vwEmpleados"
        Me.VwEmpleadosBindingSource.DataSource = Me.DataSet_ViewsListas
        '
        'VwEmpleadosTableAdapter
        '
        Me.VwEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = BD_PF2.DataSet_ViewsListasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'VwEmpleadosDataGridView
        '
        Me.VwEmpleadosDataGridView.AllowUserToAddRows = False
        Me.VwEmpleadosDataGridView.AllowUserToDeleteRows = False
        Me.VwEmpleadosDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VwEmpleadosDataGridView.AutoGenerateColumns = False
        Me.VwEmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VwEmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.VwEmpleadosDataGridView.DataSource = Me.VwEmpleadosBindingSource
        Me.VwEmpleadosDataGridView.Location = New System.Drawing.Point(13, 43)
        Me.VwEmpleadosDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.VwEmpleadosDataGridView.Name = "VwEmpleadosDataGridView"
        Me.VwEmpleadosDataGridView.ReadOnly = True
        Me.VwEmpleadosDataGridView.Size = New System.Drawing.Size(1093, 257)
        Me.VwEmpleadosDataGridView.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Architects Daughter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Empleados en la base de datos"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Apellido paterno"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Apellido paterno"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellido materno"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido materno"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fecha de nacimiento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha de nacimiento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Fecha de ingreso"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha de ingreso"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Puesto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Puesto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Subdirección"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Subdirección"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Rol"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Rol"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn9.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn9.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Contraseña"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Contraseña"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'frmListaEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1119, 314)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VwEmpleadosDataGridView)
        Me.Font = New System.Drawing.Font("Architects Daughter", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmListaEmp"
        Me.Text = "EMPLEADOS"
        CType(Me.DataSet_ViewsListas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwEmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet_ViewsListas As BD_PF2.DataSet_ViewsListas
    Friend WithEvents VwEmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwEmpleadosTableAdapter As BD_PF2.DataSet_ViewsListasTableAdapters.vwEmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As BD_PF2.DataSet_ViewsListasTableAdapters.TableAdapterManager
    Friend WithEvents VwEmpleadosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

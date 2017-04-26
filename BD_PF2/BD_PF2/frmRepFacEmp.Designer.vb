<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepFacEmp
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
        Me.VwReporteEmpDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwReporteEmpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Views = New BD_PF2.DataSet_Views()
        Me.VwReporteEmpTableAdapter = New BD_PF2.DataSet_ViewsTableAdapters.vwReporteEmpTableAdapter()
        Me.TableAdapterManager = New BD_PF2.DataSet_ViewsTableAdapters.TableAdapterManager()
        Me.VwReporteEmp2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwReporteEmp2TableAdapter = New BD_PF2.DataSet_ViewsTableAdapters.vwReporteEmp2TableAdapter()
        Me.VwReporteEmp2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.VwReporteEmpDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReporteEmpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Views, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReporteEmp2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReporteEmp2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VwReporteEmpDataGridView
        '
        Me.VwReporteEmpDataGridView.AllowUserToAddRows = False
        Me.VwReporteEmpDataGridView.AllowUserToDeleteRows = False
        Me.VwReporteEmpDataGridView.AutoGenerateColumns = False
        Me.VwReporteEmpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VwReporteEmpDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.VwReporteEmpDataGridView.DataSource = Me.VwReporteEmpBindingSource
        Me.VwReporteEmpDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.VwReporteEmpDataGridView.Name = "VwReporteEmpDataGridView"
        Me.VwReporteEmpDataGridView.ReadOnly = True
        Me.VwReporteEmpDataGridView.Size = New System.Drawing.Size(444, 260)
        Me.VwReporteEmpDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Empleado que realizó"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Empleado que realizó"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Folio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Impuesto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Impuesto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Monto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'VwReporteEmpBindingSource
        '
        Me.VwReporteEmpBindingSource.DataMember = "vwReporteEmp"
        Me.VwReporteEmpBindingSource.DataSource = Me.DataSet_Views
        '
        'DataSet_Views
        '
        Me.DataSet_Views.DataSetName = "DataSet_Views"
        Me.DataSet_Views.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwReporteEmpTableAdapter
        '
        Me.VwReporteEmpTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = BD_PF2.DataSet_ViewsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'VwReporteEmp2BindingSource
        '
        Me.VwReporteEmp2BindingSource.DataMember = "vwReporteEmp2"
        Me.VwReporteEmp2BindingSource.DataSource = Me.DataSet_Views
        '
        'VwReporteEmp2TableAdapter
        '
        Me.VwReporteEmp2TableAdapter.ClearBeforeFill = True
        '
        'VwReporteEmp2DataGridView
        '
        Me.VwReporteEmp2DataGridView.AllowUserToAddRows = False
        Me.VwReporteEmp2DataGridView.AllowUserToDeleteRows = False
        Me.VwReporteEmp2DataGridView.AutoGenerateColumns = False
        Me.VwReporteEmp2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VwReporteEmp2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.VwReporteEmp2DataGridView.DataSource = Me.VwReporteEmp2BindingSource
        Me.VwReporteEmp2DataGridView.Location = New System.Drawing.Point(472, 12)
        Me.VwReporteEmp2DataGridView.Name = "VwReporteEmp2DataGridView"
        Me.VwReporteEmp2DataGridView.ReadOnly = True
        Me.VwReporteEmp2DataGridView.Size = New System.Drawing.Size(243, 260)
        Me.VwReporteEmp2DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Empleado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Empleado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'frmRepFacEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(725, 293)
        Me.Controls.Add(Me.VwReporteEmp2DataGridView)
        Me.Controls.Add(Me.VwReporteEmpDataGridView)
        Me.Font = New System.Drawing.Font("Architects Daughter", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmRepFacEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Totales empleados"
        CType(Me.VwReporteEmpDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReporteEmpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Views, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReporteEmp2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReporteEmp2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSet_Views As BD_PF2.DataSet_Views
    Friend WithEvents VwReporteEmpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwReporteEmpTableAdapter As BD_PF2.DataSet_ViewsTableAdapters.vwReporteEmpTableAdapter
    Friend WithEvents TableAdapterManager As BD_PF2.DataSet_ViewsTableAdapters.TableAdapterManager
    Friend WithEvents VwReporteEmpDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VwReporteEmp2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwReporteEmp2TableAdapter As BD_PF2.DataSet_ViewsTableAdapters.vwReporteEmp2TableAdapter
    Friend WithEvents VwReporteEmp2DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

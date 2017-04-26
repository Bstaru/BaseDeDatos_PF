<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepFacGral
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
        Me.DataSet_Views = New BD_PF2.DataSet_Views()
        Me.VwReporteGeneralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwReporteGeneralTableAdapter = New BD_PF2.DataSet_ViewsTableAdapters.vwReporteGeneralTableAdapter()
        Me.TableAdapterManager = New BD_PF2.DataSet_ViewsTableAdapters.TableAdapterManager()
        Me.VwReporteGeneralDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwReporteGeneral2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwReporteGeneral2TableAdapter = New BD_PF2.DataSet_ViewsTableAdapters.vwReporteGeneral2TableAdapter()
        Me.VwReporteGeneral2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataSet_Views, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReporteGeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReporteGeneralDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReporteGeneral2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReporteGeneral2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet_Views
        '
        Me.DataSet_Views.DataSetName = "DataSet_Views"
        Me.DataSet_Views.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwReporteGeneralBindingSource
        '
        Me.VwReporteGeneralBindingSource.DataMember = "vwReporteGeneral"
        Me.VwReporteGeneralBindingSource.DataSource = Me.DataSet_Views
        '
        'VwReporteGeneralTableAdapter
        '
        Me.VwReporteGeneralTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = BD_PF2.DataSet_ViewsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'VwReporteGeneralDataGridView
        '
        Me.VwReporteGeneralDataGridView.AllowUserToAddRows = False
        Me.VwReporteGeneralDataGridView.AllowUserToDeleteRows = False
        Me.VwReporteGeneralDataGridView.AutoGenerateColumns = False
        Me.VwReporteGeneralDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VwReporteGeneralDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.VwReporteGeneralDataGridView.DataSource = Me.VwReporteGeneralBindingSource
        Me.VwReporteGeneralDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.VwReporteGeneralDataGridView.Name = "VwReporteGeneralDataGridView"
        Me.VwReporteGeneralDataGridView.ReadOnly = True
        Me.VwReporteGeneralDataGridView.Size = New System.Drawing.Size(543, 260)
        Me.VwReporteGeneralDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Empleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Empleado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Subdirección"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Subdirección"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Proveedor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Impuesto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Impuesto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'VwReporteGeneral2BindingSource
        '
        Me.VwReporteGeneral2BindingSource.DataMember = "vwReporteGeneral2"
        Me.VwReporteGeneral2BindingSource.DataSource = Me.DataSet_Views
        '
        'VwReporteGeneral2TableAdapter
        '
        Me.VwReporteGeneral2TableAdapter.ClearBeforeFill = True
        '
        'VwReporteGeneral2DataGridView
        '
        Me.VwReporteGeneral2DataGridView.AllowUserToAddRows = False
        Me.VwReporteGeneral2DataGridView.AllowUserToDeleteRows = False
        Me.VwReporteGeneral2DataGridView.AutoGenerateColumns = False
        Me.VwReporteGeneral2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VwReporteGeneral2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.VwReporteGeneral2DataGridView.DataSource = Me.VwReporteGeneral2BindingSource
        Me.VwReporteGeneral2DataGridView.Location = New System.Drawing.Point(57, 278)
        Me.VwReporteGeneral2DataGridView.Name = "VwReporteGeneral2DataGridView"
        Me.VwReporteGeneral2DataGridView.ReadOnly = True
        Me.VwReporteGeneral2DataGridView.Size = New System.Drawing.Size(443, 220)
        Me.VwReporteGeneral2DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Empleado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Empleado"
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
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Proveedor"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'frmRepFacGral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(566, 513)
        Me.Controls.Add(Me.VwReporteGeneral2DataGridView)
        Me.Controls.Add(Me.VwReporteGeneralDataGridView)
        Me.Font = New System.Drawing.Font("Architects Daughter", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmRepFacGral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Totales General"
        CType(Me.DataSet_Views, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReporteGeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReporteGeneralDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReporteGeneral2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReporteGeneral2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSet_Views As BD_PF2.DataSet_Views
    Friend WithEvents VwReporteGeneralBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwReporteGeneralTableAdapter As BD_PF2.DataSet_ViewsTableAdapters.vwReporteGeneralTableAdapter
    Friend WithEvents TableAdapterManager As BD_PF2.DataSet_ViewsTableAdapters.TableAdapterManager
    Friend WithEvents VwReporteGeneralDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VwReporteGeneral2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwReporteGeneral2TableAdapter As BD_PF2.DataSet_ViewsTableAdapters.vwReporteGeneral2TableAdapter
    Friend WithEvents VwReporteGeneral2DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

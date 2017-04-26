<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepFacProv
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
        Me.VwReporteProvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwReporteProvTableAdapter = New BD_PF2.DataSet_ViewsTableAdapters.vwReporteProvTableAdapter()
        Me.TableAdapterManager = New BD_PF2.DataSet_ViewsTableAdapters.TableAdapterManager()
        Me.VwReporteProvDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwReporteProv2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwReporteProv2TableAdapter = New BD_PF2.DataSet_ViewsTableAdapters.vwReporteProv2TableAdapter()
        Me.VwReporteProv2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataSet_Views, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReporteProvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReporteProvDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReporteProv2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReporteProv2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet_Views
        '
        Me.DataSet_Views.DataSetName = "DataSet_Views"
        Me.DataSet_Views.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwReporteProvBindingSource
        '
        Me.VwReporteProvBindingSource.DataMember = "vwReporteProv"
        Me.VwReporteProvBindingSource.DataSource = Me.DataSet_Views
        '
        'VwReporteProvTableAdapter
        '
        Me.VwReporteProvTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = BD_PF2.DataSet_ViewsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'VwReporteProvDataGridView
        '
        Me.VwReporteProvDataGridView.AllowUserToAddRows = False
        Me.VwReporteProvDataGridView.AllowUserToDeleteRows = False
        Me.VwReporteProvDataGridView.AutoGenerateColumns = False
        Me.VwReporteProvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VwReporteProvDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.VwReporteProvDataGridView.DataSource = Me.VwReporteProvBindingSource
        Me.VwReporteProvDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.VwReporteProvDataGridView.Name = "VwReporteProvDataGridView"
        Me.VwReporteProvDataGridView.ReadOnly = True
        Me.VwReporteProvDataGridView.Size = New System.Drawing.Size(343, 260)
        Me.VwReporteProvDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Proveedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Impuesto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Impuesto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'VwReporteProv2BindingSource
        '
        Me.VwReporteProv2BindingSource.DataMember = "vwReporteProv2"
        Me.VwReporteProv2BindingSource.DataSource = Me.DataSet_Views
        '
        'VwReporteProv2TableAdapter
        '
        Me.VwReporteProv2TableAdapter.ClearBeforeFill = True
        '
        'VwReporteProv2DataGridView
        '
        Me.VwReporteProv2DataGridView.AllowUserToAddRows = False
        Me.VwReporteProv2DataGridView.AllowUserToDeleteRows = False
        Me.VwReporteProv2DataGridView.AutoGenerateColumns = False
        Me.VwReporteProv2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VwReporteProv2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.VwReporteProv2DataGridView.DataSource = Me.VwReporteProv2BindingSource
        Me.VwReporteProv2DataGridView.Location = New System.Drawing.Point(361, 12)
        Me.VwReporteProv2DataGridView.Name = "VwReporteProv2DataGridView"
        Me.VwReporteProv2DataGridView.ReadOnly = True
        Me.VwReporteProv2DataGridView.Size = New System.Drawing.Size(243, 260)
        Me.VwReporteProv2DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Proveedor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Proveedor"
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
        'frmRepFacProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(617, 289)
        Me.Controls.Add(Me.VwReporteProv2DataGridView)
        Me.Controls.Add(Me.VwReporteProvDataGridView)
        Me.Font = New System.Drawing.Font("Architects Daughter", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmRepFacProv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRepFacProv"
        CType(Me.DataSet_Views, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReporteProvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReporteProvDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReporteProv2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReporteProv2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSet_Views As BD_PF2.DataSet_Views
    Friend WithEvents VwReporteProvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwReporteProvTableAdapter As BD_PF2.DataSet_ViewsTableAdapters.vwReporteProvTableAdapter
    Friend WithEvents TableAdapterManager As BD_PF2.DataSet_ViewsTableAdapters.TableAdapterManager
    Friend WithEvents VwReporteProvDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VwReporteProv2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwReporteProv2TableAdapter As BD_PF2.DataSet_ViewsTableAdapters.vwReporteProv2TableAdapter
    Friend WithEvents VwReporteProv2DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

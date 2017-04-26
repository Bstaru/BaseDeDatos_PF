<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepFacSubD
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
        Me.VwReporteSubDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwReporteSubDTableAdapter = New BD_PF2.DataSet_ViewsTableAdapters.vwReporteSubDTableAdapter()
        Me.TableAdapterManager = New BD_PF2.DataSet_ViewsTableAdapters.TableAdapterManager()
        Me.VwReporteSubDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwReporteSubD2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwReporteSubD2TableAdapter = New BD_PF2.DataSet_ViewsTableAdapters.vwReporteSubD2TableAdapter()
        Me.VwReporteSubD2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataSet_Views, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReporteSubDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReporteSubDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReporteSubD2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReporteSubD2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet_Views
        '
        Me.DataSet_Views.DataSetName = "DataSet_Views"
        Me.DataSet_Views.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwReporteSubDBindingSource
        '
        Me.VwReporteSubDBindingSource.DataMember = "vwReporteSubD"
        Me.VwReporteSubDBindingSource.DataSource = Me.DataSet_Views
        '
        'VwReporteSubDTableAdapter
        '
        Me.VwReporteSubDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = BD_PF2.DataSet_ViewsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'VwReporteSubDDataGridView
        '
        Me.VwReporteSubDDataGridView.AutoGenerateColumns = False
        Me.VwReporteSubDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VwReporteSubDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.VwReporteSubDDataGridView.DataSource = Me.VwReporteSubDBindingSource
        Me.VwReporteSubDDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.VwReporteSubDDataGridView.Name = "VwReporteSubDDataGridView"
        Me.VwReporteSubDDataGridView.Size = New System.Drawing.Size(444, 260)
        Me.VwReporteSubDDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Subdirección que realizó"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Subdirección que realizó"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Folio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Impuesto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Impuesto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'VwReporteSubD2BindingSource
        '
        Me.VwReporteSubD2BindingSource.DataMember = "vwReporteSubD2"
        Me.VwReporteSubD2BindingSource.DataSource = Me.DataSet_Views
        '
        'VwReporteSubD2TableAdapter
        '
        Me.VwReporteSubD2TableAdapter.ClearBeforeFill = True
        '
        'VwReporteSubD2DataGridView
        '
        Me.VwReporteSubD2DataGridView.AutoGenerateColumns = False
        Me.VwReporteSubD2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VwReporteSubD2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.VwReporteSubD2DataGridView.DataSource = Me.VwReporteSubD2BindingSource
        Me.VwReporteSubD2DataGridView.Location = New System.Drawing.Point(472, 12)
        Me.VwReporteSubD2DataGridView.Name = "VwReporteSubD2DataGridView"
        Me.VwReporteSubD2DataGridView.Size = New System.Drawing.Size(243, 260)
        Me.VwReporteSubD2DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Subdirección"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Subdirección"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'frmRepFacSubD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(725, 293)
        Me.Controls.Add(Me.VwReporteSubD2DataGridView)
        Me.Controls.Add(Me.VwReporteSubDDataGridView)
        Me.Font = New System.Drawing.Font("Architects Daughter", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmRepFacSubD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Totales Subdirección"
        CType(Me.DataSet_Views, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReporteSubDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReporteSubDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReporteSubD2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReporteSubD2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSet_Views As BD_PF2.DataSet_Views
    Friend WithEvents VwReporteSubDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwReporteSubDTableAdapter As BD_PF2.DataSet_ViewsTableAdapters.vwReporteSubDTableAdapter
    Friend WithEvents TableAdapterManager As BD_PF2.DataSet_ViewsTableAdapters.TableAdapterManager
    Friend WithEvents VwReporteSubDDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VwReporteSubD2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwReporteSubD2TableAdapter As BD_PF2.DataSet_ViewsTableAdapters.vwReporteSubD2TableAdapter
    Friend WithEvents VwReporteSubD2DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

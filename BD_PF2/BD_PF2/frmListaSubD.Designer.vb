<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaSubD
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet_ViewsListas = New BD_PF2.DataSet_ViewsListas()
        Me.VwSubdireccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwSubdireccionesTableAdapter = New BD_PF2.DataSet_ViewsListasTableAdapters.vwSubdireccionesTableAdapter()
        Me.TableAdapterManager = New BD_PF2.DataSet_ViewsListasTableAdapters.TableAdapterManager()
        Me.VwSubdireccionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataSet_ViewsListas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSubdireccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSubdireccionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Architects Daughter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 58)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Subdirecciones en " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la base de datos"
        '
        'DataSet_ViewsListas
        '
        Me.DataSet_ViewsListas.DataSetName = "DataSet_ViewsListas"
        Me.DataSet_ViewsListas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwSubdireccionesBindingSource
        '
        Me.VwSubdireccionesBindingSource.DataMember = "vwSubdirecciones"
        Me.VwSubdireccionesBindingSource.DataSource = Me.DataSet_ViewsListas
        '
        'VwSubdireccionesTableAdapter
        '
        Me.VwSubdireccionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = BD_PF2.DataSet_ViewsListasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'VwSubdireccionesDataGridView
        '
        Me.VwSubdireccionesDataGridView.AllowUserToAddRows = False
        Me.VwSubdireccionesDataGridView.AllowUserToDeleteRows = False
        Me.VwSubdireccionesDataGridView.AutoGenerateColumns = False
        Me.VwSubdireccionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VwSubdireccionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.VwSubdireccionesDataGridView.DataSource = Me.VwSubdireccionesBindingSource
        Me.VwSubdireccionesDataGridView.Location = New System.Drawing.Point(12, 70)
        Me.VwSubdireccionesDataGridView.Name = "VwSubdireccionesDataGridView"
        Me.VwSubdireccionesDataGridView.ReadOnly = True
        Me.VwSubdireccionesDataGridView.Size = New System.Drawing.Size(247, 272)
        Me.VwSubdireccionesDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Subdirección"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Subdirección"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Empleado encargado"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Empleado encargado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'frmListaSubD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(283, 360)
        Me.Controls.Add(Me.VwSubdireccionesDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Architects Daughter", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmListaSubD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUBDIRECCIONES"
        CType(Me.DataSet_ViewsListas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSubdireccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSubdireccionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSet_ViewsListas As BD_PF2.DataSet_ViewsListas
    Friend WithEvents VwSubdireccionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwSubdireccionesTableAdapter As BD_PF2.DataSet_ViewsListasTableAdapters.vwSubdireccionesTableAdapter
    Friend WithEvents TableAdapterManager As BD_PF2.DataSet_ViewsListasTableAdapters.TableAdapterManager
    Friend WithEvents VwSubdireccionesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

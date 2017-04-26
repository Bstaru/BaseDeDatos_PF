<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaProv
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
        Me.VwProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwProveedorTableAdapter = New BD_PF2.DataSet_ViewsListasTableAdapters.vwProveedorTableAdapter()
        Me.TableAdapterManager = New BD_PF2.DataSet_ViewsListasTableAdapters.TableAdapterManager()
        Me.VwProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataSet_ViewsListas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Architects Daughter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 58)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Proveedores en" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la base de datos"
        '
        'DataSet_ViewsListas
        '
        Me.DataSet_ViewsListas.DataSetName = "DataSet_ViewsListas"
        Me.DataSet_ViewsListas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwProveedorBindingSource
        '
        Me.VwProveedorBindingSource.DataMember = "vwProveedor"
        Me.VwProveedorBindingSource.DataSource = Me.DataSet_ViewsListas
        '
        'VwProveedorTableAdapter
        '
        Me.VwProveedorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = BD_PF2.DataSet_ViewsListasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'VwProveedorDataGridView
        '
        Me.VwProveedorDataGridView.AllowUserToAddRows = False
        Me.VwProveedorDataGridView.AllowUserToDeleteRows = False
        Me.VwProveedorDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VwProveedorDataGridView.AutoGenerateColumns = False
        Me.VwProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VwProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.VwProveedorDataGridView.DataSource = Me.VwProveedorBindingSource
        Me.VwProveedorDataGridView.Location = New System.Drawing.Point(34, 81)
        Me.VwProveedorDataGridView.Name = "VwProveedorDataGridView"
        Me.VwProveedorDataGridView.ReadOnly = True
        Me.VwProveedorDataGridView.Size = New System.Drawing.Size(144, 220)
        Me.VwProveedorDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'frmListaProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(215, 313)
        Me.Controls.Add(Me.VwProveedorDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmListaProv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROVEEDORES"
        CType(Me.DataSet_ViewsListas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSet_ViewsListas As BD_PF2.DataSet_ViewsListas
    Friend WithEvents VwProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwProveedorTableAdapter As BD_PF2.DataSet_ViewsListasTableAdapters.vwProveedorTableAdapter
    Friend WithEvents TableAdapterManager As BD_PF2.DataSet_ViewsListasTableAdapters.TableAdapterManager
    Friend WithEvents VwProveedorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

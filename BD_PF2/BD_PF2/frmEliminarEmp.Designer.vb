<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarEmp
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
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomEmpBE = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEliminar.Location = New System.Drawing.Point(216, 77)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(90, 30)
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre del empleado a eliminar"
        '
        'txtNomEmpBE
        '
        Me.txtNomEmpBE.Location = New System.Drawing.Point(12, 77)
        Me.txtNomEmpBE.Name = "txtNomEmpBE"
        Me.txtNomEmpBE.Size = New System.Drawing.Size(198, 30)
        Me.txtNomEmpBE.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BD_PF2.My.Resources.Resources.delete
        Me.PictureBox1.Location = New System.Drawing.Point(312, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 125)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmEliminarEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(411, 146)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtNomEmpBE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Font = New System.Drawing.Font("Architects Daughter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmEliminarEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Empleado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomEmpBE As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

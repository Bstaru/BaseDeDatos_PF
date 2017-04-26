<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogIn))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCont = New System.Windows.Forms.TextBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INICIAR SESIÓN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(138, 59)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(184, 36)
        Me.txtEmail.TabIndex = 3
        '
        'txtCont
        '
        Me.txtCont.Location = New System.Drawing.Point(138, 110)
        Me.txtCont.Name = "txtCont"
        Me.txtCont.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCont.Size = New System.Drawing.Size(184, 36)
        Me.txtCont.TabIndex = 4
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEntrar.Location = New System.Drawing.Point(128, 165)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(107, 35)
        Me.btnEntrar.TabIndex = 5
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'frmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(364, 212)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtCont)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Architects Daughter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "frmLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtCont As System.Windows.Forms.TextBox
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
End Class

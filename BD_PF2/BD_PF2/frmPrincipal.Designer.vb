<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificaEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProovedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarProovedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProovedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeProovedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubdirecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarSubdirecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarSubdirecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarSubdirecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarSubdirecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeSubdireccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorPersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorSubdireccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorPorveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfromaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormaDeUsoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Architects Daughter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.FacturasToolStripMenuItem, Me.InfromaciónToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(537, 38)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadoToolStripMenuItem, Me.ProovedorToolStripMenuItem, Me.SubdirecciónToolStripMenuItem})
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(162, 34)
        Me.AgregarToolStripMenuItem.Text = "Mantenimiento"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarEmpleadoToolStripMenuItem, Me.EliminarEmpleadoToolStripMenuItem, Me.ModificaEmpleadoToolStripMenuItem, Me.BuscarEmpleadoToolStripMenuItem, Me.ListaDeEmpleadosToolStripMenuItem})
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(218, 34)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'AgregarEmpleadoToolStripMenuItem
        '
        Me.AgregarEmpleadoToolStripMenuItem.Name = "AgregarEmpleadoToolStripMenuItem"
        Me.AgregarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(287, 34)
        Me.AgregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado"
        '
        'EliminarEmpleadoToolStripMenuItem
        '
        Me.EliminarEmpleadoToolStripMenuItem.Name = "EliminarEmpleadoToolStripMenuItem"
        Me.EliminarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(287, 34)
        Me.EliminarEmpleadoToolStripMenuItem.Text = "Eliminar Empleado"
        '
        'ModificaEmpleadoToolStripMenuItem
        '
        Me.ModificaEmpleadoToolStripMenuItem.Name = "ModificaEmpleadoToolStripMenuItem"
        Me.ModificaEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(287, 34)
        Me.ModificaEmpleadoToolStripMenuItem.Text = "Modificar Empleado"
        '
        'BuscarEmpleadoToolStripMenuItem
        '
        Me.BuscarEmpleadoToolStripMenuItem.Name = "BuscarEmpleadoToolStripMenuItem"
        Me.BuscarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(287, 34)
        Me.BuscarEmpleadoToolStripMenuItem.Text = "Buscar Empleado"
        '
        'ListaDeEmpleadosToolStripMenuItem
        '
        Me.ListaDeEmpleadosToolStripMenuItem.Name = "ListaDeEmpleadosToolStripMenuItem"
        Me.ListaDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(287, 34)
        Me.ListaDeEmpleadosToolStripMenuItem.Text = "Lista de Empleados"
        '
        'ProovedorToolStripMenuItem
        '
        Me.ProovedorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarProovedorToolStripMenuItem, Me.EliminarProovedorToolStripMenuItem, Me.ModificarProveedorToolStripMenuItem, Me.BuscarProveedorToolStripMenuItem, Me.ListaDeProovedoresToolStripMenuItem})
        Me.ProovedorToolStripMenuItem.Name = "ProovedorToolStripMenuItem"
        Me.ProovedorToolStripMenuItem.Size = New System.Drawing.Size(218, 34)
        Me.ProovedorToolStripMenuItem.Text = "Proovedor"
        '
        'AgregarProovedorToolStripMenuItem
        '
        Me.AgregarProovedorToolStripMenuItem.Name = "AgregarProovedorToolStripMenuItem"
        Me.AgregarProovedorToolStripMenuItem.Size = New System.Drawing.Size(312, 34)
        Me.AgregarProovedorToolStripMenuItem.Text = "Agregar Proveedor"
        '
        'EliminarProovedorToolStripMenuItem
        '
        Me.EliminarProovedorToolStripMenuItem.Name = "EliminarProovedorToolStripMenuItem"
        Me.EliminarProovedorToolStripMenuItem.Size = New System.Drawing.Size(312, 34)
        Me.EliminarProovedorToolStripMenuItem.Text = "Eliminar Proveedor"
        '
        'ModificarProveedorToolStripMenuItem
        '
        Me.ModificarProveedorToolStripMenuItem.Name = "ModificarProveedorToolStripMenuItem"
        Me.ModificarProveedorToolStripMenuItem.Size = New System.Drawing.Size(312, 34)
        Me.ModificarProveedorToolStripMenuItem.Text = "Modificar  Proveedor"
        '
        'BuscarProveedorToolStripMenuItem
        '
        Me.BuscarProveedorToolStripMenuItem.Name = "BuscarProveedorToolStripMenuItem"
        Me.BuscarProveedorToolStripMenuItem.Size = New System.Drawing.Size(312, 34)
        Me.BuscarProveedorToolStripMenuItem.Text = "Buscar  Proveedor"
        '
        'ListaDeProovedoresToolStripMenuItem
        '
        Me.ListaDeProovedoresToolStripMenuItem.Name = "ListaDeProovedoresToolStripMenuItem"
        Me.ListaDeProovedoresToolStripMenuItem.Size = New System.Drawing.Size(312, 34)
        Me.ListaDeProovedoresToolStripMenuItem.Text = "Lista de Proovedores"
        '
        'SubdirecciónToolStripMenuItem
        '
        Me.SubdirecciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarSubdirecciónToolStripMenuItem, Me.EliminarSubdirecciónToolStripMenuItem, Me.ModificarSubdirecciónToolStripMenuItem, Me.BuscarSubdirecciónToolStripMenuItem, Me.ListaDeSubdireccionesToolStripMenuItem})
        Me.SubdirecciónToolStripMenuItem.Name = "SubdirecciónToolStripMenuItem"
        Me.SubdirecciónToolStripMenuItem.Size = New System.Drawing.Size(218, 34)
        Me.SubdirecciónToolStripMenuItem.Text = "Subdirección"
        '
        'AgregarSubdirecciónToolStripMenuItem
        '
        Me.AgregarSubdirecciónToolStripMenuItem.Name = "AgregarSubdirecciónToolStripMenuItem"
        Me.AgregarSubdirecciónToolStripMenuItem.Size = New System.Drawing.Size(329, 34)
        Me.AgregarSubdirecciónToolStripMenuItem.Text = "Agregar Subdirección"
        '
        'EliminarSubdirecciónToolStripMenuItem
        '
        Me.EliminarSubdirecciónToolStripMenuItem.Name = "EliminarSubdirecciónToolStripMenuItem"
        Me.EliminarSubdirecciónToolStripMenuItem.Size = New System.Drawing.Size(329, 34)
        Me.EliminarSubdirecciónToolStripMenuItem.Text = "Eliminar Subdirección"
        '
        'ModificarSubdirecciónToolStripMenuItem
        '
        Me.ModificarSubdirecciónToolStripMenuItem.Name = "ModificarSubdirecciónToolStripMenuItem"
        Me.ModificarSubdirecciónToolStripMenuItem.Size = New System.Drawing.Size(329, 34)
        Me.ModificarSubdirecciónToolStripMenuItem.Text = "Modificar Subdirección"
        '
        'BuscarSubdirecciónToolStripMenuItem
        '
        Me.BuscarSubdirecciónToolStripMenuItem.Name = "BuscarSubdirecciónToolStripMenuItem"
        Me.BuscarSubdirecciónToolStripMenuItem.Size = New System.Drawing.Size(329, 34)
        Me.BuscarSubdirecciónToolStripMenuItem.Text = "Buscar Subdirección"
        '
        'ListaDeSubdireccionesToolStripMenuItem
        '
        Me.ListaDeSubdireccionesToolStripMenuItem.Name = "ListaDeSubdireccionesToolStripMenuItem"
        Me.ListaDeSubdireccionesToolStripMenuItem.Size = New System.Drawing.Size(329, 34)
        Me.ListaDeSubdireccionesToolStripMenuItem.Text = "Lista de Subdirecciones"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearFacturaToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(118, 34)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'CrearFacturaToolStripMenuItem
        '
        Me.CrearFacturaToolStripMenuItem.Name = "CrearFacturaToolStripMenuItem"
        Me.CrearFacturaToolStripMenuItem.Size = New System.Drawing.Size(242, 34)
        Me.CrearFacturaToolStripMenuItem.Text = "Crear factura"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorPersonalToolStripMenuItem, Me.PorSubdireccionesToolStripMenuItem, Me.PorPorveedoresToolStripMenuItem, Me.GeneralToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(242, 34)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'PorPersonalToolStripMenuItem
        '
        Me.PorPersonalToolStripMenuItem.Name = "PorPersonalToolStripMenuItem"
        Me.PorPersonalToolStripMenuItem.Size = New System.Drawing.Size(282, 34)
        Me.PorPersonalToolStripMenuItem.Text = "por personal"
        '
        'PorSubdireccionesToolStripMenuItem
        '
        Me.PorSubdireccionesToolStripMenuItem.Name = "PorSubdireccionesToolStripMenuItem"
        Me.PorSubdireccionesToolStripMenuItem.Size = New System.Drawing.Size(282, 34)
        Me.PorSubdireccionesToolStripMenuItem.Text = "por subdirecciones"
        '
        'PorPorveedoresToolStripMenuItem
        '
        Me.PorPorveedoresToolStripMenuItem.Name = "PorPorveedoresToolStripMenuItem"
        Me.PorPorveedoresToolStripMenuItem.Size = New System.Drawing.Size(282, 34)
        Me.PorPorveedoresToolStripMenuItem.Text = "por porveedores"
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(282, 34)
        Me.GeneralToolStripMenuItem.Text = "general"
        '
        'InfromaciónToolStripMenuItem
        '
        Me.InfromaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.InfromaciónToolStripMenuItem.Name = "InfromaciónToolStripMenuItem"
        Me.InfromaciónToolStripMenuItem.Size = New System.Drawing.Size(143, 34)
        Me.InfromaciónToolStripMenuItem.Text = "Información"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(194, 34)
        Me.AcercaDeToolStripMenuItem.Text = "acerca de"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormaDeUsoToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(84, 34)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'FormaDeUsoToolStripMenuItem
        '
        Me.FormaDeUsoToolStripMenuItem.Name = "FormaDeUsoToolStripMenuItem"
        Me.FormaDeUsoToolStripMenuItem.Size = New System.Drawing.Size(231, 34)
        Me.FormaDeUsoToolStripMenuItem.Text = "forma de uso"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.BD_PF2.My.Resources.Resources.gg2
        Me.PictureBox2.Location = New System.Drawing.Point(4, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(179, 94)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(166, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 165)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCoral
        Me.Button1.Location = New System.Drawing.Point(332, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(537, 267)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Architects Daughter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarEmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarEmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificaEmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarEmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProovedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarProovedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarProovedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeProovedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubdirecciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarSubdirecciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarSubdirecciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarSubdirecciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarSubdirecciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeSubdireccionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents InfromaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormaDeUsoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorPersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorSubdireccionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorPorveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class

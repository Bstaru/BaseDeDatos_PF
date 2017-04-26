Public Class frmPrincipal

    'Dim Conn As New conection = New conection () 

    Private Sub frmAdmin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConectarBD()
        My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Dowse_NewTarget.wav")
        Conn.Close()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        MsgBox("Base de datos de un administrador de contabilidad." & Environment.NewLine & Environment.NewLine & "Creador de la aplicación: Bstaru." & Environment.NewLine & Environment.NewLine & "FACULTAD DE CIENCIAS FÍSICO MATEMÁTICAS" & Environment.NewLine & "UNIVERSIDAD AUTÓNOMA DE NUEVO LEÓN", MsgBoxStyle.OkOnly, "ACERCA DE")
    End Sub

    Private Sub FormaDeUsoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FormaDeUsoToolStripMenuItem.Click
        ' frmInfo.ShowDialog()
        frmInfo2.ShowDialog()
    End Sub

    '_____________EMPLEADOS_______________

    Private Sub AgregarEmpleadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AgregarEmpleadoToolStripMenuItem.Click
        frmAgregarEmp.ShowDialog()
    End Sub
    Private Sub EliminarEmpleadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarEmpleadoToolStripMenuItem.Click
        frmEliminarEmp.ShowDialog()
    End Sub
    Private Sub ModificaEmpleadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificaEmpleadoToolStripMenuItem.Click
        frmEditarEmp.ShowDialog()
    End Sub
    Private Sub BuscarEmpleadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BuscarEmpleadoToolStripMenuItem.Click
        frmBuscarEmp.ShowDialog()
    End Sub
    Private Sub ListaDeEmpleadosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaDeEmpleadosToolStripMenuItem.Click
        frmListaEmp.ShowDialog()
    End Sub

    '____________PROVEEDORES______________

    Private Sub AgregarProovedorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AgregarProovedorToolStripMenuItem.Click
        frmAgregarProv.ShowDialog()
    End Sub
    Private Sub EliminarProovedorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarProovedorToolStripMenuItem.Click
        frmEliminarProv.ShowDialog()
    End Sub
    Private Sub ModificarProveedorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarProveedorToolStripMenuItem.Click
        frmEditarProv.ShowDialog()
    End Sub
    Private Sub BuscarProveedorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BuscarProveedorToolStripMenuItem.Click
        frmBuscarProv.ShowDialog()
    End Sub
    Private Sub ListaDeProovedoresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaDeProovedoresToolStripMenuItem.Click
        frmListaProv.ShowDialog()
    End Sub

    '____________SUBDIRE_______________

    Private Sub AgregarSubdirecciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AgregarSubdirecciónToolStripMenuItem.Click
        frmAgregarSubD.ShowDialog()
    End Sub
    Private Sub EliminarSubdirecciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarSubdirecciónToolStripMenuItem.Click
        frmEliminarSubD.ShowDialog()
    End Sub
    Private Sub ModificarSubdirecciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarSubdirecciónToolStripMenuItem.Click
        frmEditarSubD.ShowDialog()
    End Sub
    Private Sub BuscarSubdirecciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BuscarSubdirecciónToolStripMenuItem.Click
        frmBuscarSubD.ShowDialog()
    End Sub
    Private Sub ListaDeSubdireccionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaDeSubdireccionesToolStripMenuItem.Click
        frmListaSubD.ShowDialog()
    End Sub

    '____________FACTURAS_______________
    Private Sub CrearFacturaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CrearFacturaToolStripMenuItem.Click
        frmFactura.ShowDialog()
    End Sub
    Private Sub PorPersonalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PorPersonalToolStripMenuItem.Click
        frmRepFacEmp.ShowDialog()
    End Sub
    Private Sub PorSubdireccionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PorSubdireccionesToolStripMenuItem.Click
        frmRepFacSubD.ShowDialog()
    End Sub
    Private Sub PorPorveedoresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PorPorveedoresToolStripMenuItem.Click
        frmRepFacProv.ShowDialog()
    End Sub
    Private Sub GeneralToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GeneralToolStripMenuItem.Click
        frmRepFacGral.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Secret_Minor.wav")
        wait(1.2)
        End
    End Sub


    Private Sub AgregarToolStripMenuItem_MouseHover(sender As Object, e As System.EventArgs) Handles AgregarToolStripMenuItem.MouseHover
        My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Text_Next.wav")
    End Sub

    Private Sub FacturasToolStripMenuItem_MouseHover(sender As Object, e As System.EventArgs) Handles FacturasToolStripMenuItem.MouseHover
        My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Text_Next.wav")
    End Sub
    Private Sub InfromaciónToolStripMenuItem_MouseHover(sender As Object, e As System.EventArgs) Handles InfromaciónToolStripMenuItem.MouseHover
        My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Text_Next.wav")
    End Sub
    Private Sub AyudaToolStripMenuItem_MouseHover(sender As Object, e As System.EventArgs) Handles AyudaToolStripMenuItem.MouseHover
        My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Text_Next.wav")
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Map_Close.wav")
        MsgBox("¡Te pregunté que ¿Qué quieres hacer?!", MsgBoxStyle.OkOnly, "OIE")
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

        MsgBox("K TRAEZ PRRO!", MsgBoxStyle.OkOnly, ">:V")
        My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\Really_Nigga_Sound_Effect.wav")
        Form1.ShowDialog()

    End Sub
End Class

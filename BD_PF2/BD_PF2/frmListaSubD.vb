Public Class frmListaSubD

    Private Sub frmListaSubD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_ViewsListas.vwSubdirecciones' table. You can move, or remove it, as needed.
        Me.VwSubdireccionesTableAdapter.Fill(Me.DataSet_ViewsListas.vwSubdirecciones)

    End Sub
End Class
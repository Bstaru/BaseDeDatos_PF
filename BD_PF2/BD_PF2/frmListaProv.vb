Public Class frmListaProv

    Private Sub frmListaProv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_ViewsListas.vwProveedor' table. You can move, or remove it, as needed.
        Me.VwProveedorTableAdapter.Fill(Me.DataSet_ViewsListas.vwProveedor)

    End Sub
End Class
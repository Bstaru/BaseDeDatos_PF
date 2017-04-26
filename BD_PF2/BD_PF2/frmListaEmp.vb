Public Class frmListaEmp

    Private Sub frmListaEmp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_ViewsListas.vwEmpleados' table. You can move, or remove it, as needed.
        Me.VwEmpleadosTableAdapter.Fill(Me.DataSet_ViewsListas.vwEmpleados)

    End Sub
End Class
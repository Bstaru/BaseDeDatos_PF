Public Class frmRepFacEmp

    Private Sub frmRepFacEmp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Views.vwReporteEmp2' table. You can move, or remove it, as needed.
        Me.VwReporteEmp2TableAdapter.Fill(Me.DataSet_Views.vwReporteEmp2)
        'TODO: This line of code loads data into the 'DataSet_Views.vwReporteEmp' table. You can move, or remove it, as needed.
        Me.VwReporteEmpTableAdapter.Fill(Me.DataSet_Views.vwReporteEmp)

    End Sub

End Class
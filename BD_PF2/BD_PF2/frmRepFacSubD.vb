Public Class frmRepFacSubD

    Private Sub frmRepFacSubD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Views.vwReporteSubD2' table. You can move, or remove it, as needed.
        Me.VwReporteSubD2TableAdapter.Fill(Me.DataSet_Views.vwReporteSubD2)
        'TODO: This line of code loads data into the 'DataSet_Views.vwReporteSubD' table. You can move, or remove it, as needed.
        Me.VwReporteSubDTableAdapter.Fill(Me.DataSet_Views.vwReporteSubD)

    End Sub
End Class
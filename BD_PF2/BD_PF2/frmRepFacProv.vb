Public Class frmRepFacProv


    Private Sub frmRepFacProv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Views.vwReporteProv2' table. You can move, or remove it, as needed.
        Me.VwReporteProv2TableAdapter.Fill(Me.DataSet_Views.vwReporteProv2)
        'TODO: This line of code loads data into the 'DataSet_Views.vwReporteProv' table. You can move, or remove it, as needed.
        Me.VwReporteProvTableAdapter.Fill(Me.DataSet_Views.vwReporteProv)

    End Sub
End Class
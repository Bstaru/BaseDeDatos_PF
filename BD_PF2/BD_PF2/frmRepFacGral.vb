Public Class frmRepFacGral

    Private Sub frmRepFacGral_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Views.vwReporteGeneral2' table. You can move, or remove it, as needed.
        Me.VwReporteGeneral2TableAdapter.Fill(Me.DataSet_Views.vwReporteGeneral2)
        'TODO: This line of code loads data into the 'DataSet_Views.vwReporteGeneral2' table. You can move, or remove it, as needed.
        Me.VwReporteGeneral2TableAdapter.Fill(Me.DataSet_Views.vwReporteGeneral2)
        'TODO: This line of code loads data into the 'DataSet_Views.vwReporteGeneral' table. You can move, or remove it, as needed.
        Me.VwReporteGeneralTableAdapter.Fill(Me.DataSet_Views.vwReporteGeneral)

    End Sub
End Class
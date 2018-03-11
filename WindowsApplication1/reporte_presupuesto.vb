Public Class reporte_presupuesto
    Sub imprimir_presupuesto(ByVal id As String)
        'Me.DataTable1TableAdapter.Fill(Me.DataSet3.DataTable1, id)
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub reporte_presupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
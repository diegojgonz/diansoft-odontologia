Public Class Recibo_Pago

    Public Sub imprimir(ByVal id As Integer)
        'Dim carta As PageSettings
        'Dim papel As PaperKind
        'papel = PaperKind.Letter

        'Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1, id)
        'Me.ReportViewer1.SetPageSettings(carta)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Reportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
End Class
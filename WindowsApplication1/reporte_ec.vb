Public Class reporte_ec
    Public Sub estado_cuenta(ByRef id As Integer)
        'Me.DataTable1TableAdapter.Fill(Me.DataSet2.DataTable1, id)
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet2.DataTable1' Puede moverla o quitarla según sea necesario.

    End Sub
End Class
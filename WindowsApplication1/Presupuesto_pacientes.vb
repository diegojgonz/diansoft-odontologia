Imports MySql.Data.MySqlClient

Public Class Presupuesto_pacientes

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        reporte_presupuesto.MdiParent = Principal.MdiParent
        reporte_presupuesto.Show()
        reporte_presupuesto.imprimir_presupuesto(presupuesto.idper)
    End Sub

    Private Sub Presupuesto_pacientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String
        Dim consulta As MySqlDataAdapter
        Dim dt As New DataTable
        query = "SELECT fecha_at AS FECHA,nombre as Descripcion,pieza as Pieza,tipo AS Tipo,costo as Monto FROM trabajos " _
            + "WHERE persona_id='" + presupuesto.idper + "' AND estado='Presupuesto'"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            DataGridView1.DataSource = dt
            If dt.Rows.Count > 0 Then
                Dim total As Decimal
                For i As Integer = 0 To dt.Rows.Count - 1
                    total = total + CDec(dt.Rows(i).ItemArray(4).ToString)
                Next
                TextBox1.Text = total.ToString
            End If
        Catch ex As Exception
            MsgBox("error - " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class
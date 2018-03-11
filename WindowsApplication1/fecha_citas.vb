Imports MySql.Data.MySqlClient
Public Class fecha_citas
    Public cedula_cita As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim query As String
        Dim comando As MySqlCommand
        query = "UPDATE persona SET proxima_visita='" + CDate(MonthCalendar1.SelectionRange.Start.ToString).ToString("yyyy-MM-dd") + "' WHERE cedula='" + cedula_cita + "' "
        comando = New MySqlCommand(query, conexion_actual)
        Try
            conexion_actual.Open()
            comando.ExecuteNonQuery()
            conexion_actual.Close()
            MsgBox("Cita agregada Para " + Odontograma.nombre_paciente, MsgBoxStyle.Information, "DianSoft Odontologia")
            Me.Close()
        Catch ex As Exception
            MsgBox("error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub
End Class
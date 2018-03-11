Imports MySql.Data.MySqlClient

Public Class PacientesCita
    Private Sub PacientesCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pacientesHoy()
    End Sub
    Private Sub pacientesHoy()
        Dim sql As String
        Dim dt As New DataTable
        Dim consulta As MySqlDataAdapter

        Try
            Call conectar()
            sql = "SELECT p.id,p.nombre,c.hora,c.atendido,c.observacion FROM persona p INNER JOIN cita c ON p.id = c.persona_id WHERE c.fecha_at = '" & Now.ToString("yyyy-M-d") & "'"
            conexion_actual.Open()
            consulta = New MySqlDataAdapter(sql, conexion_actual)
            consulta.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    DataGridView1.Rows.Add(dt.Rows(i).Item(0).ToString, dt.Rows(i).Item(1).ToString, dt.Rows(i).Item(2).ToString, dt.Rows(i).Item(3).ToString, dt.Rows(i).Item(4).ToString)
                Next
            Else
                MsgBox("No hay pacientes por atender Hoy", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox("Se ha presentado un problema consultando los pacientes que seran atendidos hoy, con el siguiente mensaje: " & ex.Message, MsgBoxStyle.Critical)
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim sql As String
        Dim consulta As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim dt As New DataTable
        Try
            sql = "SELECT p.id,p.nombre,c.hora,c.atendido,c.observacion FROM persona p INNER JOIN cita c ON p.id = c.persona_id WHERE c.fecha_at = '" & CDate(MonthCalendar1.SelectionRange.Start.ToString).ToString("yyyy-MM-dd") & "'"
            conexion_actual.Open()
            consulta = New MySql.Data.MySqlClient.MySqlDataAdapter(sql, conexion_actual)
            consulta.Fill(dt)
            conexion_actual.Close()
            DataGridView1.Rows.Clear()
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    DataGridView1.Rows.Add(dt.Rows(i).Item(0).ToString, dt.Rows(i).Item(1).ToString, dt.Rows(i).Item(2).ToString, dt.Rows(i).Item(3).ToString, dt.Rows(i).Item(4).ToString)
                Next
            End If
        Catch MyEx As MySql.Data.MySqlClient.MySqlException
            MsgBox("Hubo un problema cargando los paciente por atender a la fecha seleccionada, con el siguiente mensaje de error: " & MyEx.Message)
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        Catch ex As Exception
            MsgBox("Hubo un problema cargando los paciente por atender a la fecha seleccionada, con el siguiente mensaje de error: " & ex.Message)
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try
    End Sub
End Class
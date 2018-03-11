Public Class control_cita
    Public id_paciente As Integer
    Private Sub control_cita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim consulta As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Call conectar()
            sql = "SELECT nombre FROM persona  WHERE id='" & id_paciente & "'"
            consulta = New MySql.Data.MySqlClient.MySqlDataAdapter(sql, conexion_actual)
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 0 Then
                Label3.Text = dt.Rows(0).Item(0).ToString
            Else
                MsgBox("No se encontro el paciente", MsgBoxStyle.Exclamation)
                Me.Close()
            End If
            dt = New DataTable
            sql = "SELECT p.id,p.nombre,c.hora,c.atendido,c.observacion FROM persona p INNER JOIN cita c ON p.id = c.persona_id WHERE c.fecha_at = '" & Now.ToString("yyyy-M-d") & "'"
            conexion_actual.Open()
            consulta = New MySql.Data.MySqlClient.MySqlDataAdapter(sql, conexion_actual)
            consulta.Fill(dt)
            conexion_actual.Close()
            MaterialListView2.Items.Clear()
            If dt.Rows.Count > 0 Then
                Dim item = New ListViewItem()
                Dim i As Integer = 0
                For Each drw As DataRow In dt.Rows
                    item = MaterialListView2.Items.Add(drw.Item("nombre").ToString, i)
                    item.SubItems.Add(drw.Item("hora").ToString)
                    item.SubItems.Add(drw.Item("observacion").ToString)
                    'MaterialListView2.Items.Add(item)
                    i = i + 1
                Next
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox("Hubo un Problema consultando el Paciente, con el siguiente mesnaje: " & ex.Message, MsgBoxStyle.Critical)
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
            Me.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim comando As MySql.Data.MySqlClient.MySqlCommand
        Try
            Call conectar()
            sql = "INSERT INTO cita(persona_id,fecha_at,proxima_cita,hora,atendido,observacion) VALUE('" & id_paciente & "','" & Now.ToString("yyyy-MM-dd") & "','" & CDate(MonthCalendar1.SelectionRange.Start.ToString).ToString("yyyy-MM-dd") & "','" & DateTimePicker1.Text & "','','" & RichTextBox1.Text & "') "
            comando = New MySql.Data.MySqlClient.MySqlCommand(sql, conexion_actual)
            conexion_actual.Open()
            comando.ExecuteNonQuery()
            conexion_actual.Close()
            MsgBox("Cita Guardada correctamente", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox("Hubo un problema al guardar la informacion de la cita, con el siguiente error: " & ex.Message, MsgBoxStyle.Critical)
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
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
            MaterialListView2.Items.Clear()
            If dt.Rows.Count > 0 Then
                Dim item = New ListViewItem()
                Dim i As Integer = 0
                For Each drw As DataRow In dt.Rows
                    item = MaterialListView2.Items.Add(drw.Item("nombre").ToString, i)
                    item.SubItems.Add(drw.Item("hora").ToString)
                    item.SubItems.Add(drw.Item("observacion").ToString)
                    'MaterialListView2.Items.Add(item)
                    i = i + 1
                Next
            End If
        Catch ex As Exception
            MsgBox("Hubo un problema cargando los paciente por atender a la fecha seleccionada, con el siguiente mensaje de error: " & ex.Message)
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try
    End Sub
End Class
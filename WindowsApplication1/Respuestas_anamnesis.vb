Imports MySql.Data.MySqlClient
Public Class Respuestas_anamnesis
    Public id_paciente As String
    Public nombre_paciente As String
    Sub respuestas()


    End Sub
    Private Sub Respuestas_anamnesis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String
        Dim consulta As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim columna1 As New DataGridViewColumn
        query = "SELECT id,descripcion as Preguntas FROM anamnesis"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
            End If
            Label2.Text = nombre_paciente
            DataGridView1.Columns.Add("columna1", "Respuesta")
            Dim col As DataGridViewColumn = DataGridView1.Columns("Preguntas")
            Dim col2 As DataGridViewColumn = DataGridView1.Columns("id")
            col2.Visible = False
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            col.ReadOnly = True
            Call respuestas()
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim query As String
        Dim comando As MySqlCommand
        Dim consulta As MySqlDataAdapter
        Dim dt As New DataTable
        Try
            For i As Integer = 0 To DataGridView1.RowCount - 1
                query = "SELECT * FROM respuestas WHERE persona_id='" + id_paciente + "' AND anamnesis_id='" + DataGridView1.Rows(i).Cells(0).Value.ToString + "'"
                consulta = New MySqlDataAdapter(query, conexion_actual)
                conexion_actual.Open()
                consulta.Fill(dt)
                conexion_actual.Close()
                If dt.Rows.Count > 0 Then
                    query = "UPDATE respuestas SET respuesta='" + DataGridView1.Rows(i).Cells(2).Value.ToString + "' WHERE persona_id='" + id_paciente + "' AND anamnesis_id='" + DataGridView1.Rows(i).Cells(0).Value.ToString + "'"
                    comando = New MySqlCommand(query, conexion_actual)
                    conexion_actual.Open()
                    comando.ExecuteNonQuery()
                    conexion_actual.Close()
                    dt = New DataTable
                Else
                    query = "INSERT INTO respuestas(persona_id,anamnesis_id,respuesta) " _
                            + "VALUES('" + id_paciente + "','" + DataGridView1.Rows(i).Cells(0).Value.ToString + "','" + DataGridView1.Rows(i).Cells(0).Value.ToString + "')"
                    comando = New MySqlCommand(query, conexion_actual)
                    conexion_actual.Open()
                    comando.ExecuteNonQuery()
                    conexion_actual.Close()
                    dt = New DataTable
                End If
            Next
            MsgBox("La Operacion se realizó Correctamente", MsgBoxStyle.Information, "DianSoft Odontologia")
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim query As String
        Dim consulta As MySqlDataAdapter
        Dim dt2 As New DataTable
        Try
            If id_paciente <> "" Then
                Dim c As Integer = 0
                For i As Integer = 0 To DataGridView1.RowCount - 1
                    query = "SELECT respuesta FROM respuestas WHERE persona_id='" + id_paciente + "' AND anamnesis_id='" + DataGridView1.Rows(i).Cells(0).Value.ToString + "'"
                    consulta = New MySqlDataAdapter(query, conexion_actual)
                    conexion_actual.Open()
                    consulta.Fill(dt2)
                    conexion_actual.Close()
                    If dt2.Rows.Count > 0 Then
                        c = c + 1
                        DataGridView1.Rows(i).Cells(2).Value = dt2.Rows(0).ItemArray(0).ToString
                    End If
                    dt2 = New DataTable
                Next
                If c = 0 Then
                    MsgBox("No Posee Respuestas", MsgBoxStyle.Exclamation, "Odontotec")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub
End Class
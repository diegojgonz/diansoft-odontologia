Imports MySql.Data.MySqlClient
Public Class Anamnesis
    Public id_pregunta As String
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Sub actualizar()
        Dim query As String
        Dim consulta As MySqlDataAdapter
        Dim dt As New DataTable
        query = "SELECT * FROM anamnesis"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String
        Dim consulta As MySqlDataAdapter
        Dim dt As New DataTable
        query = "SELECT * FROM anamnesis"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim query As String
        Dim comando As MySqlCommand
        Dim consulta As MySqlDataAdapter
        Dim dt As New DataTable
        query = "SELECT * FROM anamnesis WHERE id='" + id_pregunta + "'"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 0 Then
                query = "UPDATE anamnesis SET descripcion='" + TextBox1.Text + "' WHERE id='" + id_pregunta + "'"
                comando = New MySqlCommand(query, conexion_actual)
                Try
                    conexion_actual.Open()
                    comando.ExecuteNonQuery()
                    conexion_actual.Close()
                    MsgBox("Pregunta Modificada Correctamnete", MsgBoxStyle.Information, "DianSoft Odontologia")
                    id_pregunta = ""
                Catch ex As Exception
                    MsgBox("Error Modificacion: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
                End Try
            Else
                query = "INSERT INTO anamnesis(descripcion) VALUES('" + TextBox1.Text + "')"
                comando = New MySqlCommand(query, conexion_actual)
                Try
                    conexion_actual.Open()
                    comando.ExecuteNonQuery()
                    conexion_actual.Close()
                    MsgBox("Pregunta Guardada Correctamnete", MsgBoxStyle.Information, "DianSoft Odontologia")
                Catch ex As Exception
                    MsgBox("Error Almacenando: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
                End Try
            End If
        Catch ex As Exception
            MsgBox("Error consulta: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
        Call actualizar()
        TextBox1.Text = ""
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MsgBox("Esta seguro que desea Eliminar la Pregunta?", MsgBoxStyle.YesNo, "DianSoft Odontologia") = vbYes Then
            Dim query As String
            Dim comando As MySqlCommand
            query = "DELETE FROM anamnesis WHERE id='" + DataGridView1.CurrentRow.Cells(0).Value.ToString + "'"
            comando = New MySqlCommand(query, conexion_actual)
            Try
                conexion_actual.Open()
                comando.ExecuteNonQuery()
                conexion_actual.Close()
                MsgBox("Datos Eliminados Correctamente", MsgBoxStyle.Information, "DianSoft Odontologia")
                Call actualizar()

            Catch ex As Exception
                MsgBox("Error:" + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim query As String
        Dim consulta As MySqlDataAdapter
        Dim dt As New DataTable
        id_pregunta = DataGridView1.CurrentRow.Cells(0).Value.ToString
        query = "SELECT * FROM anamnesis WHERE id='" + DataGridView1.CurrentRow.Cells(0).Value.ToString + "'"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 0 Then
                TextBox1.Text = dt.Rows(0).ItemArray(1).ToString
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        id_pregunta = ""
        TextBox1.Text = ""
    End Sub
End Class
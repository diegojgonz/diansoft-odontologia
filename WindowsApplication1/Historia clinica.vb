Option Explicit On
Option Strict On
Imports MySql.Data.MySqlClient

Public Class historia_clinica
    Public id As String
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub wform_informe_alternativo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub consultar(ByVal cedula As String)
        Dim r As New DataTable
        Dim r2 As New DataTable
        Dim query As String
        Dim comand As MySqlDataAdapter
        Call conectar()
        query = "SELECT * FROM persona WHERE cedula='" + cedula + "'"
        comand = New MySqlDataAdapter(query, conexion_actual)
        conexion_actual.Open()
        comand.Fill(r)
        conexion_actual.Close()
        Texcedulaallternativo.Text = cedula
        If r.Rows.Count > 0 Then
            id = r.Rows(0).ItemArray(0).ToString()
            lblpaciente.Text = r.Rows(0).ItemArray(1).ToString()
            lblfecha.Text = CDate(r.Rows(0).ItemArray(3).ToString()).ToString("dd/MM/yyyy")
            lbledad.Text = r.Rows(0).ItemArray(4).ToString()
            Label2.Visible = True
            query = "SELECT * FROM historial WHERE id='" + id + "'"
            comand = New MySqlDataAdapter(query, conexion_actual)
            Try
                conexion_actual.Open()
                comand.Fill(r2)
                conexion_actual.Close()
                If r2.Rows.Count > 0 Then
                    Texmamografia.Text = r2.Rows(0).ItemArray(2).ToString()
                End If
            Catch ex As Exception
                MsgBox("error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
            End Try
        Else
            MsgBox("La Cédula del Paciente No Existe", MsgBoxStyle.Information, "DianSoft Odontologia")
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim r As New DataTable
        Dim r2 As New DataTable
        Dim query As String
        Dim comand As MySqlDataAdapter
        Call conectar()
        query = "SELECT * FROM persona WHERE cedula='" + Texcedulaallternativo.Text + "'"
        comand = New MySqlDataAdapter(query, conexion_actual)
        conexion_actual.Open()
        comand.Fill(r)
        conexion_actual.Close()
        If r.Rows.Count > 0 Then
            id = r.Rows(0).ItemArray(0).ToString()
            lblpaciente.Text = r.Rows(0).ItemArray(1).ToString()
            lblfecha.Text = CDate(r.Rows(0).ItemArray(3).ToString()).ToString("dd/MM/yyyy")
            lbledad.Text = r.Rows(0).ItemArray(4).ToString()
            Label2.Visible = True
            query = "SELECT * FROM historial WHERE persona_id='" + id + "'"
            comand = New MySqlDataAdapter(query, conexion_actual)
            Try
                conexion_actual.Open()
                comand.Fill(r2)
                conexion_actual.Close()
                If r2.Rows.Count > 0 Then
                    Texmamografia.Text = r2.Rows(0).ItemArray(2).ToString()
                End If
            Catch ex As Exception
                MsgBox("error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
            End Try
        Else
            MsgBox("La Cédula del Paciente No Existe", MsgBoxStyle.Information, "DianSoft Odontologia")
        End If
    End Sub

    Private Sub Btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnguardar.Click
        Dim query As String
        Dim consul As MySqlDataAdapter
        Dim comand As MySqlCommand
        Dim r As New DataTable
        If id <> "" Then
            query = "SELECT * FROM historial WHERE persona_id='" + id + "'"
            consul = New MySqlDataAdapter(query, conexion_actual)
            Try
                conexion_actual.Open()
                consul.Fill(r)
                conexion_actual.Close()
                If r.Rows.Count > 0 Then
                    query = "UPDATE historial SET historia='" + Texmamografia.Text + "' WHERE persona_id='" + id + "'"
                    comand = New MySqlCommand(query, conexion_actual)
                    conexion_actual.Open()
                    comand.ExecuteNonQuery()
                    conexion_actual.Close()
                    MsgBox("Datos Actualizados Correctamente", MsgBoxStyle.Information, "DianSoft Odontologia")
                Else
                    query = "INSERT INTO historial(persona_id,historia) VALUES ('" + id + "','" + Texmamografia.Text + "')"
                    comand = New MySqlCommand(query, conexion_actual)
                    conexion_actual.Open()
                    comand.ExecuteNonQuery()
                    conexion_actual.Close()
                    MsgBox("Datos Guardados Correctamente", MsgBoxStyle.Information, "DianSoft Odontologia")
                End If
            Catch ex As Exception
                MsgBox("Error:" + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
            End Try
        Else
            MsgBox("debe consultar un paciente", MsgBoxStyle.Critical, "DianSoft Odontologia")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
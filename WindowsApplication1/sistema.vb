Imports MySql.Data.MySqlClient
Imports System.IO

Public Class sistema
    Public enc As String
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim cd As New OpenFileDialog
        cd.Filter = "formato |*.jpg"
        cd.ShowDialog()
        If cd.FileName.ToString <> "" Then
            PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(cd.FileName)
        End If
    End Sub
    'convertir imagen a binario
    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim query As String
        Dim comando As MySqlCommand
        Dim dt As New DataTable
        Dim consulta As MySqlDataAdapter
        Dim imagen() As Byte
        imagen = Imagen_Bytes(PictureBox1.BackgroundImage)
        query = "SELECT * FROM sistema"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 0 Then
                query = "UPDATE sistema SET nombre='" + TextBox1.Text + "',direccion='" + RichTextBox1.Text + "',fax='" _
                        + TextBox3.Text + "',telefono_movil='" + TextBox2.Text + "',telefono_fijo='" + TextBox4.Text + "',pie_pagina='" + RichTextBox2.Text + "',logo=?imagen"
                comando = New MySqlCommand(query, conexion_actual)
                comando.Parameters.AddWithValue("?imagen", imagen)
                Try
                    conexion_actual.Open()
                    comando.ExecuteNonQuery()
                    conexion_actual.Close()
                    MsgBox("Datos Modificados Correctamente", MsgBoxStyle.Information, "DianSoft Odontologia")
                Catch ex As Exception
                    MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
                End Try
            Else
                query = "INSERT INTO sistema(nombre,direccion,fax,telefono_movil,telefono_fijo,pie_pagina,logo) " _
            + "VALUES('" + TextBox1.Text + "','" + RichTextBox1.Text + "','" + TextBox3.Text + "','" + TextBox2.Text + "','" + TextBox4.Text + "','" + RichTextBox2.Text + "',?imagen)"
                comando = New MySqlCommand(query, conexion_actual)
                comando.Parameters.AddWithValue("?imagen", imagen)
                Try
                    conexion_actual.Open()
                    comando.ExecuteNonQuery()
                    conexion_actual.Close()
                    MsgBox("Datos Guardados Correctamente", MsgBoxStyle.Information, "DianSoft Odontologia")
                Catch ex As Exception
                    MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
                End Try
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try

    End Sub

    Private Sub sistema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String
        Dim consulta As MySqlDataAdapter
        Dim dt As New DataTable
        query = "SELECT * FROM sistema"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 0 Then
                TextBox1.Text = dt.Rows(0).ItemArray(1).ToString
                RichTextBox1.Text = dt.Rows(0).ItemArray(2).ToString
                TextBox2.Text = dt.Rows(0).ItemArray(3).ToString
                TextBox3.Text = dt.Rows(0).ItemArray(4).ToString
                TextBox4.Text = dt.Rows(0).ItemArray(5).ToString
                RichTextBox2.Text = dt.Rows(0).ItemArray(6).ToString
                PictureBox1.BackgroundImage = Bytes_Imagen(dt.Rows(0).ItemArray(7))
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

End Class
Imports MySql.Data.MySqlClient
Public Class Agregar_trabajos
    Public id_catalogo As String
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Sub llenar()
        Dim query As String
        Dim consulta As MySqlDataAdapter
        Dim dt As New DataTable
        query = "SELECT * FROM catalogo WHERE id='" + id_catalogo + "'"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 0 Then
                TextBox1.Text = dt.Rows(0).ItemArray(2).ToString
                ComboBox2.Text = dt.Rows(0).ItemArray(3).ToString
                ComboBox1.Text = dt.Rows(0).ItemArray(1).ToString
                TextBox2.Text = dt.Rows(0).ItemArray(4).ToString
                TextBox3.Text = dt.Rows(0).ItemArray(5).ToString
                TextBox4.Text = dt.Rows(0).ItemArray(6).ToString
                TextBox5.Text = dt.Rows(0).ItemArray(7).ToString
                TextBox6.Text = dt.Rows(0).ItemArray(8).ToString
            End If
        Catch ex As Exception
            MsgBox("error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim query As String
        Dim comando As MySqlCommand
        Dim consulta As MySqlDataAdapter
        Dim dt As New DataTable
        query = "SELECT * FROM catalogo WHERE id='" + id_catalogo + "'"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 0 Then
                query = "UPDATE catalogo SET tipo='" + ComboBox1.Text + "',descripcion='" + TextBox1.Text + "',aplicacion='" + ComboBox2.Text + "',costo='" + TextBox2.Text + "',costo_pac1='" + TextBox3.Text + "',costo_pac2='" + TextBox4.Text + "',costo_pac3='" + TextBox5.Text + "',observaciones='" + TextBox6.Text + "' WHERE id='" + id_catalogo + "'"
                comando = New MySqlCommand(query, conexion_actual)
                Try
                    conexion_actual.Open()
                    comando.ExecuteNonQuery()
                    conexion_actual.Close()
                    MsgBox("Datos Modificados Correctamente", MsgBoxStyle.Information, "DianSoft Odontologia")
                Catch ex As Exception
                    MsgBox("error Modificacion: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
                    If conexion_actual.State = ConnectionState.Open Then
                        conexion_actual.Close()
                    End If
                End Try
            Else
                query = "INSERT INTO catalogo(tipo,descripcion,aplicacion,costo,costo_pac1,costo_pac2,costo_pac3,observaciones) " _
                    + "VALUES('" + ComboBox1.Text + "','" + TextBox1.Text + "','" + ComboBox2.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')"
                comando = New MySqlCommand(query, conexion_actual)
                Try
                    conexion_actual.Open()
                    comando.ExecuteNonQuery()
                    conexion_actual.Close()
                    MsgBox("Datos Guardados Correctamente", MsgBoxStyle.Information, "DianSoft Odontologia")
                Catch ex As Exception
                    MsgBox("Error Insercion: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
                    If conexion_actual.State = ConnectionState.Open Then
                        conexion_actual.Close()
                    End If
                End Try
            End If
        Catch ex As Exception
            MsgBox("error Consulta: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try
        Catalogos.actualizar()
        id_catalogo = "0"
        Me.Close()
    End Sub
    Sub limpiar()
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            ElseIf TypeOf c Is ComboBox Then
                c.Text = ""
            End If
        Next
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call limpiar()
        id_catalogo = 0
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MsgBox("Esta Seguro que desea Eliminar los datos?", MsgBoxStyle.YesNo, "DianSoft Odontologia") = vbYes Then
            Dim query As String
            Dim comando As MySqlCommand
            query = "DELETE FROM catalogo WHERE id='" + id_catalogo + "'"
            comando = New MySqlCommand(query, conexion_actual)
            Try
                conexion_actual.Open()
                comando.ExecuteNonQuery()
                conexion_actual.Close()
                MsgBox("Datos Eliminados Correctamente", MsgBoxStyle.Information, "DianSoft Odontologia")
            Catch ex As Exception
                MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
                If conexion_actual.State = ConnectionState.Open Then
                    conexion_actual.Close()
                End If
            End Try
        End If
        Catalogos.actualizar()
        Me.Close()
    End Sub
End Class
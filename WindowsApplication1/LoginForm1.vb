Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports WindowsApplication1.conexion
Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Call conectar()
        Dim query As String
        Dim comando As MySqlDataAdapter
        Dim dt As New DataTable

        If UsernameTextBox.Text <> "" Then
            If PasswordTextBox.Text <> "" Then
                query = "SELECT * FROM usuarios WHERE user_usuario='" + UsernameTextBox.Text + "' AND pass_usuario='" + PasswordTextBox.Text + "'"
                comando = New MySqlDataAdapter(query, conexion_actual)
                Try
                    conexion_actual.Open()
                    comando.Fill(dt)
                    conexion_actual.Close()
                    If dt.Rows.Count > 0 Then
                        Me.Hide()
                        Principal.ShowDialog()
                    Else
                        MsgBox("Nombre de Usuario o Contraseña no son Validos", MsgBoxStyle.Critical, "Aviso")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MsgBox("Debe Ingresar una Contraseña", MsgBoxStyle.Critical, "Aviso")
            End If
        Else
            MsgBox("Debe Ingresar un Nombre de Usuario", MsgBoxStyle.Critical, "Aviso")

        End If
        
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class

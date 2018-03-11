Imports MySql.Data.MySqlClient

Public Class agregar_usuario

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call conectar()
        Dim query As String ' variable que se utiliza para realizar la consulta en mysql como cadena.
        Dim comando As MySqlCommand 'variable objeto que almacena la consulta
        Dim consulta As MySqlDataAdapter
        Dim dt As New DataTable
        If TextBox6.Text <> "" Then
            query = "SELECT * FROM usuarios WHERE cedula ='" + TextBox6.Text + "'"
            consulta = New MySqlDataAdapter(query, conexion_actual)
            Try
                conexion_actual.Open()
                consulta.Fill(dt)
                conexion_actual.Close()
                If dt.Rows.Count > 0 Then
                    MsgBox("El USUARIO YA ESTA REGISTRADO", vbCritical, "AVISO!")
                Else
                    If TextBox6.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" Then
                        If TextBox4.Text = TextBox5.Text Then
                            ' realiza la Insercion en mysql
                            query = "INSERT INTO usuarios(nombre,apellido,cedula,direccion,telefono,user,pass,nivel) " _
                                + "VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox6.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + ComboBox1.Text + "');"
                            comando = New MySqlCommand(query, conexion_actual) 'crea el objeto con la consulta realizada
                            Try
                                conexion_actual.Open() 'Abre la Conexion
                                comando.ExecuteNonQuery() 'ejecuta el query almacenado en el objeto
                                conexion_actual.Close() ' cierra la conexion
                                MessageBox.Show("Los datos se Guardaron Correctamente")
                            Catch ex As Exception ' si existe un error al momento de ejecutar la conexion
                                MessageBox.Show("Error al ingresar los datos " + ex.Message)
                            End Try
                        Else
                            MsgBox("Las Contraseñas no son Iguales, Verifique! (*)", vbCritical, "IMPORTANTES!")
                        End If

                    Else
                        MsgBox("DEBE LLENAR LOS CAMPOS OBLIGATORIOS REPRESENTADOS POR (*)", vbNormal, "IMPORTANTES!")
                        If TextBox6.Text = "" Then
                            TextBox6.BorderStyle = BorderStyle.FixedSingle
                        End If
                        If TextBox3.Text = "" Then
                            TextBox3.BorderStyle = BorderStyle.FixedSingle
                        End If
                        If TextBox4.Text = "" Then
                            TextBox4.BorderStyle = BorderStyle.FixedSingle
                        End If
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("IMPOSIBLE REALIZAR LA CONSULTA " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Public Sub LimpiarControles()

        Dim c As Control

        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
            ComboBox1.SelectedIndex = -1
        Next
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call LimpiarControles()
    End Sub
End Class
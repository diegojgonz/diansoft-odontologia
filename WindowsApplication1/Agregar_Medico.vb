Imports MySql.Data.MySqlClient
Public Class agregar_medico

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call conectar()
        Dim query As String ' variable que se utiliza para realizar la consulta en mysql como cadena.
        Dim comando As MySqlCommand 'variable objeto que almacena la consulta
        Dim consulta As MySqlDataAdapter
        Dim dt As New DataTable
        Dim fecha As String
        Dim fechanac As String
        Dim f() As String
        Dim fn() As String
        If TextBox6.Text <> "" Then
            query = "SELECT * FROM doctores WHERE cedula ='" + TextBox6.Text + "'"
            consulta = New MySqlDataAdapter(query, conexion_actual)
            Try
                conexion_actual.Open()
                consulta.Fill(dt)
                conexion_actual.Close()
                If dt.Rows.Count > 0 Then
                    MsgBox("El MEDICO YA ESTA REGISTRADO", vbCritical, "AVISO!")
                Else
                    If TextBox6.Text <> "" And TextBox1.Text <> "" And Label13.Text <> 0 Then
                        fecha = DateTimePicker1.Text
                        f = fecha.Split("/") ' corta la cadena y llena el arreglo donde cosiga "/"
                        fecha = f(2) + "-" + f(1) + "-" + f(0) ' une el arreglo invertido
                        fechanac = DateTimePicker2.Text
                        fn = fechanac.Split("/")
                        fechanac = fn(2) + "-" + fn(1) + "-" + fn(0) ' une el arreglo invertido
                        ' realiza la consulta en mysql
                        query = "INSERT INTO doctores(nombre,cedula,fechanac,edad,direccion,telefono,fecharegistro) " _
                            + "VALUES ('" + TextBox1.Text + "','" + TextBox6.Text + "','" + fechanac + "','" + Label13.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + fecha + "');"
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
                        MsgBox("DEBE LLENAR LOS CAMPOS OBLIGATORIOS REPRESENTADOS POR (*)", vbNormal, "IMPORTANTES!")
                        If TextBox6.Text = "" Then
                            TextBox6.BorderStyle = BorderStyle.FixedSingle
                        End If
                        If TextBox1.Text = "" Then
                            TextBox1.BorderStyle = BorderStyle.FixedSingle
                        End If
                        If Label13.Text = 0 Then
                            Label13.BorderStyle = BorderStyle.FixedSingle
                        End If
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("IMPOSIBLE REALIZAR LA CONSULTA " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub DateTimePicker2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker2.TextChanged
        Dim intDias As Integer
        Dim edad As Integer
        intDias = DateDiff("d", DateTimePicker2.Text, Now, vbMonday) ' devuelve la cantidad de dias en un intervalo de fecha
        edad = intDias / 365
        If edad < 0 Then
            Label13.Text = "0"
            Label13.Visible = True
        Else
            Label13.Text = edad.ToString
            Label13.Visible = True
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
        Next c
        Label13.Text = "0"
        DateTimePicker1.Text = Now
        DateTimePicker2.Text = Now
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call LimpiarControles()
    End Sub
End Class
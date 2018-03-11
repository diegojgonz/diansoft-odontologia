Imports MySql.Data.MySqlClient


Public Class Agregar_paciente
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
            query = "SELECT * FROM persona WHERE cedula ='" + TextBox6.Text + "'"
            consulta = New MySqlDataAdapter(query, conexion_actual)
            Try
                conexion_actual.Open()
                consulta.Fill(dt)
                conexion_actual.Close()
                If dt.Rows.Count > 0 Then
                    MsgBox("El PACIENTE YA ESTA REGISTRADO", vbCritical, "AVISO!")
                Else
                    If TextBox6.Text <> "" And TextBox1.Text <> "" And TextBox8.Text <> "" And DateTimePicker2.Text <> Now Then
                        fecha = DateTimePicker1.Text
                        f = fecha.Split("/") ' corta la cadena y llena el arreglo donde cosiga "/"
                        fecha = f(2) + "-" + f(1) + "-" + f(0) ' une el arreglo invertido
                        fechanac = DateTimePicker2.Text
                        fn = fechanac.Split("/")
                        fechanac = fn(2) + "-" + fn(1) + "-" + fn(0) ' une el arreglo invertido
                        ' realiza la consulta en mysql
                        query = "INSERT INTO persona(nombre,cedula,fechanac,edad,fecha_at,representante,telefono,direccion,alergico,hismedica,histodonto,proxima_visita,tipo) " _
                            + "VALUES ('" + TextBox1.Text + "','" + TextBox6.Text + "','" + fechanac + "','" + Label13.Text + "','" + fecha + "','" + TextBox2.Text + "','" + TextBox9.Text + "','" + TextBox8.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox7.Text + "','" + CDate(Today.ToShortDateString).ToString("yyyy-MM-dd") + "','" + ComboBox1.Text + "')"
                        comando = New MySqlCommand(query, conexion_actual) 'crea el objeto con la consulta realizada
                        Try
                            conexion_actual.Open() 'Abre la Conexion
                            comando.ExecuteNonQuery() 'ejecuta el query almacenado en el objeto
                            conexion_actual.Close() ' cierra la conexion
                            If MsgBox("Los datos se Guardaron Correctamente! Desea Realizar el Odontograma?", MsgBoxStyle.YesNo, "Confirmacion!") = MsgBoxResult.Yes Then
                                If TextBox6.Text <> "" Then
                                    Odontograma.cedula.Text = TextBox6.Text

                                    Odontograma.Show()
                                    Me.Close()
                                End If
                            End If
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
                        If TextBox8.Text = "" Then
                            TextBox8.BorderStyle = BorderStyle.FixedSingle
                        End If
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("IMPOSIBLE REALIZAR LA CONSULTA " + ex.Message)
            End Try
        End If

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub ConsultarRegistroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consultar_Pacientes.Show()
    End Sub

    Private Sub CrearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Odontograma.cedula.Text = TextBox6.Text
        Odontograma.Show()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Odontograma.cedula.Text = TextBox6.Text
        Odontograma.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox6.Text <> "" Then
            Odontograma.cedula.Text = TextBox6.Text

            Odontograma.Show()
        Else
            MsgBox("NO HAY PACINETE SELECCIONADO", vbCritical, "ERROR")
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call LimpiarControles()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call historia_clinica.consultar(TextBox1.Text)
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class

Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Consultar_Pacientes
    Dim id As String
    Dim nombre As String
    Public Sub LimpiarControles(ByVal f As Form)

        Dim c As Control
        For Each c In GroupPanel1.Controls
            If TypeOf c Is MaterialSkin.Controls.MaterialSingleLineTextField Then
                c.Text = ""
            End If
        Next c
        Label13.Text = "0"
        TextBox8.Text = ""
        DateTimePicker1.Text = Now
        DateTimePicker2.Text = Now
        id = ""
        If Not IsNothing(PictureBox1.BackgroundImage) Then
            PictureBox1.BackgroundImage.Dispose()
        End If
        PictureBox1.BackgroundImage = Nothing

    End Sub
    Sub llenar_formulario(ByVal cedula As Integer)
        Call conectar()
        Dim query As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim lectura As MySqlDataAdapter
        dt.Rows.Clear()
        query = "SELECT * FROM persona " _
        + "WHERE cedula = '" + cedula.ToString + "'"

        lectura = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            lectura.Fill(dt)
            conexion_actual.Close()
            TextBox1.Text = dt.Rows(0).ItemArray(1).ToString()
            TextBox6.Text = dt.Rows(0).ItemArray(2).ToString()
            DateTimePicker2.Text = dt.Rows(0).ItemArray(3).ToString
            Label13.Text = dt.Rows(0).ItemArray(4).ToString()
            DateTimePicker1.Text = dt.Rows(0).ItemArray(5).ToString()
            TextBox2.Text = dt.Rows(0).ItemArray(6).ToString()
            TextBox9.Text = dt.Rows(0).ItemArray(7).ToString()
            TextBox8.Text = dt.Rows(0).ItemArray(8).ToString()
            TextBox4.Text = dt.Rows(0).ItemArray(9).ToString()
            TextBox5.Text = dt.Rows(0).ItemArray(10).ToString()
            TextBox7.Text = dt.Rows(0).ItemArray(11).ToString()
            ComboBox1.Text = dt.Rows(0).ItemArray(13).ToString()
            id = dt.Rows(0).ItemArray(0).ToString()
            nombre = dt.Rows(0).ItemArray(1).ToString()
            PictureBox1.BackgroundImage = Bytes_Imagen(dt.Rows(0).ItemArray(16))

        Catch ex As Exception
            MessageBox.Show("Error al consultar / " + ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call conectar()
        Dim query As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim lectura As MySqlDataAdapter
        If TextBox6.Text <> "" Then
            query = "SELECT * FROM persona " _
                + "WHERE cedula = '" + TextBox6.Text + "'"
        Else
            query = "SELECT cedula,nombre,fechanac,edad FROM persona " _
            + "WHERE nombre like '%" + TextBox1.Text + "%'"
        End If

        lectura = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            lectura.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 1 Then
                BindingSource1.DataSource = dt
                Ayuda_pacientes.DataGridView1.DataSource = BindingSource1.DataSource
                Ayuda_pacientes.Show()
            Else
                If TextBox6.Text <> "" Then
                    Call llenar_formulario(Int(TextBox6.Text))

                Else
                    Call llenar_formulario(dt.Rows(0).ItemArray(0))
                End If
            End If
        Catch ex As Exception
            MsgBox("EL PACIENTE NO EXISTE, VERIFIQUE LOS DATOS!", vbCritical, "AVISO!")
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub


    Private Sub DateTimePicker2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker2.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call LimpiarControles(Me)
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Dim intDias As Integer
        Dim edad As Integer
        intDias = DateDiff("d", DateTimePicker2.Text, Now, vbMonday) ' devuelve la cantidad de dias en un intervalo de fecha
        edad = Int(intDias / 365)
        If edad < 0 Then
            Label13.Text = "0"
            Label13.Visible = True
        Else
            Label13.Text = edad.ToString
            Label13.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox6.Text <> "" Then
            Odontograma.cedula.Text = TextBox6.Text
            Odontograma.id_persona = id
            Odontograma.nombre_paciente = TextBox1.Text
            Odontograma.TextBox1.Text = TextBox6.Text
            Odontograma.TextBox2.Text = TextBox1.Text
            Odontograma.Show()
        Else
            MsgBox("DEBE SELECCIONAR UN PACIENTE", vbCritical, "AVISO!")
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If id <> "" Then
            Call conectar()
            Dim query As String

            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim lectura As MySqlCommand
            Dim fecha As String
            Dim fechanac As String
            Dim f() As String
            Dim fn() As String
            Dim imagen() As Byte
            imagen = Imagen_Bytes(PictureBox1.BackgroundImage)

            fecha = DateTimePicker1.Text
            f = fecha.Split("/") ' corta la cadena y llena el arreglo donde cosiga "/"
            fecha = f(2) + "-" + f(1) + "-" + f(0) ' une el arreglo invertido

            fechanac = DateTimePicker2.Text
            fn = fechanac.Split("/")
            fechanac = fn(2) + "-" + fn(1) + "-" + fn(0) ' une el arreglo invertido
            If TextBox6.Text <> "" Then
                query = "UPDATE persona SET nombre ='" + TextBox1.Text + "',cedula='" + TextBox6.Text + "'," _
                    + "fechanac='" + fechanac + "',edad='" + Label13.Text + "',fecha_at='" + fecha + "'," _
                    + "representante='" + TextBox2.Text + "',telefono='" + TextBox9.Text + "'," _
                    + "direccion='" + TextBox8.Text + "',alergico='" + TextBox4.Text + "'," _
                    + "hismedica='" + TextBox5.Text + "',histodonto='" + TextBox7.Text + "',tipo='" + ComboBox1.Text + "',imagen=?imagen " _
                    + "WHERE cedula = '" + TextBox6.Text + "'"
                lectura = New MySqlCommand(query, conexion_actual)
                lectura.Parameters.AddWithValue("?imagen", imagen)
                Try
                    conexion_actual.Open()
                    lectura.ExecuteNonQuery()
                    conexion_actual.Close()
                    MsgBox("Los datos del paciente se modificó correctamente", MsgBoxStyle.Information)
                    LimpiarControles(Me)
                Catch MyEx As MySqlException
                    MsgBox("Hubo un problena al tratar de modificar el paciente, mensaje MYSQL: " + MyEx.Message, MsgBoxStyle.Critical)
                    If conexion_actual.State = ConnectionState.Open Then
                        conexion_actual.Close()
                    End If
                Catch ex As Exception
                    MsgBox("No se pudo Modificar los Datos / " + ex.Message, MsgBoxStyle.Critical)
                    If conexion_actual.State = ConnectionState.Open Then
                        conexion_actual.Close()
                    End If
                End Try
            End If
        Else
            Call conectar()
            Dim query As String ' variable que se utiliza para realizar la consulta en mysql como cadena.
            Dim comando As MySqlCommand 'variable objeto que almacena la consulta
            Dim consulta As MySqlDataAdapter
            Dim dt As New DataTable
            Dim fecha As String
            Dim fechanac As String
            Dim f() As String
            Dim fn() As String
            Dim imagen() As Byte
            imagen = Imagen_Bytes(PictureBox1.BackgroundImage)

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
                            query = "INSERT INTO persona(nombre,cedula,fechanac,edad,fecha_at,representante,telefono,direccion,alergico,hismedica,histodonto,proxima_visita,tipo,imagen) " _
                            + "VALUES ('" + TextBox1.Text + "','" + TextBox6.Text + "','" + fechanac + "','" + Label13.Text + "','" + fecha + "','" + TextBox2.Text + "','" + TextBox9.Text + "','" + TextBox8.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox7.Text + "','" + CDate(Today.ToShortDateString).ToString("yyyy-MM-dd") + "','" + ComboBox1.Text + "',?imagen)"
                            comando = New MySqlCommand(query, conexion_actual) 'crea el objeto con la consulta realizada
                            comando.Parameters.AddWithValue("?imagen", imagen)
                            Try
                                conexion_actual.Open() 'Abre la Conexion
                                comando.ExecuteNonQuery() 'ejecuta el query almacenado en el objeto
                                conexion_actual.Close() ' cierra la conexion
                                If MsgBox("Los datos se Guardaron Correctamente! Desea Realizar el Odontograma?", MsgBoxStyle.YesNo, "Confirmacion!") = MsgBoxResult.Yes Then
                                    If TextBox6.Text <> "" Then
                                        Odontograma.id_persona = comando.LastInsertedId
                                        Odontograma.Show()
                                        Me.Close()
                                    End If
                                End If
                            Catch ex As Exception ' si existe un error al momento de ejecutar la conexion
                                MsgBox("hubo un problema al ingresar los datos " + ex.Message, MsgBoxStyle.Critical)
                            End Try
                        Else
                            MsgBox("DEBE LLENAR LOS CAMPOS OBLIGATORIOS ", MsgBoxStyle.Exclamation, "IMPORTANTES!")
                        End If
                    End If
                Catch MyEx As MySqlException
                    MsgBox("Hubo un problena al tratar de guardar el paciente, mensaje MYSQL: " + MyEx.Message, MsgBoxStyle.Critical)
                    If conexion_actual.State = ConnectionState.Open Then
                        conexion_actual.Close()
                    End If
                Catch ex As Exception
                    MsgBox("No se pudo guardar los Datos / " + ex.Message, MsgBoxStyle.Critical)
                    If conexion_actual.State = ConnectionState.Open Then
                        conexion_actual.Close()
                    End If
                End Try
            End If
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Call conectar()
        Dim query As String

        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim lectura As MySqlCommand
        If TextBox6.Text <> "" Then
            If MsgBox("ESTA SEGURO QUE DESEA ELIMINAR EL REGISTRO", vbYesNo, "ATENCION!!") = vbYes Then
                query = "DELETE FROM persona " _
                    + "WHERE cedula = '" + TextBox6.Text + "'"
                lectura = New MySqlCommand(query, conexion_actual)
                Try
                    conexion_actual.Open()
                    lectura.ExecuteNonQuery()
                    conexion_actual.Close()
                    MsgBox("LOS DATOS SE ELIMINARON CORRECTAMENTE", vbInformation, "AVISO!")
                Catch ex As Exception
                    MessageBox.Show("No se pudo Eliminar los Datos / " + ex.Message)
                End Try
            End If
        Else
            MsgBox("DEBE CONSULTAR UN REGISTRO!", vbCritical, "ERROR!")
        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Call historia_clinica.consultar(TextBox6.Text)
        historia_clinica.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If id <> "" Then
            Respuestas_anamnesis.id_paciente = id
            Respuestas_anamnesis.nombre_paciente = nombre
            Respuestas_anamnesis.Show()
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If TextBox6.Text <> "" Then
            control_cita.id_paciente = id
            control_cita.ShowDialog()
        Else
            MsgBox("Debe consultar un Paciente", MsgBoxStyle.Exclamation, "DianSoft Odontologia")
        End If
    End Sub

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
End Class
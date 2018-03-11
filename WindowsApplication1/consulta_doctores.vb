Imports MySql.Data.MySqlClient
Public Class consulta_doctores
    Public id As Integer
    Sub llenar_formulario(ByVal cedula As Integer)
        Call conectar()
        Dim query As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim lectura As MySqlDataAdapter
        dt.Rows.Clear()
        query = "SELECT * FROM doctores " _
        + "WHERE cedula = '" + cedula.ToString + "'"

        lectura = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            lectura.Fill(dt)
            conexion_actual.Close()
            id = dt.Rows(0).ItemArray(0).ToString()
            TextBox1.Text = dt.Rows(0).ItemArray(1).ToString()
            TextBox6.Text = dt.Rows(0).ItemArray(2).ToString()
            DateTimePicker2.Text = dt.Rows(0).ItemArray(3).ToString
            Label13.Text = dt.Rows(0).ItemArray(4).ToString()
            TextBox8.Text = dt.Rows(0).ItemArray(5).ToString()
            TextBox9.Text = dt.Rows(0).ItemArray(6).ToString()
            DateTimePicker1.Text = dt.Rows(0).ItemArray(7).ToString()

        Catch ex As Exception
            MessageBox.Show("Error al consultar / " + ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim query As String ' variable que se utiliza para realizar la consulta en mysql como cadena.
        Dim comando As MySqlCommand 'variable objeto que almacena la consulta
        Dim consulta As MySqlDataAdapter
        Dim lectura As MySqlCommand
        Dim dt As New DataTable
        Dim fecha As String
        Dim fechanac As String
        Dim f() As String
        Dim fn() As String

        If id <> 0 Then
            Call conectar()
            fecha = DateTimePicker1.Text
            f = fecha.Split("/") ' corta la cadena y llena el arreglo donde cosiga "/"
            fecha = f(2) + "-" + f(1) + "-" + f(0) ' une el arreglo invertido

            fechanac = DateTimePicker2.Text
            fn = fechanac.Split("/")
            fechanac = fn(2) + "-" + fn(1) + "-" + fn(0) ' une el arreglo invertido
            If TextBox6.Text <> "" Then
                query = "UPDATE doctores SET nombre ='" + TextBox1.Text + "',cedula='" + TextBox6.Text + "'," _
                    + "fechanac='" + fechanac + "',edad='" + Label13.Text + "',fecharegistro='" + fecha + "'," _
                    + "direccion='" + TextBox8.Text + "',telefono='" + TextBox9.Text + "' " _
                    + "WHERE cedula= '" + TextBox6.Text + "'"
                lectura = New MySqlCommand(query, conexion_actual)
                Try
                    conexion_actual.Open()
                    lectura.ExecuteNonQuery()
                    conexion_actual.Close()
                    MessageBox.Show("LOS DATOS SE MODIFICARON CORRECTAMENTE")
                Catch ex As Exception
                    MessageBox.Show("No se pudo Modificar los Datos / " + ex.Message)
                End Try
            End If
        Else
            Call conectar()
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
                        If TextBox6.Text <> "" And TextBox1.Text <> "" And id = 0 Then
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
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show("IMPOSIBLE REALIZAR LA CONSULTA " + ex.Message)
                End Try
            End If
        End If
    End Sub

    Public Sub LimpiarControles()

        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is MaterialSkin.Controls.MaterialSingleLineTextField Then
                c.Text = ""
            End If
        Next c
        Label13.Text = "0"
        DateTimePicker1.Text = Now
        DateTimePicker2.Text = Now
        id = 0
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call LimpiarControles()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Call conectar()
        Dim query As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim lectura As MySqlCommand
        If TextBox6.Text <> "" Then
            If MsgBox("ESTA SEGURO QUE DESEA ELIMINAR EL REGISTRO", vbYesNo, "ATENCION!!") = vbYes Then
                query = "DELETE FROM doctores " _
                    + "WHERE cedula = '" + TextBox6.Text + "'"
                lectura = New MySqlCommand(query, conexion_actual)
                Try
                    conexion_actual.Open()
                    lectura.ExecuteNonQuery()
                    conexion_actual.Close()
                    MsgBox("LOS DATOS SE ELIMINARON CORRECTAMENTE", vbInformation, "AVISO!")
                    Call LimpiarControles()
                Catch ex As Exception
                    MessageBox.Show("No se pudo Eliminar los Datos / " + ex.Message)
                End Try
            End If
        Else
            MsgBox("DEBE CONSULTAR UN REGISTRO!", MsgBoxStyle.Exclamation, "ERROR!")
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Call conectar()
        Dim query As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim lectura As MySqlDataAdapter
        Dim blinsor As New BindingSource

        If TextBox6.Text <> "" Then
            query = "SELECT * FROM doctores " _
            + "WHERE cedula = '" + TextBox6.Text + "'"
        Else
            query = "SELECT cedula,nombre,fechanac,edad FROM doctores " _
            + "WHERE nombre like '%" + TextBox1.Text + "%'"
        End If

        lectura = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            lectura.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 1 Then
                blinsor.DataSource = dt
                Ayuda_doctor.DataGridView1.DataSource = blinsor.DataSource
                Ayuda_doctor.MdiParent = Principal
                Ayuda_doctor.Show()
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
End Class
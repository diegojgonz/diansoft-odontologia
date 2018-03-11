Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Consultar_Usuarios
    Public idUsuario As Integer = 0
    Public Sub LimpiarControles()
        Dim c As Control
        For Each c In GroupPanel1.Controls
            If TypeOf c Is MaterialSkin.Controls.MaterialSingleLineTextField Then
                c.Text = ""
            End If
        Next c
        TextBox8.Text = ""
        ComboBox1.SelectedIndex = -1
        idUsuario = 0
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
        query = "SELECT * FROM usuarios " _
        + "WHERE cedula = '" + cedula.ToString + "'"

        lectura = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            lectura.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 0 Then
                idUsuario = dt.Rows(0).ItemArray(0).ToString()
                TextBox1.Text = dt.Rows(0).ItemArray(1).ToString()
                TextBox2.Text = dt.Rows(0).ItemArray(2).ToString()
                TextBox6.Text = dt.Rows(0).ItemArray(3).ToString()
                TextBox9.Text = dt.Rows(0).ItemArray(4).ToString()
                TextBox3.Text = dt.Rows(0).ItemArray(5).ToString()
                TextBox4.Text = dt.Rows(0).ItemArray(6).ToString()
                TextBox5.Text = TextBox4.Text
                ComboBox1.SelectedItem = dt.Rows(0).ItemArray(7).ToString()
                TextBox8.Text = dt.Rows(0).ItemArray(8).ToString()
                PictureBox1.BackgroundImage = Bytes_Imagen(dt.Rows(0).ItemArray(10))
            Else
                MsgBox("No se encontraron resultados, por favor verifique los datos", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al consultar / " + ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Call conectar()
        Dim query As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim lectura As MySqlDataAdapter
        If TextBox6.Text <> "" Then
            query = "SELECT * FROM usuarios " _
            + "WHERE cedula = '" + TextBox6.Text + "'"
        Else
            query = "SELECT cedula,nombre,user FROM usuarios " _
            + "WHERE nombre like '%" + TextBox1.Text + "%' or apellido like '%" + TextBox2.Text + "%'"
        End If

        lectura = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            lectura.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 1 Then
                BindingSource1.DataSource = dt
                Ayuda_Usuarios.DataGridView1.DataSource = BindingSource1.DataSource
                Ayuda_Usuarios.MdiParent = Principal
                Ayuda_Usuarios.Show()
            Else
                If TextBox6.Text <> "" Then
                    Call llenar_formulario(Int(TextBox6.Text))

                Else
                    Call llenar_formulario(dt.Rows(0).ItemArray(0))
                End If
            End If
        Catch Myex As MySqlException
            MsgBox("Hubo un problema al tratar de consultar el usuario, Mensaje MYSQL : " + Myex.Message, MsgBoxStyle.Critical)
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        Catch ex As Exception
            MsgBox("Hubo un problema al tratar de consultar el usuario, generando el siguiente mensaje: " + ex.Message, MsgBoxStyle.Critical)
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call conectar()
        Dim query As String

        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim lectura As MySqlCommand
        Dim imagen() As Byte
        imagen = Imagen_Bytes(PictureBox1.BackgroundImage)

        If idUsuario <> 0 Then
            If TextBox6.Text <> "" Then
                query = "UPDATE usuarios SET nombre ='" + TextBox1.Text + "',cedula='" + TextBox6.Text + "'," _
                    + "direccion='" + TextBox8.Text + "',telefono='" + TextBox9.Text + "', nivel ='" + ComboBox1.Text + "'," _
                    + "apellido='" + TextBox2.Text + "',user='" + TextBox3.Text + "',pass='" + TextBox4.Text + "',imagen=?imagen " _
                    + "WHERE cedula='" + TextBox6.Text + "'"
                lectura = New MySqlCommand(query, conexion_actual)
                lectura.Parameters.AddWithValue("?imagen", imagen)
                Try
                    conexion_actual.Open()
                    lectura.ExecuteNonQuery()
                    conexion_actual.Close()
                    MsgBox("Los datos se modificaron correctamente", MsgBoxStyle.Information)
                    LimpiarControles()
                Catch Myex As MySqlException
                    MsgBox("Hubo un problema al tratar al guardar el usuario, Mensaje MYSQL : " + Myex.Message, MsgBoxStyle.Critical)
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
            Dim comando As MySqlCommand
            Dim consulta As MySqlDataAdapter
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
                                query = "INSERT INTO usuarios(nombre,apellido,cedula,direccion,telefono,user,pass,nivel,fecha_at,imagen) " _
                                    + "VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox6.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + ComboBox1.Text + "','" & Now.ToString("yyyy-MM-dd") & "',imagen=?imagen);"
                                comando = New MySqlCommand(query, conexion_actual) 'crea el objeto con la consulta realizada
                                comando.Parameters.AddWithValue("?imagen", imagen)
                                Try
                                    conexion_actual.Open() 'Abre la Conexion
                                    comando.ExecuteNonQuery() 'ejecuta el query almacenado en el objeto
                                    conexion_actual.Close() ' cierra la conexion
                                    MsgBox("Los datos se Guardaron Correctamente", MsgBoxStyle.Information)
                                    LimpiarControles()
                                Catch ex As Exception ' si existe un error al momento de ejecutar la conexion
                                    MsgBox("Error al ingresar los datos " + ex.Message, MsgBoxStyle.Information)
                                End Try
                            Else
                                MsgBox("Las Contraseñas no son Iguales, Verifique! (*)", MsgBoxStyle.Critical, "IMPORTANTES!")
                            End If

                        Else
                            MsgBox("DEBE LLENAR LOS CAMPOS OBLIGATORIOS ", MsgBoxStyle.Exclamation, "IMPORTANTES!")
                        End If
                    End If
                Catch Myex As MySqlException
                    MsgBox("Hubo un problema al tratar de guardar el usuario, Mensaje MYSQL : " + Myex.Message, MsgBoxStyle.Critical)
                    If conexion_actual.State = ConnectionState.Open Then
                        conexion_actual.Close()
                    End If
                Catch ex As Exception
                    MsgBox("Hubo un problema al tratar de guardar el usuario, generando el siguiente mensaje: " + ex.Message, MsgBoxStyle.Critical)
                    If conexion_actual.State = ConnectionState.Open Then
                        conexion_actual.Close()
                    End If
                End Try
            End If
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Call LimpiarControles()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call conectar()
        Dim query As String

        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim comando As MySqlCommand
        Try
            If idUsuario <> 0 Then
                If MsgBox("Esta seguro de eliminar el usuario?", MsgBoxStyle.YesNo) Then
                    query = "DELETE FROM usuarios WHERE id='" & idUsuario & "'"
                    comando = New MySqlCommand(query, conexion_actual)
                    conexion_actual.Open()
                    comando.ExecuteNonQuery()
                    conexion_actual.Close()
                    MsgBox("Usuario elimnado correctamente", MsgBoxStyle.Information)
                    LimpiarControles()
                End If
            Else
                MsgBox("No ha consultado el usuarios", MsgBoxStyle.Exclamation)
            End If
        Catch Myex As MySqlException
            MsgBox("Hubo un problema al tratar de Eliminar un usuario, Mensaje MYSQL : " + Myex.Message, MsgBoxStyle.Critical)
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        Catch ex As Exception
            MsgBox("Hubo un problema al tratar de eliminar un usuario, generando el siguiente mensaje: " & ex.Message, MsgBoxStyle.Critical)
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LimpiarControles()
        Me.Close()
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
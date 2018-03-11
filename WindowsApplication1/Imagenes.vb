Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Imagenes
    Public idPaciente As Integer = 0
    Public idImagen As Integer = 0
    Public nombreImagen As String = ""
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        If idPaciente <> 0 Then
            Dim cd As New OpenFileDialog
            cd.Filter = "Imagenes (*.bmp, *.jpg, *.png, *.jpeg)|*.bmp;*.jpg;*.jpeg;*.png"
            cd.ShowDialog()
            If cd.FileName.ToString <> "" Then
                If Not PictureBox1.Image Is Nothing Then
                    PictureBox1.Image.Dispose()
                End If
                PictureBox1.Image = Nothing
                PictureBox1.Image = System.Drawing.Image.FromFile(cd.FileName)
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

            End If
        Else
            MsgBox("Debe consultar un paciente", MsgBoxStyle.Exclamation)
            MaterialSingleLineTextField1.Focus()
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

    Private Sub MaterialFlatButton6_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton6.Click
        limpiar()
        Me.Close()
    End Sub

    Private Function GenerarNombre() As String
        Dim obj As New Random
        Dim posibles As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim longitud As Int16 = posibles.Length
        Dim letra As Char
        Dim longitudnuevacadena As Int16 = 64
        Dim nuevacadena As String = ""
        For i As Int16 = 0 To longitudnuevacadena
            letra = posibles(obj.Next(longitud))
            nuevacadena += letra.ToString
        Next
        Return nuevacadena
    End Function

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click
        If idPaciente <> 0 Then
            Dim sql As String
            Dim comando As MySqlCommand
            Dim nombre As String = ""
            Dim imagen As Image
            imagen = PictureBox1.Image
            Try
                If Not IsNothing(PictureBox1.Image) Then
                    If idImagen = 0 Then
                        nombre = GenerarNombre() & ".jpeg"
                        imagen.Save("imagenes\" & nombre, Imaging.ImageFormat.Jpeg)
                        sql = "INSERT INTO imagenes(nombre,persona_id,fecha_at,observacion) VALUES('" & nombre & "','" & idPaciente & "','" & Now.ToString("yyyy-MM-dd") & "','" & RichTextBoxEx1.Text & "')"
                        Call conectar()
                        comando = New MySqlCommand(sql, conexion_actual)
                        conexion_actual.Open()
                        comando.ExecuteNonQuery()
                        conexion_actual.Close()
                        MsgBox("Imagen se guardo correctamente", MsgBoxStyle.Information)
                        ActualizarListaImagen()
                    Else
                        nombre = GenerarNombre() & ".jpeg"
                        imagen.Save("imagenes\" & nombre, Imaging.ImageFormat.Jpeg)
                        PictureBox1.Image.Dispose()
                        PictureBox1.Image = Nothing
                        My.Computer.FileSystem.DeleteFile("imagenes\" & nombreImagen)

                        sql = "UPDATE imagenes SET nombre='" & nombre & "',fecha_in='" & Now.ToString("yyyy-MM-dd") & "',observacion='" & RichTextBoxEx1.Text & "' WHERE id='" & idImagen & "'"
                        Call conectar()
                        comando = New MySqlCommand(sql, conexion_actual)
                        conexion_actual.Open()
                        comando.ExecuteNonQuery()
                        conexion_actual.Close()
                        MsgBox("Imagen se Modifico correctamente", MsgBoxStyle.Information)
                        nombreImagen = ""
                        ActualizarListaImagen()
                    End If
                    PictureBox1.Image = Nothing
                    RichTextBoxEx1.Text = ""
                    idImagen = 0
                Else
                    MsgBox("No ha cargado una imagen", MsgBoxStyle.Critical)
                End If
            Catch Myex As MySqlException
                MsgBox("Hubo un problema al guardar la imagen, Mensaje MYSQL: " & Myex.Message)
            Catch ex As Exception
                MsgBox("Hubo un problema al guardar la imagen, generando el siguiente mensaje: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("debe consultar un paciente", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Public Shared Function Redimensionar(imagen As Image, ancho As Integer, alto As Integer) As Image

        If imagen.Width > imagen.Height Then
            alto = imagen.Height * ancho / imagen.Width
        Else
            ancho = imagen.Width * alto / imagen.Height
        End If

        Dim imagenPhoto As Image = imagen


        Dim bmPhoto As New Bitmap(ancho, alto, PixelFormat.Format24bppRgb)
        bmPhoto.SetResolution(72, 72)
        Dim grPhoto As Graphics = Graphics.FromImage(bmPhoto)
        grPhoto.SmoothingMode = SmoothingMode.AntiAlias
        grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic
        grPhoto.PixelOffsetMode = PixelOffsetMode.HighQuality
        grPhoto.DrawImage(imagenPhoto, New Rectangle(0, 0, ancho, alto), 0, 0, imagen.Width, imagen.Height,
        GraphicsUnit.Pixel)

        Dim mm As New MemoryStream()
        bmPhoto.Save(mm, System.Drawing.Imaging.ImageFormat.Jpeg)
        imagen.Dispose()
        imagenPhoto.Dispose()
        bmPhoto.Dispose()
        grPhoto.Dispose()
        Return ByteArrayToImage(mm.GetBuffer())
    End Function


    Public Shared Function ByteArrayToImage(arregloDeBytes As Byte()) As Image
        Dim ms As New MemoryStream(arregloDeBytes)
        Dim imagen As Image = Image.FromStream(ms)
        Return imagen
    End Function

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click
        Call conectar()
        Dim query As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim lectura As MySqlDataAdapter
        If MaterialSingleLineTextField1.Text <> "" Then
            query = "SELECT id,nombre,cedula FROM persona " _
                + "WHERE cedula = '" + MaterialSingleLineTextField1.Text + "'"
            lectura = New MySqlDataAdapter(query, conexion_actual)
            Try
                conexion_actual.Open()
                lectura.Fill(dt)
                conexion_actual.Close()
                If dt.Rows.Count > 0 Then
                    MaterialSingleLineTextField1.Text = dt.Rows(0).Item(2).ToString
                    MaterialSingleLineTextField2.Text = dt.Rows(0).Item(1).ToString
                    idPaciente = Convert.ToInt16(dt.Rows(0).Item(0))
                    ActualizarListaImagen()
                Else
                    MsgBox("No se encontro el paciente, verifique la cedula instroducida", MsgBoxStyle.Exclamation)
                End If
            Catch Myex As MySqlException
                MsgBox("Hubo un problema al Consultar el Paciente, Mensaje MYSQL: " & Myex.Message)
                If conexion_actual.State = ConnectionState.Open Then
                    conexion_actual.Close()
                End If
            Catch ex As Exception
                MsgBox("EL PACIENTE NO EXISTE, VERIFIQUE LOS DATOS!", MsgBoxStyle.Critical, "AVISO!")
                If conexion_actual.State = ConnectionState.Open Then
                    conexion_actual.Close()
                End If
            End Try
        Else
            MsgBox("Debe introducir una cedula par realizar la busquedad", MsgBoxStyle.Exclamation)
        End If




    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        If Not IsNothing(PictureBox1.Image) Then
            PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            PictureBox1.Refresh()
        End If
    End Sub

    Private Sub ActualizarListaImagen()
        Call conectar()
        Dim query As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim lectura As MySqlDataAdapter
        Try
            query = "SELECT id,nombre,observacion,fecha_at FROM imagenes WHERE persona_id='" & idPaciente & "' ORDER BY id DESC"
            lectura = New MySqlDataAdapter(query, conexion_actual)
            dt = New DataTable
            DataGridView1.Rows.Clear()
            conexion_actual.Open()
            lectura.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 0 Then
                DataGridView1.RowTemplate.Height = 96
                For i As Integer = 0 To dt.Rows.Count - 1
                    DataGridView1.Rows.Add(dt.Rows(i).Item(0).ToString, dt.Rows(i).Item(1).ToString, dt.Rows(i).Item(2).ToString, dt.Rows(i).Item(3), Redimensionar(Image.FromFile("imagenes\" & dt.Rows(i).Item(1).ToString), 100, 100))
                    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                Next
            End If

        Catch Myex As MySqlException
            MsgBox("Hubo un problema al Consultar las imagenes, Mensaje MYSQL: " & Myex.Message)
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        Catch ex As Exception
            MsgBox("Hubo un problema al consultar las imagenes, generando el suiguiente mensaje: " & ex.Message, MsgBoxStyle.Critical)
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try

    End Sub

    Private Sub MaterialFlatButton5_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton5.Click
        If idImagen <> 0 Then
            If MsgBox("Esta seguro de eliminar la imagen seleccionada?", MsgBoxStyle.YesNo) Then
                Try
                    Dim sql As String
                    Dim comando As MySqlCommand
                    PictureBox1.Image.Dispose()
                    PictureBox1.Image = Nothing
                    My.Computer.FileSystem.DeleteFile("imagenes\" & nombreImagen)
                    sql = "DELETE FROM imagenes WHERE id='" & idImagen & "'"
                    Call conectar()
                    comando = New MySqlCommand(sql, conexion_actual)
                    conexion_actual.Open()
                    comando.ExecuteNonQuery()
                    conexion_actual.Close()
                    nombreImagen = ""
                    ActualizarListaImagen()
                    idImagen = 0
                    nombreImagen = ""
                    MsgBox("La imagen se eliminó correctamente", MsgBoxStyle.Information)
                Catch Myex As MySqlException
                    MsgBox("Hubo un problema al eliminar la imagen, Mensaje MYSQL: " & Myex.Message)
                Catch ex As Exception
                    MsgBox("Hubo un problema al eliminar la imagen, generando el siguiente mensaje: " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        Else
            MsgBox("Debe seleccionar la imagen que desea borrar", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub limpiar()
        PictureBox1.Image = Nothing
        RichTextBoxEx1.Text = ""
        idImagen = 0
        idPaciente = 0
        MaterialSingleLineTextField1.Text = ""
        MaterialSingleLineTextField2.Text = ""
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If Not PictureBox1.Image Is Nothing Then
            PictureBox1.Image.Dispose()
        End If
        PictureBox1.Image = Nothing
        idImagen = DataGridView1.CurrentRow.Cells(0).Value
        PictureBox1.Image = Image.FromFile("imagenes\" & DataGridView1.CurrentRow.Cells(1).Value)
        nombreImagen = DataGridView1.CurrentRow.Cells(1).Value
        RichTextBoxEx1.Text = DataGridView1.CurrentRow.Cells(2).Value
    End Sub

End Class
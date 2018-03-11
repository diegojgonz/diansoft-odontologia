Imports MySql.Data.MySqlClient
Imports MaterialSkin
Imports System.IO

Public Class Principal
    Public idUsuario As Integer

    Private Sub Principal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub HistoriaClinicaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'historia_clinica.MdiParent = Me
        historia_clinica.Show()
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Call conectar()
        Dim query As String
        Dim comando As MySqlDataAdapter
        Dim dt As New DataTable
        If idUsuario <> 0 Then
            query = "SELECT * FROM usuarios WHERE id='" + idUsuario.ToString + "'"
            comando = New MySqlDataAdapter(query, conexion_actual)
            Try
                conexion_actual.Open()
                comando.Fill(dt)
                conexion_actual.Close()
                If dt.Rows.Count > 0 Then
                    labelX2.Text = "<div align='right'><font size='+4'>" + dt.Rows(0).Item("user").ToString + "</font><br/>" + dt.Rows(0).Item("nombre").ToString.Substring(0, 1) + ". " + dt.Rows(0).Item("apellido").ToString + "</div>"
                    If Not IsDBNull(Bytes_Imagen(dt.Rows(0).Item("imagen"))) Then
                        pictureBox1.BackgroundImage = Bytes_Imagen(dt.Rows(0).Item("imagen"))
                    End If
                End If
            Catch Myex As MySqlException
                MsgBox("Hubo un problema al cargar los datos del usuario, mensaje MYSQL: " + Myex.Message, MsgBoxStyle.Critical)
            Catch ex As Exception
                MsgBox("Hubo un problema al cargar los datos del usuario, generando el siguiente mensaje: " + ex.Message, MsgBoxStyle.Critical)
            End Try
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = Now.ToString("H:mm:ss")
    End Sub



    Private Sub MetroTileItem1_Click_1(sender As Object, e As EventArgs) Handles MetroTileItem1.Click
        Consultar_Pacientes.ShowDialog()
    End Sub

    Private Sub MetroTileItem2_Click(sender As Object, e As EventArgs) Handles MetroTileItem2.Click
        consulta_doctores.ShowDialog()
    End Sub

    Private Sub MetroTileItem4_Click(sender As Object, e As EventArgs) Handles MetroTileItem4.Click
        Imagenes.ShowDialog()
    End Sub

    Private Sub MetroTileItem7_Click(sender As Object, e As EventArgs) Handles MetroTileItem7.Click

    End Sub

    Private Sub MetroTileItem3_Click(sender As Object, e As EventArgs) Handles MetroTileItem3.Click
        Odontograma.ShowDialog()
    End Sub

    Private Sub MetroTileItem8_Click(sender As Object, e As EventArgs) Handles MetroTileItem8.Click
        Consultar_Usuarios.ShowDialog()
    End Sub

    Private Sub MetroTileItem9_Click(sender As Object, e As EventArgs) Handles MetroTileItem9.Click
        Caja.ShowDialog()
    End Sub

    Private Sub MetroTileItem10_Click(sender As Object, e As EventArgs) Handles MetroTileItem10.Click
        control_cita.ShowDialog()
    End Sub

    Private Sub MetroTileItem5_Click(sender As Object, e As EventArgs) Handles MetroTileItem5.Click

    End Sub

    Private Sub MetroTileItem11_Click(sender As Object, e As EventArgs) Handles MetroTileItem11.Click
        historia_clinica.ShowDialog()
    End Sub

    Private Sub MetroTileItem12_Click(sender As Object, e As EventArgs) Handles MetroTileItem12.Click
        Anamnesis.ShowDialog()
    End Sub

    Private Sub MetroTileItem6_Click(sender As Object, e As EventArgs) Handles MetroTileItem6.Click

    End Sub

    Private Sub MetroTileItem13_Click(sender As Object, e As EventArgs) Handles MetroTileItem13.Click
        presupuesto.ShowDialog()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Application.Exit()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class

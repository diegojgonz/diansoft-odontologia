Imports MySql.Data.MySqlClient

Module conexion
    Public conexion_actual As MySqlConnection
    Public conexion_stream As String
    Dim variable As MySqlDataAdapter
    Dim data As New DataSet



    Sub conectar()
        conexion_stream = "Database=odonto;Data Source=localhost;User Id=root;Password='4171449'" ' datos de conexion con la base de datos mysql
        conexion_actual = New MySqlConnection(conexion_stream) 'objeto de conexion con la base de datos, crea la conexion
        Try
            conexion_actual.Open()
        Catch ex As Exception
            MessageBox.Show("No se puede realizar la Conexión " + ex.Message)
        Finally
            If conexion_actual.State = ConnectionState.Open Then 'si el estado de conexion es abierta se procede a cerrarla
                conexion_actual.Close()
            End If
        End Try

    End Sub

End Module

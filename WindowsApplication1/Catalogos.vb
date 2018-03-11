Imports MySql.Data.MySqlClient
Public Class Catalogos
    Sub actualizar()
        Dim query As String
        Dim dt As New DataTable
        Dim consulta As MySqlDataAdapter
        query = "SELECT tipo,descripcion,aplicacion,costo,costo_pac1,costo_pac2,costo_pac3,observaciones,id FROM catalogo WHERE descripcion LIKE '%" + TextBox1.Text + "%' Order By tipo"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub
    Private Sub Catalogos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String
        Dim dt As New DataTable
        Dim consulta As MySqlDataAdapter
        query = "SELECT tipo,descripcion,aplicacion,costo,costo_pac1,costo_pac2,costo_pac3,observaciones,id FROM catalogo WHERE descripcion LIKE '%" + TextBox1.Text + "%' Order By tipo"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Agregar_trabajos.ShowDialog()
        Call actualizar()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim query As String
        Dim dt As New DataTable
        Dim consulta As MySqlDataAdapter
        'MsgBox(e.KeyChar)
        query = "SELECT tipo,descripcion,aplicacion,costo,costo_pac1,costo_pac2,costo_pac3,observaciones,id FROM catalogo WHERE descripcion LIKE '%" + TextBox1.Text + "%' Order By tipo"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Agregar_trabajos.id_catalogo = DataGridView1.CurrentRow.Cells(8).Value.ToString
        Agregar_trabajos.llenar()
        Agregar_trabajos.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MsgBox("Esta Seguro que desea Eliminar los datos?", MsgBoxStyle.YesNo, "DianSoft Odontologia") = vbYes Then
            Dim query As String
            Dim comando As MySqlCommand
            query = "DELETE FROM catalogo WHERE id='" + DataGridView1.CurrentRow.Cells(8).Value.ToString + "'"
            comando = New MySqlCommand(query, conexion_actual)
            Try
                conexion_actual.Open()
                comando.ExecuteNonQuery()
                conexion_actual.Close()
                MsgBox("Datos Eliminados Correctamente", MsgBoxStyle.Information, "DianSoft Odontologia")
            Catch ex As Exception
                MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
            End Try
        End If
        actualizar()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
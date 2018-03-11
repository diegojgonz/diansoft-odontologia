Imports MySql.Data.MySqlClient

Public Class Caja
    Public tipopersona As String
    Public idpersona As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String
        Dim consulta As MySqlDataAdapter
        Dim dt As New DataTable
        query = "SELECT id,tipo,nombre AS 'Nombre',cedula AS 'Cedula',edad AS 'Edad',fechanac AS 'Fecha de Nacimiento' FROM persona"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        idpersona = DataGridView1.CurrentRow.Cells(0).Value.ToString
        tipopersona = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Caja_paciente.MdiParent = Principal.MdiParent
        Caja_paciente.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim query As String
        Dim consulta As MySqlDataAdapter
        Dim dt As New DataTable
        query = "SELECT id,tipo,nombre AS 'Nombre',cedula AS 'Cedula',edad AS 'Edad',fechanac AS 'Fecha de Nacimiento' FROM persona WHERE nombre LIKE'%" + TextBox1.Text + "%'"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub
End Class
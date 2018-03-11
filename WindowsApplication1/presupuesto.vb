Imports MySql.Data.MySqlClient
Public Class presupuesto
    Public idper As String
    Public tipoper As String

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
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
            'DataGridView1.DefaultCellStyle.BackColor = Color.DarkGray
            'DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        idper = DataGridView1.CurrentRow.Cells(0).Value.ToString
        tipoper = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Presupuesto_pacientes.MdiParent = Principal.MdiParent
        Presupuesto_pacientes.Show()
    End Sub
End Class
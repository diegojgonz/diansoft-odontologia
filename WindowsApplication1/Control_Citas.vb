Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Control_Citas
    Public citas As Int16 = 0
    Private Sub Control_Citas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim query As String
        Dim consulta As MySqlDataAdapter
        query = "SELECT * FROM personas WHERE proxima_visita='" + CDate(Today.ToShortDateString).ToString("yyyy-MM-dd") + "'"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
                citas = 1
            Else
                DataGridView1.DataSource = Nothing
                MsgBox("No hay Pacientes para Hoy", MsgBoxStyle.Exclamation, "DianSoft Odontologia")
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim dt As New DataTable
        Dim query As String
        Dim consulta As MySqlDataAdapter
        query = "SELECT * FROM personas WHERE proxima_visita='" + CDate(MonthCalendar1.SelectionStart.ToShortDateString).ToString("yyyy-MM-dd") + "'"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
            Else
                DataGridView1.DataSource = Nothing
                'MsgBox("No hay Pacientes para la Fecha", MsgBoxStyle.Exclamation, "DianSoft Odontologia")
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DsataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Principal.MdiParent = Consultar_Pacientes.MdiParent
        Consultar_Pacientes.Show()
        Call Consultar_Pacientes.llenar_formulario(Int(DataGridView1.CurrentRow.Cells(2).Value.ToString))
        Me.Close()
    End Sub
End Class
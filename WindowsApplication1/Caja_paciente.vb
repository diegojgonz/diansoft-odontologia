Imports MySql.Data.MySqlClient
Public Class Caja_paciente
    Sub actualizar()
        Dim query As String
        Dim dt As New DataTable
        Dim consulta As MySqlDataAdapter

        query = "SELECT id,persona_id,fecha_at AS Fecha,descripcion AS Trabajo, " _
            + "monto_unitario AS 'Monto Unitario',cantidad AS Cantidad,monto as Monto,referencia as Referencia FROM caja WHERE persona_id='" + Caja.idpersona + "'"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
            TextBox1.Text = "0.00"
            TextBox2.Text = "0.00"
            TextBox3.Text = "0.00"
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                TextBox1.Text = (CDec((TextBox1.Text) + CDec(DataGridView1.Rows(i).Cells(6).Value.ToString()))).ToString
                If DataGridView1.Rows(i).Cells(3).Value.ToString = "Abono" Then
                    TextBox1.Text = (CDec((TextBox1.Text) - CDec(DataGridView1.Rows(i).Cells(6).Value.ToString()))).ToString
                    TextBox2.Text = (CDec((TextBox2.Text) + CDec(DataGridView1.Rows(i).Cells(6).Value.ToString()))).ToString
                End If
            Next
            TextBox3.Text = (CDec(TextBox1.Text) - CDec(TextBox2.Text)).ToString
        Catch ex As Exception
            MsgBox("Error - " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try
    End Sub
    Sub buscarCaja(ByVal id As Integer)
        Dim query As String
        Dim dt As New DataTable
        Dim consulta As MySqlDataAdapter
        Caja.idpersona = id.ToString
        query = "SELECT id,persona_id,fecha_at AS Fecha,descripcion AS Trabajo, " _
            + "monto_unitario AS 'Monto Unitario',cantidad AS Cantidad,monto as Monto,referencia as Referencia FROM caja WHERE persona_id='" + id.ToString + "'"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
            TextBox1.Text = "0.00"
            TextBox2.Text = "0.00"
            TextBox3.Text = "0.00"
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                TextBox1.Text = (CDec((TextBox1.Text) + CDec(DataGridView1.Rows(i).Cells(6).Value.ToString()))).ToString
                If DataGridView1.Rows(i).Cells(3).Value.ToString = "Abono" Then
                    TextBox1.Text = (CDec((TextBox1.Text) - CDec(DataGridView1.Rows(i).Cells(6).Value.ToString()))).ToString
                    TextBox2.Text = (CDec((TextBox2.Text) + CDec(DataGridView1.Rows(i).Cells(6).Value.ToString()))).ToString
                End If
            Next
            TextBox3.Text = (CDec(TextBox1.Text) - CDec(TextBox2.Text)).ToString
        Catch ex As Exception
            MsgBox("Error - " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cargos.MdiParent = Principal.MdiParent
        Cargos.ShowDialog()
        If Cargos.DialogResult = Windows.Forms.DialogResult.OK Then
            Call actualizar()
        End If
    End Sub

    Private Sub Caja_paciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call actualizar()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("¿Esta Seguro que desea borrar la Fila?", MsgBoxStyle.YesNo, "DianSoft Odontologia") = vbYes Then
            Dim query As String
            Dim comando As MySqlCommand

            query = "DELETE FROM caja WHERE id='" + DataGridView1.CurrentRow.Cells(0).Value.ToString + "'"
            comando = New MySqlCommand(query, conexion_actual)
            Try
                conexion_actual.Open()
                comando.ExecuteNonQuery()
                conexion_actual.Close()
                Call actualizar()
            Catch ex As Exception
                MsgBox("Error - " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
                If conexion_actual.State = ConnectionState.Open Then
                    conexion_actual.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Abono_caja.MdiParent = Principal.MdiParent
        Abono_caja.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        reporte_ec.MdiParent = Principal.MdiParent
        reporte_ec.Show()
        reporte_ec.estado_cuenta(Caja.idpersona)
    End Sub
End Class
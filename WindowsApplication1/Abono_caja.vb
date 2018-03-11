Imports MySql.Data.MySqlClient

Public Class Abono_caja

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim query As String
        Dim comando As MySqlCommand

        query = "INSERT INTO caja(persona_id,fecha_at,descripcion,referencia,monto,monto_unitario,cantidad)" _
            + " VALUES('" + Caja.idpersona + "','" + CDate(Today.ToShortDateString).ToString("yyyy-MM-dd") + "','Abono','" + TextBox8.Text + "','" + TextBox7.Text + "','" + TextBox7.Text + "','1')"
        comando = New MySqlCommand(query, conexion_actual)
        Try
            conexion_actual.Open()
            comando.ExecuteNonQuery()
            conexion_actual.Close()
            query = "SELECT MAX(id) FROM caja"
            Dim dt As New DataTable
            Dim consulta As MySqlDataAdapter
            consulta = New MySqlDataAdapter(query, conexion_actual)
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            query = "INSERT INTO abonos(caja_id,persona_id,monto_efectivo,monto_cheque,monto_tcredidebi,monto_bono,monto_otros,referencia) " _
                + "VALUES('" + dt.Rows(0).ItemArray(0).ToString + "','" + Caja.idpersona + "','" + TextBox2.Text + "','" + TextBox4.Text + "'" _
                + ",'" + TextBox3.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox8.Text + "')"
            comando = New MySqlCommand(query, conexion_actual)
            conexion_actual.Open()
            comando.ExecuteNonQuery()
            conexion_actual.Close()
            'Call Caja_paciente.actualizar(0)
            Recibo_Pago.Show()
            Call Recibo_Pago.imprimir(Int(dt.Rows(0).ItemArray(0).ToString))
            Me.Close()
        Catch ex As Exception
            MsgBox("Error - " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub

    Private Sub Abono_caja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label8.Text = Caja_paciente.TextBox3.Text
        TextBox1.Text = Today.ToShortDateString
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            TextBox7.Text = (CDec(TextBox2.Text) + CDec(TextBox3.Text) + CDec(TextBox4.Text) + CDec(TextBox5.Text) + CDec(TextBox6.Text)).ToString
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            TextBox7.Text = (CDec(TextBox2.Text) + CDec(TextBox3.Text) + CDec(TextBox4.Text) + CDec(TextBox5.Text) + CDec(TextBox6.Text)).ToString
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            TextBox7.Text = (CDec(TextBox2.Text) + CDec(TextBox3.Text) + CDec(TextBox4.Text) + CDec(TextBox5.Text) + CDec(TextBox6.Text)).ToString
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        If TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            TextBox7.Text = (CDec(TextBox2.Text) + CDec(TextBox3.Text) + CDec(TextBox4.Text) + CDec(TextBox5.Text) + CDec(TextBox6.Text)).ToString
        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        If TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            TextBox7.Text = (CDec(TextBox2.Text) + CDec(TextBox3.Text) + CDec(TextBox4.Text) + CDec(TextBox5.Text) + CDec(TextBox6.Text)).ToString
        End If
    End Sub
End Class
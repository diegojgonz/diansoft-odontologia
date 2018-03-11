Imports MySql.Data.MySqlClient
Public Class Cargos

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String
        Dim dt As New DataTable
        Dim consulta As MySqlDataAdapter

        query = "SELECT descripcion FROM catalogo"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            TextBox1.Text = Today.ToShortDateString.ToString
            TextBox3.Text = "1"
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "descripcion"
            ComboBox1.ValueMember = "descripcion"
        Catch ex As Exception
            MsgBox("Error - " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim query As String
        Dim comando As New MySqlCommand

        query = "INSERT INTO caja(persona_id,fecha_at,descripcion,referencia,monto,cantidad,monto_unitario)" _
            + " VALUES('" + Caja.idpersona + "','" + CDate(TextBox1.Text).ToString("yyyy-MM-dd") + "','" + ComboBox1.Text + "','Cargo','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')"
        Try
            comando = New MySqlCommand(query, conexion_actual)
            conexion_actual.Open()
            comando.ExecuteNonQuery()
            conexion_actual.Close()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            MsgBox("Cargo Registrado Correctamente!", MsgBoxStyle.Information, "DianSoft Odontologia")
        Catch ex As Exception
            MsgBox("Error - " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim query As String
        Dim consulta As MySqlDataAdapter
        Dim dt As New DataTable

        query = "SELECT * FROM catalogo WHERE descripcion='" + ComboBox1.Text + "'"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 0 Then
                If Caja.tipopersona = "Estandar" Then
                    TextBox4.Text = dt.Rows(0).ItemArray(4).ToString
                ElseIf Caja.tipopersona = "Tipo 1" Then
                    TextBox4.Text = dt.Rows(0).ItemArray(5).ToString
                ElseIf Caja.tipopersona = "Tipo 2" Then
                    TextBox4.Text = dt.Rows(0).ItemArray(6).ToString
                ElseIf Caja.tipopersona = "Tipo 3" Then
                    TextBox4.Text = dt.Rows(0).ItemArray(7).ToString
                End If
                TextBox2.Text = (CDec(TextBox4.Text) * CDec(TextBox3.Text)).ToString
            End If
        Catch ex As Exception
            MsgBox("Error - " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
        End Try
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox4.Text <> "" And TextBox3.Text <> "" Then
            TextBox2.Text = (CDec(TextBox4.Text) * CDec(TextBox3.Text)).ToString
        End If
    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class Odontograma
    Public label_actual As Control
    Public array(90, 10) As String
    Public nombre_paciente As String
    Public nro_pieza As String
    Public nombre_trabajo As String
    Public nombre_pieza As String
    Public id_persona As String
    Public tipo_persona As String
    Dim guardado As Boolean
    Private o As Integer = 1

    Sub pieza_label(ByVal objeto As Control)
        Dim nombre As String
        nombre = objeto.Name
        If nombre = "Label1" Or nombre = "Label2" Or nombre = "Label3" Or nombre = "Label4" Or nombre = "Label5" Then
            nro_pieza = "18"
        ElseIf nombre = "Label6" Or nombre = "Label7" Or nombre = "Label8" Or nombre = "Label9" Or nombre = "Label10" Then
            nro_pieza = "17"
        ElseIf nombre = "Label11" Or nombre = "Label12" Or nombre = "Label13" Or nombre = "Label14" Or nombre = "Label15" Then
            nro_pieza = "16"
        ElseIf nombre = "Label16" Or nombre = "Label17" Or nombre = "Label18" Or nombre = "Label19" Or nombre = "Label20" Then
            nro_pieza = "15"
        ElseIf nombre = "Label21" Or nombre = "Label22" Or nombre = "Label23" Or nombre = "Label24" Or nombre = "Label25" Then
            nro_pieza = "14"
        ElseIf nombre = "Label26" Or nombre = "Label27" Or nombre = "Label28" Or nombre = "Label29" Or nombre = "Label30" Then
            nro_pieza = "13"
        ElseIf nombre = "Label31" Or nombre = "Label32" Or nombre = "Label33" Or nombre = "Label34" Or nombre = "Label35" Then
            nro_pieza = "12"
        ElseIf nombre = "Label36" Or nombre = "Label37" Or nombre = "Label38" Or nombre = "Label39" Or nombre = "Label40" Then
            nro_pieza = "11"
        ElseIf nombre = "Label41" Or nombre = "Label42" Or nombre = "Label43" Or nombre = "Label44" Or nombre = "Label45" Then
            nro_pieza = "21"
        ElseIf nombre = "Label46" Or nombre = "Label47" Or nombre = "Label48" Or nombre = "Label49" Or nombre = "Label50" Then
            nro_pieza = "22"
        ElseIf nombre = "Label51" Or nombre = "Label52" Or nombre = "Label53" Or nombre = "Label54" Or nombre = "Label55" Then
            nro_pieza = "23"
        ElseIf nombre = "Label56" Or nombre = "Label57" Or nombre = "Label58" Or nombre = "Label59" Or nombre = "Label60" Then
            nro_pieza = "24"
        ElseIf nombre = "Label61" Or nombre = "Label62" Or nombre = "Label63" Or nombre = "Label64" Or nombre = "Label65" Then
            nro_pieza = "25"
        ElseIf nombre = "Label66" Or nombre = "Label67" Or nombre = "Label68" Or nombre = "Label69" Or nombre = "Label70" Then
            nro_pieza = "26"
        ElseIf nombre = "Label71" Or nombre = "Label72" Or nombre = "Label73" Or nombre = "Label74" Or nombre = "Label75" Then
            nro_pieza = "27"
        ElseIf nombre = "Label76" Or nombre = "Label77" Or nombre = "Label78" Or nombre = "Label79" Or nombre = "Label80" Then
            nro_pieza = "28"
        ElseIf nombre = "Label81" Or nombre = "Label82" Or nombre = "Label83" Or nombre = "Label84" Or nombre = "Label85" Then
            nro_pieza = "55"
        ElseIf nombre = "Label86" Or nombre = "Label87" Or nombre = "Label88" Or nombre = "Label89" Or nombre = "Label90" Then
            nro_pieza = "54"
        ElseIf nombre = "Label91" Or nombre = "Label92" Or nombre = "Label93" Or nombre = "Label94" Or nombre = "Label95" Then
            nro_pieza = "53"
        ElseIf nombre = "Label96" Or nombre = "Label97" Or nombre = "Label98" Or nombre = "Label99" Or nombre = "Label100" Then
            nro_pieza = "52"
        ElseIf nombre = "Label101" Or nombre = "Label102" Or nombre = "Label103" Or nombre = "Label104" Or nombre = "Label105" Then
            nro_pieza = "51"
        ElseIf nombre = "Label106" Or nombre = "Label107" Or nombre = "Label108" Or nombre = "Label109" Or nombre = "Label110" Then
            nro_pieza = "61"
        ElseIf nombre = "Label111" Or nombre = "Label112" Or nombre = "Label113" Or nombre = "Label114" Or nombre = "Label115" Then
            nro_pieza = "62"
        ElseIf nombre = "Label116" Or nombre = "Label117" Or nombre = "Label118" Or nombre = "Label119" Or nombre = "Label120" Then
            nro_pieza = "63"
        ElseIf nombre = "Label121" Or nombre = "Label122" Or nombre = "Label123" Or nombre = "Label124" Or nombre = "Label125" Then
            nro_pieza = "64"
        ElseIf nombre = "Label126" Or nombre = "Label127" Or nombre = "Label128" Or nombre = "Label129" Or nombre = "Label130" Then
            nro_pieza = "65"
        ElseIf nombre = "Label131" Or nombre = "Label132" Or nombre = "Label133" Or nombre = "Label134" Or nombre = "Label135" Then
            nro_pieza = "81"
        ElseIf nombre = "Label136" Or nombre = "Label137" Or nombre = "Label138" Or nombre = "Label139" Or nombre = "Label140" Then
            nro_pieza = "82"
        ElseIf nombre = "Label141" Or nombre = "Label142" Or nombre = "Label143" Or nombre = "Label144" Or nombre = "Label145" Then
            nro_pieza = "83"
        ElseIf nombre = "Label146" Or nombre = "Label147" Or nombre = "Label148" Or nombre = "Label149" Or nombre = "Label150" Then
            nro_pieza = "84"
        ElseIf nombre = "Label151" Or nombre = "Label152" Or nombre = "Label153" Or nombre = "Label154" Or nombre = "Label155" Then
            nro_pieza = "85"
        ElseIf nombre = "Label156" Or nombre = "Label157" Or nombre = "Label158" Or nombre = "Label159" Or nombre = "Label160" Then
            nro_pieza = "75"
        ElseIf nombre = "Label161" Or nombre = "Label162" Or nombre = "Label163" Or nombre = "Label164" Or nombre = "Label165" Then
            nro_pieza = "74"
        ElseIf nombre = "Label166" Or nombre = "Label167" Or nombre = "Label168" Or nombre = "Label169" Or nombre = "Label170" Then
            nro_pieza = "73"
        ElseIf nombre = "Label171" Or nombre = "Label172" Or nombre = "Label173" Or nombre = "Label174" Or nombre = "Label175" Then
            nro_pieza = "72"
        ElseIf nombre = "Label176" Or nombre = "Label177" Or nombre = "Label178" Or nombre = "Label179" Or nombre = "Label180" Then
            nro_pieza = "71"
        ElseIf nombre = "Label181" Or nombre = "Label182" Or nombre = "Label183" Or nombre = "Label184" Or nombre = "Label185" Then
            nro_pieza = "38"
        ElseIf nombre = "Label186" Or nombre = "Label187" Or nombre = "Label188" Or nombre = "Label189" Or nombre = "Label190" Then
            nro_pieza = "37"
        ElseIf nombre = "Label191" Or nombre = "Label192" Or nombre = "Label193" Or nombre = "Label194" Or nombre = "Label195" Then
            nro_pieza = "36"
        ElseIf nombre = "Label196" Or nombre = "Label197" Or nombre = "Label198" Or nombre = "Label199" Or nombre = "Label200" Then
            nro_pieza = "35"
        ElseIf nombre = "Label201" Or nombre = "Label202" Or nombre = "Label203" Or nombre = "Label204" Or nombre = "Label205" Then
            nro_pieza = "34"
        ElseIf nombre = "Label206" Or nombre = "Label207" Or nombre = "Label208" Or nombre = "Label209" Or nombre = "Label210" Then
            nro_pieza = "33"
        ElseIf nombre = "Label211" Or nombre = "Label212" Or nombre = "Label213" Or nombre = "Label214" Or nombre = "Label215" Then
            nro_pieza = "32"
        ElseIf nombre = "Label216" Or nombre = "Label217" Or nombre = "Label218" Or nombre = "Label219" Or nombre = "Label220" Then
            nro_pieza = "31"
        ElseIf nombre = "Label221" Or nombre = "Label222" Or nombre = "Label223" Or nombre = "Label224" Or nombre = "Label225" Then
            nro_pieza = "41"
        ElseIf nombre = "Label226" Or nombre = "Label227" Or nombre = "Label228" Or nombre = "Label229" Or nombre = "Label230" Then
            nro_pieza = "42"
        ElseIf nombre = "Label231" Or nombre = "Label232" Or nombre = "Label233" Or nombre = "Label234" Or nombre = "Label235" Then
            nro_pieza = "43"
        ElseIf nombre = "Label236" Or nombre = "Label237" Or nombre = "Label238" Or nombre = "Label239" Or nombre = "Label240" Then
            nro_pieza = "44"
        ElseIf nombre = "Label241" Or nombre = "Label242" Or nombre = "Label243" Or nombre = "Label244" Or nombre = "Label245" Then
            nro_pieza = "45"
        ElseIf nombre = "Label246" Or nombre = "Label247" Or nombre = "Label248" Or nombre = "Label249" Or nombre = "Label250" Then
            nro_pieza = "46"
        ElseIf nombre = "Label251" Or nombre = "Label252" Or nombre = "Label253" Or nombre = "Label254" Or nombre = "Label255" Then
            nro_pieza = "47"
        ElseIf nombre = "Label256" Or nombre = "Label257" Or nombre = "Label258" Or nombre = "Label259" Or nombre = "Label260" Then
            nro_pieza = "48"
        End If

    End Sub
    Sub actualizar_trabajo()
        Dim query As String
        Dim consulta As MySqlDataAdapter
        Dim dt As New DataTable
        query = "SELECT nombre_objeto,id,persona_id,fecha_at AS FECHA,nombre AS DESCRIPCION,tipo AS TIPO,pieza AS PIEZA,costo AS COSTO,estado AS ESTADO,status FROM trabajos WHERE persona_id='" + id_persona + "'" _
                + " ORDER BY id"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(9).Visible = False
            o = 1
            For Each c As Control In Panel4.Controls
                If TypeOf c Is PictureBox Then
                    c.Visible = False
                End If
            Next

            For k As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(k).ItemArray(5).ToString = "General" Then
                    For Each obj As Control In Panel4.Controls
                        If TypeOf obj Is PictureBox Then
                            If obj.Name = "tg" + o.ToString Then
                                obj.BackgroundImage = Image.FromFile("../../Resources/" + dt.Rows(k).ItemArray(4).ToString + ".bmp")
                                obj.BackgroundImageLayout = ImageLayout.Stretch
                                obj.BackColor = Color.Black
                                obj.Visible = True
                            End If
                        End If
                    Next
                    o = o + 1
                End If
            Next

            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    c.Visible = False
                End If
            Next
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(5).Value = "Pieza" Then
                    For Each obj As Control In Panel1.Controls
                        If TypeOf obj Is PictureBox Then
                            If obj.Name = DataGridView1.Rows(i).Cells(0).Value Then
                                obj.Visible = True
                            End If
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            MsgBox("Error en la Consulta - " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If

        End Try

    End Sub
    Sub agregar_trabajo(ByVal tipo_trabajo As String)
        Dim query As String
        Dim comando As MySqlCommand
        Dim consulta As MySqlDataAdapter
        Dim dt As New DataTable
        Dim costo As String
        Dim objeto As String

        query = "SELECT * FROM catalogo WHERE descripcion LIKE '%" + nombre_trabajo + "%'"
        consulta = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            consulta.Fill(dt)
            conexion_actual.Close()
            If tipo_persona = "Estandar" Then
                costo = dt.Rows(0).ItemArray(4).ToString
            ElseIf tipo_persona = "Tipo 1" Then
                costo = dt.Rows(0).ItemArray(5).ToString
            ElseIf tipo_persona = "Tipo 2" Then
                costo = dt.Rows(0).ItemArray(6).ToString
            Else
                costo = dt.Rows(0).ItemArray(7).ToString
            End If

            If tipo_trabajo <> "General" Then
                If nombre_pieza <> "" Then
                    objeto = nombre_pieza
                    nro_pieza = nombre_pieza.Substring(2, 2).ToUpper
                Else
                    objeto = label_actual.Name
                    'nro_pieza = 0
                End If
                query = "INSERT INTO trabajos(persona_id,nombre,fecha_at,pieza,costo,estado,tipo,nombre_objeto,cara_pieza) " _
                    + "VALUES('" + id_persona + "','" + nombre_trabajo + "','" + Date.Today.ToString("yyyy-MM-dd") + "','" + nro_pieza + "','" + costo + "','Presupuesto','" + tipo_trabajo + "','" + objeto + "','0')"
                comando = New MySqlCommand(query, conexion_actual)
                Try
                    conexion_actual.Open()
                    comando.ExecuteNonQuery()
                    conexion_actual.Close()
                Catch ex As Exception
                    MsgBox("Error al insertar el Trabajo - " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
                    If conexion_actual.State = ConnectionState.Open Then
                        conexion_actual.Close()
                    End If
                End Try
            Else
                Dim dt2 As New DataTable
                query = "SELECT * FROM trabajos WHERE fecha_at='" + Date.Today.ToString("yyyy-MM-dd") + "' AND persona_id='" + id_persona + "' AND nombre='" + nombre_trabajo + "'"
                consulta = New MySqlDataAdapter(query, conexion_actual)
                Try
                    conexion_actual.Open()
                    consulta.Fill(dt2)
                    conexion_actual.Close()
                    nro_pieza = 0
                    If dt2.Rows.Count <= 0 Then
                        query = "INSERT INTO trabajos(persona_id,nombre,fecha_at,pieza,costo,estado,tipo,cara_pieza,nombre_objeto) " _
                                + "VALUES('" + id_persona + "','" + nombre_trabajo + "','" + Date.Today.ToString("yyyy-MM-dd") + "','" + nro_pieza + "','" + costo + "','Presupuesto','" + tipo_trabajo + "','0','General')"
                        comando = New MySqlCommand(query, conexion_actual)
                        Try
                            conexion_actual.Open()
                            comando.ExecuteNonQuery()
                            conexion_actual.Close()
                        Catch ex As Exception
                            MsgBox("Error al insertar el Trabajo - " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
                            If conexion_actual.State = ConnectionState.Open Then
                                conexion_actual.Close()
                            End If
                        End Try
                    Else
                        MsgBox("¡No debe agregar trabajos iguales en la misma fecha!", MsgBoxStyle.Exclamation, "DianSoft Odontologia")
                        For Each obj As Control In Panel4.Controls
                            If TypeOf obj Is PictureBox Then
                                If obj.Name = "tg" + o.ToString Then
                                    obj.Visible = False
                                    obj.BackgroundImage = Nothing
                                    obj.BackColor = Color.Red
                                    o = o - 1
                                End If
                            End If
                        Next
                    End If
                Catch ex As Exception
                    MsgBox("Error al consultar el Trabajo - " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
                    If conexion_actual.State = ConnectionState.Open Then
                        conexion_actual.Close()
                    End If
                End Try

            End If

        Catch ex As Exception
            MsgBox("Error al Consultar (agregando trabajo) - " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try
    End Sub
    Private Sub FlurosisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlurosisToolStripMenuItem.Click
        label_actual.BackColor = Color.Yellow
        Call pieza_label(label_actual)
        nombre_trabajo = "Flurosis"
        Call agregar_trabajo("Cara")
        Call actualizar_trabajo()
    End Sub

    Private Sub GingivitisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GingivitisToolStripMenuItem.Click
        label_actual.BackColor = Color.Lime
        Call pieza_label(label_actual)
        nombre_trabajo = "Gingivitis"
        Call agregar_trabajo("Cara")
        Call actualizar_trabajo()
    End Sub

    Private Sub ResinaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResinaToolStripMenuItem.Click
        label_actual.BackColor = Color.Olive
        Call pieza_label(label_actual)
        nombre_trabajo = "Resina"
        Call agregar_trabajo("Cara")
        Call actualizar_trabajo()
    End Sub

    Private Sub TratamientoDeSencibilidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TratamientoDeSencibilidadToolStripMenuItem.Click
        label_actual.BackColor = Color.Orange
        Call pieza_label(label_actual)
        nombre_trabajo = "Tratamiento de Sensibilidad"
        Call agregar_trabajo("Cara")
        Call actualizar_trabajo()
    End Sub

    Private Sub CarieOLesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarieOLesionToolStripMenuItem.Click
        label_actual.BackColor = Color.Fuchsia
        Call pieza_label(label_actual)
        nombre_trabajo = "Amalgama"
        Call agregar_trabajo("Cara")
        Call actualizar_trabajo()
    End Sub

    Private Sub RestauracionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestauracionToolStripMenuItem.Click
        label_actual.BackColor = Color.Red
        Call pieza_label(label_actual)
        nombre_trabajo = "Carie o Lesion"
        Call agregar_trabajo("Cara")
        Call actualizar_trabajo()
    End Sub

    Private Sub Label3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label3.MouseDown
        Label3.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label3
    End Sub

    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        Label1.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label1
    End Sub

    Private Sub Label5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseDown
        Label5.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label5
    End Sub

    Private Sub Label4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label4.MouseDown
        Label4.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label4
    End Sub

    Private Sub Label2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseDown
        Label2.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label2
    End Sub

    Private Sub Label6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label6.MouseDown
        Label6.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label6
    End Sub

    Private Sub Label7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label7.MouseDown
        Label7.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label7
    End Sub

    Private Sub Label8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label8.MouseDown
        Label8.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label8
    End Sub

    Private Sub Label9_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label9.MouseDown
        Label9.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label9
    End Sub

    Private Sub Label10_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label10.MouseDown
        Label10.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label10
    End Sub
    Private Sub Label11_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label11.MouseDown
        Label11.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label11
    End Sub
    Private Sub Label12_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label12.MouseDown
        Label12.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label12
    End Sub
    Private Sub Label13_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label13.MouseDown
        Label13.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label13
    End Sub
    Private Sub Label14_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label14.MouseDown
        Label14.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label14
    End Sub
    Private Sub Label15_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label15.MouseDown
        Label15.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label15
    End Sub
    Private Sub Label16_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label16.MouseDown
        Label16.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label16
    End Sub
    Private Sub Label17_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label17.MouseDown
        Label17.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label17
    End Sub
    Private Sub Label18_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label18.MouseDown
        Label18.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label18
    End Sub
    Private Sub Label19_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label19.MouseDown
        Label19.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label19
    End Sub
    Private Sub Label20_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label20.MouseDown
        Label20.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label20
    End Sub
    Private Sub Label21_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label21.MouseDown
        Label21.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label21
    End Sub
    Private Sub Label22_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label22.MouseDown
        Label22.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label22
    End Sub
    Private Sub Label23_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label23.MouseDown
        Label23.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label23
    End Sub
    Private Sub Label24_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label24.MouseDown
        Label24.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label24
    End Sub
    Private Sub Label25_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label25.MouseDown
        Label25.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label25
    End Sub
    Private Sub Label26_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label26.MouseDown
        Label26.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label26
    End Sub
    Private Sub Label27_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label27.MouseDown
        Label27.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label27
    End Sub
    Private Sub Label28_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label28.MouseDown
        Label28.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label28
    End Sub
    Private Sub Label29_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label29.MouseDown
        Label29.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label29
    End Sub
    Private Sub Label30_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label30.MouseDown
        Label30.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label30
    End Sub
    Private Sub Label31_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label31.MouseDown
        Label31.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label31
    End Sub
    Private Sub Label32_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label32.MouseDown
        Label32.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label32
    End Sub
    Private Sub Label33_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label33.MouseDown
        Label33.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label33
    End Sub
    Private Sub Label34_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label34.MouseDown
        Label34.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label34
    End Sub
    Private Sub Label35_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label35.MouseDown
        Label35.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label35
    End Sub
    Private Sub Label36_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label36.MouseDown
        Label36.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label36
    End Sub

    Private Sub Label37_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label37.MouseDown
        Label37.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label37
    End Sub
    Private Sub Label38_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label38.MouseDown
        Label38.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label38
    End Sub
    Private Sub Label39_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label39.MouseDown
        Label39.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label39
    End Sub
    Private Sub Label40_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label40.MouseDown
        Label40.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label40
    End Sub
    Private Sub Label41_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label41.MouseDown
        Label41.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label41
    End Sub
    Private Sub Label42_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label42.MouseDown
        Label42.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label42
    End Sub
    Private Sub Label43_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label43.MouseDown
        Label43.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label43
    End Sub
    Private Sub Label44_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label44.MouseDown
        Label44.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label44
    End Sub
    Private Sub Label45_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label45.MouseDown
        Label45.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label45
    End Sub
    Private Sub Label46_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label46.MouseDown
        Label46.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label46
    End Sub
    Private Sub Label47_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label47.MouseDown
        Label47.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label47
    End Sub
    Private Sub Label48_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label48.MouseDown
        Label48.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label48
    End Sub
    Private Sub Label49_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label49.MouseDown
        Label49.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label49
    End Sub
    Private Sub Label50_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label50.MouseDown
        Label50.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label50
    End Sub
    Private Sub Label51_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label51.MouseDown
        Label51.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label51
    End Sub
    Private Sub Label52_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label52.MouseDown
        Label52.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label52
    End Sub
    Private Sub Label53_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label53.MouseDown
        Label53.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label53
    End Sub
    Private Sub Label54_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label54.MouseDown
        Label54.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label54
    End Sub
    Private Sub Label55_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label55.MouseDown
        Label55.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label55
    End Sub
    Private Sub Label56_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label56.MouseDown
        Label56.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label56
    End Sub
    Private Sub Label57_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label57.MouseDown
        Label57.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label57
    End Sub
    Private Sub Label58_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label58.MouseDown
        Label58.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label58
    End Sub
    Private Sub Label59_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label59.MouseDown
        Label59.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label59
    End Sub
    Private Sub Label60_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label60.MouseDown
        Label60.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label60
    End Sub
    Private Sub Label61_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label61.MouseDown
        Label61.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label61
    End Sub
    Private Sub Label62_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label62.MouseDown
        Label62.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label62
    End Sub
    Private Sub Label63_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label63.MouseDown
        Label63.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label63
    End Sub
    Private Sub Label64_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label64.MouseDown
        Label64.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label64
    End Sub
    Private Sub Label65_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label65.MouseDown
        Label65.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label65
    End Sub

    Private Sub Label66_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label66.MouseDown
        Label66.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label66
    End Sub
    Private Sub Label67_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label67.MouseDown
        Label67.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label67
    End Sub
    Private Sub Label68_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label68.MouseDown
        Label68.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label68
    End Sub
    Private Sub Label69_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label69.MouseDown
        Label69.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label69
    End Sub
    Private Sub Label70_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label70.MouseDown
        Label70.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label70
    End Sub
    Private Sub Label71_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label71.MouseDown
        Label71.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label71
    End Sub
    Private Sub Label72_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label72.MouseDown
        Label72.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label72
    End Sub
    Private Sub Label73_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label73.MouseDown
        Label73.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label73
    End Sub
    Private Sub Label74_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label74.MouseDown
        Label74.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label74
    End Sub
    Private Sub Label75_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label75.MouseDown
        Label75.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label75
    End Sub
    Private Sub Label76_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label76.MouseDown
        Label76.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label76
    End Sub
    Private Sub Label77_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label77.MouseDown
        Label77.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label77
    End Sub
    Private Sub Label78_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label78.MouseDown
        Label78.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label78
    End Sub
    Private Sub Label79_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label79.MouseDown
        Label79.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label79
    End Sub
    Private Sub Label80_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label80.MouseDown
        Label80.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label80
    End Sub
    Private Sub Label81_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label81.MouseDown
        Label81.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label81
    End Sub
    Private Sub Label82_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label82.MouseDown
        Label82.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label82
    End Sub
    Private Sub Label83_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label83.MouseDown
        Label83.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label83
    End Sub
    Private Sub Label84_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label84.MouseDown
        Label84.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label84
    End Sub
    Private Sub Label85_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label85.MouseDown
        Label85.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label85
    End Sub
    Private Sub Label86_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label86.MouseDown
        Label86.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label86
    End Sub
    Private Sub Label87_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label87.MouseDown
        Label87.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label87
    End Sub
    Private Sub Label88_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label88.MouseDown
        Label88.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label88
    End Sub
    Private Sub Label89_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label89.MouseDown
        Label89.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label89
    End Sub
    Private Sub Label90_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label90.MouseDown
        Label90.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label90
    End Sub
    Private Sub Label91_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label91.MouseDown
        Label91.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label91
    End Sub
    Private Sub Label92_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label92.MouseDown
        Label92.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label92
    End Sub
    Private Sub Label93_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label93.MouseDown
        Label93.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label93
    End Sub

    Private Sub Label94_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label94.MouseDown
        Label94.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label94
    End Sub
    Private Sub Label95_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label95.MouseDown
        Label95.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label95
    End Sub
    Private Sub Label96_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label96.MouseDown
        Label96.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label96
    End Sub
    Private Sub Label97_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label97.MouseDown
        Label97.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label97
    End Sub
    Private Sub Label98_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label98.MouseDown
        Label98.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label98
    End Sub
    Private Sub Label99_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label99.MouseDown
        Label99.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label99
    End Sub
    Private Sub Label100_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label100.MouseDown
        Label100.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label100
    End Sub
    Private Sub Label101_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label101.MouseDown
        Label101.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label101
    End Sub
    Private Sub Label102_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label102.MouseDown
        Label102.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label102
    End Sub
    Private Sub Label103_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label103.MouseDown
        Label103.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label103
    End Sub
    Private Sub Label104_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label104.MouseDown
        Label104.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label104
    End Sub
    Private Sub Label105_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label105.MouseDown
        Label105.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label105
    End Sub
    Private Sub Label106_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label106.MouseDown
        Label106.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label106
    End Sub
    Private Sub Label107_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label107.MouseDown
        Label107.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label107
    End Sub
    Private Sub Label108_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label108.MouseDown
        Label108.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label108
    End Sub
    Private Sub Label109_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label109.MouseDown
        Label109.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label109
    End Sub
    Private Sub Label110_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label110.MouseDown
        Label110.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label110
    End Sub
    Private Sub Label111_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label111.MouseDown
        Label111.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label111
    End Sub
    Private Sub Label112_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label112.MouseDown
        Label112.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label112
    End Sub
    Private Sub Label113_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label113.MouseDown
        Label113.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label113
    End Sub
    Private Sub Label114_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label114.MouseDown
        Label114.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label114
    End Sub
    Private Sub Label115_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label115.MouseDown
        Label115.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label115
    End Sub
    Private Sub Label116_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label116.MouseDown
        Label116.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label116
    End Sub
    Private Sub Label117_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label117.MouseDown
        Label117.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label117
    End Sub
    Private Sub Label118_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label118.MouseDown
        Label118.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label118
    End Sub
    Private Sub Label119_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label119.MouseDown
        Label119.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label119
    End Sub
    Private Sub Label120_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label120.MouseDown
        Label120.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label120
    End Sub
    Private Sub Label121_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label121.MouseDown
        Label121.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label121
    End Sub

    Private Sub Label122_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label122.MouseDown
        Label122.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label122
    End Sub
    Private Sub Label123_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label123.MouseDown
        Label123.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label123
    End Sub
    Private Sub Label124_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label124.MouseDown
        Label124.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label124
    End Sub
    Private Sub Label125_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label125.MouseDown
        Label125.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label125
    End Sub
    Private Sub Label126_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label126.MouseDown
        Label126.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label126
    End Sub
    Private Sub Label127_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label127.MouseDown
        Label127.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label127
    End Sub
    Private Sub Label128_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label128.MouseDown
        Label128.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label128
    End Sub
    Private Sub Label129_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label129.MouseDown
        Label129.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label129
    End Sub
    Private Sub Label130_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label130.MouseDown
        Label130.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label130
    End Sub
    Private Sub Label131_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label131.MouseDown
        Label131.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label131
    End Sub
    Private Sub Label132_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label132.MouseDown
        Label132.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label132
    End Sub
    Private Sub Label133_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label133.MouseDown
        Label133.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label133
    End Sub
    Private Sub Label134_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label134.MouseDown
        Label134.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label134
    End Sub
    Private Sub Label135_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label135.MouseDown
        Label135.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label135
    End Sub
    Private Sub Label136_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label136.MouseDown
        Label136.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label136
    End Sub
    Private Sub Label137_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label137.MouseDown
        Label137.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label137
    End Sub
    Private Sub Label138_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label138.MouseDown
        Label138.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label138
    End Sub
    Private Sub Label139_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label139.MouseDown
        Label139.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label139
    End Sub
    Private Sub Label140_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label140.MouseDown
        Label140.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label140
    End Sub
    Private Sub Label141_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label141.MouseDown
        Label141.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label141
    End Sub
    Private Sub Label142_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label142.MouseDown
        Label142.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label142
    End Sub
    Private Sub Label143_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label143.MouseDown
        Label143.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label143
    End Sub
    Private Sub Label144_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label144.MouseDown
        Label144.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label144
    End Sub
    Private Sub Label145_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label145.MouseDown
        Label145.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label145
    End Sub
    Private Sub Label146_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label146.MouseDown
        Label146.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label146
    End Sub
    Private Sub Label147_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label147.MouseDown
        Label147.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label147
    End Sub
    Private Sub Label148_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label148.MouseDown
        Label148.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label148
    End Sub

    Private Sub Label149_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label149.MouseDown
        Label149.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label149
    End Sub
    Private Sub Label150_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label150.MouseDown
        Label150.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label150
    End Sub
    Private Sub Label151_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label151.MouseDown
        Label151.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label151
    End Sub
    Private Sub Label152_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label152.MouseDown
        Label152.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label152
    End Sub
    Private Sub Label153_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label153.MouseDown
        Label153.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label153
    End Sub
    Private Sub Label154_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label154.MouseDown
        Label154.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label154
    End Sub
    Private Sub Label155_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label155.MouseDown
        Label155.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label155
    End Sub
    Private Sub Label156_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label156.MouseDown
        Label156.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label156
    End Sub
    Private Sub Label157_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label157.MouseDown
        Label157.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label157
    End Sub
    Private Sub Label158_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label158.MouseDown
        Label158.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label158
    End Sub
    Private Sub Label159_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label159.MouseDown
        Label159.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label159
    End Sub
    Private Sub Label160_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label160.MouseDown
        Label160.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label160
    End Sub
    Private Sub Label161_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label161.MouseDown
        Label161.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label161
    End Sub
    Private Sub Label162_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label162.MouseDown
        Label162.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label162
    End Sub
    Private Sub Label163_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label163.MouseDown
        Label163.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label163
    End Sub
    Private Sub Label164_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label164.MouseDown
        Label164.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label164
    End Sub
    Private Sub Label165_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label165.MouseDown
        Label165.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label165
    End Sub
    Private Sub Label166_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label166.MouseDown
        Label166.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label166
    End Sub
    Private Sub Label167_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label167.MouseDown
        Label167.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label167
    End Sub
    Private Sub Label168_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label168.MouseDown
        Label168.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label168
    End Sub
    Private Sub Label169_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label169.MouseDown
        Label169.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label169
    End Sub
    Private Sub Label170_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label170.MouseDown
        Label170.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label170
    End Sub
    Private Sub Label171_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label171.MouseDown
        Label171.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label171
    End Sub
    Private Sub Label172_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label172.MouseDown
        Label172.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label172
    End Sub
    Private Sub Label173_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label173.MouseDown
        Label173.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label173
    End Sub
    Private Sub Label174_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label174.MouseDown
        Label174.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label174
    End Sub
    Private Sub Label175_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label175.MouseDown
        Label175.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label175
    End Sub

    Private Sub Label176_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label176.MouseDown
        Label176.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label176
    End Sub
    Private Sub Label177_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label177.MouseDown
        Label177.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label177
    End Sub
    Private Sub Label178_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label178.MouseDown
        Label178.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label178
    End Sub
    Private Sub Label179_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label179.MouseDown
        Label179.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label179
    End Sub
    Private Sub Label180_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label180.MouseDown
        Label180.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label180
    End Sub
    Private Sub Label181_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label181.MouseDown
        Label181.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label181
    End Sub
    Private Sub Label182_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label182.MouseDown
        Label182.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label182
    End Sub
    Private Sub Label183_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label183.MouseDown
        Label183.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label183
    End Sub
    Private Sub Label184_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label184.MouseDown
        Label184.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label184
    End Sub
    Private Sub Label185_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label185.MouseDown
        Label185.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label185
    End Sub
    Private Sub Label186_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label186.MouseDown
        Label186.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label186
    End Sub
    Private Sub Label187_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label187.MouseDown
        Label187.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label187
    End Sub
    Private Sub Label188_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label188.MouseDown
        Label188.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label188
    End Sub
    Private Sub Label189_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label189.MouseDown
        Label189.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label189
    End Sub
    Private Sub Label190_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label190.MouseDown
        Label190.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label190
    End Sub
    Private Sub Label191_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label191.MouseDown
        Label191.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label191
    End Sub
    Private Sub Label192_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label192.MouseDown
        Label192.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label192
    End Sub
    Private Sub Label193_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label193.MouseDown
        Label193.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label193
    End Sub
    Private Sub Label194_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label194.MouseDown
        Label194.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label194
    End Sub
    Private Sub Label195_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label195.MouseDown
        Label195.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label195
    End Sub
    Private Sub Label196_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label196.MouseDown
        Label196.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label196
    End Sub
    Private Sub Label197_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label197.MouseDown
        Label197.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label197
    End Sub
    Private Sub Label198_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label198.MouseDown
        Label198.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label198
    End Sub
    Private Sub Label199_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label199.MouseDown
        Label199.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label199
    End Sub
    Private Sub Label200_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label200.MouseDown
        Label200.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label200
    End Sub
    Private Sub Label201_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label201.MouseDown
        Label201.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label201
    End Sub
    Private Sub Label202_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label202.MouseDown
        Label202.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label202
    End Sub

    Private Sub Label203_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label203.MouseDown
        Label203.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label203
    End Sub
    Private Sub Label204_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label204.MouseDown
        Label204.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label204
    End Sub
    Private Sub Label205_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label205.MouseDown
        Label205.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label205
    End Sub
    Private Sub Label206_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label206.MouseDown
        Label206.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label206
    End Sub
    Private Sub Label207_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label207.MouseDown
        Label207.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label207
    End Sub
    Private Sub Label208_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label208.MouseDown
        Label208.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label208
    End Sub
    Private Sub Label209_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label209.MouseDown
        Label209.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label209
    End Sub
    Private Sub Label210_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label210.MouseDown
        Label210.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label210
    End Sub
    Private Sub Label211_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label211.MouseDown
        Label211.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label211
    End Sub
    Private Sub Label212_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label212.MouseDown
        Label212.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label212
    End Sub
    Private Sub Label213_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label213.MouseDown
        Label213.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label213
    End Sub
    Private Sub Label214_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label214.MouseDown
        Label214.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label214
    End Sub
    Private Sub Label215_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label215.MouseDown
        Label215.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label215
    End Sub
    Private Sub Label216_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label216.MouseDown
        Label216.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label216
    End Sub
    Private Sub Label217_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label217.MouseDown
        Label217.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label217
    End Sub
    Private Sub Label218_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label218.MouseDown
        Label218.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label218
    End Sub
    Private Sub Label219_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label219.MouseDown
        Label219.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label219
    End Sub
    Private Sub Label220_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label220.MouseDown
        Label220.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label220
    End Sub
    Private Sub Label221_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label221.MouseDown
        Label221.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label221
    End Sub
    Private Sub Label222_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label222.MouseDown
        Label222.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label222
    End Sub
    Private Sub Label223_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label223.MouseDown
        Label223.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label223
    End Sub
    Private Sub Label224_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label224.MouseDown
        Label224.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label224
    End Sub
    Private Sub Label225_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label225.MouseDown
        Label225.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label225
    End Sub
    Private Sub Label226_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label226.MouseDown
        Label226.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label226
    End Sub
    Private Sub Label227_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label227.MouseDown
        Label227.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label227
    End Sub
    Private Sub Labe228_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label228.MouseDown
        Label228.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label228
    End Sub

    Private Sub Label229_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label229.MouseDown
        Label229.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label229
    End Sub
    Private Sub Label230_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label230.MouseDown
        Label230.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label230
    End Sub
    Private Sub Label231_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label231.MouseDown
        Label231.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label231
    End Sub
    Private Sub Label232_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label232.MouseDown
        Label232.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label232
    End Sub
    Private Sub Label233_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label233.MouseDown
        Label233.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label233
    End Sub
    Private Sub Label234_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label234.MouseDown
        Label234.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label234
    End Sub
    Private Sub Label235_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label235.MouseDown
        Label235.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label235
    End Sub
    Private Sub Label236_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label236.MouseDown
        Label236.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label236
    End Sub
    Private Sub Label237_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label237.MouseDown
        Label237.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label237
    End Sub
    Private Sub Label238_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label238.MouseDown
        Label238.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label238
    End Sub
    Private Sub Label239_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label239.MouseDown
        Label239.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label239
    End Sub
    Private Sub Label240_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label240.MouseDown
        Label240.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label240
    End Sub
    Private Sub Label241_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label241.MouseDown
        Label241.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label241
    End Sub
    Private Sub Label242_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label242.MouseDown
        Label242.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label242
    End Sub
    Private Sub Label243_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label243.MouseDown
        Label243.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label243
    End Sub
    Private Sub Label244_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label244.MouseDown
        Label244.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label244
    End Sub
    Private Sub Label245_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label245.MouseDown
        Label245.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label245
    End Sub
    Private Sub Label246_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label246.MouseDown
        Label246.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label246
    End Sub
    Private Sub Label247_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label247.MouseDown
        Label247.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label247
    End Sub
    Private Sub Label248_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label248.MouseDown
        Label248.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label248
    End Sub
    Private Sub Label249_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label249.MouseDown
        Label249.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label249
    End Sub
    Private Sub Label250_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label250.MouseDown
        Label250.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label250
    End Sub
    Private Sub Label251_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label251.MouseDown
        Label251.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label251
    End Sub
    Private Sub Label252_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label252.MouseDown
        Label252.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label252
    End Sub
    Private Sub Label253_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label253.MouseDown
        Label253.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label253
    End Sub
    Private Sub Label254_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label254.MouseDown
        Label254.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label254
    End Sub

    Private Sub Label255_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label255.MouseDown
        Label255.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label255
    End Sub
    Private Sub Label256_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label256.MouseDown
        Label256.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label256
    End Sub
    Private Sub Label257_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label257.MouseDown
        Label257.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label257
    End Sub
    Private Sub Label258_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label258.MouseDown
        Label258.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label258
    End Sub
    Private Sub Label259_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label259.MouseDown
        Label259.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label259
    End Sub
    Private Sub Label260_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label260.MouseDown
        Label260.ContextMenuStrip = ContextMenuStrip1
        label_actual = Label260
    End Sub
    Sub ejecutar()
        Dim query As String
        Dim comando As MySqlCommand

        query = "INSERT INTO odontograma(persona_id," _
        + "pieza11_1, pieza11_2, pieza11_3, pieza11_4, pieza11_5," _
        + "pieza12_1, pieza12_2, pieza12_3, pieza12_4, pieza12_5," _
        + "pieza13_1, pieza13_2, pieza13_3, pieza13_4, pieza13_5," _
        + "pieza14_1, pieza14_2, pieza14_3, pieza14_4, pieza14_5," _
        + "pieza15_1, pieza15_2, pieza15_3, pieza15_4, pieza15_5," _
        + "pieza16_1, pieza16_2, pieza16_3, pieza16_4, pieza16_5," _
        + "pieza17_1, pieza17_2, pieza17_3, pieza17_4, pieza17_5," _
        + "pieza18_1, pieza18_2, pieza18_3, pieza18_4, pieza18_5," _
        + "pieza21_1, pieza21_2, pieza21_3, pieza21_4, pieza21_5," _
        + "pieza22_1, pieza22_2, pieza22_3, pieza22_4, pieza22_5," _
        + "pieza23_1, pieza23_2, pieza23_3, pieza23_4, pieza23_5," _
        + "pieza24_1, pieza24_2, pieza24_3, pieza24_4, pieza24_5," _
        + "pieza25_1, pieza25_2, pieza25_3, pieza25_4, pieza25_5," _
        + "pieza26_1, pieza26_2, pieza26_3, pieza26_4, pieza26_5," _
        + "pieza27_1, pieza27_2, pieza27_3, pieza27_4, pieza27_5," _
        + "pieza28_1, pieza28_2, pieza28_3, pieza28_4, pieza28_5," _
        + "pieza31_1, pieza31_2, pieza31_3, pieza31_4, pieza31_5," _
        + "pieza32_1, pieza32_2, pieza32_3, pieza32_4, pieza32_5," _
        + "pieza33_1, pieza33_2, pieza33_3, pieza33_4, pieza33_5," _
        + "pieza34_1, pieza34_2, pieza34_3, pieza34_4, pieza34_5," _
        + "pieza35_1, pieza35_2, pieza35_3, pieza35_4, pieza35_5," _
        + "pieza36_1, pieza36_2, pieza36_3, pieza36_4, pieza36_5," _
        + "pieza37_1, pieza37_2, pieza37_3, pieza37_4, pieza37_5," _
        + "pieza38_1, pieza38_2, pieza38_3, pieza38_4, pieza38_5," _
        + "pieza41_1, pieza41_2, pieza41_3, pieza41_4, pieza41_5," _
        + "pieza42_1, pieza42_2, pieza42_3, pieza42_4, pieza42_5," _
        + "pieza43_1, pieza43_2, pieza43_3, pieza43_4, pieza43_5," _
        + "pieza44_1, pieza44_2, pieza44_3, pieza44_4, pieza44_5," _
        + "pieza45_1, pieza45_2, pieza45_3, pieza45_4, pieza45_5," _
        + "pieza46_1, pieza46_2, pieza46_3, pieza46_4, pieza46_5," _
        + "pieza47_1, pieza47_2, pieza47_3, pieza47_4, pieza47_5," _
        + "pieza48_1, pieza48_2, pieza48_3, pieza48_4, pieza48_5," _
        + "pieza51_1, pieza51_2, pieza51_3, pieza51_4, pieza51_5," _
        + "pieza52_1, pieza52_2, pieza52_3, pieza52_4, pieza52_5," _
        + "pieza53_1, pieza53_2, pieza53_3, pieza53_4, pieza53_5," _
        + "pieza54_1, pieza54_2, pieza54_3, pieza54_4, pieza54_5," _
        + "pieza55_1, pieza55_2, pieza55_3, pieza55_4, pieza55_5," _
        + "pieza61_1, pieza61_2, pieza61_3, pieza61_4, pieza61_5," _
        + "pieza62_1, pieza62_2, pieza62_3, pieza62_4, pieza62_5," _
        + "pieza63_1, pieza63_2, pieza63_3, pieza63_4, pieza63_5," _
        + "pieza64_1, pieza64_2, pieza64_3, pieza64_4, pieza64_5," _
        + "pieza65_1, pieza65_2, pieza65_3, pieza65_4, pieza65_5," _
        + "pieza71_1, pieza71_2, pieza71_3, pieza71_4, pieza71_5," _
        + "pieza72_1, pieza72_2, pieza72_3, pieza72_4, pieza72_5," _
        + "pieza73_1, pieza73_2, pieza73_3, pieza73_4, pieza73_5," _
        + "pieza74_1, pieza74_2, pieza74_3, pieza74_4, pieza74_5," _
        + "pieza75_1, pieza75_2, pieza75_3, pieza75_4, pieza75_5," _
        + "pieza81_1, pieza81_2, pieza81_3, pieza81_4, pieza81_5," _
        + "pieza82_1, pieza82_2, pieza82_3, pieza82_4, pieza82_5," _
        + "pieza83_1, pieza83_2, pieza83_3, pieza83_4, pieza83_5," _
        + "pieza84_1, pieza84_2, pieza84_3, pieza84_4, pieza84_5," _
        + "pieza85_1, pieza85_2, pieza85_3, pieza85_4, pieza85_5,nota)" _
        + " VALUES('" + id_persona + "'," _
        + "'" + array(11, 1) + "','" + array(11, 2) + "','" + array(11, 3) + "','" + array(11, 4) + "','" + array(11, 5) + "'," _
        + "'" + array(12, 1) + "','" + array(12, 2) + "','" + array(12, 3) + "','" + array(12, 4) + "','" + array(12, 5) + "'," _
        + "'" + array(13, 1) + "','" + array(13, 2) + "','" + array(13, 3) + "','" + array(13, 4) + "','" + array(13, 5) + "'," _
        + "'" + array(14, 1) + "','" + array(14, 2) + "','" + array(14, 3) + "','" + array(14, 4) + "','" + array(14, 5) + "'," _
        + "'" + array(15, 1) + "','" + array(15, 2) + "','" + array(15, 3) + "','" + array(15, 4) + "','" + array(15, 5) + "'," _
        + "'" + array(16, 1) + "','" + array(16, 2) + "','" + array(16, 3) + "','" + array(16, 4) + "','" + array(16, 5) + "'," _
        + "'" + array(17, 1) + "','" + array(17, 2) + "','" + array(17, 3) + "','" + array(17, 4) + "','" + array(17, 5) + "'," _
        + "'" + array(18, 1) + "','" + array(18, 2) + "','" + array(18, 3) + "','" + array(18, 4) + "','" + array(18, 5) + "'," _
        + "'" + array(21, 1) + "','" + array(21, 2) + "','" + array(21, 3) + "','" + array(21, 4) + "','" + array(21, 5) + "'," _
        + "'" + array(22, 1) + "','" + array(22, 2) + "','" + array(22, 3) + "','" + array(22, 4) + "','" + array(22, 5) + "'," _
        + "'" + array(23, 1) + "','" + array(23, 2) + "','" + array(23, 3) + "','" + array(23, 4) + "','" + array(23, 5) + "'," _
        + "'" + array(24, 1) + "','" + array(24, 2) + "','" + array(24, 3) + "','" + array(24, 4) + "','" + array(24, 5) + "'," _
        + "'" + array(25, 1) + "','" + array(25, 2) + "','" + array(25, 3) + "','" + array(25, 4) + "','" + array(25, 5) + "'," _
        + "'" + array(26, 1) + "','" + array(26, 2) + "','" + array(26, 3) + "','" + array(26, 4) + "','" + array(26, 5) + "'," _
        + "'" + array(27, 1) + "','" + array(27, 2) + "','" + array(27, 3) + "','" + array(27, 4) + "','" + array(27, 5) + "'," _
        + "'" + array(28, 1) + "','" + array(28, 2) + "','" + array(28, 3) + "','" + array(28, 4) + "','" + array(28, 5) + "'," _
        + "'" + array(31, 1) + "','" + array(31, 2) + "','" + array(31, 3) + "','" + array(31, 4) + "','" + array(31, 5) + "'," _
        + "'" + array(32, 1) + "','" + array(32, 2) + "','" + array(32, 3) + "','" + array(32, 4) + "','" + array(32, 5) + "'," _
        + "'" + array(33, 1) + "','" + array(33, 2) + "','" + array(33, 3) + "','" + array(33, 4) + "','" + array(33, 5) + "'," _
        + "'" + array(34, 1) + "','" + array(34, 2) + "','" + array(34, 3) + "','" + array(34, 4) + "','" + array(34, 5) + "'," _
        + "'" + array(35, 1) + "','" + array(35, 2) + "','" + array(35, 3) + "','" + array(35, 4) + "','" + array(35, 5) + "'," _
        + "'" + array(36, 1) + "','" + array(36, 2) + "','" + array(36, 3) + "','" + array(36, 4) + "','" + array(36, 5) + "'," _
        + "'" + array(37, 1) + "','" + array(37, 2) + "','" + array(37, 3) + "','" + array(37, 4) + "','" + array(37, 5) + "'," _
        + "'" + array(38, 1) + "','" + array(38, 2) + "','" + array(38, 3) + "','" + array(38, 4) + "','" + array(38, 5) + "'," _
        + "'" + array(41, 1) + "','" + array(41, 2) + "','" + array(41, 3) + "','" + array(41, 4) + "','" + array(41, 5) + "'," _
        + "'" + array(42, 1) + "','" + array(42, 2) + "','" + array(42, 3) + "','" + array(42, 4) + "','" + array(42, 5) + "'," _
        + "'" + array(43, 1) + "','" + array(43, 2) + "','" + array(43, 3) + "','" + array(43, 4) + "','" + array(43, 5) + "'," _
        + "'" + array(44, 1) + "','" + array(44, 2) + "','" + array(44, 3) + "','" + array(44, 4) + "','" + array(44, 5) + "'," _
        + "'" + array(45, 1) + "','" + array(45, 2) + "','" + array(45, 3) + "','" + array(45, 4) + "','" + array(45, 5) + "'," _
        + "'" + array(46, 1) + "','" + array(46, 2) + "','" + array(46, 3) + "','" + array(46, 4) + "','" + array(46, 5) + "'," _
        + "'" + array(47, 1) + "','" + array(47, 2) + "','" + array(47, 3) + "','" + array(47, 4) + "','" + array(47, 5) + "'," _
        + "'" + array(48, 1) + "','" + array(48, 2) + "','" + array(48, 3) + "','" + array(48, 4) + "','" + array(48, 5) + "'," _
        + "'" + array(51, 1) + "','" + array(51, 2) + "','" + array(51, 3) + "','" + array(51, 4) + "','" + array(51, 5) + "'," _
        + "'" + array(52, 1) + "','" + array(52, 2) + "','" + array(52, 3) + "','" + array(52, 4) + "','" + array(52, 5) + "'," _
        + "'" + array(53, 1) + "','" + array(53, 2) + "','" + array(53, 3) + "','" + array(53, 4) + "','" + array(53, 5) + "'," _
        + "'" + array(54, 1) + "','" + array(54, 2) + "','" + array(54, 3) + "','" + array(54, 4) + "','" + array(54, 5) + "'," _
        + "'" + array(55, 1) + "','" + array(55, 2) + "','" + array(55, 3) + "','" + array(55, 4) + "','" + array(55, 5) + "'," _
        + "'" + array(61, 1) + "','" + array(61, 2) + "','" + array(61, 3) + "','" + array(61, 4) + "','" + array(61, 5) + "'," _
        + "'" + array(62, 1) + "','" + array(62, 2) + "','" + array(62, 3) + "','" + array(62, 4) + "','" + array(62, 5) + "'," _
        + "'" + array(63, 1) + "','" + array(63, 2) + "','" + array(63, 3) + "','" + array(63, 4) + "','" + array(63, 5) + "'," _
        + "'" + array(64, 1) + "','" + array(64, 2) + "','" + array(64, 3) + "','" + array(64, 4) + "','" + array(64, 5) + "'," _
        + "'" + array(65, 1) + "','" + array(65, 2) + "','" + array(65, 3) + "','" + array(65, 4) + "','" + array(65, 5) + "'," _
        + "'" + array(71, 1) + "','" + array(71, 2) + "','" + array(71, 3) + "','" + array(71, 4) + "','" + array(71, 5) + "'," _
        + "'" + array(72, 1) + "','" + array(72, 2) + "','" + array(72, 3) + "','" + array(72, 4) + "','" + array(72, 5) + "'," _
        + "'" + array(73, 1) + "','" + array(73, 2) + "','" + array(73, 3) + "','" + array(73, 4) + "','" + array(73, 5) + "'," _
        + "'" + array(74, 1) + "','" + array(74, 2) + "','" + array(74, 3) + "','" + array(74, 4) + "','" + array(74, 5) + "'," _
        + "'" + array(75, 1) + "','" + array(75, 2) + "','" + array(75, 3) + "','" + array(75, 4) + "','" + array(75, 5) + "'," _
        + "'" + array(81, 1) + "','" + array(81, 2) + "','" + array(81, 3) + "','" + array(81, 4) + "','" + array(81, 5) + "'," _
        + "'" + array(82, 1) + "','" + array(82, 2) + "','" + array(82, 3) + "','" + array(82, 4) + "','" + array(82, 5) + "'," _
        + "'" + array(83, 1) + "','" + array(83, 2) + "','" + array(83, 3) + "','" + array(83, 4) + "','" + array(83, 5) + "'," _
        + "'" + array(84, 1) + "','" + array(84, 2) + "','" + array(84, 3) + "','" + array(84, 4) + "','" + array(84, 5) + "'," _
        + "'" + array(85, 1) + "','" + array(85, 2) + "','" + array(85, 3) + "','" + array(85, 4) + "','" + array(85, 5) + "','" + RichTextBox1.Text + "');"
        comando = New MySqlCommand(query, conexion_actual)
        Try
            conexion_actual.Open() 'Abre la Conexion
            comando.ExecuteNonQuery() 'ejecuta el query almacenado en el objeto
            conexion_actual.Close() ' cierra la conexion
            MessageBox.Show("Los datos se Guardaron Correctamente")
            guardado = True
        Catch ex As Exception ' si existe un error al momento de ejecutar la conexion
            MessageBox.Show("Error al ingresar los datos " + ex.Message)
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try
    End Sub

    Sub modificar()
        Dim query As String
        Dim comando As MySqlCommand

        query = "UPDATE odontograma SET " _
        + "pieza11_1='" + array(11, 1) + "',pieza11_2='" + array(11, 2) + "',pieza11_3='" + array(11, 3) + "',pieza11_4='" + array(11, 4) + "',pieza11_5='" + array(11, 5) + "'," _
        + "pieza12_1='" + array(12, 1) + "',pieza12_2='" + array(12, 2) + "',pieza12_3='" + array(12, 3) + "',pieza12_4='" + array(12, 4) + "',pieza12_5='" + array(12, 5) + "'," _
        + "pieza13_1='" + array(13, 1) + "',pieza13_2='" + array(13, 2) + "',pieza13_3='" + array(13, 3) + "',pieza13_4='" + array(13, 4) + "',pieza13_5='" + array(13, 5) + "'," _
        + "pieza14_1='" + array(14, 1) + "',pieza14_2='" + array(14, 2) + "',pieza14_3='" + array(14, 3) + "',pieza14_4='" + array(14, 4) + "',pieza14_5='" + array(14, 5) + "'," _
        + "pieza15_1='" + array(15, 1) + "',pieza15_2='" + array(15, 2) + "',pieza15_3='" + array(15, 3) + "',pieza15_4='" + array(15, 4) + "',pieza15_5='" + array(15, 5) + "'," _
        + "pieza16_1='" + array(16, 1) + "',pieza16_2='" + array(16, 2) + "',pieza16_3='" + array(16, 3) + "',pieza16_4='" + array(16, 4) + "',pieza16_5='" + array(16, 5) + "'," _
        + "pieza17_1='" + array(17, 1) + "',pieza17_2='" + array(17, 2) + "',pieza17_3='" + array(17, 3) + "',pieza17_4='" + array(17, 4) + "',pieza17_5='" + array(17, 5) + "'," _
        + "pieza18_1='" + array(18, 1) + "',pieza18_2='" + array(18, 2) + "',pieza18_3='" + array(18, 3) + "',pieza18_4='" + array(18, 4) + "',pieza18_5='" + array(18, 5) + "'," _
        + "pieza21_1='" + array(21, 1) + "',pieza21_2='" + array(21, 2) + "',pieza21_3='" + array(21, 3) + "',pieza21_4='" + array(21, 4) + "',pieza21_5='" + array(21, 5) + "'," _
        + "pieza22_1='" + array(22, 1) + "',pieza22_2='" + array(22, 2) + "',pieza22_3='" + array(22, 3) + "',pieza22_4='" + array(22, 4) + "',pieza22_5='" + array(22, 5) + "'," _
        + "pieza23_1='" + array(23, 1) + "',pieza23_2='" + array(23, 2) + "',pieza23_3='" + array(23, 3) + "',pieza23_4='" + array(23, 4) + "',pieza23_5='" + array(23, 5) + "'," _
        + "pieza24_1='" + array(24, 1) + "',pieza24_2='" + array(24, 2) + "',pieza24_3='" + array(24, 3) + "',pieza24_4='" + array(24, 4) + "',pieza24_5='" + array(24, 5) + "'," _
        + "pieza25_1='" + array(25, 1) + "',pieza25_2='" + array(25, 2) + "',pieza25_3='" + array(25, 3) + "',pieza25_4='" + array(25, 4) + "',pieza25_5='" + array(25, 5) + "'," _
        + "pieza26_1='" + array(26, 1) + "',pieza26_2='" + array(26, 2) + "',pieza26_3='" + array(26, 3) + "',pieza26_4='" + array(26, 4) + "',pieza26_5='" + array(26, 5) + "'," _
        + "pieza27_1='" + array(27, 1) + "',pieza27_2='" + array(27, 2) + "',pieza27_3='" + array(27, 3) + "',pieza27_4='" + array(27, 4) + "',pieza27_5='" + array(27, 5) + "'," _
        + "pieza28_1='" + array(28, 1) + "',pieza28_2='" + array(28, 2) + "',pieza28_3='" + array(28, 3) + "',pieza28_4='" + array(28, 4) + "',pieza28_5='" + array(28, 5) + "'," _
        + "pieza31_1='" + array(31, 1) + "',pieza31_2='" + array(31, 2) + "',pieza31_3='" + array(31, 3) + "',pieza31_4='" + array(31, 4) + "',pieza31_5='" + array(31, 5) + "'," _
        + "pieza32_1='" + array(32, 1) + "',pieza32_2='" + array(32, 2) + "',pieza32_3='" + array(32, 3) + "',pieza32_3='" + array(32, 4) + "',pieza32_5='" + array(32, 5) + "'," _
        + "pieza33_1='" + array(33, 1) + "',pieza33_2='" + array(33, 2) + "',pieza33_3='" + array(33, 3) + "',pieza33_4='" + array(33, 4) + "',pieza33_5='" + array(33, 5) + "'," _
        + "pieza34_1='" + array(34, 1) + "',pieza34_2='" + array(34, 2) + "',pieza34_3='" + array(34, 3) + "',pieza34_4='" + array(34, 4) + "',pieza34_5='" + array(34, 5) + "'," _
        + "pieza35_1='" + array(35, 1) + "',pieza35_2='" + array(35, 2) + "',pieza35_3='" + array(35, 3) + "',pieza35_4='" + array(35, 4) + "',pieza35_5='" + array(35, 5) + "'," _
        + "pieza36_1='" + array(36, 1) + "',pieza36_2='" + array(36, 2) + "',pieza36_3='" + array(36, 3) + "',pieza36_4='" + array(36, 4) + "',pieza36_5='" + array(36, 5) + "'," _
        + "pieza37_1='" + array(37, 1) + "',pieza37_2='" + array(37, 2) + "',pieza37_3='" + array(37, 3) + "',pieza37_4='" + array(37, 4) + "',pieza37_5='" + array(37, 5) + "'," _
        + "pieza38_1='" + array(38, 1) + "',pieza38_2='" + array(38, 2) + "',pieza38_3='" + array(38, 3) + "',pieza38_4='" + array(38, 4) + "',pieza38_5='" + array(38, 5) + "'," _
        + "pieza41_1='" + array(41, 1) + "',pieza41_2='" + array(41, 2) + "',pieza41_3='" + array(41, 3) + "',pieza41_4='" + array(41, 4) + "',pieza41_5='" + array(41, 5) + "'," _
        + "pieza42_1='" + array(42, 1) + "',pieza42_2='" + array(42, 2) + "',pieza42_3='" + array(42, 3) + "',pieza42_4='" + array(42, 4) + "',pieza42_5='" + array(42, 5) + "'," _
        + "pieza43_1='" + array(43, 1) + "',pieza43_2='" + array(43, 2) + "',pieza43_3='" + array(43, 3) + "',pieza43_4='" + array(43, 4) + "',pieza43_5='" + array(43, 5) + "'," _
        + "pieza44_1='" + array(44, 1) + "',pieza44_2='" + array(44, 2) + "',pieza44_3='" + array(44, 3) + "',pieza44_4='" + array(44, 4) + "',pieza44_5='" + array(44, 5) + "'," _
        + "pieza45_1='" + array(45, 1) + "',pieza45_2='" + array(45, 2) + "',pieza45_3='" + array(45, 3) + "',pieza45_4='" + array(45, 4) + "',pieza45_5='" + array(45, 5) + "'," _
        + "pieza46_1='" + array(46, 1) + "',pieza46_2='" + array(46, 2) + "',pieza46_3='" + array(46, 3) + "',pieza46_4='" + array(46, 4) + "',pieza46_5='" + array(46, 5) + "'," _
        + "pieza47_1='" + array(47, 1) + "',pieza47_2='" + array(47, 2) + "',pieza47_3='" + array(47, 3) + "',pieza47_4='" + array(47, 4) + "',pieza47_5='" + array(47, 5) + "'," _
        + "pieza48_1='" + array(48, 1) + "',pieza48_2='" + array(48, 2) + "',pieza48_3='" + array(48, 3) + "',pieza48_4='" + array(48, 4) + "',pieza48_5='" + array(48, 5) + "'," _
        + "pieza51_1='" + array(51, 1) + "',pieza51_2='" + array(51, 2) + "',pieza51_3='" + array(51, 3) + "',pieza51_4='" + array(51, 4) + "',pieza51_5='" + array(51, 5) + "'," _
        + "pieza52_1='" + array(52, 1) + "',pieza52_2='" + array(52, 2) + "',pieza52_3='" + array(52, 3) + "',pieza52_4='" + array(52, 4) + "',pieza52_5='" + array(52, 5) + "'," _
        + "pieza53_1='" + array(53, 1) + "',pieza53_2='" + array(53, 2) + "',pieza53_3='" + array(53, 3) + "',pieza53_4='" + array(53, 4) + "',pieza53_5='" + array(53, 5) + "'," _
        + "pieza54_1='" + array(54, 1) + "',pieza54_2='" + array(54, 2) + "',pieza54_3='" + array(54, 3) + "',pieza54_4='" + array(54, 4) + "',pieza54_5='" + array(54, 5) + "'," _
        + "pieza55_1='" + array(55, 1) + "',pieza55_2='" + array(55, 2) + "',pieza55_3='" + array(55, 3) + "',pieza55_4='" + array(55, 4) + "',pieza55_5='" + array(55, 5) + "'," _
        + "pieza61_1='" + array(61, 1) + "',pieza61_2='" + array(61, 2) + "',pieza61_3='" + array(61, 3) + "',pieza61_4='" + array(61, 4) + "',pieza61_5='" + array(61, 5) + "'," _
        + "pieza62_1='" + array(62, 1) + "',pieza62_2='" + array(62, 2) + "',pieza62_3='" + array(62, 3) + "',pieza62_4='" + array(62, 4) + "',pieza62_5='" + array(62, 5) + "'," _
        + "pieza63_1='" + array(63, 1) + "',pieza63_2='" + array(63, 2) + "',pieza63_3='" + array(63, 3) + "',pieza63_4='" + array(63, 4) + "',pieza63_5='" + array(63, 5) + "'," _
        + "pieza64_1='" + array(64, 1) + "',pieza64_2='" + array(64, 2) + "',pieza64_3='" + array(64, 3) + "',pieza64_4='" + array(64, 4) + "',pieza64_5='" + array(64, 5) + "'," _
        + "pieza65_1='" + array(65, 1) + "',pieza65_2='" + array(65, 2) + "',pieza65_3='" + array(65, 3) + "',pieza65_4='" + array(65, 4) + "',pieza65_5='" + array(65, 5) + "'," _
        + "pieza71_1='" + array(71, 1) + "',pieza71_2='" + array(71, 2) + "',pieza71_3='" + array(71, 3) + "',pieza71_4='" + array(71, 4) + "',pieza71_5='" + array(71, 5) + "'," _
        + "pieza72_1='" + array(72, 1) + "',pieza72_2='" + array(72, 2) + "',pieza72_3='" + array(72, 3) + "',pieza72_4='" + array(72, 4) + "',pieza72_5='" + array(72, 5) + "'," _
        + "pieza73_1='" + array(73, 1) + "',pieza73_2='" + array(73, 2) + "',pieza73_3='" + array(73, 3) + "',pieza73_4='" + array(73, 4) + "',pieza73_5='" + array(73, 5) + "'," _
        + "pieza74_1='" + array(74, 1) + "',pieza74_2='" + array(74, 2) + "',pieza74_3='" + array(74, 3) + "',pieza74_4='" + array(74, 4) + "',pieza74_5='" + array(74, 5) + "'," _
        + "pieza75_1='" + array(75, 1) + "',pieza75_2='" + array(75, 2) + "',pieza75_3='" + array(75, 3) + "',pieza75_4='" + array(75, 4) + "',pieza75_5='" + array(75, 5) + "'," _
        + "pieza81_1='" + array(81, 1) + "',pieza81_2='" + array(81, 2) + "',pieza81_3='" + array(81, 3) + "',pieza81_4='" + array(81, 4) + "',pieza81_5='" + array(81, 5) + "'," _
        + "pieza82_1='" + array(82, 1) + "',pieza82_2='" + array(82, 2) + "',pieza82_3='" + array(82, 3) + "',pieza82_4='" + array(82, 4) + "',pieza82_5='" + array(82, 5) + "'," _
        + "pieza83_1='" + array(83, 1) + "',pieza83_2='" + array(83, 2) + "',pieza83_3='" + array(83, 3) + "',pieza83_4='" + array(83, 4) + "',pieza83_5='" + array(83, 5) + "'," _
        + "pieza84_1='" + array(84, 1) + "',pieza84_2='" + array(84, 2) + "',pieza84_3='" + array(84, 3) + "',pieza84_4='" + array(84, 4) + "',pieza84_5='" + array(84, 5) + "'," _
        + "pieza85_1='" + array(85, 1) + "',pieza85_2='" + array(85, 2) + "',pieza85_3='" + array(85, 3) + "',pieza85_4='" + array(85, 4) + "',pieza85_5='" + array(85, 5) + "',nota='" + RichTextBox1.Text + "'" _
        + "WHERE persona_id='" + id_persona + "'"
        comando = New MySqlCommand(query, conexion_actual)
        Try
            conexion_actual.Open() 'Abre la Conexion
            comando.ExecuteNonQuery() 'ejecuta el query almacenado en el objeto
            conexion_actual.Close() ' cierra la conexion
            MessageBox.Show("Los datos se Modificaron Correctamente")
        Catch ex As Exception ' si existe un error al momento de ejecutar la conexion
            MessageBox.Show("Error al Modificar los datos '" + ex.Message + "'")
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call conectar()
        Dim i As Integer
        If cedula.Text <> "" Or TextBox1.Text <> "" Then
            i = 1
            For Each c As Control In pieza18.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(18, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(18, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(18, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(18, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(18, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(18, i) = c.Name.ToString + "-T"
                    Else
                        array(18, i) = ""
                    End If
                    i = i + 1
                End If
            Next
            i = 1
            For Each c As Control In pieza17.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(17, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(17, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(17, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(17, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(17, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(17, i) = c.Name.ToString + "-T"
                    Else
                        array(17, i) = ""
                    End If
                    i = i + 1
                End If
            Next
            i = 1
            For Each c As Control In pieza16.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(16, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(16, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(16, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(16, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(16, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(16, i) = c.Name.ToString + "-T"
                    Else
                        array(16, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza15.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(15, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(15, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(15, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(15, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(15, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(15, i) = c.Name.ToString + "-T"
                    Else
                        array(15, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza14.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(14, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(14, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(14, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(14, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(14, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(14, i) = c.Name.ToString + "-T"
                    Else
                        array(14, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza13.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(13, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(13, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(13, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(13, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(13, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(13, i) = c.Name.ToString + "-T"
                    Else
                        array(13, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza12.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(12, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(12, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(12, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(12, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(12, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(12, i) = c.Name.ToString + "-T"
                    Else
                        array(12, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza11.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(11, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(11, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(11, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(11, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(11, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(11, i) = c.Name.ToString + "-T"
                    Else
                        array(11, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza21.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(21, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(21, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(21, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(21, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(21, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(21, i) = c.Name.ToString + "-T"
                    Else
                        array(21, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza22.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(22, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(22, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(22, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(22, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(22, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(22, i) = c.Name.ToString + "-T"
                    Else
                        array(22, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza23.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(23, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(23, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(23, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(23, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(23, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(23, i) = c.Name.ToString + "-T"
                    Else
                        array(23, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza24.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(24, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(24, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(24, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(24, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(24, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(24, i) = c.Name.ToString + "-T"
                    Else
                        array(24, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza25.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(25, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(25, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(25, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(25, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(25, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(25, i) = c.Name.ToString + "-T"
                    Else
                        array(25, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza26.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(26, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(26, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(26, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(26, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(26, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(26, i) = c.Name.ToString + "-T"
                    Else
                        array(26, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza27.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(27, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(27, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(27, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(27, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(27, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(27, i) = c.Name.ToString + "-T"
                    Else
                        array(27, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza28.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(28, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(28, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(28, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(28, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(28, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(28, i) = c.Name.ToString + "-T"
                    Else
                        array(28, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza55.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(55, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(55, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(55, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(55, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(55, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(55, i) = c.Name.ToString + "-T"
                    Else
                        array(55, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza54.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(54, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(54, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(54, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(54, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(54, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(54, i) = c.Name.ToString + "-T"
                    Else
                        array(54, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza53.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(53, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(53, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(53, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(53, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(53, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(53, i) = c.Name.ToString + "-T"
                    Else
                        array(53, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza52.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(52, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(52, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(52, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(52, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(52, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(52, i) = c.Name.ToString + "-T"
                    Else
                        array(52, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza51.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(51, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(51, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(51, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(51, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(51, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(51, i) = c.Name.ToString + "-T"
                    Else
                        array(51, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza61.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(61, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(61, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(61, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(61, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(61, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(61, i) = c.Name.ToString + "-T"
                    Else
                        array(61, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza62.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(62, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(62, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(62, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(62, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(62, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(62, i) = c.Name.ToString + "-T"
                    Else
                        array(62, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza63.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(63, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(63, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(63, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(63, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(63, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(63, i) = c.Name.ToString + "-T"
                    Else
                        array(63, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza64.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(64, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(64, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(64, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(64, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(64, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(64, i) = c.Name.ToString + "-T"
                    Else
                        array(64, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza65.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(65, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(65, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(65, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(65, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(65, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(65, i) = c.Name.ToString + "-T"
                    Else
                        array(65, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza85.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(85, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(85, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(85, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(85, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(85, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(85, i) = c.Name.ToString + "-T"
                    Else
                        array(85, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza84.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(84, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(84, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(84, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(84, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(84, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(84, i) = c.Name.ToString + "-T"
                    Else
                        array(84, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza83.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(83, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(83, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(83, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(83, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(83, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(83, i) = c.Name.ToString + "-T"
                    Else
                        array(84, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza82.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(82, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(82, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(82, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(82, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(82, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(82, i) = c.Name.ToString + "-T"
                    Else
                        array(82, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza81.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(81, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(81, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(81, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(81, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(81, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(81, i) = c.Name.ToString + "-T"
                    Else
                        array(81, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza71.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(71, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(71, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(71, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(71, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(71, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(71, i) = c.Name.ToString + "-T"
                    Else
                        array(71, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza72.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(72, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(72, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(72, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(72, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(72, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(72, i) = c.Name.ToString + "-T"
                    Else
                        array(72, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza73.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(73, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(73, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(73, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(73, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(73, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(73, i) = c.Name.ToString + "-T"
                    Else
                        array(73, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza74.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(74, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(74, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(74, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(74, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(74, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(74, i) = c.Name.ToString + "-T"
                    Else
                        array(74, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza75.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(75, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(75, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(75, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(75, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(75, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(75, i) = c.Name.ToString + "-T"
                    Else
                        array(75, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza48.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(48, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(48, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(48, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(48, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(48, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(48, i) = c.Name.ToString + "-T"
                    Else
                        array(48, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza47.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(47, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(47, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(47, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(47, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(47, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(47, i) = c.Name.ToString + "-T"
                    Else
                        array(47, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza46.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(46, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(46, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(46, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(46, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(46, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(18, i) = c.Name.ToString + "-T"
                    Else
                        array(18, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza45.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(45, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(45, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(45, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(45, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(45, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(45, i) = c.Name.ToString + "-T"
                    Else
                        array(45, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza44.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(44, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(44, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(44, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(44, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(44, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(44, i) = c.Name.ToString + "-T"
                    Else
                        array(44, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza43.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(43, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(43, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(43, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(43, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(43, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(43, i) = c.Name.ToString + "-T"
                    Else
                        array(43, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza42.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(42, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(42, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(42, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(42, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(42, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(42, i) = c.Name.ToString + "-T"
                    Else
                        array(42, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza41.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(41, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(41, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(41, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(41, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(41, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(41, i) = c.Name.ToString + "-T"
                    Else
                        array(41, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza31.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(31, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(31, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(31, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(31, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(31, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(31, i) = c.Name.ToString + "-T"
                    Else
                        array(31, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza32.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(32, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(32, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(32, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(32, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(32, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(32, i) = c.Name.ToString + "-T"
                    Else
                        array(32, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza33.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(33, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(33, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(33, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(33, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(33, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(33, i) = c.Name.ToString + "-T"
                    Else
                        array(33, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza34.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(34, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(34, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(34, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(34, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(34, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(34, i) = c.Name.ToString + "-T"
                    Else
                        array(34, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza35.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(35, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(35, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(35, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(35, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(35, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(35, i) = c.Name.ToString + "-T"
                    Else
                        array(35, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza36.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(36, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(36, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(36, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(36, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(36, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(36, i) = c.Name.ToString + "-T"
                    Else
                        array(36, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza37.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(37, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(37, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(37, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(37, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(37, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(37, i) = c.Name.ToString + "-T"
                    Else
                        array(37, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            i = 1
            For Each c As Control In pieza38.Controls
                If TypeOf c Is Label Then
                    If c.BackColor = Color.Fuchsia Then
                        array(38, i) = c.Name.ToString + "-C"
                    ElseIf c.BackColor = Color.Red Then
                        array(38, i) = c.Name.ToString + "-R"
                    ElseIf c.BackColor = Color.Yellow Then
                        array(38, i) = c.Name.ToString + "-F"
                    ElseIf c.BackColor = Color.Lime Then
                        array(38, i) = c.Name.ToString + "-G"
                    ElseIf c.BackColor = Color.Olive Then
                        array(38, i) = c.Name.ToString + "-S"
                    ElseIf c.BackColor = Color.Orange Then
                        array(38, i) = c.Name.ToString + "-T"
                    Else
                        array(38, i) = ""
                    End If
                    i = i + 1
                End If
            Next

            Dim query As String
            Dim consulta As MySqlDataAdapter
            Dim dt As New DataTable
            query = "SELECT * FROM odontograma WHERE persona_id ='" + id_persona + "'"
            consulta = New MySqlDataAdapter(query, conexion_actual)
            Try
                conexion_actual.Open()
                consulta.Fill(dt)
                conexion_actual.Close()
                If dt.Rows.Count > 0 Then
                    Call modificar()
                Else
                    Call ejecutar()
                End If
            Catch ex As Exception
                MessageBox.Show("IMPOSIBLE REALIZAR LA OPERACION " + ex.Message)
                If conexion_actual.State = ConnectionState.Open Then
                    conexion_actual.Close()
                End If
            End Try
        Else
            MsgBox("DEBE SELECCIONAR UN PACIENTE", vbCritical, "ERROR!")
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End If
    End Sub
    Sub buscar_label(ByVal nombre As String)

        For Each c As Control In pieza18.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza17.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza16.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza15.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza14.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza13.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza12.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza11.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza21.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza22.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza23.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza24.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza25.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza26.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza27.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza28.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza55.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza54.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza53.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza52.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza51.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza61.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza62.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza63.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza64.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza65.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza85.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza84.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza83.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza82.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza81.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza71.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza72.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza73.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza74.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza75.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza48.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza47.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza46.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza45.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza44.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza43.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza42.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza41.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza31.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza32.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza33.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza34.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza35.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza36.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza37.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next

        For Each c As Control In pieza38.Controls
            If c.Name = nombre Then
                label_actual = c
            End If
        Next
    End Sub

    Sub llenar_odontograma(ByVal cedula As String)
        Call conectar()
        Dim query As String
        Dim comando As MySqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim datos() As String
        Dim label As Object
        query = "SELECT " _
        + "pieza11_1, pieza11_2, pieza11_3, pieza11_4, pieza11_5," _
        + "pieza12_1, pieza12_2, pieza12_3, pieza12_4, pieza12_5," _
        + "pieza13_1, pieza13_2, pieza13_3, pieza13_4, pieza13_5," _
        + "pieza14_1, pieza14_2, pieza14_3, pieza14_4, pieza14_5," _
        + "pieza15_1, pieza15_2, pieza15_3, pieza15_4, pieza15_5," _
        + "pieza16_1, pieza16_2, pieza16_3, pieza16_4, pieza16_5," _
        + "pieza17_1, pieza17_2, pieza17_3, pieza17_4, pieza17_5," _
        + "pieza18_1, pieza18_2, pieza18_3, pieza25_4, pieza18_5," _
        + "pieza21_1, pieza21_2, pieza21_3, pieza21_4, pieza21_5," _
        + "pieza22_1, pieza22_2, pieza22_3, pieza22_4, pieza22_5," _
        + "pieza23_1, pieza23_2, pieza23_3, pieza23_4, pieza23_5," _
        + "pieza24_1, pieza24_2, pieza24_3, pieza24_4, pieza24_5," _
        + "pieza25_1, pieza25_2, pieza25_3, pieza25_4, pieza25_5," _
        + "pieza26_1, pieza26_2, pieza26_3, pieza26_4, pieza26_5," _
        + "pieza27_1, pieza27_2, pieza27_3, pieza27_4, pieza27_5," _
        + "pieza28_1, pieza28_2, pieza28_3, pieza28_4, pieza28_5," _
        + "pieza31_1, pieza31_2, pieza31_3, pieza31_4, pieza31_5," _
        + "pieza32_1, pieza32_2, pieza32_3, pieza32_4, pieza32_5," _
        + "pieza33_1, pieza33_2, pieza33_3, pieza33_4, pieza33_5," _
        + "pieza34_1, pieza34_2, pieza34_3, pieza34_4, pieza34_5," _
        + "pieza35_1, pieza35_2, pieza35_3, pieza35_4, pieza35_5," _
        + "pieza36_1, pieza36_2, pieza36_3, pieza36_4, pieza36_5," _
        + "pieza37_1, pieza37_2, pieza37_3, pieza37_4, pieza37_5," _
        + "pieza38_1, pieza38_2, pieza38_3, pieza38_4, pieza38_5," _
        + "pieza41_1, pieza41_2, pieza41_3, pieza41_4, pieza41_5," _
        + "pieza42_1, pieza42_2, pieza42_3, pieza42_4, pieza42_5," _
        + "pieza43_1, pieza43_2, pieza43_3, pieza43_4, pieza43_5," _
        + "pieza44_1, pieza44_2, pieza44_3, pieza44_4, pieza44_5," _
        + "pieza45_1, pieza45_2, pieza45_3, pieza45_4, pieza45_5," _
        + "pieza46_1, pieza46_2, pieza46_3, pieza46_4, pieza46_5," _
        + "pieza47_1, pieza47_2, pieza47_3, pieza47_4, pieza47_5," _
        + "pieza48_1, pieza48_2, pieza48_3, pieza48_4, pieza48_5," _
        + "pieza51_1, pieza51_2, pieza51_3, pieza51_4, pieza51_5," _
        + "pieza52_1, pieza52_2, pieza52_3, pieza52_4, pieza52_5," _
        + "pieza53_1, pieza53_2, pieza53_3, pieza53_4, pieza53_5," _
        + "pieza54_1, pieza54_2, pieza54_3, pieza54_4, pieza54_5," _
        + "pieza55_1, pieza55_2, pieza55_3, pieza55_4, pieza55_5," _
        + "pieza61_1, pieza61_2, pieza61_3, pieza61_4, pieza61_5," _
        + "pieza62_1, pieza62_2, pieza62_3, pieza62_4, pieza62_5," _
        + "pieza63_1, pieza63_2, pieza63_3, pieza63_4, pieza63_5," _
        + "pieza64_1, pieza64_2, pieza64_3, pieza64_4, pieza65_5," _
        + "pieza65_1, pieza65_2, pieza65_3, pieza65_4, pieza65_5," _
        + "pieza71_1, pieza71_2, pieza71_3, pieza71_4, pieza71_5," _
        + "pieza72_1, pieza72_2, pieza72_3, pieza72_4, pieza72_5," _
        + "pieza73_1, pieza73_2, pieza73_3, pieza73_4, pieza73_5," _
        + "pieza74_1, pieza74_2, pieza74_3, pieza74_4, pieza74_5," _
        + "pieza75_1, pieza75_2, pieza75_3, pieza75_4, pieza75_5," _
        + "pieza81_1, pieza81_2, pieza81_3, pieza81_4, pieza81_5," _
        + "pieza82_1, pieza82_2, pieza82_3, pieza82_4, pieza82_5," _
        + "pieza83_1, pieza83_2, pieza83_3, pieza83_4, pieza83_5," _
        + "pieza84_1, pieza84_2, pieza84_3, pieza84_4, pieza84_5," _
        + "pieza85_1, pieza85_2, pieza85_3, pieza85_4, pieza85_5,nota" _
        + " FROM odontograma WHERE persona_id = '" + id_persona + "'"
        comando = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open() 'Abre la Conexion
            comando.Fill(dt) 'ejecuta el query almacenado en el objeto
            conexion_actual.Close() ' cierra la conexion
            If dt.Rows.Count > 0 Then
                For i = 0 To 259
                    If dt.Rows(0).ItemArray(i).ToString <> "" Then
                        datos = dt.Rows(0).ItemArray(i).ToString.Split("-")
                        label = datos(0)
                        Call buscar_label(datos(0))
                        If TypeOf label_actual Is Label Then
                            If datos(1) = "C" Then
                                label_actual.BackColor = Color.Fuchsia
                            ElseIf datos(1) = "R" Then
                                label_actual.BackColor = Color.Red
                            ElseIf datos(1) = "F" Then
                                label_actual.BackColor = Color.Yellow
                            ElseIf datos(1) = "G" Then
                                label_actual.BackColor = Color.Lime
                            ElseIf datos(1) = "S" Then
                                label_actual.BackColor = Color.Olive
                            ElseIf datos(1) = "T" Then
                                label_actual.BackColor = Color.Orange
                            End If
                        ElseIf TypeOf label_actual Is PictureBox Then
                            label_actual.Visible = True
                        End If
                    End If
                Next
                RichTextBox1.Text = dt.Rows(0).ItemArray(260).ToString
                Dim dt2 As New DataTable
                query = "SELECT * FROM persona WHERE cedula='" + cedula + "'"
                comando = New MySqlDataAdapter(query, conexion_actual)
                Try
                    conexion_actual.Open()
                    comando.Fill(dt2)
                    conexion_actual.Close()
                    nombre_paciente = dt2.Rows(0).ItemArray(1).ToString
                    id_persona = dt2.Rows(0).ItemArray(0).ToString
                    tipo_persona = dt2.Rows(0).ItemArray(13).ToString
                    TextBox2.Text = dt2.Rows(0).ItemArray(1).ToString
                Catch ex As Exception
                    MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
                    If conexion_actual.State = ConnectionState.Open Then
                        conexion_actual.Close()
                    End If
                End Try
            End If

        Catch ex As Exception ' si existe un error al momento de ejecutar la conexion
            MessageBox.Show(ex.Message)
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try
    End Sub
    Private Sub Odontograma_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call conectar()
        Dim query As String
        Dim comando As MySqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim datos() As String
        Dim label As Object
        query = "SELECT " _
        + "pieza11_1, pieza11_2, pieza11_3, pieza11_4, pieza11_5," _
        + "pieza12_1, pieza12_2, pieza12_3, pieza12_4, pieza12_5," _
        + "pieza13_1, pieza13_2, pieza13_3, pieza13_4, pieza13_5," _
        + "pieza14_1, pieza14_2, pieza14_3, pieza14_4, pieza14_5," _
        + "pieza15_1, pieza15_2, pieza15_3, pieza15_4, pieza15_5," _
        + "pieza16_1, pieza16_2, pieza16_3, pieza16_4, pieza16_5," _
        + "pieza17_1, pieza17_2, pieza17_3, pieza17_4, pieza17_5," _
        + "pieza18_1, pieza18_2, pieza18_3, pieza18_4, pieza18_5," _
        + "pieza21_1, pieza21_2, pieza21_3, pieza21_4, pieza21_5," _
        + "pieza22_1, pieza22_2, pieza22_3, pieza22_4, pieza22_5," _
        + "pieza23_1, pieza23_2, pieza23_3, pieza23_4, pieza23_5," _
        + "pieza24_1, pieza24_2, pieza24_3, pieza24_4, pieza24_5," _
        + "pieza25_1, pieza25_2, pieza25_3, pieza25_4, pieza25_5," _
        + "pieza26_1, pieza26_2, pieza26_3, pieza26_4, pieza26_5," _
        + "pieza27_1, pieza27_2, pieza27_3, pieza27_4, pieza27_5," _
        + "pieza28_1, pieza28_2, pieza28_3, pieza28_4, pieza28_5," _
        + "pieza31_1, pieza31_2, pieza31_3, pieza31_4, pieza31_5," _
        + "pieza32_1, pieza32_2, pieza32_3, pieza32_4, pieza32_5," _
        + "pieza33_1, pieza33_2, pieza33_3, pieza33_4, pieza33_5," _
        + "pieza34_1, pieza34_2, pieza34_3, pieza34_4, pieza34_5," _
        + "pieza35_1, pieza35_2, pieza35_3, pieza35_4, pieza35_5," _
        + "pieza36_1, pieza36_2, pieza36_3, pieza36_4, pieza36_5," _
        + "pieza37_1, pieza37_2, pieza37_3, pieza37_4, pieza37_5," _
        + "pieza38_1, pieza38_2, pieza38_3, pieza38_4, pieza38_5," _
        + "pieza41_1, pieza41_2, pieza41_3, pieza41_4, pieza41_5," _
        + "pieza42_1, pieza42_2, pieza42_3, pieza42_4, pieza42_5," _
        + "pieza43_1, pieza43_2, pieza43_3, pieza43_4, pieza43_5," _
        + "pieza44_1, pieza44_2, pieza44_3, pieza44_4, pieza44_5," _
        + "pieza45_1, pieza45_2, pieza45_3, pieza45_4, pieza45_5," _
        + "pieza46_1, pieza46_2, pieza46_3, pieza46_4, pieza46_5," _
        + "pieza47_1, pieza47_2, pieza47_3, pieza47_4, pieza47_5," _
        + "pieza48_1, pieza48_2, pieza48_3, pieza48_4, pieza48_5," _
        + "pieza51_1, pieza51_2, pieza51_3, pieza51_4, pieza51_5," _
        + "pieza52_1, pieza52_2, pieza52_3, pieza52_4, pieza52_5," _
        + "pieza53_1, pieza53_2, pieza53_3, pieza53_4, pieza53_5," _
        + "pieza54_1, pieza54_2, pieza54_3, pieza54_4, pieza54_5," _
        + "pieza55_1, pieza55_2, pieza55_3, pieza55_4, pieza55_5," _
        + "pieza61_1, pieza61_2, pieza61_3, pieza61_4, pieza61_5," _
        + "pieza62_1, pieza62_2, pieza62_3, pieza62_4, pieza62_5," _
        + "pieza63_1, pieza63_2, pieza63_3, pieza63_4, pieza63_5," _
        + "pieza64_1, pieza64_2, pieza64_3, pieza64_4, pieza65_5," _
        + "pieza65_1, pieza65_2, pieza65_3, pieza65_4, pieza65_5," _
        + "pieza71_1, pieza71_2, pieza71_3, pieza71_4, pieza71_5," _
        + "pieza72_1, pieza72_2, pieza72_3, pieza72_4, pieza72_5," _
        + "pieza73_1, pieza73_2, pieza73_3, pieza73_4, pieza73_5," _
        + "pieza74_1, pieza74_2, pieza74_3, pieza74_4, pieza74_5," _
        + "pieza75_1, pieza75_2, pieza75_3, pieza75_4, pieza75_5," _
        + "pieza81_1, pieza81_2, pieza81_3, pieza81_4, pieza81_5," _
        + "pieza82_1, pieza82_2, pieza82_3, pieza82_4, pieza82_5," _
        + "pieza83_1, pieza83_2, pieza83_3, pieza83_4, pieza83_5," _
        + "pieza84_1, pieza84_2, pieza84_3, pieza84_4, pieza84_5," _
        + "pieza85_1, pieza85_2, pieza85_3, pieza85_4, pieza85_5,nota" _
        + " FROM odontograma WHERE persona_id = '" + id_persona + "'"
        comando = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open() 'Abre la Conexion
            comando.Fill(dt) 'ejecuta el query almacenado en el objeto
            conexion_actual.Close() ' cierra la conexion
            If dt.Rows.Count > 0 Then
                For i = 0 To 259
                    If dt.Rows(0).ItemArray(i).ToString <> "" Then
                        datos = dt.Rows(0).ItemArray(i).ToString.Split("-")
                        label = datos(0)
                        Call buscar_label(datos(0))
                        If TypeOf label_actual Is Label Then
                            If datos(1) = "C" Then
                                label_actual.BackColor = Color.Fuchsia
                            ElseIf datos(1) = "R" Then
                                label_actual.BackColor = Color.Red
                            ElseIf datos(1) = "F" Then
                                label_actual.BackColor = Color.Yellow
                            ElseIf datos(1) = "G" Then
                                label_actual.BackColor = Color.Lime
                            ElseIf datos(1) = "S" Then
                                label_actual.BackColor = Color.Olive
                            ElseIf datos(1) = "T" Then
                                label_actual.BackColor = Color.Orange
                            End If
                        ElseIf TypeOf label_actual Is PictureBox Then
                            label_actual.Visible = True
                        End If
                    End If
                Next
                RichTextBox1.Text = dt.Rows(0).ItemArray(260)
                Call actualizar_trabajo()
            End If
        Catch Myex As MySqlException ' si existe un error al momento de ejecutar la conexion
            MsgBox("Mysql: " + Myex.Message, MsgBoxStyle.Critical)
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        Catch ex As Exception ' si existe un error al momento de ejecutar la conexion
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call conectar()
        Dim i As Integer
        If MsgBox("Desea Guardar los Cambios?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If cedula.Text <> "" Or TextBox1.Text <> "" Then
                i = 1
                For Each c As Control In pieza18.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(18, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(18, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(18, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(18, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(18, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(18, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza18.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(18, 1) = c.Name.ToString
                        End If
                    End If
                Next
                i = 1
                For Each c As Control In pieza17.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(17, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(17, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(17, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(17, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(17, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(17, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza17.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(17, 1) = c.Name.ToString
                        End If
                    End If
                Next
                i = 1
                For Each c As Control In pieza16.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(16, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(16, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(16, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(16, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(16, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(16, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza16.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(16, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza15.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(15, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(15, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(15, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(15, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(15, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(15, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza15.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(15, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza14.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(14, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(14, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(14, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(14, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(14, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(14, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza14.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(14, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza13.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(13, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(13, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(13, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(13, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(13, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(13, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza13.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(13, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza12.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(12, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(12, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(12, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(12, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(12, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(12, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza12.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(12, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza11.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(11, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(11, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(11, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(11, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(11, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(11, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza11.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(11, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza21.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(21, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(21, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(21, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(21, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(21, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(21, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza21.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(21, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza22.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(22, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(22, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(22, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(22, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(22, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(22, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza22.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(22, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza23.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(23, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(23, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(23, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(23, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(23, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(23, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza23.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(23, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza24.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(24, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(24, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(24, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(24, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(24, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(24, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza24.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(24, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza25.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(25, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(25, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(25, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(25, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(25, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(25, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza25.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(25, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza26.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(26, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(26, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(26, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(26, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(26, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(26, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza26.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(26, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza27.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(27, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(27, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(27, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(27, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(27, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(27, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza27.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(27, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza28.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(28, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(28, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(28, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(28, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(28, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(28, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza28.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(28, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza55.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(55, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(55, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(55, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(55, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(55, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(55, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza55.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(55, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza54.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(54, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(54, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(54, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(54, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(54, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(54, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza54.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(54, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza53.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(53, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(53, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(53, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(53, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(53, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(53, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza53.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(53, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza52.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(52, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(52, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(52, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(52, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(52, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(52, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza52.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(52, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza51.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(51, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(51, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(51, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(51, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(51, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(51, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza51.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(51, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza61.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(61, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(61, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(61, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(61, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(61, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(61, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza61.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(61, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza62.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(62, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(62, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(62, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(62, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(62, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(62, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza62.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(62, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza63.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(63, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(63, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(63, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(63, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(63, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(63, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza63.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(63, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza64.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(64, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(64, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(64, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(64, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(64, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(64, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza64.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(64, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza65.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(65, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(65, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(65, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(65, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(65, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(65, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza65.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(65, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza85.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(85, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(85, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(85, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(85, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(85, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(85, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza85.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(85, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza84.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(84, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(84, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(84, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(84, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(84, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(84, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza84.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(84, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza83.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(83, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(83, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(83, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(83, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(83, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(83, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza83.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(83, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza82.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(82, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(82, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(82, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(82, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(82, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(82, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza82.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(82, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza81.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(81, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(81, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(81, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(81, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(81, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(81, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza81.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(81, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza71.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(71, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(71, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(71, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(71, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(71, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(71, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza71.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(71, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza72.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(72, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(72, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(72, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(72, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(72, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(72, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza72.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(72, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza73.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(73, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(73, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(73, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(73, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(73, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(73, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza73.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(73, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza74.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(74, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(74, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(74, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(74, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(74, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(74, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza74.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(74, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza75.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(75, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(75, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(75, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(75, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(75, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(75, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza75.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(75, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza48.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(48, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(48, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(48, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(48, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(48, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(48, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza48.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(48, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza47.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(47, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(47, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(47, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(47, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(47, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(47, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza47.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(47, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza46.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(46, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(46, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(46, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(46, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(46, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(18, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza46.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(46, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza45.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(45, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(45, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(45, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(45, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(45, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(45, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza45.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(45, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza44.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(44, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(44, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(44, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(44, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(44, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(44, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza44.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(44, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza43.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(43, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(43, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(43, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(43, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(43, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(43, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza43.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(43, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza42.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(42, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(42, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(42, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(42, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(42, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(42, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza42.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(42, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza41.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(41, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(41, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(41, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(41, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(41, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(41, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza41.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(41, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza31.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(31, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(31, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(31, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(31, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(31, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(31, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza31.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(31, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza32.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(32, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(32, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(32, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(32, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(32, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(32, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza32.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(32, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza33.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(33, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(33, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(33, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(33, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(33, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(33, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza33.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(33, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza34.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(34, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(34, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(34, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(34, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(34, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(34, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza34.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(34, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza35.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(35, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(35, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(35, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(35, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(35, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(35, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza35.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(35, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza36.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(36, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(36, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(36, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(36, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(36, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(36, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza36.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(36, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza37.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(37, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(37, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(37, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(37, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(37, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(37, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza37.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(37, 1) = c.Name.ToString
                        End If
                    End If
                Next

                i = 1
                For Each c As Control In pieza38.Controls
                    If TypeOf c Is Label Then
                        If c.BackColor = Color.Fuchsia Then
                            array(38, i) = c.Name.ToString + "-C"
                        ElseIf c.BackColor = Color.Red Then
                            array(38, i) = c.Name.ToString + "-R"
                        ElseIf c.BackColor = Color.Yellow Then
                            array(38, i) = c.Name.ToString + "-F"
                        ElseIf c.BackColor = Color.Lime Then
                            array(38, i) = c.Name.ToString + "-G"
                        ElseIf c.BackColor = Color.Olive Then
                            array(38, i) = c.Name.ToString + "-S"
                        ElseIf c.BackColor = Color.Orange Then
                            array(38, i) = c.Name.ToString + "-T"
                        End If
                        i = i + 1
                    ElseIf TypeOf c Is PictureBox Then
                        If c.Visible = True Then
                            For Each d As Control In pieza38.Controls
                                If TypeOf d Is Label Then
                                    d.BackColor = Color.Transparent
                                End If
                            Next
                            array(38, 1) = c.Name.ToString
                        End If
                    End If
                Next

                Dim query As String
                Dim consulta As MySqlDataAdapter
                Dim dt As New DataTable
                query = "SELECT * FROM odontograma WHERE persona_id ='" + id_persona + "'"
                consulta = New MySqlDataAdapter(query, conexion_actual)
                Try
                    conexion_actual.Open()
                    consulta.Fill(dt)
                    conexion_actual.Close()
                    If dt.Rows.Count > 0 Then
                        Call modificar()
                    Else
                        Call ejecutar()
                    End If
                Catch ex As Exception
                    MessageBox.Show("IMPOSIBLE REALIZAR LA OPERACION " + ex.Message)
                End Try
            Else
                MsgBox("DEBE SELECCIONAR UN PACIENTE", vbCritical, "ERROR!")
            End If
        End If
        Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call conectar()
        Call limpiar_odontograma()
        Dim query As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim lectura As MySqlDataAdapter
        If TextBox1.Text <> "" Then
            query = "SELECT * FROM persona " _
            + "WHERE cedula = '" + TextBox1.Text + "'"
        Else
            query = "SELECT id,cedula,nombre,fechanac,edad FROM persona " _
            + "WHERE nombre like '%" + TextBox2.Text + "%'"
        End If

        lectura = New MySqlDataAdapter(query, conexion_actual)
        Try
            conexion_actual.Open()
            lectura.Fill(dt)
            conexion_actual.Close()
            If dt.Rows.Count > 1 Then
                BindingSource1.DataSource = dt
                ayuda_odontograma.DataGridView1.DataSource = BindingSource1.DataSource
                ayuda_odontograma.Show()
                Button1.Enabled = True
            Else
                If TextBox1.Text <> "" Then
                    nombre_paciente = dt.Rows(0).ItemArray(1).ToString
                    TextBox2.Text = dt.Rows(0).ItemArray(1).ToString
                    id_persona = dt.Rows(0).ItemArray(0).ToString
                    Call llenar_odontograma(Int(TextBox1.Text))
                    Button1.Enabled = True
                Else
                    nombre_paciente = dt.Rows(0).ItemArray(1).ToString
                    TextBox1.Text = dt.Rows(0).ItemArray(0).ToString
                    Call llenar_odontograma(dt.Rows(0).ItemArray(0))
                    Button1.Enabled = True
                End If
            End If
            Call actualizar_trabajo()
        Catch ex As Exception
            MessageBox.Show("Error al consultar / " + ex.Message)
        End Try
    End Sub

    Sub limpiar_odontograma()
        Try
            For Each c As Control In Panel1.Controls
                If TypeOf c Is Panel Then
                    For Each p As Control In c.Controls
                        p.BackColor = Color.Transparent
                    Next
                ElseIf TypeOf c Is PictureBox Then
                    c.Visible = False
                End If
            Next
            For Each c As Control In Panel4.Controls
                If TypeOf c Is PictureBox Then
                    c.Visible = False
                End If
            Next
            DataGridView1.DataSource = vbEmpty
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("Esta seguro de Limpiar el Odontograma?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Call limpiar_odontograma()
        End If
    End Sub

    Private Sub pieza18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza18.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    Dim nombre As String = accion_pieza.Text.Substring(0, 2).ToLower & "18"
                    If c.Name = nombre Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza17Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza17.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "17" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub pieza16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza16.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "16" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza15.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "15" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza14.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "14" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza13.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "13" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza12.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "12" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza11.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "11" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza21.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "21" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza22_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza22.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "22" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza23_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza23.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "23" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza24_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza24.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "24" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza25.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "25" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza26_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza26.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "26" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza27_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza27.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "27" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza28_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza28.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "28" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza31_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza31.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "31" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza32_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza32.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "32" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza33_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza33.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "33" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza34_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza34.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "34" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza35_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza35.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "35" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza36_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza36.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "36" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza37_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza37.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "37" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza38_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza38.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "38" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub pieza41_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza41.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "41" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza42_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza42.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "42" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub pieza43_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza43.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "43" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza44_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza44.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "44" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza45_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza45.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "45" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza46_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza46.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "46" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza47_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza47.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "47" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza48_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza48.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "48" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza51_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza51.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "51" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza52_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza52.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "52" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub pieza53_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza53.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "53" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub pieza54_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza54.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "54" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza55_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza55.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "55" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub pieza61_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza61.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "61" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub pieza62_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza62.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "62" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub pieza63_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza63.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "63" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub pieza64_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza64.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "64" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub pieza65_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza65.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "65" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If


    End Sub
    Private Sub pieza71_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza71.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "71" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza72_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza72.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "72" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza73_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza73.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "73" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza74_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza74.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "74" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza75_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza75.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "75" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza81_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza81.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "81" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza82_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza82.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "82" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza84_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza84.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "84" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza85_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza85.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "85" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pieza83_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pieza83.DoubleClick
        If accion_pieza.Text <> "Seleccione" Then
            For Each c As Control In Panel1.Controls
                If TypeOf c Is PictureBox Then
                    If c.Name = accion_pieza.Text.Substring(0, 2).ToLower & "83" Then
                        c.Visible = True
                        nombre_pieza = c.Name
                        nombre_trabajo = accion_pieza.Text
                        Call agregar_trabajo("Pieza")
                        Call actualizar_trabajo()
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If id_persona <> 0 Then
            control_cita.id_paciente = id_persona
            control_cita.ShowDialog()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If id_persona <> "" Then
            nombre_trabajo = ComboBox1.Text
            Call agregar_trabajo("General")
            Call actualizar_trabajo()
        Else
            MsgBox("No ha seleccionado un paciente", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim query As String
        Dim comando As MySqlCommand
        Try
            If DataGridView1.CurrentRow.Cells(8).Value.ToString = "Presupuesto" Then
                query = "DELETE FROM trabajos WHERE fecha_at = '" + CDate(DataGridView1.CurrentRow.Cells(3).Value.ToString).ToString("yyyy-MM-dd") + "'" _
                + " AND persona_id='" + id_persona + "' AND nombre LIKE '%" + DataGridView1.CurrentRow.Cells(4).Value.ToString + "%'" _
                + " AND nombre_objeto = '" + DataGridView1.CurrentRow.Cells(0).Value.ToString + "'"
                comando = New MySqlCommand(query, conexion_actual)

                If DataGridView1.CurrentRow.Cells(5).Value.ToString = "Pieza" Or DataGridView1.CurrentRow.Cells(5).Value.ToString = "General" Then
                    conexion_actual.Open()
                    comando.ExecuteNonQuery()
                    conexion_actual.Close()
                    Call actualizar_trabajo()
                ElseIf DataGridView1.CurrentRow.Cells(5).Value.ToString = "Cara"
                    conexion_actual.Open()
                    comando.ExecuteNonQuery()
                    conexion_actual.Close()
                    For Each con As Control In Panel1.Controls
                        If TypeOf con Is Panel Then
                            If con.Name = "pieza" + DataGridView1.CurrentRow.Cells(6).Value.ToString Then
                                For Each con2 As Control In con.Controls
                                    If TypeOf con2 Is Label Then
                                        If con2.Name = DataGridView1.CurrentRow.Cells(0).Value.ToString Then
                                            con2.BackColor = Color.Transparent
                                            Call actualizar_trabajo()
                                        End If
                                    End If
                                Next
                            End If
                        End If
                    Next
                    Call actualizar_trabajo()
                    Button1.PerformClick()
                End If
            ElseIf DataGridView1.CurrentRow.Cells(8).Value.ToString = "Terminado" Then
                MsgBox("Este trabajo ya esta terminado por lo tanto no se puede eliminar", MsgBoxStyle.Exclamation)

            ElseIf DataGridView1.CurrentRow.Cells(8).Value.ToString = "En Proceso" Then
                If MsgBox("Este trabajo esta en proceso, Esta Seguro de Eliminarlo del odontograma? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    query = "DELETE FROM trabajos WHERE fecha_at = '" + CDate(DataGridView1.CurrentRow.Cells(3).Value.ToString).ToString("yyyy-MM-dd") + "'" _
                + " AND persona_id='" + id_persona + "' AND nombre LIKE '%" + DataGridView1.CurrentRow.Cells(4).Value.ToString + "%'" _
                + " AND nombre_objeto = '" + DataGridView1.CurrentRow.Cells(0).Value.ToString + "'"
                    comando = New MySqlCommand(query, conexion_actual)

                    If DataGridView1.CurrentRow.Cells(5).Value.ToString = "Pieza" Or DataGridView1.CurrentRow.Cells(5).Value.ToString = "General" Then
                        conexion_actual.Open()
                        comando.ExecuteNonQuery()
                        conexion_actual.Close()
                        Call actualizar_trabajo()
                    ElseIf DataGridView1.CurrentRow.Cells(5).Value.ToString = "Cara"
                        conexion_actual.Open()
                        comando.ExecuteNonQuery()
                        conexion_actual.Close()
                        For Each con As Control In Panel1.Controls
                            If TypeOf con Is Panel Then
                                If con.Name = "pieza" + DataGridView1.CurrentRow.Cells(6).Value.ToString Then
                                    For Each con2 As Control In con.Controls
                                        If TypeOf con2 Is Label Then
                                            If con2.Name = DataGridView1.CurrentRow.Cells(0).Value.ToString Then
                                                con2.BackColor = Color.Transparent
                                                Call actualizar_trabajo()
                                            End If
                                        End If
                                    Next
                                End If
                            End If
                        Next
                        Call actualizar_trabajo()
                        Button1.PerformClick()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al Eliminar - " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim query As String
        Dim comando As MySqlCommand
        Dim enc As Boolean
        cambiar_estatus.ShowDialog()
        If cambiar_estatus.DialogResult = Windows.Forms.DialogResult.OK Then
            For i As Integer = 0 To DataGridView1.RowCount - 1
                If DataGridView1.Rows(i).Selected = True Then
                    enc = True
                    Try
                        conexion_actual.Open()
                        query = "UPDATE trabajos SET estado ='" + cambiar_estatus.status + "' WHERE id='" + DataGridView1.Rows(i).Cells(1).Value.ToString + "'"
                        comando = New MySqlCommand(query, conexion_actual)
                        comando.ExecuteNonQuery()
                        conexion_actual.Close()
                    Catch ex As Exception
                        MsgBox("Error al Actualizar - " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
                        If conexion_actual.State = ConnectionState.Open Then
                            conexion_actual.Close()
                        End If
                    End Try
                End If
            Next
            If enc = True Then
                Call actualizar_trabajo()
            Else
                MsgBox("No hay Filas Seleccionadas, Por Favor Verifique!", MsgBoxStyle.Exclamation, "DianSoft Odontologia")
                If conexion_actual.State = ConnectionState.Open Then
                    conexion_actual.Close()
                End If
            End If
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim query As String
        Dim comando As MySqlCommand
        Dim enc As Boolean
        Dim st As Boolean

        Try
            For i As Integer = 0 To DataGridView1.RowCount - 1
                If DataGridView1.Rows(i).Selected = True Then
                    enc = True
                    If DataGridView1.Rows(i).Cells(9).Value.ToString = "P" Then
                        st = True
                        conexion_actual.Open()
                        query = "INSERT INTO caja(persona_id,fecha_at,descripcion,referencia,monto,cantidad,monto_unitario)" _
                                + " VALUES('" + DataGridView1.Rows(i).Cells(2).Value.ToString + "','" + CDate(DataGridView1.Rows(i).Cells(3).Value.ToString).ToString("yyyy-MM-dd") + "'," _
                                + "'" + DataGridView1.Rows(i).Cells(4).Value.ToString + "','Odontograma','" + DataGridView1.Rows(i).Cells(7).Value.ToString + "'," _
                                + "'1','" + DataGridView1.Rows(i).Cells(7).Value.ToString + "')"
                        comando = New MySqlCommand(query, conexion_actual)
                        comando.ExecuteNonQuery()
                        query = "UPDATE trabajos SET status='C' WHERE id='" + DataGridView1.Rows(i).Cells(1).Value.ToString + "'"
                        comando = New MySqlCommand(query, conexion_actual)
                        comando.ExecuteNonQuery()
                        conexion_actual.Close()
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error al Actualizar - " + ex.Message, MsgBoxStyle.Critical, "DianSoft Odontologia")
            If conexion_actual.State = ConnectionState.Open Then
                conexion_actual.Close()
            End If
        End Try

        If enc = True Then
            If st = True Then
                Call actualizar_trabajo()
                If MsgBox("Datos Pasados a Caja Correctamente, Desea Ir a Caja?", MsgBoxStyle.YesNo, "DianSoft Odontologia") = MsgBoxResult.Yes Then
                    Caja_paciente.MdiParent = Me.MdiParent
                    Caja_paciente.Show()
                    Caja_paciente.buscarCaja(id_persona)
                End If
            Else
                If MsgBox("Los trabajos seleccionados ya existe en Caja, Desea Ir a Caja?", MsgBoxStyle.YesNo, "DianSoft Odontologia") = MsgBoxResult.Yes Then
                    Caja_paciente.MdiParent = Me.MdiParent
                    Caja_paciente.Show()
                    Caja_paciente.buscarCaja(id_persona)
                End If
            End If
        Else
            MsgBox("No hay filas Seleccionadas!", MsgBoxStyle.Exclamation, "DianSoft Odontologia")
            If MsgBox("Desea Ir a Caja?", MsgBoxStyle.YesNo, "DianSoft Odontologia") = MsgBoxResult.Yes Then
                Caja_paciente.MdiParent = Me.MdiParent
                Caja_paciente.Show()
                Caja_paciente.buscarCaja(id_persona)
            End If
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        reporte_presupuesto.MdiParent = Principal.MdiParent
        reporte_presupuesto.Show()
        reporte_presupuesto.imprimir_presupuesto(id_persona)
    End Sub

End Class

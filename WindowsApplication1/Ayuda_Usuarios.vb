Public Class Ayuda_Usuarios

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim cedula As Integer
        cedula = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Consultar_Usuarios.llenar_formulario(cedula)
        Close()
    End Sub
End Class
Public Class Ayuda_doctor
    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim cedula As Integer
        cedula = DataGridView1.CurrentRow.Cells(0).Value.ToString
        consulta_doctores.llenar_formulario(cedula)
        Close()
    End Sub
End Class
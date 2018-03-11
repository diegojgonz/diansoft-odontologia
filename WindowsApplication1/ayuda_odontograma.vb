Public Class ayuda_odontograma

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim cedula As Integer
        cedula = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Odontograma.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Odontograma.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Odontograma.nombre_paciente = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Odontograma.llenar_odontograma(cedula)
        Close()
    End Sub
End Class
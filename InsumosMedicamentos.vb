Public Class InsumosMedicamentos

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        frmGuardia.Show()
    End Sub

    Private Sub Insumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarInsumos()
        actualizarMedicamentos()
    End Sub

    Public Sub actualizarInsumos()
        sql = "select ins.idInsumo AS id, i.Nombre, ins.Stock, ins.PP AS Punto_Pedido, ins.Porcentaje from insumo as i, insumo_sector as ins where i.idinsumo = ins.idinsumo and ins.idsector = 4"
        dgvInsumos.DataSource = ConsultaDG("Insumos")
    End Sub
    Public Sub actualizarMedicamentos()
        sql = "select mes.idMedicamento AS id, m.Nombre, mes.Stock, mes.PP AS Punto_Pedido, mes.Porcentaje from medicamento as m, medicamento_sector as mes where m.idmedicamento = mes.idmedicamento and mes.idsector = 4"
        dgvMedicamentos.DataSource = ConsultaDG("Medicamentos")
    End Sub

    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        ModificarInsumo.id = dgvInsumos.CurrentRow.Cells.Item(0).Value
        ModificarInsumo.lblNombreInsumo.Text = dgvInsumos.CurrentRow.Cells.Item(1).Value
        ModificarInsumo.txtPP.Text = dgvInsumos.CurrentRow.Cells.Item(3).Value
        ModificarInsumo.txtPorcentaje.Text = dgvInsumos.CurrentRow.Cells.Item(4).Value

        Me.Hide()
        ModificarInsumo.Show()
    End Sub

    Private Sub btnCambiarMed_Click(sender As Object, e As EventArgs) Handles btnCambiarMed.Click
        ModificarMedicamento.id = dgvMedicamentos.CurrentRow.Cells.Item(0).Value
        ModificarMedicamento.lblNombreInsumo.Text = dgvMedicamentos.CurrentRow.Cells.Item(1).Value
        ModificarMedicamento.txtPP.Text = dgvMedicamentos.CurrentRow.Cells.Item(3).Value
        ModificarMedicamento.txtPorcentaje.Text = dgvMedicamentos.CurrentRow.Cells.Item(4).Value

        Me.Hide()
        ModificarMedicamento.Show()
    End Sub
End Class
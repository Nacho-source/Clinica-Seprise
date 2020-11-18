Imports System.Data.Odbc

Public Class ModificarMedicamento
    Dim rs As OdbcDataReader

    Public id As Integer
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        InsumosMedicamentos.Show()
    End Sub

    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        sql = "UPDATE medicamento_sector SET PP = " & txtPP.Text & ", Porcentaje = " & txtPorcentaje.Text & " WHERE IdMedicamento = " & id & " AND IdSector = 4"
        rs = Consulta()
        InsumosMedicamentos.actualizarMedicamentos()
        Me.Hide()
        InsumosMedicamentos.Show()
    End Sub
End Class
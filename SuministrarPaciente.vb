Imports System.Data.Odbc
Public Class SuministrarPaciente
    Dim rs As OdbcDataReader

    Public id As Integer

    Public Sub cargar()
        sql = "select I.IdInsumo as Id, Nombre, ISE.Stock FROM Insumo_Sector ISE, Insumo I where I.IdInsumo = ISE.IdInsumo AND ISE.stock > 0 AND IdSector = 4"
        dgvInsumos.DataSource = ConsultaDG("InsumosSumi")

        sql = "select M.IdMedicamento as Id, Nombre, Presen, MS.Stock FROM Medicamento_Sector MS, Medicamento M where M.IdMedicamento = MS.IdMedicamento AND MS.stock > 0 AND IdSector = 4"
        dgvMedicamentos.DataSource = ConsultaDG("InsumosSumi")
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        AtencionPacientes.Show()
    End Sub

    Private Sub btnSuministrarInsumos_Click(sender As Object, e As EventArgs) Handles btnSuministrarInsumos.Click
        If (Val(txtCantIns.Text) <> 0) Then
            If (Val(txtCantIns.Text) <= dgvInsumos.CurrentRow.Cells.Item(2).Value) Then
                sql = "insert into AtencionPacienteInsumo values ('', " & id & ", " & dgvInsumos.CurrentRow.Cells.Item(0).Value & ", " & txtCantIns.Text & ", NOW()) "
                rs = Consulta()

                sql = "update Insumo_Sector set stock = stock - " & txtCantIns.Text & " WHERE IdInsumo = " & dgvInsumos.CurrentRow.Cells.Item(0).Value & " AND IdSector = 4"
                rs = Consulta()

                AtencionPacientes.suministros()
                Me.Hide()
                AtencionPacientes.Show()
            Else
                MsgBox("No hay stock suficiente")
            End If
        Else
            MsgBox("Cantidad no puede ser cero")
        End If
    End Sub

    Private Sub btnSuministrarMedicamentos_Click(sender As Object, e As EventArgs) Handles btnSuministrarMedicamentos.Click
        If (Val(txtCantMeds.Text) <> 0) Then
            If (Val(txtCantMeds.Text) <= dgvMedicamentos.CurrentRow.Cells.Item(3).Value) Then
                sql = "insert into AtencionPacienteMedicamento values ('', " & id & ", " & dgvMedicamentos.CurrentRow.Cells.Item(0).Value & ", " & txtCantMeds.Text & ", NOW()) "
                rs = Consulta()

                sql = "update Medicamento_Sector set stock = stock - " & txtCantMeds.Text & " WHERE IdMedicamento = " & dgvMedicamentos.CurrentRow.Cells.Item(0).Value & " AND IdSector = 4"
                rs = Consulta()

                AtencionPacientes.suministros()
                Me.Hide()
                AtencionPacientes.Show()
            Else
                MsgBox("No hay stock suficiente")
            End If
        Else
            MsgBox("Cantidad no puede ser cero")
        End If
    End Sub
End Class
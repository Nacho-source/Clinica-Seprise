Imports System.Data.Odbc

Public Class AtencionPacientes
    Dim id As Integer
    Dim rs As OdbcDataReader

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        frmGuardia.Show()
    End Sub

    Private Sub AtencionPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Public Sub cargar()
        sql = "select IdAtencionPaciente AS id, CONCAT( P.Apellido, ' ', P.Nombre ) as Paciente, CONCAT( E.Apellido, ' ', E.Nombre ) as Medico, AP.Comienzo, Estado, P.Documentacion, P.IdPaciente from AtencionPaciente as AP, Paciente as P, MedicoGuardia as MG, Medico as M, Empleado as E where P.IdPaciente = AP.IdPaciente AND MG.IdMedico = M.IdMedico AND AP.IdMedicoGuardia = MG.IdMedicoGuardia AND E.IdEmpleado = M.IdEmpleado AND Fin IS NULL Order By Comienzo ASC"
        dgvAtencionPacientes.DataSource = ConsultaDG("AtencionPacientes")
    End Sub

    Private Sub dgvAtencionPacientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAtencionPacientes.CellClick
        id = dgvAtencionPacientes.CurrentRow.Cells.Item(0).Value

        suministros()
    End Sub

    Public Sub suministros()
        sql = "select Nombre, Cantidad, FechaHora from Insumo I, AtencionPacienteInsumo API where I.IdInsumo = API.IdInsumo AND IdAtencionPaciente = " & id
        dgvInsumosSumi.DataSource = ConsultaDG("InsumosSumi")

        sql = "select Nombre, Presen, Cantidad, FechaHora from Medicamento M, AtencionPacienteMedicamento APM where M.IdMedicamento = APM.IdMedicamento AND IdAtencionPaciente = " & id
        dgvMedicamentosSumi.DataSource = ConsultaDG("MedicamentosSumi")
    End Sub

    Private Sub btnDerivarEstudios_Click(sender As Object, e As EventArgs) Handles btnDerivarEstudios.Click
        Estudios.txtDocBusqueda.Text = dgvAtencionPacientes.CurrentRow.Cells.Item(5).Value
        Me.Hide()
        Estudios.Show()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ActualizarEstado.id = dgvAtencionPacientes.CurrentRow.Cells.Item(0).Value
        ActualizarEstado.txtEstado.Text = dgvAtencionPacientes.CurrentRow.Cells.Item(4).Value
        Me.Hide()
        ActualizarEstado.Show()
    End Sub

    Private Sub btnSuministrar_Click(sender As Object, e As EventArgs) Handles btnSuministrar.Click
        SuministrarPaciente.id = dgvAtencionPacientes.CurrentRow.Cells.Item(0).Value
        SuministrarPaciente.cargar()
        Me.Hide()
        SuministrarPaciente.Show()
    End Sub

    Private Sub btnInternar_Click(sender As Object, e As EventArgs) Handles btnInternar.Click
        Me.Hide()
        InternacionPaciente.Show()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        sql = "update AtencionPaciente set fin = now() where idPaciente = " & dgvAtencionPacientes.CurrentRow.Cells.Item(6).Value
        rs = Consulta()
        cargar()
    End Sub
End Class
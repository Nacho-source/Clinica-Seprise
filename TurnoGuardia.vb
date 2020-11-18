Imports System.Data.Odbc

Public Class TurnoGuardia
    Dim rs As OdbcDataReader

    Private Sub TurnoGuardia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TraerTurnos()
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        Me.Hide()
        frmGuardia.Show()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Me.Hide()
        AgregarMedicoTurno.Show()
    End Sub

    Private Sub btnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiar.Click
        ModificarMedicoTurno.id = dgvGuardia.CurrentRow.Cells.Item(6).Value
        ModificarMedicoTurno.lblNombreMedico.Text = dgvGuardia.CurrentRow.Cells.Item(1).Value & " " & dgvGuardia.CurrentRow.Cells.Item(2).Value
        ModificarMedicoTurno.lblDia.Text = dgvGuardia.CurrentRow.Cells.Item(3).Value
        ModificarMedicoTurno.Hora.Text = dgvGuardia.CurrentRow.Cells.Item(4).Value.Hours
        ModificarMedicoTurno.Minutos.Text = dgvGuardia.CurrentRow.Cells.Item(4).Value.Minutes
        ModificarMedicoTurno.Duracion.Text = dgvGuardia.CurrentRow.Cells.Item(5).Value

        Me.Hide()
        ModificarMedicoTurno.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        sql = "UPDATE MedicoGuardia SET activo = !activo WHERE IdMedicoGuardia = " & dgvGuardia.CurrentRow.Cells.Item(6).Value
        rs = Consulta()
        TraerTurnos()
    End Sub

    Public Sub TraerTurnos()
        sql = "select Medico.IdMedico, Nombre, Apellido, Dia, Comienzo, Duracion, IdMedicoGuardia AS IdTurno, (CASE WHEN Activo = 1 THEN 'Activo' ELSE 'Inactivo' END) AS TurnoActivo from MedicoGuardia, Medico, Empleado where Medico.IdEmpleado = Empleado.IdEmpleado AND Medico.IdMedico = MedicoGuardia.IdMedico order by IdMedico, Dia, Comienzo"
        dgvGuardia.DataSource = ConsultaDG("TurnoGuardia")
    End Sub
End Class
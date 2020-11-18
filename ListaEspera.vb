Imports System.Data.Odbc

Public Class frmListaEspera
    Dim rs As OdbcDataReader

    Dim nombre As String

    Private Sub ListaEspera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        actualizarLista()
        actualizarMeds()

    End Sub

    Public Sub actualizarLista()
        sql = "select IdPacienteLista as Numero, Nombre, Apellido, TipoIngreso as Ingreso, Motivo, Fecha, Hora, Descripcion as Especialidad, P.IdPaciente from ListaEspera LE, Paciente P, Especialidad E where LE.IdPaciente=P.IdPaciente and LE.IdEspecialidad=E.IdEspecialidad and LE.IdUrgencia IS NULL order by Fecha DESC, Hora DESC"
        dgvListaEspera.DataSource = ConsultaDG("ListaEspera")

        sql = "select IdPacienteLista as Numero, P.Nombre, Apellido, TipoIngreso as Ingreso, Motivo, Fecha, Hora, Descripcion as Especialidad, U.Nombre as Urgencia, P.IdPaciente from ListaEspera LE, Paciente P, Especialidad E, Urgencia U where LE.IdPaciente=P.IdPaciente and LE.IdEspecialidad=E.IdEspecialidad and U.IdUrgencia = LE.IdUrgencia order by Fecha DESC, Hora DESC"
        dgvUrgencias.DataSource = ConsultaDG("ListaEsperaUrgencias")
    End Sub

    Public Sub medsDispSql()
        Dim hoy As Date = Date.Now
        Dim hora As String = Format(hoy, "HH:mm")
        Dim diaHoy As Integer = hoy.DayOfWeek - 1

        Dim dia(7) As String

        dia(0) = "Lunes"
        dia(1) = "Martes"
        dia(2) = "Miercoles"
        dia(3) = "Jueves"
        dia(4) = "Viernes"
        dia(5) = "Sabado"
        dia(6) = "Domingo"

        Dim diaAyer = diaHoy - 1
        If (diaAyer < 0) Then
            diaAyer = 6
        End If

        sql = "Select m.IdMedico, Nombre, Apellido, IdMedicoGuardia AS Turno From MedicoGuardia mg, Medico m, Empleado e Where m.IdEmpleado = e.IdEmpleado AND m.IdMedico = mg.IdMedico AND ('" & hora & "' BETWEEN comienzo AND ADDTIME(comienzo, CONCAT(duracion,':00'))) AND Activo = true AND (mg.Dia = '" & dia(diaHoy) & "') Order by IdMedico, Dia, Comienzo"
    End Sub

    Public Sub actualizarMeds()
        medsDispSql()
        dgvMedicosDisponibles.DataSource = ConsultaDG("MedicosDisp")
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        Me.Hide()
        frmGuardia.Show()
    End Sub

    Private Sub btnAgregarPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Me.Hide()
        AgregarPaciente.Show()
    End Sub

    Private Sub btnAtenderListaUrgencia_Click(sender As Object, e As EventArgs) Handles btnAtenderListaUrgencia.Click
        AtenderPacienteUrgencia.id = dgvUrgencias.CurrentRow.Cells.Item(9).Value
        AtenderPacienteNormal.idLista = dgvUrgencias.CurrentRow.Cells.Item(0).Value
        medsDispSql()
        AtenderPacienteUrgencia.cargarMedicos()
        Me.Hide()
        AtenderPacienteUrgencia.Show()
    End Sub

    Private Sub btnAtenderListaNormal_Click(sender As Object, e As EventArgs) Handles btnAtenderListaNormal.Click
        AtenderPacienteNormal.id = dgvListaEspera.CurrentRow.Cells.Item(8).Value
        AtenderPacienteNormal.idLista = dgvListaEspera.CurrentRow.Cells.Item(0).Value
        medsDispSql()
        AtenderPacienteNormal.cargarMedicos()
        Me.Hide()
        AtenderPacienteNormal.Show()
    End Sub

    Private Sub btnEliminarUrgencia_Click(sender As Object, e As EventArgs) Handles btnEliminarUrgencia.Click
        Dim opcion As Integer = MsgBox("¿Esta seguro que quiere eliminar el item seleccionado?", MsgBoxStyle.YesNo)
        If (opcion = 6) Then
            sql = "delete from listaespera where idpacientelista = " & dgvUrgencias.CurrentRow.Cells.Item(0).Value
            rs = Consulta()

            actualizarLista()
        End If
    End Sub

    Private Sub btnEliminarNormal_Click(sender As Object, e As EventArgs) Handles btnEliminarNormal.Click
        Dim opcion As Integer = MsgBox("¿Esta seguro que quiere eliminar el item seleccionado?", MsgBoxStyle.YesNo)
        If (opcion = 6) Then
            sql = "delete from listaespera where idpacientelista = " & dgvListaEspera.CurrentRow.Cells.Item(0).Value
            rs = Consulta()

            actualizarLista()
        End If
    End Sub
End Class
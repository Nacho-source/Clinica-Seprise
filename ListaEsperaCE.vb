Imports System.Data.Odbc

Public Class ListaEsperaCE
    Dim opc As Integer
    Dim rs As OdbcDataReader
    Dim turnoID As Integer
    Dim noNull As Boolean, esNull As Boolean
    Dim prueba As String, fecha As String

    Private Sub ListaEsperaCE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AbrirConexion()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
        AdministracionCE.Show()

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        If ((rbCC.Checked = False) And (rbFK.Checked = False) And (rbSM.Checked = False)) Then
            MsgBox("Error! No se ha Seleccionado el tipo de consulta a filtrar.", MsgBoxStyle.Critical)
            Me.Show()


        Else
            
            If ((rbFecha.Checked = False) And (rbPaciente.Checked = False)) Then
                If (rbCC.Checked = True) Then
                    'CONSULTA LARGA -> POR  consulta comun 
                    sql = "select t.TurnoID Turno, p.Nombre, p.Apellido, e.Nombre, e.Apellido, ms.IdSala Sala, tc.tipo TipoConsulta, hc.fechahora Horario ,t.Estado, t.Asistido from TurnoConsultaExterna t,paciente p, empleado e,medico m, MedicoSala ms, TipoConsultaExterna tc,HorarioConsultaComun hc where ((t.Idpaciente = p.IdPaciente) and (t.idSalaMedico = ms.idSalaMedico) and(ms.IdMedico = m.IdMedico) and (t.TipoConsultaExterna = tc.tipoID) and (t.idHorarioComun=hc.idhorariocomun) and (e.idEmpleado = m.idEmpleado)) group by t.turnoID"
                    dtgPacienteEspera.DataSource = ConsultaDG("Paciente")
                End If

                If (rbFK.Checked = True) Then

                    'CONSULTA LARGA -> POR  Fisio 
                    sql = "select t.TurnoID Turno, p.Nombre, p.Apellido, e.Nombre, e.Apellido, ms.IdSala Sala, tc.tipo TipoConsulta, hf.fechahora Horario,t.Estado, t.Asistido from TurnoConsultaExterna t,paciente p, empleado e,medico m, MedicoSala ms, TipoConsultaExterna tc, HorarioFisiokinesiologiaCE hf where ((t.Idpaciente = p.IdPaciente) and (t.idSalaMedico = ms.idSalaMedico) and(ms.IdMedico = m.IdMedico) and (t.TipoConsultaExterna = tc.tipoID) and (t.idHorarioFisio=hf.idhorarioFisio) and (e.idEmpleado = m.idEmpleado)) group by t.turnoID"
                    dtgPacienteEspera.DataSource = ConsultaDG("Paciente")
                End If

                If (rbSM.Checked = True) Then
                    'CONSULTA LARGA -> POR  SAlud Mental 
                    sql = "select t.TurnoID Turno, p.Nombre, p.Apellido, e.Nombre, e.Apellido, ms.IdSala Sala, tc.tipo TipoConsulta, hs.fechahora Horario ,t.Estado, t.Asistido from TurnoConsultaExterna t,paciente p, empleado e,medico m, MedicoSala ms, TipoConsultaExterna tc, HorarioSaludMentalCE hs where ((t.Idpaciente = p.IdPaciente) and (t.idSalaMedico = ms.idSalaMedico) and(ms.IdMedico = m.IdMedico) and (t.TipoConsultaExterna = tc.tipoID) and (t.idHorarioSM=hs.idhorarioSM) and (e.idEmpleado = m.idEmpleado)) group by t.turnoID"
                    dtgPacienteEspera.DataSource = ConsultaDG("Paciente")
                End If
            End If

            If (rbFecha.Checked = True) Then
                If (cboFecha.Text = "") Then
                    MsgBox("Error! No ha especificado la fecha para consultar los turnos.", MsgBoxStyle.Critical)
                Else
                    fecha = cambiarFecha(cboFecha.Text)
                    MsgBox(fecha)
                    If (rbCC.Checked = True) Then
                        'CONSULTA LARGA -> POR FECHA consulta comun 
                        sql = "select t.TurnoID Turno, p.Nombre, p.Apellido, e.Nombre, e.Apellido, ms.IdSala Sala, tc.tipo TipoConsulta, hc.fechahora Horario ,t.Estado, t.Asistido from TurnoConsultaExterna t,paciente p, empleado e,medico m, MedicoSala ms, TipoConsultaExterna tc,HorarioConsultaComun hc where ((t.Idpaciente = p.IdPaciente) and (t.idSalaMedico = ms.idSalaMedico) and(ms.IdMedico = m.IdMedico) and (t.TipoConsultaExterna = tc.tipoID) and (t.idHorarioComun=hc.idhorariocomun) and (e.idEmpleado = m.idEmpleado) and (hc.fechahora=" & fecha & ")) group by t.turnoID"
                        dtgPacienteEspera.DataSource = ConsultaDG("Paciente")
                    End If

                    If (rbFK.Checked = True) Then
                        'CONSULTA LARGA -> POR FECHA Fisio 
                        sql = "select t.TurnoID Turno, p.Nombre, p.Apellido, e.Nombre, e.Apellido, ms.IdSala Sala, tc.tipo TipoConsulta, hf.fechahora Horario,t.Estado, t.Asistido from TurnoConsultaExterna t,paciente p, empleado e,medico m, MedicoSala ms, TipoConsultaExterna tc, HorarioFisiokinesiologiaCE hf where ((t.Idpaciente = p.IdPaciente) and (t.idSalaMedico = ms.idSalaMedico) and(ms.IdMedico = m.IdMedico) and (t.TipoConsultaExterna = tc.tipoID) and (t.idHorarioFisio=hf.idhorarioFisio) and (e.idEmpleado = m.idEmpleado) and (hf.fechahora=" & fecha & ")) group by t.turnoID"
                        dtgPacienteEspera.DataSource = ConsultaDG("Paciente")
                    End If

                    If (rbSM.Checked = True) Then
                        'CONSULTA LARGA -> POR FECHA SAlud Mental 
                        sql = "select t.TurnoID Turno, p.Nombre, p.Apellido, e.Nombre, e.Apellido, ms.IdSala Sala, tc.tipo TipoConsulta, hs.fechahora Horario ,t.Estado, t.Asistido from TurnoConsultaExterna t,paciente p, empleado e,medico m, MedicoSala ms, TipoConsultaExterna tc, HorarioSaludMentalCE hs where ((t.Idpaciente = p.IdPaciente) and (t.idSalaMedico = ms.idSalaMedico) and(ms.IdMedico = m.IdMedico) and (t.TipoConsultaExterna = tc.tipoID) and (t.idHorarioSM=hs.idhorarioSM) and (e.idEmpleado = m.idEmpleado) and (hs.fechahora=" & fecha & ")) group by t.turnoID"
                        dtgPacienteEspera.DataSource = ConsultaDG("Paciente")
                    End If
                End If
            End If


                If (rbPaciente.Checked = True) Then

                    If (txtPaciente.Text = "") Then
                        MsgBox("Error! No ha ingresado el paciente que quiere consultar. Por favor ingreselo", MsgBoxStyle.Critical)
                        Me.Show()

                    Else
                        If (rbCC.Checked = True) Then
                            'CONSULTA LARGA -> POR NOMBRE consulta comun 
                            sql = "select t.TurnoID Turno, p.Nombre, p.Apellido, e.Nombre, e.Apellido, ms.IdSala Sala, tc.tipo TipoConsulta, hc.fechahora Horario ,t.Estado, t.Asistido from TurnoConsultaExterna t,paciente p, empleado e,medico m, MedicoSala ms, TipoConsultaExterna tc,HorarioConsultaComun hc where ((t.Idpaciente = p.IdPaciente) and (t.idSalaMedico = ms.idSalaMedico) and(ms.IdMedico = m.IdMedico) and (t.TipoConsultaExterna = tc.tipoID) and (t.idHorarioComun=hc.idhorariocomun) and (e.idEmpleado = m.idEmpleado) and (p.IdPaciente=" & txtPaciente.Text & ")) group by t.turnoID"
                            dtgPacienteEspera.DataSource = ConsultaDG("Paciente")
                        End If

                        If (rbFK.Checked = True) Then
                            'CONSULTA LARGA -> POR NOMBRE Fisio 
                            sql = "select t.TurnoID Turno, p.Nombre, p.Apellido, e.Nombre, e.Apellido, ms.IdSala Sala, tc.tipo TipoConsulta, hf.fechahora Horario,t.Estado, t.Asistido from TurnoConsultaExterna t,paciente p, empleado e,medico m, MedicoSala ms, TipoConsultaExterna tc, HorarioFisiokinesiologiaCE hf where ((t.Idpaciente = p.IdPaciente) and (t.idSalaMedico = ms.idSalaMedico) and(ms.IdMedico = m.IdMedico) and (t.TipoConsultaExterna = tc.tipoID) and (t.idHorarioFisio=hf.idhorarioFisio) and (e.idEmpleado = m.idEmpleado) and (p.IdPaciente=" & txtPaciente.Text & ")) group by t.turnoID"
                            dtgPacienteEspera.DataSource = ConsultaDG("Paciente")
                        End If

                        If (rbSM.Checked = True) Then
                            'CONSULTA LARGA -> POR NOMBRE SAlud Mental 
                            sql = "select t.TurnoID Turno, p.Nombre, p.Apellido, e.Nombre, e.Apellido, ms.IdSala Sala, tc.tipo TipoConsulta, hs.fechahora Horario ,t.Estado, t.Asistido from TurnoConsultaExterna t,paciente p, empleado e,medico m, MedicoSala ms, TipoConsultaExterna tc, HorarioSaludMentalCE hs where ((t.Idpaciente = p.IdPaciente) and (t.idSalaMedico = ms.idSalaMedico) and(ms.IdMedico = m.IdMedico) and (t.TipoConsultaExterna = tc.tipoID) and (t.idHorarioSM=hs.idhorarioSM) and (e.idEmpleado = m.idEmpleado) and (p.IdPaciente=" & txtPaciente.Text & ")) group by t.turnoID"
                            dtgPacienteEspera.DataSource = ConsultaDG("Paciente")
                        End If
                    End If
                End If
            End If

    End Sub

    Private Sub btnClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClean.Click
        opc = MsgBox("Esta seguro que desea blanquear las casillas de filtraje?", vbYesNo)

        If (opc = 6) Then

            txtPaciente.Text = ""
            rbFecha.Checked = False
            rbPaciente.Checked = False
            cboFecha.Text = ""
            rbCC.Checked = False
            rbFK.Checked = False
            rbSM.Checked = False

        ElseIf (opc = 7) Then
            Me.Show()

        Else
            MsgBox("Error Inesperado. Vuelva a intentarlo", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub rbFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFecha.CheckedChanged

        sql = "select fechahora from horarioConsultaComun"
        rs = Consulta()
       
        Do While rs.Read = True

            cboFecha.Items.Add(rs(0))
        Loop

        cboFecha.Enabled = True
        rbCC.Enabled = True
        rbFK.Enabled = True
        rbSM.Enabled = True

    End Sub
    Private Sub ListaEsperaCE_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AbrirConexion()

        MsgBox("Seleccione el Tipo de Consulta.", MsgBoxStyle.Exclamation)

    End Sub

    Private Sub rbPaciente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPaciente.CheckedChanged
        cboFecha.Enabled = False
    End Sub

    Private Sub rbCC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCC.CheckedChanged
        cboFecha.Items.Clear()

        sql = "select fechahora from horarioConsultaComun"
        rs = Consulta()
        While rs.Read() = True
            cboFecha.Items.Add(rs(0))
        End While
    End Sub

    Private Sub rbFK_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFK.CheckedChanged
        cboFecha.Items.Clear()

        sql = "select fechahora from horariofisiokinesiologiace"
        rs = Consulta()
        While rs.Read() = True
            cboFecha.Items.Add(rs(0))
        End While

    End Sub

    Private Sub rbSM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSM.CheckedChanged
        cboFecha.Items.Clear()

        sql = "select fechahora from horariosaludmentalce"
        rs = Consulta()
        While rs.Read() = True
            cboFecha.Items.Add(rs(0))
        End While
    End Sub

    Private Sub dtgPacienteEspera_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgPacienteEspera.CellClick
        If (dtgPacienteEspera.SelectedRows.Count = 1) Then
            turnoID = dtgPacienteEspera.Item(0, dtgPacienteEspera.CurrentRow.Index).Value
            MsgBox("Se ha seleccionado al paciente: " & turnoID & " Para realizar una accion", MsgBoxStyle.Information)
    
        End If


    End Sub

    Private Sub btnAsistio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsistio.Click
        sql = "update turnoConsultaExterna set Asistido=1 where turnoID= " & dtgPacienteEspera.CurrentRow.Cells.Item(0).Value & ""
        rs = Consulta()
        rs.Read()
        MsgBox("Se ha confirmado la asistencia del Paciente", MsgBoxStyle.Information)
        dtgPacienteEspera.Refresh()
        Me.Hide()
        Me.Show()

    End Sub

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click


        If (dtgPacienteEspera.CurrentRow.Cells.Item(0).Value = 0) Then
            MsgBox("Error! Debe seleccionar un casillero del cliente para iniciar una consulta. Vuelva a Intentarlo.", MsgBoxStyle.Critical)
            Me.Show()
        End If

        AtencionPaciente.txtTurno.Text = turnoID

        sql = "select t.IdPaciente from TurnoConsultaExterna t where (t.turnoID=" & turnoID & ")"
        rs = Consulta()
        rs.Read()
        AtencionPaciente.txtPaciente.Text = rs(0)

        sql = "select p.Apellido from paciente p, TurnoConsultaExterna t where ((t.idPaciente=p.IdPaciente) and (t.turnoID=" & turnoID & "))"
        rs = Consulta()
        rs.Read()
        AtencionPaciente.txtApellido.Text = rs(0)

        sql = "select Email from paciente p, TurnoConsultaExterna t where ((t.idPaciente=p.IdPaciente) and (t.turnoID=" & turnoID & "))"
        rs = Consulta()
        rs.Read()
        AtencionPaciente.txtEmail.Text = rs(0)

        sql = "select Nombre from paciente p, TurnoConsultaExterna t where ((t.idPaciente=p.IdPaciente) and (t.turnoID=" & turnoID & "))"
        rs = Consulta()
        rs.Read()
        AtencionPaciente.txtNombre.Text = rs(0)

        sql = "select Telefono from paciente p, TurnoConsultaExterna t where ((t.idPaciente=p.IdPaciente) and (t.turnoID=" & turnoID & "))"
        rs = Consulta()
        rs.Read()
        AtencionPaciente.txtTelefono.Text = rs(0)

        sql = "select tp.tipo from TipoConsultaExterna tp, TurnoConsultaExterna t where ((t.TipoConsultaExterna=tp.tipoID) and (turnoID=" & turnoID & "))"
        rs = Consulta()
        rs.Read()
        AtencionPaciente.txtTipo.Text = rs(0)

        sql = "select now()"
        rs = Consulta()
        rs.Read()
        AtencionPaciente.txtFecha.Text = rs(0)

        sql = "select e.nombre, e.apellido, e.email from empleado e, medico m, turnoconsultaExterna t, medicosala ms where ((t.IdSalaMedico=ms.IdSalaMedico) and (ms.IdMedico = m.IdMedico) and (e.Idempleado=m.idEmpleado) and (t.turnoID=" & turnoID & "))"
        rs = Consulta()
        rs.Read()
        AtencionPaciente.txtMailMed.Text = rs(2)
        AtencionPaciente.txtNomMed.Text = rs(0)
        AtencionPaciente.txtApeMed.Text = rs(1)

        Me.Hide()
        AtencionPaciente.Show()

    End Sub

    Private Sub btnAusente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAusente.Click
        sql = "update turnoConsultaExterna set Asistido=0 where turnoID= " & dtgPacienteEspera.CurrentRow.Cells.Item(0).Value & ""
        rs = Consulta()
        rs.Read()
        MsgBox("Se ha confirmado la asistencia del Paciente", MsgBoxStyle.Information)
        dtgPacienteEspera.Refresh()
        Me.Hide()
        Me.Show()

    End Sub


End Class

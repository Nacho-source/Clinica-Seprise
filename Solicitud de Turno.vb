Imports System.Data.Odbc
Public Class SolicitudTurno
    Dim rs As OdbcDataReader
    Dim ds As New DataSet
    Dim adp As OdbcDataAdapter
    Dim cnn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim var, var2 As Integer
    Dim eoff As Boolean
    Dim varst As String
    Dim flagmedico, flagsobreturno As Boolean

    Private Sub SolicitudTurno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Enabled = True
        AbrirConexion()

        flagmedico = False
        txtMedico.Visible = False
        lblMedico.Visible = False
        btnSobreTurno.Enabled = True

    End Sub

    Private Sub rbSM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSM.CheckedChanged
        cboFH.Enabled = True
        rbCC.Checked = False
        rbFK.Checked = False

        sql = "select fechahora from HorarioSaludMentalCE hcc where(IdHorarioSM) not in(Select tce.IdHorarioSM from TurnoConsultaExterna tce, HorarioSaludMentalCE hsm where(estado = 1) and (tce.idHorarioSm = hsm.idHorarioSM))"
        rs = Consulta()

        While (cboFH.Text <> "")

            cboFH.Items.Clear()

        End While

        While (rs.Read = True)

            cboFH.Items.Add(rs(0))

        End While

        cboFH.Text = "Seleccione fecha y horario:"

    End Sub

    Private Sub rbFK_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFK.CheckedChanged
        cboFH.Enabled = True
        rbCC.Checked = False
        rbSM.Checked = False

        sql = "select fechahora from HorarioFisiokinesiologiaCE hcc where(IdHorarioFisio) not in(Select tce.IdHorarioFisio from TurnoConsultaExterna tce, HorarioFisiokinesiologiaCE hf where(estado = 1) and (tce.idHorarioFisio = hf.idHorarioFisio))"
        rs = Consulta()

        While (cboFH.Text <> "")

            cboFH.Items.Clear()

        End While

        While (rs.Read = True)

            cboFH.Items.Add(rs(0))

        End While

        cboFH.Text = "Seleccione fecha y horario:"

    End Sub

    Private Sub rbCC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCC.CheckedChanged
        cboFH.Enabled = True
        rbFK.Checked = False
        rbSM.Checked = False

        sql = "select fechahora from HorarioConsultaComun hcc where(idHorarioComun) not in(Select tce.idHorarioComun from TurnoConsultaExterna tce, HorarioConsultaComun hf where(estado = 1) and (tce.idHorarioComun = hf.idHorarioComun))"
        rs = Consulta()

        While (cboFH.Text <> "")

            cboFH.Items.Clear()

        End While

        While (rs.Read = True)

            cboFH.Items.Add(rs(0))

        End While

        cboFH.Text = "Seleccione fecha y horario:"

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        AdministracionCE.Show()
    End Sub

    Private Sub btnSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolicitud.Click

        var = MsgBox("¿Está seguro de que desea solicitar el turno con la información ingresada?", vbYesNo)
        If (var = 6) Then
            sql = "select count(*) from paciente where documentacion = '" & txtPaciente.Text & "'"
            rs = Consulta()
            rs.Read()

            If (txtPaciente.Text = "" Or cboFH.Text = "Seleccione fecha y horario:") Then

                MsgBox("INGRESE DNI DEL PACIENTE Y SELECCIONE UN HORARIO Y FECHA", vbCritical, "ERROR")

            Else
                If (rs.Item(0) = 0) Then

                    MsgBox("El DNI ingresado no corresponde a ningun paciente", vbCritical, "ERROR")

                Else

                    sql = "select idPaciente from paciente where documentacion = '" & txtPaciente.Text & "'"
                    rs = Consulta()
                    rs.Read()
                    Dim varpaciente As Integer = rs.Item(0)

                    If (flagmedico = True) Then

                        sql = "select e.nombre, e.apellido, ms.idSala, ms.idSalaMedico from medico m, empleado e, MedicoSala ms, sala s, (select ms.idSalaMedico, count(*) cantidad from TurnoConsultaExterna tce, MedicoSala ms where(tce.idSalaMedico = MS.idSalaMedico) group by ms.idSalaMedico) subconsulta where(MS.idSala = s.idSala) and (ms.idSalaMedico = subconsulta.idSalaMedico) and (capacidad > subconsulta.cantidad) and (e.idEmpleado = m.idEmpleado) and (m.idMedico = ms.idMedico)"
                        rs = Consulta()

                        While (rs.Read = True)
                            If ((rs.Item(0) & " " & rs.Item(1)) = ElegirMedico.cboMed.Text) Then
                                var2 = rs.Item(3)

                                CompTurno.lblSal.Text = rs.Item(3)
                                CompTurno.lblNomMed.Text = rs.Item(0) & " " & rs.Item(1)
                            End If
                        End While

                    Else
                        sql = "select ms.idSalaMedico, ms.idSala, ms.idMedico, e.nombre, e.apellido from medico m, empleado e, MedicoSala ms, sala s, (select ms.idSalaMedico, count(*) cantidad from TurnoConsultaExterna tce, MedicoSala ms where(tce.idSalaMedico = MS.idSalaMedico) group by ms.idSalaMedico) subconsulta where(MS.idSala = s.idSala) and (ms.idSalaMedico = subconsulta.idSalaMedico) and (capacidad > subconsulta.cantidad) and (e.idEmpleado = m.idEmpleado) and (m.idMedico = ms.idMedico) limit 1"
                        rs = Consulta()
                        rs.Read()
                        var2 = rs.Item(0)

                        CompTurno.lblSal.Text = rs.Item(1)
                        CompTurno.lblNomMed.Text = rs.Item(3) & " " & rs.Item(4)

                    End If

                If (rbCC.Checked = True) Then

                    Dim a = cambiarFecha(cboFH.Text)

                    sql = "select idHorarioComun from HorarioConsultaComun where(fechahora = '" & a & "')"
                    rs = Consulta()
                    rs.Read()
                    var = rs.Item(0)

                    If (flagsobreturno = True) Then
                        sql = "update HorarioConsultaComun set sobreturno = 1 where idHorarioComun = " & var & ""
                        rs = Consulta()

                    End If

                    sql = "insert into TurnoConsultaExterna values ('', 1, " & varpaciente & ", " & var2 & ", 1, 0, " & var & ", NULL, NULL)"
                    rs = Consulta()

                    CompTurno.lblConsulta.Text = "Consulta Común"

                Else
                    If (rbFK.Checked = True) Then

                        Dim a = cambiarFecha(cboFH.Text)

                        sql = "select idHorarioFisio from HorarioFisiokinesiologiaCE where (fechahora = '" & a & "')"
                        rs = Consulta()
                        rs.Read()
                        var = rs.Item(0)

                        If (flagsobreturno = True) Then
                            sql = "update HorarioFisiokinesiologiaCE set sobreturno = 1 where idHorarioFisio = " & var & ""
                            rs = Consulta()

                        End If

                        sql = "insert into TurnoConsultaExterna values ('', 2, " & varpaciente & ", " & var2 & ", 1, 0, NULL, " & var & ", NULL)"
                        rs = Consulta()

                        CompTurno.lblConsulta.Text = "Fisiokinesiología"

                    Else

                        Dim a = cambiarFecha(cboFH.Text)

                        sql = "select idHorarioSM from HorarioSaludMentalCE where (fechahora = '" & a & "')"
                        rs = Consulta()
                        rs.Read()
                        var = rs.Item(0)

                        If (flagsobreturno = True) Then
                            sql = "update HorarioSaludMentalCE set sobreturno = 1 where idHorarioSM = " & var & ""
                            rs = Consulta()
                        End If

                        sql = "insert into TurnoConsultaExterna values ('', 3, " & varpaciente & ", " & var2 & ", 1, 0, NULL, NULL, " & var & ")"
                        rs = Consulta()

                        CompTurno.lblConsulta.Text = "Salud Mental"

                    End If
                End If

                Me.Hide()

                With CompTurno
                    .Show()

                    .lblDNI.Text = txtPaciente.Text

                    sql = "select nombre, apellido from paciente where (documentacion = " & txtPaciente.Text & ")"
                    rs = Consulta()
                    rs.Read()

                    .lblNom.Text = rs(0) + " " + rs(1)

                    sql = "select max(turnoid) from TurnoConsultaExterna limit 1"
                    rs = Consulta()
                    rs.Read()
                    var = rs(0) + 1

                    .lblidTurno.Text = var
                    .lblID.Text = txtPaciente.Text
                    .lblFecha.Text = Date.Today
                    .lblFH.Text = cboFH.Text

                End With

            End If

        End If

        End If

    End Sub

    Private Sub btnMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedico.Click
        If (txtPaciente.Text = "" Or cboFH.Text = "Seleccione fecha y horario:") Then

            MsgBox("INGRESE DNI DEL PACIENTE Y SELECCIONE UN HORARIO Y FECHA", vbCritical, "ERROR")

        Else
            ElegirMedico.Show()
            txtMedico.Visible = True
            lblMedico.Visible = True
            flagmedico = True

            sql = "select ms.idMedico, e.nombre, e.apellido from medico m, empleado e, MedicoSala ms, sala s, (select ms.idSalaMedico, count(*) cantidad from TurnoConsultaExterna tce, MedicoSala ms where(tce.idSalaMedico = MS.idSalaMedico) group by ms.idSalaMedico) subconsulta where(MS.idSala = s.idSala) and (ms.idSalaMedico = subconsulta.idSalaMedico) and (capacidad > subconsulta.cantidad) and (e.idEmpleado = m.idEmpleado) and (m.idMedico = ms.idMedico)"
            rs = Consulta()

            While (ElegirMedico.cboMed.Text <> "")

                ElegirMedico.cboMed.Items.Clear()

            End While

            While (rs.Read = True)

                ElegirMedico.cboMed.Items.Add(rs.Item(1) & " " & rs.Item(2))

            End While

        End If

    End Sub

    Private Sub btnSobreTurno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSobreTurno.Click
        var = MsgBox("¿Está seguro de que desea solicitar un sobreturno?", vbYesNo)

        If (var = 6) Then
            If (rbCC.Checked = False And rbFK.Checked = False And rbSM.Checked = False) Then
                MsgBox("SELECCIONE UN TIPO DE CONSULTA PRIMERO", vbExclamation)
            Else
                btnSobreTurno.Enabled = False
                flagsobreturno = True

                If (rbCC.Checked = True) Then
                    sql = "select fechahora from HorarioConsultaComun"
                    rs = Consulta()

                    While (cboFH.Text <> "")

                        cboFH.Items.Clear()

                    End While

                    While (rs.Read = True)

                        cboFH.Items.Add(rs(0))

                    End While

                    cboFH.Text = "Seleccione fecha y horario:"
                Else
                    If (rbFK.Checked = True) Then
                        sql = "select fechahora from HorarioFisiokinesiologiaCE hcc"
                        rs = Consulta()

                        While (cboFH.Text <> "")

                            cboFH.Items.Clear()

                        End While

                        While (rs.Read = True)

                            cboFH.Items.Add(rs(0))

                        End While

                        cboFH.Text = "Seleccione fecha y horario:"
                    Else
                        If (rbSM.Checked = True) Then
                            sql = "select fechahora from HorarioSaludMentalCE"
                            rs = Consulta()

                            While (cboFH.Text <> "")

                                cboFH.Items.Clear()

                            End While

                            While (rs.Read = True)

                                cboFH.Items.Add(rs(0))

                            End While

                            cboFH.Text = "Seleccione fecha y horario:"
                        Else

                        End If

                    End If

                End If

            End If

        End If
    End Sub
End Class

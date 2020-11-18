Imports System.Data.Odbc

Public Class LiquidacionHonorarios
    Dim rs As OdbcDataReader
    Dim ds As New DataSet
    Dim adp As OdbcDataAdapter
    Dim cnn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim var, var2, conttotal, contasis As Integer
    Dim eoff As Boolean
    Dim varst As String

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If (txtDNI.Text = "") Then

            MsgBox("Debe ingresar el DNI de un médico!", vbCritical, "ERROR")

        Else
            sql = "select count(*) from medico m, empleado e where(m.idEmpleado = e.idEmpleado) and (e.documentacion= '" & txtDNI.Text & "')"
            rs = Consulta()
            rs.Read()

            If (rs.Item(0) = 0) Then

                MsgBox("El dni ingresado no corresponde a ningún médico", vbExclamation, "ERROR")
                txtDNI.Text = ""

            Else
                sql = "select count(*) from PlusHonorarioMedico phm, medico m, empleado e where (phm.idMedico = " & txtDNI.Text & ") and (fecha=curdate()) and (e.idEmpleado= m.idEmpleado) and (m.idMedico=phm.idMedico)"
                rs = Consulta()
                rs.Read()

                If (rs.Item(0) <> 0) Then
                    MsgBox("La liquidacion de honorarios para el médico seleccionado ya fue hecha este mes", vbExclamation, "Mensaje")

                Else

                    contasis = 0
                    conttotal = 0
                    'recuento de asistencias en consultas comunes
                    sql = "select count(*) cantidad from medico m, empleado e, TurnoConsultaExterna tce, MedicoSala ms, HorarioConsultaComun hcc where(m.idEmpleado = e.idEmpleado) and (ms.idMedico = m.idMedico) and (tce.idSalaMedico = ms.idSalaMedico) and (hcc.idHorarioComun = tce.idHorarioComun) and (e.documentacion= '" & txtDNI.Text & "') and (tce.asistido = 1) and (TipoConsultaExterna = 1) and (MONTH(hcc.fechahora) = 1)" 'aca se debe reemplazar el mes 1 por Today.Month para comparar con el mes actual
                    rs = Consulta()
                    rs.Read()
                    contasis = contasis + rs.Item(0)
                    InformeLiquidacionSueldo.txtCCA.Text = rs.Item(0)

                    sql = "select count(*) cantidad from medico m, empleado e, TurnoConsultaExterna tce, MedicoSala ms, HorarioConsultaComun hcc where(m.idEmpleado = e.idEmpleado) and (ms.idMedico = m.idMedico) and (tce.idSalaMedico = ms.idSalaMedico) and (hcc.idHorarioComun = tce.idHorarioComun) and (e.documentacion= '" & txtDNI.Text & "') and (TipoConsultaExterna = 1) and (MONTH(hcc.fechahora) = 1)" 'aca se debe reemplazar el mes 1 por Today.Month para comparar con el mes actual
                    rs = Consulta()
                    rs.Read()
                    conttotal = conttotal + rs.Item(0)
                    InformeLiquidacionSueldo.txtCC.Text = rs.Item(0)

                    'recuento de asistencias en consultas de fisiokinesiologia
                    sql = " select count(*) cantidad from medico m, empleado e, TurnoConsultaExterna tce, MedicoSala ms, HorarioFisiokinesiologiaCE hf where(m.idEmpleado = e.idEmpleado) and (ms.idMedico = m.idMedico) and (tce.idSalaMedico = ms.idSalaMedico) and (hf.idHorarioFisio = tce.idHorarioFisio) and (e.documentacion= '" & txtDNI.Text & "') and (tce.asistido = 1) and (TipoConsultaExterna = 2) and (MONTH(hf.fechahora) = '" & Today.Month & "')"
                    rs = Consulta()
                    rs.Read()
                    contasis = contasis + rs.Item(0)
                    InformeLiquidacionSueldo.txtCFKA.Text = rs.Item(0)

                    sql = " select count(*) cantidad from medico m, empleado e, TurnoConsultaExterna tce, MedicoSala ms, HorarioFisiokinesiologiaCE hf where(m.idEmpleado = e.idEmpleado) and (ms.idMedico = m.idMedico) and (tce.idSalaMedico = ms.idSalaMedico) and (hf.idHorarioFisio = tce.idHorarioFisio) and (e.documentacion= '" & txtDNI.Text & "') and (TipoConsultaExterna = 2) and (MONTH(hf.fechahora) = '" & Today.Month & "')"
                    rs = Consulta()
                    rs.Read()
                    conttotal = conttotal + rs.Item(0)
                    InformeLiquidacionSueldo.txtCFK.Text = rs.Item(0)

                    'recuento de asistencias en consultas de salud mental
                    sql = "select count(*) from medico m, empleado e, TurnoConsultaExterna tce, MedicoSala ms, HorarioSaludMentalCE hsm where (m.idEmpleado = e.idEmpleado) and (ms.idMedico = m.idMedico) and (tce.idSalaMedico = ms.idSalaMedico) and (hsm.idHorarioSM = tce.idHorarioSM) and (e.documentacion= '" & txtDNI.Text & "') and (tce.asistido = 1) and (TipoConsultaExterna = 3) and (MONTH(hsm.fechahora) = '" & Today.Month & "')"
                    rs = Consulta()
                    rs.Read()
                    contasis = contasis + rs.Item(0)
                    InformeLiquidacionSueldo.txtCSMA.Text = rs.Item(0)

                    sql = "select count(*) from medico m, empleado e, TurnoConsultaExterna tce, MedicoSala ms, HorarioSaludMentalCE hsm where (m.idEmpleado = e.idEmpleado) and (ms.idMedico = m.idMedico) and (tce.idSalaMedico = ms.idSalaMedico) and (hsm.idHorarioSM = tce.idHorarioSM) and (e.documentacion= '" & txtDNI.Text & "') and (TipoConsultaExterna = 3) and (MONTH(hsm.fechahora) = '" & Today.Month & "')"
                    rs = Consulta()
                    rs.Read()
                    conttotal = conttotal + rs.Item(0)
                    InformeLiquidacionSueldo.txtCSM.Text = rs.Item(0)

                    If (conttotal = 0) Then
                        MsgBox("El médico seleccionado no ha sido asignado a consultas este mes", vbExclamation)
                    Else
                        InformeLiquidacionSueldo.txtTotalConsultas.Text = conttotal
                        InformeLiquidacionSueldo.txtTotalConsultasAsistidas.Text = contasis

                        var = contasis / conttotal * 100
                        InformeLiquidacionSueldo.txtPorcen.Text = "%" & var

                        sql = "select nombre, apellido, idMedico from empleado e, medico m where (m.idEmpleado = e.idEmpleado) and documentacion = '" & txtDNI.Text & "'"
                        rs = Consulta()
                        rs.Read()

                        If (var = 100) Then
                            MsgBox("El porcentaje de asistencia en las consultas del doctor " & rs.Item(0) & " " & rs.Item(1) & " en este mes es del 100%. Por lo tanto, le corresponde un 40% de incremento del sueldo bruto($8000)", vbInformation)
                            InformeLiquidacionSueldo.txtPlus.Text = "$8000"
                            InformeLiquidacionSueldo.txtTotal.Text = InformeLiquidacionSueldo.txtPlus.Text + 20000

                            sql = " insert into PlusHonorarioMedico values (" & rs.Item(2) & ", curdate(), 8000)"
                            rs = Consulta()
                            rs.Read()
                        Else
                            If (var > 75) Then
                                MsgBox("El porcentaje de asistencia en las consultas del doctor " & rs.Item(0) & " " & rs.Item(1) & " en este mes es del " & var & "%. Por lo tanto, le corresponde un 30% de incremento del sueldo bruto($6000)", vbInformation)
                                InformeLiquidacionSueldo.txtPlus.Text = "$6000"
                                InformeLiquidacionSueldo.txtTotal.Text = InformeLiquidacionSueldo.txtPlus.Text + 20000

                                sql = " insert into PlusHonorarioMedico values (" & rs.Item(2) & ", curdate(), 6000)"
                                rs = Consulta()
                                rs.Read()
                            Else
                                If (var > 50) Then
                                    MsgBox("El porcentaje de asistencia en las consultas del doctor " & rs.Item(0) & " " & rs.Item(1) & " en este mes es del " & var & "%. Por lo tanto, le corresponde un 20% de incremento del sueldo bruto($4000)", vbInformation)
                                    InformeLiquidacionSueldo.txtPlus.Text = "$4000"
                                    InformeLiquidacionSueldo.txtTotal.Text = InformeLiquidacionSueldo.txtPlus.Text + 20000

                                    sql = "insert into PlusHonorarioMedico values (" & rs.Item(2) & ", curdate(), 4000)"
                                    rs = Consulta()
                                    rs.Read()
                                Else
                                    If (var > 25) Then
                                        MsgBox("El porcentaje de asistencia en las consultas del doctor " & rs.Item(0) & " " & rs.Item(1) & " en este mes es del " & var & "%. Por lo tanto, le corresponde un 10% de incremento del sueldo bruto($2000)", vbInformation)
                                        InformeLiquidacionSueldo.txtPlus.Text = "$2000"
                                        InformeLiquidacionSueldo.txtTotal.Text = InformeLiquidacionSueldo.txtPlus.Text + 20000

                                        sql = "insert into PlusHonorarioMedico values (" & rs.Item(2) & ", curdate(), 2000)"
                                        rs = Consulta()
                                        rs.Read()
                                    Else
                                        MsgBox("El porcentaje de asistencia en las consultas del doctor " & rs.Item(0) & " " & rs.Item(1) & " en este mes es del " & var & "%. Por lo tanto, no le corresponde un incremento del sueldo bruto", vbInformation)
                                        InformeLiquidacionSueldo.txtPlus.Text = "$0"
                                        InformeLiquidacionSueldo.txtTotal.Text = "$" & InformeLiquidacionSueldo.txtPlus.Text + 20000
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                InformeLiquidacionSueldo.Show()
            End If
        End If

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        AdministracionCE.Show()
    End Sub

    Private Sub LiquidacionHonorarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDNI.Text = ""
    End Sub
End Class
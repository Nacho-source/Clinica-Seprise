'Imports System.Data.Odbc

'Public Class AgendaTurnos
'    Dim rsHorarios As OdbcDataReader
'    Dim rsOs As OdbcDataReader
'    Dim rsEstudios As OdbcDataReader
'    Dim rsGuardarInsumo As OdbcDataReader
'    Dim rsStock As OdbcDataReader
'    Dim consulta As String
'    Dim consultaEstudio As String
'    Dim idEstudio As Integer
'    Dim idObraSocial As Integer
'    Dim nombreEstudio As String
'    Dim nombreOS As String
'    Dim consultaObraEstudio As String
'    Dim guardarInsumo As String
'    Dim stock As String
'    Dim rsOE As OdbcDataReader

'    Dim nombre As String
'    Dim apellido As String
'    Dim nroDocumento As Integer
'    Dim fecha As Object
'    Dim horario As String
'    Dim consultaAgendaTurno As String
'    Dim fechaInvertida As String
'    Dim detalle As String
'    Dim busquedaId As Integer
'    Dim rsBusqueda As OdbcDataReader
'    Dim guardarTurno As Object
'    Public idPaciente As Integer
'    Dim banderaObraSocial As Integer = 1
'    Dim consultaMedico As String
'    Dim rsMedico As OdbcDataReader
'    Dim medico As String
'    Dim rsGuardarTurno As OdbcDataReader
'    Dim busquedanoExiste As Integer
'    Dim clickeado As Boolean = False

'    Private Sub AgendaTurnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        AbrirConexion()
'        cargaHorario()
'        cboEstudios.Text = "Estudios..."
'        cboHorario.Text = "Horarios..."
'        cboObrasSociales.Text = "Obra Social..."
'        cboMedico.Text = "Medicos..."
'        txtEspecificaciones.Text = ""
'        rbtNo.Checked = False
'        rbtSi.Checked = False
'    End Sub


'    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
'        clickeado = True
'        consultaEstudio = "select * from estudio"
'        Call EjecutarEstudios(consultaEstudio)
'        While rsEstudios.Read = True
'            nombreEstudio = cboEstudios.Text.ToString
'            If nombreEstudio = rsEstudios(1) Then
'                idEstudio = rsEstudios(0)
'                Exit While
'            End If
'        End While

'        consulta = "select * from ObraSocial"
'        Call EjecutarObraS(consulta)
'        While rsOs.Read = True
'            nombreOS = cboObrasSociales.Text.ToString
'            If nombreOS = rsOs(1) Then
'                idObraSocial = rsOs(0)
'                Exit While
'            End If
'        End While

'        consultaObraEstudio = "select count(*) from obraestudio where idObraSocial = '" & idObraSocial & "' and idEstudio = '" & idEstudio & "'  "
'        Call EjecutarObraEstudio(consultaObraEstudio)

'        If rsOE.Read = True Then

'            If rsOE(0) = 0 Then

'                MsgBox("La obra social NO cubre el estudio", MsgBoxStyle.Exclamation, "Mensaje")
'                banderaObraSocial = 1
'            Else

'                MsgBox("La obra social cubre el estudio", MsgBoxStyle.Exclamation, "Mensaje")
'                banderaObraSocial = 2
'            End If

'        End If

'    End Sub

'    Private Sub rbtSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSi.CheckedChanged
'        lblObraS.Visible = True
'        cboObrasSociales.Visible = True
'        btnCalcular.Visible = True
'    End Sub

'    Private Sub rbtNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNo.CheckedChanged
'        lblObraS.Visible = False
'        cboObrasSociales.Visible = False
'        btnCalcular.Visible = False
'    End Sub


'    Private Sub btnTurno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTurno.Click

'        Dim encontrado As Integer
'        Dim valorError As Boolean = False
'        If rbtSi.Checked = True Then

'            If cboObrasSociales.Text = "Obras Social..." Or clickeado = False Then

'                valorError = True

'            End If

'        End If

'        If cboEstudios.Text = "Estudios..." Or cboHorario.Text = "Horarios..." Or cboMedico.Text = "Medicos..." Or txtEspecificaciones.Text = "" Or (rbtNo.Checked = False And rbtSi.Checked = False) And valorError = False Then

'            MsgBox("No se han completado todos los datos", MsgBoxStyle.Critical, "Atencion!")

'        ElseIf valorError = False Then
'            If MsgBox("Esta seguro de guardar los datos?", MsgBoxStyle.YesNo, "Atencion!") = MsgBoxResult.Yes Then
'                fecha = Format(dtpDia.Value.Date, "yyyy/MM/dd")
'                horario = cboHorario.Text.ToString
'                detalle = txtEspecificaciones.Text
'                medico = cboMedico.Text
'                If rbtSi.Checked = True Then
'                    consulta = "select idObraSocial from ObraSocial where nombre = '" & cboObrasSociales.Text & "'"
'                    Call EjecutarObraS(consulta)
'                    'If rsBusqueda.Read = True Then
'                    '    idObraSocial = rsOs(0)
'                    'End If

'                End If

'                consultaEstudio = "select IdEstudio from estudio where descripcion = '" & cboEstudios.Text & "'"
'                Call EjecutarEstudios(consultaEstudio)

'                If rsEstudios.Read = True Then
'                    idEstudio = rsEstudios(0)
'                End If



'                consultaAgendaTurno = "select count(*) from agendaturno where fecha = '" & fecha & "' and horario= '" & horario & "'; "
'                Call EjecutarHorarios(consultaAgendaTurno)
'                If rsHorarios.Read = True Then

'                    If rsHorarios(0) = 0 Then

'                        If banderaObraSocial = 1 Then
'                            guardarTurno = "insert into agendaturno values ('' , '" & fecha & "' , '" & horario & "', '" & detalle & "' , null, '" & medico & "' , '" & idEstudio & "', '" & idPaciente & "' )"
'                            Call EjecutarTurno(guardarTurno)

'                        Else
'                            guardarTurno = "insert into agendaturno values ('' , '" & fecha & "' , '" & horario & "', '" & detalle & "' , '" & idObraSocial & "' ,'" & medico & "' , '" & idEstudio & "', '" & idPaciente & "' )"
'                            Call EjecutarTurno(guardarTurno)

'                        End If
'                        lblFecha.Text = dtpDia.Value.Date.ToString
'                        lblHora.Text = cboHorario.Text.ToString
'                        lblNombreEstudio.Text = cboEstudios.Text.ToString
'                        MsgBox("el turno se guardo con exito", MsgBoxStyle.Exclamation, "mensaje")

'                        guardarInsumo = "select ei.idinsumo, count(*) from estudio e, estudioInsumo ei where e.idestudio = ei.idestudio and e.idestudio = '" & rsEstudios(0) & "'"
'                        Call EjecutarInsumo(guardarInsumo)

'                        If rsGuardarInsumo.Read = True Then
'                            If rsGuardarInsumo(1) <> 0 Then
'                                stock = "update Insumo_Sector set Stock = (Stock - 1) where idinsumo = '" & rsGuardarInsumo(0) & "'"
'                                Call EjecutarStock(stock)
'                            End If
'                        End If

'                        guardarInsumo = "select em.idmedicamento, count(*) from estudio e, estudioMedicamento em where e.idestudio = em.idestudio and e.idestudio = '" & rsEstudios(0) & "'"
'                        Call EjecutarInsumo(guardarInsumo)

'                        If rsGuardarInsumo.Read = True Then
'                            If rsGuardarInsumo(1) <> 0 Then
'                                stock = "update Medicamento_Sector set Stock = (Stock - 1) where idmedicamento = '" & rsGuardarInsumo(0) & "'"
'                                Call EjecutarStock(stock)
'                            End If

'                        End If

'                        gbCTurno.Visible = True
'                        gbTurno.Visible = False
'                        encontrado = 0
'                        cboEstudios.Text = "Estudios..."
'                        cboHorario.Text = "Horarios..."
'                        cboObrasSociales.Text = "Obra Social..."
'                        cboMedico.Text = "Medicos..."
'                        txtEspecificaciones.Text = ""
'                        rbtNo.Checked = False
'                        rbtSi.Checked = False

'                    Else

'                        encontrado = 1

'                    End If

'                    If encontrado <> 0 Then
'                        MsgBox("el turno ya esta ocupado. por favor, seleccione otro", MsgBoxStyle.Information, "mensaje")
'                    End If

'                End If
'            End If
'            Else
'                MsgBox("No se han completado todos los datos", MsgBoxStyle.Critical, "Atencion!")
'            End If
'            valorError = False
'    End Sub

'    Private Sub cargaHorario()
'        cboHorario.Items.Add("07:00")
'        cboHorario.Items.Add("07:15")
'        cboHorario.Items.Add("07:30")
'        cboHorario.Items.Add("07:45")
'        cboHorario.Items.Add("08:00")
'        cboHorario.Items.Add("08:15")
'        cboHorario.Items.Add("08:30")
'        cboHorario.Items.Add("08:45")
'        cboHorario.Items.Add("09:00")
'        cboHorario.Items.Add("09:15")
'        cboHorario.Items.Add("09:30")
'        cboHorario.Items.Add("09:45")
'        cboHorario.Items.Add("10:00")
'        cboHorario.Items.Add("10:15")
'        cboHorario.Items.Add("10:30")
'        cboHorario.Items.Add("10:45")
'        cboHorario.Items.Add("11:00")
'        cboHorario.Items.Add("11:15")
'        cboHorario.Items.Add("11:30")
'        cboHorario.Items.Add("11:45")
'        cboHorario.Items.Add("12:00")
'        cboHorario.Items.Add("12:15")
'        cboHorario.Items.Add("12:30")
'        cboHorario.Items.Add("12:45")
'        cboHorario.Items.Add("13:00")
'        cboHorario.Items.Add("13:15")
'        cboHorario.Items.Add("13:30")
'        cboHorario.Items.Add("13:45")
'        cboHorario.Items.Add("14:00")
'        cboHorario.Items.Add("14:15")
'        cboHorario.Items.Add("14:30")
'        cboHorario.Items.Add("14:45")
'        cboHorario.Items.Add("15:00")
'        cboHorario.Items.Add("15:15")
'        cboHorario.Items.Add("15:30")
'        cboHorario.Items.Add("15:45")
'        cboHorario.Items.Add("16:00")
'        cboHorario.Items.Add("16:15")
'        cboHorario.Items.Add("16:30")
'        cboHorario.Items.Add("16:45")
'        cboHorario.Items.Add("17:00")

'        consulta = "select * from ObraSocial"
'        Call EjecutarObraS(consulta)

'        While rsOs.Read = True
'            cboObrasSociales.Items.Add(rsOs(1))
'        End While

'        consultaEstudio = "select * from estudio"
'        Call EjecutarEstudios(consultaEstudio)

'        While rsEstudios.Read = True
'            cboEstudios.Items.Add(rsEstudios(1))
'        End While

'        consultaMedico = "select * from medico "
'        Call EjecutarMedico(consultaMedico)
'        While rsMedico.Read = True
'            cboMedico.Items.Add(rsMedico(1))
'        End While

'    End Sub

'    Private Sub EjecutarObraEstudio(ByVal consultaObraEstudio As String)
'        cmd = New OdbcCommand(consultaObraEstudio, cmn)
'        cmd.CommandType = CommandType.Text
'        rsOE = cmd.ExecuteReader()
'        cmd.Dispose()
'    End Sub

'    Private Sub EjecutarHorarios(ByVal consultaAgendaTurno As String)
'        cmd = New OdbcCommand(consultaAgendaTurno, cmn)
'        cmd.CommandType = CommandType.Text
'        rsHorarios = cmd.ExecuteReader()
'        cmd.Dispose()
'    End Sub
'    Private Sub EjecutarEstudios(ByVal consultaEstudio As String)
'        cmd = New OdbcCommand(consultaEstudio, cmn)
'        cmd.CommandType = CommandType.Text
'        rsEstudios = cmd.ExecuteReader()
'        cmd.Dispose()
'    End Sub
'    Private Sub EjecutarObraS(ByVal consulta As String)
'        cmd = New OdbcCommand(consulta, cmn)
'        cmd.CommandType = CommandType.Text
'        rsOs = cmd.ExecuteReader()
'        cmd.Dispose()
'    End Sub

'    Private Sub EjecutarMedico(ByVal consultaMedico As String)
'        cmd = New OdbcCommand(consultaMedico, cmn)
'        cmd.CommandType = CommandType.Text
'        rsMedico = cmd.ExecuteReader()
'        cmd.Dispose()
'    End Sub

'    Private Sub EjecutarTurno(ByVal guardarTurno As Object)
'        cmd = New OdbcCommand(guardarTurno, cmn)
'        cmd.CommandType = CommandType.Text
'        rsGuardarTurno = cmd.ExecuteReader()
'        cmd.Dispose()
'    End Sub
'    Private Sub EjecutarInsumo(ByVal guardarInsumo As Object)
'        cmd = New OdbcCommand(guardarInsumo, cmn)
'        cmd.CommandType = CommandType.Text
'        rsGuardarInsumo = cmd.ExecuteReader()
'        cmd.Dispose()
'    End Sub
'    Private Sub EjecutarStock(ByVal stock As Object)
'        cmd = New OdbcCommand(stock, cmn)
'        cmd.CommandType = CommandType.Text
'        rsStock = cmd.ExecuteReader()
'        cmd.Dispose()
'    End Sub


'    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

'        If MsgBox("¿Esta seguro que desea cancelar el turno? ", MsgBoxStyle.YesNo, "Atencion!") = MsgBoxResult.Yes Then

'            Me.Hide()
'            Estudios.Show()
'            Estudios.txtDocBusqueda.Text = ""
'            Estudios.gbBotones.Visible = False
'            cargaHorario()

'        End If
'    End Sub

'    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
'        'Imprimir el comprobante 
'        If MsgBox("¿Desea realizar otra operacion? ", MsgBoxStyle.YesNo, "Atencion!") = MsgBoxResult.Yes Then
'            gbCTurno.Visible = False
'            gbTurno.Visible = True
'            Me.Hide()
'            Estudios.Show()
'        Else
'            Estudios.txtDocBusqueda.Text = ""
'            Estudios.gbBotones.Visible = False
'            gbCTurno.Visible = False
'            gbTurno.Visible = True
'            Me.Hide()
'            Estudios.Show()
'        End If
'    End Sub


'End Class
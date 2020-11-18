'Option Explicit On
'Imports System.Data.Odbc

'Public Class Estudios
'    Dim rsBusqueda As Odbc.OdbcDataReader
'    Dim busquedanoExiste As Integer
'    Dim consultaBusqueda As String
'    Dim documento As Integer

'    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click

'        If btnVolver.Text = "Salir" Then
'            If MsgBox("¿Desea salir del programa? ", MsgBoxStyle.YesNo, "Atencion!") = MsgBoxResult.Yes Then

'                End

'            End If

'        ElseIf btnVolver.Text = "Volver" Then

'            Me.Hide()
'            Administracion.Show()
'            Inicio.cboUsuario.Text = "Usuarios..."
'            Inicio.txtContraseña.Text = ""

'        End If

'    End Sub

'    Private Sub btnBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusqueda.Click
'        If txtDocBusqueda.Text = "" Then
'            MsgBox("Por favor debe ingresar el numero de documento del paciente ", MsgBoxStyle.Critical, "Error...")

'        Else
'            consultaBusqueda = "select * from Paciente "
'            Call ejecutarBusqueda(consultaBusqueda)
'            busquedanoExiste = 0


'            While rsBusqueda.Read = True

'                If txtDocBusqueda.Text = rsBusqueda(2) Then
'                    MsgBox("El paciente ya existe. ¿ Que desea realizar? ", MsgBoxStyle.Exclamation, "Mensaje")
'                    gbBotones.Visible = True
'                    busquedanoExiste = 0
'                    Exit While
'                Else
'                    busquedanoExiste = 1
'                End If

'            End While

'            If busquedanoExiste <> 0 Then

'                MsgBox("El paciente no existe. Por favor registrelo! ", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Error...")
'                Me.Hide()
'                IngresoPaciente.txtNumDoc.Text = txtDocBusqueda.Text
'                IngresoPaciente.nroDocumento = txtDocBusqueda.Text
'                IngresoPaciente.Show()

'            End If
'        End If
'    End Sub

'    Private Sub txtDocBusqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDocBusqueda.KeyPress
'        If Char.IsDigit(e.KeyChar) Then
'            e.Handled = False
'        ElseIf Char.IsControl(e.KeyChar) Then
'            e.Handled = False
'        Else
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub ejecutarBusqueda(ByVal consultaBusqueda As String)
'        cmd = New OdbcCommand(consultaBusqueda, cmn)
'        cmd.CommandType = CommandType.Text
'        rsBusqueda = cmd.ExecuteReader()
'        cmd.Dispose()
'    End Sub


'    Private Sub Estudios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        txtDocBusqueda.Text = ""
'        AbrirConexion()
'    End Sub

'    Private Sub btnTurno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTurno.Click
'        AgendaTurnos.lblNombreP.Text = rsBusqueda(3) + ", " + rsBusqueda(4)
'        AgendaTurnos.idPaciente = rsBusqueda(0)
'        Me.Hide()
'        AgendaTurnos.Show()
'    End Sub

'    Private Sub btnRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistro.Click
'        AlmacenEstudio.idPaciente = rsBusqueda(0)
'        Me.Hide()
'        AlmacenEstudio.Show()

'    End Sub

'    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
'        Me.Hide()
'        EstudiosFacturacion.lblNombrePaciente.Text = rsBusqueda(4) + " ," + rsBusqueda(3)
'        EstudiosFacturacion.lblCelular.Text = rsBusqueda(10)
'        EstudiosFacturacion.lblDireccion.Text = rsBusqueda(8)
'        EstudiosFacturacion.lblLocalidad.Text = rsBusqueda(7)
'        EstudiosFacturacion.lblObraSocial.Text = rsBusqueda(14)
'        EstudiosFacturacion.idPaciente = rsBusqueda(0)
'        EstudiosFacturacion.gbFormaPago.Visible = True
'        EstudiosFacturacion.gbFacturacion.Visible = False
'        EstudiosFacturacion.Show()
'    End Sub
'End Class
'Imports System.Data.Odbc

'Public Class AlmacenEstudio

'    Dim rsBuscarEstudio As OdbcDataReader
'    Dim rsInsert As OdbcDataReader

'    Dim consultaBusqueda As String
'    Dim consultaEstudio As String
'    Dim consultaIngresar As String

'    Dim busquedanoExiste As Integer
'    Public idPaciente As Integer
'    Dim idEstudio As Integer
'    Dim fechaIngreso As Object
'    Dim selecciono As Integer
'    Dim sacarIngreso As String
'    Dim rsFecha As OdbcDataReader

'    Private Sub AlmacenEstudio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        AbrirConexion()
'    End Sub

'    Private Sub btnTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminar.Click
'        If selecciono = 1 Then
'            consultaEstudio = "select * from agendaturno where idPaciente = '" & idPaciente & "' "
'            Call EjecutarBuscarEstudio(consultaEstudio)

'            If rsBuscarEstudio.Read = True Then
'                idEstudio = rsBuscarEstudio(6)
'            End If

'            consultaIngresar = "insert into almacenestudios values ('', '" & fechaIngreso & "' , '" & idEstudio & "' , '" & idPaciente & "', 0)"
'            Call EjecutarIngreso(consultaIngresar)
'            MsgBox("El estudio fue registrado con exito", MsgBoxStyle.Information, "Registro")
'            btnVolver.Visible = True
'        Else
'            consultaIngresar = " update almacenestudios set Estado = 1 where idPaciente = '" & idPaciente & "' "
'            Call EjecutarIngreso(consultaIngresar)
'            MsgBox("El retiro del estudio fue registrado con exito", MsgBoxStyle.Information, "Registro")
'            btnVolver.Visible = True
'        End If
'    End Sub

'    Private Sub rbIngresar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbIngresar.Click
'        lblFechaIngreso.Visible = False
'        btnTerminar.Text = "Ingresar Estudio"
'        btnTerminar.Visible = True
'        fechaIngreso = Date.Now.ToString("yyyy/MM/dd")

'        selecciono = 1
'    End Sub
'    Private Sub EjecutarFecha(ByVal sacarIngreso As String)
'        cmd = New OdbcCommand(sacarIngreso, cmn)
'        cmd.CommandType = CommandType.Text
'        rsFecha = cmd.ExecuteReader()
'        cmd.Dispose()
'    End Sub

'    Private Sub rbRetirar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbRetirar.Click
'        btnTerminar.Text = "Retirar Estudio"
'        btnTerminar.Visible = True
'        lblFecha.Visible = True
'        lblFechaIngreso.Visible = True
'        sacarIngreso = "select FechaIngreso from almacenestudios where idPaciente= '" & idPaciente & "' "
'        Call EjecutarFecha(sacarIngreso)
'        If rsFecha.Read = True Then
'            lblFecha.Text = rsFecha(0)
'        End If
'        selecciono = 2
'    End Sub

'    Private Sub EjecutarBuscarEstudio(ByVal consultaEstudio As String)
'        cmd = New OdbcCommand(consultaEstudio, cmn)
'        cmd.CommandType = CommandType.Text
'        rsBuscarEstudio = cmd.ExecuteReader()
'        cmd.Dispose()
'    End Sub

'    Private Sub EjecutarIngreso(ByVal consultaIngresar As String)
'        cmd = New OdbcCommand(consultaIngresar, cmn)
'        cmd.CommandType = CommandType.Text
'        rsInsert = cmd.ExecuteReader()
'        cmd.Dispose()
'    End Sub

'    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click

'        Me.Hide()
'        Estudios.Show()
'        btnVolver.Visible = False
'        rbIngresar.Checked = False
'        rbRetirar.Checked = False

'    End Sub
'End Class
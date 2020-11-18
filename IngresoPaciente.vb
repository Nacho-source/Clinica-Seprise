'Option Explicit On
'Imports System.Data.Odbc

'Public Class IngresoPaciente

'    Public nroDocumento As Integer
'    Public nombre As String
'    Public apellido As String
'    Dim tipoSangre As String
'    Dim fecha As Object
'    Dim email As String
'    Dim tel As Integer
'    Dim cel As Integer
'    Dim obraS As String
'    Dim Direccion As String
'    Dim sqlBusqueda As String
'    Dim tipoDocu As String
'    Dim nacionalidad As String
'    Dim cp As String
'    Dim localidad As String
'    Dim sql As String
'    Dim rsInsertar As OdbcDataReader
'    Dim rsBusqueda As OdbcDataReader
'    Dim consultaOS As String
'    Dim rsOs As OdbcDataReader
'    Dim sinOS As String

'    Private Sub EjecutarConsulta(ByVal sql As String)
'        cmd = New OdbcCommand(sql, cmn)
'        cmd.CommandType = CommandType.Text
'        rsInsertar = cmd.ExecuteReader()
'        cmd.Dispose()
'    End Sub

'    Private Sub EjecutarBusqueda(ByVal sql As String)
'        cmd = New OdbcCommand(sql, cmn)
'        cmd.CommandType = CommandType.Text
'        rsBusqueda = cmd.ExecuteReader()
'        cmd.Dispose()
'    End Sub

'    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
'        Me.Hide()
'        Estudios.Show()
'    End Sub

'    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
'        If MsgBox("Esta seguro de guardar los datos?", MsgBoxStyle.YesNo, "Atencion!") = MsgBoxResult.Yes Then
'            fecha = Format(CDate(txtFecha.Text), "yyyy/MM/dd")
'            nroDocumento = txtNumDoc.Text
'            nombre = txtNombre.Text
'            apellido = txtApellido.Text
'            tipoSangre = cboGS.Text
'            email = txtEmail.Text
'            tel = txtTelefono.Text
'            cel = txtCelular.Text
'            Direccion = txtDireccion.Text
'            tipoDocu = cboTipoDoc.Text
'            nacionalidad = txtNacionalidad.Text
'            localidad = txtLocalidad.Text
'            cp = txtCP.Text

'            If sinOS = "-" Then
'                sql = "insert into paciente values ('', '" & tipoDocu & "' , '" & nroDocumento & "' , '" & nombre & "', '" & apellido & "' , '" & fecha & "','" & nacionalidad & "', '" & _
'              localidad & "','" & Direccion & "','" & cp & "','" & cel & "' ,'" & tel & "' ,'" & email & "' ,  '" & tipoSangre & "' ,'" & sinOS & "' , 0, 0  )"
'                AgendaTurnos.rbtNo.Checked = True
'            Else
'                obraS = cboObrasSociales.Text.ToString
'                sql = "insert into paciente values ( '', '" & tipoDocu & "' , '" & nroDocumento & "' , '" & nombre & "', '" & apellido & "' , '" & fecha & "','" & nacionalidad & "', '" & _
'              localidad & "','" & Direccion & "','" & cp & "','" & cel & "' ,'" & tel & "' ,'" & email & "' ,  '" & tipoSangre & "' ,'" & obraS & "' , 0, 0  )"
'                AgendaTurnos.rbtNo.Checked = True
'                AgendaTurnos.cboObrasSociales.Text = obraS
'            End If

'            Call EjecutarConsulta(sql)
'            MsgBox("El paciente fue guardado con exito. Por favor ahora seleccione un turno", MsgBoxStyle.Information, "Mensaje")
'            Me.Hide()
'            AgendaTurnos.lblNombreP.Text = apellido + ", " + nombre
'            AgendaTurnos.Show()
'        End If
'    End Sub

'    Private Sub cargarCombos()
'        cboTipoDoc.Items.Add("DNI")
'        cboTipoDoc.Items.Add("Pasaporte")
'        cboTipoDoc.Items.Add("Libreta Civica")
'        cboTipoDoc.Items.Add("Libreta Enrolamiento")
'        cboTipoDoc.Items.Add("Carnet de Extranjero")
'        cboGS.Items.Add("A+")
'        cboGS.Items.Add("A-")
'        cboGS.Items.Add("B+")
'        cboGS.Items.Add("B-")
'        cboGS.Items.Add("AB+")
'        cboGS.Items.Add("AB-")
'        cboGS.Items.Add("0+")
'        cboGS.Items.Add("0-")

'        consultaOS = "select * from ObraSocial"
'        Call EjecutarObraS(consultaOS)

'        While rsOs.Read = True
'            cboObrasSociales.Items.Add(rsOs(1))
'        End While

'    End Sub


'    Private Sub IngresoPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        AbrirConexion()
'        cboObrasSociales.Text = "Obra Social..."
'        cboTipoDoc.Text = "Seleccionar..."
'        cboGS.Text = "Grupo de Sangre"
'        cargarCombos()
'    End Sub

'    Private Sub rbtSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSi.CheckedChanged
'        lblOS.Visible = True
'        cboObrasSociales.Visible = True

'    End Sub

'    Private Sub EjecutarObraS(ByVal consultaOS As String)
'        cmd = New OdbcCommand(consultaOS, cmn)
'        cmd.CommandType = CommandType.Text
'        rsOs = cmd.ExecuteReader()
'        cmd.Dispose()
'    End Sub

'    Private Sub rbtNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNo.CheckedChanged
'        sinOS = "-"
'        lblOS.Visible = False
'        cboObrasSociales.Visible = False
'    End Sub

'    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
'        If Char.IsLetter(e.KeyChar) Then
'            e.Handled = False
'        ElseIf Char.IsControl(e.KeyChar) Then
'            e.Handled = False
'        ElseIf Char.IsSeparator(e.KeyChar) Then

'        Else
'            e.Handled = True
'        End If

'    End Sub

'    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
'        If Char.IsLetter(e.KeyChar) Then
'            e.Handled = False
'        ElseIf Char.IsControl(e.KeyChar) Then
'            e.Handled = False
'        ElseIf Char.IsSeparator(e.KeyChar) Then

'        Else
'            e.Handled = True
'        End If

'    End Sub

'    Private Sub txtNacionalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNacionalidad.KeyPress
'        If Char.IsLetter(e.KeyChar) Then
'            e.Handled = False
'        ElseIf Char.IsControl(e.KeyChar) Then
'            e.Handled = False
'        ElseIf Char.IsSeparator(e.KeyChar) Then
'            e.Handled = False
'        Else
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub txtNumDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumDoc.KeyPress
'        If Char.IsDigit(e.KeyChar) Then
'            e.Handled = False
'        ElseIf Char.IsControl(e.KeyChar) Then
'            e.Handled = False
'        Else
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
'        If Char.IsDigit(e.KeyChar) Then
'            e.Handled = False
'        ElseIf Char.IsControl(e.KeyChar) Then
'            e.Handled = False
'        Else
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub txtCelular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCelular.KeyPress
'        If Char.IsDigit(e.KeyChar) Then
'            e.Handled = False
'        ElseIf Char.IsControl(e.KeyChar) Then
'            e.Handled = False
'        Else
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub txtCP__KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCP.KeyPress
'        If Char.IsDigit(e.KeyChar) Then
'            e.Handled = False
'        ElseIf Char.IsControl(e.KeyChar) Then
'            e.Handled = False
'        Else
'            e.Handled = True
'        End If
'    End Sub


'    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAño.Click

'    End Sub
'End Class
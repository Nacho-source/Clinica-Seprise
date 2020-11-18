'Imports System.Data.Odbc

'Public Class FormularioMedicamentos
'    Dim rs As OdbcDataReader
'    Dim eoff As Boolean
'    Dim opc As String
'    Public CodigoMed As Integer
'    Public CodigoProv As Integer
'    Private Sub FormularioMedicamentos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
'        eoff = False
'        sql = "select nombre from Proveedor Where Activo=True"
'        rs = Consulta()
'        Do While eoff = False
'            If rs.Read = False Then
'                eoff = True
'            Else
'                cboProveedores.Items.Add(rs.Item(0))

'            End If
'        Loop
'    End Sub
'    Private Sub txtPrecioVenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioVenta.KeyPress
'        If Char.IsDigit(e.KeyChar) Then
'            e.Handled = False
'        ElseIf Char.IsControl(e.KeyChar) Then
'            e.Handled = True
'        Else
'            e.Handled = True
'        End If
'    End Sub
'    Private Sub txtPP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPP.KeyPress
'        If Char.IsDigit(e.KeyChar) Then
'            e.Handled = False
'        ElseIf Char.IsControl(e.KeyChar) Then
'            e.Handled = True
'        Else
'            e.Handled = True
'        End If
'    End Sub
'    Private Sub txtStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
'        If Char.IsDigit(e.KeyChar) Then
'            e.Handled = False
'        ElseIf Char.IsControl(e.KeyChar) Then
'            e.Handled = True
'        Else
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
'        If txtNombre.Text = "" Or txtPP.Text = "" Or txtPrecioVenta.Text = "" Or txtPresentacion.Text = "" Or txtStock.Text = "" Or cboProveedores.Text = "" Then
'            MsgBox("Error, Por favor rellenar todos los campos.", vbExclamation)
'        Else
'            opc = MsgBox("¿Esta seguro que desea registrar este medicamento con estos datos?", vbYesNo)
'            If opc = 6 Then
'                CodigoMed = GrillaFarmacia.Codigo
'                CodigoProv = GrillaFarmacia.CodigoProv
'                If CodigoMed <> 0 Then

'                    sql = "Update Medicamento set nombre='" & txtNombre.Text & "', presen='" & txtPresentacion.Text & "', Stock=" & txtStock.Text & ", PP=" & txtPP.Text & ", IdProv=" & CodigoProv & " Where idMedicamento=" & CodigoMed
'                    Consulta()
'                    MsgBox("Se ha modificado el medicamento satisfactoriamente")
'                Else
'                    sql = "Select IdProv from Proveedor Where nombre='" & cboProveedores.Text & "'"
'                    rs = Consulta()
'                    rs.Read()
'                    CodigoProv = rs.Item(0)

'                    sql = "Select Max(IdMedicamento)+1 from Medicamento"
'                    rs = Consulta()
'                    rs.Read()
'                    sql = "Insert Into Medicamento Values ( '' ," & CodigoProv & "," & txtStock.Text & "," & txtPP.Text & ",'" & txtNombre.Text & "','" & txtPresentacion.Text & "'," & txtPrecioVenta.Text & ", 1)"
'                    Consulta()
'                    MsgBox("Se ha agregado el medicamento satisfactoriamente")
'                End If
'                LimpiarFormulario()
'                Me.Hide()
'                GrillaFarmacia.Show()
'            End If
'        End If
'    End Sub


'    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
'        opc = MsgBox("¿Esta seguro que desea volver?, se perderan todos los datos?", vbYesNo)
'        If opc = 6 Then
'            LimpiarFormulario()
'            Me.Hide()
'            GrillaFarmacia.Show()
'        End If
'    End Sub
'    Private Sub LimpiarFormulario()
'        CodigoMed = 0
'        txtNombre.Text = ""
'        txtPP.Text = ""
'        txtPrecioVenta.Text = ""
'        txtPresentacion.Text = ""
'        txtStock.Text = ""
'        cboProveedores.Items.Clear()
'    End Sub

'End Class
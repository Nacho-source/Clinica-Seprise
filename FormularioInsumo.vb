'Imports System.Data.Odbc

'Public Class FormularioInsumo
'    Dim rs As OdbcDataReader
'    Dim eoff As Boolean
'    Dim opc As String
'    Public CodigoIns As Integer
'    Public CodigoProv As Integer
'    Private Sub FormularioInsumo_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
'        eoff = False
'        sql = "select nombre from Proveedor Where Activo=True"
'        Me.rs = Consulta()
'        Do While eoff = False
'            If rs.Read = False Then
'                eoff = True
'            Else
'                cboProveedores.Items.Add(rs.Item(0))
'            End If
'        Loop
'    End Sub

'    Private Sub txtPrecioproveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioproveedor.KeyPress
'        If Char.IsDigit(e.KeyChar) Then
'            e.Handled = False
'        ElseIf Char.IsControl(e.KeyChar) Then
'            e.Handled = True
'        Else
'            e.Handled = True
'        End If
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

'    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
'        opc = MsgBox("¿Esta seguro que desea volver?, se perderan todos los datos", vbYesNo)
'        If opc = 6 Then
'            LimpiarFormulario()
'            Me.Hide()
'            GrillaFarmacia.Show()
'        End If
'    End Sub

'    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
'        If txtNombre.Text = "" Or txtPP.Text = "" Or txtPrecioVenta.Text = "" Or txtStock.Text = "" Or cboProveedores.Text = "" Or txtPrecioproveedor.Text = "" Then
'            MsgBox("Error, Por favor rellenar todos los campos.", vbExclamation)
'        Else
'            opc = MsgBox("¿Esta seguro que desea registrar este medicamento con estos datos?", vbYesNo)
'            If opc = 6 Then
'                CodigoIns = GrillaFarmacia.Codigo
'                CodigoProv = GrillaFarmacia.CodigoProv
'                If CodigoIns <> 0 Then
'                    sql = "Update Insumo set nombre='" & txtNombre.Text & "', Stock=" & txtStock.Text & ", PP=" & txtPP.Text & " Where idInsumo=" & CodigoIns
'                    Consulta()
'                    sql = "Update Insumo_Proveedor set IdProv=" & CodigoProv & ", IdInsumo=" & CodigoIns & ", Precio=" & txtPrecioproveedor.Text & " Where idInsumo=" & CodigoIns & " and IdProv=" & CodigoProv
'                    Consulta()
'                    MsgBox("Se ha modificado el Insumo satisfactoriamente")
'                Else
'                    sql = "Select IdProv from Proveedor Where nombre='" & cboProveedores.Text & "'"
'                    rs = Consulta()
'                    rs.Read()
'                    CodigoProv = rs.Item(0)

'                    sql = "Select Max(IdInsumo)+1 from Insumo"
'                    Me.rs = Consulta()
'                    Me.rs.Read()
'                    sql = "Insert Into Insumo Values (" & Me.rs.Item(0) & ",'" & txtNombre.Text & "'," & txtStock.Text & "," & txtPP.Text & "," & txtPrecioVenta.Text & ",1)"
'                    Consulta()

'                    sql = "Insert Into Insumo_Proveedor Values (" & CodigoProv & "," & Me.rs.Item(0) & "," & txtPrecioproveedor.Text & ")"
'                    Consulta()
'                    MsgBox("Se ha agregado el Insumo satisfactoriamente")
'                End If
'                LimpiarFormulario()
'                Me.Hide()
'                GrillaFarmacia.Show()
'            End If
'        End If
'    End Sub
'    Private Sub LimpiarFormulario()
'        CodigoIns = 0
'        txtNombre.Text = ""
'        txtPP.Text = ""
'        txtPrecioVenta.Text = ""
'        txtPrecioproveedor.Text = ""
'        txtStock.Text = ""
'        cboProveedores.Items.Clear()
'    End Sub

'    Private Sub FormularioInsumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    End Sub
'End Class
Imports System.Data.Odbc

Public Class FormularioProveedor
    Dim rs As OdbcDataReader
    Dim opc As String
    Public CodigoProv As Integer
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        opc = MsgBox("¿Esta seguro que desea volver?, se perderan todos los datos", vbYesNo)
        If opc = 6 Then
            LimpiarFormulario()
            Me.Hide()
            GrillaFarmacia.Show()
        End If
    End Sub
    Private Sub LimpiarFormulario()
        CodigoProv = 0
        txtNombre.Text = ""
        txtDomicilio.Text = ""
        txtTel.Text = ""
    End Sub

    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        If txtNombre.Text = "" Or txtDomicilio.Text = "" Or txtTel.Text = "" Then
            MsgBox("Error, Por favor rellenar todos los campos.", vbExclamation)
        Else
            opc = MsgBox("¿Esta seguro que desea registrar este proveedor con estos datos?", vbYesNo)
            If opc = 6 Then
                'CodigoProv = GrillaFarmacia.CodigoProv
                If CodigoProv <> 0 Then
                    sql = "Update Proveedor set nombre='" & txtNombre.Text & "', Domi='" & txtDomicilio.Text & "', Tel=" & txtTel.Text & " Where idProv=" & CodigoProv
                    Consulta()

                    MsgBox("Se ha modificado el proveedor satisfactoriamente")
                Else
                    sql = "Insert Into Proveedor Values ('','" & txtNombre.Text & "','" & txtDomicilio.Text & "'," & txtTel.Text & ",1)"
                    Consulta()

                    MsgBox("Se ha agregado el proveedor satisfactoriamente")
                End If
                LimpiarFormulario()
                Me.Hide()
                GrillaFarmacia.Show()
            End If
        End If
    End Sub
End Class
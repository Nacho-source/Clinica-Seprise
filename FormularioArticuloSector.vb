Public Class FormularioArticuloSector
    Dim opc As Integer
    Public idArticulo As Integer
    Public idSector As Integer
    Private Sub txtStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtPPP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPPP.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtPP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPP.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        txtPP.Text = ""
        txtPPP.Text = ""
        txtStock.Text = ""
        opc = MsgBox("¿Esta seguro que desea volver, se perderan los datos? ", vbYesNo)
        If opc = 6 Then
            Me.Hide()
            GrillaFarmacia.Show()
        End If
    End Sub

    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        If txtStock.Text = "" Or txtPP.Text = "" Or txtPPP.Text = "" Then
            MsgBox("Error, Por favor rellenar todos los campos.", vbExclamation)
        ElseIf int(txtStock.Text) < int(txtPP.Text) Then
            MsgBox("Error, No se puede ingresar un punto de pedido menor al stock.", vbExclamation)
        Else

            opc = MsgBox("¿Esta seguro que desea registrar este articulo en el sector elegido con estos datos?", vbYesNo)
            If opc = 6 Then

                If btnAccion.Text = "Agregar medicamento" Then
                    sql = "Insert Into Medicamento_sector Values (" & idArticulo & "," & idSector & "," & txtStock.Text & "," & txtPP.Text & "," & txtPPP.Text & ")"
                    Consulta()
                Else
                    sql = "Insert Into insumo_sector Values ( " & idArticulo & "," & idSector & "," & txtStock.Text & "," & txtPP.Text & "," & txtPPP.Text & ")"
                    Consulta()

                End If
                MsgBox("Se ha agregado el articulo al sector indicado satisfactoriamente")
                txtPP.Text = ""
                txtPPP.Text = ""
                txtStock.Text = ""
                Me.Hide()
                GrillaFarmacia.Show()
            End If
        End If
    End Sub
End Class
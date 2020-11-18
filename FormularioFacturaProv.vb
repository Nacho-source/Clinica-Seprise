Imports System.Data.Odbc

Public Class FormularioFacturaProv
    Dim opc As Integer
    Dim rs As OdbcDataReader
    Dim eoff As Boolean
    Private Sub FormularioRemitoProveedor_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        sql = "select max(IdRem) from Remito"
        rs = Consulta()
        rs.Read()

        lblNRemito.Text = rs.Item(0)
        sql = "select nombre from proveedor where idProv= " & FormularioRemitoProveedor.CodigoProv
        rs = Consulta()
        rs.Read()
        lblNProveedor.Text = rs.Item(0)
    End Sub
    Private Sub txtCodFact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodFact.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtMontoFactProv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoFactProv.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        If txtCodFact.Text = "" Or txtMontoFactProv.Text = "" Then
            MsgBox("Error, Por favor rellenar los campos.", vbExclamation)
        Else

            opc = MsgBox("¿Esta seguro que desea registrar este remito con estos datos?", vbYesNo)
                If opc = 6 Then



                    Dim CodigoProv As Integer
                sql = "Select IdProv from Proveedor Where nombre='" & lblNProveedor.Text & "'"
                rs = Consulta()
                    rs.Read()
                    CodigoProv = rs.Item(0)

                    opc = MsgBox("¿Desea registrar la fecha de pago el dia de hoy?", vbYesNo)
                    If opc = 6 Then
                        sql = "Insert Into FactProv Values ( '', " & txtCodFact.Text & ", " & CodigoProv & ", " & lblNRemito.Text & " ," & txtMontoFactProv.Text & ", (select curdate()))"
                        Consulta()
                    Else
                        sql = "Insert Into FactProv Values ( '', " & txtCodFact.Text & ", " & CodigoProv & ", " & lblNRemito.Text & " ," & txtMontoFactProv.Text & ", '')"
                        Consulta()
                    End If

                    MsgBox("Se ha registrado la factura satisfactoriamente")
                    txtCodFact.Text = ""
                    txtMontoFactProv.Text = ""
                    Me.Hide()
                MsgBox("Ahora se debe registrar los articulos entregados en la orden de compra registrada")
                sql = "select DOC.IdOrdComp, DOC.IdDetOCI , I.IdInsumo, I.Nombre 'Insumo' , DOC.Cantidad 'Cantidad Pedida', DOC.Resto 'Cantidad Faltante' from Insumo I, Ord_Comp OC, DetOrdComp_Ins DOC Where DOC.IdOrdComp=OC.IdOrdComp and I.IdInsumo=DOC.IdInsumo and DOC.Resto>0 and DOC.IdOrdComp=" & RegistrarArtOrdCompra.idOrdComp
                RegistrarArtOrdCompra.dgvGrillaDetOrdCompI.DataSource = ConsultaDG("DetPedidoI")
                RegistrarArtOrdCompra.dgvGrillaDetOrdCompI.Columns(0).Visible = False
                RegistrarArtOrdCompra.dgvGrillaDetOrdCompI.Columns(1).Visible = False
                RegistrarArtOrdCompra.dgvGrillaDetOrdCompI.Columns(2).Visible = False
                sql = "select DOC.IdOrdComp, DOC.IdDetOCM , M.IdMedicamento, M.Nombre 'Medicamento' ,M.Presen, DOC.Cantidad 'Cantidad Pedida', DOC.Resto 'Cantidad Faltante' from Medicamento M, Ord_Comp OC, DetOrdComp_Med DOC Where DOC.IdOrdComp=OC.IdOrdComp and M.IdMedicamento=DOC.IdMedicamento and DOC.Resto>0 and DOC.IdOrdComp=" & RegistrarArtOrdCompra.idOrdComp
                RegistrarArtOrdCompra.dgvGrillaDetOrdCompM.DataSource = ConsultaDG("DetPedidoM")
                RegistrarArtOrdCompra.dgvGrillaDetOrdCompM.Columns(0).Visible = False
                RegistrarArtOrdCompra.dgvGrillaDetOrdCompM.Columns(1).Visible = False
                RegistrarArtOrdCompra.dgvGrillaDetOrdCompM.Columns(2).Visible = False
                RegistrarArtOrdCompra.Show()
                End If


        End If
    End Sub


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        opc = MsgBox("¿Esta seguro que desea volver?, se perderan todos los datos?", vbYesNo)
        If opc = 6 Then
            txtMontoFactProv.Text = ""
            txtCodFact.Text = ""

            sql = "delete from Remito Where IdRem =" & lblNRemito.Text
            Consulta()
            Me.Hide()
            FormularioRemitoProveedor.Show()
        End If
    End Sub

End Class
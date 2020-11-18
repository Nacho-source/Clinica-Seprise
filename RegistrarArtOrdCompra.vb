Imports System.Data.Odbc

Public Class RegistrarArtOrdCompra
    Dim i As Integer
    Dim opc As Integer
    Dim IdDetOrdComp As Integer
    Dim rs As OdbcDataReader
    Dim Articulo As String
    Dim eoff As Boolean
    Public idOrdComp As Integer

    Private Sub FormularioPaquete_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        i = 0
        btnRegArt.Visible = False
        lblCantIng.Visible = False
        lblCantFal.Visible = False
        lblCantPedida.Visible = False
        txtCantIng.Visible = False
        btnRegI.Visible = True
        btnRegM.Visible = True
        dgvGrillaDetOrdCompI.Enabled = True
        dgvGrillaDetOrdCompM.Enabled = True
        btnRegM.Text = "Registrar Medicamento"
        btnRegI.Text = "Registrar Insumo"
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs)

        opc = MsgBox("¿Esta seguro que desea volver?, se perderan todos los datos", vbYesNo)
        If opc = 6 Then
            Me.Hide()
            GrillaFarmacia.Show()
        End If
    End Sub

    Private Sub btnRegM_Click(sender As Object, e As EventArgs) Handles btnRegM.Click
        If btnRegM.Text <> "Cancelar" Then
            If IsNothing(dgvGrillaDetOrdCompM.CurrentRow) Then
                IdDetOrdComp = dgvGrillaDetOrdCompM.Rows(0).Cells.Item(1).Value
                lblCantF.Text = dgvGrillaDetOrdCompM.Rows(0).Cells.Item(6).Value.ToString
                lblCantP.Text = dgvGrillaDetOrdCompM.Rows(0).Cells.Item(5).Value.ToString
            Else
                IdDetOrdComp = dgvGrillaDetOrdCompM.CurrentRow.Cells.Item(1).Value
                lblCantF.Text = dgvGrillaDetOrdCompM.CurrentRow.Cells.Item(6).Value.ToString
                lblCantP.Text = dgvGrillaDetOrdCompM.CurrentRow.Cells.Item(5).Value.ToString
            End If
            dgvGrillaDetOrdCompI.Enabled = False
            dgvGrillaDetOrdCompM.Enabled = False
            btnRegM.Text = "Cancelar"
            lblCantIng.Visible = True
            lblCantFal.Visible = True
            lblCantPedida.Visible = True
            txtCantIng.Visible = True
            btnRegI.Visible = False
            btnRegArt.Visible = True
            Articulo = "M"
        Else
            dgvGrillaDetOrdCompI.Enabled = True
            dgvGrillaDetOrdCompM.Enabled = True
            btnRegM.Text = "Registrar Medicamento"

            lblCantF.Text = ""
            lblCantP.Text = ""
            btnRegI.Visible = True

            lblCantIng.Visible = False
            lblCantFal.Visible = False
            lblCantPedida.Visible = False
            txtCantIng.Visible = False
            btnRegArt.Visible = False
        End If
    End Sub

    Private Sub btnRegI_Click(sender As Object, e As EventArgs) Handles btnRegI.Click
        If btnRegI.Text <> "Cancelar" Then
            If IsNothing(dgvGrillaDetOrdCompI.CurrentRow) Then
                IdDetOrdComp = dgvGrillaDetOrdCompI.Rows(0).Cells.Item(1).Value
                lblCantF.Text = dgvGrillaDetOrdCompI.Rows(0).Cells.Item(5).Value.ToString
                lblCantP.Text = dgvGrillaDetOrdCompI.Rows(0).Cells.Item(4).Value.ToString
            Else
                IdDetOrdComp = dgvGrillaDetOrdCompI.CurrentRow.Cells.Item(1).Value
                lblCantF.Text = dgvGrillaDetOrdCompI.CurrentRow.Cells.Item(5).Value.ToString
                lblCantP.Text = dgvGrillaDetOrdCompI.CurrentRow.Cells.Item(4).Value.ToString
            End If
            dgvGrillaDetOrdCompI.Enabled = False
            dgvGrillaDetOrdCompM.Enabled = False
            btnRegI.Text = "Cancelar"


            lblCantIng.Visible = True
            lblCantFal.Visible = True
            lblCantPedida.Visible = True
            txtCantIng.Visible = True
            btnRegM.Visible = False
            btnRegArt.Visible = True
            Articulo = "I"
        Else
            dgvGrillaDetOrdCompI.Enabled = True
            dgvGrillaDetOrdCompM.Enabled = True
            btnRegI.Text = "Registrar Insumo"
            btnRegM.Visible = True
            lblCantF.Text = ""
            lblCantP.Text = ""
            lblCantIng.Visible = False
            lblCantFal.Visible = False
            lblCantPedida.Visible = False
            txtCantIng.Visible = False
            btnRegArt.Visible = False
        End If
    End Sub

    Private Sub btnRegArt_Click(sender As Object, e As EventArgs) Handles btnRegArt.Click

        If txtCantIng.Text = "" Then
            MsgBox("Error, ingresa un valor en la caja de texto.")
        ElseIf (Int(txtCantIng.Text)) <= 0 Then
            MsgBox("Error, por favor ingrese una cantidad mayor a 0.")
        ElseIf (Int(txtCantIng.Text)) > lblCantF.Text Then
            MsgBox("Error, se ha ingresado una cantidad mayor que la pedida en el pedido.")
        Else
            opc = MsgBox("¿Esta Seguro que desea registrar esta cantidad de este articulo en el paquete?", vbYesNo)
            If opc = 6 Then

                If (Int(txtCantIng.Text)) = lblCantF.Text Then
                    If Articulo = "I" Then
                        sql = "update DetOrdComp_Ins set Recibido=1, Resto= (" & Int(lblCantF.Text) - (Int(txtCantIng.Text)) & ") where IdDetOCI= " & IdDetOrdComp & " And IdOrdComp= " & idOrdComp
                        Consulta()
                    Else
                        sql = "update DetOrdComp_Med Set Recibido=1, Resto= " & Int(lblCantF.Text) & "- " & (Int(txtCantIng.Text)) & " where IdDetOCM= " & IdDetOrdComp & " And IdOrdComp= " & idOrdComp
                        Consulta()
                    End If

                Else
                    opc = MsgBox("Esta por registrar una cantidad menor a la requerida en el pedido. ¿Esta Seguro?", vbYesNo)
                    If (opc = 6) Then
                        If Articulo = "I" Then
                            sql = "update DetOrdComp_Ins set  Resto= " & Int(lblCantF.Text) & "- " & (Int(txtCantIng.Text)) & " where IdDetOCI= " & IdDetOrdComp & " And IdOrdComp= " & idOrdComp
                            Consulta()
                        Else
                            sql = "update DetOrdComp_Med set  Resto= " & Int(lblCantF.Text) & "- " & (Int(txtCantIng.Text)) & " where IdDetOCM= " & IdDetOrdComp & " And IdOrdComp= " & idOrdComp
                            Consulta()
                        End If
                    End If

                    MsgBox("Se ha registrado la cantidad ingresada del articulo del pedido seleccionado")
                End If

                opc = MsgBox("¿Desea seguir registrando articulos del pedido?", vbYesNo)
                If opc = 7 Then
                    sql = "select count(*) from detOrdComp_ins where resto<>0 and IdOrdComp=" & idOrdComp
                    rs = Consulta()
                    rs.Read()

                    If rs.Item(0) = 0 Then
                        sql = "select count(*) from detOrdComp_med where resto<>0 and IdOrdComp=" & idOrdComp
                        rs = Consulta()
                        rs.Read()
                    End If
                    If rs.Item(0) = 0 Then
                        sql = "update Ord_Comp set recibido=1 where idOrdComp=" & idOrdComp
                    End If
                    Me.Hide()
                    GrillaFarmacia.Show()
                Else
                    sql = "select count(*) from detOrdComp_ins where resto<>0 and IdOrdComp=" & idOrdComp
                    rs = Consulta()
                    rs.Read()

                    If rs.Item(0) = 0 Then
                        sql = "select count(*) from detOrdComp_med where resto<>0 and IdOrdComp=" & idOrdComp
                        rs = Consulta()
                        rs.Read()
                    End If
                    If rs.Item(0) = 0 Then
                        sql = "update Ord_Comp set recibido=1 where idOrdComp=" & idOrdComp
                        MsgBox("No quedan mas articulos por registrar.")

                        Me.Hide()
                        GrillaFarmacia.Show()
                    Else
                        sql = "select DOC.IdOrdComp, DOC.IdDetOCI , I.IdInsumo, I.Nombre 'Insumo' , DOC.Cantidad 'Cantidad Pedida', DOC.Resto 'Cantidad Faltante' from Insumo I, Ord_Comp OC, DetOrdComp_Ins DOC Where DOC.IdOrdComp=OC.IdOrdComp and I.IdInsumo=DOC.IdInsumo and DOC.Resto>0 and DOC.IdOrdComp=" & idOrdComp
                        dgvGrillaDetOrdCompI.DataSource = ConsultaDG("DetPedidoI")
                        dgvGrillaDetOrdCompI.Columns(0).Visible = False
                        dgvGrillaDetOrdCompI.Columns(1).Visible = False
                        dgvGrillaDetOrdCompI.Columns(2).Visible = False
                        sql = "select DOC.IdOrdComp, DOC.IdDetOCM , M.IdMedicamento, M.Nombre 'Medicamento' ,M.Presen, DOC.Cantidad 'Cantidad Pedida', DOC.Resto 'Cantidad Faltante' from Medicamento M, Ord_Comp OC, DetOrdComp_Med DOC Where DOC.IdOrdComp=OC.IdOrdComp and M.IdMedicamento=DOC.IdMedicamento and DOC.Resto>0 and DOC.IdOrdComp=" & idOrdComp
                        dgvGrillaDetOrdCompM.DataSource = ConsultaDG("DetPedidoM")
                        dgvGrillaDetOrdCompM.Columns(0).Visible = False
                        dgvGrillaDetOrdCompM.Columns(1).Visible = False
                        dgvGrillaDetOrdCompM.Columns(2).Visible = False
                        btnRegArt.Visible = False
                        lblCantIng.Visible = False
                        lblCantFal.Visible = False
                        lblCantPedida.Visible = False
                        txtCantIng.Visible = False
                        btnRegI.Visible = True
                        btnRegM.Visible = True
                        dgvGrillaDetOrdCompI.Enabled = True
                        dgvGrillaDetOrdCompM.Enabled = True
                        lblCantF.Text = ""
                        lblCantP.Text = ""
                        txtCantIng.Text = ""
                        btnRegM.Text = "Registrar Medicamento"
                        btnRegI.Text = "Registrar Insumo"
                    End If
                End If
                End If


        End If
        btnRegArt.Visible = False
        lblCantIng.Visible = False
        lblCantFal.Visible = False
        lblCantPedida.Visible = False
        txtCantIng.Visible = False
        lblCantF.Text = ""
        lblCantP.Text = ""
        txtCantIng.Text = ""
    End Sub
    Private Sub txtCantIng_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantIng.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub


End Class
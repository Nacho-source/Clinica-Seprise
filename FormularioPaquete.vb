Imports System.Data.Odbc

Public Class FormularioPaquete
    Dim i As Integer
    Dim opc As Integer
    Dim IdDetPedido As Integer
    Dim rs As OdbcDataReader
    Dim Articulo As String
    Dim eoff As Boolean
    Public IdPend As Integer
    Dim IdPedido As Integer
    Private Sub FormularioPaquete_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        i = 0
        btnRegArt.Visible = False
        lblCantIng.Visible = False
        lblCantPed.Visible = False
        lblCantRest.Visible = False
        txtCantIng.Visible = False
        btnRegI.Visible = True
        btnRegM.Visible = True
        dgvGrillaPedidoI.Enabled = True
        dgvGrillaPedidoM.Enabled = True
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
            If IsNothing(dgvGrillaPedidoM.CurrentRow) Then
                IdDetPedido = dgvGrillaPedidoM.Rows(0).Cells.Item(1).Value
                IdPedido = dgvGrillaPedidoM.Rows(0).Cells.Item(0).Value
                sql = "select M.Stock From Medicamento M, DetPedidoMed DP Where M.IdMedicamento = DP.IdMedicamento and DP.IdPedido=" & dgvGrillaPedidoM.Rows(0).Cells.Item(0).Value & " and DP.IdDetPedM=" & IdDetPedido
                rs = Consulta()
            Else
                IdDetPedido = dgvGrillaPedidoM.CurrentRow.Cells.Item(1).Value
                IdPedido = dgvGrillaPedidoM.CurrentRow.Cells.Item(0).Value
                sql = "select M.Stock From Medicamento M, DetPedidoMed DP Where M.IdMedicamento = DP.IdMedicamento and DP.IdPedido=" & dgvGrillaPedidoM.CurrentRow.Cells.Item(0).Value & " and DP.IdDetPedM=" & IdDetPedido
                rs = Consulta()
            End If
            dgvGrillaPedidoI.Enabled = False
            dgvGrillaPedidoM.Enabled = False
            btnRegM.Text = "Cancelar"
            lblCantP.Text = dgvGrillaPedidoM.CurrentRow.Cells.Item(6).Value.ToString
            rs.Read()
            lblCantR.Text = rs.Item(0).ToString
            lblCantIng.Visible = True
            lblCantPed.Visible = True
            lblCantRest.Visible = True
            txtCantIng.Visible = True
            btnRegI.Visible = False
            btnRegArt.Visible = True
            Articulo = "M"
        Else
            dgvGrillaPedidoI.Enabled = True
            dgvGrillaPedidoM.Enabled = True
            btnRegM.Text = "Registrar Medicamento"

            lblCantP.Text = ""
            lblCantR.Text = ""
            btnRegI.Visible = True

            lblCantIng.Visible = False
            lblCantPed.Visible = False
            lblCantRest.Visible = False
            txtCantIng.Visible = False
            btnRegArt.Visible = False
        End If
    End Sub

    Private Sub btnRegI_Click(sender As Object, e As EventArgs) Handles btnRegI.Click
        If btnRegI.Text <> "Cancelar" Then
            If IsNothing(dgvGrillaPedidoI.CurrentRow) Then
                sql = "select I.Stock From Insumo I, DetPedidoIns DP Where I.IdInsumo = DP.IdInsumo and DP.IdPedido=" & dgvGrillaPedidoI.Rows(0).Cells.Item(0).Value & " and DP.IdDetPedI=" & IdDetPedido
                IdDetPedido = dgvGrillaPedidoI.CurrentRow.Cells.Item(1).Value
                IdPedido = dgvGrillaPedidoI.CurrentRow.Cells.Item(0).Value
                rs = Consulta()
            Else
                IdDetPedido = dgvGrillaPedidoI.CurrentRow.Cells.Item(1).Value
                IdPedido = dgvGrillaPedidoI.CurrentRow.Cells.Item(0).Value
                sql = "select I.Stock From Insumo I, DetPedidoIns DP Where I.IdInsumo = DP.IdInsumo and DP.IdPedido=" & dgvGrillaPedidoI.CurrentRow.Cells.Item(0).Value & " and DP.IdDetPedI=" & IdDetPedido
                rs = Consulta()
            End If
            dgvGrillaPedidoI.Enabled = False
            dgvGrillaPedidoM.Enabled = False
            btnRegI.Text = "Cancelar"
            rs.Read()
            lblCantP.Text = dgvGrillaPedidoI.CurrentRow.Cells.Item(5).Value.ToString
            lblCantR.Text = rs.Item(0).ToString
            lblCantIng.Visible = True
            lblCantPed.Visible = True
            lblCantRest.Visible = True
            txtCantIng.Visible = True
            btnRegM.Visible = False
            btnRegArt.Visible = True
            Articulo = "I"
        Else
            dgvGrillaPedidoI.Enabled = True
            dgvGrillaPedidoM.Enabled = True
            btnRegI.Text = "Registrar Insumo"
            btnRegM.Visible = True
            lblCantP.Text = ""
            lblCantR.Text = ""
            lblCantIng.Visible = False
            lblCantPed.Visible = False
            lblCantRest.Visible = False
            txtCantIng.Visible = False
            btnRegArt.Visible = False
        End If
    End Sub

    Private Sub btnRegArt_Click(sender As Object, e As EventArgs) Handles btnRegArt.Click

        Dim IdPaquete As Integer
        If txtCantIng.Text = "" Then
            MsgBox("Error, ingresa un valor en la caja de texto.")
        ElseIf (Int(txtCantIng.Text)) > lblCantR.Text Then

            MsgBox("Error, se ha ingresado una cantidad  mayor a la restante en bodega.")
        ElseIf (Int(txtCantIng.Text)) <= 0 Then
            MsgBox("Error, por favor ingrese una cantidad mayor a 0.")
        ElseIf (Int(txtCantIng.Text)) > lblCantP.Text Then
            MsgBox("Error, se ha ingresado una cantidad mayor que la pedida en el pedido.")
        Else
            opc = MsgBox("¿Esta Seguro que desea registrar esta cantidad de este articulo en el paquete?", vbYesNo)
            If opc = 6 Then
                If i = 0 Then
                    If Articulo = "I" Then
                        IdPedido = dgvGrillaPedidoI.CurrentRow.Cells.Item(0).Value
                        IdDetPedido = dgvGrillaPedidoI.CurrentRow.Cells.Item(1).Value
                    Else
                        IdPedido = dgvGrillaPedidoM.CurrentRow.Cells.Item(0).Value
                        IdDetPedido = dgvGrillaPedidoM.CurrentRow.Cells.Item(1).Value
                    End If
                    sql = "Select distinct Pa.IdPaq from Paquete Pa, Pedido Pe where Pa.IdPedido=" & IdPedido
                    rs = Consulta()
                    rs.Read()
                    IdPaquete = rs.Item(0)
                End If
                If (Int(txtCantIng.Text)) = lblCantP.Text Then
                    If Articulo = "I" Then
                        sql = "update DetPedidoIns set Recibido=1, Resto= (" & Int(lblCantP.Text) - (Int(txtCantIng.Text)) & ") where IdDetPedI= " & IdDetPedido & " And IdPedido= " & IdPedido
                        Consulta()
                    Else
                        sql = "update DetPedidoMed Set Recibido=1, Resto= " & Int(lblCantP.Text) & "- " & (Int(txtCantIng.Text)) & " where IdDetPedM= " & IdDetPedido & " And IdPedido= " & IdPedido
                        Consulta()
                    End If

                Else
                    opc = MsgBox("Esta por registrar una cantidad menor a la requerida en el pedido. ¿Esta Seguro?", vbYesNo)
                    If (opc = 6) Then
                        If Articulo = "I" Then
                            sql = "update DetPedidoIns set  Resto= " & Int(lblCantP.Text) & "- " & (Int(txtCantIng.Text)) & " where IdDetPedI= " & IdDetPedido & " And IdPedido= " & IdPedido
                            Consulta()
                        Else
                            sql = "update DetPedidoMed set  Resto= " & Int(lblCantP.Text) & "- " & (Int(txtCantIng.Text)) & " where IdDetPedM= " & IdDetPedido & " And IdPedido= " & IdPedido
                            Consulta()
                        End If
                    End If

                    MsgBox("Se ha registrado la cantidad ingresada del articulo del pedido seleccionado")
                End If

                opc = MsgBox("¿Desea seguir registrando articulos del pedido?", vbYesNo)
                If opc = 7 Then
                    sql = "Select distinct idDetPedI, I.Nombre , DP.Resto from Insumo I, Pedido P, DetPedidoIns DP Where I.IdInsumo=DP.IdInsumo And DP.IdPedido=" & IdPedido
                    rs = Consulta()
                    i = 0
                    eoff = False
                    Dim rs2 As OdbcDataReader

                    sql = "update Pendientes Set Detalle= '' where idPend = " & IdPend
                    Do While (eoff = False)

                        If (rs.Read = True) Then
                            If rs.Item(2) > 0 Then

                                sql = "select detalle from Pendientes where idPend=" & IdPend
                                rs2 = Consulta()
                                rs2.Read()
                                sql = "update Pendientes set Detalle =('" & rs2.Item(0) & " - Insumo:" & rs.Item(1) & ", cantidad faltante: " & rs.Item(2) & ". ') where idPend = " & IdPend
                                Consulta()
                            End If
                        Else
                            eoff = True
                        End If

                    Loop
                    sql = "select distinct idDetPedM, M.Nombre , DP.Resto from Medicamento M, Pedido P, DetPedidoMed DP Where M.IdMedicamento=DP.IdMedicamento and DP.IdPedido=" & IdPedido
                    rs = Consulta()
                    eoff = False

                    Do While (eoff = False)

                        If (rs.Read = True) Then
                            If rs.Item(2) > 0 Then
                                If i = 0 Then
                                    sql = "update Pendientes Set Detalle= '' where idPend = " & IdPend

                                    Consulta()
                                    i = i + 1
                                End If
                                sql = "select detalle from Pendientes where idPend=" & IdPend
                                rs2 = Consulta()
                                rs2.Read()
                                sql = "update Pendientes set Detalle= ('" & rs2.Item(0) & " - Medicamento:" & rs.Item(1) & ", cantidad faltante: " & rs.Item(2) & ". ') where idPend = " & IdPend
                                Consulta()
                            End If
                        Else
                            eoff = True
                        End If

                    Loop
                    sql = "Select count( *)  from DetPedidoins DP Where resto>0 and DP.IdPedido=" & IdPedido
                    rs = Consulta()
                    rs.Read()
                    If rs.Item(0) = 0 Then

                        sql = "Select count( *)  from DetPedidomed DP Where resto>0 and DP.IdPedido=" & IdPedido
                        rs = Consulta()
                        rs.Read()
                    End If
                    If rs.Item(0) = 0 Then
                        MsgBox("Se han registrado todos los articulos del pedido y se elimino de pendientes")
                        sql = "delete from Pendientes  where idPend = " & IdPend
                        Consulta()

                    End If
                    Me.Hide()
                    GrillaFarmacia.Show()
                Else

                    sql = "Select count( *)  from DetPedidoins DP Where resto>0 and DP.IdPedido=" & IdPedido
                    rs = Consulta()
                    rs.Read()
                    If rs.Item(0) = 0 Then

                        sql = "Select count( *)  from DetPedidomed DP Where resto>0 and DP.IdPedido=" & IdPedido
                        rs = Consulta()
                        rs.Read()
                    End If
                    If rs.Item(0) = 0 Then
                        MsgBox("Se han registrado todos los articulos del pedido y se elimino de pendientes")
                        sql = "delete from Pendientes  where idPend = " & IdPend
                        Consulta()
                        Me.Hide()
                        GrillaFarmacia.Show()
                    End If
                End If
            End If


        End If
        btnRegArt.Visible = False
        lblCantIng.Visible = False
        lblCantPed.Visible = False
        lblCantRest.Visible = False
        txtCantIng.Visible = False
        btnRegI.Visible = True
        btnRegM.Visible = True
        dgvGrillaPedidoI.Enabled = True
        dgvGrillaPedidoM.Enabled = True
        lblCantP.Text = ""
        lblCantR.Text = ""
        txtCantIng.Text = ""
        btnRegM.Text = "Registrar Medicamento"
        btnRegI.Text = "Registrar Insumo"
        sql = "select DP.IdPedido, DP.IdDetPedI, I.IdInsumo, I.Nombre 'Insumo' , DP.Cantidad 'Cantidad Pedida', DP.Resto 'Cantidad Faltante' from Insumo I, Pedido P, DetPedidoIns DP Where DP.IdPedido=P.IdPedido and I.IdInsumo=DP.IdInsumo and DP.Resto>0  and DP.IdPedido=" & IdPedido
        dgvGrillaPedidoI.DataSource = ConsultaDG("DetPedidoI")
        dgvGrillaPedidoI.Columns(0).Visible = False
        dgvGrillaPedidoI.Columns(1).Visible = False
        dgvGrillaPedidoI.Columns(2).Visible = False
        sql = "select DP.IdPedido, DP.IdDetPedM, M.IdMedicamento, M.Nombre 'Medicamento' ,M.Presen, DP.Cantidad 'Cantidad Pedida', DP.Resto 'Cantidad Faltante' from Medicamento M, Pedido P, DetPedidoMed DP Where DP.IdPedido=P.IdPedido and M.IdMedicamento=DP.IdMedicamento and DP.Resto>0  and DP.IdPedido=" & IdPedido
        dgvGrillaPedidoM.DataSource = ConsultaDG("DetPedidoM")
        dgvGrillaPedidoM.Columns(0).Visible = False
        dgvGrillaPedidoM.Columns(1).Visible = False
        dgvGrillaPedidoM.Columns(2).Visible = False
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
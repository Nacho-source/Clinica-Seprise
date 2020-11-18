'Imports System.Data.Odbc

'Public Class GrillaFarmacia
'    Public Codigo As Integer
'    Public CodigoProv As Integer
'    Dim IdSector As Integer
'    Dim rs As OdbcDataReader
'    Dim opc As Integer
'    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
'        If (T = "MyI") Then
'            Me.Hide()
'            FormularioInsumo.CodigoIns = 0
'            FormularioInsumo.cboProveedores.Enabled = True
'            FormularioInsumo.Show()
'            FormularioInsumo.btnAccion.Text = "Registrar Insumo"
'        End If


'    End Sub
'    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
'        If (T = "MyI") Then
'            Me.Hide()
'            If IsNothing(dgvGrillaFarmacia2.CurrentRow) Then
'                sql = "Select I.nombre, P.Nombre, I.Stock, I.PP, I.PrecioVenta, IP.Precio, I.IdInsumo, P.IdProv From Insumo I, Proveedor P, Insumo_Proveedor IP  Where I.IdInsumo=IP.IdInsumo and IP.IdProv=P.IdProv and I.IdInsumo=" & dgvGrillaFarmacia2.Rows(0).Cells.Item(0).Value

'            Else
'                sql = "Select I.nombre, P.Nombre, I.Stock, I.PP, I.PrecioVenta, IP.Precio, I.IdInsumo, P.IdProv From Insumo I, Proveedor P, Insumo_Proveedor IP  Where I.IdInsumo=IP.IdInsumo and IP.IdProv=P.IdProv and I.IdInsumo=" & dgvGrillaFarmacia2.CurrentRow.Cells.Item(0).Value

'            End If
'            rs = Consulta()
'            If rs.Read = True Then
'                FormularioInsumo.Show()
'                FormularioInsumo.btnAccion.Text = "Modificar Insumo"
'                FormularioInsumo.txtNombre.Text = rs.Item(0)
'                FormularioInsumo.cboProveedores.Text = rs.Item(1)
'                FormularioInsumo.cboProveedores.Enabled = False
'                FormularioInsumo.txtStock.Text = rs.Item(2)
'                FormularioInsumo.txtPP.Text = rs.Item(3)
'                FormularioInsumo.txtPrecioVenta.Text = rs.Item(4)
'                FormularioInsumo.txtPrecioproveedor.Text = rs.Item(5)
'                Codigo = rs.Item(6)
'                CodigoProv = rs.Item(7)
'            End If
'        End If
'        If (T = "Pedido") Then
'            Dim CodigoPed As Integer
'            If btnModificar.Text <> "Cancelar" Then
'                If IsNothing(dgvGrillaFarmacia2.CurrentRow) Then
'                    CodigoPed = dgvGrillaFarmacia2.Rows(0).Cells.Item(0).Value
'                Else
'                    CodigoPed = dgvGrillaFarmacia2.CurrentRow.Cells.Item(0).Value
'                End If
'                lbltitulo1.Visible = True
'                lbltitulo2.Visible = True
'                lbltitulo3.Visible = False
'                lbltitulo1.Text = "Insumos"
'                lbltitulo2.Text = "Medicamentos"
'                dgvGrillaFarmacia.Width = 431
'                dgvGrillaFarmacia2.Visible = True
'                btnAgregar2.Visible = False
'                btnModificar2.Visible = False
'                btnEliminar2.Visible = False
'                btnModificar.Text = "Cancelar"

'                btnAgregar.Visible = False
'                btnModificar.Visible = True
'                btnEliminar.Visible = False
'                sql = "select DP.IdDetPedI, I.IdInsumo, I.Nombre 'Insumo' ,DP.Cantidad 'Cantidad Pedida' from Insumo I, Pedido P, DetPedidoIns DP Where DP.IdPedido=P.IdPedido and I.IdInsumo=DP.IdInsumo and DP.IdPedido=" & CodigoPed
'                dgvGrillaFarmacia.DataSource = ConsultaDG("DetPedidoI")
'                dgvGrillaFarmacia.Columns(0).Visible = False
'                dgvGrillaFarmacia.Columns(1).Visible = False
'                sql = "select DP.IdDetPedM, M.IdMedicamento, M.Nombre 'Medicamento' ,M.Presen, DP.Cantidad 'Cantidad Pedida' from Medicamento M, Pedido P, DetPedidoMed DP Where DP.IdPedido=P.IdPedido and M.IdMedicamento=DP.IdMedicamento and DP.IdPedido=" & CodigoPed
'                dgvGrillaFarmacia2.DataSource = ConsultaDG("DetPedidoM")
'                dgvGrillaFarmacia2.Columns(0).Visible = False
'                dgvGrillaFarmacia2.Columns(1).Visible = False
'            Else
'                MostrarPedidos()
'            End If
'        End If
'        If (T = "Paquete") Then
'            Dim CodigoPed As Integer
'            If btnModificar.Text <> "Cancelar" Then
'                If IsNothing(dgvGrillaFarmacia2.CurrentRow) Then
'                    CodigoPed = dgvGrillaFarmacia2.Rows(0).Cells.Item(0).Value
'                Else
'                    CodigoPed = dgvGrillaFarmacia2.CurrentRow.Cells.Item(0).Value
'                End If
'                lbltitulo1.Visible = True
'                lbltitulo2.Visible = True
'                lbltitulo3.Visible = False
'                lbltitulo1.Text = "Insumos entregados"
'                lbltitulo2.Text = "Medicamentos entregados"
'                dgvGrillaFarmacia.Width = 431
'                dgvGrillaFarmacia2.Visible = True
'                btnAgregar2.Visible = False
'                btnModificar2.Visible = False
'                btnEliminar2.Visible = False
'                btnModificar.Text = "Cancelar"

'                btnAgregar.Visible = False
'                btnModificar.Visible = True
'                btnEliminar.Visible = False
'                sql = "select DP.IdDetPedI, I.IdInsumo, I.Nombre 'Insumo' ,DP.Cantidad 'Cantidad Pedida', DP.Resto 'Cantidad Faltante' from Insumo I, Pedido P, DetPedidoIns DP Where DP.IdPedido=P.IdPedido and I.IdInsumo=DP.IdInsumo and DP.IdPedido=" & CodigoPed
'                dgvGrillaFarmacia.DataSource = ConsultaDG("DetPedidoI")
'                dgvGrillaFarmacia.Columns(0).Visible = False
'                dgvGrillaFarmacia.Columns(1).Visible = False
'                sql = "select DP.IdDetPedM, M.IdMedicamento, M.Nombre 'Medicamento' ,M.Presen, DP.Cantidad 'Cantidad Pedida', DP.Resto 'Cantidad Faltante' from Medicamento M, Pedido P, DetPedidoMed DP Where DP.IdPedido=P.IdPedido and M.IdMedicamento=DP.IdMedicamento and DP.IdPedido=" & CodigoPed
'                dgvGrillaFarmacia2.DataSource = ConsultaDG("DetPedidoM")
'                dgvGrillaFarmacia2.Columns(0).Visible = False
'                dgvGrillaFarmacia2.Columns(1).Visible = False
'            Else
'                MostrarPaquete()
'            End If
'        End If
'        If (T = "Articulo Sector") Then
'            If btnModificar.Text = "Eliminar insumo del sector" Then
'                sql = "select nombre from sector where idSector=" & IdSector
'                rs = Consulta()
'                rs.Read()
'                opc = MsgBox("¿Esta seguro que desea eliminar este insumo al sector " & rs.Item(0) & "?", vbYesNo)
'                If opc = 6 Then
'                    If IsNothing(dgvGrillaFarmacia2.CurrentRow) Then
'                        sql = "delete from insumo_sector where idSector= " & IdSector & " and idinsumo= " & dgvGrillaFarmacia2.Rows(0).Cells.Item(0).Value
'                    Else
'                        sql = "delete from insumo_sector where idSector= " & IdSector & " and idinsumo= " & dgvGrillaFarmacia2.CurrentRow.Cells.Item(0).Value
'                    End If
'                    Consulta()
'                    MsgBox("Se ha eliminado el insumo del sector elegido")
'                    mostrarSector()
'                End If
'            Else
'                FormularioArticuloSector.idSector = IdSector
'                If IsNothing(dgvGrillaFarmacia2.CurrentRow) Then

'                    FormularioArticuloSector.idArticulo = dgvGrillaFarmacia2.Rows(0).Cells.Item(0).Value
'                Else
'                    FormularioArticuloSector.idArticulo = dgvGrillaFarmacia2.CurrentRow.Cells.Item(0).Value
'                End If
'                sql = "select nombre from sector where idSector=" & IdSector
'                rs = Consulta()
'                rs.Read()
'                opc = MsgBox("¿Esta seguro que desea agregar este insumo al sector " & rs.Item(0) & "?", vbYesNo)
'                If opc = 6 Then

'                    FormularioArticuloSector.lblTitulo.Text = "Registrar Insumo Sector"
'                    FormularioArticuloSector.btnAccion.Text = "Agregar Insumo"
'                    Me.Hide()
'                    FormularioArticuloSector.Show()
'                End If
'            End If
'        End If
'    End Sub

'    Private Sub btnModificar2_Click(sender As Object, e As EventArgs) Handles btnModificar2.Click
'        If (T = "MyI") Then
'            Me.Hide()
'            If IsNothing(dgvGrillaFarmacia.CurrentRow) Then
'                sql = "Select M.nombre, M.Presen, P.Nombre, M.Stock, M.PP, M.PrecioVenta, M.idMedicamento, P.idProv From Medicamento M, Proveedor P Where M.IdProv=P.IdProv and M.IdMedicamento=" & dgvGrillaFarmacia.Rows(0).Cells.Item(0).Value
'            Else
'                sql = "Select M.nombre, M.Presen, P.Nombre, M.Stock, M.PP, M.PrecioVenta, M.idMedicamento, P.idProv From Medicamento M, Proveedor P Where M.IdProv=P.IdProv and M.IdMedicamento=" & dgvGrillaFarmacia.CurrentRow.Cells.Item(0).Value

'            End If
'            rs = Consulta()
'            If rs.Read = True Then

'                FormularioMedicamentos.btnAccion.Text = "Modificar Insumo"
'                FormularioMedicamentos.txtNombre.Text = rs.Item(0)
'                FormularioMedicamentos.txtPresentacion.Text = rs.Item(1)
'                FormularioMedicamentos.cboProveedores.Text = rs.Item(2)
'                FormularioMedicamentos.cboProveedores.Enabled = False
'                FormularioMedicamentos.txtStock.Text = rs.Item(3)
'                FormularioMedicamentos.txtPP.Text = rs.Item(4)
'                FormularioMedicamentos.txtPrecioVenta.Text = rs.Item(5)
'                Codigo = rs.Item(6)
'                CodigoProv = rs.Item(7)
'                FormularioMedicamentos.Show()
'            End If
'        End If
'        If (T = "Proveedor") Then
'            Me.Hide()
'            If IsNothing(dgvGrillaFarmacia.CurrentRow) Then
'                sql = "Select nombre, Domi, Tel, idProv From Proveedor Where IdProv=" & dgvGrillaFarmacia.Rows(0).Cells.Item(0).Value
'            Else
'                sql = "Select nombre, Domi, Tel, idProv From Proveedor Where IdProv=" & dgvGrillaFarmacia.CurrentRow.Cells.Item(0).Value
'            End If
'            rs = Consulta()
'            If rs.Read = True Then

'                FormularioProveedor.btnAccion.Text = "Modificar Proveedor"
'                FormularioProveedor.txtNombre.Text = rs.Item(0)
'                FormularioProveedor.txtDomicilio.Text = rs.Item(1)
'                FormularioProveedor.txtTel.Text = rs.Item(2)
'                CodigoProv = rs.Item(3)
'                FormularioProveedor.Show()
'            End If
'        End If

'    End Sub



'    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
'        Me.Hide()
'        MenuFarmacia.Show()

'    End Sub


'    Private Sub GrillaFarmacia_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
'        btnVolver.Visible = True
'        Codigo = 0
'        CodigoProv = 0
'        btnAgregar.Text = "Agregar"
'        btnModificar.Text = "Modificar"
'        btnEliminar.Text = "Eliminar"
'        btnAgregar2.Text = "Agregar"
'        btnModificar2.Text = "Modificar"
'        btnEliminar2.Text = "Eliminar"
'        btnAgregar2.Visible = True
'        btnModificar2.Visible = True
'        btnEliminar2.Visible = True
'        btnAgregar.Visible = True
'        btnModificar.Visible = True
'        btnEliminar.Visible = True
'        dgvGrillaFarmacia.Width = 934
'        dgvGrillaFarmacia2.Visible = False
'        dgvGrillaFarmacia.Visible = True
'        If T = "MyI" Then
'            lbltitulo1.Visible = True

'            lbltitulo2.Visible = True
'            lbltitulo3.Visible = False
'            lbltitulo1.Text = "Medicamentos"
'            lbltitulo2.Text = "Insumos"
'            dgvGrillaFarmacia.Width = 431
'            dgvGrillaFarmacia2.Visible = True
'            btnAgregar.Visible = True
'            btnModificar.Visible = True
'            btnEliminar.Visible = True
'            sql = "select M.IdMedicamento, P.Nombre'Nombre Proveedor', M.Nombre'Nombre Medicamento', M.Stock, M.PP , M.Presen Presentacion, M.PrecioVenta from Medicamento M, Proveedor P Where M.Activo=true and M.IdProv=P.IdProv"
'            dgvGrillaFarmacia.DataSource = ConsultaDG("Medicamentos")
'            dgvGrillaFarmacia.Columns(0).Visible = False
'            sql = "select I.IdInsumo,I.Nombre 'Nombre Insumo' , P.Nombre 'Nombre Proveedor', I.Stock, I.PP, I.PrecioVenta from Insumo I, Proveedor P, Insumo_Proveedor IP Where I.Activo=true and I.IdInsumo=IP.IdInsumo and IP.IdProv=P.IdProv"
'            dgvGrillaFarmacia2.DataSource = ConsultaDG("Insumos")
'            dgvGrillaFarmacia2.Columns(0).Visible = False

'        End If
'        If T = "Proveedor" Then
'            dgvGrillaFarmacia.Width = 934
'            lbltitulo1.Visible = False

'            lbltitulo2.Visible = False
'            lbltitulo3.Visible = True
'            lbltitulo3.Text = "Proveedores"
'            dgvGrillaFarmacia2.Visible = False
'            btnAgregar.Visible = False
'            btnModificar.Visible = False
'            btnEliminar.Visible = False
'            sql = "select IdProv, Nombre, Domi Direccion, Tel Telefono from Proveedor Where Activo=true"
'            dgvGrillaFarmacia.DataSource = ConsultaDG("Proveedores")
'            dgvGrillaFarmacia.Columns(0).Visible = False
'        End If
'        If T = "Pedido" Then
'            MostrarPedidos()
'        End If
'        If T = "Paquete" Then
'            MostrarPaquete()
'        End If
'        If T = "FacturaProveedor" Then
'            mostrarRemyFac()
'        End If
'        If T = "Articulo Sector" Then
'            mostrarSector()
'        End If
'    End Sub
'    Private Sub btnEliminar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar2.Click
'        Dim Opc As Integer
'        Dim elementoABorrar As Integer
'        Dim nombre As String

'        If T = "MyI" Then
'            If IsNothing(dgvGrillaFarmacia.CurrentRow) Then
'                nombre = dgvGrillaFarmacia.Rows(0).Cells.Item(2).Value
'                elementoABorrar = dgvGrillaFarmacia.Rows(0).Cells.Item(0).Value
'            Else
'                nombre = dgvGrillaFarmacia.CurrentRow.Cells.Item(2).Value
'                elementoABorrar = dgvGrillaFarmacia.CurrentRow.Cells.Item(0).Value
'            End If

'            Opc = MsgBox("Esta seguro que desea eliminar" & dgvGrillaFarmacia.CurrentRow.Cells.Item(2).Value, vbYesNo)
'            If (Opc = 6) Then

'                sql = "update Medicamento Set Activo=False Where IdMedicamento=" & elementoABorrar
'                Consulta()
'                MsgBox(nombre & " fue eliminado")

'            End If

'        End If
'        If T = "Proveedor" Then
'            If IsNothing(dgvGrillaFarmacia.CurrentRow) Then
'                nombre = dgvGrillaFarmacia.Rows(0).Cells.Item(1).Value
'                elementoABorrar = dgvGrillaFarmacia.Rows(0).Cells.Item(0).Value
'            Else
'                nombre = dgvGrillaFarmacia.CurrentRow.Cells.Item(1).Value
'                elementoABorrar = dgvGrillaFarmacia.CurrentRow.Cells.Item(0).Value
'            End If
'            Opc = MsgBox("Esta seguro que desea eliminar" & dgvGrillaFarmacia.CurrentRow.Cells.Item(1).Value, vbYesNo)

'            If (Opc = 6) Then
'                sql = "update Proveedor Set Activo=False Where Idprov=" & elementoABorrar
'                Consulta()
'                MsgBox(nombre & " fue eliminado")
'            End If

'        End If
'        If (T = "Pedido") Then
'            Dim CodigoPed As Integer
'            If IsNothing(dgvGrillaFarmacia.CurrentRow) Then
'                CodigoPed = dgvGrillaFarmacia.Rows(0).Cells.Item(0).Value
'            Else
'                CodigoPed = dgvGrillaFarmacia.CurrentRow.Cells.Item(0).Value
'            End If

'            sql = "Select DP.IdPedido, DP.IdDetPedI, I.IdInsumo, I.Nombre 'Insumo' , DP.Cantidad 'Cantidad Pedida', DP.Resto 'Cantidad Faltante' from Insumo I, Pedido P, DetPedidoIns DP Where DP.IdPedido=P.IdPedido and I.IdInsumo=DP.IdInsumo and DP.Resto>0  and DP.IdPedido=" & CodigoPed
'            FormularioPedido.dgvGrillaPedidoI.DataSource = ConsultaDG("DetPedidoI")
'            FormularioPedido.dgvGrillaPedidoI.Columns(0).Visible = False
'            FormularioPedido.dgvGrillaPedidoI.Columns(1).Visible = False
'            FormularioPedido.dgvGrillaPedidoI.Columns(2).Visible = False
'            sql = "select DP.IdPedido, DP.IdDetPedM, M.IdMedicamento, M.Nombre 'Medicamento' ,M.Presen, DP.Cantidad 'Cantidad Pedida', DP.Resto 'Cantidad Faltante' from Medicamento M, Pedido P, DetPedidoMed DP Where DP.IdPedido=P.IdPedido and M.IdMedicamento=DP.IdMedicamento and DP.Resto>0  and DP.IdPedido=" & CodigoPed
'            FormularioPedido.dgvGrillaPedidoM.DataSource = ConsultaDG("DetPedidoM")
'            FormularioPedido.dgvGrillaPedidoM.Columns(0).Visible = False
'            FormularioPedido.dgvGrillaPedidoM.Columns(1).Visible = False
'            FormularioPedido.dgvGrillaPedidoM.Columns(2).Visible = False
'            Me.Hide()
'            FormularioPedido.Show()
'        End If
'        If T = "Paquete" Then
'            Dim CodigoPed As Integer
'            If IsNothing(dgvGrillaFarmacia.CurrentRow) Then
'                CodigoPed = dgvGrillaFarmacia.Rows(0).Cells.Item(2).Value
'                FormularioPaquete.IdPend = dgvGrillaFarmacia.Rows(0).Cells.Item(0).Value
'            Else
'                CodigoPed = dgvGrillaFarmacia.CurrentRow.Cells.Item(2).Value
'                FormularioPaquete.IdPend = dgvGrillaFarmacia.CurrentRow.Cells.Item(0).Value
'            End If
'            sql = "select DP.IdPedido, DP.IdDetPedI, I.IdInsumo, I.Nombre 'Insumo' , DP.Cantidad 'Cantidad Pedida', DP.Resto 'Cantidad Faltante' from Insumo I, Pedido P, DetPedidoIns DP Where DP.IdPedido=P.IdPedido and I.IdInsumo=DP.IdInsumo and DP.Resto>0 and DP.IdPedido=" & CodigoPed
'            FormularioPaquete.dgvGrillaPedidoI.DataSource = ConsultaDG("DetPedidoI")
'            FormularioPaquete.dgvGrillaPedidoI.Columns(0).Visible = False
'            FormularioPaquete.dgvGrillaPedidoI.Columns(1).Visible = False
'            FormularioPaquete.dgvGrillaPedidoI.Columns(2).Visible = False
'            sql = "select DP.IdPedido, DP.IdDetPedM, M.IdMedicamento, M.Nombre 'Medicamento' ,M.Presen, DP.Cantidad 'Cantidad Pedida', DP.Resto 'Cantidad Faltante' from Medicamento M, Pedido P, DetPedidoMed DP Where DP.IdPedido=P.IdPedido and M.IdMedicamento=DP.IdMedicamento and DP.Resto>0 and DP.IdPedido=" & CodigoPed
'            FormularioPaquete.dgvGrillaPedidoM.DataSource = ConsultaDG("DetPedidoM")
'            FormularioPaquete.dgvGrillaPedidoM.Columns(0).Visible = False
'            FormularioPaquete.dgvGrillaPedidoM.Columns(1).Visible = False
'            FormularioPaquete.dgvGrillaPedidoM.Columns(2).Visible = False
'            Me.Hide()
'            FormularioPaquete.Show()

'        End If
'        If T = "FacturaProveedor" Then
'            Dim IdOrdComp As Integer


'            If btnEliminar2.Text <> "Cancelar" Then
'                If IsNothing(dgvGrillaFarmacia.CurrentRow) Then
'                    IdOrdComp = dgvGrillaFarmacia.Rows(0).Cells.Item(2).Value
'                Else
'                    IdOrdComp = dgvGrillaFarmacia.CurrentRow.Cells.Item(2).Value

'                End If
'                lbltitulo1.Text = "Medicamento de la Orden de compra"
'                lbltitulo2.Text = "Insumos de la Orden de compra"
'                dgvGrillaFarmacia.Width = 431
'                dgvGrillaFarmacia2.Visible = True
'                btnAgregar.Visible = False
'                btnModificar.Visible = False
'                btnEliminar.Visible = False
'                btnModificar2.Visible = False
'                btnAgregar2.Visible = False
'                btnEliminar2.Text = "Cancelar"

'                sql = "select DOC.IdOrdComp, DOC.IdDetOCI , I.nombre 'Nombre Insumo', DOC.Cantidad  from Remito r, insumo i,  DetOrdComp_Ins DOC where DOC.IdInsumo=I.IdInsumo and r.IdOrdComp=DOC.IdOrdComp and DOC.IdORdComp=" & IdOrdComp
'                dgvGrillaFarmacia.DataSource = ConsultaDG("Remitos")
'                dgvGrillaFarmacia.Columns(0).Visible = False
'                dgvGrillaFarmacia.Columns(1).Visible = False
'                sql = "select DOC.IdOrdComp, DOC.IdDetOCM , M.nombre  'Nombre Insumo', M.Presen 'Presentacion',  DOC.Cantidad  from Remito r, Medicamento m,  DetOrdComp_Med DOC where DOC.IdMedicamento=M.IdMedicamento and r.IdOrdComp=DOC.IdOrdComp and DOC.IdORdComp=" & IdOrdComp
'                dgvGrillaFarmacia2.DataSource = ConsultaDG("FactProv")
'                dgvGrillaFarmacia2.Columns(0).Visible = False
'                dgvGrillaFarmacia2.Columns(1).Visible = False

'            Else
'                mostrarRemyFac()
'            End If
'        End If
'        If (T = "Articulo Sector") Then
'            If btnEliminar2.Text = "Agregar articulos del Sector" Then

'                If IsNothing(dgvGrillaFarmacia.CurrentRow) Then
'                    IdSector = dgvGrillaFarmacia.Rows(0).Cells.Item(0).Value
'                Else
'                    IdSector = dgvGrillaFarmacia.CurrentRow.Cells.Item(0).Value
'                End If
'                lbltitulo1.Visible = True
'                lbltitulo2.Visible = True
'                lbltitulo3.Visible = False
'                lbltitulo1.Text = "Medicamentos"
'                lbltitulo2.Text = "Insumos"
'                dgvGrillaFarmacia.Width = 431
'                dgvGrillaFarmacia2.Visible = True
'                btnAgregar.Visible = False
'                btnEliminar.Visible = False
'                btnModificar.Text = "Agregar Insumo"
'                btnModificar.Visible = True
'                sql = "select M.IdMedicamento, P.Nombre'Nombre Proveedor', M.Nombre'Nombre Medicamento', M.Presen Presentacion from Medicamento M, Proveedor P Where M.Activo=true and M.IdProv=P.IdProv"
'                dgvGrillaFarmacia.DataSource = ConsultaDG("Medicamentos")
'                dgvGrillaFarmacia.Columns(0).Visible = False
'                sql = "select I.IdInsumo,I.Nombre 'Nombre Insumo' , P.Nombre 'Nombre Proveedor' from Insumo I, Proveedor P, Insumo_Proveedor IP Where I.Activo=true and I.IdInsumo=IP.IdInsumo and IP.IdProv=P.IdProv"
'                dgvGrillaFarmacia2.DataSource = ConsultaDG("Insumos")
'                dgvGrillaFarmacia2.Columns(0).Visible = False
'                btnEliminar2.Text = "Cancelar"
'                btnAgregar2.Text = "Agregar Medicamento"

'            ElseIf btnEliminar2.Text = "Eliminar medicamento del sector" Then
'                sql = "select nombre from sector where idSector=" & IdSector
'                rs = Consulta()
'                rs.Read()
'                Opc = MsgBox("¿Esta seguro que desea eliminar este medicamento al sector " & rs.Item(0) & "?", vbYesNo)
'                If Opc = 6 Then
'                    If IsNothing(dgvGrillaFarmacia.CurrentRow) Then
'                        sql = "delete from medicamento_sector where idSector= " & IdSector & " and idMedicamento= " & dgvGrillaFarmacia.Rows(0).Cells.Item(0).Value
'                    Else
'                        sql = "delete from medicamento_sector where idSector= " & IdSector & " and idMedicamento= " & dgvGrillaFarmacia.CurrentRow.Cells.Item(0).Value
'                    End If

'                    Consulta()
'                    MsgBox("Se ha eliminado el medicamento del sector elegido")
'                    mostrarSector()
'                End If
'            Else
'                mostrarSector()
'            End If
'        End If

'        dgvGrillaFarmacia.Refresh()
'    End Sub
'    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
'        Dim Opc As Integer
'        Dim elementoABorrar As Integer
'        Dim nombre As String
'        If T = "MyI" Then
'            If IsNothing(dgvGrillaFarmacia2.CurrentRow) Then
'                nombre = dgvGrillaFarmacia2.Rows(0).Cells.Item(4).Value
'                elementoABorrar = dgvGrillaFarmacia2.Rows(0).Cells.Item(0).Value
'            Else
'                nombre = dgvGrillaFarmacia2.CurrentRow.Cells.Item(4).Value
'                elementoABorrar = dgvGrillaFarmacia2.CurrentRow.Cells.Item(0).Value
'            End If

'            Opc = MsgBox("Esta seguro que desea eliminar" & dgvGrillaFarmacia2.CurrentRow.Cells.Item(2).Value, vbYesNo)
'            If (Opc = 6) Then

'                sql = "update Insumo set Activo=false Where IdInsumo=" & elementoABorrar
'                Consulta()
'                MsgBox(nombre & " fue eliminado")

'            End If
'        End If

'        dgvGrillaFarmacia2.Refresh()
'    End Sub

'    Private Sub btnAgregar2_Click(sender As Object, e As EventArgs) Handles btnAgregar2.Click
'        If (T = "MyI") Then
'            Me.Hide()
'            FormularioMedicamentos.CodigoMed = 0
'            FormularioMedicamentos.cboProveedores.Enabled = True
'            FormularioMedicamentos.Show()
'            FormularioMedicamentos.btnAccion.Text = "Registrar Medicamento"
'        End If
'        If (T = "Proveedor") Then
'            Me.Hide()
'            FormularioProveedor.CodigoProv = 0
'            FormularioProveedor.Show()
'            FormularioProveedor.btnAccion.Text = "Registrar Proveedor"
'        End If
'        If (T = "Pedido") Then
'            Dim CodigoPed As Integer
'            If btnAgregar2.Text <> "Cancelar" Then
'                If IsNothing(dgvGrillaFarmacia.CurrentRow) Then
'                    CodigoPed = dgvGrillaFarmacia.Rows(0).Cells.Item(0).Value
'                Else
'                    CodigoPed = dgvGrillaFarmacia.CurrentRow.Cells.Item(0).Value
'                End If
'                lbltitulo1.Visible = True
'                lbltitulo2.Visible = True
'                lbltitulo3.Visible = False
'                lbltitulo1.Text = "Insumos Faltantes"
'                lbltitulo2.Text = "Medicamentos Faltantes"
'                dgvGrillaFarmacia.Width = 431
'                dgvGrillaFarmacia2.Visible = True
'                btnAgregar2.Visible = True
'                btnModificar2.Visible = False
'                btnEliminar2.Visible = False
'                btnAgregar2.Text = "Cancelar"

'                btnAgregar.Visible = False
'                btnModificar.Visible = False
'                btnEliminar.Visible = False
'                sql = "select DP.IdDetPedI, I.IdInsumo, I.Nombre 'Insumo' ,DP.Cantidad 'Cantidad Pedida', DP.Resto 'Cantidad Faltante' from Insumo I, Pedido P, DetPedidoIns DP Where DP.IdPedido=P.IdPedido and I.IdInsumo=DP.IdInsumo  and DP.IdPedido=" & CodigoPed
'                dgvGrillaFarmacia.DataSource = ConsultaDG("DetPedidoI")
'                dgvGrillaFarmacia.Columns(0).Visible = False
'                dgvGrillaFarmacia.Columns(1).Visible = False
'                sql = "select DP.IdDetPedM, M.IdMedicamento, M.Nombre 'Medicamento' ,M.Presen, DP.Cantidad 'Cantidad Pedida', DP.Resto 'Cantidad Faltante' from Medicamento M, Pedido P, DetPedidoMed DP Where DP.IdPedido=P.IdPedido and M.IdMedicamento=DP.IdMedicamento and DP.IdPedido=" & CodigoPed
'                dgvGrillaFarmacia2.DataSource = ConsultaDG("DetPedidoM")
'                dgvGrillaFarmacia2.Columns(0).Visible = False
'                dgvGrillaFarmacia2.Columns(1).Visible = False
'            Else
'                MostrarPedidos()
'            End If
'        End If
'        If (T = "Paquete") Then
'            Dim CodigoPed As Integer
'            If btnAgregar2.Text <> "Cancelar" Then
'                If IsNothing(dgvGrillaFarmacia.CurrentRow) Then
'                    CodigoPed = dgvGrillaFarmacia.Rows(0).Cells.Item(2).Value
'                Else
'                    CodigoPed = dgvGrillaFarmacia.CurrentRow.Cells.Item(2).Value
'                End If
'                lbltitulo1.Visible = True
'                lbltitulo2.Visible = True
'                lbltitulo3.Visible = False
'                lbltitulo1.Text = "Insumos Faltantes"
'                lbltitulo2.Text = "Medicamentos Faltantes"
'                dgvGrillaFarmacia.Width = 431
'                dgvGrillaFarmacia2.Visible = True
'                btnAgregar2.Visible = True
'                btnModificar2.Visible = False
'                btnEliminar2.Visible = False
'                btnAgregar2.Text = "Cancelar"

'                btnAgregar.Visible = False
'                btnModificar.Visible = False
'                btnEliminar.Visible = False
'                sql = "select DP.IdDetPedI, I.IdInsumo, I.Nombre 'Insumo' ,DP.Cantidad 'Cantidad Pedida', DP.Resto 'Cantidad Faltante' from Insumo I, Pedido P, DetPedidoIns DP Where DP.IdPedido=P.IdPedido and I.IdInsumo=DP.IdInsumo and DP.Recibido=0 and DP.IdPedido=" & CodigoPed
'                dgvGrillaFarmacia.DataSource = ConsultaDG("DetPedidoI")
'                dgvGrillaFarmacia.Columns(0).Visible = False
'                dgvGrillaFarmacia.Columns(1).Visible = False
'                sql = "select DP.IdDetPedM, M.IdMedicamento, M.Nombre 'Medicamento' ,M.Presen, DP.Cantidad 'Cantidad Pedida', DP.Resto 'Cantidad Faltante' from Medicamento M, Pedido P, DetPedidoMed DP Where DP.IdPedido=P.IdPedido and M.IdMedicamento=DP.IdMedicamento and DP.Recibido=0 and DP.IdPedido=" & CodigoPed
'                dgvGrillaFarmacia2.DataSource = ConsultaDG("DetPedidoM")
'                dgvGrillaFarmacia2.Columns(0).Visible = False
'                dgvGrillaFarmacia2.Columns(1).Visible = False
'            Else
'                MostrarPaquete()
'            End If
'        End If
'        If T = "FacturaProveedor" Then
'            Dim IdOrdComp As Integer


'            If btnEliminar2.Text <> "Cancelar" Then
'                If IsNothing(dgvGrillaFarmacia.CurrentRow) Then
'                    IdOrdComp = dgvGrillaFarmacia.Rows(0).Cells.Item(2).Value
'                Else
'                    IdOrdComp = dgvGrillaFarmacia.CurrentRow.Cells.Item(2).Value

'                End If
'                Me.Hide()
'                FormularioRemitoProveedor.Show()

'            Else
'                mostrarRemyFac()
'            End If
'        End If
'        If (T = "Articulo Sector") Then
'            If btnAgregar2.Text = "Eliminar articulos del Sector" Then
'                If IsNothing(dgvGrillaFarmacia.CurrentRow) Then

'                    IdSector = dgvGrillaFarmacia.Rows(0).Cells.Item(0).Value
'                Else
'                    IdSector = dgvGrillaFarmacia.CurrentRow.Cells.Item(0).Value
'                End If
'                sql = "select count(*) from insumo_Sector where idSector=" & IdSector
'                rs = Consulta()
'                rs.Read()
'                If rs.Item(0) = 0 Then
'                    dgvGrillaFarmacia2.Visible = False
'                    btnModificar.Visible = False
'                    lbltitulo2.Visible = False
'                    sql = "select count(*) from medicamento_Sector where idSector=" & IdSector
'                    rs = Consulta()
'                    rs.Read()
'                Else
'                    dgvGrillaFarmacia2.Visible = True
'                    btnModificar.Visible = True
'                    lbltitulo2.Visible = True
'                    sql = "select I.IdInsumo,I.Nombre 'Nombre Insumo'  from Insumo I, Sector S, insumo_Sector SI Where I.Activo=true and I.IdInsumo=SI.IdInsumo and SI.IdSector=S.IdSector and s.IdSector=" & IdSector
'                    dgvGrillaFarmacia2.DataSource = ConsultaDG("Insumos")
'                    dgvGrillaFarmacia2.Columns(0).Visible = False
'                    sql = "select count(*) from medicamento_Sector where idSector=" & IdSector
'                    rs = Consulta()
'                    rs.Read()
'                End If
'                If rs.Item(0) = 0 Then
'                    If dgvGrillaFarmacia2.Visible = True Then
'                        lbltitulo1.Visible = False
'                        dgvGrillaFarmacia.Visible = False
'                        btnAgregar.Visible = False

'                        btnEliminar.Visible = False
'                        btnAgregar2.Text = "Cancelar"
'                        btnEliminar.Text = "Eliminar medicamento del sector"
'                        btnEliminar2.Visible = False
'                        btnModificar.Text = "Eliminar insumo del sector"
'                    Else
'                        MsgBox("El sector no posee insumos o medicamentos cargados")
'                        mostrarSector()
'                    End If


'                Else
'                    lbltitulo1.Visible = True
'                    lbltitulo3.Visible = False
'                    lbltitulo1.Text = "Medicamentos"
'                    lbltitulo2.Text = "Insumos"
'                    dgvGrillaFarmacia.Width = 431

'                    btnAgregar.Visible = False

'                    btnEliminar.Visible = False
'                    btnModificar.Text = "Eliminar insumo del sector"
'                    sql = "select M.IdMedicamento, M.Nombre'Nombre Medicamento', M.Presen Presentacion from Medicamento M, Sector S, medicamento_Sector MS Where M.Activo=true and M.IdMedicamento=MS.IdMedicamento and S.IdSector=MS.IdSector and s.IdSector=" & IdSector
'                    dgvGrillaFarmacia.DataSource = ConsultaDG("Medicamentos")
'                    dgvGrillaFarmacia.Columns(0).Visible = False
'                    btnAgregar2.Text = "Cancelar"
'                    btnEliminar2.Text = "Eliminar medicamento del sector"
'                End If
'            ElseIf btnAgregar2.Text = "Agregar Medicamento" Then
'                FormularioArticuloSector.idSector = IdSector
'                If IsNothing(dgvGrillaFarmacia.CurrentRow) Then

'                    FormularioArticuloSector.idArticulo = dgvGrillaFarmacia.Rows(0).Cells.Item(0).Value
'                Else
'                    FormularioArticuloSector.idArticulo = dgvGrillaFarmacia.CurrentRow.Cells.Item(0).Value
'                End If
'                sql = "select nombre from sector where idSector=" & IdSector
'                rs = Consulta()
'                rs.Read()
'                opc = MsgBox("¿Esta seguro que desea agregar este medicamento al sector " & rs.Item(0) & "?", vbYesNo)
'                If opc = 6 Then

'                    FormularioArticuloSector.lblTitulo.Text = "Registrar Medicamento Sector"
'                    FormularioArticuloSector.btnAccion.Text = "Agregar medicamento"
'                    Me.Hide()
'                    FormularioArticuloSector.Show()
'                End If
'            Else
'                mostrarSector()
'            End If
'        End If
'    End Sub
'    Private Sub MostrarPedidos()
'        lbltitulo1.Visible = True

'        lbltitulo2.Visible = True
'        lbltitulo3.Visible = False
'        lbltitulo1.Text = "Pedidos Sin Realizar"
'        lbltitulo2.Text = "Pedidos Entregados"
'        dgvGrillaFarmacia.Width = 431
'        dgvGrillaFarmacia2.Visible = True
'        btnAgregar2.Visible = True
'        btnModificar2.Visible = False
'        btnEliminar2.Visible = True
'        btnEliminar2.Text = "Realizar paquete del pedido"
'        btnAgregar2.Text = "Ver detalles del pedido"

'        btnAgregar.Visible = False
'        btnModificar.Visible = True
'        btnEliminar.Visible = False
'        btnModificar.Text = "Ver detalles del pedido"
'        sql = "Select Pe.IdPedido, S.Nombre'Sector', E.Nombre 'Empleado', Pe.Fecha from Pedido Pe, Sector S, Empleado E Where Pe.IdEmpleado=E.IdEmpleado and S.IdSector=Pe.IdSector and Pe.IdPedido Not in (Select IdPedido From Paquete)"
'        dgvGrillaFarmacia.DataSource = ConsultaDG("PedidosNuevos")
'        dgvGrillaFarmacia.Columns(0).Visible = False
'        sql = "select P.IdPedido, S.Nombre'Sector', E.Nombre 'Empleado', P.Fecha from Pedido P, Sector S, Empleado E Where P.IdEmpleado=E.IdEmpleado and S.IdSector=P.IdSector and P.IdPedido in (Select IdPedido From Paquete where Total=1 )"
'        dgvGrillaFarmacia2.DataSource = ConsultaDG("PedidosRealizados")
'        dgvGrillaFarmacia2.Columns(0).Visible = False
'    End Sub
'    Private Sub MostrarPaquete()
'        lbltitulo1.Visible = True

'        lbltitulo2.Visible = True
'        lbltitulo3.Visible = False
'        lbltitulo1.Text = "Paquetes con pendientes"
'        lbltitulo2.Text = "Paquetes Completos"
'        dgvGrillaFarmacia.Width = 431
'        dgvGrillaFarmacia2.Visible = True
'        btnAgregar2.Visible = True
'        btnModificar2.Visible = False
'        btnEliminar2.Visible = True
'        btnEliminar2.Text = "Realizar paquete del pedido"
'        btnAgregar2.Text = "Ver pedido del paquete"
'        btnAgregar.Visible = False
'        btnModificar.Visible = True
'        btnEliminar.Visible = False
'        btnModificar.Text = "Ver pedido del paquete"
'        sql = "select Pen.IdPend, P.IdPaq, P.IdPedido, Pen.Detalle from Paquete P, Pendientes Pen Where P.IdPaq=Pen.IdPaq "
'        dgvGrillaFarmacia.DataSource = ConsultaDG("Paquetes")
'        dgvGrillaFarmacia.Columns(0).Visible = False
'        sql = "select P.IdPaq, P.IdPedido, P.Detalle from Paquete P Where P.Total=1 "
'        dgvGrillaFarmacia2.DataSource = ConsultaDG("PaquetesCompletos")
'        dgvGrillaFarmacia2.Columns(0).Visible = False
'    End Sub
'    Private Sub mostrarRemyFac()
'        lbltitulo1.Visible = True

'        lbltitulo2.Visible = True
'        lbltitulo3.Visible = False
'        lbltitulo1.Text = "Remitos del Proveedor"
'        lbltitulo2.Text = "Facturas del Proveedor"
'        dgvGrillaFarmacia.Width = 431
'        dgvGrillaFarmacia2.Visible = True

'        btnAgregar.Visible = False
'        btnModificar.Visible = False
'        btnEliminar.Visible = False
'        btnModificar2.Visible = False
'        btnEliminar2.Visible = True
'        btnAgregar2.Visible = True
'        btnAgregar2.Text = "Registrar nuevo remito y factura"
'        btnEliminar2.Text = "Ver Orden de compra del Remito"

'        sql = "select R.IdRem, R.IdProv,R.IdORdComp, P.nombre 'Nombre Proveedor', R.FRem 'Fecha del Remito', OC.FOrdComp 'Fecha de la Orden de compra' from Remito r, Proveedor p, Ord_Comp OC where r.IdProv=p.IdProv and r.IdOrdComp=OC.IdOrdComp order by IdRem"
'        dgvGrillaFarmacia.DataSource = ConsultaDG("Remitos")
'        dgvGrillaFarmacia.Columns(0).Visible = False
'        dgvGrillaFarmacia.Columns(1).Visible = False
'        dgvGrillaFarmacia.Columns(2).Visible = False
'        sql = "select IdFactP, FP.IdProv, FP.IdRem,FP.CodFactp 'Codifo de Factura', p.Nombre 'Nombre Proveedor', Monto, FPago 'Fecha de Pago' from proveedor p, FactProv FP, Remito R where R.IdREm=FP.IdRem and FP.IdProv=P.IdProv"
'        dgvGrillaFarmacia2.DataSource = ConsultaDG("FactProv")
'        dgvGrillaFarmacia2.Columns(0).Visible = False
'        dgvGrillaFarmacia2.Columns(1).Visible = False
'        dgvGrillaFarmacia2.Columns(2).Visible = False
'    End Sub

'    Private Sub mostrarSector()
'        dgvGrillaFarmacia.Width = 934
'        lbltitulo1.Visible = False

'        lbltitulo2.Visible = False
'        lbltitulo3.Visible = True
'        lbltitulo3.Text = "Sectores"
'        dgvGrillaFarmacia2.Visible = False
'        dgvGrillaFarmacia.Visible = True
'        btnAgregar.Visible = False
'        btnModificar.Visible = False
'        btnEliminar.Visible = False
'        btnAgregar2.Visible = True
'        btnModificar2.Visible = False
'        btnEliminar2.Visible = True
'        btnAgregar2.Text = "Eliminar articulos del Sector"
'        btnEliminar2.Text = "Agregar articulos del Sector"
'        sql = "select idSector, nombre from Sector"
'        dgvGrillaFarmacia.DataSource = ConsultaDG("Sectores")
'        dgvGrillaFarmacia.Columns(0).Visible = False
'    End Sub

'    Private Sub GrillaFarmacia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

'    End Sub
'End Class
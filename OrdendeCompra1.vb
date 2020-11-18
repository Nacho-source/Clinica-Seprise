Imports System.Data.Odbc

Public Class OrdendeCompra1
    Dim eoff As Boolean = False
    Dim opc As Integer
    Dim rs As OdbcDataReader
    Dim cantidadInsumos As Integer
    Private Sub OrdendeCompra1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        blanquearFilas(0)
        sql = "select max(IdOrdComp)+1 from Ord_Comp"
        rs = Consulta()
        rs.Read()
        lblNOrdComp.Text = rs.Item(0)
        sql = "select curdate()"
        rs = Consulta()
        rs.Read()
        lblFechaI.Text = rs.Item(0)
        sql = "select nombre from Proveedor where Activo=1"
        rs = Consulta()
        Do While eoff = False
            If rs.Read() = True Then
                cboProveedor.Items.Add(rs.Item(0))
            Else
                eoff = True
            End If

        Loop
        eoff = False
    End Sub
    Private Sub txtCant1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtCant2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtCant3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtCant4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant4.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtCant5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant5.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtCant6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant6.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtCant7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant7.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCant8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant8.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboProveedor.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboMaterial1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMaterial1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboMaterial2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMaterial2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboMaterial3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMaterial3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboMaterial4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMaterial4.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboMaterial5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMaterial5.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboMaterial6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMaterial6.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboMaterial7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMaterial7.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboMaterial8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMaterial8.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        If btnProveedor.Text = "Elegir" Then
            If cboProveedor.Text <> "Elija un Proveedor" Then

                sql = "select i.nombre from insumo i, proveedor p, Insumo_proveedor IP where I.Activo=1 and I.IdInsumo=IP.IdInsumo and P.IdProv=IP.IdProv and P.nombre='" & cboProveedor.Text & "'"
                rs = Consulta()
                cantidadInsumos = 0
                Do While eoff = False
                    If rs.Read() = True Then
                        cboMaterial1.Items.Add(rs.Item(0))
                        cantidadInsumos = cantidadInsumos + 1
                    Else
                        If cantidadInsumos = 0 Then
                            opc = MsgBox("No hay insumos de este proveedor, desea proceder a la carga de medicamentos ?", vbYesNo)
                        End If
                        eoff = True
                    End If
                Loop
                eoff = False
                If cantidadInsumos <> 0 Then
                    btnProveedor.Text = "Atras"
                    cboProveedor.Enabled = False
                    btnInsumo1.Enabled = True
                    cboMaterial1.Enabled = True
                    btnContinuar.Enabled = True
                Else
                    If (opc = 6) Then
                        cargarOdCParte2()
                        Me.Hide()
                        OrdendeCompra2.Show()
                    Else
                        MsgBox("Por favor, seleccione otro proveedor")
                        btnProveedor.Text = "Elegir"
                        cboProveedor.Enabled = True
                        cboProveedor.Text = "Elija un Proveedor"
                    End If
                End If
            Else
                    MsgBox("Por favor seleccione un proveedor")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnProveedor.Text = "Elegir"
                cboProveedor.Enabled = True
                cboProveedor.Text = "Elija un Proveedor"
                blanquearFilas(1)
            End If
        End If
    End Sub
    Private Sub btnInsumo1_Click(sender As Object, e As EventArgs) Handles btnInsumo1.Click
        If btnInsumo1.Text = "Elegir" Then
            If cboMaterial1.Text <> "Elija el insumo" Then
                sql = "select I.idInsumo, IP.precio from insumo i, Insumo_proveedor IP where I.IdInsumo=IP.IdInsumo and I.nombre='" & cboMaterial1.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        lblIdI1.Text = (rs.Item(0))
                        lblVU1.Text = (rs.Item(1))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnInsumo1.Text = "Atras"
                cboMaterial1.Enabled = False
                txtCant1.Enabled = True
                btnCant1.Enabled = True
            Else
                MsgBox("Por favor seleccione un insumo")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                cboMaterial1.Enabled = True
                btnInsumo1.Text = "Elegir"
                btnCant1.Text = "Elegir"
                txtCant1.Enabled = False
                btnCant1.Enabled = False
                txtCant1.Text = ""
                lblIdI1.Text = ""
                lblVU1.Text = ""
                lblVTT.Text = ""
                lblVT1.Text = ""
                blanquearFilas(2)
            End If
        End If
    End Sub
    Private Sub btnInsumo2_Click(sender As Object, e As EventArgs) Handles btnInsumo2.Click
        If btnInsumo2.Text = "Elegir" Then
            If cboMaterial2.Text <> "Elija el insumo" Then
                sql = "select I.idInsumo, IP.precio from insumo i, Insumo_proveedor IP where I.IdInsumo=IP.IdInsumo and I.nombre='" & cboMaterial2.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        lblIdI2.Text = (rs.Item(0))
                        lblVU2.Text = (rs.Item(1))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnInsumo2.Text = "Atras"
                cboMaterial2.Enabled = False
                txtCant2.Enabled = True
                btnCant2.Enabled = True
            Else
                MsgBox("Por favor seleccione un insumo")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                cboMaterial2.Enabled = True
                btnInsumo2.Text = "Elegir"

                txtCant2.Enabled = False
                btnCant2.Enabled = False
                btnCant2.Text = "Elegir"
                txtCant2.Text = ""
                lblIdI2.Text = ""
                lblVU2.Text = ""
                lblVT2.Text = ""
                lblVTT.Text = Int(lblVT1.Text)

                blanquearFilas(3)
            End If
        End If
    End Sub
    Private Sub btnInsumo3_Click(sender As Object, e As EventArgs) Handles btnInsumo3.Click
        If btnInsumo3.Text = "Elegir" Then
            If cboMaterial3.Text <> "Elija el insumo" Then
                sql = "select I.idInsumo, IP.precio from insumo i, Insumo_proveedor IP where I.IdInsumo=IP.IdInsumo and I.nombre='" & cboMaterial3.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        lblIdI3.Text = (rs.Item(0))
                        lblVU3.Text = (rs.Item(1))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnInsumo3.Text = "Atras"
                cboMaterial3.Enabled = False
                txtCant3.Enabled = True
                btnCant3.Enabled = True
            Else
                MsgBox("Por favor seleccione un insumo")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                cboMaterial3.Enabled = True
                btnInsumo3.Text = "Elegir"

                txtCant3.Enabled = False
                btnCant3.Enabled = False
                btnCant3.Text = "Elegir"
                txtCant3.Text = ""
                lblIdI3.Text = ""
                lblVU3.Text = ""
                lblVT3.Text = ""
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text)

                blanquearFilas(4)
            End If
        End If
    End Sub
    Private Sub btnInsumo4_Click(sender As Object, e As EventArgs) Handles btnInsumo4.Click
        If btnInsumo4.Text = "Elegir" Then
            If cboMaterial4.Text <> "Elija el insumo" Then
                sql = "select I.idInsumo, IP.precio from insumo i, Insumo_proveedor IP where I.IdInsumo=IP.IdInsumo and I.nombre='" & cboMaterial4.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        lblIdI4.Text = (rs.Item(0))
                        lblVU4.Text = (rs.Item(1))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnInsumo4.Text = "Atras"
                cboMaterial4.Enabled = False
                txtCant4.Enabled = True
                btnCant4.Enabled = True
            Else
                MsgBox("Por favor seleccione un insumo")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                cboMaterial4.Enabled = True
                btnInsumo4.Text = "Elegir"
                btnCant4.Text = "Elegir"
                txtCant4.Enabled = False
                btnCant4.Enabled = False
                txtCant4.Text = ""
                lblIdI4.Text = ""
                lblVU4.Text = ""
                lblVT4.Text = ""
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text)

                blanquearFilas(5)
            End If
        End If
    End Sub
    Private Sub btnInsumo5_Click(sender As Object, e As EventArgs) Handles btnInsumo5.Click
        If btnInsumo5.Text = "Elegir" Then
            If cboMaterial5.Text <> "Elija el insumo" Then
                sql = "select I.idInsumo, IP.precio from insumo i, Insumo_proveedor IP where I.IdInsumo=IP.IdInsumo and I.nombre='" & cboMaterial5.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        lblIdI5.Text = (rs.Item(0))
                        lblVU5.Text = (rs.Item(1))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnInsumo5.Text = "Atras"
                cboMaterial5.Enabled = False
                txtCant5.Enabled = True
                btnCant5.Enabled = True
            Else
                MsgBox("Por favor seleccione un insumo")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                cboMaterial5.Enabled = True
                btnInsumo5.Text = "Elegir"
                btnCant5.Text = "Elegir"
                txtCant5.Enabled = False
                btnCant5.Enabled = False
                txtCant5.Text = ""
                lblIdI5.Text = ""
                lblVU5.Text = ""
                lblVT5.Text = ""
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text)

                blanquearFilas(6)
            End If
        End If
    End Sub
    Private Sub btnInsumo6_Click(sender As Object, e As EventArgs) Handles btnInsumo6.Click
        If btnInsumo6.Text = "Elegir" Then
            If cboMaterial6.Text <> "Elija el insumo" Then
                sql = "select I.idInsumo, IP.precio from insumo i, Insumo_proveedor IP where I.IdInsumo=IP.IdInsumo and I.nombre='" & cboMaterial6.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        lblIdI6.Text = (rs.Item(0))
                        lblVU6.Text = (rs.Item(1))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnInsumo6.Text = "Atras"
                cboMaterial6.Enabled = False
                txtCant6.Enabled = True
                btnCant6.Enabled = True
            Else
                MsgBox("Por favor seleccione un insumo")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                cboMaterial6.Enabled = True
                btnInsumo6.Text = "Elegir"
                btnCant6.Text = "Elegir"
                txtCant6.Enabled = False
                btnCant6.Enabled = False
                txtCant6.Text = ""
                lblIdI6.Text = ""
                lblVU6.Text = ""
                lblVT6.Text = ""
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text)

                blanquearFilas(7)
            End If
        End If
    End Sub
    Private Sub btnInsumo7_Click(sender As Object, e As EventArgs) Handles btnInsumo7.Click
        If btnInsumo7.Text = "Elegir" Then
            If cboMaterial7.Text <> "Elija el insumo" Then
                sql = "select I.idInsumo, IP.precio from insumo i, Insumo_proveedor IP where I.IdInsumo=IP.IdInsumo and I.nombre='" & cboMaterial7.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        lblIdI7.Text = (rs.Item(0))
                        lblVU7.Text = (rs.Item(1))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnInsumo7.Text = "Atras"
                cboMaterial7.Enabled = False
                txtCant7.Enabled = True
                btnCant7.Enabled = True
            Else
                MsgBox("Por favor seleccione un insumo")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                cboMaterial7.Enabled = True
                btnInsumo7.Text = "Elegir"
                btnCant7.Text = "Elegir"
                txtCant7.Enabled = False
                btnCant7.Enabled = False
                txtCant7.Text = ""
                lblIdI7.Text = ""
                lblVU7.Text = ""
                lblVT7.Text = ""
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text)

                blanquearFilas(8)
            End If
        End If
    End Sub
    Private Sub btnInsumo8_Click(sender As Object, e As EventArgs) Handles btnInsumo8.Click
        If btnInsumo8.Text = "Elegir" Then
            If cboMaterial8.Text <> "Elija el insumo" Then
                sql = "select I.idInsumo, IP.precio from insumo i, Insumo_proveedor IP where I.IdInsumo=IP.IdInsumo and I.nombre='" & cboMaterial8.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        lblIdI8.Text = (rs.Item(0))
                        lblVU8.Text = (rs.Item(1))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnInsumo1.Text = "Atras"
                cboMaterial8.Enabled = False
                txtCant8.Enabled = True
                btnCant8.Enabled = True
            Else
                MsgBox("Por favor seleccione un insumo")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                cboMaterial8.Enabled = True
                btnInsumo8.Text = "Elegir"
                btnCant8.Text = "Elegir"
                txtCant8.Enabled = False
                btnCant8.Enabled = False
                txtCant8.Text = ""
                lblIdI8.Text = ""
                lblVU8.Text = ""
                lblVT8.Text = ""
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text) + Int(lblVT7.Text)

            End If
        End If
    End Sub

    Private Sub btnCant1_Click(sender As Object, e As EventArgs) Handles btnCant1.Click
        If btnCant1.Text = "Elegir" Then
            If txtCant1.Text <> "" Then
                If Int(txtCant1.Text) <> 0 Then
                    lblVT1.Text = Int(txtCant1.Text) * Int(lblVU1.Text)
                    lblVTT.Text = Int(lblVT1.Text)
                    btnCant1.Text = "Atras"
                    sql = "select i.nombre from insumo i, proveedor p, Insumo_proveedor IP where I.Activo and I.IdInsumo=IP.IdInsumo and P.IdProv=IP.IdProv and P.nombre='" & cboProveedor.Text & "' and I.nombre <> '" & cboMaterial1.Text & "'"
                    rs = Consulta()
                    cantidadInsumos = 0
                    Do While eoff = False
                        If rs.Read() = True Then
                            cboMaterial2.Items.Add(rs.Item(0))
                            cantidadInsumos = cantidadInsumos + 1
                        Else
                            If cantidadInsumos = 0 Then
                                MsgBox("Ya no quedan mas insumos, para el proveedor elegido")
                                opc = MsgBox("¿Desea pasar a la carga de medicamentos?", vbYesNo)
                            End If
                            eoff = True
                        End If
                    Loop
                    eoff = False
                    If cantidadInsumos = 0 Then

                        If opc = 6 Then
                            cargarOdCParte2()
                            Me.Hide()
                            OrdendeCompra2.Show()
                        End If
                        txtCant1.Enabled = False
                    Else
                        txtCant1.Enabled = False
                        btnInsumo2.Enabled = True
                        cboMaterial2.Enabled = True
                    End If
                Else
                    MsgBox("Por favor ingrese una cantidad mayor a 0")
                End If
            Else
                    MsgBox("Por favor ingrese una cantidad")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnCant1.Text = "Elegir"
                txtCant1.Enabled = True
                txtCant1.Text = ""
                lblVT1.Text = ""
                lblVTT.Text = ""
                blanquearFilas(2)
            End If
        End If
    End Sub


    Private Sub btnCant2_Click(sender As Object, e As EventArgs) Handles btnCant2.Click
        If btnCant2.Text = "Elegir" Then
            If txtCant2.Text <> "" Then

                If Int(txtCant2.Text) <> 0 Then
                    lblVT2.Text = Int(txtCant2.Text) * Int(lblVU2.Text)
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text)
                    btnCant2.Text = "Atras"

                    sql = "select i.nombre from insumo i, proveedor p, Insumo_proveedor IP where I.Activo and I.IdInsumo=IP.IdInsumo and P.IdProv=IP.IdProv and P.nombre='" & cboProveedor.Text & "' and I.Nombre <> '" & cboMaterial1.Text & "' and I.Nombre <> '" & cboMaterial2.Text & "'"
                    rs = Consulta()
                    cantidadInsumos = 0
                    Do While eoff = False
                        If rs.Read() = True Then
                            cboMaterial3.Items.Add(rs.Item(0))
                            cantidadInsumos = cantidadInsumos + 1
                        Else
                            If cantidadInsumos = 0 Then
                                MsgBox("Ya no quedan mas insumos, para el proveedor elegido")
                                opc = MsgBox("¿Desea pasar a la carga de medicamentos?", vbYesNo)
                            End If
                            eoff = True
                        End If
                    Loop
                    eoff = False

                    If cantidadInsumos = 0 Then

                        If opc = 6 Then
                            cargarOdCParte2()
                            Me.Hide()
                            OrdendeCompra2.Show()
                        End If
                        txtCant2.Enabled = False
                    Else
                        txtCant2.Enabled = False
                        btnInsumo3.Enabled = True
                        cboMaterial3.Enabled = True
                    End If
                Else
                    MsgBox("Por favor ingrese una cantidad mayor a 0")
                End If
            Else
                    MsgBox("Por favor ingrese una cantidad")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnCant2.Text = "Elegir"
                txtCant2.Enabled = True
                txtCant2.Text = ""
                lblVT2.Text = ""
                lblVTT.Text = Int(lblVT1.Text)
                blanquearFilas(3)
            End If
        End If
    End Sub
    Private Sub btnCant3_Click(sender As Object, e As EventArgs) Handles btnCant3.Click
        If btnCant3.Text = "Elegir" Then
            If txtCant3.Text <> "" Then

                If Int(txtCant3.Text) <> 0 Then
                    lblVT3.Text = Int(txtCant3.Text) * Int(lblVU3.Text)
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text)
                    btnCant3.Text = "Atras"

                    sql = "select i.nombre from insumo i, proveedor p, Insumo_proveedor IP where I.Activo and I.IdInsumo=IP.IdInsumo and P.IdProv=IP.IdProv and P.nombre='" & cboProveedor.Text & "' and I.Nombre <> '" & cboMaterial1.Text & "' and I.Nombre <> '" & cboMaterial2.Text & "' and I.Nombre <> '" & cboMaterial3.Text & "'"
                    rs = Consulta()
                    cantidadInsumos = 0
                    Do While eoff = False
                        If rs.Read() = True Then
                            cboMaterial4.Items.Add(rs.Item(0))
                            cantidadInsumos = cantidadInsumos + 1
                        Else
                            If cantidadInsumos = 0 Then
                                MsgBox("Ya no quedan mas insumos, para el proveedor elegido")
                                opc = MsgBox("¿Desea pasar a la carga de medicamentos?", vbYesNo)
                            End If
                            eoff = True
                        End If
                    Loop
                    eoff = False

                    If cantidadInsumos = 0 Then

                        If opc = 6 Then
                            cargarOdCParte2()
                            Me.Hide()
                            OrdendeCompra2.Show()
                        End If
                        txtCant3.Enabled = False
                    Else
                        txtCant3.Enabled = False
                        btnInsumo4.Enabled = True
                        cboMaterial4.Enabled = True
                    End If
                Else
                    MsgBox("Por favor ingrese una cantidad mayor a 0")
                End If

            Else
                    MsgBox("Por favor ingrese una cantidad")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnCant3.Text = "Elegir"
                txtCant3.Enabled = True
                txtCant3.Text = ""
                lblVT3.Text = ""
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text)
                blanquearFilas(4)
            End If
        End If
    End Sub

    Private Sub btnCant4_Click(sender As Object, e As EventArgs) Handles btnCant4.Click
        If btnCant4.Text = "Elegir" Then
            If txtCant4.Text <> "" Then
                If Int(txtCant4.Text) <> 0 Then
                    lblVT4.Text = Int(txtCant4.Text) * Int(lblVU4.Text)
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text)
                    btnCant4.Text = "Atras"

                    sql = "select i.nombre from insumo i, proveedor p, Insumo_proveedor IP where I.Activo and I.IdInsumo=IP.IdInsumo and P.IdProv=IP.IdProv and P.nombre='" & cboProveedor.Text & "' and I.Nombre <> '" & cboMaterial1.Text & "' and I.Nombre <> '" & cboMaterial2.Text & "' and I.Nombre <> '" & cboMaterial3.Text & "' and I.Nombre <> '" & cboMaterial4.Text & "'"
                    rs = Consulta()
                    cantidadInsumos = 0
                    Do While eoff = False
                        If rs.Read() = True Then
                            cboMaterial5.Items.Add(rs.Item(0))
                            cantidadInsumos = cantidadInsumos + 1
                        Else
                            If cantidadInsumos = 0 Then
                                MsgBox("Ya no quedan mas insumos, para el proveedor elegido")
                                opc = MsgBox("¿Desea pasar a la carga de medicamentos?", vbYesNo)
                            End If
                            eoff = True
                        End If
                    Loop
                    eoff = False

                    If cantidadInsumos = 0 Then

                        If opc = 6 Then
                            cargarOdCParte2()
                            Me.Hide()
                            OrdendeCompra2.Show()
                        End If
                        txtCant4.Enabled = False
                    Else
                        txtCant4.Enabled = False
                        btnInsumo5.Enabled = True
                        cboMaterial5.Enabled = True
                    End If
                Else
                    MsgBox("Por favor ingrese una cantidad mayor a 0")
                End If
            Else
                    MsgBox("Por favor ingrese una cantidad")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnCant4.Text = "Elegir"
                txtCant4.Enabled = True
                txtCant4.Text = ""
                lblVT4.Text = ""
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text)
                blanquearFilas(5)
            End If
        End If
    End Sub

    Private Sub btnCant5_Click(sender As Object, e As EventArgs) Handles btnCant5.Click
        If btnCant5.Text = "Elegir" Then
            If txtCant5.Text <> "" Then

                If Int(txtCant5.Text) <> 0 Then
                    lblVT5.Text = Int(txtCant5.Text) * Int(lblVU5.Text)
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text)
                    btnCant5.Text = "Atras"

                    sql = "select i.nombre from insumo i, proveedor p, Insumo_proveedor IP where I.Activo and I.IdInsumo=IP.IdInsumo and P.IdProv=IP.IdProv and P.nombre='" & cboProveedor.Text & "' and I.Nombre <> '" & cboMaterial1.Text & "' and I.Nombre <> '" & cboMaterial2.Text & "' and I.Nombre <> '" & cboMaterial3.Text & "' and I.Nombre <> '" & cboMaterial4.Text & "'and I.Nombre <> '" & cboMaterial5.Text & "'"
                    rs = Consulta()
                    cantidadInsumos = 0
                    Do While eoff = False
                        If rs.Read() = True Then
                            cboMaterial6.Items.Add(rs.Item(0))
                            cantidadInsumos = cantidadInsumos + 1
                        Else
                            If cantidadInsumos = 0 Then
                                MsgBox("Ya no quedan mas insumos, para el proveedor elegido")
                                opc = MsgBox("¿Desea pasar a la carga de medicamentos?", vbYesNo)
                            End If
                            eoff = True
                        End If
                    Loop
                    eoff = False

                    If cantidadInsumos = 0 Then

                        If opc = 6 Then
                            cargarOdCParte2()
                            Me.Hide()
                            OrdendeCompra2.Show()
                        End If
                        txtCant5.Enabled = False
                    Else
                        txtCant5.Enabled = False
                        btnInsumo6.Enabled = True
                        cboMaterial6.Enabled = True
                    End If
                Else
                    MsgBox("Por favor ingrese una cantidad mayor a 0")
                End If
            Else
                    MsgBox("Por favor ingrese una cantidad")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnCant5.Text = "Elegir"
                txtCant5.Enabled = True
                txtCant5.Text = ""
                lblVT5.Text = ""
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text)
                blanquearFilas(6)
            End If
        End If
    End Sub

    Private Sub btnCant6_Click(sender As Object, e As EventArgs) Handles btnCant6.Click
        If btnCant6.Text = "Elegir" Then
            If txtCant6.Text <> "" Then

                If Int(txtCant6.Text) <> 0 Then
                    lblVT6.Text = Int(txtCant6.Text) * Int(lblVU6.Text)
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text)
                    btnCant6.Text = "Atras"

                    sql = "select i.nombre from insumo i, proveedor p, Insumo_proveedor IP where I.Activo and I.IdInsumo=IP.IdInsumo and P.IdProv=IP.IdProv and P.nombre='" & cboProveedor.Text & "' and I.Nombre <> '" & cboMaterial1.Text & "' and I.Nombre <> '" & cboMaterial2.Text & "' and I.Nombre <> '" & cboMaterial3.Text & "' and I.Nombre <> '" & cboMaterial4.Text & "'and I.Nombre <> '" & cboMaterial5.Text & "' and I.Nombre <> '" & cboMaterial5.Text & "'"
                    rs = Consulta()
                    cantidadInsumos = 0
                    Do While eoff = False
                        If rs.Read() = True Then
                            cboMaterial7.Items.Add(rs.Item(0))
                            cantidadInsumos = cantidadInsumos + 1
                        Else
                            If cantidadInsumos = 0 Then
                                MsgBox("Ya no quedan mas insumos, para el proveedor elegido")
                                opc = MsgBox("¿Desea pasar a la carga de medicamentos?", vbYesNo)
                            End If
                            eoff = True
                        End If
                    Loop
                    eoff = False

                    If cantidadInsumos = 0 Then

                        If opc = 6 Then
                            cargarOdCParte2()
                            Me.Hide()
                            OrdendeCompra2.Show()
                        End If
                        txtCant6.Enabled = False
                    Else
                        txtCant6.Enabled = False
                        btnInsumo7.Enabled = True
                        cboMaterial7.Enabled = True
                    End If
                Else
                    MsgBox("Por favor ingrese una cantidad mayor a 0")
                End If
            Else
                    MsgBox("Por favor ingrese una cantidad")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnCant6.Text = "Elegir"
                txtCant6.Enabled = True
                txtCant6.Text = ""
                lblVT6.Text = ""
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text)
                blanquearFilas(7)
            End If
        End If
    End Sub

    Private Sub btnCant7_Click(sender As Object, e As EventArgs) Handles btnCant7.Click
        If btnCant7.Text = "Elegir" Then
            If txtCant7.Text <> "" Then

                If Int(txtCant7.Text) <> 0 Then
                    lblVT7.Text = Int(txtCant7.Text) * Int(lblVU7.Text)
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text) + Int(lblVT7.Text)
                    btnCant7.Text = "Atras"

                    sql = "select i.nombre from insumo i, proveedor p, Insumo_proveedor IP where I.Activo and I.IdInsumo=IP.IdInsumo and P.IdProv=IP.IdProv and P.nombre='" & cboProveedor.Text & "' and I.Nombre <> '" & cboMaterial1.Text & "' and I.Nombre <> '" & cboMaterial2.Text & "' and I.Nombre <> '" & cboMaterial3.Text & "' and I.Nombre <> '" & cboMaterial4.Text & "'and I.Nombre <> '" & cboMaterial5.Text & "' and I.Nombre <> '" & cboMaterial6.Text & "' and I.Nombre <> '" & cboMaterial7.Text & "'"
                    rs = Consulta()
                    cantidadInsumos = 0
                    Do While eoff = False
                        If rs.Read() = True Then
                            cboMaterial8.Items.Add(rs.Item(0))
                            cantidadInsumos = cantidadInsumos + 1
                        Else
                            If cantidadInsumos = 0 Then
                                MsgBox("Ya no quedan mas insumos, para el proveedor elegido")
                                opc = MsgBox("¿Desea pasar a la carga de medicamentos?", vbYesNo)
                            End If
                            eoff = True
                        End If
                    Loop
                    eoff = False

                    If cantidadInsumos = 0 Then

                        If opc = 6 Then
                            cargarOdCParte2()
                            Me.Hide()
                            OrdendeCompra2.Show()
                        End If
                        txtCant7.Enabled = False
                    Else
                        txtCant7.Enabled = False
                        btnInsumo8.Enabled = True
                        cboMaterial8.Enabled = True
                    End If
                Else
                    MsgBox("Por favor ingrese una cantidad mayor a 0")
                End If
            Else
                    MsgBox("Por favor ingrese una cantidad")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnCant7.Text = "Elegir"
                txtCant7.Enabled = True
                txtCant7.Text = ""
                lblVT7.Text = ""
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text)
                blanquearFilas(8)
            End If
        End If
    End Sub

    Private Sub btnCant8_Click(sender As Object, e As EventArgs) Handles btnCant8.Click
        If btnCant8.Text = "Elegir" Then
            If txtCant8.Text <> "" Then

                If Int(txtCant8.Text) <> 0 Then
                    lblVT8.Text = Int(txtCant8.Text) * Int(lblVU8.Text)
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text) + Int(lblVT7.Text) + Int(lblVT8.Text)
                    btnCant8.Text = "Atras"
                    txtCant8.Enabled = False
                Else
                    MsgBox("Por favor ingrese una cantidad mayor a 0")
                End If
            Else
                    MsgBox("Por favor ingrese una cantidad")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnCant8.Text = "Elegir"
                txtCant8.Enabled = True
                txtCant8.Text = ""
                lblVT8.Text = ""
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text) + Int(lblVT7.Text)
            End If
        End If
    End Sub

    Public Sub blanquearFilas(ByVal i As Integer)
        If i = 0 Then
            btnProveedor.Text = "Elegir"
            cboProveedor.Enabled = True
            cboProveedor.Text = "Elija un Proveedor"
            btnContinuar.Enabled = False
            i = i + 1
        End If
        If i = 1 Then
            btnContinuar.Enabled = False
            lblIdI1.Text = ""
            txtCant1.Text = ""
            txtCant1.Enabled = False
            btnCant1.Enabled = False
            btnCant1.Text = "Elegir"
            btnInsumo1.Enabled = False
            btnInsumo1.Text = "Elegir"
            cboMaterial1.Text = "Elija el insumo"
            cboMaterial1.Enabled = False
            cboMaterial1.Items.Clear()
            lblVU1.Text = ""
            lblVT1.Text = ""
            lblVTT.Text = ""
            i = i + 1
        End If
        If i = 2 Then
            lblIdI2.Text = ""
            txtCant2.Text = ""
            txtCant2.Enabled = False
            btnCant2.Enabled = False
            btnCant2.Text = "Elegir"
            btnInsumo2.Enabled = False
            btnInsumo2.Text = "Elegir"
            cboMaterial2.Text = "Elija el insumo"
            cboMaterial2.Enabled = False
            cboMaterial2.Items.Clear()
            lblVU2.Text = ""
            lblVT2.Text = ""
            i = i + 1
        End If
        If i = 3 Then
            lblIdI3.Text = ""
            txtCant3.Text = ""
            txtCant3.Enabled = False
            btnCant3.Enabled = False
            btnCant3.Text = "Elegir"
            btnInsumo3.Enabled = False
            btnInsumo3.Text = "Elegir"
            cboMaterial3.Text = "Elija el insumo"
            cboMaterial3.Enabled = False
            cboMaterial3.Items.Clear()
            lblVU3.Text = ""
            lblVT3.Text = ""
            i = i + 1
        End If
        If i = 4 Then
            lblIdI4.Text = ""
            txtCant4.Text = ""
            txtCant4.Enabled = False
            btnCant4.Enabled = False
            btnCant4.Text = "Elegir"
            btnInsumo4.Enabled = False
            btnInsumo4.Text = "Elegir"
            cboMaterial4.Text = "Elija el insumo"
            cboMaterial4.Enabled = False
            cboMaterial4.Items.Clear()
            lblVU4.Text = ""
            lblVT4.Text = ""
            i = i + 1
        End If
        If i = 5 Then
            lblIdI5.Text = ""
            txtCant5.Text = ""
            txtCant5.Enabled = False
            btnCant5.Enabled = False
            btnCant5.Text = "Elegir"
            btnInsumo5.Enabled = False
            btnInsumo5.Text = "Elegir"
            cboMaterial5.Text = "Elija el insumo"
            cboMaterial5.Enabled = False
            cboMaterial5.Items.Clear()
            lblVU5.Text = ""
            lblVT5.Text = ""
            i = i + 1
        End If
        If i = 6 Then
            lblIdI6.Text = ""
            txtCant6.Text = ""
            txtCant6.Enabled = False
            btnCant6.Enabled = False
            btnCant6.Text = "Elegir"
            btnInsumo6.Enabled = False
            btnInsumo6.Text = "Elegir"
            cboMaterial6.Text = "Elija el insumo"
            cboMaterial6.Enabled = False
            cboMaterial6.Items.Clear()
            lblVU6.Text = ""
            lblVT6.Text = ""
            i = i + 1
        End If
        If i = 7 Then
            lblIdI7.Text = ""
            txtCant7.Text = ""
            txtCant7.Enabled = False
            btnCant7.Enabled = False
            btnCant7.Text = "Elegir"
            btnInsumo7.Enabled = False
            btnInsumo7.Text = "Elegir"
            cboMaterial7.Text = "Elija el insumo"
            cboMaterial7.Enabled = False
            cboMaterial7.Items.Clear()
            lblVU7.Text = ""
            lblVT7.Text = ""
            i = i + 1
        End If
        If i = 8 Then
            lblIdI8.Text = ""
            txtCant8.Text = ""
            txtCant8.Enabled = False
            btnCant8.Enabled = False
            btnCant8.Text = "Elegir"
            btnInsumo8.Enabled = False
            btnInsumo8.Text = "Elegir"
            cboMaterial8.Text = "Elija el insumo"
            cboMaterial8.Enabled = False
            cboMaterial8.Items.Clear()
            lblVU8.Text = ""
            lblVT8.Text = ""

        End If
    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        opc = MsgBox("¿Esta seguro que desea pasar a la carga de medicamentos?", vbYesNo)
        If opc = 6 Then
            cargarOdCParte2()
            Me.Hide()
            OrdendeCompra2.Show()
        End If
    End Sub
    Private Sub cargarOdCParte2()
        OrdendeCompra2.lblFechaI.Text = lblFechaI.Text
        OrdendeCompra2.lblProv.Text = cboProveedor.Text
        OrdendeCompra2.lblNOrdComp.Text = lblNOrdComp.Text
        If lblVTT.Text <> "" Then
            OrdendeCompra2.lblVTT.Text = lblVTT.Text
        Else
            OrdendeCompra2.lblVTT.Text = 0
        End If

        OrdendeCompra2.blanquearFilas(0, 0)
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        opc = MsgBox("¿Desea cancelar y volver atras, se borraran todos los datos?", vbYesNo)
        If opc = 6 Then
            Me.Hide()
            MenuFarmacia.Show()
        End If
    End Sub
End Class
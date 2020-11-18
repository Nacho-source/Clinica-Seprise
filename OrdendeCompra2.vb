Imports System.Data.Odbc

Public Class OrdendeCompra2
    Dim eoff As Boolean = False
    Dim opc As Integer
    Dim rs As OdbcDataReader
    Dim cantidadMedicamentos As Integer

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
    Private Sub cboPresentacion1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPresentacion1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboPresentacion2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPresentacion2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboPresentacion3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPresentacion3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboPresentacion4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPresentacion4.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboPresentacion5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPresentacion5.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboPresentacion6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPresentacion6.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboPresentacion7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPresentacion7.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cboPresentacion8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPresentacion8.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub btnMedicamento1_Click(sender As Object, e As EventArgs) Handles btnMedicamento1.Click
        If btnMedicamento1.Text = "Elegir" Then
            If cboMaterial1.Text <> "Elija el medicamento" Then
                sql = "select m.presen, m.nombre from medicamento m, proveedor p where m.IdProv=P.IdProv and p.nombre='" & lblProv.Text & "'and m.Activo =1 and m.nombre='" & cboMaterial1.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        cboPresentacion1.Items.Add(rs.Item(0))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnMedicamento1.Text = "Atras"
                cboMaterial1.Enabled = False
                cboPresentacion1.Enabled = True
                btnPresentacion1.Enabled = True
            Else
                MsgBox("Por favor seleccione un medicamento")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                cboMaterial1.Enabled = True
                btnMedicamento1.Text = "Elegir"
                cboMaterial1.Text = "Elija el medicamento"
                btnMedicamento1.Enabled = True
                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = 0
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text)
                End If
                blanquearFilas(1, 2)
            End If
        End If
    End Sub
    Private Sub btnMedicamento2_Click(sender As Object, e As EventArgs) Handles btnMedicamento2.Click
        If btnMedicamento2.Text = "Elegir" Then
            If cboMaterial2.Text <> "Elija el medicamento" Then
                sql = "select m.presen, m.nombre from medicamento m, proveedor p where m.IdProv=P.IdProv and p.nombre='" & lblProv.Text & "'and m.Activo =1 and m.nombre='" & cboMaterial2.Text & "' and (m.idMedicamento<> " & lblIdMed1.Text & ")"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        cboPresentacion2.Items.Add(rs.Item(0))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnMedicamento2.Text = "Atras"
                cboMaterial2.Enabled = False
                cboPresentacion2.Enabled = True
                btnPresentacion2.Enabled = True
            Else
                MsgBox("Por favor seleccione un medicamento")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                cboMaterial2.Enabled = True
                btnMedicamento2.Text = "Elegir"
                cboMaterial2.Text = "Elija el medicamento"
                btnMedicamento2.Enabled = True
                lblVTT.Text = Int(lblVT1.Text)

                blanquearFilas(2, 2)
            End If
        End If
    End Sub
    Private Sub btnMedicamento3_Click(sender As Object, e As EventArgs) Handles btnMedicamento3.Click
        If btnMedicamento3.Text = "Elegir" Then
            If cboMaterial3.Text <> "Elija el medicamento" Then
                sql = "select m.presen, m.nombre from medicamento m, proveedor p where m.IdProv=P.IdProv and p.nombre='" & lblProv.Text & "'and m.Activo =1 and m.nombre='" & cboMaterial3.Text & "' and (m.idMedicamento<> " & lblIdMed1.Text & " and m.idMedicamento<> " & lblIdMed2.Text & " )"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        cboPresentacion3.Items.Add(rs.Item(0))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnMedicamento3.Text = "Atras"
                cboMaterial3.Enabled = False
                cboPresentacion3.Enabled = True
                btnPresentacion3.Enabled = True
            Else
                MsgBox("Por favor seleccione un medicamento")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                cboMaterial3.Enabled = True
                btnMedicamento3.Text = "Elegir"

                cboMaterial3.Text = "Elija el medicamento"
                btnMedicamento3.Enabled = True
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text)

                blanquearFilas(3, 2)
            End If
        End If
    End Sub
    Private Sub btnMedicamento4_Click(sender As Object, e As EventArgs) Handles btnMedicamento4.Click
        If btnMedicamento4.Text = "Elegir" Then
            If cboMaterial4.Text <> "Elija el medicamento" Then
                sql = "select m.presen, m.nombre from medicamento m, proveedor p where m.IdProv=P.IdProv and p.nombre='" & lblProv.Text & "'and m.Activo =1 and m.nombre='" & cboMaterial4.Text & "' and (m.idMedicamento<> " & lblIdMed1.Text & " and m.idMedicamento<> " & lblIdMed2.Text & " and m.idMedicamento<> " & lblIdMed3.Text & ")"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        cboPresentacion4.Items.Add(rs.Item(0))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnMedicamento4.Text = "Atras"
                cboMaterial4.Enabled = False
                cboPresentacion4.Enabled = True
                btnPresentacion4.Enabled = True
            Else
                MsgBox("Por favor seleccione un medicamento")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                cboMaterial4.Enabled = True
                btnMedicamento4.Text = "Elegir"
                cboMaterial4.Text = "Elija el medicamento"
                btnMedicamento4.Enabled = True
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text)

                blanquearFilas(4, 2)
            End If
        End If
    End Sub
    Private Sub btnMedicamento5_Click(sender As Object, e As EventArgs) Handles btnMedicamento5.Click
        If btnMedicamento5.Text = "Elegir" Then
            If cboMaterial5.Text <> "Elija el medicamento" Then
                sql = "select m.presen, m.nombre from medicamento m, proveedor p where m.IdProv=P.IdProv and p.nombre='" & lblProv.Text & "'and m.Activo =1 and m.nombre='" & cboMaterial5.Text & "' and (m.idMedicamento<> " & lblIdMed1.Text & " and m.idMedicamento<> " & lblIdMed2.Text & " and m.idMedicamento<> " & lblIdMed3.Text & " and m.idMedicamento<> " & lblIdMed4.Text & ")"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        cboPresentacion5.Items.Add(rs.Item(0))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnMedicamento5.Text = "Atras"
                cboMaterial5.Enabled = False
                cboPresentacion5.Enabled = True
                btnPresentacion5.Enabled = True
            Else
                MsgBox("Por favor seleccione un medicamento")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                cboMaterial5.Enabled = True
                btnMedicamento5.Text = "Elegir"
                cboMaterial5.Text = "Elija el medicamento"
                btnMedicamento5.Enabled = True
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text)

                blanquearFilas(5, 2)
            End If
        End If
    End Sub
    Private Sub btnMedicamento6_Click(sender As Object, e As EventArgs) Handles btnMedicamento6.Click
        If btnMedicamento6.Text = "Elegir" Then
            If cboMaterial6.Text <> "Elija el medicamento" Then
                sql = "select m.presen, m.nombre from medicamento m, proveedor p where m.IdProv=P.IdProv and p.nombre='" & lblProv.Text & "'and m.Activo =1 and m.nombre='" & cboMaterial6.Text & "' and (m.idMedicamento<> " & lblIdMed1.Text & " and m.idMedicamento<> " & lblIdMed2.Text & " and m.idMedicamento<> " & lblIdMed3.Text & " and m.idMedicamento<> " & lblIdMed4.Text & " and m.idMedicamento<> " & lblIdMed5.Text & ")"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        cboPresentacion6.Items.Add(rs.Item(0))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnMedicamento6.Text = "Atras"
                cboMaterial6.Enabled = False
                cboPresentacion6.Enabled = True
                btnPresentacion6.Enabled = True
            Else
                MsgBox("Por favor seleccione un medicamento")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                cboMaterial6.Enabled = True
                btnMedicamento6.Text = "Elegir"
                cboMaterial6.Text = "Elija el medicamento"
                btnMedicamento6.Enabled = True
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text)

                blanquearFilas(6, 2)
            End If
        End If
    End Sub
    Private Sub btnMedicamento7_Click(sender As Object, e As EventArgs) Handles btnMedicamento7.Click
        If btnMedicamento7.Text = "Elegir" Then
            If cboMaterial7.Text <> "Elija el medicamento" Then
                sql = "select m.presen, m.nombre from medicamento m, proveedor p where m.IdProv=P.IdProv and p.nombre='" & lblProv.Text & "'and m.Activo =1 and m.nombre='" & cboMaterial7.Text & "' and (m.idMedicamento<> " & lblIdMed1.Text & " and m.idMedicamento<> " & lblIdMed2.Text & " and m.idMedicamento<> " & lblIdMed3.Text & " and m.idMedicamento<> " & lblIdMed4.Text & " and m.idMedicamento<> " & lblIdMed5.Text & " and m.idMedicamento<> " & lblIdMed6.Text & ")"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        cboPresentacion7.Items.Add(rs.Item(0))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnMedicamento7.Text = "Atras"
                cboMaterial7.Enabled = False
                cboPresentacion7.Enabled = True
                btnPresentacion7.Enabled = True
            Else
                MsgBox("Por favor seleccione un medicamento")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                cboMaterial7.Enabled = True
                btnMedicamento7.Text = "Elegir"
                cboMaterial7.Text = "Elija el medicamento"
                btnMedicamento7.Enabled = True
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text)

                blanquearFilas(7, 1)
            End If
        End If
    End Sub
    Private Sub btnMedicamento8_Click(sender As Object, e As EventArgs) Handles btnMedicamento8.Click
        If btnMedicamento8.Text = "Elegir" Then
            If cboMaterial8.Text <> "Elija el medicamento" Then
                sql = "select m.presen, m.nombre from medicamento m, proveedor p where m.IdProv=P.IdProv and p.nombre='" & lblProv.Text & "'and m.Activo =1 and m.nombre='" & cboMaterial8.Text & "' and (m.idMedicamento<> " & lblIdMed1.Text & " and m.idMedicamento<> " & lblIdMed2.Text & " and m.idMedicamento<> " & lblIdMed3.Text & " and m.idMedicamento<> " & lblIdMed4.Text & " and m.idMedicamento<> " & lblIdMed5.Text & " and m.idMedicamento<> " & lblIdMed6.Text & " and m.idMedicamento<> " & lblIdMed7.Text & ")"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        cboPresentacion8.Items.Add(rs.Item(0))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnMedicamento1.Text = "Atras"
                cboMaterial8.Enabled = False
                cboPresentacion8.Enabled = True
                btnPresentacion8.Enabled = True
            Else
                MsgBox("Por favor seleccione un medicamento")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                cboMaterial8.Enabled = True
                btnMedicamento8.Text = "Elegir"
                cboMaterial8.Text = "Elija el medicamento"
                btnMedicamento8.Enabled = True
                lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text) + Int(lblVT7.Text)

            End If
        End If
    End Sub
    Private Sub btnPresentacion1_Click(sender As Object, e As EventArgs) Handles btnPresentacion1.Click
        If btnPresentacion1.Text = "Elegir" Then
            If cboPresentacion1.Text <> "Elija la presentacion" Then
                sql = "select m.idMedicamento, m.precioventa from medicamento m, proveedor p where m.Idprov=p.idprov and p.nombre='" & lblProv.Text & "' and m.nombre='" & cboMaterial1.Text & "' and m.presen='" & cboPresentacion1.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        lblIdMed1.Text = (rs.Item(0))
                        lblVU1.Text = (rs.Item(1))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnPresentacion1.Text = "Atras"
                cboPresentacion1.Enabled = False
                txtCant1.Enabled = True
                btnCant1.Enabled = True
            Else
                MsgBox("Por favor seleccione una presentacion")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnPresentacion1.Text = "Elegir"
                cboPresentacion1.Enabled = True
                cboPresentacion1.Text = "Elija la presentacion"
                lblIdMed1.Text = ""
                lblVU1.Text = ""
                lblVT1.Text = ""
                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = 0
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text)
                End If

                blanquearFilas(1, 3)
            End If
        End If
    End Sub
    Private Sub btnPresentacion2_Click(sender As Object, e As EventArgs) Handles btnPresentacion2.Click
        If btnPresentacion2.Text = "Elegir" Then
            If cboPresentacion2.Text <> "Elija la presentacion" Then
                sql = "select m.idMedicamento, m.precioventa from medicamento m, proveedor p where m.Idprov=p.idprov and p.nombre='" & lblProv.Text & "' and m.nombre='" & cboMaterial2.Text & "' and m.presen='" & cboPresentacion2.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        lblIdMed2.Text = (rs.Item(0))
                        lblVU2.Text = (rs.Item(1))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnPresentacion2.Text = "Atras"
                cboPresentacion2.Enabled = False
                txtCant2.Enabled = True
                btnCant2.Enabled = True
            Else
                MsgBox("Por favor seleccione una presentacion")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnPresentacion2.Text = "Elegir"
                cboPresentacion2.Enabled = True
                cboPresentacion2.Text = "Elija la presentacion"
                lblIdMed2.Text = ""
                lblVU2.Text = ""
                lblVT2.Text = ""
                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = Int(lblVT1.Text)
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text)
                End If
                blanquearFilas(2, 3)
            End If
        End If
    End Sub
    Private Sub btnPresentacion3_Click(sender As Object, e As EventArgs) Handles btnPresentacion3.Click
        If btnPresentacion3.Text = "Elegir" Then
            If cboPresentacion3.Text <> "Elija la presentacion" Then
                sql = "select m.idMedicamento, m.precioventa from medicamento m, proveedor p where m.Idprov=p.idprov and p.nombre='" & lblProv.Text & "' and m.nombre='" & cboMaterial3.Text & "' and m.presen='" & cboPresentacion3.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        lblIdMed3.Text = (rs.Item(0))
                        lblVU3.Text = (rs.Item(1))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnPresentacion3.Text = "Atras"
                cboPresentacion3.Enabled = False
                txtCant3.Enabled = True
                btnCant3.Enabled = True
            Else
                MsgBox("Por favor seleccione una presentacion")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnPresentacion3.Text = "Elegir"
                cboPresentacion3.Enabled = True
                cboPresentacion3.Text = "Elija la presentacion"
                lblIdMed3.Text = ""
                lblVU3.Text = ""
                lblVT3.Text = ""
                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text)
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text)
                End If
                blanquearFilas(3, 3)
            End If
        End If
    End Sub
    Private Sub btnPresentacion4_Click(sender As Object, e As EventArgs) Handles btnPresentacion4.Click
        If btnPresentacion4.Text = "Elegir" Then
            If cboPresentacion4.Text <> "Elija la presentacion" Then
                sql = "select m.idMedicamento, m.precioventa from medicamento m, proveedor p where m.Idprov=p.idprov and p.nombre='" & lblProv.Text & "' and m.nombre='" & cboMaterial4.Text & "' and m.presen='" & cboPresentacion4.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        lblIdMed4.Text = (rs.Item(0))
                        lblVU4.Text = (rs.Item(1))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnPresentacion4.Text = "Atras"
                cboPresentacion4.Enabled = False
                txtCant4.Enabled = True
                btnCant4.Enabled = True
            Else
                MsgBox("Por favor seleccione una presentacion")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnPresentacion4.Text = "Elegir"
                cboPresentacion4.Enabled = True
                cboPresentacion4.Text = "Elija la presentacion"
                lblIdMed4.Text = ""
                lblVU4.Text = ""
                lblVT4.Text = ""
                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text)
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text)
                End If
                blanquearFilas(4, 3)
            End If
        End If
    End Sub
    Private Sub btnPresentacion5_Click(sender As Object, e As EventArgs) Handles btnPresentacion5.Click
        If btnPresentacion5.Text = "Elegir" Then
            If cboPresentacion5.Text <> "Elija la presentacion" Then
                sql = "select m.idMedicamento, m.precioventa from medicamento m, proveedor p where m.Idprov=p.idprov and p.nombre='" & lblProv.Text & "' and m.nombre='" & cboMaterial5.Text & "' and m.presen='" & cboPresentacion5.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        lblIdMed5.Text = (rs.Item(0))
                        lblVU5.Text = (rs.Item(1))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnPresentacion5.Text = "Atras"
                cboPresentacion5.Enabled = False
                txtCant5.Enabled = True
                btnCant5.Enabled = True
            Else
                MsgBox("Por favor seleccione una presentacion")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnPresentacion5.Text = "Elegir"
                cboPresentacion5.Enabled = True
                cboPresentacion5.Text = "Elija la presentacion"
                lblIdMed5.Text = ""
                lblVU5.Text = ""
                lblVT5.Text = ""
                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text)
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text)
                End If
                blanquearFilas(5, 3)
            End If
        End If
    End Sub
    Private Sub btnPresentacion6_Click(sender As Object, e As EventArgs) Handles btnPresentacion6.Click
        If btnPresentacion6.Text = "Elegir" Then
            If cboPresentacion6.Text <> "Elija la presentacion" Then
                sql = "select m.idMedicamento, m.precioventa from medicamento m, proveedor p where m.Idprov=p.idprov and p.nombre='" & lblProv.Text & "' and m.nombre='" & cboMaterial6.Text & "' and m.presen='" & cboPresentacion6.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        lblIdMed6.Text = (rs.Item(0))
                        lblVU6.Text = (rs.Item(1))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnPresentacion6.Text = "Atras"
                cboPresentacion6.Enabled = False
                txtCant6.Enabled = True
                btnCant6.Enabled = True
            Else
                MsgBox("Por favor seleccione una presentacion")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnPresentacion6.Text = "Elegir"
                cboPresentacion6.Enabled = True
                cboPresentacion6.Text = "Elija la presentacion"
                lblIdMed6.Text = ""
                lblVU6.Text = ""
                lblVT6.Text = ""
                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text)
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text)

                End If
                blanquearFilas(6, 3)
            End If
        End If
    End Sub
    Private Sub btnPresentacion7_Click(sender As Object, e As EventArgs) Handles btnPresentacion7.Click
        If btnPresentacion7.Text = "Elegir" Then
            If cboPresentacion7.Text <> "Elija la presentacion" Then
                sql = "select m.idMedicamento, m.precioventa from medicamento m, proveedor p where m.Idprov=p.idprov and p.nombre='" & lblProv.Text & "' and m.nombre='" & cboMaterial7.Text & "' and m.presen='" & cboPresentacion7.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        lblIdMed7.Text = (rs.Item(0))
                        lblVU7.Text = (rs.Item(1))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnPresentacion7.Text = "Atras"
                cboPresentacion7.Enabled = False
                txtCant7.Enabled = True
                btnCant7.Enabled = True
            Else
                MsgBox("Por favor seleccione una presentacion")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnPresentacion7.Text = "Elegir"
                cboPresentacion7.Enabled = True
                cboPresentacion7.Text = "Elija la presentacion"
                lblIdMed7.Text = ""
                lblVU7.Text = ""
                lblVT7.Text = ""
                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text)
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text)


                End If
                blanquearFilas(7, 3)
            End If
        End If
    End Sub
    Private Sub btnPresentacion8_Click(sender As Object, e As EventArgs) Handles btnPresentacion8.Click
        If btnPresentacion8.Text = "Elegir" Then
            If cboPresentacion8.Text <> "Elija la presentacion" Then
                sql = "select m.idMedicamento, m.precioventa from medicamento m, proveedor p where m.Idprov=p.idprov and p.nombre='" & lblProv.Text & "' and m.nombre='" & cboMaterial8.Text & "' and m.presen='" & cboPresentacion8.Text & "'"
                rs = Consulta()
                Do While eoff = False
                    If rs.Read() = True Then
                        lblIdMed8.Text = (rs.Item(0))
                        lblVU8.Text = (rs.Item(1))
                    Else
                        eoff = True
                    End If
                Loop
                eoff = False
                btnPresentacion8.Text = "Atras"
                cboPresentacion8.Enabled = False
                txtCant8.Enabled = True
                btnCant8.Enabled = True
            Else
                MsgBox("Por favor seleccione una presentacion")
            End If
        Else
            opc = MsgBox("¿Estas seguro que desea volver atras hasta este punto?, se borraran los datos", vbYesNo)
            If opc = 6 Then
                btnPresentacion8.Text = "Elegir"
                cboPresentacion8.Enabled = True
                cboPresentacion8.Text = "Elija la presentacion"
                lblIdMed8.Text = ""
                lblVU8.Text = ""
                lblVT8.Text = ""
                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text) + Int(lblVT7.Text)
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text) + Int(lblVT7.Text)


                End If
                blanquearFilas(8, 3)
            End If
        End If
    End Sub

    Private Sub btnCant1_Click(sender As Object, e As EventArgs) Handles btnCant1.Click
        If btnCant1.Text = "Elegir" Then
            If txtCant1.Text <> "" Then
                If Int(txtCant1.Text) <> 0 Then
                    lblVT1.Text = Int(txtCant1.Text) * Int(lblVU1.Text)
                    If OrdendeCompra1.lblVTT.Text <> "" Then
                        lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text)
                    Else
                        lblVTT.Text = Int(lblVT1.Text)

                    End If
                    btnContinuar.Enabled = True
                    btnCant1.Text = "Atras"
                    sql = "select  distinct m.nombre  from medicamento m, proveedor p where m.Activo=1 and p.idprov=m.idprov and P.nombre='" & lblProv.Text & "' and (m.IdMedicamento<> " & lblIdMed1.Text & ")"
                    rs = Consulta()
                    cantidadMedicamentos = 0
                    Do While eoff = False
                        If rs.Read() = True Then
                            cboMaterial2.Items.Add(rs.Item(0))
                            cantidadMedicamentos = cantidadMedicamentos + 1
                        Else
                            If cantidadMedicamentos = 0 Then
                                MsgBox("Ya no quedan mas insumos, para el proveedor elegido")
                                opc = MsgBox("¿Desea pasar a la carga de medicamentos?", vbYesNo)
                            End If
                            eoff = True
                        End If
                    Loop
                    eoff = False
                    If cantidadMedicamentos = 0 Then

                        If opc = 6 Then
                            cargarOrdendeCompraFinal()
                            Me.Hide()
                            OrdendeCompraFinal.Show()
                        End If
                        txtCant1.Enabled = False
                    Else
                        txtCant1.Enabled = False
                        btnMedicamento2.Enabled = True
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

                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = 0
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text)
                End If
                blanquearFilas(2, 1)
            End If
        End If
    End Sub


    Private Sub btnCant2_Click(sender As Object, e As EventArgs) Handles btnCant2.Click
        If btnCant2.Text = "Elegir" Then
            If txtCant2.Text <> "" Then

                If Int(txtCant2.Text) <> 0 Then
                    lblVT2.Text = Int(txtCant2.Text) * Int(lblVU2.Text)
                    If OrdendeCompra1.lblVTT.Text <> "" Then
                        lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text)

                    Else
                        lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text)

                    End If
                    btnCant2.Text = "Atras"

                    sql = "select  distinct m.nombre  from medicamento m, proveedor p where m.Activo=1 and p.idprov=m.idprov and P.nombre='" & lblProv.Text & "' and (m.IdMedicamento<> " & lblIdMed1.Text & " and m.IdMedicamento<> " & lblIdMed2.Text & ")"
                    rs = Consulta()
                    cantidadMedicamentos = 0
                    Do While eoff = False
                        If rs.Read() = True Then
                            cboMaterial3.Items.Add(rs.Item(0))
                            cantidadMedicamentos = cantidadMedicamentos + 1
                        Else
                            If cantidadMedicamentos = 0 Then
                                MsgBox("Ya no quedan mas insumos, para el proveedor elegido")
                                opc = MsgBox("¿Desea pasar a la carga de medicamentos?", vbYesNo)
                            End If
                            eoff = True
                        End If
                    Loop
                    eoff = False

                    If cantidadMedicamentos = 0 Then

                        If opc = 6 Then
                            cargarOrdendeCompraFinal()
                            Me.Hide()
                            OrdendeCompraFinal.Show()
                        End If
                        txtCant2.Enabled = False
                    Else
                        txtCant2.Enabled = False
                        btnMedicamento3.Enabled = True
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

                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = Int(lblVT1.Text)
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text)
                End If
                blanquearFilas(3, 1)
            End If
        End If
    End Sub
    Private Sub btnCant3_Click(sender As Object, e As EventArgs) Handles btnCant3.Click
        If btnCant3.Text = "Elegir" Then
            If txtCant3.Text <> "" Then

                If Int(txtCant3.Text) <> 0 Then
                    lblVT3.Text = Int(txtCant3.Text) * Int(lblVU3.Text)
                    If OrdendeCompra1.lblVTT.Text <> "" Then
                        lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text)

                    Else
                        lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text)

                    End If
                    btnCant3.Text = "Atras"

                    sql = "select  distinct m.nombre  from medicamento m, proveedor p where m.Activo=1 and p.idprov=m.idprov and P.nombre='" & lblProv.Text & "' and (m.IdMedicamento<> " & lblIdMed1.Text & " and m.IdMedicamento<> " & lblIdMed2.Text & " and m.IdMedicamento<> " & lblIdMed3.Text & ")"
                    rs = Consulta()
                    cantidadMedicamentos = 0
                    Do While eoff = False
                        If rs.Read() = True Then
                            cboMaterial4.Items.Add(rs.Item(0))
                            cantidadMedicamentos = cantidadMedicamentos + 1
                        Else
                            If cantidadMedicamentos = 0 Then
                                MsgBox("Ya no quedan mas insumos, para el proveedor elegido")
                                opc = MsgBox("¿Desea pasar a la carga de medicamentos?", vbYesNo)
                            End If
                            eoff = True
                        End If
                    Loop
                    eoff = False

                    If cantidadMedicamentos = 0 Then

                        If opc = 6 Then
                            cargarOrdendeCompraFinal()
                            Me.Hide()
                            OrdendeCompraFinal.Show()
                        End If
                        txtCant3.Enabled = False
                    Else
                        txtCant3.Enabled = False
                        btnMedicamento4.Enabled = True
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

                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text)
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text)
                End If
                blanquearFilas(4, 1)
            End If
        End If
    End Sub

    Private Sub btnCant4_Click(sender As Object, e As EventArgs) Handles btnCant4.Click
        If btnCant4.Text = "Elegir" Then
            If txtCant4.Text <> "" Then
                If Int(txtCant4.Text) <> 0 Then
                    lblVT4.Text = Int(txtCant4.Text) * Int(lblVU4.Text)
                    If OrdendeCompra1.lblVTT.Text <> "" Then
                        lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text)
                    Else
                        lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text)

                    End If
                    btnCant4.Text = "Atras"

                    sql = "select  distinct m.nombre  from medicamento m, proveedor p where m.Activo=1 and p.idprov=m.idprov and P.nombre='" & lblProv.Text & "' and (m.IdMedicamento<> " & lblIdMed1.Text & " and m.IdMedicamento<> " & lblIdMed2.Text & " and m.IdMedicamento<> " & lblIdMed3.Text & " and m.IdMedicamento<> " & lblIdMed4.Text & ")"
                    rs = Consulta()
                    cantidadMedicamentos = 0
                    Do While eoff = False
                        If rs.Read() = True Then
                            cboMaterial5.Items.Add(rs.Item(0))
                            cantidadMedicamentos = cantidadMedicamentos + 1
                        Else
                            If cantidadMedicamentos = 0 Then
                                MsgBox("Ya no quedan mas insumos, para el proveedor elegido")
                                opc = MsgBox("¿Desea pasar a la carga de medicamentos?", vbYesNo)
                            End If
                            eoff = True
                        End If
                    Loop
                    eoff = False

                    If cantidadMedicamentos = 0 Then

                        If opc = 6 Then
                            cargarOrdendeCompraFinal()
                            Me.Hide()
                            OrdendeCompraFinal.Show()
                        End If
                        txtCant4.Enabled = False
                    Else
                        txtCant4.Enabled = False
                        btnMedicamento5.Enabled = True
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
                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text)
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text)
                End If
                blanquearFilas(5, 1)
            End If
        End If
    End Sub

    Private Sub btnCant5_Click(sender As Object, e As EventArgs) Handles btnCant5.Click
        If btnCant5.Text = "Elegir" Then
            If txtCant5.Text <> "" Then

                If Int(txtCant5.Text) <> 0 Then
                    lblVT5.Text = Int(txtCant5.Text) * Int(lblVU5.Text)
                    If OrdendeCompra1.lblVTT.Text <> "" Then
                        lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text)
                    Else
                        lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text)

                    End If
                    btnCant5.Text = "Atras"

                        sql = "select  distinct m.nombre  from medicamento m, proveedor p where m.Activo=1 and p.idprov=m.idprov and P.nombre='" & lblProv.Text & "' and (m.IdMedicamento<> " & lblIdMed1.Text & " and m.IdMedicamento<> " & lblIdMed2.Text & " and m.IdMedicamento<> " & lblIdMed3.Text & " and m.IdMedicamento<> " & lblIdMed4.Text & " and m.IdMedicamento<> " & lblIdMed5.Text & ")"
                        rs = Consulta()
                        cantidadMedicamentos = 0
                        Do While eoff = False
                            If rs.Read() = True Then
                                cboMaterial6.Items.Add(rs.Item(0))
                                cantidadMedicamentos = cantidadMedicamentos + 1
                            Else
                                If cantidadMedicamentos = 0 Then
                                    MsgBox("Ya no quedan mas insumos, para el proveedor elegido")
                                    opc = MsgBox("¿Desea pasar a la carga de medicamentos?", vbYesNo)
                                End If
                                eoff = True
                            End If
                        Loop
                        eoff = False

                        If cantidadMedicamentos = 0 Then

                            If opc = 6 Then
                                cargarOrdendeCompraFinal()
                                Me.Hide()
                                OrdendeCompraFinal.Show()
                            End If
                            txtCant5.Enabled = False
                        Else
                            txtCant5.Enabled = False
                            btnMedicamento6.Enabled = True
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
                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text)
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text)
                End If
                blanquearFilas(6, 1)
            End If
        End If
    End Sub

    Private Sub btnCant6_Click(sender As Object, e As EventArgs) Handles btnCant6.Click
        If btnCant6.Text = "Elegir" Then
            If txtCant6.Text <> "" Then

                If Int(txtCant6.Text) <> 0 Then
                    lblVT6.Text = Int(txtCant6.Text) * Int(lblVU6.Text)
                    If OrdendeCompra1.lblVTT.Text <> "" Then
                        lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text)
                    Else
                        lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text)

                    End If
                    btnCant6.Text = "Atras"

                    sql = "select  distinct m.nombre  from medicamento m, proveedor p where m.Activo=1 and p.idprov=m.idprov and P.nombre='" & lblProv.Text & "' and (m.IdMedicamento<> " & lblIdMed1.Text & " and m.IdMedicamento<> " & lblIdMed2.Text & " and m.IdMedicamento<> " & lblIdMed3.Text & " and m.IdMedicamento<> " & lblIdMed4.Text & " and m.IdMedicamento<> " & lblIdMed5.Text & " and m.IdMedicamento<> " & lblIdMed6.Text & ")"
                    rs = Consulta()
                    cantidadMedicamentos = 0
                    Do While eoff = False
                        If rs.Read() = True Then
                            cboMaterial7.Items.Add(rs.Item(0))
                            cantidadMedicamentos = cantidadMedicamentos + 1
                        Else
                            If cantidadMedicamentos = 0 Then
                                MsgBox("Ya no quedan mas insumos, para el proveedor elegido")
                                opc = MsgBox("¿Desea pasar a la carga de medicamentos?", vbYesNo)
                            End If
                            eoff = True
                        End If
                    Loop
                    eoff = False

                    If cantidadMedicamentos = 0 Then

                        If opc = 6 Then
                            cargarOrdendeCompraFinal()
                            Me.Hide()
                            OrdendeCompraFinal.Show()
                        End If
                        txtCant6.Enabled = False
                    Else
                        txtCant6.Enabled = False
                        btnMedicamento7.Enabled = True
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
                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text)
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text)

                End If
                blanquearFilas(7, 1)
            End If
        End If
    End Sub

    Private Sub btnCant7_Click(sender As Object, e As EventArgs) Handles btnCant7.Click
        If btnCant7.Text = "Elegir" Then
            If txtCant7.Text <> "" Then

                If Int(txtCant7.Text) <> 0 Then
                    lblVT7.Text = Int(txtCant7.Text) * Int(lblVU7.Text)
                    If OrdendeCompra1.lblVTT.Text <> "" Then
                        lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text) + Int(lblVT7.Text)
                    Else
                        lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text) + Int(lblVT7.Text)

                    End If
                    btnCant7.Text = "Atras"

                    sql = "select  distinct m.nombre  from medicamento m, proveedor p where m.Activo=1 and p.idprov=m.idprov and P.nombre='" & lblProv.Text & "' and (m.IdMedicamento<> " & lblIdMed1.Text & " and m.IdMedicamento<> " & lblIdMed2.Text & " and m.IdMedicamento<> " & lblIdMed3.Text & " and m.IdMedicamento<> " & lblIdMed4.Text & " and m.IdMedicamento<> " & lblIdMed5.Text & " and m.IdMedicamento<> " & lblIdMed6.Text & " and m.IdMedicamento<> " & lblIdMed6.Text & ")"
                    rs = Consulta()
                    cantidadMedicamentos = 0
                    Do While eoff = False
                        If rs.Read() = True Then
                            cboMaterial8.Items.Add(rs.Item(0))
                            cantidadMedicamentos = cantidadMedicamentos + 1
                        Else
                            If cantidadMedicamentos = 0 Then
                                MsgBox("Ya no quedan mas insumos, para el proveedor elegido")
                                opc = MsgBox("¿Desea pasar a la carga de medicamentos?", vbYesNo)
                            End If
                            eoff = True
                        End If
                    Loop
                    eoff = False

                    If cantidadMedicamentos = 0 Then

                        If opc = 6 Then
                            cargarOrdendeCompraFinal()
                            Me.Hide()
                            OrdendeCompraFinal.Show()
                        End If
                        txtCant7.Enabled = False
                    Else
                        txtCant7.Enabled = False
                        btnMedicamento8.Enabled = True
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
                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text)
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text)


                End If
                blanquearFilas(8, 1)
            End If

        End If
    End Sub

    Private Sub btnCant8_Click(sender As Object, e As EventArgs) Handles btnCant8.Click
        If btnCant8.Text = "Elegir" Then
            If txtCant8.Text <> "" Then

                If Int(txtCant8.Text) <> 0 Then
                    lblVT8.Text = Int(txtCant8.Text) * Int(lblVU8.Text)
                    If OrdendeCompra1.lblVTT.Text <> "" Then
                        lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text) + Int(lblVT7.Text) + Int(lblVT8.Text)
                    Else
                        lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text) + Int(lblVT7.Text) + Int(lblVT8.Text)

                    End If
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
                If OrdendeCompra1.lblVTT.Text = "" Then
                    lblVTT.Text = Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text) + Int(lblVT7.Text)
                Else

                    lblVTT.Text = Int(OrdendeCompra1.lblVTT.Text) + Int(lblVT1.Text) + Int(lblVT2.Text) + Int(lblVT3.Text) + Int(lblVT4.Text) + Int(lblVT5.Text) + Int(lblVT6.Text) + Int(lblVT7.Text)


                End If
            End If
        End If
    End Sub
    Public Sub blanquearFilas(ByVal i As Integer, ByVal j As Integer)
        If i = 0 Then
            If OrdendeCompra1.lblVTT.Text <> "" Then
                btnContinuar.Enabled = True
            Else
                btnContinuar.Enabled = False
            End If
            lblIdMed1.Text = ""
            txtCant1.Text = ""
            txtCant1.Enabled = False
            btnCant1.Enabled = False
            btnCant1.Text = "Elegir"
            cboPresentacion1.Text = "Elija la presentacion"
            cboPresentacion1.Enabled = False
            cboPresentacion1.Items.Clear()
            btnPresentacion1.Enabled = False
            btnPresentacion1.Text = "Elegir"
            lblVU1.Text = ""
            lblVT1.Text = ""


            sql = "select m.nombre, m.presen  from medicamento m, proveedor p where m.Activo=1 and P.IdProv=m.IdProv and P.nombre='" & lblProv.Text & "'"
            rs = Consulta()
            cantidadMedicamentos = 0
            Do While eoff = False
                If rs.Read() = True Then
                    cboMaterial1.Items.Add(rs.Item(0))
                    cantidadMedicamentos = cantidadMedicamentos + 1
                Else
                    If cantidadMedicamentos = 0 Then
                        opc = MsgBox("No hay Medicamentos de este proveedor, desea proceder a la carga de medicamentos ?", vbYesNo)
                    End If
                    eoff = True
                End If
            Loop
            eoff = False
            If cantidadMedicamentos <> 0 Then
                btnMedicamento1.Enabled = True
                btnMedicamento1.Text = "Elegir"
                cboMaterial1.Text = "Elija el medicamento"
                cboMaterial1.Enabled = True

            Else
                If (opc = 6) Then
                    Me.Hide()
                    OrdendeCompraFinal.Show()
                Else
                    MsgBox("Por favor, seleccione otro proveedor o presione en el boton continuar para finalizar la orden de compra")
                    btnMedicamento1.Enabled = False
                    btnMedicamento1.Text = "Elegir"
                    cboMaterial1.Text = "Elija el medicamento"
                    cboMaterial1.Enabled = False
                End If
            End If


            j = 1
            i = 2
        End If
        If i = 1 Then
            If j = 1 Then
                cboMaterial1.Text = "Elija el medicamento"
                cboMaterial1.Enabled = False
                btnMedicamento1.Enabled = False
                btnMedicamento1.Text = "Elegir"
                cboMaterial1.Items.Clear()
                j = j + 1
            End If
            If j = 2 Then
                cboPresentacion1.Text = "Elija la presentacion"
                cboPresentacion1.Enabled = False
                cboPresentacion1.Items.Clear()
                btnPresentacion1.Enabled = False
                btnPresentacion1.Text = "Elegir"
                lblVU1.Text = ""
                lblVT1.Text = ""
                j = j + 1
            End If
            If j = 3 Then
                lblIdMed1.Text = ""
                txtCant1.Text = ""
                txtCant1.Enabled = False
                btnCant1.Enabled = False
                btnCant1.Text = "Elegir"
                j = 1
            End If
            i = i + 1
        End If
        If i = 2 Then
            If j = 1 Then
                cboMaterial2.Text = "Elija el medicamento"
                cboMaterial2.Enabled = False
                btnMedicamento2.Enabled = False
                btnMedicamento2.Text = "Elegir"
                cboMaterial2.Items.Clear()
                j = j + 1
            End If
            If j = 2 Then
                cboPresentacion2.Text = "Elija la presentacion"
                cboPresentacion2.Enabled = False
                cboPresentacion2.Items.Clear()
                btnPresentacion2.Enabled = False
                btnPresentacion2.Text = "Elegir"
                lblVU2.Text = ""
                lblVT2.Text = ""
                j = j + 1
            End If
            If j = 3 Then
                lblIdMed2.Text = ""
                txtCant2.Text = ""
                txtCant2.Enabled = False
                btnCant2.Enabled = False
                btnCant2.Text = "Elegir"
                j = 1
            End If
            i = i + 1
        End If
        If i = 3 Then
            If j = 1 Then
                cboMaterial3.Text = "Elija el medicamento"
                cboMaterial3.Enabled = False
                btnMedicamento3.Enabled = False
                btnMedicamento3.Text = "Elegir"
                cboMaterial3.Items.Clear()
                j = j + 1
            End If
            If j = 2 Then
                cboPresentacion3.Text = "Elija la presentacion"
                cboPresentacion3.Enabled = False
                cboPresentacion3.Items.Clear()
                btnPresentacion3.Enabled = False
                btnPresentacion3.Text = "Elegir"
                lblVU3.Text = ""
                lblVT3.Text = ""
                j = j + 1
            End If
            If j = 3 Then
                lblIdMed3.Text = ""
                txtCant3.Text = ""
                txtCant3.Enabled = False
                btnCant3.Enabled = False
                j = 1
            End If
            i = i + 1
        End If
        If i = 4 Then
            If j = 1 Then
                cboMaterial4.Text = "Elija el medicamento"
                cboMaterial4.Enabled = False
                btnMedicamento4.Enabled = False
                btnMedicamento4.Text = "Elegir"
                cboMaterial4.Items.Clear()
                j = j + 1
            End If
            If j = 2 Then
                cboPresentacion4.Text = "Elija la presentacion"
                cboPresentacion4.Enabled = False
                cboPresentacion4.Items.Clear()
                btnPresentacion4.Enabled = False
                btnPresentacion4.Text = "Elegir"
                lblVU4.Text = ""
                lblVT4.Text = ""
                j = j + 1
            End If
            If j = 3 Then
                lblIdMed4.Text = ""
                txtCant4.Text = ""
                txtCant4.Enabled = False
                btnCant4.Enabled = False
                j = 1
            End If
            i = i + 1
        End If
        If i = 5 Then
            If j = 1 Then
                cboMaterial5.Text = "Elija el medicamento"
                cboMaterial5.Enabled = False
                btnMedicamento5.Enabled = False
                btnMedicamento5.Text = "Elegir"
                cboMaterial5.Items.Clear()
                j = j + 1
            End If
            If j = 2 Then
                cboPresentacion5.Text = "Elija la presentacion"
                cboPresentacion5.Enabled = False
                cboPresentacion5.Items.Clear()
                btnPresentacion5.Enabled = False
                btnPresentacion5.Text = "Elegir"
                lblVU5.Text = ""
                lblVT5.Text = ""
                j = j + 1
            End If
            If j = 3 Then
                lblIdMed5.Text = ""
                txtCant5.Text = ""
                txtCant5.Enabled = False
                btnCant5.Enabled = False
                j = 1
            End If
            i = i + 1
        End If
        If i = 6 Then
            If j = 1 Then
                cboMaterial6.Text = "Elija el medicamento"
                cboMaterial6.Enabled = False
                btnMedicamento6.Enabled = False
                btnMedicamento6.Text = "Elegir"
                cboMaterial6.Items.Clear()
                j = j + 1
            End If
            If j = 2 Then
                cboPresentacion6.Text = "Elija la presentacion"
                cboPresentacion6.Enabled = False
                cboPresentacion6.Items.Clear()
                btnPresentacion6.Enabled = False
                btnPresentacion6.Text = "Elegir"
                lblVU6.Text = ""
                lblVT6.Text = ""
                j = j + 1
            End If
            If j = 3 Then
                lblIdMed6.Text = ""
                txtCant6.Text = ""
                txtCant6.Enabled = False
                btnCant6.Enabled = False
                j = 1
            End If
            i = i + 1
        End If
        If i = 7 Then
            If j = 1 Then
                cboMaterial7.Text = "Elija el medicamento"
                cboMaterial7.Enabled = False
                btnMedicamento7.Enabled = False
                btnMedicamento7.Text = "Elegir"
                cboMaterial7.Items.Clear()
                j = j + 1
            End If
            If j = 2 Then
                cboPresentacion7.Text = "Elija la presentacion"
                cboPresentacion7.Enabled = False
                cboPresentacion7.Items.Clear()
                btnPresentacion7.Enabled = False
                btnPresentacion7.Text = "Elegir"
                lblVU7.Text = ""
                lblVT7.Text = ""
                j = j + 1
            End If
            If j = 3 Then
                lblIdMed7.Text = ""
                txtCant7.Text = ""
                txtCant7.Enabled = False
                btnCant7.Enabled = False
                j = 1
            End If
            i = i + 1
        End If
        If i = 8 Then
            If j = 1 Then
                cboMaterial8.Text = "Elija el medicamento"
                cboMaterial8.Enabled = False
                btnMedicamento8.Enabled = False
                btnMedicamento8.Text = "Elegir"
                cboMaterial8.Items.Clear()
                j = j + 1
            End If
            If j = 2 Then
                cboPresentacion8.Text = "Elija la presentacion"
                cboPresentacion8.Enabled = False
                cboPresentacion8.Items.Clear()
                btnPresentacion8.Enabled = False
                btnPresentacion8.Text = "Elegir"
                lblVU8.Text = ""
                lblVT8.Text = ""
                j = j + 1
            End If
            If j = 3 Then
                lblIdMed8.Text = ""
                txtCant8.Text = ""
                txtCant8.Enabled = False
                btnCant8.Enabled = False
                j = 1
            End If

        End If
    End Sub
    Private Sub cargarOrdendeCompraFinal()
        OrdendeCompraFinal.lblFechaI.Text = OrdendeCompra1.lblFechaI.Text
        OrdendeCompraFinal.lblProv.Text = OrdendeCompra1.cboProveedor.Text
        OrdendeCompraFinal.lblNOrdComp.Text = OrdendeCompra1.lblNOrdComp.Text

        If OrdendeCompra1.lblVTT.Text = "" Then
            OrdendeCompra1.lblVTT.Text = 0
        End If
        If lblVTT.Text = "" Then
            lblVTT.Text = 0
        End If
        OrdendeCompraFinal.lblPrecioTT.Text = Int(lblVTT.Text)
        OrdendeCompraFinal.lblCantI1.Text = OrdendeCompra1.txtCant1.Text
        OrdendeCompraFinal.lblCantI2.Text = OrdendeCompra1.txtCant2.Text
        OrdendeCompraFinal.lblCantI3.Text = OrdendeCompra1.txtCant3.Text
        OrdendeCompraFinal.lblCantI4.Text = OrdendeCompra1.txtCant4.Text
        OrdendeCompraFinal.lblCantI5.Text = OrdendeCompra1.txtCant5.Text
        OrdendeCompraFinal.lblCantI6.Text = OrdendeCompra1.txtCant6.Text
        OrdendeCompraFinal.lblCantI7.Text = OrdendeCompra1.txtCant7.Text
        OrdendeCompraFinal.lblCantI8.Text = OrdendeCompra1.txtCant8.Text
        If OrdendeCompra1.lblVT1.Text = "" Then
            OrdendeCompraFinal.lblInsumo1.Text = ""
        Else
            OrdendeCompraFinal.lblInsumo1.Text = OrdendeCompra1.cboMaterial1.Text
        End If
        If OrdendeCompra1.lblVT2.Text = "" Then
            OrdendeCompraFinal.lblInsumo2.Text = ""
        Else
            OrdendeCompraFinal.lblInsumo2.Text = OrdendeCompra1.cboMaterial2.Text
        End If
        If OrdendeCompra1.lblVT3.Text = "" Then
            OrdendeCompraFinal.lblInsumo3.Text = ""
        Else
            OrdendeCompraFinal.lblInsumo3.Text = OrdendeCompra1.cboMaterial3.Text
        End If
        If OrdendeCompra1.lblVT4.Text = "" Then
            OrdendeCompraFinal.lblInsumo4.Text = ""
        Else
            OrdendeCompraFinal.lblInsumo4.Text = OrdendeCompra1.cboMaterial4.Text
        End If
        If OrdendeCompra1.lblVT5.Text = "" Then
            OrdendeCompraFinal.lblInsumo5.Text = ""
        Else
            OrdendeCompraFinal.lblInsumo5.Text = OrdendeCompra1.cboMaterial5.Text
        End If
        If OrdendeCompra1.lblVT6.Text = "" Then
            OrdendeCompraFinal.lblInsumo6.Text = ""
        Else
            OrdendeCompraFinal.lblInsumo6.Text = OrdendeCompra1.cboMaterial6.Text
        End If
        If OrdendeCompra1.lblVT7.Text = "" Then
            OrdendeCompraFinal.lblInsumo7.Text = ""
        Else
            OrdendeCompraFinal.lblInsumo7.Text = OrdendeCompra1.cboMaterial7.Text
        End If
        If OrdendeCompra1.lblVT8.Text = "" Then
            OrdendeCompraFinal.lblInsumo8.Text = ""
        Else
            OrdendeCompraFinal.lblInsumo8.Text = OrdendeCompra1.cboMaterial8.Text
        End If
        OrdendeCompraFinal.lblCantM1.Text = txtCant1.Text
        OrdendeCompraFinal.lblCantM2.Text = txtCant2.Text
        OrdendeCompraFinal.lblCantM3.Text = txtCant3.Text
        OrdendeCompraFinal.lblCantM4.Text = txtCant4.Text
        OrdendeCompraFinal.lblCantM5.Text = txtCant5.Text
        OrdendeCompraFinal.lblCantM6.Text = txtCant6.Text
        OrdendeCompraFinal.lblCantM7.Text = txtCant7.Text
        OrdendeCompraFinal.lblCantM8.Text = txtCant8.Text

        If lblVT1.Text = "" Then
            OrdendeCompraFinal.lblPresentacion1.Text = ""
            OrdendeCompraFinal.lblMedicamento1.Text = ""
        Else
            OrdendeCompraFinal.lblPresentacion1.Text = cboPresentacion1.Text
            OrdendeCompraFinal.lblMedicamento1.Text = cboMaterial1.Text
        End If
        If lblVT2.Text = "" Then
            OrdendeCompraFinal.lblPresentacion2.Text = ""
            OrdendeCompraFinal.lblMedicamento2.Text = ""
        Else
            OrdendeCompraFinal.lblPresentacion2.Text = cboPresentacion2.Text
            OrdendeCompraFinal.lblMedicamento2.Text = cboMaterial2.Text
        End If
        If lblVT3.Text = "" Then
            OrdendeCompraFinal.lblPresentacion3.Text = ""
            OrdendeCompraFinal.lblMedicamento3.Text = ""
        Else
            OrdendeCompraFinal.lblPresentacion3.Text = cboPresentacion3.Text
            OrdendeCompraFinal.lblMedicamento3.Text = cboMaterial3.Text
        End If
        If lblVT4.Text = "" Then
            OrdendeCompraFinal.lblPresentacion4.Text = ""
            OrdendeCompraFinal.lblMedicamento4.Text = ""
        Else
            OrdendeCompraFinal.lblPresentacion4.Text = cboPresentacion4.Text
            OrdendeCompraFinal.lblMedicamento4.Text = cboMaterial4.Text
        End If
        If lblVT5.Text = "" Then
            OrdendeCompraFinal.lblPresentacion5.Text = ""
            OrdendeCompraFinal.lblMedicamento5.Text = ""
        Else
            OrdendeCompraFinal.lblPresentacion5.Text = cboPresentacion5.Text
            OrdendeCompraFinal.lblMedicamento5.Text = cboMaterial5.Text
        End If
        If lblVT6.Text = "" Then
            OrdendeCompraFinal.lblPresentacion6.Text = ""
            OrdendeCompraFinal.lblMedicamento6.Text = ""
        Else
            OrdendeCompraFinal.lblPresentacion6.Text = cboPresentacion6.Text
            OrdendeCompraFinal.lblMedicamento6.Text = cboMaterial6.Text
        End If
        If lblVT7.Text = "" Then
            OrdendeCompraFinal.lblPresentacion7.Text = ""
            OrdendeCompraFinal.lblMedicamento7.Text = ""
        Else
            OrdendeCompraFinal.lblPresentacion7.Text = cboPresentacion7.Text
            OrdendeCompraFinal.lblMedicamento7.Text = cboMaterial7.Text
        End If
        If lblVT8.Text = "" Then
            OrdendeCompraFinal.lblPresentacion8.Text = ""
            OrdendeCompraFinal.lblMedicamento8.Text = ""
        Else
            OrdendeCompraFinal.lblPresentacion8.Text = cboPresentacion8.Text
            OrdendeCompraFinal.lblMedicamento8.Text = cboMaterial8.Text
        End If
    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        opc = MsgBox("¿Desea continuar a ver la Orden de compra completa para imprimir?", vbYesNo)
        If opc = 6 Then
            cargarOrdendeCompraFinal()
            Me.Hide()
            OrdendeCompraFinal.Show()
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        opc = MsgBox("¿Desea cancelar y volver a la carga de insumos?", vbYesNo)
        If opc = 6 Then
            Me.Hide()
            OrdendeCompra1.Show()
        End If
    End Sub
End Class
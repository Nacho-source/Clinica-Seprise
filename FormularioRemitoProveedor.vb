Imports System.Data.Odbc

Public Class FormularioRemitoProveedor
    Dim opc As Integer
    Dim rs As OdbcDataReader
    Dim eoff As Boolean
    Public CodigoProv As Integer
    Private Sub FormularioRemitoProveedor_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        sql = "Select Max(IdRem)+1 from Remito"
        rs = Consulta()
        rs.Read()
        lblNRemito.Text = rs.Item(0)


        sql = "select curdate()"
        rs = Consulta()
        rs.Read()
        lblFdeRemito.Text = rs.Item(0)
    End Sub

    Private Sub txtNOrdComp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNOrdComp.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        If txtNOrdComp.Text = "" Then
            MsgBox("Error, Por favor rellenar los campos.", vbExclamation)
        Else
            sql = "select count(*) from Ord_Comp where IdOrdComp=" & txtNOrdComp.Text
            rs = Consulta()
            rs.Read()

            If rs.Item(0) = 0 Then
                MsgBox("Error, Numero de orden de compra inexistente.", vbExclamation)
            Else
                sql = "select count(*) from detOrdComp_ins where resto<>0 and IdOrdComp=" & txtNOrdComp.Text
                rs = Consulta()
                rs.Read()

                If rs.Item(0) = 0 Then
                    sql = "select count(*) from detOrdComp_med where resto<>0 and IdOrdComp=" & txtNOrdComp.Text
                    rs = Consulta()
                    rs.Read()
                End If
                If rs.Item(0) <> 0 Then
                    opc = MsgBox("¿Esta seguro que desea registrar este remito con estos datos?", vbYesNo)
                    If opc = 6 Then
                        RegistrarArtOrdCompra.idOrdComp = txtNOrdComp.Text



                        sql = "Select IdProv from Ord_comp Where IdOrdComp=" & txtNOrdComp.Text
                        rs = Consulta()
                        rs.Read()
                        CodigoProv = rs.Item(0)

                        sql = "Select Max(IdMedicamento)+1 from Medicamento"
                        rs = Consulta()
                        rs.Read()
                        sql = "Insert Into Remito Values ( " & lblNRemito.Text & " ," & CodigoProv & ", (select curdate())," & txtNOrdComp.Text & ")"
                        Consulta()
                        MsgBox("Se ha agregado el remito satisfactoriamente")
                        txtNOrdComp.Text = ""

                        Me.Hide()
                        MsgBox("Ahora se debe registrar la factura del remito registrado")
                        FormularioFacturaProv.Show()
                    End If
                Else
                    MsgBox("Error, Numero de orden de compra no contiene articulos faltantes.", vbExclamation)
                End If

            End If
            End If
    End Sub


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        opc = MsgBox("¿Esta seguro que desea volver?, se perderan todos los datos?", vbYesNo)
        If opc = 6 Then
            txtNOrdComp.Text = ""
            Me.Hide()
            GrillaFarmacia.Show()
        End If
    End Sub

End Class
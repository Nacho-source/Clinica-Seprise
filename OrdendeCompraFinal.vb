Imports System.Globalization

Public Class OrdendeCompraFinal
    Dim cambio As New CultureInfo("es-ES")
    Dim opc As Integer
    Private Sub btnImprimir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImprimir.Click
        cambio.NumberFormat.NumberDecimalSeparator = (".")
        System.Threading.Thread.CurrentThread.CurrentCulture = cambio
        opc = MsgBox("¿Desea imprimir y registrar la orden de compra con estos datos?", vbYesNo)
        If opc = 6 Then
            sql = "insert into Ord_Comp values(" & lblNOrdComp.Text & ", '" & lblFechaI.Text & "',(select IdProv from Proveedor where nombre='" & lblProv.Text & "'), 0, 0)"
            Consulta()

            If OrdendeCompra1.lblVT1.Text <> "" Then

                sql = "insert into DetOrdComp_Ins values(''," & lblNOrdComp.Text & ", " & OrdendeCompra1.lblIdI1.Text & ", " & OrdendeCompra1.txtCant1.Text & ", " & OrdendeCompra1.lblVU1.Text & ", " & OrdendeCompra1.txtCant1.Text & ", 0)"
                Consulta()
            End If
            If OrdendeCompra1.lblVT2.Text <> "" Then
                sql = "insert into DetOrdComp_Ins values(''," & lblNOrdComp.Text & ", " & OrdendeCompra1.lblIdI2.Text & ", " & OrdendeCompra1.txtCant2.Text & ", " & OrdendeCompra1.lblVU2.Text & ", " & OrdendeCompra1.txtCant2.Text & ", 0)"
                Consulta()
            End If
            If OrdendeCompra1.lblVT3.Text <> "" Then
                sql = "insert into DetOrdComp_Ins values(''," & lblNOrdComp.Text & ", " & OrdendeCompra1.lblIdI3.Text & ", " & OrdendeCompra1.txtCant3.Text & ", " & OrdendeCompra1.lblVU3.Text & ", " & OrdendeCompra1.txtCant3.Text & ", 0)"
                Consulta()
            End If
            If OrdendeCompra1.lblVT4.Text <> "" Then
                sql = "insert into DetOrdComp_Ins values(''," & lblNOrdComp.Text & ", " & OrdendeCompra1.lblIdI4.Text & ", " & OrdendeCompra1.txtCant4.Text & ", " & OrdendeCompra1.lblVU4.Text & ", " & OrdendeCompra1.txtCant4.Text & ", 0)"
                Consulta()
            End If
            If OrdendeCompra1.lblVT5.Text <> "" Then
                sql = "insert into DetOrdComp_Ins values(''," & lblNOrdComp.Text & ", " & OrdendeCompra1.lblIdI5.Text & ", " & OrdendeCompra1.txtCant5.Text & ", " & OrdendeCompra1.lblVU5.Text & ", " & OrdendeCompra1.txtCant5.Text & ", 0)"
                Consulta()
            End If
            If OrdendeCompra1.lblVT6.Text <> "" Then
                sql = "insert into DetOrdComp_Ins values(''," & lblNOrdComp.Text & ", " & OrdendeCompra1.lblIdI6.Text & ", " & OrdendeCompra1.txtCant6.Text & ", " & OrdendeCompra1.lblVU6.Text & ", " & OrdendeCompra1.txtCant6.Text & ", 0)"
                Consulta()
            End If
            If OrdendeCompra1.lblVT7.Text <> "" Then
                sql = "insert into DetOrdComp_Ins values(''," & lblNOrdComp.Text & ", " & OrdendeCompra1.lblIdI7.Text & ", " & OrdendeCompra1.txtCant7.Text & ", " & OrdendeCompra1.lblVU7.Text & ", " & OrdendeCompra1.txtCant7.Text & ", 0)"
                Consulta()
            End If
            If OrdendeCompra1.lblVT8.Text <> "" Then
                sql = "insert into DetOrdComp_Ins values(''," & lblNOrdComp.Text & ", " & OrdendeCompra1.lblIdI8.Text & ", " & OrdendeCompra1.txtCant8.Text & ", " & OrdendeCompra1.lblVU8.Text & ", " & OrdendeCompra1.txtCant8.Text & ", 0)"
                Consulta()
            End If

            If OrdendeCompra2.lblVT1.Text <> "" Then
                sql = "insert into DetOrdComp_Med values(''," & lblNOrdComp.Text & ", " & OrdendeCompra2.lblIdMed1.Text & ", " & OrdendeCompra2.txtCant1.Text & ", " & OrdendeCompra2.lblVU1.Text & ", " & OrdendeCompra2.txtCant1.Text & ", 0)"
                Consulta()
            End If
            If OrdendeCompra2.lblVT2.Text <> "" Then
                sql = "insert into DetOrdComp_Med values(''," & lblNOrdComp.Text & ", " & OrdendeCompra2.lblIdMed2.Text & ", " & OrdendeCompra2.txtCant2.Text & ", " & OrdendeCompra2.lblVU2.Text & ", " & OrdendeCompra2.txtCant2.Text & ", 0)"
                Consulta()
            End If
            If OrdendeCompra2.lblVT3.Text <> "" Then
                sql = "insert into DetOrdComp_Med values(''," & lblNOrdComp.Text & ", " & OrdendeCompra2.lblIdMed3.Text & ", " & OrdendeCompra2.txtCant3.Text & ", " & OrdendeCompra2.lblVU3.Text & ", " & OrdendeCompra2.txtCant3.Text & ", 0)"
                Consulta()
            End If
            If OrdendeCompra2.lblVT4.Text <> "" Then

                sql = "insert into DetOrdComp_Med values(''," & lblNOrdComp.Text & ", " & OrdendeCompra2.lblIdMed4.Text & ", " & OrdendeCompra2.txtCant4.Text & ", " & OrdendeCompra2.lblVU4.Text & ", " & OrdendeCompra2.txtCant4.Text & ", 0)"
                Consulta()
            End If
            If OrdendeCompra2.lblVT5.Text <> "" Then
                sql = "insert into DetOrdComp_Med values(''," & lblNOrdComp.Text & ", " & OrdendeCompra2.lblIdMed5.Text & ", " & OrdendeCompra2.txtCant5.Text & ", " & OrdendeCompra2.lblVU5.Text & ", " & OrdendeCompra2.txtCant5.Text & ", 0)"
                Consulta()
            End If
            If OrdendeCompra2.lblVT6.Text <> "" Then
                sql = "insert into DetOrdComp_Med values(''," & lblNOrdComp.Text & ", " & OrdendeCompra2.lblIdMed6.Text & ", " & OrdendeCompra2.txtCant6.Text & ", " & OrdendeCompra2.lblVU6.Text & ", " & OrdendeCompra2.txtCant6.Text & ", 0)"
                Consulta()
            End If
            If OrdendeCompra2.lblVT7.Text <> "" Then
                sql = "insert into DetOrdComp_Med values(''," & lblNOrdComp.Text & ", " & OrdendeCompra2.lblIdMed7.Text & ", " & OrdendeCompra2.txtCant7.Text & ", " & OrdendeCompra2.lblVU7.Text & ", " & OrdendeCompra2.txtCant7.Text & ", 0)"
                Consulta()
            End If
            If OrdendeCompra2.lblVT8.Text <> "" Then
                sql = "insert into DetOrdComp_Med values(''," & lblNOrdComp.Text & ", " & OrdendeCompra2.lblIdMed8.Text & ", " & OrdendeCompra2.txtCant8.Text & ", " & OrdendeCompra2.lblVU8.Text & ", " & OrdendeCompra2.txtCant8.Text & ", 0)"
                Consulta()
            End If
            'iMPRIMIR
            Me.Hide()
            MenuFarmacia.Show()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelar.Click
        opc = MsgBox("¿Desea cancelar y volver a la carga de los medicamentos?", vbYesNo)
        If opc = 6 Then
            Me.Hide()
            OrdendeCompra2.Show()
        End If
    End Sub

End Class
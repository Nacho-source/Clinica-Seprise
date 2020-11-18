'Option Explicit On
'Imports System.Data.Odbc
'Imports System.Globalization

'Public Class MenuFarmacia
'    Dim cambio As New CultureInfo("es-ES")
'    Private Sub btnProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProveedor.Click

'        T = "Proveedor"

'        Me.Hide()
'        GrillaFarmacia.Show()

'    End Sub

'    Private Sub MenuFarmacia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        AbrirConexion()

'    End Sub

'    Private Sub btnMedIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedIns.Click

'        T = "MyI"


'        Me.Hide()
'        GrillaFarmacia.Show()
'    End Sub

'    Private Sub btnPedidos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPedidos.Click
'        T = "Pedido"


'        Me.Hide()
'        GrillaFarmacia.Show()
'    End Sub

'    Private Sub btnContPaq_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnContPaq.Click
'        T = "Paquete"


'        Me.Hide()
'        GrillaFarmacia.Show()
'    End Sub

'    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
'        cambio.NumberFormat.NumberDecimalSeparator = (".")
'        System.Threading.Thread.CurrentThread.CurrentCulture = cambio
'        Dim rs As OdbcDataReader
'        Dim cantidadSectores As Integer
'        Dim eoff As Boolean = False
'        Dim pedidoSector As Boolean = False
'        sql = "select count(*) from Sector"
'        rs = Consulta()
'        rs.Read()
'        cantidadSectores = rs.Item(0)
'        For i As Integer = 1 To cantidadSectores
'            sql = "select * from Pedido where Fecha= curdate() and IdSector=" & i
'            rs = Consulta()
'            If rs.Read() = False Then
'                sql = "select IdInsumo, Stock, PP, Porcentaje from Insumo_Sector where IdSector=" & i
'                rs = Consulta()
'                Do While eoff = False
'                    If rs.Read() = True Then
'                        If (rs.Item(1) < rs.Item(2)) Then
'                            If pedidoSector = False Then
'                                sql = "insert into Pedido Values(''," & i & ", -1, curdate())"
'                                Consulta()
'                                pedidoSector = True
'                            End If
'                            sql = "insert into DetPedidoIns values ('', (select max(IdPedido) from Pedido)," & rs.Item(0) & ", " & ((rs.Item(2) * rs.Item(3)) / 100) & ", " & ((rs.Item(2) * rs.Item(3)) / 100) & ",0)"
'                            Consulta()
'                        End If
'                    Else
'                        eoff = True
'                    End If
'                Loop
'                eoff = False
'                sql = "select IdMedicamento, Stock, PP, Porcentaje from Medicamento_Sector where IdSector=" & i
'                rs = Consulta()
'                Do While eoff = False
'                    If rs.Read() = True Then
'                        If (rs.Item(1) < rs.Item(2)) Then
'                            If pedidoSector = False Then
'                                sql = "insert into Pedido Values(''," & i & ", 0, curdate())"
'                                Consulta()
'                                pedidoSector = True
'                            End If
'                            sql = "insert into DetPedidoMed values ('', (select max(IdPedido) from Pedido)," & rs.Item(0) & ", " & ((rs.Item(2) * rs.Item(3)) / 100) & ", " & ((rs.Item(2) * rs.Item(3)) / 100) & ",0)"
'                            Consulta()
'                        End If
'                    Else
'                        eoff = True
'                    End If
'                Loop
'            End If
'            i = i + 1
'        Next
'        MsgBox("Se han actualizado los pedidos!!!!!!!!!")

'    End Sub
'    Function obtenerFechaActual()
'        Dim rs As OdbcDataReader
'        sql = "select curdate()"
'        rs = Consulta()
'        rs.Read()
'        Return rs.Item(0)
'    End Function

'    Private Sub btnOrdDeCompra_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOrdDeCompra.Click
'        Me.Hide()
'        OrdendeCompra1.Show()

'    End Sub

'    Private Sub btnFactProv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFactProv.Click
'        T = "FacturaProveedor"
'        Me.Hide()
'        GrillaFarmacia.Show()
'    End Sub

'    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSalir.Click
'        Dim opc As Integer
'        If btnSalir.Text = "SALIR" Then

'            opc = MsgBox("¿Esta seguro que desea cerrar el programa?", vbYesNo)
'            If opc = 6 Then

'                End

'            End If

'        ElseIf btnSalir.Text = "Volver" Then

'            Me.Hide()
'            Administracion.Show()

'        End If

'    End Sub

'    Private Sub btnControlArtSec_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnControlArtSec.Click
'        T = "Articulo Sector"
'        Me.Hide()
'        GrillaFarmacia.Show()
'    End Sub
'End Class

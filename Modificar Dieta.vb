Option Explicit On

Public Class frmModificarDieta

    Dim opc As Integer
    Dim valorprueba As Boolean = False
    Dim DatoSeleccionadoGeneralDesc As String
    Dim DatoSeleccionadoGeneralId As Integer
    Dim rsModificarDieta As Odbc.OdbcDataReader
    Dim rsCargaModificarDieta As Odbc.OdbcDataReader
    Dim DatoSeleccionadoDetalleId As Integer
    Dim DatoSeleccionadoDetalleDesc As String

    Private Sub btnAgregarPlato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPlato.Click
        If cboPlatoDietaModif.Text <> "" Then
            If DatoSeleccionadoGeneralId > 0 Then
                opc = MsgBox("¿Esta seguro que quiere modificar este plato agregando el plato " & cboPlatoDietaModif.Text & "?", MsgBoxStyle.YesNo)
                If opc = 6 Then

                    'hacer if viendo si existe el plato en la dieta
                    sql = "select p.Descripcion from Plato p inner join Dieta_Plato DP on p.IdPlato=DP.IdPlato where p.Descripcion = '" & cboPlatoDietaModif.Text & "'"
                    rsModificarDieta = Consulta()
                    rsModificarDieta.Read()
                    If IsDBNull(rsModificarDieta(0)) = False Then

                        sql = "select IdPlato from Plato where Descripcion = '" & cboPlatoDietaModif.Text & "'"
                        rsModificarDieta = Consulta()
                        rsModificarDieta.Read()
                        If IsDBNull(rsModificarDieta(0)) = False Then
                            If opc = 6 Then
                                sql = "insert into Dieta_Plato values ('" & rsModificarDieta(0) & "', '" & DatoSeleccionadoGeneralId & "')"
                                rsModificarDieta = Consulta()
                                'MsgBox("entro")

                                sql = "select p.* from Plato p inner join Dieta_Plato DP on p.IdPlato=DP.IdPlato where DP.IdDieta='" & DatoSeleccionadoGeneralId & "'"
                                dgvDetalleDietaModif.DataSource = ConsultaDG("DetalleDietaModif")
                            End If
                        Else
                            MsgBox("Ya esta el plato en la tabla", vbCritical, "Error")
                        End If
                    Else
                        MsgBox("Ya existe este plato en la dieta", vbCritical, "Error")
                    End If
                End If
            Else
                MsgBox("Tiene que elegir una Dieta a modificar", vbCritical, "Error")
            End If
        Else
            MsgBox("Debe seleccionar un plato en el combo", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click

        Me.Hide()
        frmMenuDieta.Show()

    End Sub

    Private Sub frmModificarDieta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        sql = "select * from Dieta"
        dgvDietaModif.DataSource = ConsultaDG("DietaModif")

        cboPlatoDietaModif.Items.Clear()
        sql = "select Descripcion from Plato"
        rsCargaModificarDieta = Consulta()
        While rsCargaModificarDieta.Read() = True
            cboPlatoDietaModif.Items.Add(rsCargaModificarDieta(0))
        End While

    End Sub

    Private Sub dgvDietaModif_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDietaModif.CellContentClick

        'MsgBox(dgvDietaModif.Rows(e.RowIndex).Cells(0).Value.ToString())
        'MsgBox(dgvDietaModif.Rows(e.RowIndex).Cells(1).Value.ToString())
        'MsgBox(dgvDietaModif.Rows(e.RowIndex).Cells(2).Value.ToString())

        DatoSeleccionadoGeneralId = dgvDietaModif.Rows(e.RowIndex).Cells(0).Value.ToString()
        DatoSeleccionadoGeneralDesc = dgvDietaModif.Rows(e.RowIndex).Cells(1).Value.ToString()

        'If valorprueba = True Then
        '    sql = "select p.Descripcion from Plato p inner join Dieta_Plato DP on p.IdPlato=DP.IdPlato where DP.IdDieta='" & DatoSeleccionadoGeneralId & "'"
        '    dgvDetalleDietaModif.DataSource = ConsultaDG("DetalleDietaModif")

        'End If

        'If valorprueba = False Then
        sql = "select p.* from Plato p inner join Dieta_Plato DP on p.IdPlato=DP.IdPlato where DP.IdDieta='" & DatoSeleccionadoGeneralId & "'"
        dgvDetalleDietaModif.DataSource = ConsultaDG("DetalleDietaModif")
        'End If





    End Sub

    Private Sub btnEliminarPlato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPlato.Click

        If DatoSeleccionadoGeneralId > 0 Then

            If DatoSeleccionadoDetalleId > 0 Then
                opc = MsgBox("Esta seguro que desea eliminar el plato '" & DatoSeleccionadoDetalleDesc & "'?", vbYesNo, "Confirmacion")

                sql = "delete from Dieta_Plato where (IdPlato = '" & DatoSeleccionadoDetalleId & "') and (IdDieta = '" & DatoSeleccionadoGeneralId & "')"
                rsCargaModificarDieta = Consulta()

                sql = "select p.* from Plato p inner join Dieta_Plato DP on p.IdPlato=DP.IdPlato where DP.IdDieta='" & DatoSeleccionadoGeneralId & "'"
                dgvDetalleDietaModif.DataSource = ConsultaDG("DetalleDietaModif")
            Else
                MsgBox("Tiene que elegir una plato a eliminar", vbCritical, "Error")
            End If
        Else
            MsgBox("Tiene que elegir una Dieta a modificar", vbCritical, "Error")
        End If

    End Sub

    Private Sub dgvDetalleDietaModif_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleDietaModif.CellContentClick

        DatoSeleccionadoDetalleId = dgvDetalleDietaModif.Rows(e.RowIndex).Cells(0).Value.ToString()
        DatoSeleccionadoDetalleDesc = dgvDetalleDietaModif.Rows(e.RowIndex).Cells(1).Value.ToString()
    End Sub
End Class

Public Class frmAgregarModificarPlato

    Private Sub frmAgregarModificarPlato_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles Me.Layout

        sql = "select IdPlato, Descripcion from Plato"
        dgvPlatos.DataSource = ConsultaDG("Platos")

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Me.Hide()
        fmrAgregarPlato.Show()

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click

        Me.Hide()
        frmMenuDieta.Show()

    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModificar.Click

        If fmrModificarPlato.platoMod = 0 Then

            MsgBox("Debe seleccionar un plato para realizar la accion", vbOKOnly, "Error de seleccion de plato")
        Else

            Me.Hide()
            fmrModificarPlato.Show()

        End If

    End Sub

    Private Sub dgvPlatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPlatos.CellContentClick

        fmrModificarPlato.platoMod = dgvPlatos.Rows(e.RowIndex).Cells(0).Value.ToString()

    End Sub
End Class

Public Class InformeLiquidacionSueldo


    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        AdministracionCE.Show()
        LiquidacionHonorarios.txtDNI.Text = ""

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Me.Hide()
        AdministracionCE.Show()
        LiquidacionHonorarios.txtDNI.Text = ""
    End Sub
End Class
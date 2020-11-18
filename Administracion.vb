Public Class Administracion

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInternación.Click

    End Sub

    Private Sub btnNutrición_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNutrición.Click

        Me.Hide()
        frmMenuDieta.Show()

    End Sub

    Private Sub btnEstudios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstudios.Click

        Me.Hide()
        Estudios.Show()

    End Sub

    Private Sub btnConfiguracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguracion.Click

    End Sub

    Private Sub btnFarmaciasInsumos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFarmaciasInsumos.Click

        Me.Hide()
        MenuFarmacia.btnSalir.Text = "Volver"
        MenuFarmacia.Show()

    End Sub

    Private Sub btnEnfermería_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnfermería.Click

        Me.Hide()
        frmMenuEnfermeria.Show()

    End Sub

    Private Sub btnGuardia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardia.Click
        Me.Hide()
        frmGuardia.Show()
    End Sub

    Private Sub btnConsultoriosExternos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultoriosExternos.Click
        AdministracionCE.Show()
        Me.Hide()

    End Sub

    Private Sub Administracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
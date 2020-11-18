Public Class MenuEstudios

    Private Sub MenuEstudios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngreso.Click

        Me.Hide()
        IngresoPaciente.Show()

    End Sub

    Private Sub Turnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Turnos.Click

        Me.Hide()
        AgendaTurnos.Show()

    End Sub
End Class
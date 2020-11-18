Public Class ElegirMedico

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        SolicitudTurno.Show()
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If (cboMed.Text = "") Then
            MsgBox("SELECCIONE UN MEDICO", vbExclamation, "ERROR")
        Else
            Me.Hide()
            SolicitudTurno.Show()
            SolicitudTurno.txtMedico.Text = cboMed.Text
        End If

    End Sub
End Class
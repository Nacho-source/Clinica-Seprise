Imports System.Data.Odbc
Public Class ModificarMedicoTurno
    Dim rs As OdbcDataReader
    Public id As Integer
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        TurnoGuardia.Show()
    End Sub

    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        sql = "UPDATE MedicoGuardia SET Comienzo = '" & Hora.Text & ":" & Minutos.Text & "', Duracion = " & Duracion.Text & " WHERE IdMedicoGuardia = " & id
        rs = Consulta()

        TurnoGuardia.TraerTurnos()
        Me.Hide()
        TurnoGuardia.Show()
    End Sub
End Class
Imports System.Data.Odbc
Public Class ActualizarEstado
    Public id As Integer
    Dim rs As OdbcDataReader

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        sql = "UPDATE AtencionPaciente SET estado = '" & txtEstado.Text & "' WHERE IdAtencionPaciente = " & id
        rs = Consulta()

        AtencionPacientes.cargar()
        Me.Hide()
        AtencionPacientes.Show()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        AtencionPacientes.Show()
    End Sub
End Class
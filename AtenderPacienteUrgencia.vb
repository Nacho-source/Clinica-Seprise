Imports System.Data.Odbc

Public Class AtenderPacienteUrgencia
    Dim rs As OdbcDataReader

    Public id As Integer
    Public idLista As Integer

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        frmListaEspera.Show()
    End Sub

    Public Sub cargarMedicos()
        rs = Consulta()

        While (rs.Read = True)
            cboMedico.Items.Add(rs(3) & " - " & rs(2) & " " & rs(1))
        End While
    End Sub

    Private Sub btnAtender_Click(sender As Object, e As EventArgs) Handles btnAtender.Click
        sql = "insert into AtencionPaciente values ('', " & id & ", " & Val(cboMedico.Text) & ", NOW(), NULL, '')"
        rs = Consulta()

        sql = "delete from listaespera where idpacientelista = " & idLista
        rs = Consulta()

        AtencionPacientes.cargar()
        frmListaEspera.actualizarLista()

        Me.Hide()
        frmListaEspera.Show()
    End Sub
End Class
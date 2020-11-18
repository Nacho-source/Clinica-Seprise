Option Explicit On
Imports System.Data.Odbc

Public Class frmGuardia
    Private Sub Guardia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AbrirConexion()
    End Sub

    Private Sub btnAgregarPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPaciente.Click
        Me.Hide()
        TurnoGuardia.Show()
    End Sub

    Private Sub btnListaEspera_Click(sender As Object, e As EventArgs) Handles btnListaEspera.Click
        Me.Hide()
        frmListaEspera.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        AtencionPacientes.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        InsumosMedicamentos.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        If btnVolver.Text = "Salir" Then

            If MsgBox("¿Desea salir del programa? ", MsgBoxStyle.YesNo, "Atencion!") = MsgBoxResult.Yes Then

                End

            End If

        ElseIf btnVolver.Text = "Volver" Then

            Me.Hide()
            Administracion.Show()

        End If
    End Sub
End Class

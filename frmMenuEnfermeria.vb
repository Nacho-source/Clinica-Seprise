Public Class frmMenuEnfermeria
    Private Sub cmdEgresoPac_Click(sender As Object, e As EventArgs) Handles cmdEgresoPac.Click
        EgresoPac.Show()
        Me.Hide()
    End Sub

    Private Sub cmdVisPeriod_Click(sender As Object, e As EventArgs) Handles cmdVisPeriod.Click
        frmVisPeriodEnfermeria.Show()
        Me.Hide()
    End Sub

    Private Sub cmdAltaRonda_Click(sender As Object, e As EventArgs) Handles cmdAltaRonda.Click
        frmRondaEnfermeria.Show()
        Me.Hide()
    End Sub

    Private Sub cmdVolver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdVolver.Click


        If cmdVolver.Text = "Salir" Then

            If MsgBox("¿Desea salir del programa? ", MsgBoxStyle.YesNo, "Atencion!") = MsgBoxResult.Yes Then

                End

            End If

        ElseIf cmdVolver.Text = "Volver" Then

            Me.Hide()
            Administracion.Show()

        End If

    End Sub

    Private Sub frmMenuEnfermeria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
    End Sub
End Class
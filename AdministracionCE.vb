Public Class AdministracionCE

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdTurno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTurno.Click
        Me.Hide()
        SolicitudTurno.Show()

    End Sub

    Private Sub cmdIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIngreso.Click
        Me.Hide()
        IngresoMedicoCE.Show()

    End Sub

    Private Sub cmdRecepcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRecepcion.Click
        Me.Hide()
        ListaEsperaCE.Show()

    End Sub

    Private Sub cmdHonorario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHonorario.Click

        Me.Hide()
        LiquidacionHonorarios.Show()

    End Sub

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Hide()
        'Administracion.show()
    End Sub

    Private Sub AdministracionCE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AbrirConexion()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        HistoriaClinicaCE.btnBack.Visible = False


        Me.Hide()
        HistoriaClinicaCE.Show()

    End Sub
End Class
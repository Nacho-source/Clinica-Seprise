Imports System.Data.Odbc

Public Class AgregarMedicoTurno
    Dim rsMeds As OdbcDataReader
    Dim rs As OdbcDataReader

    Private Sub AgregarMedico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select Nombre, Apellido, IdMedico from Medico, Empleado where Medico.idEmpleado = Empleado.idEmpleado"
        rsMeds = Consulta()

        While (rsMeds.Read = True)
            cboMedico.Items.Add(rsMeds(2) & " - " & rsMeds(0) & " " & rsMeds(1))
        End While
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim hora(7) As Integer
        Dim minutos(7) As Integer
        Dim duracion(7) As Integer
        Dim checked(7) As Boolean

        If (cboMedico.Text = "") Then
            MsgBox("Seleccione un medico")
        Else
            checked(0) = cbLunes.Checked
            checked(1) = cbMartes.Checked
            checked(2) = cbMiercoles.Checked
            checked(3) = cbJueves.Checked
            checked(4) = cbViernes.Checked
            checked(5) = cbSabado.Checked
            checked(6) = cbDomingo.Checked

            If (cbLunes.Checked = True) Then
                hora(0) = LHora.Value
                minutos(0) = LMinutos.Value
                duracion(0) = LDuracion.Value
            End If
            If (cbMartes.Checked = True) Then
                hora(1) = MaHora.Value
                minutos(1) = MaMinutos.Value
                duracion(1) = MaDuracion.Value
            End If
            If (cbMiercoles.Checked = True) Then
                hora(2) = MiHora.Value
                minutos(2) = MiMinutos.Value
                duracion(2) = MiDuracion.Value
            End If
            If (cbJueves.Checked = True) Then
                hora(3) = JuHora.Value
                minutos(3) = JuMinutos.Value
                duracion(3) = JuDuracion.Value
            End If
            If (cbViernes.Checked = True) Then
                hora(4) = ViHora.Value
                minutos(4) = ViMinutos.Value
                duracion(4) = ViDuracion.Value
            End If
            If (cbSabado.Checked = True) Then
                hora(5) = SaHora.Value
                minutos(5) = SaMinutos.Value
                duracion(5) = SaDuracion.Value
            End If
            If (cbDomingo.Checked = True) Then
                hora(6) = DomHora.Value
                minutos(6) = DomMinutos.Value
                duracion(6) = DomDuracion.Value
            End If

            Dim dia(7) As String

            dia(0) = "Lunes"
            dia(1) = "Martes"
            dia(2) = "Miercoles"
            dia(3) = "Jueves"
            dia(4) = "Viernes"
            dia(5) = "Sabado"
            dia(6) = "Domingo"

            For i As Integer = 0 To 6
                If (checked(i)) Then
                    sql = "insert into MedicoGuardia (IdMedico, Dia, Comienzo, Duracion) values ( " & Val(cboMedico.Text) & ", '" & dia(i) & "', '" & hora(i) & ":" & minutos(i) & "', " & duracion(i) & ")"
                    rs = Consulta()
                End If
            Next

            Me.Hide()
            TurnoGuardia.Show()
        End If
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        Me.Hide()
        TurnoGuardia.Show()
    End Sub


    Private Sub cbLunes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLunes.CheckedChanged
        If (cbLunes.Checked = False) Then
            LHora.Enabled = False
            LMinutos.Enabled = False
            LDuracion.Enabled = False
        Else
            LHora.Enabled = True
            LMinutos.Enabled = True
            LDuracion.Enabled = True
        End If
    End Sub

    Private Sub cbMartes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMartes.CheckedChanged
        If (cbMartes.Checked = False) Then
            MaHora.Enabled = False
            MaMinutos.Enabled = False
            MaDuracion.Enabled = False
        Else
            MaHora.Enabled = True
            MaMinutos.Enabled = True
            MaDuracion.Enabled = True
        End If
    End Sub

    Private Sub cbMiercoles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMiercoles.CheckedChanged
        If (cbMiercoles.Checked = False) Then
            MiHora.Enabled = False
            MiMinutos.Enabled = False
            MiDuracion.Enabled = False
        Else
            MiHora.Enabled = True
            MiMinutos.Enabled = True
            MiDuracion.Enabled = True
        End If
    End Sub

    Private Sub cbJueves_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbJueves.CheckedChanged
        If (cbJueves.Checked = False) Then
            JuHora.Enabled = False
            JuMinutos.Enabled = False
            JuDuracion.Enabled = False
        Else
            JuHora.Enabled = True
            JuMinutos.Enabled = True
            JuDuracion.Enabled = True
        End If
    End Sub

    Private Sub cbViernes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbViernes.CheckedChanged
        If (cbViernes.Checked = False) Then
            ViHora.Enabled = False
            ViMinutos.Enabled = False
            ViDuracion.Enabled = False
        Else
            ViHora.Enabled = True
            ViMinutos.Enabled = True
            ViDuracion.Enabled = True
        End If
    End Sub

    Private Sub cbSabado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSabado.CheckedChanged
        If (cbSabado.Checked = False) Then
            SaHora.Enabled = False
            SaMinutos.Enabled = False
            SaDuracion.Enabled = False
        Else
            SaHora.Enabled = True
            SaMinutos.Enabled = True
            SaDuracion.Enabled = True
        End If
    End Sub

    Private Sub cbDomingo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDomingo.CheckedChanged
        If (cbDomingo.Checked = False) Then
            DomHora.Enabled = False
            DomMinutos.Enabled = False
            DomDuracion.Enabled = False
        Else
            DomHora.Enabled = True
            DomMinutos.Enabled = True
            DomDuracion.Enabled = True
        End If
    End Sub
End Class
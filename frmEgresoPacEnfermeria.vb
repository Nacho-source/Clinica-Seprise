Public Class EgresoPac
    Dim rs As Odbc.OdbcDataReader
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        sql = "select count(*) from paciente p, internacionconsentimiento ic where documentacion=" & txtDNI.Text & " and p.idpaciente=ic.idpaciente"
        MsgBox(sql)
        rs = Consulta()
        rs.Read()
        If rs(0) = 1 Then
            cmdBuscar.Visible = False
            txtDNI.Enabled = False
            cmdVerifAlta.Visible = True
        Else
            MsgBox("El paciente con el DNI " & txtDNI.Text & " no se encuentra en la base de datos", , "Error")
            txtDNI.Text = ""
        End If
    End Sub

    Private Sub cmdVerifAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerifAlta.Click
        sql = "select count(*) from paciente p, internacionconsentimiento ic where documentacion=" & txtDNI.Text & " and p.idpaciente=ic.idpaciente and ic.alta=true"
        rs = Consulta()
        rs.Read()
        If rs(0) = 0 Then
            MsgBox("El paciente aun no ha sido dado de alta.")

        Else
            MsgBox("El paciente ha sido dado de alta. Imprima el comprobante")
            sql = "select internado from paciente where documentacion=" & txtDNI.Text
            rs = Consulta()
            rs.Read()
            If (rs(0).Equals(DBNull.Value)) = False Then
                If rs(0) = 1 Then
                    sql = "update paciente set internado=false where documentacion=" & txtDNI.Text
                    Consulta()
                    sql = "update habitacion_internacion set ocupadas=ocupadas-1 where nrohabi= (select nrohabi from internacionconsentimiento where idpaciente=(select idpaciente from paciente where documentacion=" & txtDNI.Text & "))"
                    Consulta()
                Else
                    sql = "select internadourgente from paciente where documentacion=" & txtDNI.Text
                    rs = Consulta()
                    rs.Read()
                    If (rs(0).Equals(DBNull.Value)) = False Then
                        If rs(0) = 1 Then
                            sql = "update paciente set internadourgente=false where documentacion=" & txtDNI.Text
                            Consulta()
                        End If
                    End If
                End If
            End If
            cmdVerifAlta.Visible = False
            cmdPrint.Visible = True
        End If
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        sql = "select nombre, apellido from paciente where documentacion= " & txtDNI.Text
        rs = Consulta()
        rs.Read()
        frmComprobAltaEnfermeria.Label9.Text = "Nombre del paciente = " & rs(0) & " " & rs(1)
        frmComprobAltaEnfermeria.Show()
        Me.cmdVerifAlta.Visible = True
        Me.txtDNI.Text = ""
        Me.cmdPrint.Visible = False
        Me.Hide()
    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        Me.Hide()
        frmMenuEnfermeria.Show()
    End Sub

End Class
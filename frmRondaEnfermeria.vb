Option Explicit On
Public Class frmRondaEnfermeria
    Dim fecha As String
    Dim hora As String
    Dim diasi As String
    Dim diasm As String
    Dim rs As Odbc.OdbcDataReader

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select max(NroRonda) from Ronda"
        rs = Consulta()
        rs.Read()
        txtNR.Text = "" & rs(0) + 1
        sql = "select idpaciente, nombre, apellido, documentacion from paciente"
        rs = Consulta()
        While (rs.Read = True)
            cboPaciente.Items.Add(rs(0) & " " & rs(1) & " " & rs(2) & " " & rs(3))
        End While
        sql = "select m.IdMedico, e.nombre, e.apellido, e.documentacion from empleado e, medico m where e.idempleado=m.idempleado"
        rs = Consulta()
        While (rs.Read = True)
            cboMedico.Items.Add(rs(0) & " " & rs(1) & " " & rs(2) & " " & rs(3))
        End While
        sql = "select idinsumo, nombre from insumo"
        rs = Consulta()
        While (rs.Read = True)
            cboInsumo.Items.Add(rs(0) & " " & rs(1))
        End While
        sql = "select idmedicamento, nombre from medicamento"
        rs = Consulta()
        While (rs.Read = True)
            cboMedicamento.Items.Add(rs(0) & " " & rs(1))
        End While
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        fecha = txtAño.Text & "-" & txtMes.Text & "-" & txtDia.Text
        hora = txtHora.Text & ":" & txtMinutos.Text & ":00"
        sql = "insert into Ronda values(''," & Val(cboPaciente.Text) & "," & Val(cboMedico.Text) & ",'" & txtObs.Text & "','" & fecha & "','" + hora + "')"
        Consulta()

        sql = "select max(NroRonda) from Ronda"
        rs = Consulta()
        rs.Read()

        If chkDI.Checked = True Then
            diasi = diasi & "D"
        End If
        If chkLI.Checked = True Then
            diasi = diasi & "L"
        End If
        If chkMI.Checked = True Then
            diasi = diasi & "M"
        End If
        If chkMMI.Checked = True Then
            diasi = diasi & "Mier"
        End If
        If chkJI.Checked = True Then
            diasi = diasi & "J"
        End If
        If chkVI.Checked = True Then
            diasi = diasi & "V"
        End If
        If chkSI.Checked = True Then
            diasi = diasi & "S"
        End If

        If chkDM.Checked = True Then
            diasm = diasm & "D"
        End If
        If chkLM.Checked = True Then
            diasm = diasm & "L"
        End If
        If chkMM.Checked = True Then
            diasm = diasm & "M"
        End If
        If chkMMM.Checked = True Then
            diasm = diasm & "Mier"
        End If
        If chkJM.Checked = True Then
            diasm = diasm & "J"
        End If
        If chkVM.Checked = True Then
            diasm = diasm & "V"
        End If
        If chkSM.Checked = True Then
            diasm = diasm & "S"
        End If

        If (cboInsumo.Text <> "Seleccionar insumo") Then
            sql = "insert into RondaPacInsumo values('', " & rs(0) & ", " & Val(cboInsumo.Text) & ",'" & diasi & "," & horasI.Text & "," & cantI.Text & ")"
            Consulta()
        End If

        If (cboMedicamento.Text <> "Seleccionar medicamento") Then
            sql = "insert into RondaPacMedic values ('', " & rs(0) & ", " & Val(cboMedicamento.Text) & ",'" & diasm & "'," & horasM.Text & "," & cantM.Text & ")"
            Consulta()
        End If

        blanquearCampos()
    End Sub

    Private Sub rbInsumo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbInsumo.CheckedChanged
        If rbInsumo.Checked = True Then
            gbInsumo.Visible = True
        ElseIf (gbInsumo.Visible = True) Then
            gbInsumo.Visible = False
        End If
    End Sub

    Private Sub rbMedicamento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMedicamento.CheckedChanged
        If rbMedicamento.Checked = True Then
            gbMedic.Visible = True
        ElseIf (gbMedic.Visible = True) Then
            gbMedic.Visible = False
        End If
    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        blanquearCampos()
        Me.Hide()
        frmMenuEnfermeria.Show()
    End Sub

    Private Function blanquearCampos()
        diasi = ""
        diasm = ""
        fecha = ""
        hora = ""
        txtAño.Text = ""
        txtDia.Text = ""
        txtHora.Text = ""
        txtMes.Text = ""
        txtMinutos.Text = ""
        txtNR.Text = ""
        txtObs.Text = ""
        cboInsumo.Text = "Seleccionar insumo"
        cboMedicamento.Text = "Seleccionar medicamento"
        cboPaciente.Text = "Seleccionar paciente"
        cboMedico.Text = "Seleccionar medico"
        horasM.Text = ""
        horasI.Text = ""
        chkDI.Checked = False
        chkDM.Checked = False
        chkJM.Checked = False
        chkJI.Checked = False
        chkLI.Checked = False
        chkLM.Checked = False
        chkMI.Checked = False
        chkMM.Checked = False
        chkMMI.Checked = False
        chkMMM.Checked = False
        chkSI.Checked = False
        chkSM.Checked = False
        chkVI.Checked = False
        chkVM.Checked = False
    End Function
End Class

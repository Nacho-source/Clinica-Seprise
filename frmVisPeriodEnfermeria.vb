Public Class frmVisPeriodEnfermeria
    Dim rs As Odbc.OdbcDataReader
    Dim dia As String
    Dim row As Integer
    Private Sub VisPeriod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select dayofweek(curdate())"
        rs = Consulta()
        rs.Read()
        If rs(0) = 1 Then
            dia = "D"
        ElseIf rs(0) = 2 Then
            dia = "L"
        ElseIf rs(0) = 3 Then
            dia = "M"
        ElseIf rs(0) = 4 Then
            dia = "Mier"
        ElseIf rs(0) = 5 Then
            dia = "J"
        ElseIf rs(0) = 6 Then
            dia = "V"
        ElseIf rs(0) = 7 Then
            dia = "S"
        End If

        sql = "select distinct r.idpaciente, ic.idhabitacion, rm.idmedicamento, m.nombre, rm.canhora, rm.cantidad, m.presen from ronda r, internacionconsentimiento ic, rondapacmedic rm, medicamento m where rm.dias like '%" & dia & "%' and ic.idpaciente=r.idpaciente and rm.idmedicamento=rm.idmedicamento"
        DGVisPeriodM.DataSource = ConsultaDG("VisPeriod")

        sql = "select distinct r.idpaciente, ic.idhabitacion, ri.idinsumo, i.nombre, ri.canhora, ri.cantidad from ronda r, internacionconsentimiento ic, rondapacinsumo ri, insumo i where ri.dias like '%" & dia & "%' and ic.idpaciente=r.idpaciente and ri.idinsumo=i.idinsumo"
        DGVisPeriodI.DataSource = ConsultaDG("VisPeriod")
    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        Me.Hide()
        frmMenuEnfermeria.Show()
    End Sub

    Private Sub DGVisPeriodI_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DGVisPeriodI.MouseDoubleClick
        frmAltaVisitaPeriodEnfermeria.txtIP.Text = DGVisPeriodI.CurrentRow.Cells(0).Value
        frmAltaVisitaPeriodEnfermeria.IdInsumo = DGVisPeriodI.CurrentRow.Cells(2).Value
        frmAltaVisitaPeriodEnfermeria.cantidad = DGVisPeriodI.CurrentRow.Cells(5).Value
        frmAltaVisitaPeriodEnfermeria.tipoVisita = False
        Me.Hide()
        frmAltaVisitaPeriodEnfermeria.Show()
    End Sub

    Private Sub DGVisPeriodM_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DGVisPeriodM.MouseDoubleClick
        frmAltaVisitaPeriodEnfermeria.txtIP.Text = DGVisPeriodM.CurrentRow.Cells(0).Value
        frmAltaVisitaPeriodEnfermeria.idMedicamento = DGVisPeriodM.CurrentRow.Cells(2).Value
        frmAltaVisitaPeriodEnfermeria.cantidad = DGVisPeriodM.CurrentRow.Cells(5).Value
        frmAltaVisitaPeriodEnfermeria.tipoVisita = True
        Me.Hide()
        frmAltaVisitaPeriodEnfermeria.Show()
    End Sub
End Class
Public Class RecetaCE
    Dim opc As Integer
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        opc = MsgBox("¿Esta seguro que desea Cancelar esta Receta?", MsgBoxStyle.YesNo)

        If (opc = 6) Then

            AtencionPaciente.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        opc = MsgBox("¿Esta seguro que desea Imprimir esta Receta?", MsgBoxStyle.YesNo)

        If (opc = 6) Then
            'Me.PrintForm1.Print()
            ListaEsperaCE.Show()
            Me.Hide()
        Else
            Me.Show()
        End If

        btnBack.Visible = False
        btnPrint.Visible = False
    End Sub

    Private Sub RecetaCE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnBack.Visible = True
        btnPrint.Visible = True
    End Sub
    Private Sub RecetaCE_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnBack.Visible = True
        btnPrint.Visible = True
    End Sub
End Class
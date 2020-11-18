Option Explicit On
Imports System.Data.Odbc

Public Class frmMenuDieta

    Dim rsLPedido As OdbcDataReader
    Dim rsLPedidoOperaciones As OdbcDataReader
    Dim DatoSeleccionadoGeneral As String
    Dim opc As Integer

    Private Sub frmMenuDieta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        sql = "select * from dieta"
        dgvDieta.DataSource = ConsultaDG("DietaGeneral")

    End Sub

    Private Sub frmMenuDieta_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AbrirConexion()

    End Sub

    Private Sub btnModificarDieta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarDieta.Click

        frmModificarDieta.Show()
        Me.Hide()

    End Sub

    Private Sub btnAgregarDieta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDieta.Click

        Me.Hide()
        frmCrearDieta.Show()

    End Sub

    Private Sub dgvDieta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDieta.CellContentClick

        'MsgBox(dgvDieta.Rows(e.RowIndex).Cells(0).Value.ToString())
        'MsgBox(dgvDieta.Rows(e.RowIndex).Cells(1).Value.ToString())
        'MsgBox(dgvDieta.Rows(e.RowIndex).Cells(2).Value.ToString())


        sql = "select p.* from Plato p inner join Dieta_Plato DP on p.IdPlato=DP.IdPlato where DP.IdDieta='" & dgvDieta.Rows(e.RowIndex).Cells(0).Value.ToString() & "'"
        dgvDetalleDieta.DataSource = ConsultaDG("DetalleDietaGeneral")

        DatoSeleccionadoGeneral = dgvDieta.Rows(e.RowIndex).Cells(0).Value.ToString()

    End Sub

    Private Sub btnEliminarDieta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDieta.Click

        opc = MsgBox("¿Esta seguro que desea eliminar esta dieta?" & vbCrLf & "IMPORTANTE: Al eliminar esta dieta esta retirandola de todos los pacientes que la tengan", vbYesNo)
        If opc = 6 Then
            If DatoSeleccionadoGeneral > 0 Then
                sql = "select count(IdDieta) from Dieta where IdDieta='" & DatoSeleccionadoGeneral & "'"
                rsLPedido = Consulta()
                rsLPedido.Read()
                If rsLPedido(0) = 1 Then

                    sql = "Delete from Dieta_Plato where IdDieta='" & DatoSeleccionadoGeneral & "'"
                    rsLPedidoOperaciones = Consulta()

                    sql = "Delete from DietaPaciente where IdDieta='" & DatoSeleccionadoGeneral & "'"
                    rsLPedidoOperaciones = Consulta()

                    sql = "Delete from Dieta where IdDieta='" & DatoSeleccionadoGeneral & "'"
                    rsLPedidoOperaciones = Consulta()

                    sql = "select * from dieta"
                    dgvDieta.DataSource = ConsultaDG("DietaGeneral")
                Else
                    MsgBox("No se encuentra la dieta seleccionada", vbCritical, "Error")
                End If
            Else
                MsgBox("Debe seleccionar una Dieta a eliminar en el recuadro de la izquierda", vbCritical, "Error")
            End If
        End If
        'MsgBox("", vbCritical, "Error")  nota: utilizar para los errores
    End Sub

    Private Sub btnAgregarPlatoNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPlatoNuevo.Click

        Me.Hide()
        frmAgregarModificarPlato.Show()

    End Sub

    Private Sub lblAsignarPaciente_Click(sender As Object, e As EventArgs) Handles lblAsignarPaciente.Click

        Me.Hide()
        fmrAsignarPaciente.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
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
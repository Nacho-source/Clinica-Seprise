
Imports System.Data.Odbc
Public Class fmrAsignarPaciente

    Dim rs2 As OdbcDataReader
    Dim rs3 As OdbcDataReader

    Dim paciente As Integer
    Dim dieta As Integer
    Dim pregunta As Boolean
    Dim verificadorPaciente As Boolean = False
    Dim verificadorDieta As Boolean = False
    Dim duracion As Integer
    Dim inicio As String
    Dim noPermitido As Boolean = False

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        pregunta = MsgBox("Esta seguro que desea volver?", MsgBoxStyle.OkCancel, "VOLVER")

        If pregunta = True Then

            Me.Hide()
            frmMenuDieta.Show()

        End If

    End Sub

    Private Sub fmrAsignarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Completar lista de Dietas

        sql = "select * from dieta"
        dgvDieta.DataSource = ConsultaDG("Dietas")

        ' Completar lista de pacientes

        sql = "select idpaciente, nombre, apellido, documentacion from paciente"
        dgvPaciente.DataSource = ConsultaDG("Dietas")


    End Sub

    Private Sub dgvPaciente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPaciente.CellContentClick

        paciente = dgvPaciente.CurrentRow.Cells.Item(0).Value

        verificadorPaciente = True

    End Sub

    Private Sub dgvDieta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDieta.CellContentClick

        dieta = dgvDieta.CurrentRow.Cells.Item(0).Value

        sql = "select dp.idplato, p.descripcion from dieta_plato dp, plato p where (iddieta = " & dieta & ") and (dp.idplato = p.idplato)"
        dgvDetalle.DataSource = ConsultaDG("Platos")

        verificadorDieta = True

    End Sub

    Private Sub btnAsignarPaciente_Click(sender As Object, e As EventArgs) Handles btnAsignarPaciente.Click

        pregunta = MsgBox("Desea asignar la dieta?", MsgBoxStyle.OkCancel, "Asignar dieta")

        If (verificadorPaciente = False) Then

            MsgBox("No ha seleccionado un paciente!", MsgBoxStyle.OkOnly, "Error de asignacion de dieta")

            pregunta = False

        End If

        If (verificadorDieta = False) Then

            MsgBox("No ha seleccionado una dieta!", MsgBoxStyle.OkOnly, "Error de asignacion de dieta")

            pregunta = False

        End If

        ' Verificacion de ingrediente no permitido

        sql = "select I.IdIngrediente from Ingrediente I inner join ingredientenopermitido IP on I.IdIngrediente=IP.IdIngrediente inner join Enfermedad E on IP.IdEnfermedad=E.IdEnfermedad inner join PacienteEnfermedad PE on E.IdEnfermedad=PE.IdEnfermedad where idpaciente = " & paciente
        rs2 = Consulta()

        While rs2.Read = True

            sql = "select distinct idingrediente from plato P inner join dieta_plato DP on DP.IdPlato = P.IdPlato inner join plato_ingrediente PLI on PLI.IdPlato = P.IdPlato where DP.iddieta = " & dieta
            rs3 = Consulta()

            While rs3.Read = True

                If (rs2(0) = rs3(0)) Then

                    pregunta = False
                    noPermitido = True

                End If

            End While

        End While

        If (noPermitido = True) Then

            MsgBox("El paciente no tiene permitido consumir la dieta, ya que posee un ingrediente que no puede comer", vbOKOnly, "Error")

        End If

        If (pregunta = True) Then

            duracion = InputBox("Ingrese la cantidad de dias de duracion de la dieta (Maximo 200 dias)", "Duracion de dias")

            If (duracion <= 0) Or (duracion > 200) Then

                MsgBox("Error. La duracion debe durar entre 1 y 200 dias", vbOKOnly, "Error")

                duracion = InputBox("Ingrese la cantidad de dias de duracion de la dieta (Maximo 200 dias)", "Duracion de dias")

            End If

            sql = "insert into dietapaciente values(" & dieta & "," & paciente & "," & duracion & ",curdate())"
            rs2 = Consulta()
            rs2.Read()

            MsgBox("Se a asignado la dieta al paciente", vbOKOnly, "Dieta asignada")

        End If

    End Sub
End Class
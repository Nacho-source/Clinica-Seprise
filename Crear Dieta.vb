Option Explicit On

Imports System.Data.Odbc

Public Class frmCrearDieta

    Dim rs2 As OdbcDataReader

    Dim plato As String
    Dim idplato As String
    Dim errorNom As Boolean
    Dim vuelta As Boolean = True

    Private Sub btnCrearDieta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearDieta.Click

        Dim pregunta As Boolean
        Dim id As Integer
        Dim cantidad As Integer
        Dim descripcion As String

        cantidad = lstPlatosDieta.Items.Count

        pregunta = MsgBox("Desea crear la dieta?", MsgBoxStyle.OkCancel, "Crear dieta")

        If cantidad = 0 Then

            MsgBox("La dieta no posee platos. Debe ingresar al menos un plato para continuar!", MsgBoxStyle.OkOnly, "Error de creacion de dieta")

            pregunta = False

        End If

        If cboConsistencia.Text = "" Then

            MsgBox("La dieta no posee una consistencia. Debe ingresar el tipo de consistencia para continuar!", MsgBoxStyle.OkOnly, "Error de creacion de dieta")

            pregunta = False

        End If

        If pregunta = True Then

            descripcion = txtAgregarNombreDieta.Text

            Trim(descripcion)   ' Quita los espacios en blanco al principio y al final del texto

            verificarNombre(descripcion)

            If (errorNom = False) Then

                ' Se agregan los datos
                sql = "select count(*) from dieta"
                rs2 = Consulta()
                rs2.Read()

                id = rs2(0) + 1

                sql = "insert into Dieta values(" & id & ",'" & descripcion & "' , '" & cboConsistencia.Text & "')"
                rs2 = Consulta()
                rs2.Read()

                For i = 0 To cantidad - 1

                    plato = lstPlatosDieta.Items(i)

                    sql = "select idplato from plato where (descripcion = '" & plato & "')"
                    rs2 = Consulta()
                    rs2.Read()

                    idplato = rs2(0)

                    sql = ""    ' Se iguala el sql a 0 porque si no tira error la siguiente consulta (no tengo idea de por que)
                    sql = "insert into Dieta_Plato values(" & idplato & "," & id & ")"
                    rs2 = Consulta()
                    rs2.Read()

                    cantidad += 1

                Next

                MsgBox("La dieta se creo satisfactoriamente", vbOKOnly)

            End If

        End If

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click

        Dim pregunta As Boolean

        pregunta = MsgBox("Esta seguro que desea volver?", MsgBoxStyle.OkCancel, "VOLVER")

        If pregunta = True Then

            Me.Hide()
            frmMenuDieta.Show()

            vuelta = True

        End If

    End Sub


    Private Sub frmCrearDieta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated


        If vuelta = True Then

            lstPlatosDieta.Items.Clear()
            txtAgregarNombreDieta.Text = ""

            vuelta = False

        End If

        sql = "select descripcion from plato"
        rs2 = Consulta()

        While (rs2.Read = True)

            cboAgregarPlatoDieta.Items.Add(rs2(0))

        End While

    End Sub

    Private Sub btnAgregarPlatoDieta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPlatoDieta.Click

        Dim condicion As Boolean = False

        Dim cantidad As Integer = lstPlatosDieta.Items.Count

        If cantidad = 0 Then

            lstPlatosDieta.Items.Add(cboAgregarPlatoDieta.Text)

        End If

        For i = 0 To cantidad - 1

            If lstPlatosDieta.Items(i) = cboAgregarPlatoDieta.Text Then

                MsgBox("El plato ya fue ingresado", MsgBoxStyle.OkOnly, "Error de ingreso de plato")
                i = cantidad
                condicion = False
            Else

                condicion = True

            End If

        Next

        If condicion = True Then

            lstPlatosDieta.Items.Add(cboAgregarPlatoDieta.Text)

        End If

    End Sub

    Private Sub btnQuitarPlato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarPlato.Click

        lstPlatosDieta.Items.Remove(lstPlatosDieta.SelectedItem)

    End Sub

    Private Sub btnQuitarTodoPlato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarTodoPlato.Click

        Dim pregunta As Boolean

        pregunta = MsgBox("Desea quitar todos los platos?", MsgBoxStyle.YesNo, "Quitar todo")

        If pregunta = True Then

            lstPlatosDieta.Items.Clear()

        End If

    End Sub

    Private Sub verificarNombre(ByVal descripcion)

        sql = "select idplato from plato where (descripcion = '" & descripcion & "')"
        rs2 = Consulta()

        If rs2.Read = True Then

            MsgBox("La descripcion que especifico ya existe", vbOKOnly, "Error de descripcion")

            errorNom = True

        End If

    End Sub

    Private Sub cboAgregarPlatoDieta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAgregarPlatoDieta.SelectedIndexChanged

        If cboAgregarPlatoDieta.Text <> "" Then

            btnAgregarPlatoDieta.Enabled = True

        End If

    End Sub

    Private Sub frmCrearDieta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cboConsistencia.Items.Clear()

        cboConsistencia.Items.Add("Parenteral")
        cboConsistencia.Items.Add("Enteral")

    End Sub
End Class
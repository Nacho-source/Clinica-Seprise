Imports System.Data.Odbc

Public Class fmrAgregarPlato

    Dim pregunta As Boolean
    Dim descripcion As String
    Dim id As Integer
    Dim rs2 As OdbcDataReader

    Dim ingrediente As String
    Dim idingrediente As String
    Dim errorNom As Boolean
    Dim vuelta As Boolean = True

    Private Sub btnVolverAgregarPlato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverAgregarPlato.Click

        pregunta = MsgBox("Esta seguro que desea volver?", MsgBoxStyle.OkCancel, "VOLVER")

        If pregunta = True Then

            Me.Hide()
            frmAgregarModificarPlato.Show()
            vuelta = True

        End If

    End Sub

    Private Sub fmrAgregarPlato_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        If vuelta = True Then
            'agrego vuelta por un error en el codigo que no logramos entender la razon

            lstAgregarPlato.Items.Clear()

            txtAgregarNombrePlato.Text = ""

            vuelta = False

        End If

    End Sub

    Private Sub AgregarPlato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "select Descripcion from Ingrediente"
        rs2 = Consulta()

        While (rs2.Read = True)

            cboIngrediente.Items.Add(rs2(0))

        End While

    End Sub

    Private Sub btnAgregarAgregarPlato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarAgregarPlato.Click

        Dim cantidad As Integer

        cantidad = lstAgregarPlato.Items.Count

        pregunta = MsgBox("Desea crear el plato?", MsgBoxStyle.OkCancel, "CREAR PLATO")

        If cantidad = 0 Then

            MsgBox("El plato no posee ingredientes. Debe ingresar al menos un ingrediente para continuar!", MsgBoxStyle.OkOnly, "Error de creacion de plato")

            pregunta = False

        End If

        If pregunta = True Then

            descripcion = txtAgregarNombrePlato.Text

            Trim(descripcion)   ' Quita los espacios en blanco al principio y al final del texto

            verificarNombre(descripcion)

            If (errorNom = False) Then

                ' Se agregan los datos
                sql = "select count(*) from plato"
                rs2 = Consulta()
                rs2.Read()

                id = rs2(0) + 1

                sql = "insert into Plato values(" & id & ",'" & descripcion & "')"
                rs2 = Consulta()
                rs2.Read()

                For i = 0 To cantidad - 1

                    ingrediente = lstAgregarPlato.Items(i)

                    sql = "select idingrediente from ingrediente where (descripcion = '" & ingrediente & "')"
                    rs2 = Consulta()
                    rs2.Read()

                    idingrediente = rs2(0)

                    sql = "insert into Plato_Ingrediente values(" & id & "," & idingrediente & ")"
                    rs2 = Consulta()
                    rs2.Read()

                    cantidad += 1

                Next

                MsgBox("El plato se creo satisfactoriamente", vbOKOnly)

            End If

        End If

    End Sub

    Private Sub btnAgregarIngredientePlato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarIngredientePlato.Click

        Dim condicion As Boolean = False

        Dim cantidad As Integer = lstAgregarPlato.Items.Count

        If cantidad = 0 Then

            lstAgregarPlato.Items.Add(cboIngrediente.Text)

        End If

        For i = 0 To cantidad - 1

            If lstAgregarPlato.Items(i) = cboIngrediente.Text Then

                MsgBox("El ingrediente ya fue ingresado", MsgBoxStyle.OkOnly, "Error de ingreso de ingrediente")
                i = cantidad
                condicion = False
            Else

                condicion = True

            End If

        Next

        If condicion = True Then

            lstAgregarPlato.Items.Add(cboIngrediente.Text)

        End If

    End Sub

    Private Sub btnQuitarPlatoAgregarPlato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarPlatoAgregarPlato.Click

        lstAgregarPlato.Items.Remove(lstAgregarPlato.SelectedItem)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarTodoAgregarPlato.Click

        pregunta = MsgBox("Desea quitar todos los ingredientes?", MsgBoxStyle.YesNo, "Quitar todo")

        If pregunta = True Then

            lstAgregarPlato.Items.Clear()

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

    
    Private Sub cboIngrediente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIngrediente.SelectedIndexChanged

        If cboIngrediente.Text <> "" Then

            btnAgregarIngredientePlato.Enabled = True

        End If

    End Sub
End Class
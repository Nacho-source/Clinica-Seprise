Imports System.Data.Odbc
Public Class fmrModificarPlato

    Dim pregunta As Boolean
    Dim rs2 As OdbcDataReader
    Public platoMod As Integer

    Dim ingrediente As String
    Dim idingrediente As String
    Dim vuelta As Boolean = True

    Private Sub fmrModificarPlato_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated



        Dim cantidad As Integer

        If vuelta = True Then

            lstModificarPlato.Items.Clear()

            txtModificarIngredientePlato.Text = ""

            ' Llenar la lista con ingredientes
            sql = "select count(IdIngrediente) from Plato_Ingrediente where (IdPlato = " & platoMod & ")"
            rs2 = Consulta()
            rs2.Read()

            cantidad = rs2(0)

            sql = "select Descripcion from Plato_Ingrediente pl, Ingrediente i where (pl.IdIngrediente = i.IdIngrediente) and (pl.IdPlato = " & platoMod & ")"
            rs2 = Consulta()

            While (rs2.Read = True)

                lstModificarPlato.Items.Add(rs2(0))

            End While

            vuelta = False
        End If

        ' Llenar el cbo
        sql = "select Descripcion from Ingrediente"
        rs2 = Consulta()

        While (rs2.Read = True)

            cboIngredienteMod.Items.Add(rs2(0))

        End While

        ' Llenar el nombre
        sql = "select Descripcion from Plato where (IdPlato = " & platoMod & ")"
        rs2 = Consulta()
        rs2.Read()

        txtModificarNombrePlato.Text = rs2(0)

    End Sub

    Private Sub btnVolverModificarPlato_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVolverModificarPlato.Click

        pregunta = MsgBox("Desea descartar los cambios y volver al menu?", MsgBoxStyle.OkCancel, "VOLVER")

        If pregunta = True Then

            Me.Hide()
            frmAgregarModificarPlato.Show()
            vuelta = True

        End If

    End Sub

    Private Sub btnQuitarPlatoModificarPlato_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQuitarPlatoModificarPlato.Click

        lstModificarPlato.Items.Remove(lstModificarPlato.SelectedItem)

    End Sub

    Private Sub btnQuitarTodoModificarPlato_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQuitarTodoModificarPlato.Click

        pregunta = MsgBox("Desea quitar todos los ingredientes?", MsgBoxStyle.YesNo, "Quitar todo")

        If pregunta = True Then

            lstModificarPlato.Items.Clear()

        End If


    End Sub

    Private Sub btnModificarModificarPlato_Click(sender As Object, e As EventArgs) Handles btnModificarModificarPlato.Click

        Dim cantidad As Integer = lstModificarPlato.Items.Count
        Dim descripcion As String

        pregunta = MsgBox("Desea modificar el plato?", MsgBoxStyle.OkCancel, "CREAR PLATO")

        If cantidad = 0 Then

            MsgBox("El plato no posee ingredientes. Debe ingresar al menos un ingrediente para continuar!", MsgBoxStyle.OkOnly, "Error de modificacion de plato")

            pregunta = False

        End If

        descripcion = txtModificarNombrePlato.Text
        Trim(descripcion)

        If pregunta = True Then

            sql = "delete from Plato_ingrediente where Idplato = '" & platoMod & "'"
            rs2 = Consulta()

            sql = "update plato set descripcion = '" & descripcion & "' where idplato = " & platoMod & ""
            rs2 = Consulta()

            cantidad = lstModificarPlato.Items.Count

            For i = 0 To cantidad - 1

                ingrediente = lstModificarPlato.Items(i)

                sql = "select idingrediente from ingrediente where (descripcion = '" & ingrediente & "')"
                rs2 = Consulta()
                rs2.Read()

                idingrediente = rs2(0)

                sql = "insert into plato_ingrediente values(" & platoMod & "," & idingrediente & ")"
                rs2 = Consulta()
                rs2.Read()

            Next

            MsgBox("El plato fue modificado satisfactoriamente", vbOKOnly, "Plato modificado")

        End If

    End Sub

    Private Sub btnModificarIngredientePlato_Click(sender As Object, e As EventArgs) Handles btnModificarIngredientePlato.Click

        Dim condicion As Boolean = False

        Dim cantidad As Integer = lstModificarPlato.Items.Count

        If cantidad = 0 Then

            lstModificarPlato.Items.Add(cboIngredienteMod.Text)

        End If

        For i = 0 To cantidad - 1

            If lstModificarPlato.Items(i) = cboIngredienteMod.Text Then

                MsgBox("El ingrediente ya fue ingresado", MsgBoxStyle.OkOnly, "Error de ingreso de ingrediente")
                i = cantidad
                condicion = False
            Else

                condicion = True

            End If

        Next

        If condicion = True Then

            lstModificarPlato.Items.Add(cboIngredienteMod.Text)

        End If

    End Sub

    Private Sub cboIngredienteMod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIngredienteMod.SelectedIndexChanged

        'Verifica si el cbo tiene ingredientes, si no los tiene, no deja apretar el boton
        If cboIngredienteMod.Text <> "" Then

            btnModificarIngredientePlato.Enabled = True

        End If

    End Sub
End Class
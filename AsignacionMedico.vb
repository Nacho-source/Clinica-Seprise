Imports System.Data.Odbc

Public Class AsignacionMedico
    Dim opc As Integer
    Dim rs As OdbcDataReader
    Private Sub AsignacionMedico_Activate(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AbrirConexion()

        sql = "select m.idMedicamento, m.nombre from medicamento m, medicamento_sector ms where ((m.idMedicamento=ms.idMedicamento) and (ms.idSector=4))"
        rs = Consulta()

        Do While rs.Read = True

            cbo1.Items.Add(rs(0) & " " & rs(1))
            ComboBox1.Items.Add(rs(0) & " " & rs(1))
            ComboBox2.Items.Add(rs(0) & " " & rs(1))
            ComboBox3.Items.Add(rs(0) & " " & rs(1))
            ComboBox4.Items.Add(rs(0) & " " & rs(1))
            ComboBox5.Items.Add(rs(0) & " " & rs(1))
            ComboBox15.Items.Add(rs(0) & " " & rs(1))
            ComboBox14.Items.Add(rs(0) & " " & rs(1))
        Loop
        sql = "select i.idInsumo, i.nombre from Insumo i, insumo_sector ms where ((i.idInsumo=ms.idInsumo) and (ms.idSector=4))"
        rs = Consulta()

        Do While rs.Read = True
            ComboBox6.Items.Add(rs(0) & " " & rs(1))
            ComboBox7.Items.Add(rs(0) & " " & rs(1))
            ComboBox8.Items.Add(rs(0) & " " & rs(1))
            ComboBox9.Items.Add(rs(0) & " " & rs(1))
            ComboBox10.Items.Add(rs(0) & " " & rs(1))
            ComboBox11.Items.Add(rs(0) & " " & rs(1))
            ComboBox13.Items.Add(rs(0) & " " & rs(1))
            ComboBox12.Items.Add(rs(0) & " " & rs(1))
        Loop

        sql = "select idsala, capacidad from sala where idSector=1"
        rs = Consulta()
        Do While rs.Read = True
            cboSala.Items.Add(rs(0))

        Loop
    End Sub

    Private Sub cmdAceptar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAceptar.Click
        opc = MsgBox("¿Esta seguro que desea confirmar la asignacion de medicamentos e insumos?", MsgBoxStyle.YesNo)
        If (opc = 6) Then
            If (cboSala.Text = "") Then
                MsgBox("Error! No se le ha asignado una sala al Medico.", MsgBoxStyle.Critical)
                Me.Show()
            Else
                sql = "insert into medicosala values(''," & Label10.Text & "," & cboSala.Text & ")"
                rs = Consulta()
                rs.Read()

            End If
            If (TextBox1.Text <> "") Then
                sql = "update medicamento_sector set stock=(stock-" & TextBox1.Text & ") where idSector=4"
                rs = Consulta()
                rs.Read()
            End If
            If (TextBox2.Text <> "") Then
                sql = "update medicamento_sector set stock=(stock-" & TextBox2.Text & ") where idSector=4"
                rs = Consulta()
                rs.Read()
            End If
            If (TextBox3.Text <> "") Then
                sql = "update medicamento_sector set stock=(stock-" & TextBox3.Text & ") where idSector=4"
                rs = Consulta()
                rs.Read()
            End If
            If (TextBox4.Text <> "") Then
                sql = "update medicamento_sector set stock=(stock-" & TextBox4.Text & ") where idSector=4"
                rs = Consulta()
                rs.Read()
            End If
            If (TextBox5.Text <> "") Then
                sql = "update medicamento_sector set stock=(stock-" & TextBox5.Text & ") where idSector=4"
                rs = Consulta()
                rs.Read()
            End If

            If (TextBox15.Text <> "") Then
                sql = "update medicamento_sector set stock=(stock-" & TextBox15.Text & ") where idSector=4"
                rs = Consulta()
                rs.Read()
            End If
            If (TextBox14.Text <> "") Then
                sql = "update medicamento_sector set stock=(stock-" & TextBox14.Text & ") where idSector=4"
                rs = Consulta()
                rs.Read()
            End If


            If (TextBox6.Text <> "") Then
                sql = "update insumo_sector set stock=(stock-" & TextBox6.Text & ") where idSector=4"
                rs = Consulta()
                rs.Read()
            End If
            If (TextBox7.Text <> "") Then
                sql = "update insumo_sector set stock=(stock-" & TextBox7.Text & ") where idSector=4"
                rs = Consulta()
                rs.Read()
            End If
            If (TextBox8.Text <> "") Then
                sql = "update insumo_sector set stock=(stock-" & TextBox8.Text & ") where idSector=4"
                rs = Consulta()
                rs.Read()
            End If
            If (TextBox9.Text <> "") Then
                sql = "update insumo_sector set stock=(stock-" & TextBox9.Text & ") where idSector=4"
                rs = Consulta()
                rs.Read()
            End If
            If (TextBox10.Text <> "") Then
                sql = "update insumo_sector set stock=(stock-" & TextBox10.Text & ") where idSector=4"
                rs = Consulta()
                rs.Read()
            End If
            If (TextBox11.Text <> "") Then
                sql = "update insumo_sector set stock=(stock-" & TextBox11.Text & ") where idSector=4"
                rs = Consulta()
                rs.Read()
            End If
            If (TextBox12.Text <> "") Then
                sql = "update insumo_sector set stock=(stock-" & TextBox12.Text & ") where idSector=4"
                rs = Consulta()
                rs.Read()
            End If
            If (TextBox13.Text <> "") Then
                sql = "update insumo_sector set stock=(stock-" & TextBox13.Text & ") where idSector=4"
                rs = Consulta()
                rs.Read()
            End If

            MsgBox("La Asignacion del medico a finalizado con exito", MsgBoxStyle.Information)
            AdministracionCE.Show()
            Me.Hide()

        Else
            Me.Show()
        End If
    End Sub

    Private Sub cmdBack_Click(sender As System.Object, e As System.EventArgs) Handles cmdBack.Click

        opc = MsgBox("¿Esta seguro que desea Cancelar la asignacion de madicamentos e insumos?", MsgBoxStyle.YesNo)
        If (opc = 6) Then
            txtcant1.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""
            TextBox12.Text = ""
            TextBox13.Text = ""
            TextBox14.Text = ""
            TextBox15.Text = ""

            cbo1.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox4.Text = ""
            ComboBox5.Text = ""
            ComboBox6.Text = ""
            ComboBox7.Text = ""
            ComboBox8.Text = ""
            ComboBox9.Text = ""
            ComboBox10.Text = ""
            ComboBox11.Text = ""
            ComboBox12.Text = ""
            ComboBox13.Text = ""
            ComboBox14.Text = ""
            ComboBox15.Text = ""

            IngresoMedicoCE.Show()
            Me.Hide()

        Else
            Me.Show()
        End If

    End Sub

    Private Sub cboSala_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSala.SelectedIndexChanged
        sql = "select capacidad from sala where idsala=" & cboSala.Text & ""
        rs = Consulta()
        rs.Read()
        Label12.Text = rs(0)
    End Sub
End Class
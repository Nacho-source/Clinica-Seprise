Imports System.Data.Odbc

Public Class HistoriaClinicaCE
    Dim opc As Integer
    Dim rs As OdbcDataReader, idEmpleado As String

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click

        opc = MsgBox("¿Esta seguro que desea Volver a la Atencion del Paciente?", MsgBoxStyle.YesNo)

        If (opc = 6) Then
            Me.Hide()
            Button1.Visible = True
            AtencionPaciente.Show()

        Else
            Me.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        opc = MsgBox("¿Esta seguro que desea Volver a la administracion?", MsgBoxStyle.YesNo)

        If (opc = 6) Then
            Me.Hide()
            btnBack.Visible = True
            AdministracionCE.Show()

        Else
            Me.Show()
        End If
    End Sub

    Private Sub cmdDatos_Click(sender As System.Object, e As System.EventArgs) Handles cmdDatos.Click

        If ((txtCodMed.Text = "") And (txtDni.Text = "")) Then

            MsgBox("Ingrese un Dato para reconocer el Paciente", MsgBoxStyle.Exclamation)

            Me.Show()

        Else

            If (txtCodMed.Text <> "") Then
                sql = "select e.idPaciente from Paciente e where (idPaciente=" & txtCodMed.Text & ")"
                rs = Consulta()
                rs.Read()
                idEmpleado = rs(0).ToString

                sql = "select e.idPaciente, e.documentacion, e.Nombre, e.Apellido, e.Telefono, e.Email, e.grupoS from Paciente e where e.idPaciente='" & txtCodMed.Text & "'"
                rs = Consulta()
                rs.Read()
                MsgBox(rs(0))

                txtDatos.Text = "Paciente: " & rs(0) & ". DNI: " & rs(1) & ". Nombre: " & rs(2) & ". Apellido: " & rs(3) & ". Telefono: " & rs(4) & ". Email: " & rs(5) & ""


                'consulta para mostrar historia clinica
                sql = "select h.HistoriaClinicaID HistoriaID, h.IdPaciente Paciente,h.fecha, h.descripcion  from paciente e, historiaclinicaexterna h where ((e.IdPaciente=h.IdPaciente) and (e.idpaciente='" & txtCodMed.Text & "'))"
                rs = Consulta()
                rs.Read()

                Do While (rs.Read = True)
                    lstHistoriaClinica.Items.Add(" ")
                    lstHistoriaClinica.Items.Add(" Historia Clinica N°: " & rs(0) & " ")
                    lstHistoriaClinica.Items.Add("      Paciente N°: " & rs(1) & "       Fecha de Historia Clinica:" & rs(2) & " ")
                    lstHistoriaClinica.Items.Add(" Descripcion: " & rs(3) & " ")
                    lstHistoriaClinica.Items.Add(" ")
                    lstHistoriaClinica.Items.Add(" ")
                Loop


                If (txtDatos.Text = "") Then
                    MsgBox("No se ha encontrado el Doctor ingresado. vuelva a intentarlo", MsgBoxStyle.Exclamation)
                End If
            End If

            If (txtDni.Text <> "") Then
                sql = "select e.idEmpleado from empleado e where (e.documentacion=" & txtDni.Text & ")"
                rs = Consulta()
                rs.Read()
                idEmpleado = rs(0).ToString

                sql = "select m.idPaciente, e.documentacion, e.Nombre, e.Apellido, e.Telefono, e.Email from Paciente ewhere e.idPaciente ='" & txtDni.Text & "'"
                rs = Consulta()
                rs.Read()
                txtDatos.Text = "Paciente: " & rs(0) & ". DNI: " & rs(1) & ". Nombre: " & rs(2) & ". Apellido: " & rs(3) & ". Telefono: " & rs(4) & ". Email: " & rs(5) & "."

                'consulta para mostrar historia clinica
                sql = "select h.HistoriaClinicaID HistoriaID, h.IdPaciente Paciente,h.fecha, h.descripcion  from paciente e, historiaclinicaexterna h where ((e.IdPaciente=h.IdPaciente) and (e.documentacion='" & txtDni.Text & "'))"
                rs = Consulta()
                rs.Read()

                Do While (rs.Read = True)
                    lstHistoriaClinica.Items.Add(" ")
                    lstHistoriaClinica.Items.Add(" Historia Clinica N°: " & rs(0) & " ")
                    lstHistoriaClinica.Items.Add("      Paciente N°: " & rs(1) & "       Fecha de Historia Clinica:" & rs(2) & " ")
                    lstHistoriaClinica.Items.Add(" Descripcion: " & rs(3) & " ")
                    lstHistoriaClinica.Items.Add(" ")
                    lstHistoriaClinica.Items.Add(" ")
                Loop




                If (txtDatos.Text = "") Then
                    MsgBox("No se ha encontrado el Doctor ingresado. vuelva a intentarlo", MsgBoxStyle.Exclamation)
                End If
            End If

        End If
    End Sub

    Private Sub HistoriaClinicaCE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AbrirConexion()

    End Sub
End Class
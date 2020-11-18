Imports System.Data.Odbc

Public Class AtencionPaciente
    Dim opc As Integer
    Dim rs As OdbcDataReader
    Dim turnoID As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        opc = MsgBox("¿Esta seguro que desea cancelar esta consulta?", MsgBoxStyle.YesNo)

        If (opc = 6) Then
            txtApellido.Text = ""
            txtApeMed.Text = ""
            txtEmail.Text = ""
            txtFecha.Text = ""
            txtMailMed.Text = ""
            txtNombre.Text = ""
            txtNomMed.Text = ""
            txtPaciente.Text = ""
            txtTelefono.Text = ""
            txtTipo.Text = ""
            txtHisMed.Text = ""

            Me.Hide()
            AdministracionCE.Show()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnReceta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceta.Click

        RecetaCE.lblIdPac.Text = txtPaciente.Text
        RecetaCE.lblApePac.Text = txtApellido.Text
        RecetaCE.lblNombrePac.Text = txtNombre.Text
        RecetaCE.lblNomMed.Text = txtNomMed.Text & " " & txtApeMed.Text

        sql = "select p.ObraSocial from paciente p where (p.IdPaciente=" & txtPaciente.Text & ")"
        rs = Consulta()
        rs.Read()
        RecetaCE.lblObraSoc.Text = rs(0)

        sql = "select e.descripcion, m.matricula, s.telefono from especialidad e, turnoConsultaExterna t, Medico m, empleado em, sala s, medicosala ms where ((e.idempleado=m.idempleado) and (m.idMedico=ms.IdMedico) and (ms.idSalaMedico=t.idSalaMedico) and (ms.idSala=s.idSala) and (t.TurnoID =" & txtTurno.Text & ")) group by m.idMedico"
        rs = Consulta()
        rs.Read()

        RecetaCE.lblEspecialidad.Text = rs(0)
        RecetaCE.lblMatricula.Text = rs(1)
        RecetaCE.lblTelSector.Text = rs(2)

        sql = "select curdate()"
        rs = Consulta()
        rs.Read()
        RecetaCE.lblFecha.Text = rs(0)


        Me.Hide()
        RecetaCE.Show()
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        sql = "insert into historiaclinicaexterna values(''," & txtPaciente.Text & ", '" & txtHisMed.Text & "', curdate())"
        rs = Consulta()
        rs.Read()


        MsgBox("La consulta del Paciente" & txtPaciente.Text & " ha finalizado y se ha guardado con exito.", MsgBoxStyle.Information)
        Me.Hide()
        ListaEsperaCE.Show()

    End Sub

    Private Sub BtnHistoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistoria.Click

        HistoriaClinicaCE.txtCodMed.Text = txtPaciente.Text

        sql = "select e.idPaciente, e.documentacion, e.Nombre, e.Apellido, e.Telefono, e.Email, e.grupoS from Paciente e where e.idPaciente='" & txtPaciente.Text & "'"
        rs = Consulta()
        rs.Read()
        HistoriaClinicaCE.txtDatos.Text = "Paciente: " & rs(0) & ". DNI: " & rs(1) & ". Nombre: " & rs(2) & ". Apellido: " & rs(3) & ". Telefono: " & rs(4) & ". Email: " & rs(5) & ""

        'consulta para mostrar historia clinica
        sql = "select h.HistoriaClinicaID HistoriaID, h.IdPaciente Paciente,h.fecha, h.descripcion  from paciente e, historiaclinicaexterna h where ((e.IdPaciente=h.IdPaciente) and (e.idpaciente='" & txtPaciente.Text & "'))"
        rs = Consulta()
        rs.Read()

        Do While (rs.Read = True)
            HistoriaClinicaCE.lstHistoriaClinica.Items.Add(" ")
            HistoriaClinicaCE.lstHistoriaClinica.Items.Add(" Historia Clinica N°: " & rs(0) & " ")
            HistoriaClinicaCE.lstHistoriaClinica.Items.Add("      Paciente N°: " & rs(1) & "       Fecha de Historia Clinica:" & rs(2) & " ")
            HistoriaClinicaCE.lstHistoriaClinica.Items.Add(" Descripcion: " & rs(3) & " ")
            HistoriaClinicaCE.lstHistoriaClinica.Items.Add(" ")
            HistoriaClinicaCE.lstHistoriaClinica.Items.Add(" ")
        Loop
        HistoriaClinicaCE.Button1.Visible = False

        Me.Hide()
        HistoriaClinicaCE.Show()

    End Sub

    Private Sub AtencionPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
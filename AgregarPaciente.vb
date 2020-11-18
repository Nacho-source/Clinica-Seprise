Imports System.Data.Odbc

Public Class AgregarPaciente
    Dim rs As OdbcDataReader

    Dim motivo As String

    Private Sub AgregarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMotivo.Text = ""
        cboTipoIngreso.Text = ""
        cboPaciente.Text = ""
        cboEspecialidad.Text = ""
        cboUrgencia.Text = ""

        sql = "select IdPaciente, Nombre, Apellido from Paciente"
        rs = Consulta()

        While (rs.Read = True)
            cboPaciente.Items.Add(rs(0) & " - " & rs(1) & " " & rs(2))
        End While

        sql = "select IdUrgencia, Nombre from Urgencia"
        rs = Consulta()

        While (rs.Read = True)
            cboUrgencia.Items.Add(rs(0) & " - " & rs(1))
        End While

        sql = "select IdEspecialidad, Descripcion from Especialidad"
        rs = Consulta()

        While (rs.Read = True)
            cboEspecialidad.Items.Add(rs(0) & " - " & rs(1))
        End While
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        frmListaEspera.Show()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (txtMotivo.Text = "" Or cboTipoIngreso.Text = "" Or cboPaciente.Text = "" Or cboEspecialidad.Text = "") Then
            MsgBox("Complete todos los campos")
        Else
            Dim urg As String
            If (cboUrgencia.Text = "") Then
                urg = "NULL"
            Else
                urg = Val(cboEspecialidad.Text).ToString
            End If

            sql = "insert into ListaEspera (IdPacienteLista,TipoIngreso,Motivo,Fecha,Hora,IdPaciente,IdUrgencia,IdEspecialidad) values ( '', '" & cboTipoIngreso.Text & "', '" & txtMotivo.Text & "', CURDATE(), CURTIME(), " & Val(cboPaciente.Text) & ", " & urg & ", " & Val(cboEspecialidad.Text) & " )"
            rs = Consulta()

            txtMotivo.Text = ""
            cboTipoIngreso.Text = ""
            cboPaciente.Text = ""
            cboEspecialidad.Text = ""
            cboUrgencia.Text = ""

            frmListaEspera.actualizarLista()
            Me.Hide()
            frmListaEspera.Show()
        End If
    End Sub
End Class
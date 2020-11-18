Imports System.Data.Odbc

Public Class EstudiosFacturacion
    Public idPaciente As Integer
    Dim DataSet As DataSet
    Dim cargaGrilla As OdbcDataAdapter

    Private Sub EstudiosFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AbrirConexion()

        lblFecha.Text = Date.Now.ToString("dd/MM/yyyy")
        sql = "select ag.idEstudio as 'Numero de Estudio ', e.Descripcion as 'Descripcion' , e.precio as 'Precio' from agendaturno ag, estudio e where ag.idEstudio = e.idestudio  and ag.idPaciente = '" & idPaciente & "' "
        'Call EjecutarGrilla(sql)
        dgvResumen.DataSource = ConsultaDG("Facturacion")


        'dgvResumen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        'dgvResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'dgvResumen.AllowUserToAddRows = False

    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If rbCredito.Checked = True Or rbDebito.Checked = True Then
            gbTarjeta.Visible = True
            gbFormaPago.Visible = False
            gbFacturacion.Visible = False
            gbTarjeta.Location = New Point(12, 26)
        ElseIf rbEfectivo.Checked = True Then
            btnImprimir.Visible = True
            gbFormaPago.Visible = False
            gbFacturacion.Visible = True
            gbFacturacion.Location = New Point(12, 26)
        Else
            MsgBox("Debe seleccionar una opcion", MsgBoxStyle.Exclamation, "Error...")
        End If
    End Sub


    Private Sub btnAbonar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbonar.Click
        If txtNroTarjeta.Text = "" Or txtClave.Text = "" Or txtFechaVto.Text = "" Then

            MsgBox("No completo todos los datos. Por favor ingreselos" + MsgBoxStyle.Exclamation + "Atencion!")

        Else

            btnImprimir.Visible = True
            gbFormaPago.Visible = False
            gbTarjeta.Visible = False
            gbFacturacion.Location = New Point(12, 26)
            gbFacturacion.Visible = True

        End If
        
    End Sub

    Private Sub txtNroTarjeta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroTarjeta.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtClave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClave.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'no se cual es la sintaxis para imprimir
        MsgBox("Se imprimio con exito")

        rbCredito.Checked = False
        rbDebito.Checked = False
        rbEfectivo.Checked = False

        btnImprimir.Visible = False
        btnVolver.Visible = True

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click

        Me.Hide()
        btnVolver.Visible = False
        btnImprimir.Visible = True
        Estudios.txtDocBusqueda.Text = ""
        Estudios.gbBotones.Visible = False
        Estudios.Show()

    End Sub

End Class
Imports System.Data.Odbc

Public Class IngresoMedicoCE

    Dim rs As OdbcDataReader, idEmpleado As Integer, datos As String, opc As Integer, IdMedico As Integer
    Private Sub cmdAceptar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAceptar.Click

        opc = MsgBox("¿ESta seguro que desea realizar esta accion?", MsgBoxStyle.YesNo)
        If (opc = 6) Then
            If (rdbAusente.Checked = True) Then
                sql = "insert into EmpleadoAsistencia values (''," & idEmpleado & ", now(), 0)"
                rs = Consulta()
                rs.Read()
                MsgBox("La Asistencia se ha marcado correctamente.", MsgBoxStyle.Information)
            End If
            If (rdbPrecente.Checked = True) Then
                sql = "insert into EmpleadoAsistencia values (''," & idEmpleado & ", now(), 1)"
                rs = Consulta()
                rs.Read()
                MsgBox("La Inasistencia se ha marcado correctamente.", MsgBoxStyle.Information)
            End If

        Else
            Me.Show()
        End If

    End Sub

    Private Sub cmdDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDatos.Click

        If ((txtCodMed.Text = "") And (txtDni.Text = "")) Then

            MsgBox(ex.Message & vbCrLf & "Ingrese un Dato para reconocer el Medico")

            Me.Show()

        Else

            If (txtCodMed.Text <> "") Then
                sql = "select e.idEmpleado from empleado e, medico m where (idMedico=" & txtCodMed.Text & ")"
                rs = Consulta()
                rs.Read()
                idEmpleado = Val(rs(0))

                sql = "select m.idMedico, e.documentacion, e.Nombre, e.Apellido, e.Telefono, e.Email from Empleado e, Medico m where e.idEmpleado= m.idEmpleado and m.IdMedico ='" & txtCodMed.Text & "'"
                rs = Consulta()
                rs.Read()
                IdMedico = rs(0)

                txtDatos.Text = "ID Medico: " & rs(0) & ". DNI: " & rs(1) & ". Nombre: " & rs(2) & ". Apellido: " & rs(3) & ". Telefono: " & rs(4) & ". Email: " & rs(5) & ""

                If (txtDatos.Text = "") Then
                    MsgBox("No se ha encontrado el Doctor ingresado. vuelva a intentarlo", MsgBoxStyle.Exclamation)
                End If
            End If

            If (txtDni.Text <> "") Then
                sql = "select e.idEmpleado from empleado e where (e.documentacion=" & txtDni.Text & ")"
                rs = Consulta()
                rs.Read()
                idEmpleado = Val(rs(0))
                
                sql = "select m.idMedico, e.documentacion, e.Nombre, e.Apellido, e.Telefono, e.Email from Empleado e, Medico m where e.idEmpleado= m.idEmpleado and e.documentacion ='" & txtDni.Text & "'"
                rs = Consulta()
                rs.Read()
                txtDatos.Text = "ID Medico: " & rs(0) & ". DNI: " & rs(1) & ". Nombre: " & rs(2) & ". Apellido: " & rs(3) & ". Telefono: " & rs(4) & ". Email: " & rs(5) & "."
                If (txtDatos.Text = "") Then
                    MsgBox("No se ha encontrado el Doctor ingresado. vuelva a intentarlo", MsgBoxStyle.Exclamation)
                End If
            End If

        End If

    End Sub

    Private Function ex() As Object
        Throw New NotImplementedException
    End Function

    Private Sub rdbCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCodigo.CheckedChanged
        txtDni.Enabled = False
        txtCodMed.Enabled = True
        txtDni.Text = ""
    End Sub

    Private Sub rdbDni_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDni.CheckedChanged
        txtDni.Enabled = True
        txtCodMed.Enabled = False
        txtCodMed.Text = ""
    End Sub

    Private Sub rdbPrecente_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbPrecente.CheckedChanged

    End Sub

    Private Sub rdbAusente_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbAusente.CheckedChanged

    End Sub

    Private Sub IngresoMedicoCE_Activate(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AbrirConexion()
        sql = "select curdate()"
        rs = Consulta()
        rs.Read()
        lblFecha.Text = "La fecha de hoy es: " & rs(0)

        txtDatos.Enabled = False

    End Sub

   

    Private Sub btnAsignar_Click(sender As System.Object, e As System.EventArgs) Handles btnAsignar.Click

        If (txtDatos.Text = "") Then
            MsgBox("Error! No ha seleccionado ningun medico para la asignacion.", MsgBoxStyle.Critical)
            Me.Show()
        Else

            AsignacionMedico.Label2.Text = "Se le esta por asignar los medicamentos e insumos mansuales al medico: "
            AsignacionMedico.Label10.Text = (IdMedico)
            Me.Hide()
            AsignacionMedico.Show()
        End If
    End Sub

    Private Sub cmdBack_Click(sender As System.Object, e As System.EventArgs) Handles cmdBack.Click

        opc = MsgBox("¿Esta seguro que desea Cancelar la operacion?", MsgBoxStyle.Exclamation)

        If (opc = 6) Then
            txtCodMed.Text = ""
            txtDatos.Text = ""
            txtDni.Text = ""
            rdbAusente.Checked = False
            rdbCodigo.Checked = False
            rdbDni.Checked = False
            rdbPrecente.Checked = False


            AdministracionCE.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub
End Class
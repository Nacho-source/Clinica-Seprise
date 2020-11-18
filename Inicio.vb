Option Explicit On

Imports System.Data.Odbc

Public Class Inicio

    Dim conexion As OdbcConnection
    Dim comando As OdbcCommand
    Dim rsUsuario As OdbcDataReader

    Dim usuario As String

    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            conexion = New OdbcConnection("DSN=Clinica")
            conexion.Open()

        Catch ex As Exception

            MsgBox(ex.Message & vbCrLf & "Fallo la conexion")
            End

        End Try

        usuario = "select Nombre, Contraseña from Usuario"

        Call EjecutarUsuario(usuario)

        While rsUsuario.Read = True

            cboUsuario.Items.Add(rsUsuario(0))

        End While


    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Call EjecutarUsuario(usuario)

        Dim noEncontrado As Integer = 0

        While rsUsuario.Read = True

            If txtContraseña.Text = rsUsuario(1) And cboUsuario.Text = rsUsuario(0) Then

                If rsUsuario(0) = "Consultorios Externos" Then

                    Me.Hide()
                    AdministracionCE.Show()
                    AdministracionCE.cmdVolver.Text = "Salir"
                    noEncontrado = 1

                ElseIf rsUsuario(0) = "Internación" Then

                    Me.Hide()
                    'Internación.Show()
                    noEncontrado = 1

                ElseIf rsUsuario(0) = "Estudios" Then

                    Me.Hide()
                    Estudios.btnVolver.Text = "Salir"
                    Estudios.Show()
                    noEncontrado = 1

                ElseIf rsUsuario(0) = "Guardia" Then

                    Me.Hide()
                    frmGuardia.Show()
                    frmGuardia.btnVolver.Text = "Salir"
                    noEncontrado = 1

                ElseIf rsUsuario(0) = "Enfermería" Then

                    Me.Hide()
                    frmMenuEnfermeria.Show()
                    frmMenuEnfermeria.cmdVolver.Text = "Salir"
                    noEncontrado = 1

                ElseIf rsUsuario(0) = "Nutrición" Then

                    Me.Hide()
                    frmMenuDieta.btnVolver.Text = "Salir"
                    frmMenuDieta.Show()
                    noEncontrado = 1

                ElseIf rsUsuario(0) = "Farmacias e insumos" Then

                    Me.Hide()
                    MenuFarmacia.Show()
                    noEncontrado = 1

                ElseIf rsUsuario(0) = "Administrador" Then

                    Me.Hide()
                    Administracion.Show()
                    noEncontrado = 1

                End If

            End If

        End While

        If noEncontrado = 0 Then

            MsgBox("Contraseña o usuario incorrecto/s")
            txtContraseña.Text = ""
            cboUsuario.Text = "Usuarios..."

        End If

    End Sub

    Private Sub EjecutarUsuario(ByVal usuario As String)

        comando = New OdbcCommand(usuario, conexion)
        comando.CommandType = CommandType.Text
        rsUsuario = comando.ExecuteReader()
        comando.Dispose()

    End Sub

End Class
Imports System.Data.Odbc 'importar odbc para usar clases
Module Module1
    Dim cmn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim rs As OdbcDataReader
    Public sql As String
    Dim eoff As Boolean
    Dim opt As Integer

    Dim ds As New DataSet
    Dim adp As OdbcDataAdapter

    Function ConsultaDG(ByVal tabla As String) 'en codigo de form: 
        'sql = "select..."
        'dgvGrid(nombre grid).DataSource = 
        'ConsultaDG("NoCapacitados"(nombre para identificar la consulta))
        Try
            If (ds.Tables.Contains(tabla) = True) Then
                ds.Tables.Remove(tabla)
            End If

            ds.Tables.Add(tabla)

            adp = New OdbcDataAdapter(sql, cmn)
            adp.Fill(ds.Tables(tabla))

            Return ds.Tables(tabla)
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Fallo la consulta")
            Return 0
        End Try
    End Function
	'En formulario poner un rs local por cada uno que se hace, consulta devuelve el rs listo para usar
	'sql = "consulta"
	'rs(local) = Consulta()
    Function Consulta()
        Try
            cmd = New OdbcCommand(sql, cmn)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader()
            cmd.Dispose()
            Return rs
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Fallo la consulta")
            Return 0
        End Try
    End Function
    Sub AbrirConexion() 'llamar cuando se inicia el programa, en el form l  oad
        Try
            cmn = New OdbcConnection("DSN=Clinica") 'aca va el data source name de la conexion con odbc
            cmn.Open()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Fallo la conexion")
        End Try
    End Sub

    Function cambiarFecha(ByVal viejaFecha As String) As String
        Dim fecha As String() = viejaFecha.Split("/")
        Dim dia As String = fecha(0).ToString
        Dim mes As String = fecha(1).ToString
        Dim añoHora As String() = fecha(2).ToString.Split(" ")
        Dim año As String = añoHora(0).ToString
        Dim hora As String = añoHora(1).ToString

        Dim nuevaFecha As String = año & "/" & mes & "/" & dia & " " & hora

        'MsgBox(nuevaFecha)


        Return nuevaFecha
    End Function


End Module
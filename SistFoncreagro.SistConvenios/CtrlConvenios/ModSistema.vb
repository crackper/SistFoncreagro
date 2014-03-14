Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.SqlClient
Module ModSistema
    Public swnuevo, swmodificar As Boolean
    Public conex As String
    Public vformulario As Boolean = False
    Public vformperson As Boolean = False
    Public vidgnral As String
    Public vnomgnral As String
    Public vcodperso As String

    Public Function DevuelveFecha(ByVal nombrecolumna As String, ByVal nombretabla As String, ByVal proyecto As Integer) As DateTime
        Dim vcadena As String
        vcadena = "Select " & nombrecolumna & " As FecIni From " & nombretabla & " Where IdProyecto = " & proyecto
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase("CtrlConvenios.My.MySettings.cnx")
            Dim cmd As DbCommand = db.GetSqlStringCommand(vcadena)
            Return db.ExecuteScalar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return CDate("01/01/1990")
        End Try
    End Function

    Public Function MaxPrimaryKeyCajaChica(ByVal nombrecolumna As String, ByVal nombretabla As String) As String
        Dim vcadena As String
        vcadena = "Select IsNull(Max(" & nombrecolumna & "), 'CAJA000') As Id From " & nombretabla

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase("cnx")
            Dim cmd As DbCommand = db.GetSqlStringCommand(vcadena)
            Return db.ExecuteScalar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    Public Function Caracter(ByVal aski As Integer, ByVal Tipo As String, ByVal cadena As String) As Integer
        ' ----------------------------------------------------------------
        ' brinda formato a una celda de un flex o caja de texto
        ' ----------------------------------------------------------------
        Caracter = 0
        Select Case Tipo
            Case "Entero"
                If aski >= 48 And aski <= 57 Then
                    Caracter = aski
                End If
            Case "Decimal"
                If (aski >= 48 And aski <= 57) Or (aski = 46) Then
                    If (aski >= 48 And aski <= 57) Then ' el caracter es sólo numero
                        Caracter = aski
                    Else
                        If encontrar_caracter(cadena, ".") = 0 And Len(cadena) > 0 And (aski = 46) Then
                            If Mid(cadena, Len(cadena), 1) <> "." Then
                                Caracter = aski
                            End If
                        End If
                    End If
                End If
            Case "Letra"
                If (aski >= 97 And aski <= 122) Or (aski >= 65 And aski <= 90) Then
                    Caracter = aski
                End If
            Case "Fecha"
                If (aski >= 48 And aski <= 57) Or (aski = 47) Or (aski = 45) Then
                    Caracter = aski
                End If
            Case "Texto"
                Caracter = aski
        End Select
        If aski = 8 Then Caracter = aski
    End Function

    Public Function encontrar_caracter(ByVal cadena As String, ByVal Caracter As String) As Integer
        ' ----------------------------------------------------------------
        ' encuentra un caracter en un cadena para este caso un punto
        ' ----------------------------------------------------------------
        Dim i As Integer
        encontrar_caracter = 0
        For i = 1 To Len(cadena)
            If Mid(cadena, i, 1) = Caracter Then
                encontrar_caracter = encontrar_caracter + 1
            End If
        Next i
    End Function

    Public Sub AlternarColorFilas(ByVal grilla As DataGridView)
        With grilla
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        End With
    End Sub

    Public Function Buscar(ByVal Columna As String, ByVal texto As String, ByVal BindingSource As BindingSource) As Integer

        Try
            ' Si está vacio salir y no retornar nada
            If BindingSource.DataSource Is Nothing Then
                Return -1
            End If
            ' Ejecutar el método Find pasándole los datos
            Dim fila As Integer = BindingSource.Find(Columna.Trim, texto)
            ' Mover el cursor a la fila obtenida
            BindingSource.Position = fila
            ' Retornar el valor
            Return fila
            ' Errores
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
        ' No retornar nada
        Return -1

    End Function

    Public Function ValidarUsuario(ByVal vnomusuario As String, ByVal vcontrasena As String, ByVal columnomusuario As String, ByVal columcontusuario As String, ByVal vtabla As String) As String
        Dim vcadena As String
        vcadena = "Select Count(*) As NroRegistros From " & vtabla & " Where " & columnomusuario & " = '" & vnomusuario & "' And " & columcontusuario & " = '" & vcontrasena & "'"
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase("cnx")
            Dim cmd As DbCommand = db.GetSqlStringCommand(vcadena)
            Return db.ExecuteScalar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    Public Function DevuelveUsuario(ByVal vnomusuario As String, ByVal vcontrasena As String, ByVal columnomusuario As String, ByVal columcontusuario As String, ByVal vtabla As String) As String
        Dim vcadena As String
        vcadena = "Select ApePaterno + ' ' + ApeMaterno + ' ' + Nombres As Usuario From " & vtabla & " Where " & columnomusuario & " = '" & vnomusuario & "' And " & columcontusuario & " = '" & vcontrasena & "'"
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase("cnx")
            Dim cmd As DbCommand = db.GetSqlStringCommand(vcadena)
            Return db.ExecuteScalar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    Public Function DevuelveNivel(ByVal vnomusuario As String, ByVal vcontrasena As String, ByVal columnomusuario As String, ByVal columcontusuario As String, ByVal vtabla As String) As String
        Dim vcadena As String
        vcadena = "Select Nivel From " & vtabla & " Where " & columnomusuario & " = '" & vnomusuario & "' And " & columcontusuario & " = '" & vcontrasena & "'"
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase("cnx")
            Dim cmd As DbCommand = db.GetSqlStringCommand(vcadena)
            Return db.ExecuteScalar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    Public Function DevuelveParametro(ByVal vtabla As String, ByVal columna As String, ByVal criterio As String) As Decimal
        Dim vcadena As String
        vcadena = "Select IsNull(ValorParametro, 0) As Valor From " & vtabla & " Where " & columna & " = '" & criterio & "';"
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase("cnx")
            Dim cmd As DbCommand = db.GetSqlStringCommand(vcadena)
            Return db.ExecuteScalar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    Public Function DevuelveNroVoucher(ByVal nombrecolumna As String, ByVal nombretabla As String) As String
        Dim vcadena As String
        vcadena = "Select IsNull(Max(" & nombrecolumna & "), '000000') As Id From " & nombretabla
        Try
            Dim db As Database = DatabaseFactory.CreateDatabase("cnx")
            Dim cmd As DbCommand = db.GetSqlStringCommand(vcadena)
            Return db.ExecuteScalar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    Public Function MaxPrimaryKeyCompuesto(ByVal nombrecolumna As String, ByVal nombretabla As String, ByVal nomcolumpadre As String, ByVal valornomcolumpadre As String) As String
        Dim vcadena As String
        vcadena = "Select IsNull(Max(" & nombrecolumna & "), 0) + 1 As Id From " & nombretabla & " Where " & nomcolumpadre & " = '" & valornomcolumpadre & "'"

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase("cnx")
            Dim cmd As DbCommand = db.GetSqlStringCommand(vcadena)
            Return db.ExecuteScalar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

End Module

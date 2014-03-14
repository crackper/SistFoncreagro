
Public Class Funciones
    Public Function CampoFecha(ByVal Valor As Date) As String
        'If IsDBNull(DateValue(Valor)) Then
        If DateValue(Valor) = "01/01/0001" Then
            Return ""
        Else
            Dim mdia As String = Format(Day(Valor), "00")
            Dim mMes As String = Format(Month(Valor), "00")
            Dim mAnio As String = Year(Valor).ToString
            Return mdia + "/" + mMes + "/" + mAnio
        End If
    End Function

    Public Function CampoNumero(ByVal Valor As Decimal) As String
        If CInt(Valor) = 0 Then
            Return ""
        Else
            Dim num As String
            num = Format(Valor, "##,##0.00")
            Return num
        End If
    End Function

    Public Function ValorNumero(ByVal Dato As System.Nullable(Of Decimal)) As Decimal
        If Dato Is Nothing Then
            ValorNumero = 0
        Else
            ValorNumero = Dato
        End If
    End Function
End Class

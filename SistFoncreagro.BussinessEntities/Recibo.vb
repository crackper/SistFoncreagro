Public Class Recibo
    Public Property IdRecibo As Int32
    Public Property Monto As Decimal
    Public Property Fecha As DateTime
    Public Property Glosa As String
    Public Property Beneficiario As Nullable(Of Int32)
    Public Property IdProyecto As Int32
    Public Property Codigo As String
    Public Property Estado As String
    Public Property Usuario As Int32
    Public Property Personal As Personal
    Public Property FechaVencimiento As DateTime
    Public Property IdCCosto As Nullable(Of Int32)
    Public Property CCosto As CCosto
    Public ReadOnly Property EntregadoA As String
        Get
            If Beneficiario.HasValue Then
                Return Personal.ApePaterno + " " + Personal.ApeMaterno + " " + Personal.Nombres
            Else
                Return ""
            End If

        End Get
    End Property
    Public ReadOnly Property NomEstado As String
        Get
            Select Case Estado
                Case "P"
                    Return "Pendiente"
                Case "R"
                    Return "Rendido"
                Case "A"
                    Return "Anulado"
                Case "V"
                    Return "Vencido"
            End Select
        End Get
    End Property
    Public ReadOnly Property NomCCosto As String
        Get
            If IdCCosto.HasValue Then
                Return CCosto.CodigoElementoGasto
            Else
                Return ""
            End If

        End Get
    End Property
End Class

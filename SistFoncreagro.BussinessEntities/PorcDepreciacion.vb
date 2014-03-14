Public Class PorcDepreciacion
    Public Property IdPorcDepreciacion As Int32
    Public Property Tipo As String
    Public Property Valor As Decimal
    Public ReadOnly Property NombreMostrar As String
        Get
            Return Tipo + " " + Valor.ToString + "%"
        End Get
    End Property
End Class

Public Class Desembolso
    
    Public Property IdDesembolso As Int32
    Public Property IdConvenio As Int32
    Public Property Numero As Byte
    Public Property MontoEjec As Decimal
    Public Property MontoProg As Decimal
    Public Property FechaProg As System.Nullable(Of Date)
    Public Property FechaEjec As System.Nullable(Of Date)
    Public Property Estado As String
    Public Property IdProveedorCliente As Int32
    Public Property _ProveedorCliente As ProveedorCliente

    Public ReadOnly Property Anio As String
        Get
            Return Year(FechaProg)
        End Get
    End Property

End Class

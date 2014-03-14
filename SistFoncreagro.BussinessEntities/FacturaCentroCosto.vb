Public Class FacturaCentroCosto
    Public Property IdFacturaCentroCosto As Int32
    Public Property IdOrdenCentroCosto As Int32
    Public Property IdTipoDocumento As Int32
    Public Property Serie As String
    Public Property Numero As String
    Public Property MontoFact As Decimal
    Public Property documento As TipoDocumento
    Public ReadOnly Property NombreDocumento As String
        Get
            Return documento.Nombre
        End Get
    End Property
End Class

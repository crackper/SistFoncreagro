Public Class DocumentoRendido
    Public Property FechaDocumento As DateTime
    Public Property Glosa As String
    Public Property IdCCosto As Int32
    Public Property IdDocRendido As Int32
    Public Property IdDocumentoCont As Int32
    Public Property IdProveedorCliente As Int32
    Public Property IdReciboRendicion As Int32
    Public Property Monto As Decimal
    Public Property NroDocumento As Int32
    Public Property Serie As String
    Public Property TipoCambio As Decimal
    Public Property IdTipoGasto As Int32
    Public Property ProveedorCliente As ProveedorCliente
    Public Property CCosto As CCosto
    Public Property DocumentoContabilizado As DocumentoContabilizado
    Public Property TipoGasto As TipoGasto
    Public Property FechaPago As DateTime
    Public Property FechaVencimiento As DateTime
    Public ReadOnly Property Proveedor As String
        Get
            Return ProveedorCliente.Ruc + " " + ProveedorCliente.RazonSocial
        End Get
    End Property
    Public ReadOnly Property CentroCosto As String
        Get
            Return CCosto.Codigo + " " + CCosto._ElementoGasto.NomElemGasto
        End Get
    End Property
    Public ReadOnly Property TipoDocumento As String
        Get
            Return DocumentoContabilizado.Codigo + " " + DocumentoContabilizado.Descripcion
        End Get
    End Property
    Public ReadOnly Property Gasto As String
        Get
            Return TipoGasto.Descripcion
        End Get
    End Property
End Class

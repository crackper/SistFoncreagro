Public Class OrdenCompra
    Public Property IdOrdenCompra As Int32
    Public Property IdRequerimiento As Int32
    Public Property NumeroOrden As String
    Public Property Tipo As String
    Public Property IdRequeridoPor As Int32
    Public Property FechaGeneraOrden As Date
    Public Property Estado As String
    Public Property IdMoneda As Int32
    Public Property IgvPor As Decimal
    Public Property SubTotal As Decimal
    Public Property Igv As Decimal
    Public Property Total As Decimal
    Public Property IdProveedor As Int32
    Public Property IdComprador As Int32
    Public Property IdTipoPago As Int32
    Public Property Anticipo As Decimal
    Public Property Observacion As String
    Public Property ActivarCentroCosto As Boolean
    Public Property FechaSolicitaAprobacion As Date
    Public Property IdLugarRecepcion As Int32
    Public Property FechaProbableEntrega As Date
    Public Property FechaRecepcion As Date
    Public Property DocumentoReferencial As String
    Public Property IdPersonaRecepciona As Int32
    Public Property IdResponsableAprobar As Int32
    Public Property factura As Boolean
    Public Property IdCotizacion As Int32
    Public Property Destino As String
    Public Property CodigoAreaD As String
    Public Property RazonSocialD As String
    Public Property AbreviacionMonedaD As String
    Public Property RequeridoPorD As String
    Public Property Rechazado As Int32
    Public Property Sustento As String
    Public Property IdTipoDocumento As Int32
    '
    Public Property tipoPago As TipoPago
    Public Property requerimiento As Requerimiento
    Public Property moneda As Moneda
    Public Property proveedor As ProveedorCliente
    Public Property detalleOrdenCompra As List(Of DetalleOrdenCompra)

    Public ReadOnly Property monedaOrden
        Get
            Return moneda.Siglas
        End Get
    End Property
    Public ReadOnly Property NombreProveedorCompleato As String
        Get
            Return proveedor.NombreProveedor
        End Get
    End Property
    Public ReadOnly Property nombreProveedor As String
        Get
            Return proveedor.RazonSocial
        End Get
    End Property
    Public ReadOnly Property numeroOrdenCompra As String
        Get
            Return NumeroOrden + " - " + Tipo + " - " + Estado
        End Get
    End Property
End Class

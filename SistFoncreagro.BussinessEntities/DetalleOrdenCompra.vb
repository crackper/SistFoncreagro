Public Class DetalleOrdenCompra
    Public Property IdDetalleOrdenCompra As Int32
    Public Property IdOrdenCompra As Int32
    Public Property IdCatalogo As Int32
    Public Property Observacion As String
    Public Property CantidadSolicitada As Decimal
    Public Property PrecioCompra As Decimal
    Public Property IdUnidad As Int32
    Public Property AfectoIgv As Boolean
    Public Property CantidadComprada As Decimal
    Public Property CantidadPendiente As Boolean
    Public Property IdDetalleRequerimiento As Int32
    Public Property DescripcionGen As String
    Public Property EstadoFactura As Boolean

    Public Property IdCentroCosto As Int32
    Public Property catalogo As Catalogo
    Public Property unidad As UnidadMedida
    Public ReadOnly Property PrecioCantComprada As Decimal
        Get
            Return CantidadComprada * PrecioCompra
        End Get
    End Property

    Public ReadOnly Property CantidadPendienteNumero As Decimal
        Get
            Return CantidadSolicitada - CantidadComprada
        End Get
    End Property

    Public ReadOnly Property nombreCatalogo As String
        Get
            Return catalogo.Descripcion & " - (" & Observacion & ")"
        End Get
    End Property

    Public ReadOnly Property codigoCatalogo As String
        Get
            Return catalogo.Codigo
        End Get
    End Property

    Public ReadOnly Property unidadMedidaAbreviacion As String
        Get
            Return unidad.Abreviacion
        End Get
    End Property

    Public ReadOnly Property Subtotal As Decimal
        Get
            Return CantidadSolicitada * PrecioCompra
        End Get
    End Property

End Class

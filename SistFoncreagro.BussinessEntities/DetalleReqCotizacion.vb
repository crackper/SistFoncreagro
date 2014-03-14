Public Class DetalleReqCotizacion
    Public Property IdDetalleReqCotizacion As Int32
    Public Property IdCotizacion As Int32
    Public Property IdDetalleRequerimiento As Int32
    Public Property IdCatalogo As Int32
    Public Property DetalleReq As DetalleRequerimiento

    Public ReadOnly Property codigoCatalogo
        Get
            Return DetalleReq.cat.Codigo
        End Get
    End Property
    Public ReadOnly Property nombreCatalogo
        Get
            Return DetalleReq.cat.Descripcion & " - (" & DetalleReq.observacion & ")"
        End Get
    End Property
    Public ReadOnly Property UnidadMedidaDetalle
        Get
            Return DetalleReq.unidadAbreviatura
        End Get
    End Property
    Public ReadOnly Property Cantidad
        Get
            Return DetalleReq.Cantidad
        End Get
    End Property
    Public ReadOnly Property IdCentroCosto
        Get
            Return DetalleReq.IdCentroCosto
        End Get
    End Property
    Public ReadOnly Property DetAfectoIgv As Boolean
        Get
            Return DetalleReq.AfectoIgv
        End Get
    End Property
End Class

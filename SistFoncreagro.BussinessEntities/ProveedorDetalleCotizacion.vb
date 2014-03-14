Public Class ProveedorDetalleCotizacion
    Public Property IdProveedorDetalleCotizacion As Int32
    Public Property IdDetalleReqCotizacion As Int32
    Public Property IdProveedor As Int32
    Public Property Monto As Decimal
    Public Property Estado As Boolean
    Public Property Proveedor As ProveedorCliente
    Public ReadOnly Property NombreProveedor As String
        Get
            Return Proveedor.NombreProveedor
        End Get
    End Property
End Class

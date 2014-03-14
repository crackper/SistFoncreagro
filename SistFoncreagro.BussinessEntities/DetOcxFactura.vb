Public Class DetOcxFactura
    Public Property IdDetOcxFactura As Int32
    Public Property IdOcxFactura As Int32
    Public Property IdDetalleOrdenCompra As Int32
    Public Property IdPlanContable As Int32
    Public Property Cantidad As Decimal
    Public Property Estado As Boolean
    Public Property CCosto As String
    Public Property Producto As String
    Public Property PCompraDetalle As Decimal
    Public ReadOnly Property SubTotal As Decimal
        Get
            Return Cantidad * PCompraDetalle
        End Get
    End Property
End Class

Imports SistFoncreagro.BussinessEntities
Public Interface IDetalleComprobanteBL
    Sub SaveDetalleComprobante(ByVal detalleComprobante As DetalleComprobante)
    Sub DeleteDetalleComprobante(ByVal idDetalleComprobante As Int32)
    Function GetAllFromDetalleComprobanteByIdOcxFactura(ByVal idOcxFactura As Int32) As List(Of DetalleComprobante)
End Interface

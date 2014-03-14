Imports SistFoncreagro.BussinessEntities

Public Interface IDetalleOrdenCompraRepository
    Function GetAllFromDetalleOrdenCompraByIdOrdenCompra(ByVal idOrdenCompra As Int32) As List(Of DetalleOrdenCompra)
    Function GetAllFromDetalleByIdCCosto(ByVal IdCcosto As Int32, ByVal IdOc As Int32) As List(Of DetalleOrdenCompra)
    Sub UpdateDetalleOrdenCompra(ByVal detalleOrdenCompra As DetalleOrdenCompra)
    Sub UpdateDetalleOrdenCompra1(ByVal detalle As List(Of DetalleOrdenCompra))
    Sub UpdateDetalleOrdenCompraRecepcion(ByVal detalleOrdenCompra As DetalleOrdenCompra)
    Sub UpdateDetalleOrdenCompraRecepcion1(ByVal detalle As List(Of DetalleOrdenCompra))
End Interface

Imports SistFoncreagro.BussinessEntities
Public Interface IEstadoOrdenCompraRepository
    Function GetAllFromEstadoOrdenCompraByIdOrdenCompra(ByVal IdOrdenCompra As Int32) As List(Of EstadoOrdenCompra)
End Interface

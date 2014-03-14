Imports SistFoncreagro.BussinessEntities
Public Interface IEstadoOrdenCompraBL
    Function GetAllFromEstadoOrdenCompraByIdOrdenCompra(ByVal IdOrdenCompra As Int32) As List(Of EstadoOrdenCompra)
End Interface

Imports SistFoncreagro.BussinessEntities
Public Interface IOrdenCentroCostoRepository
    Function GetAllFromOrdenCentroCostoByIdOrdenCompra(ByVal IdOrdenCOmpra As Int32) As List(Of OrdenCentroCosto)
    Sub FinalizarRegOrdenCompraCentroCosto(ByVal IdOrdenCentroCosto)
End Interface

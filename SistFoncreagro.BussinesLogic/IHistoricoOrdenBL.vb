Imports SistFoncreagro.BussinessEntities
Public Interface IHistoricoOrdenBL
    Sub RechazarOrden(ByVal historicoOrden As HistoricoOrden)
    Function GetAllFromHistoricoByIdOrdenCompra(ByVal IdOrdenCOmpra As Int32) As List(Of HistoricoOrden)
End Interface

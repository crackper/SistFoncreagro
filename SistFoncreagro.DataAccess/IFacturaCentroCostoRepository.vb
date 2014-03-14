Imports SistFoncreagro.BussinessEntities
Public Interface IFacturaCentroCostoRepository
    Sub SaveFacturaCentroCosto(ByVal facturaCCosto As FacturaCentroCosto)
    Sub DeleteFacturaCentroCosto(ByVal IdFacturaCentroCosto As Int32)
    Function GetAllFromFacturaCentroCostoByIdOrdenCentroCosto(ByVal IdOrdenCentroCosto As Int32) As List(Of FacturaCentroCosto)
End Interface

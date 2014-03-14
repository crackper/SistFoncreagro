Imports SistFoncreagro.BussinessEntities
Public Interface IPosicionCCostosRepository
    Function GetPosicionesCCostosValidasByFechaByIdCCostos(ByVal Fecha As DateTime, ByVal IdCCosto As Int32) As List(Of PosicionCentroCosto)
    Function SavePosicionCCosto(ByVal posicionCCostos As PosicionCentroCosto) As Int32
End Interface

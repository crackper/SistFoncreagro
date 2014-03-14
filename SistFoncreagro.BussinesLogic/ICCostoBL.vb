Imports SistFoncreagro.BussinessEntities

Public Interface ICCostoBL
    Function GetAllFromCCosto() As List(Of CCosto)
    Function GetCCOSTOByIdCCosto(ByVal _IdCCosto As Int32) As CCosto
    Function GetCCOSTOByIdProyecto(ByVal _IdProyecto As Int32) As List(Of CCosto)
    Function GetCCOSTOByIdOrdenCompra(ByVal IdOrden As Int32) As List(Of CCosto)
    Function SaveCCosto(ByVal _CCosto As CCosto) As String
    Function DeleteCCosto(ByVal _IdCCosto As Int32) As String
End Interface

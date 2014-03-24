Imports SistFoncreagro.BussinessEntities
Public Interface ICCostoxDetalleOrden
    Function GetAllFromCCostoDetalleOrdenByIdDetalleOrden(ByVal idDetalleOrden As Int32) As List(Of CCostoxDetalleOrden)
End Interface

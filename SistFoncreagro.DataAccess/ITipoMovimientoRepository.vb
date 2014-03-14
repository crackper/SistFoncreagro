Imports SistFoncreagro.BussinessEntities
Public Interface ITipoMovimientoRepository
    Function GetAllFromTIPOMOVIMIENTO() As List(Of TipoMovimiento)
    Function GetTIPOMOVIMIENTOByIdTipoMovimiento(ByVal IdTipoMovimiento As Int32) As TipoMovimiento
End Interface

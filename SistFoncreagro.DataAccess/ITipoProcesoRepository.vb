Imports SistFoncreagro.BussinessEntities
Public Interface ITipoProcesoRepository
    Function GetAllFromTIPOPROCESO() As List(Of TipoProceso)
    Function GetTIPOPROCESOByIdTipoProceso(ByVal IdTipoProceso As Int32) As TipoProceso
End Interface

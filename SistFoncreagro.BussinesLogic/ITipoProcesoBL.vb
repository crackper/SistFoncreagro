Imports SistFoncreagro.BussinessEntities
Public Interface ITipoProcesoBL
    Function GetAllFromTIPOPROCESO() As List(Of TipoProceso)
    Function GetTIPOPROCESOByIdTipoProceso(ByVal IdTipoProceso As Int32) As TipoProceso
End Interface

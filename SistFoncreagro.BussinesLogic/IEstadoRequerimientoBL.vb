Imports SistFoncreagro.BussinessEntities
Public Interface IEstadoRequerimientoBL
    Function GetAllFromEstadoRequerimientoByIdRequerimiento(ByVal IdRequerimiento As Int32) As List(Of EstadoRequerimiento)
End Interface

Imports SistFoncreagro.BussinessEntities
Public Interface ICoordinaProyectoRepository
    Function GetCoordinaParteProyectoByIdArea(ByVal IdArea As Int32) As List(Of CoordinaParteProyecto)
    Function GetCoordinaParteProyectoByIdProyectoVigentes(ByVal IdProyecto As Int32) As List(Of CoordinaParteProyecto)
    Function SaveCoordinaParteProyecto(ByVal coordinaParteProyecto As CoordinaParteProyecto) As Int32
    Sub DeleteCoordinaParteProyecto(ByVal IdCoordinaProyecto As Int32)
End Interface

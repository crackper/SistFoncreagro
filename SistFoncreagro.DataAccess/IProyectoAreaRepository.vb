Imports SistFoncreagro.BussinessEntities
Public Interface IProyectoAreaRepository
    Function GetProyectoAreaByIdArea(ByVal IdArea As Int32) As List(Of ProyectoArea)
    Function GetProyectoAreaByIdProyectoVigentes(ByVal IdProyecto As Int32) As List(Of ProyectoArea)
    Function GetProyectoAreaByIdAreaByProyectoVigentes(ByVal IdArea As Int32) As List(Of ProyectoArea)
    Function SaveProyectoArea(ByVal ProyectoArea As ProyectoArea) As Int32
    Sub DeleteProyectoArea(ByVal IdProyectoArea As Int32)
End Interface

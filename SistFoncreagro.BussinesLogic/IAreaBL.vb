Imports SistFoncreagro.BussinessEntities
Public Interface IAreaBL
    Function GetAllFromArea(ByVal argArea As ArgumentosArea) As List(Of Area)
    Function GetAllFromArea2() As List(Of Area)
    Function SaveArea(ByVal area As Area) As Int32
    Function GetAreaByNombre(ByVal Nombre As String, ByVal argArea As ArgumentosArea) As Area
    Function GetAREAByIdArea(ByVal idArea As Int32, ByVal argArea As ArgumentosArea)
    Function GetAreaByIdProyecto(ByVal IdProyecto As Int32, ByVal argArea As ArgumentosArea)
    Function GetAreaByTipoArea(ByVal TipoArea As String, ByVal argArea As ArgumentosArea)
    Function GetAreaByIdPadre(ByVal IdPadre As Int32, ByVal argArea As ArgumentosArea) As List(Of Area)
    Function GetTipoAreaDeSubArea(ByVal IdPadre As Int32) As String
    Function GetAreaSuperior(ByVal argArea As ArgumentosArea) As Area
    Sub DeleteArea(ByVal idArea As Int32)
    Function AgregarProyectoAArea(ByVal IdProyecto As Int32, ByVal area As Area) As Int32
    Function DeleteAreaAndSubAreas(ByVal IdArea As Int32) As Integer

End Interface

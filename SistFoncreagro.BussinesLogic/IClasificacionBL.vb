Imports SistFoncreagro.BussinessEntities

Public Interface IClasificacionBL
    Function GetAllFromClasificacion() As List(Of Clasificacion)
    Function GetFromClasificacionById(ByVal _id As Int32) As Clasificacion
    Function GetFromClasificacionByTipo(ByVal _Tipo As Int32) As List(Of Clasificacion)
    Sub SaveClasificacion(ByVal _Clasificacion As Clasificacion)
    Sub DeleteClasificacion(ByVal _id As Int32)
    Function GetCLASIFICACIONByIdCatalogo(ByVal IdCatalogo As Int32) As Clasificacion
End Interface

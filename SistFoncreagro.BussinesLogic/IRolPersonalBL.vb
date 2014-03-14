Imports SistFoncreagro.BussinessEntities
Public Interface IRolPersonalBL
    Function GetFromRolPersonalByIdRol(ByVal idRol As Int32, ByVal IdPerProy As Int32, ByVal Tipo As Boolean) As List(Of RolPersonal)
    Sub SaveRolPersonal(ByVal rolPersona As RolPersonal)
    Sub DeleteRolPersonal(ByVal idRolPersonal As Int32)
    Sub UpdateResponsable(ByVal idPersonalOriginal As Int32, ByVal idPersonalReemplazo As Int32, ByVal idRol As Int32, ByVal idproyecto As Int32)
End Interface

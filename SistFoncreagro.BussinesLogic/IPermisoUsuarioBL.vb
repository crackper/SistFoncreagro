Imports SistFoncreagro.BussinessEntities
Public Interface IPermisoUsuarioBL
    Sub SavePERMISOUSUARIO(_PermisoUsuario As PermisoUsuario)
    Function GetPERMISOUSUARIOByIdPersonal(ByVal IdPersonal As Int32) As PermisoUsuario
End Interface

Imports SistFoncreagro.BussinessEntities
Public Interface ISubActividadRepository
    Function GetSUBACTIVIDADByIdSubActividad(ByVal IdSubActividad As Int32) As SubActividad
    Sub DeleteSubActividad(ByVal IdSubActividad As Int32)
    Sub SaveSUBACTIVIDAD(ByVal _SUBACTIVIDAD As SubActividad)
    Sub GenerarPoaTecnico(IdProyecto As Int32)
End Interface

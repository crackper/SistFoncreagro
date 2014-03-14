Imports SistFoncreagro.BussinessEntities
Public Interface IMotivoAusenciaBL
    Function GetAllFromMOTIVOAUSENCIA() As List(Of MotivoAusencia)
    Function GetMOTIVOAUSENCIAByIdMotivoAusencia(ByVal IdMotivoAusencia As Int32) As MotivoAusencia
    Function GetMotivoAusenciaByFechasByIdPeriodoLaboral(ByVal FI As Date, ByVal FF As Date, ByVal IdPeriodoLaboral As Int32) As List(Of MotivoAusencia)
End Interface

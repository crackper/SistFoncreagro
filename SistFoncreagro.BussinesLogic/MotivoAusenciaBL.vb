Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class MotivoAusenciaBL : Implements IMotivoAusenciaBL

    Dim factoryrepository As IMotivoAusenciaRepository
    Public Sub New()
        factoryrepository = New MotivoAusenciaRepository
    End Sub
    Public Function GetAllFromMOTIVOAUSENCIA() As System.Collections.Generic.List(Of BussinessEntities.MotivoAusencia) Implements IMotivoAusenciaBL.GetAllFromMOTIVOAUSENCIA
        Return factoryrepository.GetAllFromMOTIVOAUSENCIA
    End Function

    Public Function GetMOTIVOAUSENCIAByIdMotivoAusencia(ByVal IdMotivoAusencia As Integer) As BussinessEntities.MotivoAusencia Implements IMotivoAusenciaBL.GetMOTIVOAUSENCIAByIdMotivoAusencia
        Return factoryrepository.GetMOTIVOAUSENCIAByIdMotivoAusencia(IdMotivoAusencia)
    End Function

    Public Function GetMotivoAusenciaByFechasByIdPeriodoLaboral(ByVal FI As Date, ByVal FF As Date, ByVal IdPeriodoLaboral As Integer) As System.Collections.Generic.List(Of BussinessEntities.MotivoAusencia) Implements IMotivoAusenciaBL.GetMotivoAusenciaByFechasByIdPeriodoLaboral
        Return factoryrepository.GetMotivoAusenciaByFechasByIdPeriodoLaboral(FI, FF, IdPeriodoLaboral)
    End Function
End Class

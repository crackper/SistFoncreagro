Imports SistFoncreagro.BussinessEntities
Public Interface IAusenciaBL
    Function GetAUSENCIAByIdAusenciaAndIdPeriodoLaboral(ByVal IdAusencia As Int32, ByVal IdPeriodoLaboral As Int32) As Ausencia
    Function GetAUSENCIAByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Int32) As List(Of Ausencia)
    Function SaveAUSENCIA(ByVal _Ausencia As Ausencia) As Int32
    Function GetAusenciaByIdPeriodoLaboralByAbreviatura(ByVal IdPeriodoLaboral As Int32, ByVal Abreviatura As String)
    Sub DeleteAusencia(ByVal IdAusencia As Int32, ByVal IdPeriodoLaboral As Int32)
    Sub UpdateArchivoAUSENCIA(ByVal Archivo As String, ByVal IdAusencia As Int32, ByVal IdPeriodoLaboral As Int32)
End Interface

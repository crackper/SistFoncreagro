Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class AusenciaBL : Implements IAusenciaBL

    Dim factoryrepository As IAusenciaRepository

    Public Sub New()
        factoryrepository = New AusenciaRepository
    End Sub
    Public Sub DeleteAusencia(ByVal IdAusencia As Integer, ByVal IdPeriodoLaboral As Integer) Implements IAusenciaBL.DeleteAusencia
        factoryrepository.DeleteAusencia(IdAusencia, IdPeriodoLaboral)
    End Sub

    Public Function GetAUSENCIAByIdAusenciaAndIdPeriodoLaboral(ByVal IdAusencia As Integer, ByVal IdPeriodoLaboral As Integer) As BussinessEntities.Ausencia Implements IAusenciaBL.GetAUSENCIAByIdAusenciaAndIdPeriodoLaboral
        Return factoryrepository.GetAUSENCIAByIdAusenciaAndIdPeriodoLaboral(IdAusencia, IdPeriodoLaboral)
    End Function

    Public Function GetAUSENCIAByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Integer) As System.Collections.Generic.List(Of BussinessEntities.Ausencia) Implements IAusenciaBL.GetAUSENCIAByIdPeriodoLaboral
        Return factoryrepository.GetAUSENCIAByIdPeriodoLaboral(IdPeriodoLaboral)
    End Function

    Public Function SaveAUSENCIA(ByVal _Ausencia As BussinessEntities.Ausencia) As Integer Implements IAusenciaBL.SaveAUSENCIA
        Return factoryrepository.SaveAUSENCIA(_Ausencia)
    End Function

    Public Sub UpdateArchivoAUSENCIA(ByVal Archivo As String, ByVal IdAusencia As Integer, ByVal IdPeriodoLaboral As Integer) Implements IAusenciaBL.UpdateArchivoAUSENCIA
        factoryrepository.UpdateArchivoAUSENCIA(Archivo, IdAusencia, IdPeriodoLaboral)
    End Sub

    Public Function GetAusenciaByIdPeriodoLaboralByAbreviatura(ByVal IdPeriodoLaboral As Integer, ByVal Abreviatura As String) As Object Implements IAusenciaBL.GetAusenciaByIdPeriodoLaboralByAbreviatura
        Return factoryrepository.GetAusenciaByIdPeriodoLaboralByAbreviatura(IdPeriodoLaboral, Abreviatura)
    End Function
End Class

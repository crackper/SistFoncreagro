Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class DistribucionCCostosPersonalBL : Implements IDistribucionCCostosPersonalBL

    Dim factoryrepository As IDistribucionCCostosPersonalRepository

    Public Sub New()
        factoryrepository = New DistribucionCCostosPersonalRepository
    End Sub

    Public Function GetDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio(ByVal IdPeriodoLaboral As Integer, ByVal Anio As Integer, ByVal Mes As Integer) As System.Collections.Generic.List(Of BussinessEntities.DistribucionCCostosPersonal) Implements IDistribucionCCostosPersonalBL.GetDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio
        Return factoryrepository.GetDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio(IdPeriodoLaboral, Anio, Mes)
    End Function

    Public Function GetDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio2(ByVal IdPeriodoLaboral As Integer, ByVal anio As String, ByVal mes As String) As System.Collections.Generic.List(Of BussinessEntities.DistribucionCCostosPersonal) Implements IDistribucionCCostosPersonalBL.GetDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio2
        Return factoryrepository.GetDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio2(IdPeriodoLaboral, anio, mes)
    End Function

    Public Function GetIdDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio(ByVal IdPeriodoLaboral As Integer, ByVal anio As String, ByVal mes As String) As System.Collections.Generic.List(Of BussinessEntities.DistribucionCCostosPersonal) Implements IDistribucionCCostosPersonalBL.GetIdDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio
        Return factoryrepository.GetIdDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio(IdPeriodoLaboral, anio, mes)
    End Function
    Public Function GetDistribucionCCostosPersonalByIdDistribucionCCP(ByVal IdDistribucionCCP As Integer) As System.Collections.Generic.List(Of BussinessEntities.DistribucionCCostosPersonal) Implements IDistribucionCCostosPersonalBL.GetDistribucionCCostosPersonalByIdDistribucionCCP
        Return factoryrepository.GetDistribucionCCostosPersonalByIdDistribucionCCP(IdDistribucionCCP)
    End Function

    Public Sub SaveDistribucionCCostosPersonalByCCostosIdDistribucionCCP(ByVal DistribucionCCostospersonal As BussinessEntities.DistribucionCCostosPersonal) Implements IDistribucionCCostosPersonalBL.SaveDistribucionCCostosPersonalByCCostosIdDistribucionCCP
        factoryrepository.SaveDistribucionCCostosPersonalByCCostosIdDistribucionCCP(DistribucionCCostospersonal)
    End Sub

    Public Sub DeleteDISTRIBUCIONCCOSTOSPERSONAL(ByVal IdDistribucionCCP As Integer, ByVal IdCCosto As Integer) Implements IDistribucionCCostosPersonalBL.DeleteDISTRIBUCIONCCOSTOSPERSONAL
        factoryrepository.DeleteDISTRIBUCIONCCOSTOSPERSONAL(IdDistribucionCCP, IdCCosto)
    End Sub

    'Public Function SaveDistribucionCCostosPersonalByMesAnioByCCostosIdPeriodoLaboral(ByVal DistribucionCCostospersonal As BussinessEntities.DistribucionCCostosPersonal) As Integer Implements IDistribucionCCostosPersonalBL.SaveDistribucionCCostosPersonalByMesAnioByCCostosIdPeriodoLaboral
    '    Return factoryrepository.SaveDistribucionCCostosPersonalByMesAnioByCCostosIdPeriodoLaboral(DistribucionCCostospersonal)
    'End Function

    'Public Function GetMaxAnioAnMesDistribucionCCostosPersonalByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Integer, ByVal Anio As String, ByVal Mes As String) As System.Collections.Generic.List(Of BussinessEntities.DistribucionCCostosPersonal) Implements IDistribucionCCostosPersonalBL.GetMaxAnioAnMesDistribucionCCostosPersonalByIdPeriodoLaboral
    '    Return factoryrepository.GetMaxAnioAnMesDistribucionCCostosPersonalByIdPeriodoLaboral(IdPeriodoLaboral, Anio, Mes)
    'End Function

    Public Function SaveListaDistribucionCCostosPersonal(ByVal listaDistribucionCCostosPersonal As System.Collections.Generic.List(Of BussinessEntities.DistribucionCCostosPersonal)) As Integer Implements IDistribucionCCostosPersonalBL.SaveListaDistribucionCCostosPersonal

        For Each dcc As DistribucionCCostosPersonal In listaDistribucionCCostosPersonal
            ' ''Try
            ''SaveDistribucionCCostosPersonalByMesAnioByCCostosIdPeriodoLaboral(dcc)
            ' ''Catch ex As Exception

            ' ''End Try
        Next
        Return 1
    End Function



End Class

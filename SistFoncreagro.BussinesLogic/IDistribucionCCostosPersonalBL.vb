Imports SistFoncreagro.BussinessEntities
Public Interface IDistribucionCCostosPersonalBL
    Function GetDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio(ByVal IdPeriodoLaboral As Int32, ByVal Anio As Integer, ByVal Mes As Integer) As List(Of DistribucionCCostosPersonal)
    Function GetDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio2(ByVal IdPeriodoLaboral As Int32, ByVal anio As String, ByVal mes As String) As List(Of DistribucionCCostosPersonal)
    Function GetIdDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio(ByVal IdPeriodoLaboral As Int32, ByVal anio As String, ByVal mes As String) As List(Of DistribucionCCostosPersonal)
    Function GetDistribucionCCostosPersonalByIdDistribucionCCP(ByVal IdDistribucionCCP As Int32) As List(Of DistribucionCCostosPersonal)
    Sub SaveDistribucionCCostosPersonalByCCostosIdDistribucionCCP(ByVal DistribucionCCostospersonal As DistribucionCCostosPersonal)
    Sub DeleteDISTRIBUCIONCCOSTOSPERSONAL(ByVal IdDistribucionCCP As Int32, ByVal IdCCosto As Int32)
    Function SaveListaDistribucionCCostosPersonal(ByVal listaDistribucionCCostosPersonal As List(Of DistribucionCCostosPersonal)) As Int32

End Interface


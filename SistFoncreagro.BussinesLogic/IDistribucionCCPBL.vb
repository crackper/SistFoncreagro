Imports SistFoncreagro.BussinessEntities
Public Interface IDistribucionCCPBL
    Function GetDISTRIBUCIONCCPByIdPeriodoLaboralByFecha(ByVal IdPeriodoLaboral As Int32, ByVal fecha As DateTime) As DistribucionCCP
    Function SaveDISTRIBUCIONCCP(ByVal DistribucionPPC As DistribucionCCP) As Int32
    Function GetDISTRIBUCIONCCPByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Int32) As List(Of DistribucionCCP)
    Function GetDISTRIBUCIONCCPByIdDistribucionCCP(ByVal IdDistribucionCCP As Int32) As DistribucionCCP
    Sub DeleteDISTRIBUCIONCCP(ByVal IdDistribucionCCP As Int32)
End Interface

Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class DistribucionCCPBL : Implements IDistribucionCCPBL
    Dim factoryrepository As IDISTRIBUCIONCCPRepository

    Public Sub New()
        factoryrepository = New DISTRIBUCIONCCPRepository
    End Sub
    Public Function GetDISTRIBUCIONCCPByIdPeriodoLaboralByFecha(ByVal IdPeriodoLaboral As Integer, ByVal fecha As Date) As BussinessEntities.DistribucionCCP Implements IDistribucionCCPBL.GetDISTRIBUCIONCCPByIdPeriodoLaboralByFecha
        Return factoryrepository.GetDISTRIBUCIONCCPByIdPeriodoLaboralByFecha(IdPeriodoLaboral, fecha)
    End Function

    Public Function SaveDISTRIBUCIONCCP(ByVal DistribucionPPC As BussinessEntities.DistribucionCCP) As Integer Implements IDistribucionCCPBL.SaveDISTRIBUCIONCCP
        Return factoryrepository.SaveDISTRIBUCIONCCP(DistribucionPPC)
    End Function

    Public Function GetDISTRIBUCIONCCPByIdDistribucionCCP(ByVal IdDistribucionCCP As Integer) As BussinessEntities.DistribucionCCP Implements IDistribucionCCPBL.GetDISTRIBUCIONCCPByIdDistribucionCCP
        Return factoryrepository.GetDISTRIBUCIONCCPByIdDistribucionCCP(IdDistribucionCCP)
    End Function

    Public Function GetDISTRIBUCIONCCPByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Integer) As System.Collections.Generic.List(Of BussinessEntities.DistribucionCCP) Implements IDistribucionCCPBL.GetDISTRIBUCIONCCPByIdPeriodoLaboral
        Return factoryrepository.GetDISTRIBUCIONCCPByIdPeriodoLaboral(IdPeriodoLaboral)
    End Function

    Public Sub DeleteDISTRIBUCIONCCP(ByVal IdDistribucionCCP As Integer) Implements IDistribucionCCPBL.DeleteDISTRIBUCIONCCP
        factoryrepository.DeleteDISTRIBUCIONCCP(IdDistribucionCCP)
    End Sub
End Class

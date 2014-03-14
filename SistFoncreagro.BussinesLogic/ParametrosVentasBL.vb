Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ParametrosVentasBL : Implements IParametrosVentasBL
    Dim factoryrepository As IParametrosVentasRepository
    Public Sub New()
        factoryrepository = New ParametrosVentasRepository
    End Sub

    Public Function GetAllFromPARAMETROSVENTAS() As System.Collections.Generic.List(Of BussinessEntities.ParametrosVentas) Implements IParametrosVentasBL.GetAllFromPARAMETROSVENTAS
        Return factoryrepository.GetAllFromPARAMETROSVENTAS
    End Function

    Public Sub SavePARAMETROSVENTAS(ByVal _Parametros As BussinessEntities.ParametrosVentas) Implements IParametrosVentasBL.SavePARAMETROSVENTAS
        factoryrepository.SavePARAMETROSVENTAS(_Parametros)
    End Sub

    Public Sub UpdateEstadoPARAMETROSVENTAS(ByVal IdParametro As Integer) Implements IParametrosVentasBL.UpdateEstadoPARAMETROSVENTAS
        factoryrepository.UpdateEstadoPARAMETROSVENTAS(IdParametro)
    End Sub
End Class

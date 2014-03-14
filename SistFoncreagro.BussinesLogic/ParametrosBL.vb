Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ParametrosBL : Implements IParametrosBL

    Dim factoryrepository As IParametrosRepository
    Public Sub New()
        factoryrepository = New ParametrosRepository
    End Sub
    Public Function GetPARAMETROSByNombre(ByVal Nombre As String) As BussinessEntities.Parametros Implements IParametrosBL.GetPARAMETROSByNombre
        Return factoryrepository.GetPARAMETROSByNombre(Nombre)
    End Function

    Public Function GetValorUIT(ByVal Fecha As Date) As BussinessEntities.Parametros Implements IParametrosBL.GetValorUIT
        Return factoryrepository.GetValorUIT(Fecha)
    End Function

    Public Function GetAllfromPARAMETROS() As System.Collections.Generic.List(Of BussinessEntities.Parametros) Implements IParametrosBL.GetAllfromPARAMETROS
        Return factoryrepository.GetAllfromPARAMETROS
    End Function

    Public Function GetPARAMETROSByIdParametro(ByVal IdParametro As Integer) As BussinessEntities.Parametros Implements IParametrosBL.GetPARAMETROSByIdParametro
        Return factoryrepository.GetPARAMETROSByIdParametro(IdParametro)
    End Function

    Public Sub SavePARAMETROS(ByVal _Parametros As BussinessEntities.Parametros) Implements IParametrosBL.SavePARAMETROS
        factoryrepository.SavePARAMETROS(_Parametros)
    End Sub

    Public Sub UpdateEstadoPARAMETROS(ByVal IdParametro As Integer) Implements IParametrosBL.UpdateEstadoPARAMETROS
        factoryrepository.UpdateEstadoPARAMETROS(IdParametro)
    End Sub

    Public Function GetPorcentajeSistemaPenciones(IdSistemaPensiones As Integer, monto As Decimal) As Decimal Implements IParametrosBL.GetPorcentajeSistemaPenciones
        Return factoryrepository.GetPorcentajeSistemaPenciones(IdSistemaPensiones, monto)
    End Function
End Class

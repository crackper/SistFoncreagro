Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class CuentaBancariaBL : Implements ICuentaBancariaBL
    Dim factoryrepository As ICuentaBancariaRepository
    Public Sub New()
        factoryrepository = New CuentaBancariaRepository
    End Sub
    Public Function GetCUENTABANCARIAByIdPoyecto(ByVal IdProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.CuentaBancaria) Implements ICuentaBancariaBL.GetCUENTABANCARIAByIdPoyecto
        Return factoryrepository.GetCUENTABANCARIAByIdPoyecto(IdProyecto)
    End Function

    Public Function GetAllFromCUENTABANCARIA() As System.Collections.Generic.List(Of BussinessEntities.CuentaBancaria) Implements ICuentaBancariaBL.GetAllFromCUENTABANCARIA
        Return factoryrepository.GetAllFromCUENTABANCARIA
    End Function

    Public Function GetCUENTABANCARIAByIdCtaBancaria(ByVal IdCtaBancaria As Integer) As BussinessEntities.CuentaBancaria Implements ICuentaBancariaBL.GetCUENTABANCARIAByIdCtaBancaria
        Return factoryrepository.GetCUENTABANCARIAByIdCtaBancaria(IdCtaBancaria)
    End Function

    Public Function GetCTABANCARIAInTransaccion(ByVal Anio As Integer, ByVal Mes As Integer, ByVal Flag As String) As System.Collections.Generic.List(Of BussinessEntities.CuentaBancaria) Implements ICuentaBancariaBL.GetCTABANCARIAInTransaccion
        Return factoryrepository.GetCTABANCARIAInTransaccion(Anio, Mes, Flag)
    End Function
    Public Sub SaveCUENTABANCARIA(ByVal _CuentaBancaria As BussinessEntities.CuentaBancaria) Implements ICuentaBancariaBL.SaveCUENTABANCARIA
        factoryrepository.SaveCUENTABANCARIA(_CuentaBancaria)
    End Sub

    Public Sub UpdateEstadoCUENTABANCARIA(ByVal IdCtaBancaria As Integer) Implements ICuentaBancariaBL.UpdateEstadoCUENTABANCARIA
        factoryrepository.UpdateEstadoCUENTABANCARIA(IdCtaBancaria)
    End Sub

    Public Function GetCTABANCARIAInConciliacion(ByVal Anio As Integer) As System.Collections.Generic.List(Of BussinessEntities.CuentaBancaria) Implements ICuentaBancariaBL.GetCTABANCARIAInConciliacion
        Return factoryrepository.GetCTABANCARIAInConciliacion(Anio)
    End Function
End Class

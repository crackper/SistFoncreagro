Imports SistFoncreagro.BussinessEntities
Public Interface ICuentaBancariaRepository
    Function GetCUENTABANCARIAByIdPoyecto(ByVal IdProyecto As Int32) As List(Of CuentaBancaria)
    Function GetAllFromCUENTABANCARIA() As List(Of CuentaBancaria)
    Function GetCTABANCARIAInConciliacion(ByVal Anio As Int32) As List(Of CuentaBancaria)
    Function GetCUENTABANCARIAByIdCtaBancaria(ByVal IdCtaBancaria As Int32) As CuentaBancaria
    Function GetCTABANCARIAInTransaccion(ByVal Anio As Int32, ByVal Mes As Int32, ByVal Flag As String) As List(Of CuentaBancaria)
    Sub SaveCUENTABANCARIA(ByVal _CuentaBancaria As CuentaBancaria)
    Sub UpdateEstadoCUENTABANCARIA(ByVal IdCtaBancaria As Int32)
End Interface

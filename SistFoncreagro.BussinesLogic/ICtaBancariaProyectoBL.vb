Imports SistFoncreagro.BussinessEntities
Public Interface ICtaBancariaProyectoBL
    Function GetAllFromCTABANCARIAPROYECTO() As List(Of CtaBancariaProyecto)
    Function GetCTABANCARIAPROYECTOByIdCtaBancaria(ByVal IdCtaBancaria As Int32) As List(Of CtaBancariaProyecto)
    Sub SaveCTABANCARIAPROYECTO(ByVal _CtaBancariaProyecto As CtaBancariaProyecto)
    Sub DeleteCTABANCARIAPROYECTO(ByVal IdCtaBancaria As Int32, ByVal IdProyecto As Int32)
    Sub UpdateEstadoCTABANCARIAPROYECTO(ByVal IdCtaBancaria As Int32, ByVal IdProyecto As Int32)
    Function GetCTABANCARIAPROYECTOByIdCtaBancariaAndIdProyecto(ByVal IdCtaBancaria As Int32, ByVal IdProyecto As Int32) As CtaBancariaProyecto
    Function GetSaldosCuentasBancarias(ByVal IdCtaBancaria As Int32, ByVal IdProyecto As Int32, Fecha As DateTime) As CtaBancariaProyecto
End Interface

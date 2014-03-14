Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class CtaBancariaProyectoBL : Implements ICtaBancariaProyectoBL
    Dim factoryrepository As ICtaBancariaProyectoRepository

    Public Sub New()
        factoryrepository = New CtaBancariaProyectoRepository
    End Sub

    Public Sub DeleteCTABANCARIAPROYECTO(ByVal IdCtaBancaria As Integer, ByVal IdProyecto As Integer) Implements ICtaBancariaProyectoBL.DeleteCTABANCARIAPROYECTO
        factoryrepository.DeleteCTABANCARIAPROYECTO(IdCtaBancaria, IdProyecto)
    End Sub

    Public Function GetAllFromCTABANCARIAPROYECTO() As System.Collections.Generic.List(Of BussinessEntities.CtaBancariaProyecto) Implements ICtaBancariaProyectoBL.GetAllFromCTABANCARIAPROYECTO
        Return factoryrepository.GetAllFromCTABANCARIAPROYECTO
    End Function

    Public Function GetCTABANCARIAPROYECTOByIdCtaBancaria(ByVal IdCtaBancaria As Integer) As System.Collections.Generic.List(Of BussinessEntities.CtaBancariaProyecto) Implements ICtaBancariaProyectoBL.GetCTABANCARIAPROYECTOByIdCtaBancaria
        Return factoryrepository.GetCTABANCARIAPROYECTOByIdCtaBancaria(IdCtaBancaria)
    End Function

    Public Sub SaveCTABANCARIAPROYECTO(ByVal _CtaBancariaProyecto As BussinessEntities.CtaBancariaProyecto) Implements ICtaBancariaProyectoBL.SaveCTABANCARIAPROYECTO
        factoryrepository.SaveCTABANCARIAPROYECTO(_CtaBancariaProyecto)
    End Sub

    Public Sub UpdateEstadoCTABANCARIAPROYECTO(ByVal IdCtaBancaria As Integer, ByVal IdProyecto As Integer) Implements ICtaBancariaProyectoBL.UpdateEstadoCTABANCARIAPROYECTO
        factoryrepository.UpdateEstadoCTABANCARIAPROYECTO(IdCtaBancaria, IdProyecto)
    End Sub

    Public Function GetCTABANCARIAPROYECTOByIdCtaBancariaAndIdProyecto(ByVal IdCtaBancaria As Integer, ByVal IdProyecto As Integer) As BussinessEntities.CtaBancariaProyecto Implements ICtaBancariaProyectoBL.GetCTABANCARIAPROYECTOByIdCtaBancariaAndIdProyecto
        Return factoryrepository.GetCTABANCARIAPROYECTOByIdCtaBancariaAndIdProyecto(IdCtaBancaria, IdProyecto)
    End Function

    Public Function GetSaldosCuentasBancarias(IdCtaBancaria As Integer, IdProyecto As Integer, Fecha As Date) As BussinessEntities.CtaBancariaProyecto Implements ICtaBancariaProyectoBL.GetSaldosCuentasBancarias
        Return factoryrepository.GetSaldosCuentasBancarias(IdCtaBancaria, IdProyecto, Fecha)
    End Function
End Class

Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class CierreContableBL : Implements ICierreContableBL
    Dim factoryrepository As ICierreContableRepository

    Public Sub New()
        factoryrepository = New CierreContableRepository
    End Sub

    Public Sub DeleteCIERRECONTABLE(ByVal IdCierre As Integer) Implements ICierreContableBL.DeleteCIERRECONTABLE
        factoryrepository.DeleteCIERRECONTABLE(IdCierre)
    End Sub

    Public Function GetAllFromCIERRECONTABLE() As System.Collections.Generic.List(Of BussinessEntities.CierreContable) Implements ICierreContableBL.GetAllFromCIERRECONTABLE
        Return factoryrepository.GetAllFromCIERRECONTABLE
    End Function

    Public Function GetAllFromCIERRECONTABLEDetallado() As System.Collections.Generic.List(Of BussinessEntities.CierreContable) Implements ICierreContableBL.GetAllFromCIERRECONTABLEDetallado
        Return factoryrepository.GetAllFromCIERRECONTABLEDetallado
    End Function

    Public Function GetCIERRECONTABLEByIdCierre(ByVal IdCierre As Integer) As BussinessEntities.CierreContable Implements ICierreContableBL.GetCIERRECONTABLEByIdCierre
        Return factoryrepository.GetCIERRECONTABLEByIdCierre(IdCierre)
    End Function

    Public Function SaveCIERRECONTABLE(ByVal _CierreContable As BussinessEntities.CierreContable) As Integer Implements ICierreContableBL.SaveCIERRECONTABLE
        Return factoryrepository.SaveCIERRECONTABLE(_CierreContable)
    End Function
End Class

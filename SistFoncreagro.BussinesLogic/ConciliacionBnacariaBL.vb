Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ConciliacionBnacariaBL : Implements IConciliacionBancariaBL
    Dim factoryrepository As IConciliacionBancariaRepository

    Public Sub New()
        factoryrepository = New ConciliacionBancariaRepository
    End Sub
    Public Sub DeleteCONCILIACIONBANCARIA(ByVal IdConciliacion As Integer) Implements IConciliacionBancariaBL.DeleteCONCILIACIONBANCARIA
        factoryrepository.DeleteCONCILIACIONBANCARIA(IdConciliacion)
    End Sub

    Public Function GetCONCILIACIONBANCARIAByAnioAndIdCtaBancaria(ByVal Anio As Integer, ByVal IdCtaBancaria As Integer) As System.Collections.Generic.List(Of BussinessEntities.ConciliacionBancaria) Implements IConciliacionBancariaBL.GetCONCILIACIONBANCARIAByAnioAndIdCtaBancaria
        Return factoryrepository.GetCONCILIACIONBANCARIAByAnioAndIdCtaBancaria(Anio, IdCtaBancaria)
    End Function

    Public Function GetCONCILIACIONBANCARIAByIdConciliacion(ByVal IdConciliacion As Integer) As BussinessEntities.ConciliacionBancaria Implements IConciliacionBancariaBL.GetCONCILIACIONBANCARIAByIdConciliacion
        Return factoryrepository.GetCONCILIACIONBANCARIAByIdConciliacion(IdConciliacion)
    End Function

    Public Function SaveCONCILIACIONBANCARIA(ByVal _ConciliacionBancaria As BussinessEntities.ConciliacionBancaria) As Integer Implements IConciliacionBancariaBL.SaveCONCILIACIONBANCARIA
        Return factoryrepository.SaveCONCILIACIONBANCARIA(_ConciliacionBancaria)
    End Function

    Public Sub UpdateEstadoCONCILIACIONBANCARIA(ByVal IdConciliacion As Integer) Implements IConciliacionBancariaBL.UpdateEstadoCONCILIACIONBANCARIA
        factoryrepository.UpdateEstadoCONCILIACIONBANCARIA(IdConciliacion)
    End Sub
End Class

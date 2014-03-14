Imports SistFoncreagro.BussinessEntities
Public Interface IConciliacionBancariaRepository
    Function SaveCONCILIACIONBANCARIA(ByVal _ConciliacionBancaria As ConciliacionBancaria) As Int32
    Function GetCONCILIACIONBANCARIAByAnioAndIdCtaBancaria(ByVal Anio As Int32, ByVal IdCtaBancaria As Int32) As List(Of ConciliacionBancaria)
    Function GetCONCILIACIONBANCARIAByIdConciliacion(ByVal IdConciliacion As Int32) As ConciliacionBancaria
    Sub DeleteCONCILIACIONBANCARIA(ByVal IdConciliacion As Int32)
    Sub UpdateEstadoCONCILIACIONBANCARIA(ByVal IdConciliacion As Int32)
End Interface

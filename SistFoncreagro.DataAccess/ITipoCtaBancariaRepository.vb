Imports SistFoncreagro.BussinessEntities
Public Interface ITipoCtaBancariaRepository
    Function GetAllFromTIPOCTABANCARIA() As List(Of TipoCtaBancaria)
    Function GetTIPOCTABANCARIAByIdTipoCtaBancaria(ByVal IdTipoCtaBancaria As Int32) As TipoCtaBancaria
End Interface

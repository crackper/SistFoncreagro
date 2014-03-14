Imports SistFoncreagro.BussinessEntities
Public Interface ICierreContableRepository
    Function SaveCIERRECONTABLE(ByVal _CierreContable As CierreContable) As Int32
    Sub DeleteCIERRECONTABLE(ByVal IdCierre As Int32)
    Function GetAllFromCIERRECONTABLE() As List(Of CierreContable)
    Function GetCIERRECONTABLEByIdCierre(ByVal IdCierre As Int32) As CierreContable
    Function GetAllFromCIERRECONTABLEDetallado() As List(Of CierreContable)
End Interface

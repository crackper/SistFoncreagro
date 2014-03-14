Imports SistFoncreagro.BussinessEntities
Public Interface ISubdiarioBL
    Function GetAllSUBDIARIO() As List(Of Subdiario)
    Function GetAllSUBDIARIOActivos() As List(Of Subdiario)
    Function GetSUBDIARIOInTransaccion(ByVal Anio As Int32, ByVal Mes As Int32) As List(Of Subdiario)
    Function GetSUBDIARIOByIdSubDiario(ByVal IdSubDiario As Int32) As Subdiario
    Function GetSUBDIARIOInTransaccionByFlag(ByVal Anio As Int32, ByVal Mes As Int32, ByVal Flag As String) As List(Of Subdiario)
    Function GetSUBDIARIOByIdOpFinanciera(ByVal IdOpFinanciera As Int32) As List(Of Subdiario)
    Sub SaveSUBDIARIO(ByVal _Subdiario As Subdiario)
    Sub DeleteSUBDIARIO(ByVal IdSubdiario As Int32)
    Sub UpdateEstadoSUBDIARIO(ByVal IdSubdiario As Int32)
End Interface

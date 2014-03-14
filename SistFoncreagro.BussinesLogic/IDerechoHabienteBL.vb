Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Interface IDerechoHabienteBL
    Function GetDERECHOHABIENTEConyugueByIdPersonal(ByVal IdPersonal As Int32) As List(Of DerechoHabiente)
    Function GetDERECHOHABIENTEHijoByIdPersonal(ByVal IdPersonal As Int32) As List(Of DerechoHabiente)
    Function GetDERECHOHABIENTEOtrosVinculosByIdPersonal(ByVal IdPersonal As Int32) As List(Of DerechoHabiente)
    Function SaveDERECHOHABIENTE(ByVal derechoHabiente As DerechoHabiente) As Int32
    Sub DeleteDerechoHabiente(ByVal IdPersonal As Int32, ByVal IdDerechoHabiente As Int32)
End Interface

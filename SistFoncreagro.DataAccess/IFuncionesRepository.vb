Imports SistFoncreagro.BussinessEntities
Public Interface IFuncionesRepository
    Function GetAllFromFUNCIONES() As List(Of Funciones)
    Function SaveFUNCIONES(ByVal funciones As Funciones) As Int32
    Function GetFUNCIONESByIdFuncionAndIdPosicion(ByVal IdFuncion As Int32, ByVal IdPosicion As Int32) As Funciones
    Function GetFUNCIONESByIdPosicion(ByVal IdPosicion As Int32) As List(Of Funciones)
    Sub DeletefUNCIONES(ByVal idFuncion As Int32, ByVal IdPosicion As Int32)
End Interface

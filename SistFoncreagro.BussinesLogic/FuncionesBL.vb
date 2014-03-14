Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class FuncionesBL : Implements IFuncionesBL
    Dim factoryrepository As IFuncionesRepository

    Public Sub New()
        factoryrepository = New FuncionesRepository
    End Sub

    Public Sub DeletefUNCIONES(ByVal idFuncion As Integer, ByVal IdPosicion As Integer) Implements IFuncionesBL.DeletefUNCIONES
        factoryrepository.DeletefUNCIONES(idFuncion, IdPosicion)
    End Sub

    Public Function GetAllFromFUNCIONES() As System.Collections.Generic.List(Of BussinessEntities.Funciones) Implements IFuncionesBL.GetAllFromFUNCIONES
        Return factoryrepository.GetAllFromFUNCIONES()
    End Function

    Public Function GetFUNCIONESByIdFuncionAndIdPosicion(ByVal IdFuncion As Integer, ByVal IdPosicion As Integer) As BussinessEntities.Funciones Implements IFuncionesBL.GetFUNCIONESByIdFuncionAndIdPosicion
        Return factoryrepository.GetFUNCIONESByIdFuncionAndIdPosicion(IdFuncion, IdPosicion)
    End Function

    Public Function GetFUNCIONESByIdPosicion(ByVal IdPosicion As Integer) As System.Collections.Generic.List(Of BussinessEntities.Funciones) Implements IFuncionesBL.GetFUNCIONESByIdPosicion
        Return factoryrepository.GetFUNCIONESByIdPosicion(IdPosicion)
    End Function

    Public Function SaveFUNCIONES(ByVal funciones As BussinessEntities.Funciones) As Integer Implements IFuncionesBL.SaveFUNCIONES
        Return factoryrepository.SaveFUNCIONES(funciones)
    End Function
End Class

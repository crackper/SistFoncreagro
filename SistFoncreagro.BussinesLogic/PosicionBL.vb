Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class PosicionBL : Implements IPosicionBL

    Dim factoryrepository As IPosicionRepository

    Public Sub New()
        factoryrepository = New PosicionRepository
    End Sub

    Public Sub DeletePosicion(ByVal IdPosicion As Integer) Implements IPosicionBL.DeletePosicion
        factoryrepository.DeletePosicion(IdPosicion)
    End Sub

    Public Function GetAllFromPosicion(ByVal argPosicion As BussinessEntities.ArgumentosPosicion) As System.Collections.Generic.List(Of BussinessEntities.Posicion) Implements IPosicionBL.GetAllFromPosicion
        Return factoryrepository.GetAllFromPosicion(argPosicion)
    End Function

    Public Function GetAllFromPosicion2() As System.Collections.Generic.List(Of BussinessEntities.Posicion) Implements IPosicionBL.GetAllFromPosicion2
        Dim argPosicion2 As New ArgumentosPosicion(Nothing, 0, 0, 0, 0, 0, 0)
        Return factoryrepository.GetAllFromPosicion(argPosicion2)
    End Function
    Public Function GetJefaturaByIdArea(ByVal idArea As Integer, ByVal argPosicion As BussinessEntities.ArgumentosPosicion) As BussinessEntities.Posicion Implements IPosicionBL.GetJefaturaByIdArea
        Return factoryrepository.GetJefaturaByIdArea(idArea, argPosicion)
    End Function

    Public Function GetListaPosicionesDeUnaAreaySubAreasByIdArea(ByVal IdArea As Integer) As System.Collections.Generic.IList(Of BussinessEntities.Posicion) Implements IPosicionBL.GetListaPosicionesDeUnaAreaySubAreasByIdArea
        Return factoryrepository.GetListaPosicionesDeUnaAreaySubAreasByIdArea(IdArea)
    End Function

    Public Function GetPosicionByIdArea(ByVal IdArea As Integer, ByVal argPosicion As BussinessEntities.ArgumentosPosicion) As System.Collections.Generic.List(Of BussinessEntities.Posicion) Implements IPosicionBL.GetPosicionByIdArea
        Return factoryrepository.GetPosicionByIdArea(IdArea, argPosicion)
    End Function

    Public Function GetPosicionByIdArea2(ByVal IdArea As Integer) As System.Collections.Generic.List(Of BussinessEntities.Posicion) Implements IPosicionBL.GetPosicionByIdArea2
        Dim argPosicion2 As New ArgumentosPosicion(Nothing, 0, 0, 0, 0, 0, 0)
        Return factoryrepository.GetPosicionByIdArea(IdArea, argPosicion2)
    End Function

    Public Function GetPosicionByIdPosicion(ByVal IdPosicion As Integer, ByVal argPosicion As BussinessEntities.ArgumentosPosicion) As BussinessEntities.Posicion Implements IPosicionBL.GetPosicionByIdPosicion
        Return factoryrepository.GetPosicionByIdPosicion(IdPosicion, argPosicion)
    End Function

    Public Function SavePosicion(ByVal posicion As BussinessEntities.Posicion) As Integer Implements IPosicionBL.SavePosicion
        Return factoryrepository.SavePosicion(posicion)
    End Function


End Class

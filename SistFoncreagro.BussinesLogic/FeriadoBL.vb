Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class FeriadoBL : Implements IFeriadoBL

    Dim factoryrepository As IFeriadoRepository

    Public Sub New()
        factoryrepository = New FeriadoRepository
    End Sub

    Public Sub DeleteFeriado(ByVal _id As Integer) Implements IFeriadoBL.DeleteFeriado
        factoryrepository.DeleteFeriado(_id)
    End Sub

    Public Function GetAllFromFeriado() As System.Collections.Generic.List(Of BussinessEntities.Feriado) Implements IFeriadoBL.GetAllFromFeriado
        Return factoryrepository.GetAllFromFeriado
    End Function

    Public Function GetFeriadoByFecha(ByVal _Fecha As Date) As BussinessEntities.Feriado Implements IFeriadoBL.GetFeriadoByFecha
        Return factoryrepository.GetFeriadoByFecha(_Fecha)
    End Function

    Public Function GetFeriadoById(ByVal _Id As Integer) As BussinessEntities.Feriado Implements IFeriadoBL.GetFeriadoById
        Return factoryrepository.GetFeriadoById(_Id)
    End Function

    Public Function SaveFeriado(ByVal _Feriado As BussinessEntities.Feriado) As Integer Implements IFeriadoBL.SaveFeriado
        Return factoryrepository.SaveFeriado(_Feriado)
    End Function
End Class

Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class ElementoGastoBL : Implements IElementoGastoBL

    Dim factoryrepository As IElementoGastoRepository

    Public Sub New()
        factoryrepository = New ElementoGastoRepository
    End Sub

    Public Function GetAllFromElementoGasto() As System.Collections.Generic.List(Of BussinessEntities.ElementoGasto) Implements IElementoGastoBL.GetAllFromElementoGasto
        Return factoryrepository.GetAllFromElementoGasto
    End Function

    Public Function GetFromElementoGastoById(ByVal _id As Integer) As BussinessEntities.ElementoGasto Implements IElementoGastoBL.GetFromElementoGastoById
        Return factoryrepository.GetFromElementoGastoById(_id)
    End Function

    Public Function GetFromElementoGastoByIdClasificacion(ByVal _id As Integer) As BussinessEntities.ElementoGasto Implements IElementoGastoBL.GetFromElementoGastoByIdClasificacion
        Return factoryrepository.GetFromElementoGastoByIdClasificacion(_id)
    End Function

    Public Function DeleteElementoGasto(ByVal _id As Integer) As String Implements IElementoGastoBL.DeleteElementoGasto
        Return factoryrepository.DeleteElementoGasto(_id)
    End Function

    Public Function SaveElementoGasto(ByVal _ElementoGasto As BussinessEntities.ElementoGasto) As Integer Implements IElementoGastoBL.SaveElementoGasto
        Return factoryrepository.SaveElementoGasto(_ElementoGasto)
    End Function
End Class

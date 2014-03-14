Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class AmbitoProyectoBL : Implements IAmbitoProyectoBL

    Dim factoryrepository As IAmbitoProyectoRepository

    Public Sub New()
        factoryrepository = New AmbitoProyectoRepository
    End Sub

    Public Sub DeleteAmbitoProyecto(ByVal _id As Integer) Implements IAmbitoProyectoBL.DeleteAmbitoProyecto
        factoryrepository.DeleteAmbitoProyecto(_id)
    End Sub

    Public Function GetAllFromAmbitoProyecto() As System.Collections.Generic.List(Of BussinessEntities.AmbitoProyecto) Implements IAmbitoProyectoBL.GetAllFromAmbitoProyecto
        Return factoryrepository.GetAllFromAmbitoProyecto
    End Function

    Public Function GetAmbitoProyectoByIdProy(ByVal _IdProy As Integer) As System.Collections.Generic.List(Of BussinessEntities.AmbitoProyecto) Implements IAmbitoProyectoBL.GetAmbitoProyectoByIdProy
        Return factoryrepository.GetAmbitoProyectoByIdProy(_IdProy)
    End Function

    Public Function GetFromAmbitoProyectoById(ByVal _id As Integer) As BussinessEntities.AmbitoProyecto Implements IAmbitoProyectoBL.GetFromAmbitoProyectoById
        Return factoryrepository.GetFromAmbitoProyectoById(_id)
    End Function

    Public Sub SaveAmbitoProyecto(ByVal _AmbitoProyecto As System.Collections.Generic.List(Of BussinessEntities.AmbitoProyecto)) Implements IAmbitoProyectoBL.SaveAmbitoProyecto
        factoryrepository.SaveAmbitoProyecto(_AmbitoProyecto)
    End Sub
End Class

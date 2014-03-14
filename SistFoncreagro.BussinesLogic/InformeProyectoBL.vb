Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class InformeProyectoBL : Implements IInformeProyectoBL

    Dim factoryrepository As IInformeProyectoRepository

    Public Sub New()
        factoryrepository = New InformeProyectoRepository
    End Sub

    Public Sub DeleteInformeProyecto(ByVal _id As Integer) Implements IInformeProyectoBL.DeleteInformeProyecto
        factoryrepository.DeleteInformeProyecto(_id)
    End Sub

    Public Function GetInformeProyectoByIdProyecto(ByVal _idProy As Integer) As System.Collections.Generic.List(Of BussinessEntities.InformeProyecto) Implements IInformeProyectoBL.GetInformeProyectoByIdProyecto
        Return factoryrepository.GetInformeProyectoByIdProyecto(_idProy)
    End Function

    Public Function SaveInformeProyecto(ByVal _InformeProyecto As BussinessEntities.InformeProyecto) As Integer Implements IInformeProyectoBL.SaveInformeProyecto
        Return factoryrepository.SaveInformeProyecto(_InformeProyecto)
    End Function

    Public Function GetAllFromInformeProyectoById(ByVal _id As Integer) As BussinessEntities.InformeProyecto Implements IInformeProyectoBL.GetAllFromInformeProyectoById
        Return factoryrepository.GetAllFromInformeProyectoById(_id)
    End Function
End Class

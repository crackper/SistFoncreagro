Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class ProyCompBL : Implements IProyCompBL

    Dim factoryrepository As IProyCompRepository

    Public Sub New()
        factoryrepository = New ProyCompRepository
    End Sub

    Public Function GetAllFromProyComp() As System.Collections.Generic.List(Of BussinessEntities.ProyComp) Implements IProyCompBL.GetAllFromProyComp
        Return factoryrepository.GetAllFromProyComp
    End Function

    Public Function GetProyCompById(ByVal _id As Integer) As BussinessEntities.ProyComp Implements IProyCompBL.GetProyCompById
        Return factoryrepository.GetProyCompById(_id)
    End Function

    Public Function GetProyCompByIdProyecto(ByVal _idProy As Integer) As System.Collections.Generic.List(Of BussinessEntities.ProyComp) Implements IProyCompBL.GetProyCompByIdProyecto
        Return factoryrepository.GetProyCompByIdProyecto(_idProy)
    End Function

    Public Function DeleteProyComp(ByVal _id As Integer) As String Implements IProyCompBL.DeleteProyComp
        Return factoryrepository.DeleteProyComp(_id)
    End Function

    Public Function SaveProyComp(ByVal _ProyComp As BussinessEntities.ProyComp) As String Implements IProyCompBL.SaveProyComp
        Return factoryrepository.SaveProyComp(_ProyComp)
    End Function
End Class

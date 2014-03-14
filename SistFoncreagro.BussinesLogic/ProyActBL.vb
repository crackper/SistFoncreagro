Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class ProyActBL : Implements IProyActBL

    Dim factoryrepository As IProyActRepository

    Public Sub New()
        factoryrepository = New ProyActRepository
    End Sub

    Public Function GetAllFromProyAct() As System.Collections.Generic.List(Of BussinessEntities.ProyAct) Implements IProyActBL.GetAllFromProyAct
        Return factoryrepository.GetAllFromProyAct
    End Function

    Public Function GetProyActById(ByVal _id As Integer) As BussinessEntities.ProyAct Implements IProyActBL.GetProyActById
        Return factoryrepository.GetProyActById(_id)
    End Function

    Public Function GetProyActByIdProyecto(ByVal _idProy As Integer) As System.Collections.Generic.List(Of BussinessEntities.ProyAct) Implements IProyActBL.GetProyActByIdProyecto
        Return factoryrepository.GetProyActByIdProyecto(_idProy)
    End Function

    Public Function DeleteProyAct(ByVal _id As Integer) As String Implements IProyActBL.DeleteProyAct
        Return factoryrepository.DeleteProyAct(_id)
    End Function

    Public Function SaveProyAct(ByVal _ProyAct As BussinessEntities.ProyAct) As String Implements IProyActBL.SaveProyAct
        Return factoryrepository.SaveProyAct(_ProyAct)
    End Function
End Class

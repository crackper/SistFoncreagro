Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class EjerPresupBL : Implements IEjerPresupBL

    Dim factoryrepository As IEjerPresupRepository

    Public Sub New()
        factoryrepository = New EjerPresupRepository
    End Sub

    Public Function DeleteEjerPresup(ByVal _id As Integer) As String Implements IEjerPresupBL.DeleteEjerPresup
        Return factoryrepository.DeleteEjerPresup(_id)
    End Function

    Public Function GetAllFromEjerPresup() As System.Collections.Generic.List(Of BussinessEntities.EjerPresup) Implements IEjerPresupBL.GetAllFromEjerPresup
        Return factoryrepository.GetAllFromEjerPresup
    End Function

    Public Function GetEjerPresupByIdEjerPresup(ByVal _id As Integer) As BussinessEntities.EjerPresup Implements IEjerPresupBL.GetEjerPresupByIdEjerPresup
        Return factoryrepository.GetEjerPresupByIdEjerPresup(_id)
    End Function

    Public Function GetEjerPresupByEstado(ByVal _estado As String) As BussinessEntities.EjerPresup Implements IEjerPresupBL.GetEjerPresupByEstado
        Return factoryrepository.GetEjerPresupByEstado(_estado)
    End Function

    Public Function SaveEjerPresup(ByVal _EjerPresup As BussinessEntities.EjerPresup) As String Implements IEjerPresupBL.SaveEjerPresup
        Return factoryrepository.SaveEjerPresup(_EjerPresup)
    End Function

    Public Function EjerPresupEstado() As String Implements IEjerPresupBL.EjerPresupEstado
        Return factoryrepository.EjerPresupEstado
    End Function
End Class

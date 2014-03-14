Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class EjecucionBL : Implements IEjecucionBL
    Dim factoryrepository As IEjecucionRepository
    Public Sub New()
        factoryrepository = New EjecucionRepository
    End Sub

    Public Sub DeleteEJECUCION(ByVal IdEjecucion As Integer) Implements IEjecucionBL.DeleteEJECUCION
        factoryrepository.DeleteEJECUCION(IdEjecucion)
    End Sub

    Public Function GetEJECUCIONByIdEjecucion(ByVal IdEjecucion As Integer) As BussinessEntities.Ejecucion Implements IEjecucionBL.GetEJECUCIONByIdEjecucion
        Return factoryrepository.GetEJECUCIONByIdEjecucion(IdEjecucion)
    End Function

    Public Function GetEJECUCIONByIdProyecto(ByVal IdProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.Ejecucion) Implements IEjecucionBL.GetEJECUCIONByIdProyecto
        Return factoryrepository.GetEJECUCIONByIdProyecto(IdProyecto)
    End Function

    Public Function SaveEJECUCION(ByVal _Ejecucion As BussinessEntities.Ejecucion) As Integer Implements IEjecucionBL.SaveEJECUCION
        Return factoryrepository.SaveEJECUCION(_Ejecucion)
    End Function
End Class

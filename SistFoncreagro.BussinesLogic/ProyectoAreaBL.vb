Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ProyectoAreaBL : Implements IProyectoAreaBL
    Dim factoryrepository As IProyectoAreaRepository

    Public Sub New()
        factoryrepository = New ProyectoAreaRepository
    End Sub

    Public Sub DeleteProyectoArea(ByVal IdProyectoArea As Integer) Implements IProyectoAreaBL.DeleteProyectoArea
        factoryrepository.DeleteProyectoArea(IdProyectoArea)
    End Sub

    Public Function GetProyectoAreaByIdArea(ByVal IdArea As Integer) As System.Collections.Generic.List(Of BussinessEntities.ProyectoArea) Implements IProyectoAreaBL.GetProyectoAreaByIdArea
        Return factoryrepository.GetProyectoAreaByIdArea(IdArea)
    End Function

    Public Function GetProyectoAreaByIdAreaByProyectoVigentes(ByVal IdArea As Integer) As System.Collections.Generic.List(Of BussinessEntities.ProyectoArea) Implements IProyectoAreaBL.GetProyectoAreaByIdAreaByProyectoVigentes
        Return factoryrepository.GetProyectoAreaByIdAreaByProyectoVigentes(IdArea)
    End Function

    Public Function GetProyectoAreaByIdProyectoVigentes(ByVal IdProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.ProyectoArea) Implements IProyectoAreaBL.GetProyectoAreaByIdProyectoVigentes
        Return factoryrepository.GetProyectoAreaByIdProyectoVigentes(IdProyecto)
    End Function

    Public Function SaveProyectoArea(ByVal ProyectoArea As BussinessEntities.ProyectoArea) As Integer Implements IProyectoAreaBL.SaveProyectoArea
        Return factoryrepository.SaveProyectoArea(ProyectoArea)
    End Function
End Class

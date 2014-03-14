Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class PermisosBL : Implements IPermisosBL
    Dim factoryrepository As IPermisosRepository

    Public Sub New()
        factoryrepository = New PermisosRepository
    End Sub

    Public Function GetAllFromPermisos() As System.Collections.Generic.List(Of BussinessEntities.Permisos) Implements IPermisosBL.GetAllFromPermisos
        Return factoryrepository.GetAllFromPermisos
    End Function

    Public Function GetPermisosByDescripcion(descripcion As String) As BussinessEntities.Permisos Implements IPermisosBL.GetPermisosByDescripcion
        Return factoryrepository.GetPermisosByDescripcion(descripcion)
    End Function

    Public Function PASolicitaAprobacion(IdPersonal As Integer) As Integer Implements IPermisosBL.PASolicitaAprobacion
        Return factoryrepository.PASolicitaAprobacion(IdPersonal)
    End Function
End Class

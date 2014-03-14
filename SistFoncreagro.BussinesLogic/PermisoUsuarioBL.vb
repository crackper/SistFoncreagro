Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class PermisoUsuarioBL : Implements IPermisoUsuarioBL
    Dim factoryrepository As IPermisoUsuarioRepository

    Public Sub New()
        factoryrepository = New PermisoUsuarioRepository
    End Sub

    Public Function GetPERMISOUSUARIOByIdPersonal(IdPersonal As Integer) As BussinessEntities.PermisoUsuario Implements IPermisoUsuarioBL.GetPERMISOUSUARIOByIdPersonal
        Return factoryrepository.GetPERMISOUSUARIOByIdPersonal(IdPersonal)
    End Function

    Public Sub SavePERMISOUSUARIO(_PermisoUsuario As BussinessEntities.PermisoUsuario) Implements IPermisoUsuarioBL.SavePERMISOUSUARIO
        factoryrepository.SavePERMISOUSUARIO(_PermisoUsuario)
    End Sub
End Class

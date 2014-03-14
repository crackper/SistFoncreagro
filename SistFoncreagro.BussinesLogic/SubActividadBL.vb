Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class SubActividadBL : Implements ISubActividadBL
    Dim factoryrepository As ISubActividadRepository

    Public Sub New()
        factoryrepository = New SubActividadRepository
    End Sub

    Public Sub DeleteSubActividad(IdSubActividad As Integer) Implements ISubActividadBL.DeleteSubActividad
        factoryrepository.DeleteSubActividad(IdSubActividad)
    End Sub

    Public Sub GenerarPoaTecnico(IdProyecto As Integer) Implements ISubActividadBL.GenerarPoaTecnico
        factoryrepository.GenerarPoaTecnico(IdProyecto)
    End Sub

    Public Function GetSUBACTIVIDADByIdSubActividad(IdSubActividad As Integer) As BussinessEntities.SubActividad Implements ISubActividadBL.GetSUBACTIVIDADByIdSubActividad
        Return factoryrepository.GetSUBACTIVIDADByIdSubActividad(IdSubActividad)
    End Function

    Public Sub SaveSUBACTIVIDAD(_SUBACTIVIDAD As BussinessEntities.SubActividad) Implements ISubActividadBL.SaveSUBACTIVIDAD
        factoryrepository.SaveSUBACTIVIDAD(_SUBACTIVIDAD)
    End Sub
End Class

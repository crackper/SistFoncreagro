Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class RolPersonalBL : Implements IRolPersonalBL
    Dim factoryRolPersonal As IRolPersonalRepository
    Sub New()
        factoryRolPersonal = New RolPersonalRepository
    End Sub

    Public Sub DeleteRolPersonal(ByVal idRolPersonal As Integer) Implements IRolPersonalBL.DeleteRolPersonal
        factoryRolPersonal.DeleteRolPersonal(idRolPersonal)
    End Sub

    Public Sub SaveRolPersonal(ByVal rolPersona As BussinessEntities.RolPersonal) Implements IRolPersonalBL.SaveRolPersonal
        factoryRolPersonal.SaveRolPersonal(rolPersona)
    End Sub

    Public Function GetFromRolPersonalByIdRol(ByVal idRol As Integer, ByVal IdPerProy As Integer, ByVal Tipo As Boolean) As System.Collections.Generic.List(Of BussinessEntities.RolPersonal) Implements IRolPersonalBL.GetFromRolPersonalByIdRol
        Return factoryRolPersonal.GetFromRolPersonalByIdRol(idRol, IdPerProy, Tipo)
    End Function

    Public Sub UpdateResponsable(ByVal idPersonalOriginal As Integer, ByVal idPersonalReemplazo As Integer, ByVal idRol As Integer, ByVal idproyecto As Integer) Implements IRolPersonalBL.UpdateResponsable
        factoryRolPersonal.UpdateResponsable(idPersonalOriginal, idPersonalReemplazo, idRol, idproyecto)
    End Sub
End Class

Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class RolBL : Implements IRolBL
    Dim aRolRepository As IRolRepository
    Sub New()
        aRolRepository = New RolRepository
    End Sub
    Public Sub DeleteROL(ByVal IdRol As Integer) Implements IRolBL.DeleteROL
        aRolRepository.DeleteROL(IdRol)
    End Sub
    Public Function GetAllFromROL() As System.Collections.Generic.List(Of BussinessEntities.ROL) Implements IRolBL.GetAllFromROL
        Return aRolRepository.GetAllFromROL
    End Function
    Public Function GetROLByIdRol(ByVal IdRol As Integer) As BussinessEntities.ROL Implements IRolBL.GetROLByIdRol
        Return aRolRepository.GetROLByIdRol(IdRol)
    End Function
    Public Function SaveROL(ByVal rol As BussinessEntities.ROL) As Integer Implements IRolBL.SaveROL
        Return aRolRepository.SaveROL(rol)
    End Function
End Class

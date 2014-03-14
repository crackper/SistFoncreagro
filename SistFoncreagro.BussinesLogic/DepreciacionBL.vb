Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class DepreciacionBL : Implements IDepreciacionBL
    Dim factoryrepository As IDepreciacionRepository
    Public Sub New()
        factoryrepository = New DepreciacionRepository
    End Sub
    Public Sub DeleteDEPRECIACION(ByVal IdDepreciacion As Integer) Implements IDepreciacionBL.DeleteDEPRECIACION
        factoryrepository.DeleteDEPRECIACION(IdDepreciacion)
    End Sub

    Public Function GetDEPRECIACIONByIdDepreciacion(ByVal IdDeprecicion As Integer) As BussinessEntities.Depreciacion Implements IDepreciacionBL.GetDEPRECIACIONByIdDepreciacion
        Return factoryrepository.GetDEPRECIACIONByIdDepreciacion(IdDeprecicion)
    End Function

    Public Sub SaveDEPRECIACION(ByVal _Depreciacion As BussinessEntities.Depreciacion) Implements IDepreciacionBL.SaveDEPRECIACION
        factoryrepository.SaveDEPRECIACION(_Depreciacion)
    End Sub

    Public Sub GenerarDepreciacion(ByVal fechaContable As Date, ByVal usuario As Integer, ByVal ejercicio As Integer, ByVal mes As Integer, ByVal idProyecto As Integer) Implements IDepreciacionBL.GenerarDepreciacion
        factoryrepository.GenerarDepreciacion(fechaContable, usuario, ejercicio, mes, idProyecto)
    End Sub
End Class

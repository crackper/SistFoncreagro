Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ResponsableBL : Implements IResponsableBL
    Dim factoryrepository As IResponsableRepository

    Public Sub New()
        factoryrepository = New ResponsableRepository
    End Sub

    Public Sub DeleteRESPONSABLE(ByVal IdResponsable As Integer) Implements IResponsableBL.DeleteRESPONSABLE
        factoryrepository.DeleteRESPONSABLE(IdResponsable)
    End Sub

    Public Function GetRESPONSABLEByIdControl(ByVal IdControl As Integer) As System.Collections.Generic.List(Of BussinessEntities.Responsable) Implements IResponsableBL.GetRESPONSABLEByIdControl
        Return factoryrepository.GetRESPONSABLEByIdControl(IdControl)
    End Function

    Public Function GetRESPONSABLEByIdResponsable(ByVal IdResponsable As Integer) As BussinessEntities.Responsable Implements IResponsableBL.GetRESPONSABLEByIdResponsable
        Return factoryrepository.GetRESPONSABLEByIdResponsable(IdResponsable)
    End Function

    Public Sub SaveRESPONSABLE(ByVal _Responsable As BussinessEntities.Responsable) Implements IResponsableBL.SaveRESPONSABLE
        factoryrepository.SaveRESPONSABLE(_Responsable)
    End Sub
End Class

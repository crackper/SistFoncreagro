Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ResponsableBienMuebleBL : Implements IResponsableBienMuebleBL
    Dim factoryrepository As IResponsableBienMuebleRepository

    Public Sub New()
        factoryrepository = New ResponsableBienMuebleRepository
    End Sub
    Public Function GetRESPONSABLEBIENMUEBLEByIdBienMueble(ByVal IdBienMueble As Integer) As System.Collections.Generic.List(Of BussinessEntities.ResponsableBienMueble) Implements IResponsableBienMuebleBL.GetRESPONSABLEBIENMUEBLEByIdBienMueble
        Return factoryrepository.GetRESPONSABLEBIENMUEBLEByIdBienMueble(IdBienMueble)
    End Function

    Public Function GetRESPONSABLEBIENMUEBLEByIdResponsable(ByVal IdResponsable As Integer) As BussinessEntities.ResponsableBienMueble Implements IResponsableBienMuebleBL.GetRESPONSABLEBIENMUEBLEByIdResponsable
        Return factoryrepository.GetRESPONSABLEBIENMUEBLEByIdResponsable(IdResponsable)
    End Function

    Public Sub SaveRESPONSABLEBIENMUEBLE(ByVal _ResponsableBienMueble As BussinessEntities.ResponsableBienMueble) Implements IResponsableBienMuebleBL.SaveRESPONSABLEBIENMUEBLE
        factoryrepository.SaveRESPONSABLEBIENMUEBLE(_ResponsableBienMueble)
    End Sub

    Public Sub DeleteRESPONSABLEBIENMUEBLE(ByVal IdResponsable As Integer) Implements IResponsableBienMuebleBL.DeleteRESPONSABLEBIENMUEBLE
        factoryrepository.DeleteRESPONSABLEBIENMUEBLE(IdResponsable)
    End Sub
End Class

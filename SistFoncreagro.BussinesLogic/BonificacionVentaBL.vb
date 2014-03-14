Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class BonificacionVentaBL : Implements IBonificacionVentaBL
    Dim factoryrepository As IBonificacionVentaRepository

    Public Sub New()
        factoryrepository = New BonificacionVentaRepository
    End Sub

    Public Sub DeleteBONIFICACIONVENTA(ByVal IdBonificacion As Integer) Implements IBonificacionVentaBL.DeleteBONIFICACIONVENTA
        factoryrepository.DeleteBONIFICACIONVENTA(IdBonificacion)
    End Sub

    Public Function GetBONIFICACIONVENTAByIdBonificacion(ByVal IdBonificacion As Integer) As BussinessEntities.BonificacionVenta Implements IBonificacionVentaBL.GetBONIFICACIONVENTAByIdBonificacion
        Return factoryrepository.GetBONIFICACIONVENTAByIdBonificacion(IdBonificacion)
    End Function

    Public Function GetBONIFICACIONVENTAByIdVenta(ByVal IdVenta As Integer) As System.Collections.Generic.List(Of BussinessEntities.BonificacionVenta) Implements IBonificacionVentaBL.GetBONIFICACIONVENTAByIdVenta
        Return factoryrepository.GetBONIFICACIONVENTAByIdVenta(IdVenta)
    End Function

    Public Sub SaveBONIFICACIONVENTA(ByVal _Bonificacion As BussinessEntities.BonificacionVenta) Implements IBonificacionVentaBL.SaveBONIFICACIONVENTA
        factoryrepository.SaveBONIFICACIONVENTA(_Bonificacion)
    End Sub
End Class

Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class CatalogoVentaBL : Implements ICatalogoVentaBL
    Dim factoryrepository As ICatalogoVentaRepository
    Public Sub New()
        factoryrepository = New CatalogoVentaRepository
    End Sub
    Public Function GetAllFromCATALOGOVENTAS() As System.Collections.Generic.List(Of BussinessEntities.CatalogoVenta) Implements ICatalogoVentaBL.GetAllFromCATALOGOVENTAS
        Return factoryrepository.GetAllFromCATALOGOVENTAS()
    End Function

    Public Function GetCATALOGOVENTAByIdCatVenta(ByVal IdCatVenta As Integer) As BussinessEntities.CatalogoVenta Implements ICatalogoVentaBL.GetCATALOGOVENTAByIdCatVenta
        Return factoryrepository.GetCATALOGOVENTAByIdCatVenta(IdCatVenta)
    End Function

    Public Sub SaveCATALOGOVENTA(ByVal _CatalogoVenta As BussinessEntities.CatalogoVenta) Implements ICatalogoVentaBL.SaveCATALOGOVENTA
        factoryrepository.SaveCATALOGOVENTA(_CatalogoVenta)
    End Sub

    Public Sub UpdateEstadoCATALOGOVENTA(ByVal IdCatVenta As Integer) Implements ICatalogoVentaBL.UpdateEstadoCATALOGOVENTA
        factoryrepository.UpdateEstadoCATALOGOVENTA(IdCatVenta)
    End Sub
End Class

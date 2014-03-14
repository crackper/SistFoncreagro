Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class DetalleVentaBL : Implements IDetalleVentaBL
    Dim factoryrepository As IDetalleVentaRepository
    Public Sub New()
        factoryrepository = New DetalleVentaRepository
    End Sub

    Public Sub DeleteDETALLEVENTA(ByVal IdDetalleVenta As Integer) Implements IDetalleVentaBL.DeleteDETALLEVENTA
        factoryrepository.DeleteDETALLEVENTA(IdDetalleVenta)
    End Sub

    Public Function GetDETALLEVENTAByIdDetalleVenta(ByVal IdDetalleVenta As Integer) As BussinessEntities.DetalleVenta Implements IDetalleVentaBL.GetDETALLEVENTAByIdDetalleVenta
        Return factoryrepository.GetDETALLEVENTAByIdDetalleVenta(IdDetalleVenta)
    End Function

    Public Function GetDETALLEVENTAByIdVenta(ByVal IdVenta As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleVenta) Implements IDetalleVentaBL.GetDETALLEVENTAByIdVenta
        Return factoryrepository.GetDETALLEVENTAByIdVenta(IdVenta)
    End Function

    Public Sub SaveDETALLEVENTA(ByVal _DetalleVenta As BussinessEntities.DetalleVenta) Implements IDetalleVentaBL.SaveDETALLEVENTA
        factoryrepository.SaveDETALLEVENTA(_DetalleVenta)
    End Sub
End Class

Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ProveedorDetalleCotizacionBL : Implements IProveedorDetalleCotizacionBL
    Dim proveedorDetalleCotifactory As IProveedorDetalleCotizacionRepository
    Sub New()
        proveedorDetalleCotifactory = New ProveedorDetalleCotizacionRepository
    End Sub

    Public Function GetAllFromProveedorDetalleCotizacionByIdDetalleReqCotizacion(ByVal idDetalleReqCotizacion As Integer) As System.Collections.Generic.List(Of BussinessEntities.ProveedorDetalleCotizacion) Implements IProveedorDetalleCotizacionBL.GetAllFromProveedorDetalleCotizacionByIdDetalleReqCotizacion
        Return proveedorDetalleCotifactory.GetAllFromProveedorDetalleCotizacionByIdDetalleReqCotizacion(idDetalleReqCotizacion)
    End Function

    'Public Sub UpdateProveedorDetalleCotizacion(ByVal proveedorDetalleCoti As BussinessEntities.ProveedorDetalleCotizacion) Implements IProveedorDetalleCotizacionBL.UpdateProveedorDetalleCotizacion
    '    proveedorDetalleCotifactory.UpdateProveedorDetalleCotizacion(proveedorDetalleCoti)
    'End Sub

    Public Sub SaveProveedorDetalleCotizacion1(ByVal proveedorDetalleCoti As System.Collections.Generic.List(Of BussinessEntities.ProveedorDetalleCotizacion)) Implements IProveedorDetalleCotizacionBL.SaveProveedorDetalleCotizacion1
        proveedorDetalleCotifactory.SaveProveedorDetalleCotizacion1(proveedorDetalleCoti)
    End Sub

    Public Sub DeleteProveedor1(ByVal proveedorDetCot As System.Collections.Generic.List(Of BussinessEntities.ProveedorDetalleCotizacion)) Implements IProveedorDetalleCotizacionBL.DeleteProveedor1
        proveedorDetalleCotifactory.DeleteProveedor1(proveedorDetCot)
    End Sub

    Public Sub UpdateProveedorDetalleCotizacion1(ByVal proveedorDetalleCoti As System.Collections.Generic.List(Of BussinessEntities.ProveedorDetalleCotizacion)) Implements IProveedorDetalleCotizacionBL.UpdateProveedorDetalleCotizacion1
        proveedorDetalleCotifactory.UpdateProveedorDetalleCotizacion1(proveedorDetalleCoti)
    End Sub

    Public Sub UpdateIgvCotizacion(ByVal IdDetalleRequerimiento As Integer, ByVal valor As Boolean) Implements IProveedorDetalleCotizacionBL.UpdateIgvCotizacion
        proveedorDetalleCotifactory.UpdateIgvCotizacion(IdDetalleRequerimiento, valor)
    End Sub
End Class

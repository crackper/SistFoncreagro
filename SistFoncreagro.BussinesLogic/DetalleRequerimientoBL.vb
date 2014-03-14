Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class DetalleRequerimientoBL : Implements IDetalleRequerimientoBL
    Dim factoryRepsitory As IDetalleRequerimientoRepository
    Sub New()
        factoryRepsitory = New DetalleRequerimientoRepository
    End Sub
    Public Sub EliminarDetalle(ByVal idDetalleRequerimiento As Integer) Implements IDetalleRequerimientoBL.EliminarDetalle
        factoryRepsitory.EliminarDetalle(idDetalleRequerimiento)
    End Sub
    Public Function GetAllFromDetalleRequerimientoByIdReq(ByVal idRequerimiento As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleRequerimiento) Implements IDetalleRequerimientoBL.GetAllFromDetalleRequerimientoByIdReq
        Return factoryRepsitory.GetAllFromDetalleRequerimientoByIdReq(idRequerimiento)
    End Function
    Public Function GetAllFromDetalleRequerimientoOrdenadoByIdReq(ByVal idRequerimiento As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleRequerimiento) Implements IDetalleRequerimientoBL.GetAllFromDetalleRequerimientoOrdenadoByIdReq
        Return factoryRepsitory.GetAllFromDetalleRequerimientoOrdenadoByIdReq(idRequerimiento)
    End Function
    Public Sub SaveDetalleRequerimiento(ByVal detalleRequerimiento As BussinessEntities.DetalleRequerimiento) Implements IDetalleRequerimientoBL.SaveDetalleRequerimiento
        factoryRepsitory.SaveDetalleRequerimiento(detalleRequerimiento)
    End Sub
    Public Sub UpdateDetalleRequerimiento(ByVal detalleRequerimiento As BussinessEntities.DetalleRequerimiento) Implements IDetalleRequerimientoBL.UpdateDetalleRequerimiento
        factoryRepsitory.UpdateDetalleRequerimiento(detalleRequerimiento)
    End Sub
    Public Function GetDetalleRequerimientoByIdDetalleReq(ByVal idDetalleRequerimiento As Integer) As BussinessEntities.DetalleRequerimiento Implements IDetalleRequerimientoBL.GetDetalleRequerimientoByIdDetalleReq
        Return factoryRepsitory.GetDetalleRequerimientoByIdDetalleReq(idDetalleRequerimiento)
    End Function
    Public Function GetAllFromDetalleRequerimientoByEstadoByIdReq(ByVal idRequerimiento As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleRequerimiento) Implements IDetalleRequerimientoBL.GetAllFromDetalleRequerimientoByEstadoByIdReq
        Return factoryRepsitory.GetAllFromDetalleRequerimientoByEstadoByIdReq(idRequerimiento)
    End Function
    Public Sub AnularItemDetalle(ByVal idDetalleRequerimiento As Integer, ByVal motivo As String) Implements IDetalleRequerimientoBL.AnularItemDetalle
        factoryRepsitory.AnularItemDetalle(idDetalleRequerimiento, motivo)
    End Sub
End Class

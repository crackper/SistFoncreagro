Imports SistFoncreagro.BussinessEntities
Public Interface IDetalleRequerimientoBL
    Function GetAllFromDetalleRequerimientoByEstadoByIdReq(ByVal idRequerimiento As Integer) As List(Of DetalleRequerimiento)
    Function GetAllFromDetalleRequerimientoByIdReq(ByVal idRequerimiento As Integer) As List(Of DetalleRequerimiento)
    Function GetAllFromDetalleRequerimientoOrdenadoByIdReq(ByVal idRequerimiento As Integer) As List(Of DetalleRequerimiento)
    Function GetDetalleRequerimientoByIdDetalleReq(ByVal idDetalleRequerimiento As Int32) As DetalleRequerimiento
    Sub SaveDetalleRequerimiento(ByVal detalleRequerimiento As DetalleRequerimiento)
    Sub UpdateDetalleRequerimiento(ByVal detalleRequerimiento As DetalleRequerimiento)
    Sub EliminarDetalle(ByVal idDetalleRequerimiento As Int32)
    Sub AnularItemDetalle(ByVal idDetalleRequerimiento As Int32, ByVal motivo As String)
End Interface

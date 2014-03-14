Imports SistFoncreagro.BussinessEntities

Public Interface IOrdenCompraRepository
    Function GetAllFromOrdenCompraByIdComprador(ByVal idComprador As Int32) As List(Of OrdenCompra)
    Function GetOrdenCompraByIdOrdenCompra(ByVal idOrdenCompra As Int32, ByVal detalle As Boolean) As OrdenCompra
    Function GetAllFromOrdenCompraPorAprobarByIdResponsable(ByVal idResponsable As Int32) As List(Of OrdenCompra)
    Sub AprobarOrdenCompra(ByVal IdOrdenCompra As Int32, ByVal IdPersonal As Int32)
    Function GetAllFromOrdenCompraAprobadasEnviadasByIdComprador(ByVal IdComprador As Int32) As List(Of OrdenCompra)
    Sub UpdateOcEnviarProveedor(ByVal idOrdenCompra As Int32, ByVal idLugarRecepcion As Int32, ByVal fechaEntregaEjecucion As Date)
    Sub UpdateOrdenCompra(ByVal ordenCompra As OrdenCompra)
    Sub AnularOrdenCompra(ByVal idOrdenCompra As Int32, ByVal idPersonal As Int32, ByVal Motivo As String, ByVal tipo As Int32)
    Sub SolicitarAprobacion(ByVal idOrdenCompra As Int32, ByVal IdTipoPago As Int32, ByVal anticipo As Decimal)
    Function GetAllFromOrdenCompraByIdResponsableAprobar(ByVal IdPersonaAprueba As Int32) As List(Of OrdenCompra)
    Function GetAllFromDetalleOrdenCompraByIdOrdenCompra(ByVal idOrdenCompra As Int32) As List(Of DetalleOrdenCompra)
    Function GetAllFromDetalleByIdCCosto(ByVal IdCcosto As Int32, ByVal IdOrden As Int32) As List(Of DetalleOrdenCompra)
    Function GetAllFromOrdenCompraEnviadasRecepcionadas() As List(Of OrdenCompra)
    Function GetAllFromOrdenCompraEnviadasRecepcionadasByTipo(ByVal tipo As String) As List(Of OrdenCompra)
    Sub SaveRecepcionOrdenCompra(ByVal ordenCompra As OrdenCompra, ByVal tipoRecepcion As Boolean)
    Function GetAllFromOrdenCompra(ByVal parametro As String) As List(Of OrdenCompra)
End Interface

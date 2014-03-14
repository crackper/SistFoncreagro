Imports SistFoncreagro.BussinessEntities
Public Interface ITipoTrabajadorDetalleConceptoBL
    Function GetTipoTrabajadorDetalleConceptoByDisponible(ByVal Disponible As Boolean) As List(Of TipoTrabajadorDetalleConcepto)
    Function SaveTipoTrabajadorDetalleConcepto(ByVal TipoTrabajadorDetalleConcepto As TipoTrabajadorDetalleConcepto) As Int32
    Sub DeleteTipoTrabajadorDetalleConcepto(ByVal IdTipoTDetConcepto As Int32)
    Function GetTipoTrabajadorDetalleConceptoByIds(ByVal IdTipoTrabajador As Int32, ByVal IdCategoria As Int32, ByVal IdDetalleConcepto As Int32) As TipoTrabajadorDetalleConcepto

    Sub SaveAndDeleteListaTipoTrabajador(ByVal listaCrear As List(Of TipoTrabajadorDetalleConcepto), ByVal listaEliminar As List(Of Int32))
End Interface

Imports SistFoncreagro.BussinessEntities
Public Interface ITipoTrabajadorBL
    'Function GetAllFromTipoTrabajador() As List(Of TipoTrabajador)
    Function GetTipoTrabajadorByIdTipoTrabajadorIdCategoria(ByVal idTipoTrabajador As Int32, ByVal idCategoria As Int32) As TipoTrabajador
    Function GetTipoTrabajadorByIdCategoria(ByVal idCategoria As Int32) As List(Of TipoTrabajador)
    Function GetTipoTrabajadorByIdCategoriaYDisponibles(ByVal idCategoria As Int32, ByVal disponible As Boolean) As List(Of TipoTrabajador)
    Function GetTipoTrabajadorByDisponible(ByVal Disponible As Boolean) As List(Of TipoTrabajador)
    'Sub SaveTipoTrabajador(ByVal tipoTrabajador As TipoTrabajador)
    'Sub DeleteTipoTrabajador(ByVal idTipoTrabajador As Int32, ByVal idCategoria As Int32)
End Interface

Imports SistFoncreagro.BussinessEntities
Public Interface ITipoContratoRepository
    Function GetAllFromTipoContrato() As List(Of TipoContrato)
    Function GetTipoContratoByIdTipoContrato(ByVal idTipoContrato As Int32) As TipoContrato
    Function GetTipoContratoByIdCategoria(ByVal idCategoria As Int32) As List(Of TipoContrato)
    Sub SaveTipoContrato(ByVal tipoContrato As TipoContrato)
    Sub DeleteTipoContrato(ByVal idTipoContrato As Int32)
End Interface

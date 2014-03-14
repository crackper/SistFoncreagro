Imports SistFoncreagro.BussinessEntities
Public Interface ITipoDocumentoIdentidadRepository
    Function GetAllFromTipoDocumentoIdentidad() As List(Of TipoDocumentoIdentidad)
    Function GetTipoDocumentoIdentidadByIdTipoDI(ByVal idTipoDI As Int32) As TipoDocumentoIdentidad
    Function GetTipoDocumentoIdentidadByIdNacionalidad(ByVal IdNacionalidad) As List(Of TipoDocumentoIdentidad)
    Sub SaveTipoDocumentoIdentidad(ByVal tipoDocumentoIdentidad As TipoDocumentoIdentidad)
    Sub DeleteTipoDocumentoIdentidad(ByVal idTipoDI As Int32)
End Interface

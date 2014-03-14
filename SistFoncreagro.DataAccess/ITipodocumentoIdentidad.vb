Imports SistFoncreagro.BussinessEntities
Public Interface ITipodocumentoIdentidad
    Function GetAllFromTipoDocumentoIdentidad() As List(Of TipoDocumentoIdentidad)
    Function GetTipoDocumentoIdentidadByIdNacionalidad(ByVal idNacionalidad As Int32) As List(Of TipoDocumentoIdentidad)
    Function GetTipoDocumentoIdentidadByTipoPersona(ByVal tipoPersona As String) As List(Of TipoDocumentoIdentidad)
End Interface

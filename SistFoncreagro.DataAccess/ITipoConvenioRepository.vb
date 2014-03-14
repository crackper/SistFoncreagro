Imports SistFoncreagro.BussinessEntities

Public Interface ITipoConvenioRepository
    Function GetAllFromTipoConvenio() As List(Of TipoConvenio)
    Function GetTipoConvenioByIdTipoConvenio(ByVal _IdTipoConvenio As Int32) As TipoConvenio
    Function SaveTipoConvenio(ByVal _TipoConvenio As TipoConvenio) As Int32
    Sub DeleteTipoConvenio(ByVal id As String)
End Interface

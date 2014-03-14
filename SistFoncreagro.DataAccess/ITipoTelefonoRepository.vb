Imports SistFoncreagro.BussinessEntities
Public Interface ITipoTelefonoRepository
    Function GetAllTipoTelefono() As List(Of TipoTelefono)
    Function GetTipoTelefonoByIdTipoTelefono(ByVal IdTipoTelefono As Int32) As TipoTelefono
End Interface

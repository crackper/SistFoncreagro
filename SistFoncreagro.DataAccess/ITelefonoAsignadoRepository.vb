Imports SistFoncreagro.BussinessEntities
Public Interface ITelefonoAsignadoRepository
    Function GetAllFromTelefonoAsignado() As List(Of TelefonoAsignado)
    Function GetTelefonoAsignadoByIdAsignacionTelefono(ByVal IdAsignacionTelefono As Int32) As TelefonoAsignado
    Function GetTelefonoAsignadoByIdPeriodoLaboralByEstado(ByVal IdPeriodoLaboral As Int32, ByVal estado As Boolean) As List(Of TelefonoAsignado)
    Function SaveTelefonoAsignado(ByVal telefonoAsignado As TelefonoAsignado) As Int32
    Sub DeleteTelefonoAsignado(ByVal IdAsignacionTelefono As Int32)

End Interface

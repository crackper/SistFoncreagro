Imports SistFoncreagro.BussinessEntities
Public Interface ITelefonoCoorporativoRepository
    Function GetAllFromTelefonoCoorporativo() As List(Of TelefonoCoorporativo)
    Function GetTelefonoCoorporativoByIdTelefCoorporativo(ByVal IdTelefCoorporativo As Int32) As TelefonoCoorporativo
End Interface

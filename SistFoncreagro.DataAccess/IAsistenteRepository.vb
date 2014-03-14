Imports SistFoncreagro.BussinessEntities
Public Interface IAsistenteRepository
    Function GetASISTENTEByIdControl(ByVal IdControl As Int32) As List(Of Asistente)
    Sub SaveASISTENTE(ByVal _Asistente As Asistente)
    Function GetASISTENTEByIdAsistente(ByVal IdAsistente As Int32) As Asistente
    Sub DeleteASISTENTE(ByVal IdAsistente As Int32)
End Interface

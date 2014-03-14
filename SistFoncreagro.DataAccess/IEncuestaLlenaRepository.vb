Imports SistFoncreagro.BussinessEntities
Public Interface IEncuestaLlenaRepository
    Function SaveENCUESTALLENA(ByVal _EncuestaLlena As EncuestaLlena) As Int32
    Function GenerarENCUESTALLENA(ByVal IdPersonal As Int32) As Int32
    Function GetENCUESTALLENAByIdEncuesta(ByVal IdEncuestaLlena As Int32) As EncuestaLlena
    Sub UpdateENCUESTALLENA(ByVal IdEncuestaLlena As Int32)
    Function VerifyExisteENCUESTALLENAByIdPersonal(ByVal IdPersonal As Int32) As Int32
End Interface

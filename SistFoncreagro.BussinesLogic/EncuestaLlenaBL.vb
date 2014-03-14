Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class EncuestaLlenaBL : Implements IEncuestaLlenaBL
    Dim factoryrepository As IEncuestaLlenaRepository

    Public Sub New()
        factoryrepository = New EncuestaLlenaRepository
    End Sub

    Public Function GenerarENCUESTALLENA(ByVal IdPersonal As Integer) As Integer Implements IEncuestaLlenaBL.GenerarENCUESTALLENA
        Return factoryrepository.GenerarENCUESTALLENA(IdPersonal)
    End Function

    Public Function GetENCUESTALLENAByIdEncuesta(ByVal IdEncuestaLlena As Integer) As BussinessEntities.EncuestaLlena Implements IEncuestaLlenaBL.GetENCUESTALLENAByIdEncuesta
        Return factoryrepository.GetENCUESTALLENAByIdEncuesta(IdEncuestaLlena)
    End Function

    Public Sub UpdateENCUESTALLENA(ByVal IdEncuestaLlena As Integer) Implements IEncuestaLlenaBL.UpdateENCUESTALLENA
        factoryrepository.UpdateENCUESTALLENA(IdEncuestaLlena)
    End Sub

    Public Function SaveENCUESTALLENA(ByVal _EncuestaLlena As BussinessEntities.EncuestaLlena) As Integer Implements IEncuestaLlenaBL.SaveENCUESTALLENA
        Return factoryrepository.SaveENCUESTALLENA(_EncuestaLlena)
    End Function

    Public Function VerifyExisteENCUESTALLENAByIdPersonal(ByVal IdPersonal As Integer) As Integer Implements IEncuestaLlenaBL.VerifyExisteENCUESTALLENAByIdPersonal
        Return factoryrepository.VerifyExisteENCUESTALLENAByIdPersonal(IdPersonal)
    End Function
End Class

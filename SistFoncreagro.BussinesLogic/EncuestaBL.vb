Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class EncuestaBL : Implements IEncuestaBL
    Dim factoryrepository As IEncuestaRepository

    Public Sub New()
        factoryrepository = New EncuestaRepository
    End Sub

    Public Sub DeleteENCUESTA(ByVal IdEncuesta As Integer) Implements IEncuestaBL.DeleteENCUESTA
        factoryrepository.DeleteENCUESTA(IdEncuesta)
    End Sub

    Public Function GetAllFromENCUESTA() As System.Collections.Generic.List(Of BussinessEntities.Encuesta) Implements IEncuestaBL.GetAllFromENCUESTA
        Return factoryrepository.GetAllFromENCUESTA
    End Function

    Public Function GetENCUESTAByIdEncuesta(ByVal IdEncuesta As Integer) As BussinessEntities.Encuesta Implements IEncuestaBL.GetENCUESTAByIdEncuesta
        Return factoryrepository.GetENCUESTAByIdEncuesta(IdEncuesta)
    End Function

    Public Sub SaveENCUESTA(ByVal _Encuesta As BussinessEntities.Encuesta) Implements IEncuestaBL.SaveENCUESTA
        factoryrepository.SaveENCUESTA(_Encuesta)
    End Sub
End Class

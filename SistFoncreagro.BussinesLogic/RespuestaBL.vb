Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class RespuestaBL : Implements IRespuestaBL
    Dim factoryrepository As IRespuestaRepository

    Public Sub New()
        factoryrepository = New RespuestaRepository
    End Sub

    Public Function GetRESPUESTAByIdEncuestaLlena(ByVal IdEncuestaLlena As Integer) As System.Collections.Generic.List(Of BussinessEntities.Respuesta) Implements IRespuestaBL.GetRESPUESTAByIdEncuestaLlena
        Return factoryrepository.GetRESPUESTAByIdEncuestaLlena(IdEncuestaLlena)
    End Function

    Public Function GetRESPUESTAByIdRespuesta(ByVal IdRespuesta As Integer) As BussinessEntities.Respuesta Implements IRespuestaBL.GetRESPUESTAByIdRespuesta
        Return factoryrepository.GetRESPUESTAByIdRespuesta(IdRespuesta)
    End Function

    Public Sub UpdateRESPUESTA(ByVal _Respuesta As BussinessEntities.Respuesta) Implements IRespuestaBL.UpdateRESPUESTA
        factoryrepository.UpdateRESPUESTA(_Respuesta)
    End Sub

    Public Sub SaveRESPUESTA(ByVal IdEncuestaLlena As Integer) Implements IRespuestaBL.SaveRESPUESTA
        factoryrepository.SaveRESPUESTA(IdEncuestaLlena)
    End Sub
End Class

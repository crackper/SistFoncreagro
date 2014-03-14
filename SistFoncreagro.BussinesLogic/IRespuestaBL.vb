Imports SistFoncreagro.BussinessEntities
Public Interface IRespuestaBL
    Function GetRESPUESTAByIdRespuesta(ByVal IdRespuesta As Int32) As Respuesta
    Function GetRESPUESTAByIdEncuestaLlena(ByVal IdEncuestaLlena As Int32) As List(Of Respuesta)
    Sub UpdateRESPUESTA(ByVal _Respuesta As Respuesta)
    Sub SaveRESPUESTA(ByVal IdEncuestaLlena As Int32)
End Interface

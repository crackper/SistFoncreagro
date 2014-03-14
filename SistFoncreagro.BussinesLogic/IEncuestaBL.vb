Imports SistFoncreagro.BussinessEntities
Public Interface IEncuestaBL
    Sub SaveENCUESTA(ByVal _Encuesta As Encuesta)
    Sub DeleteENCUESTA(ByVal IdEncuesta As Int32)
    Function GetENCUESTAByIdEncuesta(ByVal IdEncuesta As Int32) As Encuesta
    Function GetAllFromENCUESTA() As List(Of Encuesta)
End Interface

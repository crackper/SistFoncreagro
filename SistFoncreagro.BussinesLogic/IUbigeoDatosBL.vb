Imports SistFoncreagro.BussinessEntities

Public Interface IUbigeoDatosBL
    Function GetAllFromUbigeoDatos() As List(Of UbigeoDatos)
    Function GetUbigeoDatosByIdUbigeoDatos(ByVal _IdUbigeoDatos As String) As UbigeoDatos
    Function GetUbigeoDatosByNivel(ByVal _Nivel As String) As List(Of UbigeoDatos)
    Function GetUBIGEODATOSByParameter(ByVal texto As String) As List(Of UbigeoDatos)
End Interface

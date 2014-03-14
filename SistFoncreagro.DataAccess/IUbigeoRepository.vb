Imports SistFoncreagro.BussinessEntities

Public Interface IUbigeoRepository
    Function GetAllFromUbigeo() As List(Of Ubigeo)
    Function GetUbigeoByIdUbigeo(ByVal _IdUbigeo As String) As Ubigeo
    Sub SaveUbigeo(ByVal _Ubigeo As Ubigeo)
    Function DeleteUbigeo(ByVal _id As String) As String
    Function GetUBIGEOByParameter(ByVal texto As String) As List(Of Ubigeo)

End Interface

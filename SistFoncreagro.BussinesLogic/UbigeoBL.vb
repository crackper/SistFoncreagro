Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class UbigeoBL : Implements IUbigeoBL
    Dim factoryrepository As IUbigeoRepository

    Public Sub New()
        factoryrepository = New UbigeoRepository
    End Sub

    Public Function DeleteUbigeo(ByVal _id As String) As String Implements IUbigeoBL.DeleteUbigeo
        Return factoryrepository.DeleteUbigeo(_id)
    End Function

    Public Function GetAllFromUbigeo() As System.Collections.Generic.List(Of BussinessEntities.Ubigeo) Implements IUbigeoBL.GetAllFromUbigeo
        Return factoryrepository.GetAllFromUbigeo
    End Function

    Public Function GetUbigeoByIdUbigeo(ByVal _IdUbigeo As String) As BussinessEntities.Ubigeo Implements IUbigeoBL.GetUbigeoByIdUbigeo
        Return factoryrepository.GetUbigeoByIdUbigeo(_IdUbigeo)
    End Function

    Public Sub SaveUbigeo(ByVal _Ubigeo As BussinessEntities.Ubigeo) Implements IUbigeoBL.SaveUbigeo
        factoryrepository.SaveUbigeo(_Ubigeo)
    End Sub

    Public Function GetUBIGEOByParameter(ByVal texto As String) As System.Collections.Generic.List(Of BussinessEntities.Ubigeo) Implements IUbigeoBL.GetUBIGEOByParameter
        Return factoryrepository.GetUBIGEOByParameter(texto)
    End Function
End Class

Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class UbigeoDatosBL : Implements IUbigeoDatosBL
    Dim factoryrepository As IUbigeoDatosRepository

    Public Sub New()
        factoryrepository = New UbigeoDatosRepository
    End Sub

    Public Function GetAllFromUbigeoDatos() As System.Collections.Generic.List(Of BussinessEntities.UbigeoDatos) Implements IUbigeoDatosBL.GetAllFromUbigeoDatos
        Return factoryrepository.GetAllFromUbigeoDatos
    End Function

    Public Function GetUbigeoDatosByIdUbigeoDatos(ByVal _IdUbigeoDatos As String) As BussinessEntities.UbigeoDatos Implements IUbigeoDatosBL.GetUbigeoDatosByIdUbigeoDatos
        Return factoryrepository.GetUbigeoDatosByIdUbigeoDatos(_IdUbigeoDatos)
    End Function

    Public Function GetUbigeoDatosByNivel(ByVal _Nivel As String) As System.Collections.Generic.List(Of BussinessEntities.UbigeoDatos) Implements IUbigeoDatosBL.GetUbigeoDatosByNivel
        Return factoryrepository.GetUbigeoDatosByNivel(_Nivel)
    End Function

    Public Function GetUBIGEODATOSByParameter(ByVal texto As String) As System.Collections.Generic.List(Of BussinessEntities.UbigeoDatos) Implements IUbigeoDatosBL.GetUBIGEODATOSByParameter
        Return factoryrepository.GetUBIGEODATOSByParameter(texto)
    End Function
End Class

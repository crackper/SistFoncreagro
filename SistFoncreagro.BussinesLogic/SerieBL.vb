Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class SerieBL : Implements ISerieBL
    Dim factoryrepository As ISerieRepository

    Public Sub New()
        factoryrepository = New SerieRepository
    End Sub

    Public Function GetAllFromSERIE() As System.Collections.Generic.List(Of BussinessEntities.Serie) Implements ISerieBL.GetAllFromSERIE
        Return factoryrepository.GetAllFromSERIE()
    End Function

    Public Sub SaveSERIE(ByVal _Serie As BussinessEntities.Serie) Implements ISerieBL.SaveSERIE
        factoryrepository.SaveSERIE(_Serie)
    End Sub

    Public Sub UpdateEstadoSERIE(ByVal IdSerie As Integer) Implements ISerieBL.UpdateEstadoSERIE
        factoryrepository.UpdateEstadoSERIE(IdSerie)
    End Sub
End Class

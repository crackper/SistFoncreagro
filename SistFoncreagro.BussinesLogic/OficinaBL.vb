Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class OficinaBL : Implements IOficinaBL
    Dim factoryrepository As IOficinaRepository

    Public Sub New()
        factoryrepository = New OficinaRepository
    End Sub

    Public Function GetAllFromOFICINA() As System.Collections.Generic.List(Of BussinessEntities.Oficina) Implements IOficinaBL.GetAllFromOFICINA
        Return factoryrepository.GetAllFromOFICINA
    End Function

    Public Function GetOFICINAByIdOficina(ByVal IdOficina As Integer) As BussinessEntities.Oficina Implements IOficinaBL.GetOFICINAByIdOficina
        Return factoryrepository.GetOFICINAByIdOficina(IdOficina)
    End Function

    Public Sub SaveOFICINA(ByVal _Oficina As BussinessEntities.Oficina) Implements IOficinaBL.SaveOFICINA
        factoryrepository.SaveOFICINA(_Oficina)
    End Sub

    Public Sub UpdateEstadoOFICINA(ByVal IdOficina As Integer) Implements IOficinaBL.UpdateEstadoOFICINA
        factoryrepository.UpdateEstadoOFICINA(IdOficina)
    End Sub

    Public Function GetOFICINAByIdLocal(ByVal IdLocal As Integer) As System.Collections.Generic.List(Of BussinessEntities.Oficina) Implements IOficinaBL.GetOFICINAByIdLocal
        Return factoryrepository.GetOFICINAByIdLocal(IdLocal)
    End Function

    Public Sub DeleteOFICINA(ByVal IdOficina As Integer) Implements IOficinaBL.DeleteOFICINA
        factoryrepository.DeleteOFICINA(IdOficina)
    End Sub
End Class

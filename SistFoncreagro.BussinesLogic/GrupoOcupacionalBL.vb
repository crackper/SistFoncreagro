Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class GrupoOcupacionalBL : Implements IGrupoOcupacionalBL
    Dim factoryrepository As IGrupoOcupacionalRepository

    Public Sub New()
        factoryrepository = New GrupoOcupacionalRepository
    End Sub

    Public Function GetAllFromGrupoOcupacional() As System.Collections.Generic.List(Of BussinessEntities.GrupoOcupacional) Implements IGrupoOcupacionalBL.GetAllFromGrupoOcupacional
        Return factoryrepository.GetAllFromGrupoOcupacional
    End Function

    Public Function GetGrupoOcupacionalByDisponible() As System.Collections.Generic.List(Of BussinessEntities.GrupoOcupacional) Implements IGrupoOcupacionalBL.GetGrupoOcupacionalByDisponible
        Return factoryrepository.GetGrupoOcupacionalByDisponible
    End Function
End Class

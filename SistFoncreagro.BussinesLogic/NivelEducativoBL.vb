Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class NivelEducativoBL : Implements INivelEducativoBL
    Dim factoryRepository As INivelEducativoRepository
    Sub New()
        factoryRepository = New NivelEducativoRepository
    End Sub

    Public Sub DeleNivelEducativo(ByVal idNivelEducativo As Integer) Implements INivelEducativoBL.DeleNivelEducativo
        Me.factoryRepository.DeleNivelEducativo(idNivelEducativo)
    End Sub

    Public Function GetAllFromNivelEducativo() As System.Collections.Generic.List(Of BussinessEntities.NivelEducativo) Implements INivelEducativoBL.GetAllFromNivelEducativo
        Return Me.factoryRepository.GetAllFromNivelEducativo
    End Function

    Public Function GetNivelEducativoByIdNivelEducativo(ByVal idNivelEducativo As Integer) As BussinessEntities.NivelEducativo Implements INivelEducativoBL.GetNivelEducativoByIdNivelEducativo
        Return Me.factoryRepository.GetNivelEducativoByIdNivelEducativo(idNivelEducativo)
    End Function

    Public Sub SaveNivelEducativo(ByVal nivelEducativo As BussinessEntities.NivelEducativo) Implements INivelEducativoBL.SaveNivelEducativo
        Me.factoryRepository.SaveNivelEducativo(nivelEducativo)
    End Sub
End Class

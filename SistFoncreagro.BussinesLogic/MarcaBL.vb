Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class MarcaBL : Implements IMarcaBL
    Dim factoryRepository As IMarcaRepository
    Sub New()
        factoryRepository = New MarcaRepository
    End Sub
    Public Function GetAllFromByIdMarca(ByVal idMarca As Integer) As BussinessEntities.Marca Implements IMarcaBL.GetAllFromByIdMarca
        Return factoryRepository.GetAllFromByIdMarca(idMarca)
    End Function
    Public Function GetAllFromMarca() As System.Collections.Generic.List(Of BussinessEntities.Marca) Implements IMarcaBL.GetAllFromMarca
        Return factoryRepository.GetAllFromMarca
    End Function
    Public Sub SaveMarca(ByVal marca As BussinessEntities.Marca) Implements IMarcaBL.SaveMarca
        factoryRepository.SaveMarca(marca)
    End Sub
    Public Sub DeleteMarca(ByVal IdMarca As Integer) Implements IMarcaBL.DeleteMarca
        factoryRepository.DeleteMarca(IdMarca)
    End Sub
End Class

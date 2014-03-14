Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class CategoriaRrhhBL : Implements ICategoriaRrhhBL
    Dim factoryRepository As ICategoriaRrhhRepository
    Sub New()
        factoryRepository = New CategoriaRrhhRepository
    End Sub

    Public Function GetAllFromCategoriaRrhh() As System.Collections.Generic.List(Of BussinessEntities.CategoriaRrhh) Implements ICategoriaRrhhBL.GetAllFromCategoriaRrhh
        Return Me.factoryRepository.GetAllFromCategoriaRrhh
    End Function

    Public Function GetCategoriaRrhhByIdCategoria(ByVal idCategoria As Integer) As BussinessEntities.CategoriaRrhh Implements ICategoriaRrhhBL.GetCategoriaRrhhByIdCategoria
        Return Me.factoryRepository.GetCategoriaRrhhByIdCategoria(idCategoria)
    End Function
End Class

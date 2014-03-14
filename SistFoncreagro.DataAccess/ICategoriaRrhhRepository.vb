Imports SistFoncreagro.BussinessEntities
Public Interface ICategoriaRrhhRepository
    Function GetAllFromCategoriaRrhh() As List(Of CategoriaRrhh)
    Function GetCategoriaRrhhByIdCategoria(ByVal idCategoria As Int32) As CategoriaRrhh
    Sub SaveCategoriaRrhh(ByVal categoriaRrhh As CategoriaRrhh)
    Sub DeleteCategoriaRrhh(ByVal idCategoria As Int32)

End Interface

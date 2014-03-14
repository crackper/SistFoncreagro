Imports SistFoncreagro.BussinessEntities

Public Interface ICatalogoBL
    Function GetAllFromCatalogoByTipo(ByVal tipo As Int32) As List(Of Catalogo)
    Function GetAllFromCatalogoByIdCatalogo(ByVal idCatalogo As Integer) As Catalogo
    Function GetAllFromCatalogoByParametro(ByVal tipo As Int32, ByVal parametro As String) As List(Of Catalogo)
    Function GelAllFromProductosByParametro(ByVal Texto As String) As List(Of Catalogo)
    Function GetAllFromCatalogoOfDetalleRequerimientoByParametro(ByVal idRequerimiento As Int32, ByVal parametro As String) As List(Of Catalogo)
    Function GetAllFromCatalogoFullByParametro(ByVal parametro As String) As List(Of Catalogo)
    Sub SaveCatalogo(ByVal catalogo As Catalogo)
    Sub UpdateCatalogo(ByVal catalogo As Catalogo)
    Sub DeleteCatalogo(ByVal idCatalogo As Integer)
End Interface

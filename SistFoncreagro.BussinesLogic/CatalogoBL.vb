Imports SistFoncreagro.DataAccess
Imports SistFoncreagro.BussinessEntities

Public Class CatalogoBL : Implements ICatalogoBL
    Dim factoryRepository As ICatalogoRepository
    Sub New()
        factoryRepository = New CatalogoRepository
    End Sub
    Public Sub DeleteCatalogo(ByVal idCatalogo As Integer) Implements ICatalogoBL.DeleteCatalogo
        factoryRepository.DeleteCatalogo(idCatalogo)
    End Sub

    Public Function GetAllFromCatalogoByIdCatalogo(ByVal idCatalogo As Integer) As BussinessEntities.Catalogo Implements ICatalogoBL.GetAllFromCatalogoByIdCatalogo
        Return factoryRepository.GetAllFromCatalogoByIdCatalogo(idCatalogo)
    End Function

    Public Function GetAllFromCatalogoByTipo(ByVal tipo As Integer) As System.Collections.Generic.List(Of BussinessEntities.Catalogo) Implements ICatalogoBL.GetAllFromCatalogoByTipo
        Return factoryRepository.GetAllFromCatalogoByTipo(tipo)
    End Function
    Public Function GetAllFromCatalogoByParametro(ByVal tipo As Integer, ByVal parametro As String) As System.Collections.Generic.List(Of BussinessEntities.Catalogo) Implements ICatalogoBL.GetAllFromCatalogoByParametro
        Return factoryRepository.GetAllFromCatalogoByParametro(tipo, parametro)
    End Function

    Public Function GelAllFromProductosByParametro(ByVal Texto As String) As System.Collections.Generic.List(Of BussinessEntities.Catalogo) Implements ICatalogoBL.GelAllFromProductosByParametro
        Return factoryRepository.GelAllFromProductosByParametro(Texto)
    End Function

    Public Function GetAllFromCatalogoOfDetalleRequerimientoByParametro(ByVal idRequerimiento As Integer, ByVal parametro As String) As System.Collections.Generic.List(Of BussinessEntities.Catalogo) Implements ICatalogoBL.GetAllFromCatalogoOfDetalleRequerimientoByParametro
        Return factoryRepository.GetAllFromCatalogoOfDetalleRequerimientoByParametro(idRequerimiento, parametro)
    End Function
    Public Sub SaveCatalogo(ByVal catalogo As BussinessEntities.Catalogo) Implements ICatalogoBL.SaveCatalogo
        factoryRepository.SaveCatalogo(catalogo)
    End Sub
    Public Sub UpdateCatalogo(ByVal catalogo As BussinessEntities.Catalogo) Implements ICatalogoBL.UpdateCatalogo
        factoryRepository.UpdateCatalogo(catalogo)
    End Sub
    Public Function GetAllFromCatalogoFullByParametro(ByVal parametro As String) As System.Collections.Generic.List(Of BussinessEntities.Catalogo) Implements ICatalogoBL.GetAllFromCatalogoFullByParametro
        Return factoryRepository.GetAllFromCatalogoFullByParametro(parametro)
    End Function
End Class

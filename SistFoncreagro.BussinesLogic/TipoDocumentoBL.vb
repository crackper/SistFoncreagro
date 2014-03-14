Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoDocumentoBL : Implements ITipoDocumentoBL
    Dim factoryrepository As ITipoDocumentoRepository

    Public Sub New()
        factoryrepository = New TipoDocumentoRepository
    End Sub

    Public Sub DeleteTIPODOCUMENTO(ByVal IdTipoDocumento As Integer) Implements ITipoDocumentoBL.DeleteTIPODOCUMENTO
        factoryrepository.DeleteTIPODOCUMENTO(IdTipoDocumento)
    End Sub

    Public Function GetAllFromTIPODOCUMENTO() As System.Collections.Generic.List(Of BussinessEntities.TipoDocumento) Implements ITipoDocumentoBL.GetAllFromTIPODOCUMENTO
        Return factoryrepository.GetAllFromTIPODOCUMENTO()
    End Function

    Public Function GetTIPODOCUMENTOByIdTipoDocumento(ByVal IdTipoDocumento As Integer) As BussinessEntities.TipoDocumento Implements ITipoDocumentoBL.GetTIPODOCUMENTOByIdTipoDocumento
        Return factoryrepository.GetTIPODOCUMENTOByIdTipoDocumento(IdTipoDocumento)
    End Function

    Public Sub SaveTIPODOCUMENTO(ByVal _TipoDocumento As BussinessEntities.TipoDocumento) Implements ITipoDocumentoBL.SaveTIPODOCUMENTO
        factoryrepository.SaveTIPODOCUMENTO(_TipoDocumento)
    End Sub

    Public Sub UpdateEstadoTIPODOCUMENTO(ByVal IdTipoDocumento As Integer) Implements ITipoDocumentoBL.UpdateEstadoTIPODOCUMENTO
        factoryrepository.UpdateEstadoTIPODOCUMENTO(IdTipoDocumento)
    End Sub
End Class

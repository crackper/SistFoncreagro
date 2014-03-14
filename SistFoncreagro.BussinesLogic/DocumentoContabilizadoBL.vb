Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class DocumentoContabilizadoBL : Implements IDocumentoContabilizadoBL

    Dim factoryrepository As IDocumentoContabilizadoRepository

    Public Sub New()
        factoryrepository = New DocumentoContabilizadoRepository
    End Sub

    Public Sub DeleteDOCUMENTOCONTABILIZADO(ByVal IdDocConta As Integer) Implements IDocumentoContabilizadoBL.DeleteDOCUMENTOCONTABILIZADO
        factoryrepository.DeleteDOCUMENTOCONTABILIZADO(IdDocConta)
    End Sub

    Public Function GetAllFromDOCUMENTOCONTABILIZADO() As System.Collections.Generic.List(Of BussinessEntities.DocumentoContabilizado) Implements IDocumentoContabilizadoBL.GetAllFromDOCUMENTOCONTABILIZADO
        Return factoryrepository.GetAllFromDOCUMENTOCONTABILIZADO()
    End Function

    Public Function GetDOCUMENTOCONTABILIZADOByIdDocConta(ByVal IdDocConta As Integer) As BussinessEntities.DocumentoContabilizado Implements IDocumentoContabilizadoBL.GetDOCUMENTOCONTABILIZADOByIdDocConta
        Return factoryrepository.GetDOCUMENTOCONTABILIZADOByIdDocConta(IdDocConta)
    End Function

    Public Sub UpdateEstadoDOCUMENTOCONTABILIZADO(ByVal IdDocumentoCont As Integer) Implements IDocumentoContabilizadoBL.UpdateEstadoDOCUMENTOCONTABILIZADO
        factoryrepository.UpdateEstadoDOCUMENTOCONTABILIZADO(IdDocumentoCont)
    End Sub

    Public Function SaveDOCUMENTOCONTABILIZADO(ByVal _Documentocontabilizado As BussinessEntities.DocumentoContabilizado) As Integer Implements IDocumentoContabilizadoBL.SaveDOCUMENTOCONTABILIZADO
        Return factoryrepository.SaveDOCUMENTOCONTABILIZADO(_Documentocontabilizado)
    End Function
End Class

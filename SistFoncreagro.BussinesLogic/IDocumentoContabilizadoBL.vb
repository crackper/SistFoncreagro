Imports SistFoncreagro.BussinessEntities
Public Interface IDocumentoContabilizadoBL
    Function GetAllFromDOCUMENTOCONTABILIZADO() As List(Of DocumentoContabilizado)
    Function GetDOCUMENTOCONTABILIZADOByIdDocConta(ByVal IdDocConta As Int32) As DocumentoContabilizado
    Function SaveDOCUMENTOCONTABILIZADO(ByVal _Documentocontabilizado As DocumentoContabilizado) As Int32
    Sub DeleteDOCUMENTOCONTABILIZADO(ByVal IdDocConta As Int32)
    Sub UpdateEstadoDOCUMENTOCONTABILIZADO(ByVal IdDocumentoCont As Int32)
End Interface

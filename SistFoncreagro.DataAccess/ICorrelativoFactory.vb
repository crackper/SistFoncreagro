Imports SistFoncreagro.BussinessEntities
Public Interface ICorrelativoFactory
    Function GetCorrelativoByDocumentoByAnio(ByVal Documento As String, ByVal Anio As String) As Correlativo
    Function SaveCorrelativo(ByVal Correlativo As Correlativo) As Int32
    Sub UpdateCorrelativoNroCorrelativo(ByVal IdCorrelativo As Int32, ByVal NroCorrelativo As Int32)
End Interface

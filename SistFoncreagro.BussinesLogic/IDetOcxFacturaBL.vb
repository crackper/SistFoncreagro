Imports SistFoncreagro.BussinessEntities
Public Interface IDetOcxFacturaBL
    Sub SaveDetOcxFactura(ByVal detOcxFact As DetOcxFactura)
    Sub SaveDetOcxFactura1(ByVal detOcxFact As List(Of DetOcxFactura))
    Sub SaveDetOcxFacturaPrec(ByVal detOcxFact As DetOcxFactura)
    Sub SaveDetOcxFacturaPrec1(ByVal detOcxFact As List(Of DetOcxFactura))
    Sub DeleteDetOcxFactura(ByVal IdDetOc As Int32)
    Sub FinalizarRegistroDetOcxFactura(ByVal idOcFact As Int32)
    Function GetAllFromDetOcxFacturaById(ByVal idOcFact) As List(Of DetOcxFactura)
End Interface

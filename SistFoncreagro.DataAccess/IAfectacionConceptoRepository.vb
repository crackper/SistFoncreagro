Imports SistFoncreagro.BussinessEntities
Public Interface IAfectacionConceptoRepository
    Function GetAllFromAFECTACIONCONCEPTO() As List(Of AfectacionConcepto)
    Function SaveAFECTACIONCONCEPTO(ByVal afectacionConcepto As AfectacionConcepto) As Int32
    Sub DeleteAFECTACIONCONCEPTO(ByVal IdAfectacion As Int32)
End Interface

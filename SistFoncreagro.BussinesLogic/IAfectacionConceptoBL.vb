Imports SistFoncreagro.BussinessEntities
Public Interface IAfectacionConceptoBL
    Function GetAllFromAFECTACIONCONCEPTO() As List(Of AfectacionConcepto)
    Function SaveAFECTACIONCONCEPTO(ByVal afectacionConcepto As AfectacionConcepto) As Int32
    Sub DeleteAFECTACIONCONCEPTO(ByVal IdAfectacion As Int32)

    Sub SaveAndDeleteListaAfectacionConcepto(ByVal listaCrear As System.Collections.Generic.List(Of AfectacionConcepto), ByVal listaEliminar As System.Collections.Generic.List(Of Integer))
End Interface

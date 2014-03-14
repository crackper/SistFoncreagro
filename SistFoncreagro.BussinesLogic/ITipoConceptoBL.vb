Imports SistFoncreagro.BussinessEntities
Public Interface ITipoConceptoBL
    Function GetAllFromTIPOCONCEPTO() As List(Of TipoConcepto)
    Function GetTIPOCONCEPTOByIdTipoConcepto(ByVal IdTipoConcepto As Int32) As TipoConcepto
End Interface

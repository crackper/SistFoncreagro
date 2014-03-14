Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Interface IConceptoPlanillaBL
    Function GetAllFromConceptoPlanilla() As List(Of ConceptoPlanilla)
    Function GetConceptoPlanillaByIdConceptoPlanilla(ByVal IdConceptoPlanillas As Int32) As ConceptoPlanilla
    Function GetConceptoPlanillaByIdTipoConcepto(ByVal IdTipoConcepto As Int32) As List(Of ConceptoPlanilla)
    Function SaveConceptoPlanilla(ByVal conceptoPlanilla As ConceptoPlanilla) As Int32
    Sub DeleteCONCEPTOPLANILLA(ByVal IdConceptoPlanilla As Int32)

End Interface

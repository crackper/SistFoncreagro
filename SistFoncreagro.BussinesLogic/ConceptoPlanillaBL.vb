Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ConceptoPlanillaBL : Implements IConceptoPlanillaBL
    Dim factoryrepository As IConceptoPlanillaRepository

    Public Sub New()
        factoryrepository = New ConceptoPlanillaRepository
    End Sub

    Public Function GetAllFromConceptoPlanilla() As System.Collections.Generic.List(Of BussinessEntities.ConceptoPlanilla) Implements IConceptoPlanillaBL.GetAllFromConceptoPlanilla
        Return factoryrepository.GetAllFromConceptoPlanilla()
    End Function

    Public Function GetConceptoPlanillaByIdConceptoPlanilla(ByVal IdConceptoPlanillas As Integer) As BussinessEntities.ConceptoPlanilla Implements IConceptoPlanillaBL.GetConceptoPlanillaByIdConceptoPlanilla
        Return factoryrepository.GetConceptoPlanillaByIdConceptoPlanilla(IdConceptoPlanillas)
    End Function

    Public Function GetConceptoPlanillaByIdTipoConcepto(ByVal IdTipoConcepto As Integer) As System.Collections.Generic.List(Of BussinessEntities.ConceptoPlanilla) Implements IConceptoPlanillaBL.GetConceptoPlanillaByIdTipoConcepto
        Return factoryrepository.GetConceptoPlanillaByIdTipoConcepto(IdTipoConcepto)
    End Function

    Public Function SaveConceptoPlanilla(ByVal conceptoPlanilla As BussinessEntities.ConceptoPlanilla) As Integer Implements IConceptoPlanillaBL.SaveConceptoPlanilla
        Return factoryrepository.SaveConceptoPlanilla(conceptoPlanilla)
    End Function

    Public Sub DeleteCONCEPTOPLANILLA(ByVal IdConceptoPlanilla As Integer) Implements IConceptoPlanillaBL.DeleteCONCEPTOPLANILLA
        factoryrepository.DeleteCONCEPTOPLANILLA(IdConceptoPlanilla)
    End Sub
End Class

Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoConceptoBL : Implements ITipoConceptoBL
    Dim factoryrepository As ITipoConceptoRepository

    Public Sub New()
        factoryrepository = New TipoConceptoRepository
    End Sub

    Public Function GetAllFromTIPOCONCEPTO() As System.Collections.Generic.List(Of BussinessEntities.TipoConcepto) Implements ITipoConceptoBL.GetAllFromTIPOCONCEPTO
        Return factoryrepository.GetAllFromTIPOCONCEPTO()
    End Function

    Public Function GetTIPOCONCEPTOByIdTipoConcepto(ByVal IdTipoConcepto As Integer) As BussinessEntities.TipoConcepto Implements ITipoConceptoBL.GetTIPOCONCEPTOByIdTipoConcepto
        Return factoryrepository.GetTIPOCONCEPTOByIdTipoConcepto(IdTipoConcepto)
    End Function
End Class

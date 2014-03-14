Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class AfectacionConceptoBL : Implements IAfectacionConceptoBL
    Dim factoryrepository As IAfectacionConceptoRepository

    Public Sub New()
        factoryrepository = New AfectacionConceptoRepository
    End Sub
    Public Sub DeleteAFECTACIONCONCEPTO(ByVal IdAfectacion As Integer) Implements IAfectacionConceptoBL.DeleteAFECTACIONCONCEPTO
        factoryrepository.DeleteAFECTACIONCONCEPTO(IdAfectacion)
    End Sub

    Public Function GetAllFromAFECTACIONCONCEPTO() As System.Collections.Generic.List(Of BussinessEntities.AfectacionConcepto) Implements IAfectacionConceptoBL.GetAllFromAFECTACIONCONCEPTO
        Return factoryrepository.GetAllFromAFECTACIONCONCEPTO
    End Function

    Public Function SaveAFECTACIONCONCEPTO(ByVal afectacionConcepto As BussinessEntities.AfectacionConcepto) As Integer Implements IAfectacionConceptoBL.SaveAFECTACIONCONCEPTO
        Return factoryrepository.SaveAFECTACIONCONCEPTO(afectacionConcepto)
    End Function

    Public Sub SaveAndDeleteListaAfectacionConcepto(ByVal listaCrear As System.Collections.Generic.List(Of BussinessEntities.AfectacionConcepto), ByVal listaEliminar As System.Collections.Generic.List(Of Integer)) Implements IAfectacionConceptoBL.SaveAndDeleteListaAfectacionConcepto
        If listaEliminar.Count > 0 Then
            For i = 0 To listaEliminar.Count - 1
                DeleteAFECTACIONCONCEPTO(listaEliminar(i))
            Next
        End If

        If listaCrear.Count > 0 Then
            For i = 0 To listaCrear.Count - 1
                SaveAFECTACIONCONCEPTO(listaCrear(i))
            Next
        End If
    End Sub
End Class

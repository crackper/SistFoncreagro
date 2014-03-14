Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class DetalleConceptoBL : Implements IDetalleConceptoBL

    Dim factoryrepository As IDetalleConceptoRepository

    Public Sub New()
        factoryrepository = New DetalleConceptoRepository
    End Sub

    Public Sub DeleteDetalleConcepto(ByVal IdDetalleConcepto As Int32) Implements IDetalleConceptoBL.DeleteDetalleConcepto
        factoryrepository.DeleteDetalleConcepto(IdDetalleConcepto)
    End Sub

    Public Function GetDetalleConceptoAportes() As System.Collections.Generic.List(Of BussinessEntities.DetalleConcepto) Implements IDetalleConceptoBL.GetDetalleConceptoAportes
        Return factoryrepository.GetDetalleConceptoAportes()
    End Function

    Public Function GetDetalleConceptoByIdConceptoPlanilla(ByVal IdConceptoPlanilla As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleConcepto) Implements IDetalleConceptoBL.GetDetalleConceptoByIdConceptoPlanilla
        Return factoryrepository.GetDetalleConceptoByIdConceptoPlanilla(IdConceptoPlanilla)
    End Function

    Public Function GetDetalleConceptoByIdDetalleConcepto(ByVal IdDetalleConcepto As Integer) As BussinessEntities.DetalleConcepto Implements IDetalleConceptoBL.GetDetalleConceptoByIdDetalleConcepto
        Return factoryrepository.GetDetalleConceptoByIdDetalleConcepto(IdDetalleConcepto)
    End Function

    Public Function GetDetalleConceptoByIdTipoConcepto(ByVal IdTipoConcepto As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleConcepto) Implements IDetalleConceptoBL.GetDetalleConceptoByIdTipoConcepto
        Return factoryrepository.GetDetalleConceptoByIdTipoConcepto(IdTipoConcepto)
    End Function

    Public Function GetDetalleConceptoByCodTipoConcepto(ByVal Cod As String) As BussinessEntities.DetalleConcepto Implements IDetalleConceptoBL.GetDetalleConceptoByCodTipoConcepto
        Return factoryrepository.GetDetalleConceptoByCodTipoConcepto(Cod)
    End Function
    Public Function SaveDetalleConcepto(ByVal detalleConcepto As BussinessEntities.DetalleConcepto) As Integer Implements IDetalleConceptoBL.SaveDetalleConcepto
        Return factoryrepository.SaveDetalleConcepto(detalleConcepto)
    End Function

    Public Function GetDetalleConceptoQueSonAportes() As System.Collections.Generic.List(Of BussinessEntities.DetalleConcepto) Implements IDetalleConceptoBL.GetDetalleConceptoQueSonAportes
        Return factoryrepository.GetDetalleConceptoQueSonAportes
    End Function

    Public Function GetDetalleConceptoQueSonIngresos() As System.Collections.Generic.List(Of BussinessEntities.DetalleConcepto) Implements IDetalleConceptoBL.GetDetalleConceptoQueSonIngresos
        Return factoryrepository.GetDetalleConceptoQueSonIngresos
    End Function

End Class

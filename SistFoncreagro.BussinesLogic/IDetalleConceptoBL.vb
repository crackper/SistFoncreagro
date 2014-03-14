Imports SistFoncreagro.BussinessEntities
Public Interface IDetalleConceptoBL
    Function GetDetalleConceptoByIdDetalleConcepto(ByVal IdDetalleConcepto As Int32) As DetalleConcepto
    Function GetDetalleConceptoByIdConceptoPlanilla(ByVal IdConceptoPlanilla As Int32) As List(Of DetalleConcepto)
    Function GetDetalleConceptoByIdTipoConcepto(ByVal IdTipoConcepto As Int32) As List(Of DetalleConcepto)
    Function GetDetalleConceptoAportes() As List(Of DetalleConcepto)
    Function SaveDetalleConcepto(ByVal detalleConcepto As DetalleConcepto) As Int32
    Function GetDetalleConceptoByCodTipoConcepto(ByVal Cod As String) As DetalleConcepto
    Function GetDetalleConceptoQueSonIngresos() As List(Of DetalleConcepto)
    Function GetDetalleConceptoQueSonAportes() As List(Of DetalleConcepto)
    Sub DeleteDetalleConcepto(ByVal IdDetalleConcepto As Int32)
End Interface

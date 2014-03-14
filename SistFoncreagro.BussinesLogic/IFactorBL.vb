Imports SistFoncreagro.BussinessEntities
Public Interface IFactorBL
    Function GetFactorByIdDetalleConcepto(ByVal IdDetalleConcepto As Int32) As List(Of Factor)
    Function GetFactorVigente(ByVal IdDetalleConcepto As Int32) As Factor
    Function GetFactorByMaxFecha(ByVal IdDetalleConcepto As Int32) As Factor
    Function SaveFACTOR(ByVal factor As Factor) As Int32
    Sub DeleteFactor(ByVal IdFactor As Int32)

    Function SaveFactorUpdateVigente(ByVal factor As Factor) As Int32
End Interface

Imports SistFoncreagro.BussinessEntities
Public Interface IFactorRepository
    Function GetFactorByIdDetalleConcepto(ByVal IdDetalleConcepto As Int32) As List(Of Factor)
    Function GetFactorVigente(ByVal IdDetalleConcepto As Int32) As Factor
    Function GetFactorByMaxFecha(ByVal IdDetalleConcepto As Int32) As Factor
    Function SaveFACTOR(ByVal factor As Factor) As Int32
    Sub DeleteFactor(ByVal IdFactor As Int32)

End Interface

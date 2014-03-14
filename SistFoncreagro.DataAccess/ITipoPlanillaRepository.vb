Imports SistFoncreagro.BussinessEntities
Public Interface ITipoPlanillaRepository
    Function GetAllFromTIPOPLANILLA() As List(Of TipoPlanilla)
    Function GetTIPOPLANILLAByIdTipoPlanilla(ByVal IdTipoPlanilla As Int32) As TipoPlanilla
    Function SaveTIPOPLANILLA(ByVal tipoPlanilla As TipoPlanilla) As Int32
    Sub DeleteTIPOPLANILLA(ByVal IdTipoPlanilla As Int32)

End Interface

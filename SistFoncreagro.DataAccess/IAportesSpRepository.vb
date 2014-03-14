Imports SistFoncreagro.BussinessEntities
Public Interface IAportesSpRepository
    Sub SaveAportesSp(ByVal aportes As AporteSp)
    Function GetAllFromAportesSp() As List(Of AporteSp)
    Function GetAllFromAporteAnterior(ByVal idSistema As Int32, ByVal idPerido As Int32)
    Function GetAllFromAporteGuardado(ByVal idSistema As Int32, ByVal idPerido As Int32)

End Interface

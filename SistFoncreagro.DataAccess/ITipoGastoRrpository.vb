Imports SistFoncreagro.BussinessEntities
Public Interface ITipoGastoRrpository
    Function GetAllFromTIPOGASTO() As List(Of TipoGasto)
    Function GetTIPOGASTOByIdTipoGasto(ByVal IdTipoGasto As Int32) As TipoGasto
    Sub SaveTIPOGASTO(ByVal _TipoGasto As TipoGasto)
End Interface

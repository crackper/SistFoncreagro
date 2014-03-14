Imports SistFoncreagro.BussinessEntities
Public Interface ITipoSpRepository
    Sub SaveTipoSp(ByVal tipoSp As TipoSp)
    Function GetAllFromTipoSp() As List(Of TipoSp)
End Interface

Imports SistFoncreagro.BussinessEntities

Public Interface ITipoSpBL
    Sub SaveTipoSp(ByVal tipoSp As TipoSp)
    Function GetAllFromTipoSp() As List(Of TipoSp)

End Interface

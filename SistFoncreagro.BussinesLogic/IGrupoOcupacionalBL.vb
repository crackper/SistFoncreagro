Imports SistFoncreagro.BussinessEntities
Public Interface IGrupoOcupacionalBL
    Function GetAllFromGrupoOcupacional() As List(Of GrupoOcupacional)
    Function GetGrupoOcupacionalByDisponible() As List(Of GrupoOcupacional)
End Interface

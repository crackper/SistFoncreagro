Imports SistFoncreagro.BussinessEntities
Public Interface IGrupoOcupacionalRepository
    Function GetAllFromGrupoOcupacional() As List(Of GrupoOcupacional)
    Function GetGrupoOcupacionalByDisponible() As List(Of GrupoOcupacional)
    Function GetGrupoOcupacionalByIdGrupoOcupacional(ByVal IdGrupoOcupacinal As Int32) As GrupoOcupacional
End Interface

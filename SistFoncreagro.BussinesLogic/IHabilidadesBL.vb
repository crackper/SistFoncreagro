Imports SistFoncreagro.BussinessEntities
Public Interface IHabilidadesBL
    Function GetAllFromHABILIDADES() As List(Of Habilidades)
    Function SaveHABILIDADES(ByVal habilidades As Habilidades) As Int32
    Function GetHABILIDAESByIdHabilidadAndIdPosicion(ByVal IdHabilidad As Int32, ByVal IdPosicion As Int32) As Habilidades
    Function GetHABILIDAESByIdPosicion(ByVal IdPosicion As Int32) As List(Of Habilidades)
    Sub DeleteHabilidades(ByVal idHabilidad As Int32)
End Interface

Imports SistFoncreagro.BussinessEntities
Public Interface IPosicionRepository
    Function GetAllFromPosicion(ByVal argPosicion As ArgumentosPosicion) As List(Of Posicion)
    Function GetPosicionByIdPosicion(ByVal IdPosicion As Int32, ByVal argPosicion As ArgumentosPosicion) As Posicion
    Function GetPosicionByIdArea(ByVal IdArea As Int32, ByVal argPosicion As ArgumentosPosicion) As List(Of Posicion)
    Function SavePosicion(ByVal posicion As Posicion) As Int32
    Function GetJefaturaByIdArea(ByVal idArea As Int32, ByVal argPosicion As ArgumentosPosicion) As Posicion
    Function GetListaPosicionesDeUnaAreaySubAreasByIdArea(ByVal IdArea As Int32) As IList(Of Posicion)
    Function GetPosicionesByIdCCostoAndFecha(ByVal IdCCosto As Int32, ByVal fecha As DateTime) As List(Of Posicion)
    Function GetPosicionesByIdProyectoAndFecha(ByVal IdProyecto As Int32, ByVal fecha As DateTime) As List(Of Posicion)
    Sub DeletePosicion(ByVal IdPosicion As Int32)
End Interface

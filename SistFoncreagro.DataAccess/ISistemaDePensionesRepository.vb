Imports SistFoncreagro.BussinessEntities

Public Interface ISistemaDePensionesRepository
    Sub SaveSistemaPensiones(ByVal sistemaPension As SistemaDePensiones)
    Function GetAllFromSistemaPensiones() As List(Of SistemaDePensiones)
    Function GetAllFromSistemaPensionesByTipoSp(ByVal idTipoSp As Int32) As List(Of SistemaDePensiones)
    Function GetFromSistemaPensionesByIdSistemaPensiones(ByVal idSistemaPensiones As Int32) As SistemaDePensiones
    Function GetSistemaDePensionesByIdSistemaPensiones(ByVal IdSistemaPensiones As Int32)

End Interface

Imports SistFoncreagro.BussinessEntities
Public Interface IAfiliacionSPRepository
    Function GetAllFromAFILIACIONSP() As List(Of AfiliacionSP)
    Function GetAFILIACIONSPByIdAfiliacionSPAndIdPersonalAndIdSistemaPensiones(ByVal IdAfiliacionSP As Int32, ByVal IdPersonal As Int32, ByVal IdSistemaPensiones As Int32) As AfiliacionSP
    Function SaveAFILIACIONSP(ByVal afiliacionSP As AfiliacionSP) As Int32
    Function GetAFILIACIONSPByIdPersonal(ByVal IdPersonal As Int32) As List(Of AfiliacionSP)
    Function GetAFILIACIONSPByIdSistemaPensiones(ByVal IdSistemaPensiones As Int32) As List(Of AfiliacionSP)
    Function GetAFILIACIONSPByIdSistemaPensionesAndActivos(ByVal IdSistemaPensiones As Int32) As List(Of AfiliacionSP)
    Function GetAFILIACIONSPByIdPersonalAndActiva(ByVal IdPersonal As Int32) As AfiliacionSP
    Sub DeleteAfiliacionSP(ByVal IdAfiliacionSP As Int32, ByVal IdPersonal As Int32, ByVal IdSistemaPensiones As Int32)
    'Function GetAFILIACIONSPByIdPersonalAndEstado(ByVal IdPersonal As Int32, ByVal estado As Boolean) As List(Of AfiliacionSP)
    'Function GetAFILIACIONSPByIdSistemaPensionesAndActivosAndEstado(ByVal IdSistemaPensiones As Int32, ByVal estado As Boolean) As List(Of AfiliacionSP)

End Interface

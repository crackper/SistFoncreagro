Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class AfiliacionSPBL : Implements IAfiliacionSPBL

    Dim factoryrepository As IAfiliacionSPRepository

    Public Sub New()
        factoryrepository = New AfiliacionSPRepository
    End Sub

    Public Function GetAFILIACIONSPByIdAfiliacionSPAndIdPersonalAndIdSistemaPensiones(ByVal IdAfiliacionSP As Integer, ByVal IdPersonal As Integer, ByVal IdSistemaPensiones As Integer) As BussinessEntities.AfiliacionSP Implements IAfiliacionSPBL.GetAFILIACIONSPByIdAfiliacionSPAndIdPersonalAndIdSistemaPensiones
        Return factoryrepository.GetAFILIACIONSPByIdAfiliacionSPAndIdPersonalAndIdSistemaPensiones(IdAfiliacionSP, IdPersonal, IdSistemaPensiones)
    End Function

    Public Function GetAFILIACIONSPByIdPersonal(ByVal IdPersonal As Integer) As System.Collections.Generic.List(Of BussinessEntities.AfiliacionSP) Implements IAfiliacionSPBL.GetAFILIACIONSPByIdPersonal
        Return factoryrepository.GetAFILIACIONSPByIdPersonal(IdPersonal)
    End Function

    Public Function GetAFILIACIONSPByIdPersonalAndActiva(ByVal IdPersonal As Integer) As BussinessEntities.AfiliacionSP Implements IAfiliacionSPBL.GetAFILIACIONSPByIdPersonalAndActiva
        Return factoryrepository.GetAFILIACIONSPByIdPersonalAndActiva(IdPersonal)
    End Function

    Public Function GetAFILIACIONSPByIdSistemaPensiones(ByVal IdSistemaPensiones As Integer) As System.Collections.Generic.List(Of BussinessEntities.AfiliacionSP) Implements IAfiliacionSPBL.GetAFILIACIONSPByIdSistemaPensiones
        Return factoryrepository.GetAFILIACIONSPByIdSistemaPensiones(IdSistemaPensiones)
    End Function

    Public Function GetAFILIACIONSPByIdSistemaPensionesAndActivos(ByVal IdSistemaPensiones As Integer) As System.Collections.Generic.List(Of BussinessEntities.AfiliacionSP) Implements IAfiliacionSPBL.GetAFILIACIONSPByIdSistemaPensionesAndActivos
        Return factoryrepository.GetAFILIACIONSPByIdSistemaPensionesAndActivos(IdSistemaPensiones)
    End Function

    Public Function GetAllFromAFILIACIONSP() As System.Collections.Generic.List(Of BussinessEntities.AfiliacionSP) Implements IAfiliacionSPBL.GetAllFromAFILIACIONSP
        Return factoryrepository.GetAllFromAFILIACIONSP
    End Function

    Public Function SaveAFILIACIONSP(ByVal afiliacionSP As BussinessEntities.AfiliacionSP) As Integer Implements IAfiliacionSPBL.SaveAFILIACIONSP
        Return factoryrepository.SaveAFILIACIONSP(afiliacionSP)
    End Function

    Public Sub DeleteAfiliacionSP(ByVal IdAfiliacionSP As Integer, ByVal IdPersonal As Integer, ByVal IdSistemaPensiones As Integer) Implements IAfiliacionSPBL.DeleteAfiliacionSP
        factoryrepository.DeleteAfiliacionSP(IdAfiliacionSP, IdPersonal, IdSistemaPensiones)
    End Sub
End Class

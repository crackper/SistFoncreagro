Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class UbicacionSemovientesBL : Implements IUbicacionSemovientesBL
    Dim factoryrepository As IUbicacionSemovientesRepository

    Public Sub New()
        factoryrepository = New UbicacionSemovientesRepository
    End Sub

    Public Sub DeleteUBICACIONSEMOVIENTES(ByVal IdUbicacionSemoviente As Integer) Implements IUbicacionSemovientesBL.DeleteUBICACIONSEMOVIENTES
        factoryrepository.DeleteUBICACIONSEMOVIENTES(IdUbicacionSemoviente)
    End Sub

    Public Function GetUBICACIONSEMOVIENTESByIdUbicacionSemoviente(ByVal IdUbicacionSemoviente As Integer) As BussinessEntities.UbicacionSemovientes Implements IUbicacionSemovientesBL.GetUBICACIONSEMOVIENTESByIdUbicacionSemoviente
        Return factoryrepository.GetUBICACIONSEMOVIENTESByIdUbicacionSemoviente(IdUbicacionSemoviente)
    End Function

    Public Sub SaveUBICACIONSEMOVIENTES(ByVal _UbicacionSemovientes As BussinessEntities.UbicacionSemovientes) Implements IUbicacionSemovientesBL.SaveUBICACIONSEMOVIENTES
        factoryrepository.SaveUBICACIONSEMOVIENTES(_UbicacionSemovientes)
    End Sub
End Class

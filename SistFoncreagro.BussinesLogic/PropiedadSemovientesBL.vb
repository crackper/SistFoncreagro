Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class PropiedadSemovientesBL : Implements IPropiedadSemovientesBL
    Dim factoryrepository As IPropiedadSemovienteRepository

    Public Sub New()
        factoryrepository = New PropiedadSemovientesRepository
    End Sub

    Public Sub DeletePROPIEDADSEMOVIENTES(ByVal IdPropiedadSemoviente As Integer) Implements IPropiedadSemovientesBL.DeletePROPIEDADSEMOVIENTES
        factoryrepository.DeletePROPIEDADSEMOVIENTES(IdPropiedadSemoviente)
    End Sub

    Public Function GetPROPIEDADSEMOVIENTESByIdPropiedadSemoviente(ByVal IdPropiedadSemoviente As Integer) As BussinessEntities.PropiedadSemovientes Implements IPropiedadSemovientesBL.GetPROPIEDADSEMOVIENTESByIdPropiedadSemoviente
        Return factoryrepository.GetPROPIEDADSEMOVIENTESByIdPropiedadSemoviente(IdPropiedadSemoviente)
    End Function

    Public Sub SavePROPIEDADSEMOVIENTES(ByVal _PropiedadSemovientes As BussinessEntities.PropiedadSemovientes) Implements IPropiedadSemovientesBL.SavePROPIEDADSEMOVIENTES
        factoryrepository.SavePROPIEDADSEMOVIENTES(_PropiedadSemovientes)
    End Sub
End Class

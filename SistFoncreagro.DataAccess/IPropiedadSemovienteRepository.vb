Imports SistFoncreagro.BussinessEntities
Public Interface IPropiedadSemovienteRepository
    Function GetPROPIEDADSEMOVIENTESByIdPropiedadSemoviente(ByVal IdPropiedadSemoviente As Int32) As PropiedadSemovientes
    Sub DeletePROPIEDADSEMOVIENTES(ByVal IdPropiedadSemoviente As Int32)
    Sub SavePROPIEDADSEMOVIENTES(ByVal _PropiedadSemovientes As PropiedadSemovientes)
End Interface

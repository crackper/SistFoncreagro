Imports SistFoncreagro.BussinessEntities
Public Interface IUbicacionSemovientesBL
    Function GetUBICACIONSEMOVIENTESByIdUbicacionSemoviente(ByVal IdUbicacionSemoviente As Int32) As UbicacionSemovientes
    Sub DeleteUBICACIONSEMOVIENTES(ByVal IdUbicacionSemoviente As Int32)
    Sub SaveUBICACIONSEMOVIENTES(ByVal _UbicacionSemovientes As UbicacionSemovientes)
End Interface

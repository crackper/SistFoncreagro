Imports SistFoncreagro.BussinessEntities
Public Interface IAdjuntoSemovientesRepository
    Function GetADJUNTOSEMOVIENTESByIdAdjuntoSemoviente(ByVal IdAdjuntoSemoviente As Int32) As AdjuntoSemovientes
    Function GetADJUNTOSEMOVIENTESByIdSemoviente(ByVal IdSemoviente As Int32) As List(Of AdjuntoSemovientes)
    Sub DeleteADJUNTOSEMOVIENTES(ByVal IdAdjuntoSemoviente As Int32)
    Sub SaveADJUNTOSEMOVIENTES(ByVal _AdjuntoSemoviente As AdjuntoSemovientes)
End Interface

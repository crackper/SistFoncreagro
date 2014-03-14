Imports SistFoncreagro.BussinessEntities
Public Interface ISemovientesRepository
    Sub DeleteSEMOVIENTES(ByVal IdSemoviente As Int32)
    Function GetSEMOVIENTESById(ByVal IdSemoviente As Int32) As Semovientes
    Function GetAllFromSEMOVIENTES() As List(Of Semovientes)
    Function SaveSEMOVIENTES(ByVal _Semovientes As Semovientes) As Int32
End Interface

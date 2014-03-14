Imports SistFoncreagro.BussinessEntities
Public Interface IGradoSalarialRepository
    Function GetAllFromGRADOSALARIAL() As List(Of GradoSalarial)
    Function SaveGRADOSALARIAL(ByVal GradoSalarial As GradoSalarial) As Int32
    Function GetGradoSalarialByIdGradoSalarial(ByVal IdGradoSalarial As Int32) As GradoSalarial
    Function GetGradoSalarialByGrado(ByVal Grado As String) As GradoSalarial
    Function GetGradoSalarialSinSubsecuente() As GradoSalarial
    Sub DeleteGradoSalarial(ByVal idGradoSalarial As Int32)
End Interface



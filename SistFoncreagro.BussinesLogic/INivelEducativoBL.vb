Imports SistFoncreagro.BussinessEntities
Public Interface INivelEducativoBL
    Function GetAllFromNivelEducativo() As List(Of NivelEducativo)
    Function GetNivelEducativoByIdNivelEducativo(ByVal idNivelEducativo As Int32) As NivelEducativo
    Sub SaveNivelEducativo(ByVal nivelEducativo As NivelEducativo)
    Sub DeleNivelEducativo(ByVal idNivelEducativo As Int32)
End Interface



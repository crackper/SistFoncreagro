Imports SistFoncreagro.BussinessEntities
Public Interface IFactorEvaluacionBL
    Function GetFACTOREVALUACIONByIdFactor(ByVal IdFactor As Int32) As FactorEvaluacion
    Function GetAllFromFACTOREVALUACION() As List(Of FactorEvaluacion)
    Sub DeleteFACTOREVALUACION(ByVal IdFactor As Int32)
    Sub SaveFACTOR(ByVal _Factor As FactorEvaluacion)
End Interface

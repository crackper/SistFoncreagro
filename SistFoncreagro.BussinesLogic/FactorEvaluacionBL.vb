Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class FactorEvaluacionBL : Implements IFactorEvaluacionBL
    Dim factoryrepository As IFactorEvaluacionRepository

    Public Sub New()
        factoryrepository = New FactorEvaluacionRepository
    End Sub

    Public Sub DeleteFACTOREVALUACION(ByVal IdFactor As Integer) Implements IFactorEvaluacionBL.DeleteFACTOREVALUACION
        factoryrepository.DeleteFACTOREVALUACION(IdFactor)
    End Sub

    Public Function GetAllFromFACTOREVALUACION() As System.Collections.Generic.List(Of BussinessEntities.FactorEvaluacion) Implements IFactorEvaluacionBL.GetAllFromFACTOREVALUACION
        Return factoryrepository.GetAllFromFACTOREVALUACION
    End Function

    Public Function GetFACTOREVALUACIONByIdFactor(ByVal IdFactor As Integer) As BussinessEntities.FactorEvaluacion Implements IFactorEvaluacionBL.GetFACTOREVALUACIONByIdFactor
        Return factoryrepository.GetFACTOREVALUACIONByIdFactor(IdFactor)
    End Function

    Public Sub SaveFACTOR(ByVal _Factor As BussinessEntities.FactorEvaluacion) Implements IFactorEvaluacionBL.SaveFACTOR
        factoryrepository.SaveFACTOR(_Factor)
    End Sub
End Class

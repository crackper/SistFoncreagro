Imports SistFoncreagro.BussinessEntities
Public Interface IPlanContableRepository
    Function GetAllPLANCONTABLE() As List(Of PlanContable)
    Function GetPLANCONTABLEByIdPlan(ByVal IdPlan As Int32) As PlanContable
    Function GetPLANCONTABLEByParameter(ByVal Texto As String) As List(Of PlanContable)
    Function GetPLANCONTABLEByParameterCompras(ByVal Texto As String) As List(Of PlanContable)
    Function SavePLANCONTABLE(ByVal _PlanContable As PlanContable) As Int32
    Function VerifyExistePLANCONTABLE(ByVal Codigo As String) As Int32
    Function GetCodigoFromPLANCONTABLE(ByVal IdPlan As Int32) As PlanContable
    Function GetPLANCONTABLEByCodigo(ByVal Codigo As String) As PlanContable
    Sub DeletePLANCONTABLE(ByVal IdPlan As Int32)
    Sub UpdateEstadoPLANCONTABLE(ByVal IdPlan As Int32)
End Interface

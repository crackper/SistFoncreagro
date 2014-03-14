Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class PlanContableBL : Implements IPlanContableBL
    Dim factoryrepository As IPlanContableRepository

    Public Sub New()
        factoryrepository = New PlanContableRepository
    End Sub
    Public Function GetAllPLANCONTABLE() As System.Collections.Generic.List(Of BussinessEntities.PlanContable) Implements IPlanContableBL.GetAllPLANCONTABLE
        Return factoryrepository.GetAllPLANCONTABLE()
    End Function

    Public Sub DeletePLANCONTABLE(ByVal IdPlan As Integer) Implements IPlanContableBL.DeletePLANCONTABLE
        factoryrepository.DeletePLANCONTABLE(IdPlan)
    End Sub

    Public Function GetPLANCONTABLEByIdPlan(ByVal IdPlan As Integer) As BussinessEntities.PlanContable Implements IPlanContableBL.GetPLANCONTABLEByIdPlan
        Return factoryrepository.GetPLANCONTABLEByIdPlan(IdPlan)


    End Function

    Public Function GetPLANCONTABLEByParameter(ByVal Texto As String) As System.Collections.Generic.List(Of BussinessEntities.PlanContable) Implements IPlanContableBL.GetPLANCONTABLEByParameter
        Return factoryrepository.GetPLANCONTABLEByParameter(Texto)
    End Function

    Public Function GetPLANCONTABLEByParameterCompras(ByVal Texto As String) As System.Collections.Generic.List(Of BussinessEntities.PlanContable) Implements IPlanContableBL.GetPLANCONTABLEByParameterCompras
        Return factoryrepository.GetPLANCONTABLEByParameterCompras(Texto)
    End Function

    Public Function SavePLANCONTABLE(ByVal _PlanContable As BussinessEntities.PlanContable) As Integer Implements IPlanContableBL.SavePLANCONTABLE
        Return factoryrepository.SavePLANCONTABLE(_PlanContable)
    End Function

    Public Sub UpdateEstadoPLANCONTABLE(ByVal IdPlan As Integer) Implements IPlanContableBL.UpdateEstadoPLANCONTABLE
        factoryrepository.UpdateEstadoPLANCONTABLE(IdPlan)
    End Sub

    Public Function VerifyExistePLANCONTABLE(ByVal Codigo As String) As Integer Implements IPlanContableBL.VerifyExistePLANCONTABLE
        Return factoryrepository.VerifyExistePLANCONTABLE(Codigo)
    End Function

    Public Function GetCodigoFromPLANCONTABLE(ByVal IdPlan As Integer) As BussinessEntities.PlanContable Implements IPlanContableBL.GetCodigoFromPLANCONTABLE
        Return factoryrepository.GetCodigoFromPLANCONTABLE(IdPlan)
    End Function

    Public Function GetPLANCONTABLEByCodigo(ByVal Codigo As String) As BussinessEntities.PlanContable Implements IPlanContableBL.GetPLANCONTABLEByCodigo
        Return factoryrepository.GetPLANCONTABLEByCodigo(Codigo)
    End Function
End Class

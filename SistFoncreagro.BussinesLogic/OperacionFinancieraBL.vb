Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class OperacionFinancieraBL : Implements IOperacionFinancieraBL

    Dim factoryrepository As IOperacionFinancieraRepository

    Public Sub New()
        factoryrepository = New OperacionFinancieraRepository
    End Sub
    Public Function GetAllFromOperacionFinanciera() As System.Collections.Generic.List(Of BussinessEntities.OperacionFinanciera) Implements IOperacionFinancieraBL.GetAllFromOperacionFinanciera
        Return factoryrepository.GetAllFromOperacionFinanciera()
    End Function
    Public Sub SaveOperacionFinanciera(ByVal _OperacionFinanciera As BussinessEntities.OperacionFinanciera) Implements IOperacionFinancieraBL.SaveOperacionFinanciera
        factoryrepository.SaveOperacionFinanciera(_OperacionFinanciera)
    End Sub

    Public Sub DeleteOperacionFinanciera(ByVal IdOpFinanciera As Integer) Implements IOperacionFinancieraBL.DeleteOperacionFinanciera
        factoryrepository.DeleteOperacionFinanciera(IdOpFinanciera)
    End Sub

    Public Function GetOperacionFinancieraByIdOpFinaciera(ByVal IdOpFinanciera As Integer) As BussinessEntities.OperacionFinanciera Implements IOperacionFinancieraBL.GetOperacionFinancieraByIdOpFinaciera
        Return factoryrepository.GetOPERACIONFINANCIERAByIdOperacion(IdOpFinanciera)
    End Function
End Class

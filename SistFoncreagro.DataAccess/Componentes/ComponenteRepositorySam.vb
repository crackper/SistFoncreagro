Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports SistFoncreagro.BussinessEntities

Partial Public Class ComponenteRepository : Inherits MasterDataAccess : Implements IComponenteRepository

    Public Function GetComponentesConvenioProyByIdComProy(ByVal idConvProy As Integer) As Object Implements IComponenteRepository.GetComponentesConvenioProyByIdComProy
        Dim query = db.ExecuteSprocAccessor(Of ComponenteDto)("GetComponentesConvenioProyByIdComProy", idConvProy)

        Return query.ToList()
    End Function
End Class

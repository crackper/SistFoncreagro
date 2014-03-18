Imports SistFoncreagro.BussinessEntities
Imports Microsoft.Practices.EnterpriseLibrary.Data

Partial Public Class ConvenioRepository : Inherits MasterDataAccess : Implements IConvenioRepository

    Public Function GetConveniosByIdProyecto(idProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.ConvenioDto) Implements IConvenioRepository.GetConveniosByIdProyecto
        Dim query = db.ExecuteSprocAccessor(Of ConvenioDto)("GetConveniosByIdProyecto", idProyecto)

        Return query.ToList()
    End Function
End Class

Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports SistFoncreagro.BussinessEntities
Imports System.Data

Partial Public Class ProyectoRepository : Inherits MasterDataAccess : Implements IProyectoRepository

    Public Function GetProyectoDtoyIdProyecto(idProyecto As Integer) As BussinessEntities.ProyectoDto Implements IProyectoRepository.GetProyectoDtoyIdProyecto
        Dim query = db.ExecuteSprocAccessor(Of ProyectoDto)("GetProyectoDtoyIdProyecto", idProyecto)
        Return query.SingleOrDefault()
       
    End Function
End Class

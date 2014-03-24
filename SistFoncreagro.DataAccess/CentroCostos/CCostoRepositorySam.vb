Imports SistFoncreagro.BussinessEntities
Imports Microsoft.Practices.EnterpriseLibrary.Data

Partial Public Class CCostoRepository : Inherits MasterDataAccess : Implements ICCostoRepository

    Public Function GetCCostoByIdProyAct(idProyAct As Integer) As System.Collections.Generic.List(Of BussinessEntities.CCostoDto) Implements ICCostoRepository.GetCCostoByIdProyAct
        Dim query = db.ExecuteSprocAccessor(Of CCostoDto)("GetCCostoByIdProyAct", idProyAct)

        Return query.ToList()
    End Function
End Class

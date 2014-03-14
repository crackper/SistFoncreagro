Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoGastoBL : Implements ITipoGastoRrpository
    Dim factoryrepository As ITipoGastoRrpository
    Public Sub New()
        factoryrepository = New TipoGastoRepository
    End Sub
    Public Function GetAllFromTIPOGASTO() As System.Collections.Generic.List(Of BussinessEntities.TipoGasto) Implements DataAccess.ITipoGastoRrpository.GetAllFromTIPOGASTO
        Return factoryrepository.GetAllFromTIPOGASTO
    End Function

    Public Function GetTIPOGASTOByIdTipoGasto(ByVal IdTipoGasto As Integer) As BussinessEntities.TipoGasto Implements DataAccess.ITipoGastoRrpository.GetTIPOGASTOByIdTipoGasto
        Return factoryrepository.GetTIPOGASTOByIdTipoGasto(IdTipoGasto)
    End Function

    Public Sub SaveTIPOGASTO(ByVal _TipoGasto As BussinessEntities.TipoGasto) Implements DataAccess.ITipoGastoRrpository.SaveTIPOGASTO
        factoryrepository.SaveTIPOGASTO(_TipoGasto)
    End Sub
End Class

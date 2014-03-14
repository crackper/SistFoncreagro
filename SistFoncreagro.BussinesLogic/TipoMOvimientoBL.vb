Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoMOvimientoBL : Implements ITipoMovimientoBL
    Dim factoryrepository As ITipoMovimientoRepository

    Public Sub New()
        factoryrepository = New TipoMovimientoRepository
    End Sub

    Public Function GetAllFromTIPOMOVIMIENTO() As System.Collections.Generic.List(Of BussinessEntities.TipoMovimiento) Implements ITipoMovimientoBL.GetAllFromTIPOMOVIMIENTO
        Return factoryrepository.GetAllFromTIPOMOVIMIENTO
    End Function

    Public Function GetTIPOMOVIMIENTOByIdTipoMovimiento(ByVal IdTipoMovimiento As Integer) As BussinessEntities.TipoMovimiento Implements ITipoMovimientoBL.GetTIPOMOVIMIENTOByIdTipoMovimiento
        Return factoryrepository.GetTIPOMOVIMIENTOByIdTipoMovimiento(IdTipoMovimiento)
    End Function
End Class

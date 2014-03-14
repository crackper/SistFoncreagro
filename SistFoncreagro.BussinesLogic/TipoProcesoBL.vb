Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoProcesoBL : Implements ITipoProcesoBL
    Dim factoryrepository As ITipoProcesoRepository

    Public Sub New()
        factoryrepository = New TipoProcesoRepository
    End Sub
    Public Function GetAllFromTIPOPROCESO() As System.Collections.Generic.List(Of BussinessEntities.TipoProceso) Implements ITipoProcesoBL.GetAllFromTIPOPROCESO
        Return factoryrepository.GetAllFromTIPOPROCESO
    End Function

    Public Function GetTIPOPROCESOByIdTipoProceso(ByVal IdTipoProceso As Integer) As BussinessEntities.TipoProceso Implements ITipoProcesoBL.GetTIPOPROCESOByIdTipoProceso
        Return factoryrepository.GetTIPOPROCESOByIdTipoProceso(IdTipoProceso)
    End Function
End Class

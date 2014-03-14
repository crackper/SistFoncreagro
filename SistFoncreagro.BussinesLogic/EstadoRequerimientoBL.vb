Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class EstadoRequerimientoBL : Implements IEstadoRequerimientoBL
    Dim estadoReq As IEstadoRequerimientoRepository
    Sub New()
        estadoReq = New EstadoRequerimientoRepository
    End Sub
    Public Function GetAllFromEstadoRequerimientoByIdRequerimiento(ByVal IdRequerimiento As Integer) As System.Collections.Generic.List(Of BussinessEntities.EstadoRequerimiento) Implements IEstadoRequerimientoBL.GetAllFromEstadoRequerimientoByIdRequerimiento
        Return estadoReq.GetAllFromEstadoRequerimientoByIdRequerimiento(IdRequerimiento)
    End Function
End Class

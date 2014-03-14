Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Imports System.Data
Public Class TipoTrabajadorDetalleConceptoBL : Implements ITipoTrabajadorDetalleConceptoBL
    Dim factoryrepository As ITipoTrabajadorDetalleConceptoRepository

    Public Sub New()
        factoryrepository = New TipoTrabajadorDetalleConceptoRepository
    End Sub

    Public Sub DeleteTipoTrabajadorDetalleConcepto(ByVal IdTipoTDetConcepto As Integer) Implements ITipoTrabajadorDetalleConceptoBL.DeleteTipoTrabajadorDetalleConcepto
        factoryrepository.DeleteTipoTrabajadorDetalleConcepto(IdTipoTDetConcepto)
    End Sub

    Public Function GetTipoTrabajadorDetalleConceptoByDisponible(ByVal Disponible As Boolean) As System.Collections.Generic.List(Of BussinessEntities.TipoTrabajadorDetalleConcepto) Implements ITipoTrabajadorDetalleConceptoBL.GetTipoTrabajadorDetalleConceptoByDisponible
        Return factoryrepository.GetTipoTrabajadorDetalleConceptoByDisponible(Disponible)
    End Function

    Public Function SaveTipoTrabajadorDetalleConcepto(ByVal TipoTrabajadorDetalleConcepto As BussinessEntities.TipoTrabajadorDetalleConcepto) As Integer Implements ITipoTrabajadorDetalleConceptoBL.SaveTipoTrabajadorDetalleConcepto
        Return factoryrepository.SaveTipoTrabajadorDetalleConcepto(TipoTrabajadorDetalleConcepto)
    End Function

    Public Function GetTipoTrabajadorDetalleConceptoByIds(ByVal IdTipoTrabajador As Integer, ByVal IdCategoria As Integer, ByVal IdDetalleConcepto As Integer) As BussinessEntities.TipoTrabajadorDetalleConcepto Implements ITipoTrabajadorDetalleConceptoBL.GetTipoTrabajadorDetalleConceptoByIds
        Return factoryrepository.GetTipoTrabajadorDetalleConceptoByIds(IdTipoTrabajador, IdCategoria, IdDetalleConcepto)
    End Function

    Public Sub SaveAndDeleteListaTipoTrabajador(ByVal listaCrear As System.Collections.Generic.List(Of BussinessEntities.TipoTrabajadorDetalleConcepto), ByVal listaEliminar As System.Collections.Generic.List(Of Integer)) Implements ITipoTrabajadorDetalleConceptoBL.SaveAndDeleteListaTipoTrabajador
        If listaEliminar.Count > 0 Then
            For i = 0 To listaEliminar.Count - 1
                DeleteTipoTrabajadorDetalleConcepto(listaEliminar(i))
            Next
        End If

        If listaCrear.Count > 0 Then
            For i = 0 To listaCrear.Count - 1
                SaveTipoTrabajadorDetalleConcepto(listaCrear(i))
            Next
        End If
    End Sub
End Class


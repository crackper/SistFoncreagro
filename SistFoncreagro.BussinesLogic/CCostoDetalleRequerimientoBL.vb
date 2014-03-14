Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class CCostoDetalleRequerimientoBL : Implements ICCostoDetalleRequerimientoBL
    Dim factoryRepository As ICCostoDetalleRequerimientoRepository
    Public Sub New()
        factoryRepository = New CCostoDetalleRequerimientoRepository
    End Sub

    Public Sub DeleteCCostoDetalleRequerimiento(ByVal idcCostoDetalleRequerimiento As Integer) Implements ICCostoDetalleRequerimientoBL.DeleteCCostoDetalleRequerimiento
        factoryRepository.DeleteCCostoDetalleRequerimiento(idcCostoDetalleRequerimiento)
    End Sub

    Public Function GetAllFromCCostoDetalleRequerimientoByIdDetReq(ByVal idDetReq As Integer) As System.Collections.Generic.List(Of BussinessEntities.CCostoxDetalleRequerimiento) Implements ICCostoDetalleRequerimientoBL.GetAllFromCCostoDetalleRequerimientoByIdDetReq
        Return factoryRepository.GetAllFromCCostoDetalleRequerimientoByIdDetReq(idDetReq)
    End Function

    Public Sub SaveCCostoDetalleRequerimiento(ByVal ccostoDetalleRequerimiento As BussinessEntities.CCostoxDetalleRequerimiento) Implements ICCostoDetalleRequerimientoBL.SaveCCostoDetalleRequerimiento
        factoryRepository.SaveCCostoDetalleRequerimiento(ccostoDetalleRequerimiento)
    End Sub
End Class

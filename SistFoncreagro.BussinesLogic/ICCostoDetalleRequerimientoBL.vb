Imports SistFoncreagro.BussinessEntities

Public Interface ICCostoDetalleRequerimientoBL
    Function GetAllFromCCostoDetalleRequerimientoByIdDetReq(ByVal idDetReq As Int32) As List(Of CCostoxDetalleRequerimiento)
    Sub SaveCCostoDetalleRequerimiento(ByVal ccostoDetalleRequerimiento As CCostoxDetalleRequerimiento)
    Sub DeleteCCostoDetalleRequerimiento(ByVal idcCostoDetalleRequerimiento As Int32)
End Interface

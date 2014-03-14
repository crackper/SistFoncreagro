Imports SistFoncreagro.BussinessEntities
Public Interface ITransaccionBL
    Function GetAllFromTransaccion() As List(Of Transaccion)
    Function GetTransaccionByIdTransaccion(ByVal IdTransaccion As Int32) As Transaccion
    Function GetTransaccionByAnioMes(ByVal anio As Int32, ByVal mes As Int32) As List(Of Transaccion)
    Function GetTRANSACCIONByAnioMesIdSubdiarioIdProveedorCliente(ByVal anio As Int32, ByVal mes As Int32, ByVal idSubDiario As Int32, ByVal idproveedorCliente As Int32) As List(Of Transaccion)
    Function GetTRANSACCIONByAnioMesIdSubdiario(ByVal anio As Int32, ByVal mes As Int32, ByVal idSubDiario As Int32) As List(Of Transaccion)
    Function SaveTransaccion(ByVal _Transaccion As Transaccion) As Int32
    Function GenerarTRANSACCIONDuplicada(ByVal IdTransaccion As Int32, ByVal fechaCOntable As DateTime, ByVal usuario As Int32, ByVal IdSubdiario As Int32) As Int32
    Function GenerarTRANSACCIONRevertida(ByVal IdTransaccion As Int32, ByVal fechaCOntable As DateTime, ByVal usuario As Int32, ByVal IdSubdiario As Int32) As Int32
    Function GenerarTRANSACCIONByIdRendicion(ByVal IdRendicion As Int32, ByVal idUser As Int32) As Int32
    Function GenerarTRANSACCIONordenCompra(ByVal IdOcxFactura As Int32, ByVal FechaContable As DateTime, ByVal Usuario As Int32) As Int32
    Function GetTRANSACCIONByAnioMesIdSubdiarioFlag(ByVal anio As Int32, ByVal mes As Int32, ByVal idSubDiario As Int32, ByVal Flag As String) As List(Of Transaccion)
    Function GetTRANSACCIONByAnioMesIdSubdiarioCodigo(ByVal anio As Int32, ByVal mes As Int32, ByVal idSubDiario As Int32, ByVal Codigo As String) As Transaccion
    Sub DeleteTransaccion(ByVal IdTransaccion As Int32)
    Sub UpdateEstadoTRANSACCION(ByVal IdTransaccion As Int32, ByVal Estado As String)
    Sub AnularTRANSACCIONCaja(ByVal IdTransaccion As Int32)
    Sub UpdateMontosCCOSTO(ByVal Codigo As String, ByVal Monto As Decimal)
    Sub GenerarDestinoDiario(ByVal IdTransaccion As Int32)
    Function VerifyDisponibleCCOSTO(ByVal Codigo As String) As Decimal
    Function GetCCostoLINEA(ByVal registro As String, ByVal coa As String, ByVal cargo As Decimal) As String
    Function GetTRANSACCIONByAnioMesFlagCtaBancaria(ByVal anio As Int32, ByVal mes As Int32, ByVal Flag As String, ByVal IdCtaBancaria As Int32) As List(Of Transaccion)
    Function GetTRANSACCIONESdeAnticiposEntregasPendientes() As List(Of Transaccion)
    Sub UpdateEnlaceTRANSACCION(ByVal IdTransaccion As Int32, ByVal Enlace As String)
    Function GetTRANSACCIONByAnioMesFlagIdproyecto(ByVal anio As Int32, ByVal mes As Int32, ByVal Flag As String, ByVal IdProyecto As Int32) As List(Of Transaccion)
    Sub GenerarAjusteDifCambio(ByVal FechaContable As DateTime, ByVal anio As Int32, ByVal mes As Int32, ByVal usuario As Int32)
    Sub GenerarAsientoApertura(ByVal FechaContable As DateTime, ByVal anio As Int32, ByVal mes As Int32, ByVal usuario As Int32)
    Sub GenerarAsientoCierre(ByVal FechaContable As DateTime, ByVal anio As Int32, ByVal mes As Int32, ByVal usuario As Int32)
    Function VerifyExisteAjusteDifCambio(ByVal Anio As Int32, ByVal Mes As Int32) As Int32
    Function VerifyDocumentoDuplicado(ByVal Proveedor As Int32, ByVal Serie As String, ByVal Numero As Int64, ByVal DocContable As Int32, ByVal IdTransaccion As Int32) As Int32
    Function VerifyDocumentoVentaDuplicado(ByVal Serie As String, ByVal Numero As Int64, ByVal DocContable As Int32, ByVal IdTransaccion As Int32) As Int32
    Function VerifyDocumentoDuplicadoRendicion(ByVal Proveedor As Int32, ByVal Serie As String, ByVal Numero As Int64, ByVal DocContable As Int32, ByVal IdDocumentoRendido As Int32) As Int32
    Sub UpdateProyectoTRANSACCION(ByVal idTransaccion As Int32, ByVal proyecto As String)
    Sub UpdateMotivoOCxFactura(ByVal IdOcxFactura As Int32, ByVal motivo As String)
    Sub CancelarCtaXPagar(ByVal idTipoDoc As Int32, ByVal serie As String, ByVal numero As Int64, ByVal idProveedor As Int32, ByVal estado As String)
    Sub CancelarCtaXCobrar(ByVal idTipoDoc As Int32, ByVal serie As String, ByVal numero As Int64, ByVal idProveedor As Int32, ByVal estado As String)
    Sub CuadrarVoucher(ByVal IdTransaccion As Int32)
    Sub CuadrarVoucherCaja(ByVal IdTransaccion As Int32)
    Sub CuadrarVoucherDiario(ByVal IdTransaccion As Int32)
    Sub GenerarLineaFondoFijo(ByVal IdTransaccion As Int32)
    Function GetTransaccionesSinProcesar(ByVal Anio As Int32, ByVal Mes As Int32) As List(Of Transaccion)
    Function GetSaldoTotalTransaccion(ByVal IdTransaccion As Int32) As Decimal
    Function GenerarTRANSACCIONByIdVenta(ByVal IdVenta As Int32, ByVal IdUser As Int32, ByVal FechaContable As DateTime) As Int32
    Sub Send_EmailContabilidadTransferencia(ByVal IdTransaccion As Int32)
    Function GenerarTRANSACCIONBajaSemovientes(ByVal IdTransaccion As Int32) As Int32
    Sub Send_EmailContabilidadBajaGanado(ByVal IdTransaccion As Int32)
    Sub GenerarAsientoDepreciacion(ByVal FechaContable As DateTime, ByVal anio As Int32, ByVal mes As Int32, ByVal usuario As Int32)
    Sub GenerarAsientoTraslado(ByVal FechaContable As DateTime, ByVal anio As Int32, ByVal mes As Int32, ByVal usuario As Int32)
    Function VerifyExisteTransaccion(ByVal Proyecto As Int32, ByVal FechaDoc As DateTime, ByVal Proveedor As Int32, ByVal Total As Decimal) As Int32
    Sub GenerarAsientoSemovientes(ByVal FechaContable As DateTime, ByVal IdUser As Int32)
End Interface

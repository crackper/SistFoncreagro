Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TransaccionBL : Implements ITransaccionBL
    Dim factoryrepository As ITransaccionRepository
    Public Sub New()
        factoryrepository = New TransaccionRepository
    End Sub

    Public Sub DeleteTransaccion(ByVal IdTransaccion As Integer) Implements ITransaccionBL.DeleteTransaccion
        factoryrepository.DeleteTransaccion(IdTransaccion)
    End Sub

    Public Function GetAllFromTransaccion() As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionBL.GetAllFromTransaccion
        Return factoryrepository.GetAllFromTransaccion()
    End Function

    Public Function GetTransaccionByIdTransaccion(ByVal IdTransaccion As Integer) As BussinessEntities.Transaccion Implements ITransaccionBL.GetTransaccionByIdTransaccion
        Return factoryrepository.GetTRANSACCIONByIdtransaccion(IdTransaccion)
    End Function
    Public Function GettransaccionByAnioMes(ByVal anio As Integer, ByVal mes As Integer) As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionBL.GetTransaccionByAnioMes
        Return factoryrepository.GetTRANSACCIONByAnioMes(anio, mes)
    End Function

    Public Function GetTRANSACCIONByAnioMesIdSubdiarioIdProveedorCliente(ByVal anio As Integer, ByVal mes As Integer, ByVal idSubDiario As Integer, ByVal idproveedorCliente As Integer) As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionBL.GetTRANSACCIONByAnioMesIdSubdiarioIdProveedorCliente
        Return factoryrepository.GetTRANSACCIONByAnioMesIdSubdiarioIdProveedorCliente(anio, mes, idSubDiario, idproveedorCliente)
    End Function

    Public Function SaveTransaccion(ByVal _Transaccion As BussinessEntities.Transaccion) As Integer Implements ITransaccionBL.SaveTransaccion
        Return factoryrepository.SaveTransaccion(_Transaccion)
    End Function

    Public Sub UpdateEstadoTRANSACCION(ByVal IdTransaccion As Integer, ByVal Estado As String) Implements ITransaccionBL.UpdateEstadoTRANSACCION
        factoryrepository.UpdateEstadoTRANSACCION(IdTransaccion, Estado)
    End Sub

    Public Function GetTRANSACCIONByAnioMesIdSubdiario(ByVal anio As Integer, ByVal mes As Integer, ByVal idSubDiario As Integer) As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionBL.GetTRANSACCIONByAnioMesIdSubdiario
        Return factoryrepository.GetTRANSACCIONByAnioMesIdSubdiario(anio, mes, idSubDiario)
    End Function

    Public Function GenerarTRANSACCIONByIdRendicion(ByVal IdRendicion As Integer, ByVal idUser As Int32) As Integer Implements ITransaccionBL.GenerarTRANSACCIONByIdRendicion
        Return factoryrepository.GenerarTRANSACCIONByIdRendicion(IdRendicion, idUser)
    End Function

    Public Function GetTRANSACCIONByAnioMesIdSubdiarioFlag(ByVal anio As Integer, ByVal mes As Integer, ByVal idSubDiario As Integer, ByVal Flag As String) As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionBL.GetTRANSACCIONByAnioMesIdSubdiarioFlag
        Return factoryrepository.GetTRANSACCIONByAnioMesIdSubdiarioFlag(anio, mes, idSubDiario, Flag)
    End Function

    Public Sub AnularTRANSACCIONCaja(ByVal IdTransaccion As Integer) Implements ITransaccionBL.AnularTRANSACCIONCaja
        factoryrepository.AnularTRANSACCIONCaja(IdTransaccion)
    End Sub

    Public Function GetTRANSACCIONByAnioMesIdSubdiarioCodigo(ByVal anio As Integer, ByVal mes As Integer, ByVal idSubDiario As Integer, ByVal Codigo As String) As BussinessEntities.Transaccion Implements ITransaccionBL.GetTRANSACCIONByAnioMesIdSubdiarioCodigo
        Return factoryrepository.GetTRANSACCIONByAnioMesIdSubdiarioCodigo(anio, mes, idSubDiario, Codigo)
    End Function

    Public Function GenerarTRANSACCIONDuplicada(ByVal IdTransaccion As Integer, ByVal fechaCOntable As Date, ByVal usuario As Integer, ByVal IdSubdiario As Int32) As Integer Implements ITransaccionBL.GenerarTRANSACCIONDuplicada
        Return factoryrepository.GenerarTRANSACCIONDuplicada(IdTransaccion, fechaCOntable, usuario, IdSubdiario)
    End Function

    Public Sub UpdateMontosCCOSTO(ByVal Codigo As String, ByVal Monto As Decimal) Implements ITransaccionBL.UpdateMontosCCOSTO
        factoryrepository.UpdateMontosCCOSTO(Codigo, Monto)
    End Sub

    Public Function VerifyDisponibleCCOSTO(ByVal Codigo As String) As Decimal Implements ITransaccionBL.VerifyDisponibleCCOSTO
        Return factoryrepository.VerifyDisponibleCCOSTO(Codigo)
    End Function

    Public Function GetCCostoLINEA(ByVal registro As String, ByVal coa As String, ByVal cargo As Decimal) As String Implements ITransaccionBL.GetCCostoLINEA
        Return factoryrepository.GetCCostoLINEA(registro, coa, cargo)
    End Function

    Public Function GetTRANSACCIONByAnioMesFlagCtaBancaria(ByVal anio As Integer, ByVal mes As Integer, ByVal Flag As String, ByVal IdCtaBancaria As Integer) As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionBL.GetTRANSACCIONByAnioMesFlagCtaBancaria
        Return factoryrepository.GetTRANSACCIONByAnioMesFlagCtaBancaria(anio, mes, Flag, IdCtaBancaria)
    End Function

    Public Sub GenerarDestinoDiario(ByVal IdTransaccion As Integer) Implements ITransaccionBL.GenerarDestinoDiario
        factoryrepository.GenerarDestinoDiario(IdTransaccion)
    End Sub

    Public Function GetTRANSACCIONESdeAnticiposEntregasPendientes() As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionBL.GetTRANSACCIONESdeAnticiposEntregasPendientes
        Return factoryrepository.GetTRANSACCIONESdeAnticiposEntregasPendientes()
    End Function

    Public Sub UpdateEnlaceTRANSACCION(ByVal IdTransaccion As Integer, ByVal Enlace As String) Implements ITransaccionBL.UpdateEnlaceTRANSACCION
        factoryrepository.UpdateEnlaceTRANSACCION(IdTransaccion, Enlace)
    End Sub

    Public Function GetTRANSACCIONByAnioMesFlagIdproyecto(ByVal anio As Integer, ByVal mes As Integer, ByVal Flag As String, ByVal IdProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionBL.GetTRANSACCIONByAnioMesFlagIdproyecto
        Return factoryrepository.GetTRANSACCIONByAnioMesFlagIdproyecto(anio, mes, Flag, IdProyecto)
    End Function

    Public Function GenerarTRANSACCIONRevertida(ByVal IdTransaccion As Integer, ByVal fechaCOntable As Date, ByVal usuario As Integer, ByVal IdSubdiario As Int32) As Integer Implements ITransaccionBL.GenerarTRANSACCIONRevertida
        Return factoryrepository.GenerarTRANSACCIONRevertida(IdTransaccion, fechaCOntable, usuario, IdSubdiario)
    End Function

    Public Sub GenerarAjusteDifCambio(ByVal FechaContable As Date, ByVal anio As Integer, ByVal mes As Integer, ByVal usuario As Integer) Implements ITransaccionBL.GenerarAjusteDifCambio
        factoryrepository.GenerarAjusteDifCambio(FechaContable, anio, mes, usuario)
    End Sub

    Public Sub GenerarAsientoApertura(ByVal FechaContable As Date, ByVal anio As Integer, ByVal mes As Integer, ByVal usuario As Integer) Implements ITransaccionBL.GenerarAsientoApertura
        factoryrepository.GenerarAsientoApertura(FechaContable, anio, mes, usuario)
    End Sub

    Public Sub GenerarAsientoCierre(ByVal FechaContable As Date, ByVal anio As Integer, ByVal mes As Integer, ByVal usuario As Integer) Implements ITransaccionBL.GenerarAsientoCierre
        factoryrepository.GenerarAsientoCierre(FechaContable, anio, mes, usuario)
    End Sub

    Public Function VerifyExisteAjusteDifCambio(ByVal Anio As Integer, ByVal Mes As Integer) As Integer Implements ITransaccionBL.VerifyExisteAjusteDifCambio
        Return factoryrepository.VerifyExisteAjusteDifCambio(Anio, Mes)
    End Function
    Public Sub UpdateProyectoTRANSACCION(ByVal idTransaccion As Integer, ByVal proyecto As String) Implements ITransaccionBL.UpdateProyectoTRANSACCION
        factoryrepository.UpdateProyectoTRANSACCION(idTransaccion, proyecto)
    End Sub
    Public Function GenerarTRANSACCIONordenCompra(ByVal IdOcxFactura As Integer, ByVal FechaContable As Date, ByVal Usuario As Integer) As Integer Implements ITransaccionBL.GenerarTRANSACCIONordenCompra
        Return factoryrepository.GenerarTRANSACCIONordenCompra(IdOcxFactura, FechaContable, Usuario)
    End Function

    Public Sub UpdateMotivoOCxFactura(ByVal IdOcxFactura As Integer, ByVal motivo As String) Implements ITransaccionBL.UpdateMotivoOCxFactura
        factoryrepository.UpdateMotivoOCxFactura(IdOcxFactura, motivo)
    End Sub

    Public Sub CancelarCtaXPagar(ByVal idTipoDoc As Integer, ByVal serie As String, ByVal numero As Long, ByVal idProveedor As Integer, ByVal estado As String) Implements ITransaccionBL.CancelarCtaXPagar
        factoryrepository.CancelarCtaXPagar(idTipoDoc, serie, numero, idProveedor, estado)
    End Sub

    Public Sub CancelarCtaXCobrar(ByVal idTipoDoc As Integer, ByVal serie As String, ByVal numero As Long, ByVal idProveedor As Integer, ByVal estado As String) Implements ITransaccionBL.CancelarCtaXCobrar
        factoryrepository.CancelarCtaXCobrar(idTipoDoc, serie, numero, idProveedor, estado)
    End Sub

    Public Sub CuadrarVoucher(ByVal IdTransaccion As Integer) Implements ITransaccionBL.CuadrarVoucher
        factoryrepository.CuadrarVoucher(IdTransaccion)
    End Sub

    Public Sub CuadrarVoucherCaja(ByVal IdTransaccion As Integer) Implements ITransaccionBL.CuadrarVoucherCaja
        factoryrepository.CuadrarVoucherCaja(IdTransaccion)
    End Sub

    Public Sub CuadrarVoucherDiario(ByVal IdTransaccion As Integer) Implements ITransaccionBL.CuadrarVoucherDiario
        factoryrepository.CuadrarVoucherDiario(IdTransaccion)
    End Sub

    Public Sub GenerarLineaFondoFijo(ByVal IdTransaccion As Integer) Implements ITransaccionBL.GenerarLineaFondoFijo
        factoryrepository.GenerarLineaFondoFijo(IdTransaccion)
    End Sub

    Public Function GetTransaccionesSinProcesar(ByVal Anio As Integer, ByVal Mes As Integer) As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionBL.GetTransaccionesSinProcesar
        Return factoryrepository.GetTransaccionesSinProcesar(Anio, Mes)
    End Function

    Public Function GetSaldoTotalTransaccion(ByVal IdTransaccion As Integer) As Decimal Implements ITransaccionBL.GetSaldoTotalTransaccion
        Return factoryrepository.GetSaldoTotalTransaccion(IdTransaccion)
    End Function

    Public Function VerifyDocumentoDuplicado(ByVal Proveedor As Integer, ByVal Serie As String, ByVal Numero As Long, ByVal DocContable As Integer, ByVal IdTransaccion As Integer) As Integer Implements ITransaccionBL.VerifyDocumentoDuplicado
        Return factoryrepository.VerifyDocumentoDuplicado(Proveedor, Serie, Numero, DocContable, IdTransaccion)
    End Function

    Public Function VerifyDocumentoVentaDuplicado(ByVal Serie As String, ByVal Numero As Long, ByVal DocContable As Integer, ByVal IdTransaccion As Integer) As Integer Implements ITransaccionBL.VerifyDocumentoVentaDuplicado
        Return factoryrepository.VerifyDocumentoVentaDuplicado(Serie, Numero, DocContable, IdTransaccion)
    End Function

    Public Function VerifyDocumentoDuplicadoRendicion(ByVal Proveedor As Integer, ByVal Serie As String, ByVal Numero As Long, ByVal DocContable As Integer, ByVal IdDocumentoRendido As Integer) As Integer Implements ITransaccionBL.VerifyDocumentoDuplicadoRendicion
        Return factoryrepository.VerifyDocumentoDuplicadoRendicion(Proveedor, Serie, Numero, DocContable, IdDocumentoRendido)
    End Function

    Public Function GenerarTRANSACCIONByIdVenta(ByVal IdVenta As Integer, ByVal IdUser As Integer, ByVal FechaContable As Date) As Integer Implements ITransaccionBL.GenerarTRANSACCIONByIdVenta
        Return factoryrepository.GenerarTRANSACCIONByIdVenta(IdVenta, IdUser, FechaContable)
    End Function

    Public Sub Send_EmailContabilidadTransferencia(ByVal IdTransaccion As Integer) Implements ITransaccionBL.Send_EmailContabilidadTransferencia
        factoryrepository.Send_EmailContabilidadTransferencia(IdTransaccion)
    End Sub

    Public Function GenerarTRANSACCIONBajaSemovientes(ByVal IdTransaccion As Integer) As Integer Implements ITransaccionBL.GenerarTRANSACCIONBajaSemovientes
        Return factoryrepository.GenerarTRANSACCIONBajaSemovientes(IdTransaccion)
    End Function

    Public Sub Send_EmailContabilidadBajaGanado(ByVal IdTransaccion As Integer) Implements ITransaccionBL.Send_EmailContabilidadBajaGanado
        factoryrepository.Send_EmailContabilidadBajaGanado(IdTransaccion)
    End Sub

    Public Sub GenerarAsientoDepreciacion(ByVal FechaContable As Date, ByVal anio As Integer, ByVal mes As Integer, ByVal usuario As Integer) Implements ITransaccionBL.GenerarAsientoDepreciacion
        factoryrepository.GenerarAsientoDepreciacion(FechaContable, anio, mes, usuario)
    End Sub

    Public Sub GenerarAsientoTraslado(ByVal FechaContable As Date, ByVal anio As Integer, ByVal mes As Integer, ByVal usuario As Integer) Implements ITransaccionBL.GenerarAsientoTraslado
        factoryrepository.GenerarAsientoTraslado(FechaContable, anio, mes, usuario)
    End Sub

    Public Function VerifyExisteTransaccion(ByVal Proyecto As Integer, ByVal FechaDoc As Date, ByVal Proveedor As Integer, ByVal Total As Decimal) As Integer Implements ITransaccionBL.VerifyExisteTransaccion
        Return factoryrepository.VerifyExisteTransaccion(Proyecto, FechaDoc, Proveedor, Total)
    End Function

    Public Sub GenerarAsientoSemovientes(ByVal FechaContable As Date, ByVal IdUser As Integer) Implements ITransaccionBL.GenerarAsientoSemovientes
        factoryrepository.GenerarAsientoSemovientes(FechaContable, IdUser)
    End Sub
End Class

Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TransaccionRepository : Inherits MasterDataAccess : Implements ITransaccionRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Transaccion)
        Dim lista As New List(Of Transaccion)
        Dim DocumentoContabilizadoRepository As New DocumentoContabilizadoRepository
        Dim TipoDocumentoRepository As New TipoDocumentoRepository
        Dim CuentaBancariaRepository As New CuentaBancariaRepository
        Dim OperacionFinancierarepository As New OperacionFinancieraRepository
        Dim proveedorRepository As New ProveedorClienteRepository
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Transaccion As New Transaccion() With
                {
                   .Anio = reader.GetValue(0),
                   .BaseImponible = reader.GetValue(1),
                   .BaseInafecto = reader.GetValue(2),
                   .Codigo = reader.GetValue(3),
                   .Estado = reader.GetValue(6),
                   .FechaContable = reader.GetValue(7),
                   .FechaDocumento = reader.GetValue(9),
                   .Glosa = reader.GetValue(11),
                   .IdSubDiario = reader.GetValue(18),
                   .Idtransaccion = reader.GetValue(21),
                   .Mes = reader.GetValue(22),
                   .MontoIgv = reader.GetValue(23),
                   .NroDocumento = reader.GetValue(26),
                   .Otros = reader.GetValue(27),
                  .TipoCambio = reader.GetValue(30),
                   .Total = reader.GetValue(32),
                   .Usuario = reader.GetValue(33),
                   .ValorIgv = reader.GetValue(34),
                   .IdMoneda = reader.GetValue(35),
                   .IdProyecto = reader.GetValue(38),
                   .Flag = reader.GetValue(40),
                   .AfectoSistPen = reader.GetValue(43),
                   .AporteAfp = reader.GetValue(45),
                   .Comision = reader.GetValue(46),
                   .Seguro = reader.GetValue(47),
                   .MontoSistPen = reader.GetValue(48)
                  }
                If Not (reader.IsDBNull(14)) Then
                    _Transaccion.IdOpFinanciera = reader.GetValue(14)
                    _Transaccion.OperacionFinanciera = OperacionFinancierarepository.GetOPERACIONFINANCIERAByIdOperacion(reader.GetValue(14))
                End If
                If Not (reader.IsDBNull(17)) Then
                    _Transaccion.IdProveedorCliente = reader.GetValue(17)
                    _Transaccion.ProveedorCliente = proveedorRepository.GetAllFromProveedorClienteById(reader.GetValue(17))
                End If
                If Not (reader.IsDBNull(29)) Then
                    _Transaccion.SerieDocumento = reader.GetValue(29)

                End If
                If Not (reader.IsDBNull(4)) Then
                    _Transaccion.IdCtaBancaria = reader.GetValue(4)
                End If

                If Not (reader.IsDBNull(5)) Then
                    _Transaccion.DiasVencimiento = reader.GetValue(5)
                End If

                If Not (reader.IsDBNull(8)) Then
                    _Transaccion.FechaDocRef = reader.GetValue(8)
                End If
                If Not (reader.IsDBNull(10)) Then
                    _Transaccion.FechaVencimiento = reader.GetValue(10)
                End If
                If Not (reader.IsDBNull(12)) Then
                    _Transaccion.IdDetraccion = reader.GetValue(12)
                End If
                If Not (reader.IsDBNull(13)) Then
                    _Transaccion.IdDocumentoCont = reader.GetValue(13)
                    _Transaccion.DocumentoContabilizado = DocumentoContabilizadoRepository.GetDOCUMENTOCONTABILIZADOByIdDocConta(reader.GetValue(13))
                    _Transaccion.TipoDocumento = TipoDocumentoRepository.GetTIPODOCUMENTOByIdTipoDocumento(_Transaccion.DocumentoContabilizado.IdTipoDocumento)

                End If
                If Not (reader.IsDBNull(15)) Then
                    _Transaccion.IdOrdenCompra = reader.GetValue(15)
                End If

                If Not (reader.IsDBNull(16)) Then
                    _Transaccion.IdPersonal = reader.GetValue(16)
                End If
                If Not (reader.IsDBNull(20)) Then
                    _Transaccion.IdTipoDocRef = reader.GetValue(20)
                End If

                If Not (reader.IsDBNull(24)) Then
                    _Transaccion.NroCheque = reader.GetValue(24)
                End If

                If Not (reader.IsDBNull(25)) Then
                    _Transaccion.NroDocRef = reader.GetValue(25)
                End If

                If Not (reader.IsDBNull(28)) Then
                    _Transaccion.SerieDocRef = reader.GetValue(28)
                End If

                If Not (reader.IsDBNull(19)) Then
                    _Transaccion.IdTipoBaseImp = reader.GetValue(19)

                End If

                If Not (reader.IsDBNull(31)) Then
                    _Transaccion.TipoCambioDocRef = reader.GetValue(31)
                End If
                If Not (reader.IsDBNull(36)) Then
                    _Transaccion.NroExoneracion = reader.GetValue(36)
                End If
                If Not (reader.IsDBNull(37)) Then
                    _Transaccion.MontoRetencion = reader.GetValue(37)
                End If
                If Not (reader.IsDBNull(39)) Then
                    _Transaccion.AfectoIgv = reader.GetValue(39)
                End If
                If Not (reader.IsDBNull(41)) Then
                    _Transaccion.Enlace = reader.GetValue(41)
                End If
                If Not (reader.IsDBNull(42)) Then
                    _Transaccion.IdTipoMedioPago = reader.GetValue(42)
                End If
                If Not (reader.IsDBNull(44)) Then
                    _Transaccion.IdAfp = reader.GetValue(44)
                End If
                lista.Add(_Transaccion)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteTransaccion(ByVal IdTransaccion As Integer) Implements ITransaccionRepository.DeleteTransaccion
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteTransaccion")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromTransaccion() As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionRepository.GetAllFromTransaccion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTRANSACCION")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTRANSACCIONByIdtransaccion(ByVal IdTransaccion As Integer) As BussinessEntities.Transaccion Implements ITransaccionRepository.GetTRANSACCIONByIdtransaccion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTRANSACCIONByIdtransaccion")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
    Public Function GetTRANSACCIONByAnioMes(ByVal anio As Integer, ByVal mes As Integer) As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionRepository.GetTRANSACCIONByAnioMes
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTRANSACCIONByAnioMes")
        command.Parameters.AddWithValue("anio", anio)
        command.Parameters.AddWithValue("mes", mes)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTRANSACCIONByAnioMesIdSubdiarioIdProveedorCliente(ByVal anio As Integer, ByVal mes As Integer, ByVal idSubDiario As Integer, ByVal idproveedorCliente As Integer) As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionRepository.GetTRANSACCIONByAnioMesIdSubdiarioIdProveedorCliente
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTRANSACCIONByAnioMesIdSubdiarioIdProveedorCliente")
        command.Parameters.AddWithValue("anio", anio)
        command.Parameters.AddWithValue("mes", mes)
        command.Parameters.AddWithValue("idSubDiario", idSubDiario)
        command.Parameters.AddWithValue("idProveedorCliente", idproveedorCliente)
        Return SelectObjectFactory(command)
    End Function

    Public Function SaveTransaccion(ByVal Transaccion As BussinessEntities.Transaccion) As Integer Implements ITransaccionRepository.SaveTransaccion
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveTransaccion")
        command.Parameters.AddWithValue("Anio", Transaccion.Anio)
        command.Parameters.AddWithValue("BaseImponible", Transaccion.BaseImponible)
        command.Parameters.AddWithValue("BaseInafecto", Transaccion.BaseInafecto)
        command.Parameters.AddWithValue("IdCtaBancaria", Transaccion.IdCtaBancaria)
        command.Parameters.AddWithValue("DiasVencimiento", Transaccion.DiasVencimiento)
        command.Parameters.AddWithValue("FechaContable", Transaccion.FechaContable)
        command.Parameters.AddWithValue("FechaDocRef", Transaccion.FechaDocRef)
        command.Parameters.AddWithValue("FechaDocumento", Transaccion.FechaDocumento)
        command.Parameters.AddWithValue("FechaVencimiento", Transaccion.FechaVencimiento)
        command.Parameters.AddWithValue("Glosa", Transaccion.Glosa)
        command.Parameters.AddWithValue("IdDetraccion", Transaccion.IdDetraccion)
        command.Parameters.AddWithValue("IdDocumentoCont", Transaccion.IdDocumentoCont)
        command.Parameters.AddWithValue("IdOpFinanciera", Transaccion.IdOpFinanciera)
        command.Parameters.AddWithValue("IdPersonal", Transaccion.IdPersonal)
        command.Parameters.AddWithValue("IdProveedorCliente", Transaccion.IdProveedorCliente)
        command.Parameters.AddWithValue("IdSubDiario", Transaccion.IdSubDiario)
        command.Parameters.AddWithValue("IdTipoBaseImp", Transaccion.IdTipoBaseImp)
        command.Parameters.AddWithValue("IdTipoDocRef", Transaccion.IdTipoDocRef)
        command.Parameters.AddWithValue("IdTransaccion", Transaccion.Idtransaccion)
        command.Parameters.AddWithValue("Mes", Transaccion.Mes)
        command.Parameters.AddWithValue("MontoIgv", Transaccion.MontoIgv)
        command.Parameters.AddWithValue("NroCheque", Transaccion.NroCheque)
        command.Parameters.AddWithValue("NroDocRef", Transaccion.NroDocRef)
        command.Parameters.AddWithValue("NroDocumento", Transaccion.NroDocumento)
        command.Parameters.AddWithValue("Otros", Transaccion.Otros)
        command.Parameters.AddWithValue("SerieDocumento", Transaccion.SerieDocumento)
        command.Parameters.AddWithValue("SerieDocRef", Transaccion.SerieDocRef)
        command.Parameters.AddWithValue("TipoCambioDocRef", Transaccion.TipoCambioDocRef)
        command.Parameters.AddWithValue("TipoCambio", Transaccion.TipoCambio)
        command.Parameters.AddWithValue("Total", Transaccion.Total)
        command.Parameters.AddWithValue("Usuario", Transaccion.Usuario)
        command.Parameters.AddWithValue("ValorIgv", Transaccion.ValorIgv)
        command.Parameters.AddWithValue("IdMoneda", Transaccion.IdMoneda)
        command.Parameters.AddWithValue("NroExoneracion", Transaccion.NroExoneracion)
        command.Parameters.AddWithValue("MontoRetencion", Transaccion.MontoRetencion)
        command.Parameters.AddWithValue("IdProyecto", Transaccion.IdProyecto)
        command.Parameters.AddWithValue("AfectoIgv", Transaccion.AfectoIgv)
        command.Parameters.AddWithValue("Flag", Transaccion.Flag)
        command.Parameters.AddWithValue("IdTipoMedioPago", Transaccion.IdTipoMedioPago)
        command.Parameters.AddWithValue("AfectoSistPen", Transaccion.AfectoSistPen)
        command.Parameters.AddWithValue("IdAfp", Transaccion.IdAfp)
        command.Parameters.AddWithValue("AporteAfp", Transaccion.AporteAfp)
        command.Parameters.AddWithValue("Comision", Transaccion.Comision)
        command.Parameters.AddWithValue("Seguro", Transaccion.Seguro)
        command.Parameters.AddWithValue("MontoSistPen", Transaccion.MontoSistPen)
        Dim i As Int32
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If

            End If
        End Using
        Return i
    End Function
    Public Sub UpdateEstadoTRANSACCION(ByVal IdTransaccion As Integer, ByVal Estado As String) Implements ITransaccionRepository.UpdateEstadoTRANSACCION
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoTRANSACCION")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        command.Parameters.AddWithValue("Estado", Estado)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetTRANSACCIONByAnioMesIdSubdiario(ByVal anio As Integer, ByVal mes As Integer, ByVal idSubDiario As Integer) As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionRepository.GetTRANSACCIONByAnioMesIdSubdiario
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTRANSACCIONByAnioMesIdSubdiario")
        command.Parameters.AddWithValue("anio", anio)
        command.Parameters.AddWithValue("mes", mes)
        command.Parameters.AddWithValue("idSubDiario", idSubDiario)
        Return SelectObjectFactory(command)
    End Function

    Public Function GenerarTRANSACCIONByIdRendicion(ByVal IdRendicion As Integer, ByVal idUser As Int32) As Integer Implements ITransaccionRepository.GenerarTRANSACCIONByIdRendicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarTRANSACCIONByIdRendicion")
        Dim Id As Int32
        command.Parameters.AddWithValue("IdRendicion", IdRendicion)
        command.Parameters.AddWithValue("idUser", idUser)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function

    Public Function GetTRANSACCIONByAnioMesIdSubdiarioFlag(ByVal anio As Integer, ByVal mes As Integer, ByVal idSubDiario As Integer, ByVal Flag As String) As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionRepository.GetTRANSACCIONByAnioMesIdSubdiarioFlag
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTRANSACCIONByAnioMesIdSubdiarioFlag")
        command.Parameters.AddWithValue("anio", anio)
        command.Parameters.AddWithValue("mes", mes)
        command.Parameters.AddWithValue("idSubDiario", idSubDiario)
        command.Parameters.AddWithValue("Flag", Flag)
        Return SelectObjectFactory(command)
    End Function

    Public Sub AnularTRANSACCIONCaja(ByVal IdTransaccion As Integer) Implements ITransaccionRepository.AnularTRANSACCIONCaja
        Dim command As SqlCommand = MyBase.CreateSPCommand("AnularTRANSACCIONCaja")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetTRANSACCIONByAnioMesIdSubdiarioCodigo(ByVal anio As Integer, ByVal mes As Integer, ByVal idSubDiario As Integer, ByVal Codigo As String) As BussinessEntities.Transaccion Implements ITransaccionRepository.GetTRANSACCIONByAnioMesIdSubdiarioCodigo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTRANSACCIONByAnioMesIdSubdiarioCodigo")
        command.Parameters.AddWithValue("anio", anio)
        command.Parameters.AddWithValue("mes", mes)
        command.Parameters.AddWithValue("idSubDiario", idSubDiario)
        command.Parameters.AddWithValue("codigo", Codigo)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GenerarTRANSACCIONDuplicada(ByVal IdTransaccion As Integer, ByVal fechaCOntable As Date, ByVal usuario As Integer, ByVal IdSubdiario As Int32) As Integer Implements ITransaccionRepository.GenerarTRANSACCIONDuplicada
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarTRANSACCIONDuplicada")
        Dim Id As Int32
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        command.Parameters.AddWithValue("fechaCOntable", fechaCOntable)
        command.Parameters.AddWithValue("usuario", usuario)
        command.Parameters.AddWithValue("idSubdiario", IdSubdiario)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)

            End If
        End Using
        Return Id
    End Function
    Public Sub UpdateMontosCCOSTO(ByVal Codigo As String, ByVal Monto As Decimal) Implements ITransaccionRepository.UpdateMontosCCOSTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateMontosCCOSTO")
        command.Parameters.AddWithValue("Codigo", Codigo)
        command.Parameters.AddWithValue("Monto", Monto)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function VerifyDisponibleCCOSTO(ByVal Codigo As String) As Decimal Implements ITransaccionRepository.VerifyDisponibleCCOSTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("VerifyDisponibleCCOSTO")
        Dim Disponible As Decimal
        command.Parameters.AddWithValue("Codigo", Codigo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Disponible = reader.GetValue(0)
            End If

        End Using
        Return Disponible
    End Function

    Public Function GetCCostoLINEA(ByVal registro As String, ByVal coa As String, ByVal cargo As Decimal) As String Implements ITransaccionRepository.GetCCostoLINEA
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCCostoLINEA")
        Dim ccosto As String = ""
        command.Parameters.AddWithValue("registro", registro)
        command.Parameters.AddWithValue("coa", coa)
        command.Parameters.AddWithValue("cargo", cargo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                ccosto = reader.GetValue(0)
            End If
        End Using
        Return ccosto
    End Function

    Public Function GetTRANSACCIONByAnioMesFlagCtaBancaria(ByVal anio As Integer, ByVal mes As Integer, ByVal Flag As String, ByVal IdCtaBancaria As Integer) As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionRepository.GetTRANSACCIONByAnioMesFlagCtaBancaria
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTRANSACCIONByAnioMesFlagCtaBancaria")
        command.Parameters.AddWithValue("anio", anio)
        command.Parameters.AddWithValue("mes", mes)
        command.Parameters.AddWithValue("IdCtaBancaria", IdCtaBancaria)
        command.Parameters.AddWithValue("Flag", Flag)
        Return SelectObjectFactory(command)
    End Function

    Public Sub GenerarDestinoDiario(ByVal IdTransaccion As Integer) Implements ITransaccionRepository.GenerarDestinoDiario
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarDestinoDiario")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Function GetTRANSACCIONESdeAnticiposEntregasPendientes() As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionRepository.GetTRANSACCIONESdeAnticiposEntregasPendientes
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTRANSACCIONESdeAnticiposEntregasPendientes")
        Return SelectObjectFactory(command)
    End Function

    Public Sub UpdateEnlaceTRANSACCION(ByVal IdTransaccion As Integer, ByVal Enlace As String) Implements ITransaccionRepository.UpdateEnlaceTRANSACCION
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEnlaceTRANSACCION")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        command.Parameters.AddWithValue("Enlace", Enlace)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetTRANSACCIONByAnioMesFlagIdproyecto(ByVal anio As Integer, ByVal mes As Integer, ByVal Flag As String, ByVal IdProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionRepository.GetTRANSACCIONByAnioMesFlagIdproyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTRANSACCIONByAnioMesFlagIdproyecto")
        command.Parameters.AddWithValue("anio", anio)
        command.Parameters.AddWithValue("mes", mes)
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        command.Parameters.AddWithValue("Flag", Flag)
        Return SelectObjectFactory(command)
    End Function

    Public Function GenerarTRANSACCIONRevertida(ByVal IdTransaccion As Integer, ByVal fechaCOntable As Date, ByVal usuario As Integer, ByVal IdSubdiario As Int32) As Integer Implements ITransaccionRepository.GenerarTRANSACCIONRevertida
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarTRANSACCIONRevertida")
        Dim Id As Int32
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        command.Parameters.AddWithValue("fechaCOntable", fechaCOntable)
        command.Parameters.AddWithValue("usuario", usuario)
        command.Parameters.AddWithValue("idSubdiario", IdSubdiario)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)

            End If
        End Using
        Return Id
    End Function

    Public Sub GenerarAjusteDifCambio(ByVal FechaContable As Date, ByVal anio As Integer, ByVal mes As Integer, ByVal usuario As Integer) Implements ITransaccionRepository.GenerarAjusteDifCambio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarAsientoAjusteDifCambio")
        command.Parameters.AddWithValue("FechaContable", FechaContable)
        command.Parameters.AddWithValue("anio", anio)
        command.Parameters.AddWithValue("mes", mes)
        command.Parameters.AddWithValue("usuario", usuario)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub GenerarAsientoApertura(ByVal FechaContable As Date, ByVal anio As Integer, ByVal mes As Integer, ByVal usuario As Integer) Implements ITransaccionRepository.GenerarAsientoApertura
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarAsientoApertura")
        command.Parameters.AddWithValue("FechaContable", FechaContable)
        command.Parameters.AddWithValue("anio", anio)
        command.Parameters.AddWithValue("mes", mes)
        command.Parameters.AddWithValue("usuario", usuario)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub GenerarAsientoCierre(ByVal FechaContable As Date, ByVal anio As Integer, ByVal mes As Integer, ByVal usuario As Integer) Implements ITransaccionRepository.GenerarAsientoCierre
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarAsientoCierre")
        command.Parameters.AddWithValue("FechaContable", FechaContable)
        command.Parameters.AddWithValue("anio", anio)
        command.Parameters.AddWithValue("mes", mes)
        command.Parameters.AddWithValue("usuario", usuario)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function VerifyExisteAjusteDifCambio(ByVal Anio As Integer, ByVal Mes As Integer) As Integer Implements ITransaccionRepository.VerifyExisteAjusteDifCambio
        Dim command As SqlCommand = MyBase.CreateSPCommand("VerifyExisteAjusteDifCambio")
        Dim Id As Int32
        command.Parameters.AddWithValue("Mes", Mes)
        command.Parameters.AddWithValue("Anio", Anio)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function

    Public Sub UpdateProyectoTRANSACCION(ByVal idTransaccion As Integer, ByVal proyecto As String) Implements ITransaccionRepository.UpdateProyectoTRANSACCION
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateProyectoTRANSACCION")
        command.Parameters.AddWithValue("IdTransaccion", idTransaccion)
        command.Parameters.AddWithValue("proyecto", proyecto)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GenerarTRANSACCIONordenCompra(ByVal IdOcxFactura As Integer, ByVal FechaContable As Date, ByVal Usuario As Integer) As Integer Implements ITransaccionRepository.GenerarTRANSACCIONordenCompra
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarTRANSACCIONordenCompra")
        Dim Id As Int32
        command.Parameters.AddWithValue("IdOcxFactura", IdOcxFactura)
        command.Parameters.AddWithValue("FechaContable", FechaContable)
        command.Parameters.AddWithValue("Usuario", Usuario)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)

            End If

        End Using
        Return Id
    End Function

    Public Sub UpdateMotivoOCxFactura(ByVal IdOcxFactura As Integer, ByVal motivo As String) Implements ITransaccionRepository.UpdateMotivoOCxFactura
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateMotivoOCxFactura")
        command.Parameters.AddWithValue("IdOcxFactura", IdOcxFactura)
        command.Parameters.AddWithValue("motivo", motivo)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub CancelarCtaXPagar(ByVal idTipoDoc As Integer, ByVal serie As String, ByVal numero As Long, ByVal idProveedor As Integer, ByVal estado As String) Implements ITransaccionRepository.CancelarCtaXPagar
        Dim command As SqlCommand = MyBase.CreateSPCommand("CancelarCtaXPagar")
        command.Parameters.AddWithValue("idTipoDoc", idTipoDoc)
        command.Parameters.AddWithValue("serie", serie)
        command.Parameters.AddWithValue("numero", numero)
        command.Parameters.AddWithValue("idProveedor", idProveedor)
        command.Parameters.AddWithValue("estado", estado)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub CancelarCtaXCobrar(ByVal idTipoDoc As Integer, ByVal serie As String, ByVal numero As Long, ByVal idProveedor As Integer, ByVal estado As String) Implements ITransaccionRepository.CancelarCtaXCobrar
        Dim command As SqlCommand = MyBase.CreateSPCommand("CancelarCtaXCobrar")
        command.Parameters.AddWithValue("idTipoDoc", idTipoDoc)
        command.Parameters.AddWithValue("serie", serie)
        command.Parameters.AddWithValue("numero", numero)
        command.Parameters.AddWithValue("idProveedor", idProveedor)
        command.Parameters.AddWithValue("estado", estado)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub CuadrarVoucher(ByVal IdTransaccion As Integer) Implements ITransaccionRepository.CuadrarVoucher
        Dim command As SqlCommand = MyBase.CreateSPCommand("CuadrarVoucher")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub CuadrarVoucherCaja(ByVal IdTransaccion As Integer) Implements ITransaccionRepository.CuadrarVoucherCaja
        Dim command As SqlCommand = MyBase.CreateSPCommand("CuadrarVoucherCaja")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub CuadrarVoucherDiario(ByVal IdTransaccion As Integer) Implements ITransaccionRepository.CuadrarVoucherDiario
        Dim command As SqlCommand = MyBase.CreateSPCommand("CuadrarVoucherDiario")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub GenerarLineaFondoFijo(ByVal IdTransaccion As Integer) Implements ITransaccionRepository.GenerarLineaFondoFijo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarLineaFondoFijo")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetTransaccionesSinProcesar(ByVal Anio As Integer, ByVal Mes As Integer) As System.Collections.Generic.List(Of BussinessEntities.Transaccion) Implements ITransaccionRepository.GetTransaccionesSinProcesar
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTransaccionesSinProcesar")
        command.Parameters.AddWithValue("anio", Anio)
        command.Parameters.AddWithValue("mes", Mes)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetSaldoTotalTransaccion(ByVal IdTransaccion As Integer) As Decimal Implements ITransaccionRepository.GetSaldoTotalTransaccion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetSaldoTotalTransaccion")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        Dim i As Decimal
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If

            End If
        End Using
        Return i
    End Function

    Public Function VerifyDocumentoDuplicado(ByVal Proveedor As Integer, ByVal Serie As String, ByVal Numero As Long, ByVal DocContable As Integer, ByVal IdTransaccion As Integer) As Integer Implements ITransaccionRepository.VerifyDocumentoDuplicado
        Dim command As SqlCommand = MyBase.CreateSPCommand("VerifyDocumentoDuplicado")
        Dim Id As Int32
        command.Parameters.AddWithValue("Proveedor", Proveedor)
        command.Parameters.AddWithValue("Serie", Serie)
        command.Parameters.AddWithValue("Numero", Numero)
        command.Parameters.AddWithValue("DocContable", DocContable)
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function

    Public Function VerifyDocumentoVentaDuplicado(ByVal Serie As String, ByVal Numero As Long, ByVal DocContable As Integer, ByVal IdTransaccion As Integer) As Integer Implements ITransaccionRepository.VerifyDocumentoVentaDuplicado
        Dim command As SqlCommand = MyBase.CreateSPCommand("VerifyDocumentoVentaDuplicado")
        Dim Id As Int32
        command.Parameters.AddWithValue("Serie", Serie)
        command.Parameters.AddWithValue("Numero", Numero)
        command.Parameters.AddWithValue("DocContable", DocContable)
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function

    Public Function VerifyDocumentoDuplicadoRendicion(ByVal Proveedor As Integer, ByVal Serie As String, ByVal Numero As Long, ByVal DocContable As Integer, ByVal IdDocumentoRendido As Integer) As Integer Implements ITransaccionRepository.VerifyDocumentoDuplicadoRendicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("VerifyDocumentoDuplicadoRendicion")
        Dim Id As Int32
        command.Parameters.AddWithValue("Proveedor", Proveedor)
        command.Parameters.AddWithValue("Serie", Serie)
        command.Parameters.AddWithValue("Numero", Numero)
        command.Parameters.AddWithValue("DocContable", DocContable)
        command.Parameters.AddWithValue("IdDocumentoRendido", IdDocumentoRendido)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function

    Public Function GenerarTRANSACCIONByIdVenta(ByVal IdVenta As Integer, ByVal IdUser As Integer, ByVal FechaContable As Date) As Integer Implements ITransaccionRepository.GenerarTRANSACCIONByIdVenta
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarTRANSACCIONByIdVenta")
        Dim Id As Int32
        command.Parameters.AddWithValue("IdVenta", IdVenta)
        command.Parameters.AddWithValue("FechaContable", FechaContable)
        command.Parameters.AddWithValue("IdUser", IdUser)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)

            End If

        End Using
        Return Id
    End Function

    Public Sub Send_EmailContabilidadTransferencia(ByVal IdTransaccion As Integer) Implements ITransaccionRepository.Send_EmailContabilidadTransferencia
        Dim command As SqlCommand = MyBase.CreateSPCommand("Send_EmailContabilidadTransferencia")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GenerarTRANSACCIONBajaSemovientes(ByVal IdTransaccion As Integer) As Integer Implements ITransaccionRepository.GenerarTRANSACCIONBajaSemovientes
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarTRANSACCIONBajaSemovientes")
        Dim Id As Int32
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)

            End If

        End Using
        Return Id
    End Function

    Public Sub Send_EmailContabilidadBajaGanado(ByVal IdTransaccion As Integer) Implements ITransaccionRepository.Send_EmailContabilidadBajaGanado
        Dim command As SqlCommand = MyBase.CreateSPCommand("Send_EmailContabilidadBajaGanado")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub GenerarAsientoDepreciacion(ByVal FechaContable As Date, ByVal anio As Integer, ByVal mes As Integer, ByVal usuario As Integer) Implements ITransaccionRepository.GenerarAsientoDepreciacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarAsientoDepreciacion")
        command.Parameters.AddWithValue("FechaContable", FechaContable)
        command.Parameters.AddWithValue("anio", anio)
        command.Parameters.AddWithValue("mes", mes)
        command.Parameters.AddWithValue("usuario", usuario)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub GenerarAsientoTraslado(ByVal FechaContable As Date, ByVal anio As Integer, ByVal mes As Integer, ByVal usuario As Integer) Implements ITransaccionRepository.GenerarAsientoTraslado
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarAsientoTraslado")
        command.Parameters.AddWithValue("FechaContable", FechaContable)
        command.Parameters.AddWithValue("anio", anio)
        command.Parameters.AddWithValue("mes", mes)
        command.Parameters.AddWithValue("usuario", usuario)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function VerifyExisteTransaccion(ByVal Proyecto As Integer, ByVal FechaDoc As Date, ByVal Proveedor As Integer, ByVal Total As Decimal) As Integer Implements ITransaccionRepository.VerifyExisteTransaccion
        Dim command As SqlCommand = MyBase.CreateSPCommand("VerifyExisteTransaccion")
        Dim Id As Int32
        command.Parameters.AddWithValue("Proyecto", Proyecto)
        command.Parameters.AddWithValue("FechaDoc", FechaDoc)
        command.Parameters.AddWithValue("Proveedor", Proveedor)
        command.Parameters.AddWithValue("Total", Total)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function

    Public Sub GenerarAsientoSemovientes(ByVal FechaContable As Date, ByVal IdUser As Integer) Implements ITransaccionRepository.GenerarAsientoSemovientes
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarAsientoSemovientes")
        command.Parameters.AddWithValue("FechaContable", FechaContable)
        command.Parameters.AddWithValue("usuario", IdUser)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
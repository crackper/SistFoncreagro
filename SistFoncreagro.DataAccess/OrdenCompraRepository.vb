Imports System.Data.Common
Imports System.Data.SqlClient
Imports SistFoncreagro.BussinessEntities

Public Class OrdenCompraRepository : Inherits MasterDataAccess : Implements IOrdenCompraRepository
    Dim moneda As IMonedaRepository
    Dim proveedor As IProveedorClienteRepository
    Dim requerimientoCom As IRequerimientoRepository
    Dim detOrdenCompra As IDetalleOrdenCompraRepository
    Dim persona As IPersonalRepository
    Sub New()
        moneda = New MonedaRepository
        proveedor = New ProveedorClienteRepository
        requerimientoCom = New RequerimientoRepository
        detOrdenCompra = New DetalleOrdenCompraRepository
        persona = New PersonalRepository
    End Sub

    Public Function GetAllFromOrdenCompraByIdComprador(ByVal idComprador As Integer) As System.Collections.Generic.List(Of BussinessEntities.OrdenCompra) Implements IOrdenCompraRepository.GetAllFromOrdenCompraByIdComprador
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromOrdenCompraByIdComprador")
        command.Parameters.AddWithValue("IdComprador", idComprador)
        Return SelectObjectFactoryFinal(command)
    End Function

    Public Function GetOrdenCompraByIdOrdenCompra(ByVal idOrdenCompra As Integer, ByVal detalle As Boolean) As BussinessEntities.OrdenCompra Implements IOrdenCompraRepository.GetOrdenCompraByIdOrdenCompra
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetOrdenCompraByIdOrdenCompra")
        command.Parameters.AddWithValue("IdOrdenCompra", idOrdenCompra)
        Return SelectObjectFactory(command, detalle).SingleOrDefault
    End Function

    Public Function GetAllFromOrdenCompraPorAprobarByIdResponsable(ByVal idResponsable As Integer) As System.Collections.Generic.List(Of BussinessEntities.OrdenCompra) Implements IOrdenCompraRepository.GetAllFromOrdenCompraPorAprobarByIdResponsable
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromOrdenCompraPorAprobar")
        command.Parameters.AddWithValue("IdResponsableAprobar", idResponsable)
        Return SelectObjectFactoryFinal(command)
    End Function

    Public Sub AprobarOrdenCompra(ByVal IdOrdenCompra As Integer, ByVal IdPersonal As Integer) Implements IOrdenCompraRepository.AprobarOrdenCompra
        Dim command As SqlCommand = MyBase.CreateSPCommand("AprobarOrdenCompraProceso")
        command.Parameters.AddWithValue("IdOrdenCompra", IdOrdenCompra)
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromOrdenCompraAprobadasEnviadasByIdComprador(ByVal IdComprador As Integer) As System.Collections.Generic.List(Of BussinessEntities.OrdenCompra) Implements IOrdenCompraRepository.GetAllFromOrdenCompraAprobadasEnviadasByIdComprador
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromOrdenCompraAprobadasEnviadasByIdComprador")
        command.Parameters.AddWithValue("IdComprador", IdComprador)
        Dim detalle As Boolean = False
        Return SelectObjectFactoryFinal(command)
    End Function

    Public Sub UpdateOcEnviarProveedor(ByVal idOrdenCompra As Integer, ByVal idLugarRecepcion As Integer, ByVal fechaEntregaEjecucion As Date) Implements IOrdenCompraRepository.UpdateOcEnviarProveedor
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateOcEnviarProveedor")
        command.Parameters.AddWithValue("IdOrdenCompra", idOrdenCompra)
        command.Parameters.AddWithValue("IdLugarRecepcion", idLugarRecepcion)
        command.Parameters.AddWithValue("Fecha", fechaEntregaEjecucion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromOrdenCompraEnviadasRecepcionadas() As System.Collections.Generic.List(Of BussinessEntities.OrdenCompra) Implements IOrdenCompraRepository.GetAllFromOrdenCompraEnviadasRecepcionadas
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromOrdenCompraEnviadasRecepcionadas")
        Return SelectObjectFactory(command, False)
    End Function
    Public Function GetAllFromOrdenCompraEnviadasRecepcionadasByTipo(ByVal tipo As String) As System.Collections.Generic.List(Of BussinessEntities.OrdenCompra) Implements IOrdenCompraRepository.GetAllFromOrdenCompraEnviadasRecepcionadasByTipo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromOrdenCompraEnviadasRecepcionadasByTipo")
        command.Parameters.AddWithValue("Tipo", tipo)
        Return SelectObjectFactoryFinal(command)
    End Function
    Public Sub AnularOrdenCompra(ByVal idOrdenCompra As Integer, ByVal idPersonal As Integer, ByVal Motivo As String, ByVal tipo As Integer) Implements IOrdenCompraRepository.AnularOrdenCompra
        Dim command As SqlCommand = MyBase.CreateSPCommand("AnularOrdenCompra")
        command.Parameters.AddWithValue("IdOrdenCompra", idOrdenCompra)
        command.Parameters.AddWithValue("IdPersonal", idPersonal)
        command.Parameters.AddWithValue("Motivo", Motivo)
        command.Parameters.AddWithValue("Tipo", tipo)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub UpdateOrdenCompra(ByVal ordenCompra As BussinessEntities.OrdenCompra) Implements IOrdenCompraRepository.UpdateOrdenCompra
        detOrdenCompra.UpdateDetalleOrdenCompra1(ordenCompra.detalleOrdenCompra)
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateOrdenCompra")
        command.Parameters.AddWithValue("IdOrdenCompra", ordenCompra.IdOrdenCompra)
        command.Parameters.AddWithValue("IdCotizacion", ordenCompra.IdCotizacion)
        command.Parameters.AddWithValue("IdMoneda", ordenCompra.IdMoneda)
        command.Parameters.AddWithValue("IdTipoPago", ordenCompra.IdTipoPago)
        command.Parameters.AddWithValue("IdTipoDocumento", ordenCompra.IdTipoDocumento)
        command.Parameters.AddWithValue("Anticipo", ordenCompra.Anticipo)
        command.Parameters.AddWithValue("Destino", ordenCompra.Destino)
        command.Parameters.AddWithValue("Observacion", ordenCompra.Observacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub SaveRecepcionOrdenCompra(ByVal ordenCompra As BussinessEntities.OrdenCompra, ByVal tipoRecepcion As Boolean) Implements IOrdenCompraRepository.SaveRecepcionOrdenCompra
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveRecepcionOrdenCompra")
        command.Parameters.AddWithValue("IdOrdenCompra", ordenCompra.IdOrdenCompra)
        command.Parameters.AddWithValue("IdPersonaRecepciona", ordenCompra.IdPersonaRecepciona)
        command.Parameters.AddWithValue("DocumentoReferencial", ordenCompra.DocumentoReferencial)
        command.Parameters.AddWithValue("Tipo", tipoRecepcion)
        detOrdenCompra.UpdateDetalleOrdenCompraRecepcion1(ordenCompra.detalleOrdenCompra)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromDetalleOrdenCompraByIdOrdenCompra(ByVal idOrdenCompra As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleOrdenCompra) Implements IOrdenCompraRepository.GetAllFromDetalleOrdenCompraByIdOrdenCompra
        Return detOrdenCompra.GetAllFromDetalleOrdenCompraByIdOrdenCompra(idOrdenCompra)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand, ByVal detalle As Boolean) As List(Of OrdenCompra)
        Dim listaOrdenCompra As New List(Of OrdenCompra)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim oCompra As New OrdenCompra()
                With oCompra
                    .IdOrdenCompra = reader.GetInt32(0)
                    .IdRequerimiento = reader.GetInt32(1)
                    .NumeroOrden = reader.GetString(2)
                    .Tipo = reader.GetString(3)
                    .IdRequeridoPor = reader.GetInt32(4)
                    .FechaGeneraOrden = reader.GetDateTime(5)
                    .Estado = reader.GetString(6)
                    .IdMoneda = reader.GetInt32(7)
                    .SubTotal = reader.GetDecimal(8)
                    .Igv = reader.GetDecimal(9)
                    .Total = reader.GetDecimal(10)
                    .IdProveedor = reader.GetInt32(11)
                    .IdComprador = reader.GetInt32(12)
                    .IdTipoPago = reader.GetInt32(13)
                    .Anticipo = reader.GetDecimal(14)
                    .ActivarCentroCosto = reader.GetBoolean(16)
                    .IgvPor = reader.GetDecimal(24)
                    .IdCotizacion = reader.GetInt32(25)
                    .Rechazado = reader.GetInt32(26)
                    .IdTipoDocumento = reader.GetInt32(27)
                End With
                If Not reader.IsDBNull(15) Then
                    oCompra.Observacion = reader.GetString(15)
                End If
                If Not reader.IsDBNull(17) Then
                    oCompra.FechaSolicitaAprobacion = reader.GetDateTime(17)
                End If
                If Not reader.IsDBNull(18) Then
                    oCompra.IdLugarRecepcion = reader.GetInt32(18)
                End If
                If Not reader.IsDBNull(19) Then
                    oCompra.FechaProbableEntrega = reader.GetDateTime(19)
                End If
                If Not reader.IsDBNull(20) Then
                    oCompra.FechaRecepcion = reader.GetDateTime(20)
                End If
                If Not reader.IsDBNull(21) Then
                    oCompra.IdPersonaRecepciona = reader.GetInt32(21)
                End If
                If Not reader.IsDBNull(22) Then
                    oCompra.IdResponsableAprobar = reader.GetInt32(22)
                End If
                If Not reader.IsDBNull(23) Then
                    oCompra.factura = reader.GetBoolean(23)
                End If
                If Not reader.IsDBNull(28) Then
                    oCompra.Destino = reader.GetString(28)
                End If
                oCompra.moneda = moneda.GetMonedaByIdMoneda(reader.GetInt32(7))
                oCompra.proveedor = proveedor.GetAllFromProveedorClienteById(reader.GetInt32(11))
                oCompra.requerimiento = requerimientoCom.GetAllFromRequerimientoByIdReq(reader.GetInt32(1))

                If detalle = True Then
                    oCompra.detalleOrdenCompra = detOrdenCompra.GetAllFromDetalleOrdenCompraByIdOrdenCompra(reader.GetInt32(0))
                End If
                listaOrdenCompra.Add(oCompra)
            End While
        End Using
        Return listaOrdenCompra
    End Function

    Private Function SelectObjectFactoryFinal(ByVal command As SqlCommand) As List(Of OrdenCompra)
        Dim listaOrdenCompra As New List(Of OrdenCompra)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim oCompra As New OrdenCompra()
                With oCompra
                    .IdOrdenCompra = reader.GetInt32(0)
                    .IdRequerimiento = reader.GetInt32(1)
                    .NumeroOrden = reader.GetString(2)
                    .Tipo = reader.GetString(3)
                    .IdRequeridoPor = reader.GetInt32(4)
                    .FechaGeneraOrden = reader.GetDateTime(5)
                    .Estado = reader.GetString(6)
                    .IdMoneda = reader.GetInt32(7)
                    .SubTotal = reader.GetDecimal(8)
                    .Igv = reader.GetDecimal(9)
                    .Total = reader.GetDecimal(10)
                    .IdProveedor = reader.GetInt32(11)
                    .IdComprador = reader.GetInt32(12)
                    .IdTipoPago = reader.GetInt32(13)
                    .Anticipo = reader.GetDecimal(14)
                    .ActivarCentroCosto = reader.GetBoolean(16)
                    .IgvPor = reader.GetDecimal(24)
                End With
                If Not reader.IsDBNull(15) Then
                    oCompra.Observacion = reader.GetString(15)
                End If
                If Not reader.IsDBNull(17) Then
                    oCompra.FechaSolicitaAprobacion = reader.GetDateTime(17)
                End If
                If Not reader.IsDBNull(18) Then
                    oCompra.IdLugarRecepcion = reader.GetInt32(18)
                End If
                If Not reader.IsDBNull(19) Then
                    oCompra.FechaProbableEntrega = reader.GetDateTime(19)
                End If
                If Not reader.IsDBNull(20) Then
                    oCompra.FechaRecepcion = reader.GetDateTime(20)
                End If
                If Not reader.IsDBNull(21) Then
                    oCompra.IdPersonaRecepciona = reader.GetInt32(21)
                End If
                If Not reader.IsDBNull(22) Then
                    oCompra.IdResponsableAprobar = reader.GetInt32(22)
                End If
                If Not reader.IsDBNull(23) Then
                    oCompra.factura = reader.GetBoolean(23)
                End If
                If Not reader.IsDBNull(25) Then
                    oCompra.CodigoAreaD = reader.GetString(25)
                End If
                If Not reader.IsDBNull(26) Then
                    oCompra.RazonSocialD = reader.GetString(26)
                End If
                If Not reader.IsDBNull(27) Then
                    oCompra.AbreviacionMonedaD = reader.GetString(27)
                End If
                If Not reader.IsDBNull(28) Then
                    oCompra.RequeridoPorD = reader.GetString(28)
                End If
                listaOrdenCompra.Add(oCompra)
            End While
        End Using
        Return listaOrdenCompra
    End Function

    Public Function GetAllFromOrdenCompraByIdResponsableAprobar(ByVal IdPersonaAprueba As Integer) As System.Collections.Generic.List(Of BussinessEntities.OrdenCompra) Implements IOrdenCompraRepository.GetAllFromOrdenCompraByIdResponsableAprobar
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromOrdenCompraByIdResponsableAprobar")
        command.Parameters.AddWithValue("IdResponsableAprobar", IdPersonaAprueba)
        Return SelectObjectFactoryFinal(command)
    End Function

    Public Function GetAllFromDetalleByIdCCosto(ByVal IdCcosto As Integer, ByVal IdOrden As Int32) As System.Collections.Generic.List(Of BussinessEntities.DetalleOrdenCompra) Implements IOrdenCompraRepository.GetAllFromDetalleByIdCCosto
        Return detOrdenCompra.GetAllFromDetalleByIdCCosto(IdCcosto, IdOrden)
    End Function

    Public Sub SolicitarAprobacion(ByVal idOrdenCompra As Integer, ByVal IdTipoPago As Integer, ByVal anticipo As Decimal) Implements IOrdenCompraRepository.SolicitarAprobacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("SolicitarAprobacionOrdenCompraProceso")
        command.Parameters.AddWithValue("IdOrdenCompra", idOrdenCompra)
        command.Parameters.AddWithValue("IdTipoPago", IdTipoPago)
        command.Parameters.AddWithValue("Anticipo", anticipo)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromOrdenCompra(ByVal parametro As String) As System.Collections.Generic.List(Of BussinessEntities.OrdenCompra) Implements IOrdenCompraRepository.GetAllFromOrdenCompra
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromOrdenCompraByParametro")
        command.Parameters.AddWithValue("Parametro", parametro)
        Return SelectObjectFactoryBuscar(command)
    End Function

    Private Function SelectObjectFactoryBuscar(ByVal command As SqlCommand) As List(Of OrdenCompra)
        Dim listaOrdenCompra As New List(Of OrdenCompra)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim oCompra As New OrdenCompra()
                With oCompra
                    .IdOrdenCompra = reader.GetInt32(0)
                    .NumeroOrden = reader.GetString(1)
                    .Tipo = reader.GetString(2)
                    .Estado = reader.GetString(3)
                End With
                listaOrdenCompra.Add(oCompra)
            End While
        End Using
        Return listaOrdenCompra
    End Function
End Class


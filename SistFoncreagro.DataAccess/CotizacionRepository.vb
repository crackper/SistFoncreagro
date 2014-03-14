Imports System.Data.Common
Imports System.Data.SqlClient
Imports SistFoncreagro.BussinessEntities

Public Class CotizacionRepository : Inherits MasterDataAccess : Implements ICotizacionRepository
    Dim detalleReqCotiRepository As IDetalleReqCotizacionRepository
    Dim persona As IPersonalRepository
    Sub New()
        detalleReqCotiRepository = New DetalleReqCotizacionRepository
        persona = New PersonalRepository
    End Sub
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Cotizacion)
        Dim listaCotizacion As New List(Of Cotizacion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                'IdCotizacion, IdComprador, IdTipoCotizacion, IdRequerimiento, IdMoneda, Nombre,
                'FechaRegistro, Estado, Observaciones
                Dim cotizacion As New Cotizacion()
                With cotizacion
                    .IdCotizacion = reader.GetInt32(0)
                    .IdComprador = reader.GetInt32(1)
                    .IdTipoCotizacion = reader.GetInt32(2)
                    .IdRequerimiento = reader.GetInt32(3)
                    .IdMoneda = reader.GetInt32(4)
                    .Nombre = reader.GetString(5)
                    .FechaRegistro = reader.GetDateTime(6)
                    .Estado = reader.GetString(7)
                    .NroRequerimiento = reader.GetString(9)
                    .CodigoArea = reader.GetString(10)
                    .IdRazon = reader.GetInt32(11)
                    .IdResponsable = reader.GetInt32(12)
                End With
                If Not (reader.IsDBNull(8)) Then
                    cotizacion.Observaciones = reader.GetString(8)
                End If
                cotizacion.comprador = persona.GetPersonalByIdPersonal(reader.GetInt32(1))
                listaCotizacion.Add(cotizacion)
            End While
        End Using
        Return listaCotizacion
    End Function

    Public Sub SaveCotizacion(ByVal coti As BussinessEntities.Cotizacion) Implements ICotizacionRepository.SaveCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCOTIZACION")

        Dim parametroBase As DbParameter = command.CreateParameter()
        parametroBase.ParameterName = "IdCotizacion"
        parametroBase.Direction = ParameterDirection.InputOutput
        parametroBase.Value = coti.IdCotizacion

        command.Parameters.Add(parametroBase)

        command.Parameters.AddWithValue("IdComprador", coti.IdComprador)
        command.Parameters.AddWithValue("IdTipoCotizacion", coti.IdTipoCotizacion)
        command.Parameters.AddWithValue("IdRequerimiento", coti.IdRequerimiento)
        command.Parameters.AddWithValue("IdMoneda", coti.IdMoneda)
        command.Parameters.AddWithValue("Nombre", coti.Nombre)
        MyBase.ExecuteNonQuery(command)

        coti.IdCotizacion = parametroBase.Value
        detalleReqCotiRepository.SaveDetalleReqCotizacion1(coti.detalleReqCoti, coti.IdCotizacion)
    End Sub

    Public Sub GenerarOrdenCompraOfIdCotizacion(ByVal idCotizacion As Integer) Implements ICotizacionRepository.GenerarOrdenCompraOfIdCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetGenerarOrdenCompraOfCotizacion")
        command.Parameters.AddWithValue("IdCotizacion", idCotizacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetFromCotizacionByIdCotizacion(ByVal idCotizacion As Integer) As BussinessEntities.Cotizacion Implements ICotizacionRepository.GetFromCotizacionByIdCotizacion
        Dim command As SqlCommand =
        MyBase.CreateSPCommand("GetFromCotizacionByIdCotizacion")
        command.Parameters.AddWithValue("IdCotizacion", idCotizacion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub UpdateCotizacion(ByVal cotizacion As BussinessEntities.Cotizacion) Implements ICotizacionRepository.UpdateCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateCotizacion")
        command.Parameters.AddWithValue("IdCotizacion", cotizacion.IdCotizacion)
        command.Parameters.AddWithValue("IdTipoCotizacion", cotizacion.IdTipoCotizacion)
        command.Parameters.AddWithValue("IdMoneda", cotizacion.IdMoneda)
        command.Parameters.AddWithValue("Nombre", cotizacion.Nombre)
        command.Parameters.AddWithValue("Observaciones", cotizacion.Observaciones)
        command.Parameters.AddWithValue("IdRazon", cotizacion.IdRazon)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromDetalleRequerimientoCotizacionByIdDetReqCot(ByVal idCotizacion As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleReqCotizacion) Implements ICotizacionRepository.GetAllFromDetalleRequerimientoCotizacionByIdDetReqCot
        Dim detalleReqCotizacion As New DetalleReqCotizacionRepository
        Return detalleReqCotizacion.GetAllDetalleRequerimientoCotizacionByIdCotizacion(idCotizacion)
    End Function

    Public Function GetAllFromCotizacionesByIdComprador(ByVal idComprador As Integer) As System.Collections.Generic.List(Of BussinessEntities.Cotizacion) Implements ICotizacionRepository.GetAllFromCotizacionesByIdComprador
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCotizacionByIdComprador")
        command.Parameters.AddWithValue("IdComprador", idComprador)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetAllFromCotizacionesByIdResponsable(ByVal idResponsable As Integer) As System.Collections.Generic.List(Of BussinessEntities.Cotizacion) Implements ICotizacionRepository.GetAllFromCotizacionesByIdResponsable
        'Function GetAllFromCotizacionesByIdResponsable(ByVal idResponsable As Int32) As List(Of Cotizacion)
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCotizacionesByIdResponsable")
        command.Parameters.AddWithValue("IdResponsable", idResponsable)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveItemDetalleReqCotizacon(ByVal detalleReqCoti As BussinessEntities.DetalleReqCotizacion) Implements ICotizacionRepository.SaveItemDetalleReqCotizacon
        Dim detalleReqCotizacion As New DetalleReqCotizacionRepository
        detalleReqCotizacion.SaveItemDetalleReqCotizacon(detalleReqCoti)
    End Sub

    Public Sub DeleteItemDetalleReqCotizacion(ByVal IdDetalleReqCotizacion As Integer) Implements ICotizacionRepository.DeleteItemDetalleReqCotizacion
        Dim detalleReqCotizacion As New DetalleReqCotizacionRepository
        detalleReqCotizacion.DeleteItemDetalleReqCotizacion(IdDetalleReqCotizacion)
    End Sub

    Public Sub FinalizarCotizacion(ByVal IdContizacion As Integer) Implements ICotizacionRepository.FinalizarCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("FinalizarCotizacion")
        command.Parameters.AddWithValue("IdCotizacion", IdContizacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub ModificarCotizacionCompleta(ByVal IdContizacion As Integer) Implements ICotizacionRepository.ModificarCotizacionCompleta
        Dim command As SqlCommand = MyBase.CreateSPCommand("ModificarCotizacionCompleta")
        command.Parameters.AddWithValue("IdCotizacion", IdContizacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub AnularCotizacion(ByVal IdContizacion As Integer) Implements ICotizacionRepository.AnularCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("AnularCotización")
        command.Parameters.AddWithValue("IdCotizacion", IdContizacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub SolicitarAprobacionSoulSource(ByVal IdContizacion As Integer, ByVal IdRazon As Integer) Implements ICotizacionRepository.SolicitarAprobacionSoulSource
        Dim command As SqlCommand = MyBase.CreateSPCommand("SolicitarAprobacionSoulSource")
        command.Parameters.AddWithValue("IdCotizacion", IdContizacion)
        command.Parameters.AddWithValue("IdRazon", IdRazon)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub AprobarSoulSource(ByVal IdContizacion As Integer, ByVal IdPersonal As Integer) Implements ICotizacionRepository.AprobarSoulSource
        Dim command As SqlCommand = MyBase.CreateSPCommand("AprobarSoulSource")
        command.Parameters.AddWithValue("IdCotizacion", IdContizacion)
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub AnularSoulSource(ByVal IdContizacion As Integer, ByVal IdPersonal As Integer) Implements ICotizacionRepository.AnularSoulSource
        Dim command As SqlCommand = MyBase.CreateSPCommand("AnularSoleSource")
        command.Parameters.AddWithValue("IdCotizacion", IdContizacion)
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
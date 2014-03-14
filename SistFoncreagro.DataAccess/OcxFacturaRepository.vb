Imports System.Data.Common
Imports System.Data.SqlClient
Imports SistFoncreagro.BussinessEntities
Public Class OcxFacturaRepository : Inherits MasterDataAccess : Implements IOcxFacturaRepository
    Public Function GetAllFromOcxFacturaById(ByVal IdOcxFactura As Integer) As BussinessEntities.OcxFactura Implements IOcxFacturaRepository.GetAllFromOcxFacturaById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromOcxFacturaById")
        command.Parameters.AddWithValue("IdOcxFactura", IdOcxFactura)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
    Public Function GetAllFromOcxFacturaByIdOrdenCompra(ByVal IdOrdenCompra As Integer) As System.Collections.Generic.List(Of BussinessEntities.OcxFactura) Implements IOcxFacturaRepository.GetAllFromOcxFacturaByIdOrdenCompra
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromOcxFacturaByIdOrdenCompra")
        command.Parameters.AddWithValue("IdOrdenCompra", IdOrdenCompra)
        Return SelectObjectFactory(command)
    End Function
    Public Sub SaveOcxFactura(ByVal ocFac As BussinessEntities.OcxFactura) Implements IOcxFacturaRepository.SaveOcxFactura
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveOcxFactura")
        command.Parameters.AddWithValue("IdOrdenCompra", ocFac.IdOrdenCompra)
        command.Parameters.AddWithValue("Serie", ocFac.Serie)
        command.Parameters.AddWithValue("Numero", ocFac.Numero)
        command.Parameters.AddWithValue("Monto", ocFac.Monto)
        command.Parameters.AddWithValue("Fecha", ocFac.Fecha)
        command.Parameters.AddWithValue("FechaRecepcion", ocFac.FechaRecepcion)
        command.Parameters.AddWithValue("IdTipoDocumento", ocFac.IdTipoDocumento)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Sub UpdateOcxFactura(ByVal ocFac As BussinessEntities.OcxFactura) Implements IOcxFacturaRepository.UpdateOcxFactura
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateOcxFactura")
        command.Parameters.AddWithValue("IdOcxFactura", ocFac.IdOrdenCompra)
        command.Parameters.AddWithValue("IdOrdenCompra", ocFac.IdOrdenCompra)
        command.Parameters.AddWithValue("Serie", ocFac.Serie)
        command.Parameters.AddWithValue("Numero", ocFac.Numero)
        command.Parameters.AddWithValue("Monto", ocFac.Monto)
        command.Parameters.AddWithValue("Fecha", ocFac.Fecha)
        command.Parameters.AddWithValue("FechaRecepcion", ocFac.FechaRecepcion)
        command.Parameters.AddWithValue("IdTipoDocumento", ocFac.IdTipoDocumento)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of OcxFactura)
        Dim lista As New List(Of OcxFactura)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim ocFact As New OcxFactura() With
                    {.IdOcxFactura = reader.GetInt32(0),
                     .IdOrdenCompra = reader.GetInt32(1),
                     .Serie = reader.GetString(2),
                     .Numero = reader.GetString(3),
                     .Monto = reader.GetDecimal(4),
                     .Fecha = reader.GetDateTime(5),
                     .IdTipoDocumento = reader.GetInt32(6),
                     .NroOrden = reader.GetString(7),
                     .Area = reader.GetString(8),
                     .NombreTipoDoc = reader.GetString(9),
                     .TipoRendicion = reader.GetInt32(10)
                    }
                lista.Add(ocFact)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeletaOcxFactura(ByVal IdOcxFac As Integer) Implements IOcxFacturaRepository.DeletaOcxFactura
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeletaOcxFactura")
        command.Parameters.AddWithValue("IdOcxFactura", IdOcxFac)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Sub RechazarOcxFactura(ByVal IdOcxFac As Integer, ByVal motivo As String) Implements IOcxFacturaRepository.RechazarOcxFactura
        Dim command As SqlCommand = MyBase.CreateSPCommand("RechazarOcxFactura")
        command.Parameters.AddWithValue("IdOcxFactura", IdOcxFac)
        command.Parameters.AddWithValue("Motivo", motivo)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Function SaveOcxFacturaComprobante(ByVal ocFac As BussinessEntities.OcxFactura) As Integer Implements IOcxFacturaRepository.SaveOcxFacturaComprobante
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveOcxFacturaComprobante")
        Dim parametroBase As DbParameter = command.CreateParameter()
        parametroBase.ParameterName = "IdOcxFactura"
        parametroBase.Direction = ParameterDirection.InputOutput
        parametroBase.Value = ocFac.IdOcxFactura
        command.Parameters.Add(parametroBase)
        command.Parameters.AddWithValue("Serie", ocFac.Serie)
        command.Parameters.AddWithValue("Numero", ocFac.Numero)
        command.Parameters.AddWithValue("Monto", ocFac.Monto)
        command.Parameters.AddWithValue("Fecha", ocFac.Fecha)
        command.Parameters.AddWithValue("IdTipoDocumento", ocFac.IdTipoDocumento)
        command.Parameters.AddWithValue("IdArea", ocFac.IdArea)
        command.Parameters.AddWithValue("IdProveedor", ocFac.IdProveedor)
        command.Parameters.AddWithValue("IdMoneda", ocFac.IdMoneda)
        command.Parameters.AddWithValue("NroVales", ocFac.NroVales)
        command.Parameters.AddWithValue("Observaciones", ocFac.Observaciones)
        command.Parameters.AddWithValue("FechaRecepcion", ocFac.FechaRecepcion)
        MyBase.ExecuteNonQuery(command)
        ocFac.IdOcxFactura = parametroBase.Value
        Return ocFac.IdOcxFactura
    End Function
    Public Function UpdateOcxFacturaComprobante(ByVal ocFac As BussinessEntities.OcxFactura) As Integer Implements IOcxFacturaRepository.UpdateOcxFacturaComprobante
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateOcxFacturaComprobante")
        Dim parametroBase As DbParameter = command.CreateParameter()
        parametroBase.ParameterName = "Respuesta"
        parametroBase.Direction = ParameterDirection.InputOutput
        parametroBase.Value = ocFac.IdOcxFactura
        command.Parameters.Add(parametroBase)
        command.Parameters.AddWithValue("IdOcxFactura", ocFac.IdOcxFactura)
        command.Parameters.AddWithValue("Serie", ocFac.Serie)
        command.Parameters.AddWithValue("Numero", ocFac.Numero)
        command.Parameters.AddWithValue("Monto", ocFac.Monto)
        command.Parameters.AddWithValue("Fecha", ocFac.Fecha)
        command.Parameters.AddWithValue("IdTipoDocumento", ocFac.IdTipoDocumento)
        command.Parameters.AddWithValue("IdArea", ocFac.IdArea)
        command.Parameters.AddWithValue("IdProveedor", ocFac.IdProveedor)
        command.Parameters.AddWithValue("IdMoneda", ocFac.IdMoneda)
        command.Parameters.AddWithValue("NroVales", ocFac.NroVales)
        command.Parameters.AddWithValue("Observaciones", ocFac.Observaciones)
        command.Parameters.AddWithValue("FechaRecepcion", ocFac.FechaRecepcion)
        MyBase.ExecuteNonQuery(command)
        ocFac.IdOcxFactura = parametroBase.Value
        Return ocFac.IdOcxFactura
    End Function
    Public Function GetAllFromOcxFacturaComprobante() As System.Collections.Generic.List(Of BussinessEntities.OcxFactura) Implements IOcxFacturaRepository.GetAllFromOcxFacturaComprobante
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromOcxFacturaComprobante")
        Return SelectObjectFactoryComprobante(command)
    End Function
    Private Function SelectObjectFactoryComprobante(ByVal command As SqlCommand) As List(Of OcxFactura)
        Dim lista As New List(Of OcxFactura)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim ocFact As New OcxFactura() With
                    {.IdOcxFactura = reader.GetInt32(0),
                     .Serie = reader.GetString(1),
                     .Numero = reader.GetString(2),
                     .Monto = reader.GetDecimal(3),
                     .Fecha = reader.GetDateTime(4),
                     .Finalizado = reader.GetBoolean(5),
                     .IdArea = reader.GetInt32(6),
                     .IdProveedor = reader.GetInt32(7),
                     .IdMoneda = reader.GetInt32(8),
                     .NroVales = reader.GetInt32(9),
                     .Observaciones = reader.GetString(10),
                     .NombreTipoDoc = reader.GetString(11),
                     .NombreArea = reader.GetString(12),
                     .NombreProveedor = reader.GetString(13),
                     .NroOrden = reader.GetString(14),
                     .IdTipoDocumento = reader.GetInt32(15),
                     .FechaRecepcion = reader.GetDateTime(16)
                    }
                lista.Add(ocFact)
            End While
        End Using
        Return lista
    End Function

    Public Function FinalizarRegistroComprobante(ByVal IdOcxFac As Integer) As Integer Implements IOcxFacturaRepository.FinalizarRegistroComprobante
        Dim command As SqlCommand = MyBase.CreateSPCommand("FinalizarRegistroComprobante")
        Dim parametroBase As DbParameter = command.CreateParameter()
        Dim respuesta As Int32
        parametroBase.ParameterName = "Respuesta"
        parametroBase.Direction = ParameterDirection.InputOutput
        parametroBase.Value = respuesta
        command.Parameters.Add(parametroBase)
        command.Parameters.AddWithValue("IdOcxFactura", IdOcxFac)
        MyBase.ExecuteNonQuery(command)
        respuesta = parametroBase.Value
        Return respuesta
    End Function
End Class

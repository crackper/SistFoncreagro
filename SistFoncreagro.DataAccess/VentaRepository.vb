Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class VentaRepository : Inherits MasterDataAccess : Implements IVentaRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Venta)
        Dim lista As New List(Of Venta)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Venta As New Venta() With
                {
                 .IdVenta = reader.GetValue(0),
                 .IdTipoDocumento = reader.GetValue(1),
                 .FechaDocumento = reader.GetValue(2),
                .IdProyecto = reader.GetValue(5),
                 .IdProveedorCliente = reader.GetValue(6),
                 .TipoPago = reader.GetValue(7),
                 .IdTipoVenta = reader.GetValue(8),
                 .AfectoIGV = reader.GetValue(9),
                 .Estado = reader.GetValue(10),
                 .Modalidad = reader.GetValue(12),
                  .IdUsuario = reader.GetValue(15),
                  .Transferencia = reader.GetValue(17),
                 .ValorIGV = reader.GetValue(19),
                 .PrecioConIGV = reader.GetValue(21)
                }
                If Not (reader.IsDBNull(3)) Then
                    _Venta.NroSerie = reader.GetValue(3)
                End If
                If Not (reader.IsDBNull(4)) Then
                    _Venta.NroDocumento = reader.GetValue(4)
                End If
                If Not (reader.IsDBNull(11)) Then
                    _Venta.NroNotaInterna = reader.GetValue(11)
                End If
                If Not (reader.IsDBNull(13)) Then
                    _Venta.IdBanco = reader.GetValue(13)
                End If
                If Not (reader.IsDBNull(14)) Then
                    _Venta.NroVoucher = reader.GetValue(14)
                End If
                If Not (reader.IsDBNull(16)) Then
                    _Venta.Referencia = reader.GetValue(16)
                End If
                If Not (reader.IsDBNull(18)) Then
                    _Venta.FlagVentaAnimales = reader.GetValue(18)
                End If
                If Not (reader.IsDBNull(20)) Then
                    _Venta.Observacion = reader.GetValue(20)
                End If
                If Not (reader.IsDBNull(22)) Then
                    _Venta.Observacion1 = reader.GetValue(22)
                End If
                lista.Add(_Venta)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeleteVENTA(ByVal IdVenta As Integer) Implements IVentaRepository.DeleteVENTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteVENTA")
        command.Parameters.AddWithValue("IdVenta", IdVenta)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetVENTAByAnio(ByVal Anio As Integer) As System.Collections.Generic.List(Of BussinessEntities.Venta) Implements IVentaRepository.GetVENTAByAnio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetVENTAByAnio")
        command.Parameters.AddWithValue("Anio", Anio)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetVENTAByEstado(ByVal Estado As String) As System.Collections.Generic.List(Of BussinessEntities.Venta) Implements IVentaRepository.GetVENTAByEstado
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetVENTAByEstado")
        command.Parameters.AddWithValue("Estado", Estado)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetVENTAByIdVenta(ByVal IdVenta As Integer) As BussinessEntities.Venta Implements IVentaRepository.GetVENTAByIdVenta
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetVENTAByIdVenta")
        command.Parameters.AddWithValue("IdVenta", IdVenta)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveVENTA(ByVal _Venta As BussinessEntities.Venta) As Integer Implements IVentaRepository.SaveVENTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveVENTA")
        command.Parameters.AddWithValue("AfectoIGV", _Venta.AfectoIGV)
        command.Parameters.AddWithValue("Estado", _Venta.Estado)
        command.Parameters.AddWithValue("FechaDocumento", _Venta.FechaDocumento)
        command.Parameters.AddWithValue("IdBanco", _Venta.IdBanco)
        command.Parameters.AddWithValue("IdProveedorCliente", _Venta.IdProveedorCliente)
        command.Parameters.AddWithValue("IdProyecto", _Venta.IdProyecto)
        command.Parameters.AddWithValue("IdTipoDocumento", _Venta.IdTipoDocumento)
        command.Parameters.AddWithValue("IdTipoVenta", _Venta.IdTipoVenta)
        command.Parameters.AddWithValue("IdUsuario", _Venta.IdUsuario)
        command.Parameters.AddWithValue("IdVenta", _Venta.IdVenta)
        command.Parameters.AddWithValue("Modalidad", _Venta.Modalidad)
        command.Parameters.AddWithValue("NroNotaInterna", _Venta.NroNotaInterna)
        command.Parameters.AddWithValue("NroVoucher", _Venta.NroVoucher)
        command.Parameters.AddWithValue("TipoPago", _Venta.TipoPago)
        command.Parameters.AddWithValue("Transferencia", _Venta.Transferencia)
        command.Parameters.AddWithValue("Referencia", _Venta.Referencia)
        command.Parameters.AddWithValue("FlagVentaAnimales", _Venta.FlagVentaAnimales)
        command.Parameters.AddWithValue("ValorIGV", _Venta.ValorIGV)
        command.Parameters.AddWithValue("Observacion", _Venta.Observacion)
        command.Parameters.AddWithValue("PrecioConIGV", _Venta.PrecioConIGV)
        command.Parameters.AddWithValue("Observacion1", _Venta.Observacion1)
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

    Public Sub UpdateEstadoVENTA(ByVal IdVenta As Integer, ByVal Estado As String) Implements IVentaRepository.UpdateEstadoVENTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoVENTA")
        command.Parameters.AddWithValue("IdVenta", IdVenta)
        command.Parameters.AddWithValue("Estado", Estado)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub GenerarComprobanteVenta(ByVal IdVenta As Integer, ByVal IdProyecto As Integer, ByVal IdTipoDocumento As Integer) Implements IVentaRepository.GenerarComprobanteVenta
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarComprobanteVenta")
        command.Parameters.AddWithValue("IdVenta", IdVenta)
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        command.Parameters.AddWithValue("IdTipoDocumento", IdTipoDocumento)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub UpdateIgvVenta(ByVal IdCatVenta As Integer, ByVal IdVenta As Integer) Implements IVentaRepository.UpdateIgvVenta
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateIgvVenta")
        command.Parameters.AddWithValue("IdVenta", IdVenta)
        command.Parameters.AddWithValue("IdCatVenta", IdCatVenta)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub UpdateObservacionVENTA(ByVal IdVenta As Integer, ByVal Observacion As String) Implements IVentaRepository.UpdateObservacionVENTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateObservacionVENTA")
        command.Parameters.AddWithValue("IdVenta", IdVenta)
        command.Parameters.AddWithValue("Observacion", Observacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function VerifyVentaTituloGratuito(ByVal serie As String, ByVal numero As Integer, ByVal tipo As Integer) As String Implements IVentaRepository.VerifyVentaTituloGratuito
        Dim command As SqlCommand = MyBase.CreateSPCommand("VerifyVentaTituloGratuito")
        command.Parameters.AddWithValue("serie", serie)
        command.Parameters.AddWithValue("numero", numero)
        command.Parameters.AddWithValue("tipo", tipo)
        Dim i As String
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If

            End If
        End Using
        Return i
    End Function

    Public Function VerifyVentaSemovientes(ByVal serie As String, ByVal numero As Integer, ByVal tipo As Integer) As String Implements IVentaRepository.VerifyVentaSemovientes
        Dim command As SqlCommand = MyBase.CreateSPCommand("VerifyVentaSemovientes")
        command.Parameters.AddWithValue("serie", serie)
        command.Parameters.AddWithValue("numero", numero)
        command.Parameters.AddWithValue("tipo", tipo)
        Dim i As String
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If

            End If
        End Using
        Return i
    End Function

    Public Sub GenerarAsientoTraslado(ByVal FechaContable As Date, ByVal anio As Integer, ByVal mes As Integer, ByVal usuario As Integer) Implements IVentaRepository.GenerarAsientoTraslado
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarAsientoTraslado")
        command.Parameters.AddWithValue("FechaContable", FechaContable)
        command.Parameters.AddWithValue("anio", anio)
        command.Parameters.AddWithValue("mes", mes)
        command.Parameters.AddWithValue("usuario", usuario)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class

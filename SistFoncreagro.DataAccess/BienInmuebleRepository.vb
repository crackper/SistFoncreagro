Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class BienInmuebleRepository : Inherits MasterDataAccess : Implements IBienInmuebleRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of BienInmueble)
        Dim lista As New List(Of BienInmueble)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _BienInmueble As New BienInmueble() With
                {
                    .IdBienInmueble = reader.GetValue(0),
                    .Nombre = reader.GetValue(1),
                    .FechaCompra = reader.GetValue(5),
                    .ValorCompra = reader.GetValue(6),
                    .IdProyecto = reader.GetValue(7),
                    .AreaTotal = reader.GetValue(10),
                    .AreaConstruida = reader.GetValue(11),
                    .IdTipo = reader.GetValue(12),
                    .IdMoneda = reader.GetValue(13),
                    .Estado = reader.GetValue(14),
                    .TipoCambio = reader.GetValue(15)
                }
                If Not (reader.IsDBNull(2)) Then
                    _BienInmueble.IdUbigeo = reader.GetValue(2)
                End If
                If Not (reader.IsDBNull(3)) Then
                    _BienInmueble.Direccion = reader.GetValue(3)
                End If
                If Not (reader.IsDBNull(4)) Then
                    _BienInmueble.Observacion = reader.GetValue(4)
                End If
                If Not (reader.IsDBNull(8)) Then
                    _BienInmueble.IdCCosto = reader.GetValue(8)
                End If
                If Not (reader.IsDBNull(9)) Then
                    _BienInmueble.IdProveedorCliente = reader.GetValue(9)
                End If

                lista.Add(_BienInmueble)
            End While
        End Using
        Return lista
    End Function

    Public Function GetBIENINMUEBLEByIdBienInmueble(ByVal IdBienInmueble As Integer) As BussinessEntities.BienInmueble Implements IBienInmuebleRepository.GetBIENINMUEBLEByIdBienInmueble
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetBIENINMUEBLEByIdBienInmueble")
        command.Parameters.AddWithValue("IdBienInmueble", IdBienInmueble)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveBIENINMUEBLE(ByVal _BienInmueble As BussinessEntities.BienInmueble) As Integer Implements IBienInmuebleRepository.SaveBIENINMUEBLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveBIENINMUEBLE")
        command.Parameters.AddWithValue("AreaConstruida", _BienInmueble.AreaConstruida)
        command.Parameters.AddWithValue("AreaTotal", _BienInmueble.AreaTotal)
        command.Parameters.AddWithValue("Direccion", _BienInmueble.Direccion)
        command.Parameters.AddWithValue("FechaCompra", _BienInmueble.FechaCompra)
        command.Parameters.AddWithValue("IdBienInmueble", _BienInmueble.IdBienInmueble)
        command.Parameters.AddWithValue("IdCCosto", _BienInmueble.IdCCosto)
        command.Parameters.AddWithValue("IdMoneda", _BienInmueble.IdMoneda)
        command.Parameters.AddWithValue("IdProveedorCliente", _BienInmueble.IdProveedorCliente)
        command.Parameters.AddWithValue("IdProyecto", _BienInmueble.IdProyecto)
        command.Parameters.AddWithValue("IdTipo", _BienInmueble.IdTipo)
        command.Parameters.AddWithValue("IdUbigeo", _BienInmueble.IdUbigeo)
        command.Parameters.AddWithValue("Nombre", _BienInmueble.Nombre)
        command.Parameters.AddWithValue("Observacion", _BienInmueble.Observacion)
        command.Parameters.AddWithValue("ValorCompra", _BienInmueble.ValorCompra)
        command.Parameters.AddWithValue("TipoCambio", _BienInmueble.TipoCambio)

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
    Public Sub UpdateEstadoBIENINMUEBLE(ByVal IdBienInmueble As Integer, ByVal Estado As String) Implements IBienInmuebleRepository.UpdateEstadoBIENINMUEBLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoBIENINMUEBLE")
        command.Parameters.AddWithValue("IdBienInmueble", IdBienInmueble)
        command.Parameters.AddWithValue("Estado", Estado)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class

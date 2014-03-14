Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class BienMuebleRepository : Inherits MasterDataAccess : Implements IBienMuebleRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of BIENMUEBLE)
        Dim lista As New List(Of BIENMUEBLE)
        Dim CatalogoRepository As New CatalogoRepository
        Dim AreaRepository As New ProyectoRepository

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _BIENMUEBLE As New BIENMUEBLE() With
                {
                    .IdBienMueble = reader.GetValue(0),
                    .Codigo = reader.GetValue(1),
                    .Tipo = reader.GetValue(2),
                    .IdCatalogo = reader.GetValue(3),
                    .IdPlanCuenta = reader.GetValue(4),
                    .IdProyecto = reader.GetValue(7),
                    .FechaIngreso = reader.GetValue(9),
                    .Costo = reader.GetValue(10),
                    .Estado = reader.GetValue(11),
                    .IdOficina = reader.GetValue(24),
                    .IdUsuario = reader.GetValue(26),
                    .Donacion = reader.GetValue(27),
                    .Validado = reader.GetValue(28),
                    .Conservacion = reader.GetValue(29)
                }
                If Not (reader.IsDBNull(5)) Then
                    _BIENMUEBLE.IdPlanDepreciacion = reader.GetValue(5)
                End If
                If Not (reader.IsDBNull(6)) Then
                    _BIENMUEBLE.IdPlanDepreciacion1 = reader.GetValue(6)
                End If
                If Not (reader.IsDBNull(8)) Then
                    _BIENMUEBLE.IdCCosto = reader.GetValue(8)
                End If
                If Not (reader.IsDBNull(12)) Then
                    _BIENMUEBLE.IdProveedorCliente = reader.GetValue(12)
                End If
                If Not (reader.IsDBNull(13)) Then
                    _BIENMUEBLE.Descripcion = reader.GetValue(13)
                End If
                If Not (reader.IsDBNull(14)) Then
                    _BIENMUEBLE.IdTipoDocumento = reader.GetValue(14)
                End If
                If Not (reader.IsDBNull(15)) Then
                    _BIENMUEBLE.NroDocumento = reader.GetValue(15)
                End If
                If Not (reader.IsDBNull(16)) Then
                    _BIENMUEBLE.SerieDocumento = reader.GetValue(16)
                End If
                If Not (reader.IsDBNull(17)) Then
                    _BIENMUEBLE.IdMarca = reader.GetValue(17)
                End If
                If Not (reader.IsDBNull(18)) Then
                    _BIENMUEBLE.Modelo = reader.GetValue(18)
                End If
                If Not (reader.IsDBNull(19)) Then
                    _BIENMUEBLE.Serie = reader.GetValue(19)
                End If
                If Not (reader.IsDBNull(20)) Then
                    _BIENMUEBLE.Color = reader.GetValue(20)
                End If
                If Not (reader.IsDBNull(21)) Then
                    _BIENMUEBLE.Motor = reader.GetValue(21)
                End If
                If Not (reader.IsDBNull(22)) Then
                    _BIENMUEBLE.Placa = reader.GetValue(22)
                End If
                If Not (reader.IsDBNull(23)) Then
                    _BIENMUEBLE.Otro = reader.GetValue(23)
                End If
                If Not (reader.IsDBNull(25)) Then
                    _BIENMUEBLE.IdBienPadre = reader.GetValue(25)
                End If
                If Not (reader.IsDBNull(30)) Then
                    _BIENMUEBLE.CodigoReferencia = reader.GetValue(30)
                End If
                _BIENMUEBLE.Catalogo = CatalogoRepository.GetAllFromCatalogoByIdCatalogo(reader.GetValue(3))
                _BIENMUEBLE.Area = AreaRepository.GetFromProyectoByIdProyecto(reader.GetValue(7))

                lista.Add(_BIENMUEBLE)
            End While
        End Using
        Return lista
    End Function
    Public Function GetAllFromBIENMUEBLE() As System.Collections.Generic.List(Of BussinessEntities.BIENMUEBLE) Implements IBienMuebleRepository.GetAllFromBIENMUEBLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromBIENMUEBLE")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetBIENMUEBLEByIdBienMueble(ByVal IdBienMueble As Integer) As BussinessEntities.BIENMUEBLE Implements IBienMuebleRepository.GetBIENMUEBLEByIdBienMueble
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetBIENMUEBLEByIdBienMueble")
        command.Parameters.AddWithValue("IdBienMueble", IdBienMueble)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveBIENMUEBLE(ByVal _BienMueble As BussinessEntities.BIENMUEBLE) As Integer Implements IBienMuebleRepository.SaveBIENMUEBLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveBIENMUEBLE")
        command.Parameters.AddWithValue("Color", _BienMueble.Color)
        command.Parameters.AddWithValue("Conservacion", _BienMueble.Conservacion)
        command.Parameters.AddWithValue("Costo", _BienMueble.Costo)
        command.Parameters.AddWithValue("Descripcion", _BienMueble.Descripcion)
        command.Parameters.AddWithValue("Donacion", _BienMueble.Donacion)
        command.Parameters.AddWithValue("FechaIngreso", _BienMueble.FechaIngreso)
        command.Parameters.AddWithValue("IdBienMueble", _BienMueble.IdBienMueble)
        command.Parameters.AddWithValue("IdBienPadre", _BienMueble.IdBienPadre)
        command.Parameters.AddWithValue("IdCatalogo", _BienMueble.IdCatalogo)
        command.Parameters.AddWithValue("IdCCosto", _BienMueble.IdCCosto)
        command.Parameters.AddWithValue("IdMarca", _BienMueble.IdMarca)
        command.Parameters.AddWithValue("IdOficina", _BienMueble.IdOficina)
        command.Parameters.AddWithValue("IdPlanCuenta", _BienMueble.IdPlanCuenta)
        command.Parameters.AddWithValue("IdPlanDepreciacion", _BienMueble.IdPlanDepreciacion)
        command.Parameters.AddWithValue("IdPlanDepreciacion1", _BienMueble.IdPlanDepreciacion1)
        command.Parameters.AddWithValue("IdProveedorCliente", _BienMueble.IdProveedorCliente)
        command.Parameters.AddWithValue("IdProyecto", _BienMueble.IdProyecto)
        command.Parameters.AddWithValue("IdTipoDocumento", _BienMueble.IdTipoDocumento)
        command.Parameters.AddWithValue("IdUsuario", _BienMueble.IdUsuario)
        command.Parameters.AddWithValue("Modelo", _BienMueble.Modelo)
        command.Parameters.AddWithValue("Motor", _BienMueble.Motor)
        command.Parameters.AddWithValue("NroDocumento", _BienMueble.NroDocumento)
        command.Parameters.AddWithValue("Otro", _BienMueble.Otro)
        command.Parameters.AddWithValue("Placa", _BienMueble.Placa)
        command.Parameters.AddWithValue("Serie", _BienMueble.Serie)
        command.Parameters.AddWithValue("SerieDocumento", _BienMueble.SerieDocumento)
        command.Parameters.AddWithValue("Tipo", _BienMueble.Tipo)
        command.Parameters.AddWithValue("CodigoReferencia", _BienMueble.CodigoReferencia)
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

    Public Function GetBIENMUEBLEByParameter(ByVal texto As String) As System.Collections.Generic.List(Of BussinessEntities.BIENMUEBLE) Implements IBienMuebleRepository.GetBIENMUEBLEByParameter
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetBIENMUEBLEByParameter")
        command.Parameters.AddWithValue("texto", texto)
        Return SelectObjectFactory(command)
    End Function

    Public Sub UpdateEstadoBIENMUEBLE(ByVal IdBienMueble As Integer, ByVal Estado As String) Implements IBienMuebleRepository.UpdateEstadoBIENMUEBLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoBIENMUEBLE")
        command.Parameters.AddWithValue("IdBienMueble", IdBienMueble)
        command.Parameters.AddWithValue("Estado", Estado)
        MyBase.ExecuteReader(command)
    End Sub
End Class

Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class DetalleEjecucionRepository : Inherits MasterDataAccess : Implements IDetalleEjecucionRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of DetalleEjecucion)
        Dim lista As New List(Of DetalleEjecucion)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _DetalleEjecucion As New DetalleEjecucion() With
                {
                  .IdDetalleEje = reader.GetValue(0),
                  .IdProyecto = reader.GetValue(1),
                  .IdUbigeo = reader.GetValue(2),
                    .FechaProgramada = reader.GetValue(10),
                    .IdUsuario = reader.GetValue(9),
                  .Tipo = reader.GetValue(12),
                  .Estado = reader.GetValue(14)
              }
                If Not (reader.IsDBNull(3)) Then
                    _DetalleEjecucion.Observaciones = reader.GetValue(3)
                End If
                If Not (reader.IsDBNull(4)) Then
                    _DetalleEjecucion.IdFamilia = reader.GetValue(4)
                End If

                If Not (reader.IsDBNull(5)) Then
                    _DetalleEjecucion.ClimaSocial = reader.GetValue(5)
                End If
                If Not (reader.IsDBNull(6)) Then
                    _DetalleEjecucion.AccionesTomadas = reader.GetValue(6)
                End If
                If Not (reader.IsDBNull(7)) Then
                    _DetalleEjecucion.Quejas = reader.GetValue(7)
                End If
                If Not (reader.IsDBNull(8)) Then
                    _DetalleEjecucion.Fecha = reader.GetValue(8)
                End If
                If Not (reader.IsDBNull(11)) Then
                    _DetalleEjecucion.FechaReprogramada = reader.GetValue(11)
                End If
                If Not (reader.IsDBNull(13)) Then
                    _DetalleEjecucion.Hora = reader.GetValue(13)
                End If
                lista.Add(_DetalleEjecucion)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeletetDETALLEEJECUCION(ByVal IdDetalleEje As Integer) Implements IDetalleEjecucionRepository.DeletetDETALLEEJECUCION
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDETALLEEJECUCION")
        command.Parameters.AddWithValue("IdDetalleEje", IdDetalleEje)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetDETALLEEJECUCIONByIdDetalleEje(ByVal IdDetalleEje As Integer) As BussinessEntities.DetalleEjecucion Implements IDetalleEjecucionRepository.GetDETALLEEJECUCIONByIdDetalleEje
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDETALLEEJECUCIONByIdDetalleEje")
        command.Parameters.AddWithValue("IdDetalleEje", IdDetalleEje)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetDETALLEEJECUCIONByIdProyecto(ByVal IdProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleEjecucion) Implements IDetalleEjecucionRepository.GetDETALLEEJECUCIONByIdProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDETALLEEJECUCIONByIdProyecto")
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        Return SelectObjectFactory(command)
    End Function

    Public Function SaveDETALLEEJECUCION(ByVal _DetalleEjecucion As BussinessEntities.DetalleEjecucion) As Integer Implements IDetalleEjecucionRepository.SaveDETALLEEJECUCION
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDETALLEEJECUCION")
        command.Parameters.AddWithValue("AccionesTomadas", _DetalleEjecucion.AccionesTomadas)
        command.Parameters.AddWithValue("ClimaSocial", _DetalleEjecucion.ClimaSocial)
        command.Parameters.AddWithValue("IdDetalleEje", _DetalleEjecucion.IdDetalleEje)
        command.Parameters.AddWithValue("IdProyecto", _DetalleEjecucion.IdProyecto)
        command.Parameters.AddWithValue("IdFamilia", _DetalleEjecucion.IdFamilia)
        command.Parameters.AddWithValue("IdUbigeo", _DetalleEjecucion.IdUbigeo)
        command.Parameters.AddWithValue("Observaciones", _DetalleEjecucion.Observaciones)
        command.Parameters.AddWithValue("Quejas", _DetalleEjecucion.Quejas)
        command.Parameters.AddWithValue("Fecha", _DetalleEjecucion.Fecha)
        command.Parameters.AddWithValue("IdUsuario", _DetalleEjecucion.IdUsuario)
        command.Parameters.AddWithValue("FechaProgramada", _DetalleEjecucion.FechaProgramada)
        command.Parameters.AddWithValue("FechaReprogramada", _DetalleEjecucion.FechaReprogramada)
        command.Parameters.AddWithValue("Tipo", _DetalleEjecucion.Tipo)
        command.Parameters.AddWithValue("Hora", _DetalleEjecucion.Hora)
        command.Parameters.AddWithValue("Estado", _DetalleEjecucion.Estado)
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

    Public Sub UpdateEstadoDetalleejecucion(ByVal IdDetalleEje As Integer) Implements IDetalleEjecucionRepository.UpdateEstadoDetalleejecucion
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoDetalleejecucion")
        command.Parameters.AddWithValue("IdDetalleEje", IdDetalleEje)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class

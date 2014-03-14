Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class EstadoBienMuebleRepository : Inherits MasterDataAccess : Implements IEstadoBienMuebleRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of EstadoBienMueble)
        Dim lista As New List(Of EstadoBienMueble)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _EstadoBienMueble As New EstadoBienMueble() With
                {
                    .IdEstado = reader.GetValue(0),
                    .IdTipo = reader.GetValue(1),
                    .FechaInicio = reader.GetValue(2),
                    .IdBienMueble = reader.GetValue(3)
                }
                If Not (reader.IsDBNull(4)) Then
                    _EstadoBienMueble.Observacion = reader.GetValue(4)
                End If
                If Not (reader.IsDBNull(5)) Then
                    _EstadoBienMueble.IdMotivo = reader.GetValue(5)
                End If
                If Not (reader.IsDBNull(6)) Then
                    _EstadoBienMueble.DocumentoBaja = reader.GetValue(6)
                End If
                If Not (reader.IsDBNull(7)) Then
                    _EstadoBienMueble.BajaContable = reader.GetValue(7)
                End If
                If Not (reader.IsDBNull(8)) Then
                    _EstadoBienMueble.BajaPatrimonio = reader.GetValue(8)
                End If
               
                lista.Add(_EstadoBienMueble)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteESTADOBIENMUEBLE(ByVal IdEstado As Integer) Implements IEstadoBienMuebleRepository.DeleteESTADOBIENMUEBLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteESTADOBIENMUEBLE")
        command.Parameters.AddWithValue("IdEstado", IdEstado)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetESTADOBIENMUEBLEByIdBienMueble(ByVal IdBienMueble As Integer) As System.Collections.Generic.List(Of BussinessEntities.EstadoBienMueble) Implements IEstadoBienMuebleRepository.GetESTADOBIENMUEBLEByIdBienMueble
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetESTADOBIENMUEBLEByIdBienMueble")
        command.Parameters.AddWithValue("IdBienMueble", IdBienMueble)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetESTADOBIENMUEBLEByIdEstado(ByVal IdEstado As Integer) As BussinessEntities.EstadoBienMueble Implements IEstadoBienMuebleRepository.GetESTADOBIENMUEBLEByIdEstado
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetESTADOBIENMUEBLEByIdEstado")
        command.Parameters.AddWithValue("IdEstado", IdEstado)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveESTADOBIENMUEBLE(ByVal _EstadoBienMueble As BussinessEntities.EstadoBienMueble) Implements IEstadoBienMuebleRepository.SaveESTADOBIENMUEBLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveESTADOBIENMUEBLE")
       command.Parameters.AddWithValue("FechaInicio", _EstadoBienMueble.FechaInicio)
        command.Parameters.AddWithValue("IdBienMueble", _EstadoBienMueble.IdBienMueble)
        command.Parameters.AddWithValue("IdEstado", _EstadoBienMueble.IdEstado)
        command.Parameters.AddWithValue("IdTipo", _EstadoBienMueble.IdTipo)
        command.Parameters.AddWithValue("Observacion", _EstadoBienMueble.Observacion)
        command.Parameters.AddWithValue("IdMotivo", _EstadoBienMueble.IdMotivo)
        command.Parameters.AddWithValue("DocumentoBaja", _EstadoBienMueble.DocumentoBaja)
        command.Parameters.AddWithValue("BajaContable", _EstadoBienMueble.BajaContable)
        command.Parameters.AddWithValue("BajaPatrimonio", _EstadoBienMueble.BajaPatrimonio)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class

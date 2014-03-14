Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class ObservacionRepository : Inherits MasterDataAccess : Implements IObservacionRepository

    Public Sub DeleteObservacion(ByVal _id As Integer) Implements IObservacionRepository.DeleteObservacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteOBSERVACION")
        command.Parameters.AddWithValue("idObservacion", _id)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetObservacionById(ByVal _id As Integer) As BussinessEntities.Observacion Implements IObservacionRepository.GetObservacionById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetOBSERVACIONById")
        command.Parameters.AddWithValue("IdObservacion", _id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Observacion)
        Dim lista As New List(Of Observacion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)

            While reader.Read
                Dim _Observacion As New Observacion() With
                    {
                        .IdObservacion = reader.GetValue(reader.GetOrdinal("IdObservacion")),
                        .Id = reader.GetValue(reader.GetOrdinal("Id")),
                        .Tabla = reader.GetValue(reader.GetOrdinal("Tabla"))
                    }
                If Not (reader.IsDBNull(reader.GetOrdinal("Observacion"))) Then
                    _Observacion.Observacion = reader.GetValue(reader.GetOrdinal("Observacion"))
                End If
                lista.Add(_Observacion)
            End While
        End Using
        Return lista
    End Function

    Public Function GetObservacionByIdAndTabla(ByVal _id As Integer, ByVal _Tabla As String) As System.Collections.Generic.List(Of BussinessEntities.Observacion) Implements IObservacionRepository.GetObservacionByIdAndTabla
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetOBSERVACIONByIdAndTabla")
        command.Parameters.AddWithValue("Id", _id)
        command.Parameters.AddWithValue("Tabla", _Tabla)
        Return SelectObjectFactory(command)
    End Function

    Public Sub UpdateObservacion(ByVal _IdObservacion As Integer, ByVal _Obser As String) Implements IObservacionRepository.UpdateObservacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateOBSERVACION")
        command.Parameters.AddWithValue("IdObservacion", _IdObservacion)
        command.Parameters.AddWithValue("Observacion", _Obser)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub InsertObservacion(ByVal _Observacion As BussinessEntities.Observacion) Implements IObservacionRepository.InsertObservacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("InsertOBSERVACION")
        command.Parameters.AddWithValue("IdObservacion", _Observacion.IdObservacion)
        command.Parameters.AddWithValue("Id", _Observacion.Id)
        command.Parameters.AddWithValue("Observacion", _Observacion.Observacion)
        command.Parameters.AddWithValue("Tabla", _Observacion.Tabla)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class

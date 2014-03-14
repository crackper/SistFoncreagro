Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class AdjuntoRequerimientoRepository : Inherits MasterDataAccess : Implements IAdjuntoRequerimientoRepository

    Public Sub DeleteadjuntoRequerimiento(ByVal IdAdjuntoRequerimiento As Integer, ByVal IdRequerimiento As Int32) Implements IAdjuntoRequerimientoRepository.DeleteadjuntoRequerimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteadjuntoRequerimiento")
        command.Parameters.AddWithValue("IdAdjuntoRequerimiento", IdAdjuntoRequerimiento)
        command.Parameters.AddWithValue("IdRequerimiento", IdRequerimiento)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromAdjuntoReqByIdReq(ByVal IdRequerimiento As Integer) As System.Collections.Generic.List(Of BussinessEntities.AdjuntoRequerimiento) Implements IAdjuntoRequerimientoRepository.GetAllFromAdjuntoReqByIdReq
        Dim command As SqlCommand =
                   MyBase.CreateSPCommand("GetAllFromAdjuntoReqByIdReq")
        command.Parameters.AddWithValue("IdRequerimiento", IdRequerimiento)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveAdjuntoRequerimiento(ByVal adjunto As BussinessEntities.AdjuntoRequerimiento) Implements IAdjuntoRequerimientoRepository.SaveAdjuntoRequerimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveAdjuntoRequerimiento")
        command.Parameters.AddWithValue("IdRequerimiento", adjunto.IdRequerimiento)
        command.Parameters.AddWithValue("Archivo", adjunto.Archivo)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of AdjuntoRequerimiento)
        Dim listaAdjunto As New List(Of AdjuntoRequerimiento)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim adjunto As New AdjuntoRequerimiento
                With adjunto
                    .IdAdjuntoRequerimiento = reader.GetInt32(0)
                    .IdRequerimiento = reader.GetInt32(1)
                    .Archivo = reader.GetString(2)
                    .Estado = reader.GetBoolean(3)
                End With
                listaAdjunto.Add(adjunto)
            End While
        End Using
        Return listaAdjunto
    End Function
End Class

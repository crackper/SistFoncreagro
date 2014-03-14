Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class RespuestaRepository : Inherits MasterDataAccess : Implements IRespuestaRepository

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Respuesta)
        Dim lista As New List(Of Respuesta)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Respuesta As New Respuesta() With
                {
                   .IdRespuesta = reader.GetValue(0),
                       .IdEncuestaLlena = reader.GetValue(1),
                       .IdDetalle = reader.GetValue(2)
                 }
                If Not (reader.IsDBNull(3)) Then
                    _Respuesta.Respuesta = reader.GetValue(3)
                End If
                If Not (reader.IsDBNull(4)) Then
                    _Respuesta.Comentario = reader.GetValue(4)
                End If

                lista.Add(_Respuesta)
            End While
        End Using
        Return lista
    End Function

    Public Function GetRESPUESTAByIdEncuestaLlena(ByVal IdEncuestaLlena As Integer) As System.Collections.Generic.List(Of BussinessEntities.Respuesta) Implements IRespuestaRepository.GetRESPUESTAByIdEncuestaLlena
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetRESPUESTAByIdEncuestaLlena")
        command.Parameters.AddWithValue("IdEncuestaLlena", IdEncuestaLlena)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetRESPUESTAByIdRespuesta(ByVal IdRespuesta As Integer) As BussinessEntities.Respuesta Implements IRespuestaRepository.GetRESPUESTAByIdRespuesta
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetRESPUESTAByIdRespuesta")
        command.Parameters.AddWithValue("IdRespuesta", IdRespuesta)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub UpdateRESPUESTA(ByVal _Respuesta As BussinessEntities.Respuesta) Implements IRespuestaRepository.UpdateRESPUESTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateRESPUESTA")
        command.Parameters.AddWithValue("Comentario", _Respuesta.Comentario)
        command.Parameters.AddWithValue("IdRespuesta", _Respuesta.IdRespuesta)
        command.Parameters.AddWithValue("Respuesta", _Respuesta.Respuesta)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub SaveRESPUESTA(ByVal IdEncuestaLlena As Integer) Implements IRespuestaRepository.SaveRESPUESTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveRESPUESTA")
        command.Parameters.AddWithValue("IdEncuestaLlena", IdEncuestaLlena)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class

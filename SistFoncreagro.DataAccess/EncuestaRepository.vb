Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class EncuestaRepository : Inherits MasterDataAccess : Implements IEncuestaRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Encuesta)
        Dim lista As New List(Of Encuesta)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Encuesta As New Encuesta() With
                {
                    .IdEncuesta = reader.GetValue(0),
                    .FechaInicio = reader.GetValue(1),
                    .FechaFin = reader.GetValue(2),
                    .Descripcion = reader.GetValue(3),
                    .Estado = reader.GetValue(4)
                }

                lista.Add(_Encuesta)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteENCUESTA(ByVal IdEncuesta As Integer) Implements IEncuestaRepository.DeleteENCUESTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteENCUESTA")
        command.Parameters.AddWithValue("IdEncuesta", IdEncuesta)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromENCUESTA() As System.Collections.Generic.List(Of BussinessEntities.Encuesta) Implements IEncuestaRepository.GetAllFromENCUESTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromENCUESTA")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetENCUESTAByIdEncuesta(ByVal IdEncuesta As Integer) As BussinessEntities.Encuesta Implements IEncuestaRepository.GetENCUESTAByIdEncuesta
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetENCUESTAByIdEncuesta")
        command.Parameters.AddWithValue("IdEncuesta", IdEncuesta)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveENCUESTA(ByVal _Encuesta As BussinessEntities.Encuesta) Implements IEncuestaRepository.SaveENCUESTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveENCUESTA")
        command.Parameters.AddWithValue("Descripcion", _Encuesta.Descripcion)
        command.Parameters.AddWithValue("FechaInicio", _Encuesta.FechaInicio)
        command.Parameters.AddWithValue("FechaFin", _Encuesta.FechaFin)
        command.Parameters.AddWithValue("IdEncuesta", _Encuesta.IdEncuesta)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class

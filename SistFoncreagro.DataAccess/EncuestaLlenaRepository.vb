Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class EncuestaLlenaRepository : Inherits MasterDataAccess : Implements IEncuestaLlenaRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of EncuestaLlena)
        Dim lista As New List(Of EncuestaLlena)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _EncuestaLlena As New EncuestaLlena() With
                {
                    .IdEncuestaLlena = reader.GetValue(0),
                    .IdPersonal = reader.GetValue(1),
                    .Fecha = reader.GetValue(3),
                    .Estado = reader.GetValue(4)
                 }
                If Not (reader.IsDBNull(2)) Then
                    _EncuestaLlena.Candidato = reader.GetValue(2)
                End If
                If Not (reader.IsDBNull(5)) Then
                    _EncuestaLlena.IdProyecto = reader.GetValue(5)
                End If

                lista.Add(_EncuestaLlena)
            End While
        End Using
        Return lista
    End Function
    Public Function GenerarENCUESTALLENA(ByVal IdPersonal As Integer) As Integer Implements IEncuestaLlenaRepository.GenerarENCUESTALLENA
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarENCUESTALLENA")
        Dim id As Int32
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                id = reader.GetValue(0)

            End If
        End Using
        Return id
    End Function

    Public Function GetENCUESTALLENAByIdEncuesta(ByVal IdEncuestaLlena As Integer) As BussinessEntities.EncuestaLlena Implements IEncuestaLlenaRepository.GetENCUESTALLENAByIdEncuesta
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetENCUESTALLENAByIdEncuesta")
        command.Parameters.AddWithValue("IdEncuestaLlena", IdEncuestaLlena)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
    Public Sub UpdateENCUESTALLENA(ByVal IdEncuestaLlena As Integer) Implements IEncuestaLlenaRepository.UpdateENCUESTALLENA
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateENCUESTALLENA")
        command.Parameters.AddWithValue("IdEncuestaLlena", IdEncuestaLlena)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function SaveENCUESTALLENA(ByVal _EncuestaLlena As BussinessEntities.EncuestaLlena) As Integer Implements IEncuestaLlenaRepository.SaveENCUESTALLENA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveENCUESTALLENA")
        command.Parameters.AddWithValue("Candidato", _EncuestaLlena.Candidato)
        command.Parameters.AddWithValue("Fecha", _EncuestaLlena.Fecha)
        command.Parameters.AddWithValue("IdEncuestaLlena", _EncuestaLlena.IdEncuestaLlena)
        command.Parameters.AddWithValue("IdPersonal", _EncuestaLlena.IdPersonal)
        command.Parameters.AddWithValue("IdProyecto", _EncuestaLlena.IdProyecto)
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

    Public Function VerifyExisteENCUESTALLENAByIdPersonal(ByVal IdPersonal As Integer) As Integer Implements IEncuestaLlenaRepository.VerifyExisteENCUESTALLENAByIdPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("VerifyExisteENCUESTALLENAByIdPersonal")
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
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
End Class

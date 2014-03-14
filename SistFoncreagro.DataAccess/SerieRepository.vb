Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class SerieRepository : Inherits MasterDataAccess : Implements ISerieRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Serie)
        Dim lista As New List(Of Serie)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Serie As New Serie() With
                {
                    .Actual = reader.GetValue(0),
                    .Estado = reader.GetValue(1),
                    .IdSerie = reader.GetValue(3),
                    .IdTipoDoumento = reader.GetValue(4),
                    .IdUsuario = reader.GetValue(5),
                    .Inicio = reader.GetValue(6),
                    .Serie = reader.GetValue(7)
                }
                If Not (reader.IsDBNull(2)) Then
                    _Serie.IdProyecto = reader.GetValue(2)
                End If
               
                lista.Add(_Serie)
            End While
        End Using
        Return lista
    End Function

    Public Function GetAllFromSERIE() As System.Collections.Generic.List(Of BussinessEntities.Serie) Implements ISerieRepository.GetAllFromSERIE
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromSERIE")
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveSERIE(ByVal _Serie As BussinessEntities.Serie) Implements ISerieRepository.SaveSERIE
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveSERIE")
        command.Parameters.AddWithValue("IdProyecto", _Serie.IdProyecto)
        command.Parameters.AddWithValue("IdSerie", _Serie.IdSerie)
        command.Parameters.AddWithValue("IdTipoDoumento", _Serie.IdTipoDoumento)
        command.Parameters.AddWithValue("IdUsuario", _Serie.IdUsuario)
        command.Parameters.AddWithValue("Serie", _Serie.Serie)
        command.Parameters.AddWithValue("Actual", _Serie.Actual)
        MyBase.ExecuteReader(command)
    End Sub

    Public Sub UpdateEstadoSERIE(ByVal IdSerie As Integer) Implements ISerieRepository.UpdateEstadoSERIE
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoSERIE")
        command.Parameters.AddWithValue("IdSerie", IdSerie)
        MyBase.ExecuteReader(command)
    End Sub
End Class

Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class AsistenteRepository : Inherits MasterDataAccess : Implements IAsistenteRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Asistente)
        Dim lista As New List(Of Asistente)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Asistente As New Asistente() With
                {
                .IdAsistente = reader.GetValue(0),
                    .IdInteresado = reader.GetValue(1),
                    .IdControl = reader.GetValue(3)
                }
                If Not reader.IsDBNull(2) Then
                    _Asistente.Observaciones = reader.GetValue(2)
                End If
                lista.Add(_Asistente)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteASISTENTE(ByVal IdAsistente As Integer) Implements IAsistenteRepository.DeleteASISTENTE
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteASISTENTE")
        command.Parameters.AddWithValue("IdAsistente", IdAsistente)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetASISTENTEByIdAsistente(ByVal IdAsistente As Integer) As BussinessEntities.Asistente Implements IAsistenteRepository.GetASISTENTEByIdAsistente
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetASISTENTEByIdAsistente")
        command.Parameters.AddWithValue("IdAsistente", IdAsistente)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetASISTENTEByIdControl(ByVal IdControl As Integer) As System.Collections.Generic.List(Of BussinessEntities.Asistente) Implements IAsistenteRepository.GetASISTENTEByIdControl
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetASISTENTEByIdControl")
        command.Parameters.AddWithValue("IdControl", IdControl)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveASISTENTE(ByVal _Asistente As BussinessEntities.Asistente) Implements IAsistenteRepository.SaveASISTENTE
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveASISTENTE")
        command.Parameters.AddWithValue("IdAsistente", _Asistente.IdAsistente)
        command.Parameters.AddWithValue("IdControl", _Asistente.IdControl)
        command.Parameters.AddWithValue("IdInteresado", _Asistente.IdInteresado)
        command.Parameters.AddWithValue("Observaciones", _Asistente.Observaciones)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class

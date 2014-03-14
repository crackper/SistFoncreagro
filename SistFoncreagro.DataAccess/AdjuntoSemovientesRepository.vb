Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class AdjuntoSemovientesRepository : Inherits MasterDataAccess : Implements IAdjuntoSemovientesRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of AdjuntoSemovientes)
        Dim lista As New List(Of AdjuntoSemovientes)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _AdjuntoSemoviente As New AdjuntoSemovientes() With
                {
                    .IdAdjuntoSemoviente = reader.GetValue(0),
                    .IdSemoviente = reader.GetValue(1),
                    .Nombre = reader.GetValue(2),
                    .Archivo = reader.GetValue(3),
                    .Fecha = reader.GetValue(4)
                }

                lista.Add(_AdjuntoSemoviente)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteADJUNTOSEMOVIENTES(ByVal IdAdjuntoSemoviente As Integer) Implements IAdjuntoSemovientesRepository.DeleteADJUNTOSEMOVIENTES
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteADJUNTOSEMOVIENTES")
        command.Parameters.AddWithValue("IdAdjuntoSemoviente", IdAdjuntoSemoviente)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetADJUNTOSEMOVIENTESByIdAdjuntoSemoviente(ByVal IdAdjuntoSemoviente As Integer) As BussinessEntities.AdjuntoSemovientes Implements IAdjuntoSemovientesRepository.GetADJUNTOSEMOVIENTESByIdAdjuntoSemoviente
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetADJUNTOSEMOVIENTESByIdAdjuntoSemoviente")
        command.Parameters.AddWithValue("IdAdjuntoSemoviente", IdAdjuntoSemoviente)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetADJUNTOSEMOVIENTESByIdSemoviente(ByVal IdSemoviente As Integer) As System.Collections.Generic.List(Of BussinessEntities.AdjuntoSemovientes) Implements IAdjuntoSemovientesRepository.GetADJUNTOSEMOVIENTESByIdSemoviente
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetADJUNTOSEMOVIENTESByIdSemoviente")
        command.Parameters.AddWithValue("IdSemoviente", IdSemoviente)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveADJUNTOSEMOVIENTES(ByVal _AdjuntoSemoviente As BussinessEntities.AdjuntoSemovientes) Implements IAdjuntoSemovientesRepository.SaveADJUNTOSEMOVIENTES
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveADJUNTOSEMOVIENTES")
        command.Parameters.AddWithValue("Archivo", _AdjuntoSemoviente.Archivo)
        command.Parameters.AddWithValue("Fecha", _AdjuntoSemoviente.Fecha)
        command.Parameters.AddWithValue("IdAdjuntoSemoviente", _AdjuntoSemoviente.IdAdjuntoSemoviente)
        command.Parameters.AddWithValue("IdSemoviente", _AdjuntoSemoviente.IdSemoviente)
        command.Parameters.AddWithValue("Nombre", _AdjuntoSemoviente.Nombre)
        MyBase.ExecuteReader(command)
    End Sub
End Class

Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class UbicacionSemovientesRepository : Inherits MasterDataAccess : Implements IUbicacionSemovientesRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of UbicacionSemovientes)
        Dim lista As New List(Of UbicacionSemovientes)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _UbicacionSemoviente As New UbicacionSemovientes() With
                {
                    .IdUbicacionSemoviente = reader.GetValue(0),
                    .IdSemoviente = reader.GetValue(1),
                    .IdProyecto = reader.GetValue(2),
                    .FechaInicio = reader.GetValue(3)
                }
                If Not (reader.IsDBNull(4)) Then
                    _UbicacionSemoviente.FechaFin = reader.GetValue(4)
                End If
                If Not (reader.IsDBNull(5)) Then
                    _UbicacionSemoviente.Observacion = reader.GetValue(5)
                End If
                lista.Add(_UbicacionSemoviente)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteUBICACIONSEMOVIENTES(ByVal IdUbicacionSemoviente As Integer) Implements IUbicacionSemovientesRepository.DeleteUBICACIONSEMOVIENTES
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteUBICACIONSEMOVIENTES")
        command.Parameters.AddWithValue("IdUbicacionSemoviente", IdUbicacionSemoviente)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetUBICACIONSEMOVIENTESByIdUbicacionSemoviente(ByVal IdUbicacionSemoviente As Integer) As BussinessEntities.UbicacionSemovientes Implements IUbicacionSemovientesRepository.GetUBICACIONSEMOVIENTESByIdUbicacionSemoviente
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetUBICACIONSEMOVIENTESByIdUbicacionSemoviente")
        command.Parameters.AddWithValue("IdUbicacionSemoviente", IdUbicacionSemoviente)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveUBICACIONSEMOVIENTES(ByVal _UbicacionSemovientes As BussinessEntities.UbicacionSemovientes) Implements IUbicacionSemovientesRepository.SaveUBICACIONSEMOVIENTES
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveUBICACIONSEMOVIENTES")
        command.Parameters.AddWithValue("FechaFin", _UbicacionSemovientes.FechaFin)
        command.Parameters.AddWithValue("FechaInicio", _UbicacionSemovientes.FechaInicio)
        command.Parameters.AddWithValue("IdProyecto", _UbicacionSemovientes.IdProyecto)
        command.Parameters.AddWithValue("IdSemoviente", _UbicacionSemovientes.IdSemoviente)
        command.Parameters.AddWithValue("IdUbicacionSemoviente", _UbicacionSemovientes.IdUbicacionSemoviente)
        command.Parameters.AddWithValue("Observacion", _UbicacionSemovientes.Observacion)
        MyBase.ExecuteReader(command)
    End Sub
End Class

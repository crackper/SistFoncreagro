Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class PropiedadSemovientesRepository : Inherits MasterDataAccess : Implements IPropiedadSemovienteRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of PropiedadSemovientes)
        Dim lista As New List(Of PropiedadSemovientes)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _PropiedadSemovientes As New PropiedadSemovientes() With
                {
                   .IdPropiedadSemoviente = reader.GetValue(0),
                   .IdSemoviente = reader.GetValue(1),
                   .Peso = reader.GetValue(2),
                   .Valor = reader.GetValue(3),
                   .FechaInicio = reader.GetValue(4),
                   .IdEstadoSemoviente = reader.GetValue(6),
                   .IdCategoriaAnimal = reader.GetValue(7)
                }
                If Not (reader.IsDBNull(5)) Then
                    _PropiedadSemovientes.FechaFin = reader.GetValue(5)
                End If

                lista.Add(_PropiedadSemovientes)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeletePROPIEDADSEMOVIENTES(ByVal IdPropiedadSemoviente As Integer) Implements IPropiedadSemovienteRepository.DeletePROPIEDADSEMOVIENTES
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeletePROPIEDADSEMOVIENTES")
        command.Parameters.AddWithValue("IdPropiedadSemoviente", IdPropiedadSemoviente)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetPROPIEDADSEMOVIENTESByIdPropiedadSemoviente(ByVal IdPropiedadSemoviente As Integer) As BussinessEntities.PropiedadSemovientes Implements IPropiedadSemovienteRepository.GetPROPIEDADSEMOVIENTESByIdPropiedadSemoviente
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPROPIEDADSEMOVIENTESByIdPropiedadSemoviente")
        command.Parameters.AddWithValue("IdPropiedadSemoviente", IdPropiedadSemoviente)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SavePROPIEDADSEMOVIENTES(ByVal _PropiedadSemovientes As BussinessEntities.PropiedadSemovientes) Implements IPropiedadSemovienteRepository.SavePROPIEDADSEMOVIENTES
        Dim command As SqlCommand = MyBase.CreateSPCommand("SavePROPIEDADSEMOVIENTES")
        command.Parameters.AddWithValue("FechaFin", _PropiedadSemovientes.FechaFin)
        command.Parameters.AddWithValue("FechaInicio", _PropiedadSemovientes.FechaInicio)
        command.Parameters.AddWithValue("IdCategoriaAnimal", _PropiedadSemovientes.IdCategoriaAnimal)
        command.Parameters.AddWithValue("IdSemoviente", _PropiedadSemovientes.IdSemoviente)
        command.Parameters.AddWithValue("IdEstadoSemoviente", _PropiedadSemovientes.IdEstadoSemoviente)
        command.Parameters.AddWithValue("IdPropiedadSemoviente", _PropiedadSemovientes.IdPropiedadSemoviente)
        command.Parameters.AddWithValue("Peso", _PropiedadSemovientes.Peso)
        command.Parameters.AddWithValue("Valor", _PropiedadSemovientes.Valor)
        MyBase.ExecuteReader(command)
    End Sub
End Class

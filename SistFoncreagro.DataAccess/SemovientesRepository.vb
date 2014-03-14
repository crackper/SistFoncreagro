Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class SemovientesRepository : Inherits MasterDataAccess : Implements ISemovientesRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Semovientes)
        Dim lista As New List(Of Semovientes)
        Dim EspecieRepository As New EspecieAnimalRepository

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Semoviente As New Semovientes() With
                {
                    .IdSemoviente = reader.GetValue(0),
                    .IdProyecto = reader.GetValue(1),
                    .IdProyectoCPD = reader.GetValue(2),
                    .AreteEstablo = reader.GetValue(4),
                    .EdadMeses = reader.GetValue(6),
                    .IdRaza = reader.GetValue(8),
                    .TipoIngreso = reader.GetValue(12),
                    .FechaRegistro = reader.GetValue(14),
                    .Sexo = reader.GetValue(16)
                }

                If Not (reader.IsDBNull(3)) Then
                    _Semoviente.AreteMicrochip = reader.GetValue(3)
                End If
                If Not (reader.IsDBNull(5)) Then
                    _Semoviente.FechaNacimiento = reader.GetValue(5)
                End If
                If Not (reader.IsDBNull(7)) Then
                    _Semoviente.Nombre = reader.GetValue(7)
                End If
                If Not (reader.IsDBNull(9)) Then
                    _Semoviente.DescSemoviente = reader.GetValue(9)
                End If
                If Not (reader.IsDBNull(10)) Then
                    _Semoviente.IdSemovientePadre = reader.GetValue(10)
                End If
                If Not (reader.IsDBNull(11)) Then
                    _Semoviente.IdSemovienteMadre = reader.GetValue(11)
                End If
                If Not (reader.IsDBNull(13)) Then
                    _Semoviente.IdOrigenSemoviente = reader.GetValue(13)
                End If
                If Not (reader.IsDBNull(17)) Then
                    _Semoviente.Color = reader.GetValue(17)
                End If
                If Not (reader.IsDBNull(15)) Then
                    _Semoviente.IdPlan = reader.GetValue(15)
                End If
                _Semoviente.especie = EspecieRepository.GetEspecieAnimalByIdRaza(reader.GetValue(8))

                lista.Add(_Semoviente)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteSEMOVIENTES(ByVal IdSemoviente As Integer) Implements ISemovientesRepository.DeleteSEMOVIENTES
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteSEMOVIENTES")
        command.Parameters.AddWithValue("IdSemoviente", IdSemoviente)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromSEMOVIENTES() As System.Collections.Generic.List(Of BussinessEntities.Semovientes) Implements ISemovientesRepository.GetAllFromSEMOVIENTES
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromSEMOVIENTES")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetSEMOVIENTESById(ByVal IdSemoviente As Integer) As BussinessEntities.Semovientes Implements ISemovientesRepository.GetSEMOVIENTESById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetSEMOVIENTESById")
        command.Parameters.AddWithValue("IdSemoviente", IdSemoviente)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveSEMOVIENTES(ByVal _Semovientes As BussinessEntities.Semovientes) As Integer Implements ISemovientesRepository.SaveSEMOVIENTES
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveSEMOVIENTES")
        command.Parameters.AddWithValue("AreteEstablo", _Semovientes.AreteEstablo)
        command.Parameters.AddWithValue("AreteMicrochip", _Semovientes.AreteMicrochip)
        command.Parameters.AddWithValue("Color", _Semovientes.Color)
        command.Parameters.AddWithValue("DescSemoviente", _Semovientes.DescSemoviente)
        command.Parameters.AddWithValue("EdadMeses", _Semovientes.EdadMeses)
        command.Parameters.AddWithValue("FechaNacimiento", _Semovientes.FechaNacimiento)
        command.Parameters.AddWithValue("FechaRegistro", _Semovientes.FechaRegistro)
        command.Parameters.AddWithValue("IdOrigenSemoviente", _Semovientes.IdOrigenSemoviente)
        command.Parameters.AddWithValue("IdPlan", _Semovientes.IdPlan)
        command.Parameters.AddWithValue("IdProyecto", _Semovientes.IdProyecto)
        command.Parameters.AddWithValue("IdProyectoCPD", _Semovientes.IdProyectoCPD)
        command.Parameters.AddWithValue("IdRaza", _Semovientes.IdRaza)
        command.Parameters.AddWithValue("IdSemoviente", _Semovientes.IdSemoviente)
        command.Parameters.AddWithValue("IdSemovienteMadre", _Semovientes.IdSemovienteMadre)
        command.Parameters.AddWithValue("IdSemovientePadre", _Semovientes.IdSemovientePadre)
        command.Parameters.AddWithValue("Nombre", _Semovientes.Nombre)
        command.Parameters.AddWithValue("Sexo", _Semovientes.Sexo)
        command.Parameters.AddWithValue("TipoIngreso", _Semovientes.TipoIngreso)
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

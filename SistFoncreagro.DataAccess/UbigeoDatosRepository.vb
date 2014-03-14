Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class UbigeoDatosRepository : Inherits MasterDataAccess : Implements IUbigeoDatosRepository
    Public Function GetAllFromUbigeoDatos() As System.Collections.Generic.List(Of BussinessEntities.UbigeoDatos) Implements IUbigeoDatosRepository.GetAllFromUbigeoDatos
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromUBIGEODATOS")
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of UbigeoDatos)
        Dim lista As New List(Of UbigeoDatos)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _UbigeoDatos As New UbigeoDatos() With
                    {
                        .CUBIGEO = reader.GetValue(reader.GetOrdinal("CUBIGEO")),
                        .Nombre = reader.GetValue(reader.GetOrdinal("Nombre"))
                    }
                If Not (reader.IsDBNull(reader.GetOrdinal("Departamento"))) Then
                    _UbigeoDatos.Departamento = reader.GetValue(reader.GetOrdinal("Departamento"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Provincia"))) Then
                    _UbigeoDatos.Provincia = reader.GetValue(reader.GetOrdinal("Provincia"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Distrito"))) Then
                    _UbigeoDatos.Distrito = reader.GetValue(reader.GetOrdinal("Distrito"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("CentroPoblado"))) Then
                    _UbigeoDatos.CentroPoblado = reader.GetValue(reader.GetOrdinal("CentroPoblado"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Caserio"))) Then
                    _UbigeoDatos.Caserio = reader.GetValue(reader.GetOrdinal("Caserio"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("FK"))) Then
                    _UbigeoDatos.FK = reader.GetValue(reader.GetOrdinal("FK"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Nivel"))) Then
                    _UbigeoDatos.Nivel = reader.GetValue(reader.GetOrdinal("Nivel"))
                End If

                lista.Add(_UbigeoDatos)
            End While
        End Using
        Return lista
    End Function

    Public Function GetUbigeoDatosByIdUbigeoDatos(ByVal _IdUbigeoDatos As String) As BussinessEntities.UbigeoDatos Implements IUbigeoDatosRepository.GetUbigeoDatosByIdUbigeoDatos
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetUBIGEODATOSById")
        command.Parameters.AddWithValue("CUbigeo", _IdUbigeoDatos)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetUbigeoDatosByNivel(ByVal _Nivel As String) As System.Collections.Generic.List(Of BussinessEntities.UbigeoDatos) Implements IUbigeoDatosRepository.GetUbigeoDatosByNivel
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetUBIGEODATOSByNivel")
        command.Parameters.AddWithValue("Nivel", _Nivel)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetUBIGEODATOSByParameter(ByVal texto As String) As System.Collections.Generic.List(Of BussinessEntities.UbigeoDatos) Implements IUbigeoDatosRepository.GetUBIGEODATOSByParameter
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetUBIGEODATOSByParameter")
        command.Parameters.AddWithValue("texto", texto)
        Return SelectObjectFactory(command)
    End Function
End Class

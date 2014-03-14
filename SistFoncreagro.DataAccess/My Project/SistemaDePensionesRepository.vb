Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class SistemaDePensionesRepository : Inherits MasterDataAccess : Implements ISistemaDePensionesRepository

    Public Function GetAllFromSistemaPensiones() As System.Collections.Generic.List(Of BussinessEntities.SistemaDePensiones) Implements ISistemaDePensionesRepository.GetAllFromSistemaPensiones

    End Function

    Public Sub SaveSistemaPensiones(ByVal sistemaPension As BussinessEntities.SistemaDePensiones) Implements ISistemaDePensionesRepository.SaveSistemaPensiones

    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of SistemaDePensiones)
        Dim listaSistemaPensiones As New List(Of SistemaDePensiones)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim sistemaPensiones As New SistemaDePensiones
                With sistemaPensiones
                    .IdSistemaPensiones = reader.GetInt32(0)
                    .Descripcion = reader.GetString(1)
                    .NombreCorto = reader.GetString(2)
                    .IdTipoSp = reader.GetInt32(3)
                End With
                If Not reader.IsDBNull(4) Then
                    sistemaPensiones.CodSunat = reader.GetString(4)
                End If
                listaSistemaPensiones.Add(sistemaPensiones)
            End While
        End Using
        Return listaSistemaPensiones
    End Function

    Public Function GetAllFromSistemaPensionesByTipoSp(ByVal idTipoSp As Integer) As System.Collections.Generic.List(Of BussinessEntities.SistemaDePensiones) Implements ISistemaDePensionesRepository.GetAllFromSistemaPensionesByTipoSp
        Dim command As SqlCommand =
            MyBase.CreateSPCommand("GetAllFromSistemaPensionesByTipoSp")
        command.Parameters.AddWithValue("TipoSp", idTipoSp)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFromSistemaPensionesByIdSistemaPensiones(ByVal idSistemaPensiones As Integer) As BussinessEntities.SistemaDePensiones Implements ISistemaDePensionesRepository.GetFromSistemaPensionesByIdSistemaPensiones
        Dim command As SqlCommand =
    MyBase.CreateSPCommand("GetFromSistemaPensionesByIdSistemaPensiones")
        command.Parameters.AddWithValue("IdSistemaPensiones", idSistemaPensiones)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    ''''
    Public Function GetSistemaDePensionesByIdSistemaPensiones(ByVal IdSistemaPensiones As Integer) As Object Implements ISistemaDePensionesRepository.GetSistemaDePensionesByIdSistemaPensiones
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetSistemaDePensionesByIdSistemaPensiones")
        command.Parameters.AddWithValue("IdSistemaPensiones", IdSistemaPensiones)
        Return SelectObjectFactory2(command).SingleOrDefault
    End Function

    Private Function SelectObjectFactory2(ByVal command As SqlCommand) As List(Of SistemaDePensiones)
        Dim lista As New List(Of SistemaDePensiones)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New SistemaDePensiones
                If Not reader.IsDBNull(reader.GetOrdinal("CodSunat")) Then
                    entity.CodSunat = reader.GetValue(reader.GetOrdinal("CodSunat"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdSistemaPensiones")) Then
                    entity.IdSistemaPensiones = reader.GetValue(reader.GetOrdinal("IdSistemaPensiones"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoSP")) Then
                    entity.IdTipoSp = reader.GetValue(reader.GetOrdinal("IdTipoSP"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("NombreCorto")) Then
                    entity.NombreCorto = reader.GetValue(reader.GetOrdinal("NombreCorto"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '

    End Function
End Class

Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class AdjMonitRepository : Inherits MasterDataAccess : Implements IAdjMonitRepository

    Public Sub DeleteAdjMonit(ByVal _id As Integer) Implements IAdjMonitRepository.DeleteAdjMonit
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteADJMONIT")
        command.Parameters.AddWithValue("idAdjMonit", _id)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetADJMONITByIdAdjMonit(ByVal _id As Integer) As BussinessEntities.AdjMonit Implements IAdjMonitRepository.GetADJMONITByIdAdjMonit
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetADJMONITByIdAdjMonit")
        command.Parameters.AddWithValue("idAdjMonit", _id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetAllFromAdjMonit() As System.Collections.Generic.List(Of BussinessEntities.AdjMonit) Implements IAdjMonitRepository.GetAllFromAdjMonit
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromADJMONIT")
        Return SelectObjectFactory(command)
    End Function

    Public Function SaveAdjMonit(ByVal _AdjMonit As BussinessEntities.AdjMonit) As Integer Implements IAdjMonitRepository.SaveAdjMonit
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveADJMONIT")
        Dim Id As Int32

        command.Parameters.AddWithValue("IdAdjMonit", _AdjMonit.IdAdjMonit)
        command.Parameters.AddWithValue("Id", _AdjMonit.Id)
        command.Parameters.AddWithValue("Tabla", _AdjMonit.Tabla)
        command.Parameters.AddWithValue("Ruta", _AdjMonit.Ruta)
        command.Parameters.AddWithValue("Descripcion", _AdjMonit.Descripcion)
        command.Parameters.AddWithValue("Fecha ", _AdjMonit.Fecha)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of AdjMonit)
        Dim lista As New List(Of AdjMonit)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _AdjMonit As New AdjMonit() With
                    {
                        .IdAdjMonit = reader.GetValue(reader.GetOrdinal("IdAdjMonit")),
                        .Ruta = reader.GetValue(reader.GetOrdinal("Ruta")),
                        .Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                    }
                If Not (reader.IsDBNull(reader.GetOrdinal("Fecha"))) Then
                    _AdjMonit.Fecha = reader.GetValue(reader.GetOrdinal("Fecha"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Id"))) Then
                    _AdjMonit.Id = reader.GetValue(reader.GetOrdinal("Id"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Tabla"))) Then
                    _AdjMonit.Tabla = reader.GetValue(reader.GetOrdinal("Tabla"))
                End If
                lista.Add(_AdjMonit)
            End While
        End Using
        Return lista
    End Function

    Public Function GetADJMONITByIdAndTabla(ByVal _Id As Integer, ByVal _Tabla As String) As System.Collections.Generic.List(Of BussinessEntities.AdjMonit) Implements IAdjMonitRepository.GetADJMONITByIdAndTabla
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetADJMONITByIdAndTabla")
        command.Parameters.AddWithValue("Id", _Id)
        command.Parameters.AddWithValue("Tabla", _Tabla)
        Return SelectObjectFactory(command)
    End Function
End Class

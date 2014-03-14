Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class InformeProyectoRepository : Inherits MasterDataAccess : Implements IInformeProyectoRepository

    Public Sub DeleteInformeProyecto(ByVal _id As Integer) Implements IInformeProyectoRepository.DeleteInformeProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteINFORMEPROYECTO")
        command.Parameters.AddWithValue("idInfProy", _id)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetInformeProyectoByIdProyecto(ByVal _idProy As Integer) As System.Collections.Generic.List(Of BussinessEntities.InformeProyecto) Implements IInformeProyectoRepository.GetInformeProyectoByIdProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetINFORMEPROYECTOByIdProyecto")
        command.Parameters.AddWithValue("idProyecto", _idProy)
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of InformeProyecto)
        Dim lista As New List(Of InformeProyecto)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)

            While reader.Read
                Dim _InformeProyecto As New InformeProyecto() With
                    {
                        .IdInfProy = reader.GetValue(reader.GetOrdinal("IdInfProy")),
                        .IdProyecto = reader.GetValue(reader.GetOrdinal("IdProyecto")),
                        .Tipo = reader.GetValue(reader.GetOrdinal("Tipo"))
                    }
                If Not (reader.IsDBNull(reader.GetOrdinal("FechaProg"))) Then
                    _InformeProyecto.FechaProg = reader.GetValue(reader.GetOrdinal("FechaProg"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("FechaPresen"))) Then
                    _InformeProyecto.FechaPresen = reader.GetValue(reader.GetOrdinal("FechaPresen"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Estado"))) Then
                    _InformeProyecto.Estado = reader.GetValue(reader.GetOrdinal("Estado"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("IdAdjMonit"))) Then
                    _InformeProyecto.IdAdjMonit = reader.GetValue(reader.GetOrdinal("IdAdjMonit"))
                End If

                Dim _miArchivo As New AdjMonitRepository
                _InformeProyecto._Archivo = _miArchivo.GetADJMONITByIdAdjMonit(_InformeProyecto.IdAdjMonit)

                lista.Add(_InformeProyecto)
            End While
        End Using
        Return lista
    End Function

    Public Function SaveInformeProyecto(ByVal _InformeProyecto As BussinessEntities.InformeProyecto) As Integer Implements IInformeProyectoRepository.SaveInformeProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveINFORMEPROYECTO")
        Dim Id As Int32

        command.Parameters.AddWithValue("IdInfProy", _InformeProyecto.IdInfProy)
        command.Parameters.AddWithValue("IdProyecto", _InformeProyecto.IdProyecto)
        command.Parameters.AddWithValue("Tipo", _InformeProyecto.Tipo)
        command.Parameters.AddWithValue("FechaProg", _InformeProyecto.FechaProg)
        command.Parameters.AddWithValue("FechaPresen", _InformeProyecto.FechaPresen)
        command.Parameters.AddWithValue("Estado", _InformeProyecto.Estado)
        command.Parameters.AddWithValue("IdAdjMonit", _InformeProyecto.IdAdjMonit)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function

    Public Function GetAllFromInformeProyectoById(ByVal _id As Integer) As BussinessEntities.InformeProyecto Implements IInformeProyectoRepository.GetAllFromInformeProyectoById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromINFORMEPROYECTOById")
        command.Parameters.AddWithValue("idInfProy", _id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
End Class

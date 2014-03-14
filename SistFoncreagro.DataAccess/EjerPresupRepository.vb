Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class EjerPresupRepository : Inherits MasterDataAccess : Implements IEjerPresupRepository

    Public Function DeleteEjerPresup(ByVal _id As Integer) As String Implements IEjerPresupRepository.DeleteEjerPresup
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteEJERPRESUP")
        command.Parameters.AddWithValue("idEjerPresup", _id)
        Dim mMensaje As String
        mMensaje = ""
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                mMensaje = reader.GetValue(0)
            End If
        End Using
        Return mMensaje
    End Function

    Public Function GetAllFromEjerPresup() As System.Collections.Generic.List(Of BussinessEntities.EjerPresup) Implements IEjerPresupRepository.GetAllFromEjerPresup
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromEJERPRESUP")
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of EjerPresup)
        Dim lista As New List(Of EjerPresup)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _EjerPresup As New EjerPresup() With
                    {
                        .IdEjerPresup = reader.GetValue(reader.GetOrdinal("IdEjerPresup"))
                    }
                If Not (reader.IsDBNull(reader.GetOrdinal("FechaInicio"))) Then
                    _EjerPresup.FechaInicio = reader.GetValue(reader.GetOrdinal("FechaInicio"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("FechaFin"))) Then
                    _EjerPresup.FechaFin = reader.GetValue(reader.GetOrdinal("FechaFin"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Codigo"))) Then
                    _EjerPresup.Codigo = reader.GetValue(reader.GetOrdinal("Codigo"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Estado"))) Then
                    _EjerPresup.Estado = reader.GetValue(reader.GetOrdinal("Estado"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Tipo"))) Then
                    _EjerPresup.Tipo = reader.GetValue(reader.GetOrdinal("Tipo"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Anio"))) Then
                    _EjerPresup.Anio = reader.GetValue(reader.GetOrdinal("Anio"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("MesIni"))) Then
                    _EjerPresup.MesIni = reader.GetValue(reader.GetOrdinal("MesIni"))
                End If
                lista.Add(_EjerPresup)
            End While
        End Using
        Return lista
    End Function

    Public Function GetEjerPresupByIdEjerPresup(ByVal _id As Integer) As BussinessEntities.EjerPresup Implements IEjerPresupRepository.GetEjerPresupByIdEjerPresup
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetEJERPRESUPByIdEjerPresup")
        command.Parameters.AddWithValue("idEjerPresup", _id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetEjerPresupByEstado(ByVal _Estado As String) As BussinessEntities.EjerPresup Implements IEjerPresupRepository.GetEjerPresupByEstado
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetEJERPRESUPByEstado")
        command.Parameters.AddWithValue("Estado", _Estado)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveEjerPresup(ByVal _EjerPresup As BussinessEntities.EjerPresup) As String Implements IEjerPresupRepository.SaveEjerPresup
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveEJERPRESUP")
        Dim mError As String
        mError = ""
        command.Parameters.AddWithValue("IdEjerPresup", _EjerPresup.IdEjerPresup)
        command.Parameters.AddWithValue("FechaInicio", _EjerPresup.FechaInicio)
        command.Parameters.AddWithValue("FechaFin", _EjerPresup.FechaFin)
        command.Parameters.AddWithValue("Estado", _EjerPresup.Estado)
        command.Parameters.AddWithValue("Tipo", _EjerPresup.Tipo)
        command.Parameters.AddWithValue("Anio", _EjerPresup.Anio)
        command.Parameters.AddWithValue("MesIni", _EjerPresup.MesIni)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                mError = reader.GetValue(0)
            End If
        End Using
        Return mError
    End Function

    Public Function EjerPresupEstado() As String Implements IEjerPresupRepository.EjerPresupEstado
        Dim command As SqlCommand = MyBase.CreateSPCommand("EjerPresupEstado")
        Dim mMensaje As String
        mMensaje = ""
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                mMensaje = reader.GetValue(0)
            End If
        End Using
        Return mMensaje
    End Function
End Class

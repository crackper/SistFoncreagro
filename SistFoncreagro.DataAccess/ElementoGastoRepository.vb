Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class ElementoGastoRepository : Inherits MasterDataAccess : Implements IElementoGastoRepository

    Public Function GetAllFromElementoGasto() As System.Collections.Generic.List(Of BussinessEntities.ElementoGasto) Implements IElementoGastoRepository.GetAllFromElementoGasto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromELEMENTOGASTO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFromElementoGastoById(ByVal _id As Integer) As BussinessEntities.ElementoGasto Implements IElementoGastoRepository.GetFromElementoGastoById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetELEMGASTOByIdElemGasto")
        command.Parameters.AddWithValue("IdElemGasto", _id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetFromElementoGastoByIdClasificacion(ByVal _id As Integer) As BussinessEntities.ElementoGasto Implements IElementoGastoRepository.GetFromElementoGastoByIdClasificacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetELEMGASTOByIdClasificacion")
        command.Parameters.AddWithValue("IdClasificacion", _id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ElementoGasto)
        Dim lista As New List(Of ElementoGasto)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _ElementoGasto As New ElementoGasto() With
                    {
                        .IdElemGasto = reader.GetValue(reader.GetOrdinal("IdElemGasto")),
                        .IdClasificacion = reader.GetValue(reader.GetOrdinal("IdClasificacion"))
                    }
                If Not (reader.IsDBNull(reader.GetOrdinal("DesElemGasto"))) Then
                    _ElementoGasto.DesElemGasto = reader.GetValue(reader.GetOrdinal("DesElemGasto"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("CodElemGasto"))) Then
                    _ElementoGasto.CodElemGasto = reader.GetValue(reader.GetOrdinal("CodElemGasto"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("NomElemGasto"))) Then
                    _ElementoGasto.NomElemGasto = reader.GetValue(reader.GetOrdinal("NomElemGasto"))
                End If

                Dim _miClasif As New ClasificacionRepository
                _ElementoGasto._Clasificacion = _miClasif.GetFromClasificacionById(_ElementoGasto.IdClasificacion)

                lista.Add(_ElementoGasto)
            End While
        End Using
        Return lista
    End Function

    Public Function DeleteElementoGasto(ByVal _id As Integer) As String Implements IElementoGastoRepository.DeleteElementoGasto
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteELEMENTOGASTO")
        command.Parameters.AddWithValue("idElemGasto", _id)

        Dim mMensaje As String
        mMensaje = ""
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                mMensaje = reader.GetValue(0)
            End If
        End Using
        Return mMensaje
    End Function

    Public Function SaveElementoGasto(ByVal _ElementoGasto As BussinessEntities.ElementoGasto) As Integer Implements IElementoGastoRepository.SaveElementoGasto
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveELEMGASTO")

        command.Parameters.AddWithValue("IdElemGasto", _ElementoGasto.IdElemGasto)
        'command.Parameters.AddWithValue("CodElemGasto", _ElementoGasto.CodElemGasto)
        command.Parameters.AddWithValue("NomElemGasto", _ElementoGasto.NomElemGasto)
        command.Parameters.AddWithValue("DesElemGasto", _ElementoGasto.DesElemGasto)
        command.Parameters.AddWithValue("IdClasificacion", _ElementoGasto.IdClasificacion)
        Dim id As Int32

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                id = reader.GetValue(0)
            End If
        End Using

        Return id

    End Function
End Class

Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class AdendaRepository : Inherits MasterDataAccess : Implements IAdendaRepository

    Public Function GetAllFromAdenda() As System.Collections.Generic.List(Of BussinessEntities.Adenda) Implements IAdendaRepository.GetAllFromAdenda
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromADENDA")
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Adenda)
        Dim lista As New List(Of Adenda)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Adenda As New Adenda() With
                {
                .IdAdenda = reader.GetValue(reader.GetOrdinal("IdAdenda")),
                .IdConvenio = reader.GetValue(reader.GetOrdinal("IdConvenio")),
                 .Numero = reader.GetValue(reader.GetOrdinal("Numero")),
                 .Fecha = reader.GetValue(reader.GetOrdinal("Fecha"))
                }
                If Not (reader.IsDBNull(reader.GetOrdinal("Motivo"))) Then
                    _Adenda.Motivo = reader.GetValue(reader.GetOrdinal("Motivo"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Monto"))) Then
                    _Adenda.Monto = reader.GetValue(reader.GetOrdinal("Monto"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("FechaFin"))) Then
                    _Adenda.FechaFin = reader.GetValue(reader.GetOrdinal("FechaFin"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("VigenciaIni"))) Then
                    _Adenda.VigenciaIni = reader.GetValue(reader.GetOrdinal("VigenciaIni"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("VigenciaFin"))) Then
                    _Adenda.VigenciaFin = reader.GetValue(reader.GetOrdinal("VigenciaFin"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Costo"))) Then
                    _Adenda.Costo = reader.GetValue(reader.GetOrdinal("Costo"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Responsable"))) Then
                    _Adenda.Responsable = reader.GetValue(reader.GetOrdinal("Responsable"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Tiempo"))) Then
                    _Adenda.Tiempo = reader.GetValue(reader.GetOrdinal("Tiempo"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Alcance"))) Then
                    _Adenda.Alcance = reader.GetValue(reader.GetOrdinal("Alcance"))
                End If
                lista.Add(_Adenda)
            End While
        End Using
        Return lista
    End Function

    Public Function SaveAdenda(ByVal _Adenda As BussinessEntities.Adenda) As Integer Implements IAdendaRepository.SaveAdenda
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveADENDA")
        Dim Id As Int32

        command.Parameters.AddWithValue("IdAdenda", _Adenda.IdAdenda)
        command.Parameters.AddWithValue("IdConvenio", _Adenda.IdConvenio)
        command.Parameters.AddWithValue("Fecha ", _Adenda.Fecha)
        command.Parameters.AddWithValue("Motivo", _Adenda.Motivo)
        command.Parameters.AddWithValue("Monto", _Adenda.Monto)
        command.Parameters.AddWithValue("FechaFin", _Adenda.FechaFin)
        command.Parameters.AddWithValue("VigenciaIni", _Adenda.VigenciaIni)
        command.Parameters.AddWithValue("VigenciaFin", _Adenda.VigenciaFin)
        command.Parameters.AddWithValue("Costo", _Adenda.Costo)
        command.Parameters.AddWithValue("Responsable", _Adenda.Responsable)
        command.Parameters.AddWithValue("Tiempo", _Adenda.Tiempo)
        command.Parameters.AddWithValue("Alcance", _Adenda.Alcance)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function

    Public Function GetFromAdendaByIdConvenio(ByVal _id As Integer) As System.Collections.Generic.List(Of BussinessEntities.Adenda) Implements IAdendaRepository.GetFromAdendaByIdConvenio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetADENDAByIdConvenio")
        command.Parameters.AddWithValue("IdConvenio", _id)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFromAdendaByIdAdenda(ByVal _id As Integer) As BussinessEntities.Adenda Implements IAdendaRepository.GetFromAdendaByIdAdenda
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetADENDAByIdAdenda")
        command.Parameters.AddWithValue("IdAdenda", _id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub DeleteAdenda(ByVal _id As Integer) Implements IAdendaRepository.DeleteAdenda
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteADENDA")
        command.Parameters.AddWithValue("idAdenda", _id)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class

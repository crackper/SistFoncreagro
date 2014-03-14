Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class DesembolsoRepository : Inherits MasterDataAccess : Implements IDesembolsoRepository

    Public Function GetAllFromDesembolsos() As System.Collections.Generic.List(Of BussinessEntities.Desembolso) Implements IDesembolsoRepository.GetAllFromDesembolsos
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromDESEMBOLSOS")
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Desembolso)
        Dim lista As New List(Of Desembolso)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read

                Dim _Desembolso As New Desembolso() With
                {.IdDesembolso = reader.GetValue(reader.GetOrdinal("IdDesembolso")),
                .IdConvenio = reader.GetValue(reader.GetOrdinal("IdConvenio"))
                }

                If Not (reader.IsDBNull(reader.GetOrdinal("Numero"))) Then
                    _Desembolso.Numero = reader.GetValue(reader.GetOrdinal("Numero"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("MontoEjec"))) Then
                    _Desembolso.MontoEjec = reader.GetValue(reader.GetOrdinal("MontoEjec"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("MontoProg"))) Then
                    _Desembolso.MontoProg = reader.GetValue(reader.GetOrdinal("MontoProg"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("FechaEjec"))) Then
                    _Desembolso.FechaEjec = reader.GetValue(reader.GetOrdinal("FechaEjec"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("FechaProg"))) Then
                    _Desembolso.FechaProg = reader.GetValue(reader.GetOrdinal("FechaProg"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Estado"))) Then
                    _Desembolso.Estado = reader.GetValue(reader.GetOrdinal("Estado"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("IdProveedorCliente"))) Then
                    _Desembolso.IdProveedorCliente = reader.GetValue(reader.GetOrdinal("IdProveedorCliente"))
                End If
                Dim _miInstitucion As New ProveedorClienteRepository
                _Desembolso._ProveedorCliente = _miInstitucion.GetAllFromProveedorClienteById(_Desembolso.IdProveedorCliente)
                lista.Add(_Desembolso)
            End While
        End Using
        Return lista
    End Function

    Public Function SaveDesembolso(ByVal _Desembolso As BussinessEntities.Desembolso) As Integer Implements IDesembolsoRepository.SaveDesembolso
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDESEMBOLSOS")
        Dim Id As Int32

        command.Parameters.AddWithValue("IdDesembolso", _Desembolso.IdDesembolso)
        command.Parameters.AddWithValue("IdConvenio", _Desembolso.IdConvenio)
        command.Parameters.AddWithValue("MontoProg", _Desembolso.MontoProg)
        command.Parameters.AddWithValue("FechaProg", _Desembolso.FechaProg)
        command.Parameters.AddWithValue("Estado", _Desembolso.Estado)
        command.Parameters.AddWithValue("IdProveedorCliente", _Desembolso.IdProveedorCliente)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id

        MyBase.ExecuteNonQuery(command)

    End Function

    Public Function GetFromDesembolsoByIdConvenio(ByVal _id As Integer) As System.Collections.Generic.List(Of BussinessEntities.Desembolso) Implements IDesembolsoRepository.GetFromDesembolsoByIdConvenio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDESEMBOLSOSByIdConvenio")
        command.Parameters.AddWithValue("idConvenio", _id)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFromDesembolsoByIdDesembolso(ByVal id As Integer) As BussinessEntities.Desembolso Implements IDesembolsoRepository.GetFromDesembolsoByIdDesembolso
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDESEMBOLSOSByIdDesembolso")
        command.Parameters.AddWithValue("idDesembolso", id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub DeleteDesembolso(ByVal _id As Integer) Implements IDesembolsoRepository.DeleteDesembolso
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDesembolso")
        command.Parameters.AddWithValue("idDesembolso", _id)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class

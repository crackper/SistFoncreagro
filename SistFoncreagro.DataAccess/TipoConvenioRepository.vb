Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class TipoConvenioRepository : Inherits MasterDataAccess : Implements ITipoConvenioRepository

    Public Function GetAllFromTipoConvenio() As System.Collections.Generic.List(Of BussinessEntities.TipoConvenio) Implements ITipoConvenioRepository.GetAllFromTipoConvenio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTIPOCONVENIO")
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoConvenio)
        Dim lista As New List(Of TipoConvenio)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _TipoConvenio As New TipoConvenio() With
                {.IdTipConv = reader.GetValue(reader.GetOrdinal("IdTipConv")),
                 .Nombre = reader.GetValue(reader.GetOrdinal("Nombre"))
                }
                lista.Add(_TipoConvenio)
            End While
        End Using
        Return lista
    End Function

    Public Function GetTipoConvenioByIdTipoConvenio(ByVal _IdTipoConvenio As Integer) As BussinessEntities.TipoConvenio Implements ITipoConvenioRepository.GetTipoConvenioByIdTipoConvenio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTIPOCONVENIOByIdTipoConvenio")
        command.Parameters.AddWithValue("idTipConv", _IdTipoConvenio)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub DeleteTipoConvenio(ByVal id As String) Implements ITipoConvenioRepository.DeleteTipoConvenio
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteTIPOCONVENIO")
        command.Parameters.AddWithValue("idTipoConvenio", id)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function SaveTipoConvenio(ByVal _TipoConvenio As BussinessEntities.TipoConvenio) As Integer Implements ITipoConvenioRepository.SaveTipoConvenio
        Dim command As SqlCommand = MyBase.CreateSPCommand("InsertTIPOCONVENIO")
        Dim Id As Int32

        command.Parameters.AddWithValue("IdTipConv", _TipoConvenio.IdTipConv)
        command.Parameters.AddWithValue("Nombre", _TipoConvenio.Nombre)
        MyBase.ExecuteNonQuery(command)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function
End Class

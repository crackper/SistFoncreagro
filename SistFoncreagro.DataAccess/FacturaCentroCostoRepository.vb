Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class FacturaCentroCostoRepository : Inherits MasterDataAccess : Implements IFacturaCentroCostoRepository
    Dim tipoDocumentoRepository As ITipoDocumentoRepository
    Sub New()
        tipoDocumentoRepository = New TipoDocumentoRepository
    End Sub
    Public Function GetAllFromFacturaCentroCostoByIdOrdenCentroCosto(ByVal IdOrdenCentroCosto As Integer) As System.Collections.Generic.List(Of BussinessEntities.FacturaCentroCosto) Implements IFacturaCentroCostoRepository.GetAllFromFacturaCentroCostoByIdOrdenCentroCosto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromFacturaCentroCostoByIdOrdenCentroCosto")
        command.Parameters.AddWithValue("IdOrdenCentroCosto", IdOrdenCentroCosto)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveFacturaCentroCosto(ByVal facturaCCosto As BussinessEntities.FacturaCentroCosto) Implements IFacturaCentroCostoRepository.SaveFacturaCentroCosto
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveFacturaCentroCosto")
        command.Parameters.AddWithValue("IdOrdenCentroCosto", facturaCCosto.IdOrdenCentroCosto)
        command.Parameters.AddWithValue("IdTipoDocumento", facturaCCosto.IdTipoDocumento)
        command.Parameters.AddWithValue("Serie", facturaCCosto.Serie)
        command.Parameters.AddWithValue("Numero", facturaCCosto.Numero)
        command.Parameters.AddWithValue("MontoFact", facturaCCosto.MontoFact)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub DeleteFacturaCentroCosto(ByVal IdFacturaCentroCosto As Integer) Implements IFacturaCentroCostoRepository.DeleteFacturaCentroCosto
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteFacturaCentroCosto")
        command.Parameters.AddWithValue("IdFacturaCentroCosto", IdFacturaCentroCosto)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of FacturaCentroCosto)
        Dim listaFacturaCCosto As New List(Of FacturaCentroCosto)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim facturaCCosto As New FacturaCentroCosto
                With facturaCCosto
                    .IdFacturaCentroCosto = reader.GetInt32(0)
                    .IdOrdenCentroCosto = reader.GetInt32(1)
                    .IdTipoDocumento = reader.GetInt32(2)
                    .Serie = reader.GetString(3)
                    .Numero = reader.GetString(4)
                    .MontoFact = reader.GetDecimal(5)
                    .documento = tipoDocumentoRepository.GetTIPODOCUMENTOByIdTipoDocumento(reader.GetInt32(2))
                End With
                listaFacturaCCosto.Add(facturaCCosto)
            End While
        End Using
        Return listaFacturaCCosto
    End Function
End Class

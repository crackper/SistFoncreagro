Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class OrdenCentroCostoRepository : Inherits MasterDataAccess : Implements IOrdenCentroCostoRepository
    Dim centroCosto As ICCostoRepository
    Sub New()
        centroCosto = New CCostoRepository
    End Sub
    Public Function GetAllFromOrdenCentroCostoByIdOrdenCompra(ByVal IdOrdenCOmpra As Integer) As System.Collections.Generic.List(Of BussinessEntities.OrdenCentroCosto) Implements IOrdenCentroCostoRepository.GetAllFromOrdenCentroCostoByIdOrdenCompra
        Dim command As SqlCommand =
              MyBase.CreateSPCommand("GetAllFromOrdenCentroCostoByIdOrdenCompra")
        command.Parameters.AddWithValue("IdOrdenCompra", IdOrdenCOmpra)
        Return SelectObjectFactory(command)
    End Function
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of OrdenCentroCosto)
        Dim listaOrdenCentro As New List(Of OrdenCentroCosto)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim ordenCCosto As New OrdenCentroCosto
                With ordenCCosto
                    .IdOrdenCentroCosto = reader.GetInt32(0)
                    .IdOrdenCompra = reader.GetInt32(1)
                    .IdCentroCosto = reader.GetInt32(2)
                    .Monto = reader.GetDecimal(3)
                    .Estado = reader.GetString(4)
                End With
                ordenCCosto.centroC = centroCosto.GetCCOSTOByIdCCosto(reader.GetInt32(2))
                listaOrdenCentro.Add(ordenCCosto)
            End While
        End Using
        Return listaOrdenCentro
    End Function

    Public Sub FinalizarRegOrdenCompraCentroCosto(ByVal IdOrdenCentroCosto As Object) Implements IOrdenCentroCostoRepository.FinalizarRegOrdenCompraCentroCosto
        Dim command As SqlCommand = MyBase.CreateSPCommand("FinalizarRegOrdenCompraCentroCosto")
        command.Parameters.AddWithValue("IdOrdenCentroCosto", IdOrdenCentroCosto)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class

Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class RazonSoulSourceRepository : Inherits MasterDataAccess : Implements IRazonSoulSourceRepository

    Public Function GetAllFromRazones() As System.Collections.Generic.List(Of BussinessEntities.RazonSoulSource) Implements IRazonSoulSourceRepository.GetAllFromRazones
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromRazones")
        Return SelectObjectFactory(command)
    End Function

    Public Sub UpdateRazonCotizaconSoulSource(ByVal IdContizacion As Integer, ByVal IdRazon As Integer) Implements IRazonSoulSourceRepository.UpdateRazonCotizaconSoulSource
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateRazonCotizaconSoulSource")
        command.Parameters.AddWithValue("IdOrdenCompra", IdContizacion)
        command.Parameters.AddWithValue("IdPersonaRecepciona", IdRazon)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of RazonSoulSource)
        Dim listaRazon As New List(Of RazonSoulSource)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim aRazon As New RazonSoulSource
                With aRazon
                    .IdRazonSoulSource = reader.GetInt32(0)
                    .Descripcion = reader.GetString(1)
                End With
                listaRazon.Add(aRazon)
            End While
        End Using
        Return listaRazon
    End Function
End Class

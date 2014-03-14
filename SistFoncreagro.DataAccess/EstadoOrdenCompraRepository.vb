Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class EstadoOrdenCompraRepository : Inherits MasterDataAccess : Implements IEstadoOrdenCompraRepository
    Dim persona As IPersonalRepository
    Dim rol As IRolRepository
    Sub New()
        persona = New PersonalRepository
    End Sub
    Public Function GetAllFromEstadoOrdenCompraByIdOrdenCompra(ByVal IdOrdenCompra As Integer) As System.Collections.Generic.List(Of BussinessEntities.EstadoOrdenCompra) Implements IEstadoOrdenCompraRepository.GetAllFromEstadoOrdenCompraByIdOrdenCompra
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromEstadoOrdenCompraByIdOrdenCompra")
        command.Parameters.AddWithValue("IdOrdenCompra", IdOrdenCompra)
        Return SelectObjectFactory(command)
    End Function
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of EstadoOrdenCompra)
        Dim listaEstadoOrdenCompra As New List(Of EstadoOrdenCompra)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim estadoOrden As New EstadoOrdenCompra

                With estadoOrden
                    .IdEstadoOrdenCompra = reader.GetInt32(0)
                    .IdOrdenCompra = reader.GetInt32(1)
                    .IdPersonal = reader.GetInt32(2)
                    .IdRol = reader.GetInt32(4)
                End With
                If Not reader.IsDBNull(3) Then
                    estadoOrden.FechaApruebaAnula = reader.GetDateTime(3)
                End If
                estadoOrden.persona = persona.GetPersonalByIdPersonal(reader.GetInt32(2))
                listaEstadoOrdenCompra.Add(estadoOrden)
            End While
        End Using
        Return listaEstadoOrdenCompra
    End Function
End Class

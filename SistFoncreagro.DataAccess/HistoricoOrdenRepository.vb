Imports System.Data.Common
Imports System.Data.SqlClient
Imports SistFoncreagro.BussinessEntities
Public Class HistoricoOrdenRepository : Inherits MasterDataAccess : Implements IHistoricoOrdenRepository
    Dim personaFactory As IPersonalRepository
    Sub New()
        personaFactory = New PersonalRepository
    End Sub
    Public Function GetAllFromHistoricoByIdOrdenCompra(ByVal IdOrdenCOmpra As Integer) As System.Collections.Generic.List(Of BussinessEntities.HistoricoOrden) Implements IHistoricoOrdenRepository.GetAllFromHistoricoByIdOrdenCompra
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromHistoricoByIdOrdenCompra")
        command.Parameters.AddWithValue("IdOrdenCompra ", IdOrdenCOmpra)
        Return SelectObjectFactory(command)
    End Function
    Public Sub RechazarOrden(ByVal historicoOrden As BussinessEntities.HistoricoOrden) Implements IHistoricoOrdenRepository.RechazarOrden
        Dim command As SqlCommand = MyBase.CreateSPCommand("RechazarOrden")
        command.Parameters.AddWithValue("IdOrdenCompra ", historicoOrden.IdOrden)
        command.Parameters.AddWithValue("IdPersonal", historicoOrden.IdPersonal)
        command.Parameters.AddWithValue("Motivo", historicoOrden.Motivo)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of HistoricoOrden)
        Dim listaHistorico As New List(Of HistoricoOrden)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim historicoOrden As New HistoricoOrden
                With historicoOrden
                    .IdHistorico = reader.GetInt32(0)
                    .IdOrden = reader.GetInt32(1)
                    .IdPersonal = reader.GetInt32(2)
                    .Fecha = reader.GetDateTime(3)
                    .Motivo = reader.GetString(4)
                    .DetalleAprobacion = reader.GetString(5)
                End With
                historicoOrden.personaRechaza = personaFactory.GetPersonalByIdPersonal(reader.GetInt32(2))
                listaHistorico.Add(historicoOrden)
            End While
        End Using
        Return listaHistorico
    End Function
End Class

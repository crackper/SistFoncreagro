Imports System.Data.Common
Imports System.Data.SqlClient
Imports SistFoncreagro.BussinessEntities

Public Class HistoricoRequerimientoRepository : Inherits MasterDataAccess : Implements IHistoricoRequerimientoRepository
    Dim personaFactory As IPersonalRepository
    Sub New()
        personaFactory = New PersonalRepository
    End Sub
    Public Function GetAllFromHistoricoByIdRequerimiento(ByVal idRequerimiento As Integer) As System.Collections.Generic.List(Of BussinessEntities.HistoricoRequerimiento) Implements IHistoricoRequerimientoRepository.GetAllFromHistoricoByIdRequerimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromHistoricoByIdRequerimiento")
        command.Parameters.AddWithValue("IdRequerimiento", idRequerimiento)
        Return SelectObjectFactory(command)
    End Function

    Public Sub RechazarRequerimiento(ByVal historicoReq As BussinessEntities.HistoricoRequerimiento) Implements IHistoricoRequerimientoRepository.RechazarRequerimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("RechazarRequerimiento")
        command.Parameters.AddWithValue("IdRequerimiento", historicoReq.IdRequerimiento)
        command.Parameters.AddWithValue("IdPersonal", historicoReq.IdPersonal)
        command.Parameters.AddWithValue("Motivo", historicoReq.Motivo)
        command.Parameters.AddWithValue("Tipo", historicoReq.Tipo)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of HistoricoRequerimiento)
        Dim listaHistorico As New List(Of HistoricoRequerimiento)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim historicoReq As New HistoricoRequerimiento()
                With historicoReq
                    .IdHistorico = reader.GetInt32(0)
                    .IdRequerimiento = reader.GetInt32(1)
                    .IdPersonal = reader.GetInt32(2)
                    .Fecha = reader.GetDateTime(3)
                    .Motivo = reader.GetString(4)
                    .DetalleAprobacion = reader.GetString(5)
                End With
                historicoReq.personaRechaza = personaFactory.GetPersonalByIdPersonal(reader.GetInt32(2))
                listaHistorico.Add(historicoReq)
            End While
        End Using
        Return listaHistorico
    End Function


End Class

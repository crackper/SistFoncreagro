Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class AdjuntoCotizacionRepository : Inherits MasterDataAccess : Implements IAdjuntoCotizacionRepository

    Public Sub DeleteadjuntoCotizacion(ByVal IdAdjuntoCotizacion As Integer) Implements IAdjuntoCotizacionRepository.DeleteadjuntoCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteadjuntoCotizacion")
        command.Parameters.AddWithValue("IdAdjuntoCotizacion", IdAdjuntoCotizacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromAdjuntoCotizacionByIdCotizacion(ByVal idCotizacion As Integer) As System.Collections.Generic.List(Of BussinessEntities.AdjuntoCotizacion) Implements IAdjuntoCotizacionRepository.GetAllFromAdjuntoCotizacionByIdCotizacion
        Dim command As SqlCommand =
                     MyBase.CreateSPCommand("GetAllFromAdjuntoCotizacionByIdCotizacion")
        command.Parameters.AddWithValue("IdCotizacion", idCotizacion)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveAdjuntoCotizacion(ByVal adjunto As BussinessEntities.AdjuntoCotizacion) Implements IAdjuntoCotizacionRepository.SaveAdjuntoCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveAdjuntoCotizacion")
        command.Parameters.AddWithValue("IdCotizacion", adjunto.IdCotizacion)
        command.Parameters.AddWithValue("Nombre", adjunto.Nombre)
        command.Parameters.AddWithValue("NombreReport", adjunto.NombreReport)
        command.Parameters.AddWithValue("Oc", adjunto.Oc)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of AdjuntoCotizacion)
        Dim listaAdjunto As New List(Of AdjuntoCotizacion)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim adjunto As New AdjuntoCotizacion
                With adjunto
                    .IdAdjuntoCotizacion = reader.GetInt32(0)
                    .IdCotizacion = reader.GetInt32(1)
                    .Nombre = reader.GetString(2)
                    .Fecha = reader.GetDateTime(3)
                    .Estado = reader.GetBoolean(4)
                End With
                listaAdjunto.Add(adjunto)
            End While
        End Using
        Return listaAdjunto
    End Function
End Class

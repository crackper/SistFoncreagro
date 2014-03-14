Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class EstadoCotizacionRepository : Inherits MasterDataAccess : Implements IEstadoCotizacionRepository
    Dim persona As IPersonalRepository
    Dim rol As IRolRepository
    Sub New()
        persona = New PersonalRepository

    End Sub

    Public Function GetAllFromEstadoCotizacionByIdCotizacion(ByVal IdRequerimiento As Integer) As System.Collections.Generic.List(Of BussinessEntities.EstadoCotizacion) Implements IEstadoCotizacionRepository.GetAllFromEstadoCotizacionByIdCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromEstadoCotizacionByIdEstadoCotizacion")
        command.Parameters.AddWithValue("IdCotizacion", IdRequerimiento)
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of EstadoCotizacion)
        Dim listaEstadoCoti As New List(Of EstadoCotizacion)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim estadoCoti As New EstadoCotizacion
                With estadoCoti
                    .IdEstadoCotizacion = reader.GetInt32(0)
                    .IdCotizacion = reader.GetInt32(1)
                    .IdPersonal = reader.GetInt32(2)
                    .IdRol = reader.GetInt32(4)
                End With
                If Not reader.IsDBNull(3) Then
                    estadoCoti.FechaApruebaAnula = reader.GetDateTime(3)
                End If
                estadoCoti.persona = persona.GetPersonalByIdPersonal(reader.GetInt32(2))
                listaEstadoCoti.Add(estadoCoti)
            End While
        End Using
        Return listaEstadoCoti
    End Function
End Class

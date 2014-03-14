Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class EstadoRequerimientoRepository : Inherits MasterDataAccess : Implements IEstadoRequerimientoRepository
    Dim persona As IPersonalRepository
    Dim rol As IRolRepository
    Sub New()
        persona = New PersonalRepository

    End Sub
    Public Function GetAllFromEstadoRequerimientoByIdRequerimiento(ByVal IdRequerimiento As Integer) As System.Collections.Generic.List(Of BussinessEntities.EstadoRequerimiento) Implements IEstadoRequerimientoRepository.GetAllFromEstadoRequerimientoByIdRequerimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromEstadoRequerimientoByIdRequerimiento")
        command.Parameters.AddWithValue("IdRequerimiento", IdRequerimiento)
        Return SelectObjectFactory(command)
    End Function
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of EstadoRequerimiento)
        Dim listaEstadoRequerimiento As New List(Of EstadoRequerimiento)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim listaEstadoReq As New EstadoRequerimiento

                With listaEstadoReq
                    .IdEstadoRequerimiento = reader.GetInt32(0)
                    .IdRequerimiento = reader.GetInt32(1)
                    .IdPersonal = reader.GetInt32(2)
                    .IdRol = reader.GetInt32(4)
                End With
                If Not reader.IsDBNull(3) Then
                    listaEstadoReq.FechaApruebaAnula = reader.GetDateTime(3)
                End If
                listaEstadoReq.persona = persona.GetPersonalByIdPersonal(reader.GetInt32(2))
                listaEstadoRequerimiento.Add(listaEstadoReq)
            End While
        End Using
        Return listaEstadoRequerimiento
    End Function
End Class

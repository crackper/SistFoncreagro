Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class EjecucionRepository : Inherits MasterDataAccess : Implements IEjecucionRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Ejecucion)
        Dim lista As New List(Of Ejecucion)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Ejecucion As New Ejecucion() With
                {
                   .IdEjecucion = reader.GetValue(0),
                       .Fecha = reader.GetValue(1),
                       .IdUsuario = reader.GetValue(2),
                       .IdProyecto = reader.GetValue(3),
                       .Descripcion = reader.GetValue(4)
                }

                lista.Add(_Ejecucion)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteEJECUCION(ByVal IdEjecucion As Integer) Implements IEjecucionRepository.DeleteEJECUCION
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteEJECUCION")
        command.Parameters.AddWithValue("IdEjecucion", IdEjecucion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetEJECUCIONByIdEjecucion(ByVal IdEjecucion As Integer) As BussinessEntities.Ejecucion Implements IEjecucionRepository.GetEJECUCIONByIdEjecucion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetEJECUCIONByIdEjecucion")
        command.Parameters.AddWithValue("IdEjecucion", IdEjecucion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetEJECUCIONByIdProyecto(ByVal IdProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.Ejecucion) Implements IEjecucionRepository.GetEJECUCIONByIdProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetEJECUCIONByIdProyecto")
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        Return SelectObjectFactory(command)
    End Function

    Public Function SaveEJECUCION(ByVal _Ejecucion As BussinessEntities.Ejecucion) As Integer Implements IEjecucionRepository.SaveEJECUCION
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveEJECUCION")
        command.Parameters.AddWithValue("Descripcion", _Ejecucion.Descripcion)
        command.Parameters.AddWithValue("Fecha", _Ejecucion.Fecha)
        command.Parameters.AddWithValue("IdEjecucion", _Ejecucion.IdEjecucion)
        command.Parameters.AddWithValue("IdProyecto", _Ejecucion.IdProyecto)
        command.Parameters.AddWithValue("IdUsuario", _Ejecucion.IdUsuario)
        Dim i As Int32
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If

            End If
        End Using
        Return i
    End Function
End Class

Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class DetEjerPresupRepository : Inherits MasterDataAccess : Implements IDetEjerPresupRepository

    Public Function GetAllFromDetEjerPresup() As System.Collections.Generic.List(Of BussinessEntities.DetEjerPresup) Implements IDetEjerPresupRepository.GetAllFromDetEjerPresup
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromDETEJERPRESUP")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetDetEjerPresupByIdDetEjerPresup(ByVal _id As Integer) As BussinessEntities.DetEjerPresup Implements IDetEjerPresupRepository.GetDetEjerPresupByIdDetEjerPresup
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDETEJERPRESUPByIdDetEjerPresup")
        command.Parameters.AddWithValue("idDetEjerPresup", _id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of DetEjerPresup)
        Dim lista As New List(Of DetEjerPresup)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _DetEjerPresup As New DetEjerPresup() With
                    {
                        .IdDetEjerPresup = reader.GetValue(reader.GetOrdinal("IdDetEjerPresup")),
                        .IdEjerPresup = reader.GetValue(reader.GetOrdinal("IdEjerPresup")),
                        .IdCCosto = reader.GetValue(reader.GetOrdinal("IdCCosto"))
                    }
                If Not (reader.IsDBNull(reader.GetOrdinal("Anio"))) Then
                    _DetEjerPresup.Anio = reader.GetValue(reader.GetOrdinal("Anio"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Mes"))) Then
                    _DetEjerPresup.Mes = reader.GetValue(reader.GetOrdinal("Mes"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("ProgramadoFisico"))) Then
                    _DetEjerPresup.ProgramadoFisico = reader.GetValue(reader.GetOrdinal("ProgramadoFisico"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("ProgramadoPresup"))) Then
                    _DetEjerPresup.ProgramadoPresup = reader.GetValue(reader.GetOrdinal("ProgramadoPresup"))
                End If
                lista.Add(_DetEjerPresup)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteDetEjerPresup(ByVal _id As Integer) Implements IDetEjerPresupRepository.DeleteDetEjerPresup
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDETEJERPRESUP")
        command.Parameters.AddWithValue("idDetEjerPresup", _id)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub SaveDetEjerPresup(ByVal _DetEjerPresup As BussinessEntities.DetEjerPresup) Implements IDetEjerPresupRepository.SaveDetEjerPresup
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDETEJERPRESUP")

        command.Parameters.AddWithValue("IdDetEjerPresup", _DetEjerPresup.IdDetEjerPresup)
        command.Parameters.AddWithValue("IdEjerPresup", _DetEjerPresup.IdEjerPresup)
        command.Parameters.AddWithValue("IdCCosto", _DetEjerPresup.IdCCosto)
        command.Parameters.AddWithValue("Mes", _DetEjerPresup.Mes)
        command.Parameters.AddWithValue("Anio", _DetEjerPresup.Anio)
        command.Parameters.AddWithValue("ProgramadoPresup", _DetEjerPresup.ProgramadoPresup)
        command.Parameters.AddWithValue("ProgramadoFisico", _DetEjerPresup.ProgramadoFisico)

        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub SaveDetEjerPresup1(ByVal _DetEjerPresup As System.Collections.Generic.List(Of BussinessEntities.DetEjerPresup)) Implements IDetEjerPresupRepository.SaveDetEjerPresup1
        For Each det As DetEjerPresup In _DetEjerPresup
            SaveDetEjerPresup(det)
        Next
    End Sub

End Class

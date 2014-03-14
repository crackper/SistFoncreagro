Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class UnidadMedidaRepository : Inherits MasterDataAccess : Implements IUnidadMedidaRepository

    Public Function GetAllFromUnidadMedidaByIdUnidadMedida(ByVal IdUnidadMedida As Integer) As BussinessEntities.UnidadMedida Implements IUnidadMedidaRepository.GetAllFromUnidadMedidaByIdUnidadMedida
        Dim command As SqlCommand =
               MyBase.CreateSPCommand("GetAllFromUnidadMedidaByIdUnidad")
        command.Parameters.AddWithValue("IdUnidadMedida", IdUnidadMedida)
        Return SelectObjectFactoryUnidadMedida(command).SingleOrDefault
    End Function

    Public Function GetAllFromUnidadMedida() As System.Collections.Generic.List(Of BussinessEntities.UnidadMedida) Implements IUnidadMedidaRepository.GetAllFromUnidadMedida
        Dim command As SqlCommand =
       MyBase.CreateSPCommand("GetAllFromUnidadMedidad")
        Return SelectObjectFactoryUnidadMedida(command)
    End Function
    Public Sub SaveUnidadMedida(ByVal unidadMedida As BussinessEntities.UnidadMedida) Implements IUnidadMedidaRepository.SaveUnidadMedida
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveUnidadMedida")
        command.Parameters.AddWithValue("IdUnidadMedida", unidadMedida.IdUnidadMedida)
        command.Parameters.AddWithValue("Descripcion", unidadMedida.Descripcion)
        command.Parameters.AddWithValue("Abreviacion", unidadMedida.Abreviacion)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Private Function SelectObjectFactoryUnidadMedida(ByVal command As SqlCommand) As List(Of UnidadMedida)
        Dim listaUnidadMedida As New List(Of UnidadMedida)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim unidadMedida As New UnidadMedida

                With unidadMedida
                    .IdUnidadMedida = reader.GetInt32(0)
                    .Abreviacion = reader.GetString(1)
                    .Descripcion = reader.GetString(2)
                End With
                listaUnidadMedida.Add(unidadMedida)
            End While

        End Using
        Return listaUnidadMedida
    End Function

    Public Sub DeleteUnidadMedida(ByVal IdUnidaMedida As Integer) Implements IUnidadMedidaRepository.DeleteUnidadMedida
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteUnidadMedida")
        command.Parameters.AddWithValue("IdUnidadMedida", IdUnidaMedida)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class

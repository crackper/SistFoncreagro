Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class MarcaRepository : Inherits MasterDataAccess : Implements IMarcaRepository

    Public Function GetAllFromByIdMarca(ByVal idMarca As Integer) As BussinessEntities.Marca Implements IMarcaRepository.GetAllFromByIdMarca
        Dim command As SqlCommand =
            MyBase.CreateSPCommand("GetAllFromByIdMarca")
        command.Parameters.AddWithValue("IdMarca", idMarca)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetAllFromMarca() As System.Collections.Generic.List(Of BussinessEntities.Marca) Implements IMarcaRepository.GetAllFromMarca
        Dim command As SqlCommand =
     MyBase.CreateSPCommand("GetAllFromMarca")
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveMarca(ByVal marca As BussinessEntities.Marca) Implements IMarcaRepository.SaveMarca
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveMarca")
        command.Parameters.AddWithValue("IdMarca", marca.IdMarca)
        command.Parameters.AddWithValue("Descripcion", marca.Descripcion)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Marca)
        Dim listaMarca As New List(Of Marca)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim marca As New Marca
                With marca
                    .IdMarca = reader.GetInt32(0)
                    .Descripcion = reader.GetString(1)
                End With
                listaMarca.Add(marca)
            End While

        End Using
        Return listaMarca
    End Function

    Public Sub DeleteMarca(ByVal IdMarca As Integer) Implements IMarcaRepository.DeleteMarca
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteMarca")
        command.Parameters.AddWithValue("IdMarca", IdMarca)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class

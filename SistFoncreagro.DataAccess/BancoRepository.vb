Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class BancoRepository : Inherits MasterDataAccess : Implements IBancoRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Banco)
        Dim lista As New List(Of Banco)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Banco As New Banco() With
                {
                  .IdBanco = reader.GetValue(2),
                  .Nombre = reader.GetValue(3)
                }
                If Not (reader.IsDBNull(0)) Then
                    _Banco.Contacto = reader.GetValue(0)
                End If
                If Not (reader.IsDBNull(1)) Then
                    _Banco.Direccion = reader.GetValue(1)
                End If
                If Not (reader.IsDBNull(4)) Then
                    _Banco.Telefono1 = reader.GetValue(4)
                End If
                If Not (reader.IsDBNull(5)) Then
                    _Banco.Telefono2 = reader.GetValue(5)
                End If
                If Not (reader.IsDBNull(6)) Then
                    _Banco.Telefono3 = reader.GetValue(6)
                End If
                lista.Add(_Banco)
            End While
        End Using
        Return lista
    End Function
    Public Function GetAllFromBANCO() As System.Collections.Generic.List(Of BussinessEntities.Banco) Implements IBancoRepository.GetAllFromBANCO
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromBANCO")
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveBanco(ByVal _Banco As BussinessEntities.Banco) Implements IBancoRepository.SaveBanco
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveBanco")
        command.Parameters.AddWithValue("Contacto", _Banco.Contacto)
        command.Parameters.AddWithValue("Direccion", _Banco.Direccion)
        command.Parameters.AddWithValue("IdBanco", _Banco.IdBanco)
        command.Parameters.AddWithValue("Nombre", _Banco.Nombre)
        command.Parameters.AddWithValue("Telefono1", _Banco.Telefono1)
        command.Parameters.AddWithValue("Telefono2", _Banco.Telefono2)
        command.Parameters.AddWithValue("Telefono3", _Banco.Telefono3)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetBANCOByIdBanco(ByVal IdBanco As Integer) As BussinessEntities.Banco Implements IBancoRepository.GetBANCOByIdBanco
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetBANCOByIdBanco")
        command.Parameters.AddWithValue("IdBanco", IdBanco)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
End Class

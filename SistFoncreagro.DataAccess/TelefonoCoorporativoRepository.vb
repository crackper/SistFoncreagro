Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TelefonoCoorporativoRepository : Inherits MasterDataAccess : Implements ITelefonoCoorporativoRepository

    Public Function GetAllFromTelefonoCoorporativo() As System.Collections.Generic.List(Of BussinessEntities.TelefonoCoorporativo) Implements ITelefonoCoorporativoRepository.GetAllFromTelefonoCoorporativo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTelefonoCoorporativo")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTelefonoCoorporativoByIdTelefCoorporativo(ByVal IdTelefCoorporativo As Integer) As BussinessEntities.TelefonoCoorporativo Implements ITelefonoCoorporativoRepository.GetTelefonoCoorporativoByIdTelefCoorporativo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTelefonoCoorporativoByIdTelefCoorporativo")
        command.Parameters.AddWithValue("IdTelefCoorporativo", IdTelefCoorporativo)

        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TelefonoCoorporativo)
        Dim lista As New List(Of TelefonoCoorporativo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New TelefonoCoorporativo
                If Not reader.IsDBNull(reader.GetOrdinal("IdTelefonoCoorporativo")) Then
                    entity.IdTelefonoCoorporativo = reader.GetValue(reader.GetOrdinal("IdTelefonoCoorporativo"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("NroRP")) Then
                    entity.NroRP = reader.GetValue(reader.GetOrdinal("NroRP"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("NroTelefono")) Then
                    entity.NroTelefono = reader.GetValue(reader.GetOrdinal("NroTelefono"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoTelefono")) Then
                    entity.IdTipoTelefono = reader.GetValue(reader.GetOrdinal("IdTipoTelefono"))

                    Dim TipoTelefonoRepository As New TipoTelefonoRepository
                    entity.Descripcion = TipoTelefonoRepository.GetTipoTelefonoByIdTipoTelefono(entity.IdTipoTelefono).Descripcion
                End If
                lista.Add(entity)
            End While
        End Using
        Return lista

    End Function
End Class

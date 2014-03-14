Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TipoTelefonoRepository : Inherits MasterDataAccess : Implements ITipoTelefonoRepository

    Public Function GetAllTipoTelefono() As System.Collections.Generic.List(Of BussinessEntities.TipoTelefono) Implements ITipoTelefonoRepository.GetAllTipoTelefono
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllTipoTelefono")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTipoTelefonoByIdTipoTelefono(ByVal IdTipoTelefono As Integer) As BussinessEntities.TipoTelefono Implements ITipoTelefonoRepository.GetTipoTelefonoByIdTipoTelefono
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTipoTelefonoByIdTipoTelefono")
        command.Parameters.AddWithValue("IdTipoTelefono", IdTipoTelefono)

        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoTelefono)
        Dim lista As New List(Of TipoTelefono)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New TipoTelefono
                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoTelefono")) Then
                    entity.IdTipoTelefono = reader.GetValue(reader.GetOrdinal("IdTipoTelefono"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If

                lista.Add(entity)
            End While
        End Using
        Return lista

    End Function
End Class

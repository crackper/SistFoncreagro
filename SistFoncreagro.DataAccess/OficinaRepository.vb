Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class OficinaRepository : Inherits MasterDataAccess : Implements IOficinaRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Oficina)
        Dim lista As New List(Of Oficina)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Oficina As New Oficina() With
                {
                    .IdOficina = reader.GetValue(0),
                    .Nombre = reader.GetValue(1),
                    .Estado = reader.GetValue(3),
                    .IdLocal = reader.GetValue(4)
                }
                If Not (reader.IsDBNull(2)) Then
                    _Oficina.Descripcion = reader.GetValue(2)
                End If

                lista.Add(_Oficina)
            End While
        End Using
        Return lista
    End Function

    Public Function GetAllFromOFICINA() As System.Collections.Generic.List(Of BussinessEntities.Oficina) Implements IOficinaRepository.GetAllFromOFICINA
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromOFICINA")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetOFICINAByIdOficina(ByVal IdOficina As Integer) As BussinessEntities.Oficina Implements IOficinaRepository.GetOFICINAByIdOficina
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetOFICINAByIdOficina")
        command.Parameters.AddWithValue("IdOficina", IdOficina)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveOFICINA(ByVal _Oficina As BussinessEntities.Oficina) Implements IOficinaRepository.SaveOFICINA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveOFICINA")
        command.Parameters.AddWithValue("Descripcion", _Oficina.Descripcion)
        command.Parameters.AddWithValue("IdLocal", _Oficina.IdLocal)
        command.Parameters.AddWithValue("IdOficina", _Oficina.IdOficina)
        command.Parameters.AddWithValue("Nombre", _Oficina.Nombre)
        MyBase.ExecuteReader(command)
    End Sub

    Public Sub UpdateEstadoOFICINA(ByVal IdOficina As Integer) Implements IOficinaRepository.UpdateEstadoOFICINA
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoOFICINA")
        command.Parameters.AddWithValue("IdOficina", IdOficina)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetOFICINAByIdLocal(ByVal IdLocal As Integer) As System.Collections.Generic.List(Of BussinessEntities.Oficina) Implements IOficinaRepository.GetOFICINAByIdLocal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetOFICINAByIdLocal")
        command.Parameters.AddWithValue("IdLocal", IdLocal)
        Return SelectObjectFactory(command)
    End Function

    Public Sub DeleteOFICINA(ByVal IdOficina As Integer) Implements IOficinaRepository.DeleteOFICINA
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteOFICINA")
        command.Parameters.AddWithValue("IdOficina", IdOficina)
        MyBase.ExecuteReader(command)
    End Sub
End Class

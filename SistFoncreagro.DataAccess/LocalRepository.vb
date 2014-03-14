Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class LocalRepository : Inherits MasterDataAccess : Implements ILocalRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Local)
        Dim lista As New List(Of Local)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Local As New Local() With
                {
                    .IdLocal = reader.GetValue(0),
                    .Nombre = reader.GetValue(1),
                    .Estado = reader.GetValue(3)
                }
                If Not (reader.IsDBNull(2)) Then
                    _Local.Descripcion = reader.GetValue(2)
                End If
                If Not (reader.IsDBNull(4)) Then
                    _Local.Direccion = reader.GetValue(4)
                End If

                lista.Add(_Local)
            End While
        End Using
        Return lista
    End Function

    Public Function GetAllFromLOCAL() As System.Collections.Generic.List(Of BussinessEntities.Local) Implements ILocalRepository.GetAllFromLOCAL
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromLOCAL")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetLOCALByIdLocal(ByVal IdLocal As Integer) As BussinessEntities.Local Implements ILocalRepository.GetLOCALByIdLocal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetLOCALByIdLocal")
        command.Parameters.AddWithValue("IdLocal", IdLocal)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveLOCAL(ByVal _Local As BussinessEntities.Local) Implements ILocalRepository.SaveLOCAL
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveLOCAL")
        command.Parameters.AddWithValue("Descripcion", _Local.Descripcion)
        command.Parameters.AddWithValue("Direccion", _Local.Direccion)
        command.Parameters.AddWithValue("IdLocal", _Local.IdLocal)
        command.Parameters.AddWithValue("Nombre", _Local.Nombre)
        MyBase.ExecuteReader(command)
    End Sub

    Public Sub UpdateEstadoLOCAL(ByVal IdLocal As Integer) Implements ILocalRepository.UpdateEstadoLOCAL
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoLOCAL")
        command.Parameters.AddWithValue("IdLocal", IdLocal)
        MyBase.ExecuteReader(command)
    End Sub

    Public Sub DeleteLOCAL(ByVal IdLocal As Integer) Implements ILocalRepository.DeleteLOCAL
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteLOCAL")
        command.Parameters.AddWithValue("IdLocal", IdLocal)
        MyBase.ExecuteReader(command)
    End Sub
End Class

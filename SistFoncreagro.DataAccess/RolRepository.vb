Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class RolRepository : Inherits MasterDataAccess : Implements IRolRepository
    Public Sub DeleteROL(ByVal IdRol As Integer) Implements IRolRepository.DeleteROL
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteROL")
        command.Parameters.AddWithValue("IdRol", IdRol)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Function GetAllFromROL() As System.Collections.Generic.List(Of BussinessEntities.ROL) Implements IRolRepository.GetAllFromROL
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromROL")
        Return SelectObjectFactory(command)
    End Function
    Public Function GetROLByIdRol(ByVal IdRol As Integer) As BussinessEntities.ROL Implements IRolRepository.GetROLByIdRol
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetROLByIdRol")
        command.Parameters.AddWithValue("IdRol", IdRol)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveROL(ByVal rol As BussinessEntities.ROL) As Integer Implements IRolRepository.SaveROL
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveROL")
        'command.Parameters.AddWithValue("IdUnidadMedida", UnidadMedida.IdUnidadMedida)
        MyBase.ExecuteNonQuery(command)
    End Function
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ROL)
        Dim listaRoles As New List(Of ROL)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim aRol As New ROL
                With aRol
                    .IdRol = reader.GetInt32(0)
                    .NombreRol = reader.GetString(1)
                    .Abreviatura = reader.GetString(2)
                End With
                If Not (reader.IsDBNull(3)) Then
                    aRol.Descripcion = reader.GetString(3)
                End If
                listaRoles.Add(aRol)
            End While
        End Using
        Return listaRoles
    End Function
    Public Function GetRolAsignadoAreaProyecto() As System.Collections.Generic.List(Of BussinessEntities.ROL) Implements IRolRepository.GetRolAsignadoAreaProyecto

    End Function
End Class

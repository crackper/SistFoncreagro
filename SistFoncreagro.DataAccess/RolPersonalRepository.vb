Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class RolPersonalRepository : Inherits MasterDataAccess : Implements IRolPersonalRepository
    Dim personaRepository As IPersonalRepository
    Dim proyectoRepository As IProyectoRepository
    Sub New()
        personaRepository = New PersonalRepository
        proyectoRepository = New ProyectoRepository
    End Sub
    Public Sub DeleteRolPersonal(ByVal idRolPersonal As Integer) Implements IRolPersonalRepository.DeleteRolPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteRolPersonal")
        command.Parameters.AddWithValue("IdRolPersonal", idRolPersonal)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Function GetFromRolPersonalByIdRol(ByVal idRol As Integer, ByVal IdPerProy As Integer, ByVal Tipo As Boolean) As System.Collections.Generic.List(Of BussinessEntities.RolPersonal) Implements IRolPersonalRepository.GetFromRolPersonalByIdRol
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetFromRolPersonalByIdRol")
        command.Parameters.AddWithValue("IdRol", idRol)
        command.Parameters.AddWithValue("IdPerProy", IdPerProy)
        command.Parameters.AddWithValue("Tipo", Tipo)
        Return SelectObjectFactoryRolPersonal(command)
    End Function


    Public Sub SaveRolPersonal(ByVal rolPersona As BussinessEntities.RolPersonal) Implements IRolPersonalRepository.SaveRolPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveRolPersonal")
        command.Parameters.AddWithValue("IdRolPersonal", rolPersona.IdRolPersonal)
        command.Parameters.AddWithValue("IdRol", rolPersona.IdRol)
        command.Parameters.AddWithValue("IdPersonal", rolPersona.IdPersonal)
        command.Parameters.AddWithValue("IdProyecto", rolPersona.IdProyecto)
        command.Parameters.AddWithValue("Estado", rolPersona.Estado)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Private Function SelectObjectFactoryRolPersonal(ByVal command As SqlCommand) As List(Of RolPersonal)
        Dim listaRolPersonal As New List(Of RolPersonal)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim rolPersona As New RolPersonal
                With rolPersona
                    .IdRolPersonal = reader.GetInt32(0)
                    .IdRol = reader.GetInt32(1)
                    .IdPersonal = reader.GetInt32(2)
                    .IdProyecto = reader.GetInt32(3)
                    .Estado = reader.GetBoolean(4)
                    .Persona = personaRepository.GetPersonalByIdPersonal(reader.GetInt32(2))
                End With
                If reader.GetInt32(3) <> 0 Then
                    rolPersona.Proyecto = proyectoRepository.GetFromProyectoByIdProyecto(reader.GetInt32(3))
                End If
                listaRolPersonal.Add(rolPersona)
            End While
        End Using
        Return listaRolPersonal
    End Function

    Public Sub UpdateResponsable(ByVal idPersonalOriginal As Integer, ByVal idPersonalReemplazo As Integer, ByVal idRol As Integer, ByVal idProyecto As Integer) Implements IRolPersonalRepository.UpdateResponsable
        Dim command As SqlCommand = MyBase.CreateSPCommand("ReemplazarResponsable")
        command.Parameters.AddWithValue("IdPersonalOriginal", idPersonalOriginal)
        command.Parameters.AddWithValue("IdPersonaReemplazo", idPersonalReemplazo)
        command.Parameters.AddWithValue("IdRol", idRol)
        If idProyecto <> 0 Then
            command.Parameters.AddWithValue("IdProyecto", idProyecto)
        End If
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
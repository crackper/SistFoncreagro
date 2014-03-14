Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class PermisoUsuarioRepository : Inherits MasterDataAccess : Implements IPermisoUsuarioRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of PermisoUsuario)
        Dim lista As New List(Of PermisoUsuario)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _PermisoUsuario As New PermisoUsuario() With
                {
                  .IdPermisoUsuario = reader.GetValue(0),
                  .IdPersonal = reader.GetValue(1),
                  .Estado = reader.GetValue(5)
              }
                If Not (reader.IsDBNull(2)) Then
                    _PermisoUsuario.FechaPermiso = reader.GetValue(2)
                End If
                If Not (reader.IsDBNull(3)) Then
                    _PermisoUsuario.HoraInicio = reader.GetValue(3)
                End If
                If Not (reader.IsDBNull(4)) Then
                    _PermisoUsuario.HoraFin = reader.GetValue(4)
                End If
                If Not (reader.IsDBNull(6)) Then
                    _PermisoUsuario.IdPersonalAutoriza = reader.GetValue(6)
                End If
                If Not (reader.IsDBNull(7)) Then
                    _PermisoUsuario.FechaAutoriza = reader.GetValue(7)
                End If
                lista.Add(_PermisoUsuario)
            End While
        End Using
        Return lista
    End Function
    Public Function GetPERMISOUSUARIOByIdPersonal(IdPersonal As Integer) As BussinessEntities.PermisoUsuario Implements IPermisoUsuarioRepository.GetPERMISOUSUARIOByIdPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERMISOUSUARIOByIdPersonal")
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SavePERMISOUSUARIO(_PermisoUsuario As BussinessEntities.PermisoUsuario) Implements IPermisoUsuarioRepository.SavePERMISOUSUARIO
        Dim command As SqlCommand = MyBase.CreateSPCommand("SavePERMISOUSUARIO")
        command.Parameters.AddWithValue("Estado", _PermisoUsuario.Estado)
        command.Parameters.AddWithValue("FechaPermiso", _PermisoUsuario.FechaPermiso)
        command.Parameters.AddWithValue("HoraFin", _PermisoUsuario.HoraFin)
        command.Parameters.AddWithValue("HoraInicio", _PermisoUsuario.HoraInicio)
        command.Parameters.AddWithValue("IdPersonalAutoriza", _PermisoUsuario.IdPersonalAutoriza)
        command.Parameters.AddWithValue("IdPermisoUsuario", _PermisoUsuario.IdPermisoUsuario)
        MyBase.ExecuteReader(command)
    End Sub
End Class

Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class PermisosRepository : Inherits MasterDataAccess : Implements IPermisosRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Permisos)
        Dim lista As New List(Of Permisos)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Permisos As New Permisos() With
                {
                    .Descripcion = reader.GetValue(0),
                    .Dia = reader.GetValue(1),
                    .Estado = reader.GetValue(2),
                    .HoraFin = reader.GetValue(3),
                    .HoraInicio = reader.GetValue(4),
                    .IdPermiso = reader.GetValue(5)
                }

                lista.Add(_Permisos)
            End While
        End Using
        Return lista
    End Function
    Public Function GetAllFromPermisos() As System.Collections.Generic.List(Of BussinessEntities.Permisos) Implements IPermisosRepository.GetAllFromPermisos
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromPermisos")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetPermisosByDescripcion(descripcion As String) As BussinessEntities.Permisos Implements IPermisosRepository.GetPermisosByDescripcion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPermisosByDescripcion")
        command.Parameters.AddWithValue("descripcion", descripcion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function PASolicitaAprobacion(IdPersonal As Integer) As Integer Implements IPermisosRepository.PASolicitaAprobacion
        Dim Id As Int32
        Dim command As SqlCommand = MyBase.CreateSPCommand("PASolicitaAprobacion")
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function
End Class

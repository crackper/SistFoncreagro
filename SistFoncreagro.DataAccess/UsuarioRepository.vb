Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class UsuarioRepository : Inherits MasterDataAccess : Implements IUsuarioRepository
    Private Function SelectObjectFactoryUsuario(ByVal command As SqlCommand, ByVal admin As Boolean) As List(Of Usuario)
        Dim listaUsuarios As New List(Of Usuario)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim usuarioSistema As New Usuario
                With usuarioSistema
                    .IdUsuario = reader.GetInt32(0)
                    .NombreUsuario = reader.GetString(1)
                    .NombrePersonalCompleto = reader.GetString(2)
                    If admin = True Then
                        .Estado = reader.GetBoolean(3)
                        .NroFalla = reader.GetInt32(4)
                    End If
                End With
                listaUsuarios.Add(usuarioSistema)
            End While
        End Using
        Return listaUsuarios
    End Function
    Public Function GetUsuarioByNombreUsuarioSistema(ByVal nombreUsuario As String) As BussinessEntities.Usuario Implements IUsuarioRepository.GetUsuarioByNombreUsuarioSistema
        Dim command As SqlCommand =
              MyBase.CreateSPCommand("GetUsuarioByNombreUsuarioSistema")
        command.Parameters.AddWithValue("nombreUsuario", nombreUsuario)
        Return SelectObjectFactoryUsuario(command, False).SingleOrDefault
    End Function

    Public Sub ActualizarUsuarioRegistrado(ByVal usuario As BussinessEntities.Usuario) Implements IUsuarioRepository.ActualizarUsuarioRegistrado
        Dim command As SqlCommand = MyBase.CreateSPCommand("ActualizarUsuarioRegistrado")
        command.Parameters.AddWithValue("IdPersonal", usuario.IdUsuario)
        command.Parameters.AddWithValue("NombreUsuario", usuario.NombreUsuario)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromPersonalSinUsuarioGetAllFromPersonalNotUser() As System.Collections.Generic.List(Of BussinessEntities.Usuario) Implements IUsuarioRepository.GetAllFromPersonalSinUsuarioGetAllFromPersonalNotUser
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromPersonalNotUser")
        Return SelectObjectFactoryUsuario(command, False)
    End Function

    Public Function GetAllFromUsuariosSistema() As System.Collections.Generic.List(Of BussinessEntities.Usuario) Implements IUsuarioRepository.GetAllFromUsuariosSistema
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromUsuariosSistema")
        Return SelectObjectFactoryUsuario(command, True)
    End Function

    Public Sub HabilitarDeshabilitar(ByVal idPersonal As Integer, ByVal estado As Boolean) Implements IUsuarioRepository.HabilitarDeshabilitar
        Dim command As SqlCommand = MyBase.CreateSPCommand("HabilitarDeshabilitar")
        command.Parameters.AddWithValue("IdPersonal", idPersonal)
        command.Parameters.AddWithValue("Estado", estado)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromAsistentesUser() As System.Collections.Generic.List(Of BussinessEntities.Usuario) Implements IUsuarioRepository.GetAllFromAsistentesUser
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromAsistentesUser")
        Return SelectObjectFactoryUsuario(command, False)
    End Function

    Public Sub RestaurarPaswword(ByVal idPersonal As Integer) Implements IUsuarioRepository.RestaurarPaswword
        Dim command As SqlCommand = MyBase.CreateSPCommand("RestaurarPassword")
        command.Parameters.AddWithValue("IdPersonal", idPersonal)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
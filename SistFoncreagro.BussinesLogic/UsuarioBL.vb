Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class UsuarioBL : Implements IUsuarioBL
    Dim usuarioSistema As IUsuarioRepository
    Sub New()
        usuarioSistema = New UsuarioRepository
    End Sub
    Public Function GetUsuarioByNombreUsuarioSistema(ByVal nombreUsuario As String) As BussinessEntities.Usuario Implements IUsuarioBL.GetUsuarioByNombreUsuarioSistema
        Return usuarioSistema.GetUsuarioByNombreUsuarioSistema(nombreUsuario)
    End Function
    Public Sub ActualizarUsuarioRegistrado(ByVal usuario As BussinessEntities.Usuario) Implements IUsuarioBL.ActualizarUsuarioRegistrado
        usuarioSistema.ActualizarUsuarioRegistrado(usuario)
    End Sub
    Public Function GetAllFromPersonalSinUsuarioGetAllFromPersonalNotUser() As System.Collections.Generic.List(Of BussinessEntities.Usuario) Implements IUsuarioBL.GetAllFromPersonalSinUsuarioGetAllFromPersonalNotUser
        Return usuarioSistema.GetAllFromPersonalSinUsuarioGetAllFromPersonalNotUser
    End Function

    Public Function GetAllFromUsuariosSistema() As System.Collections.Generic.List(Of BussinessEntities.Usuario) Implements IUsuarioBL.GetAllFromUsuariosSistema
        Return usuarioSistema.GetAllFromUsuariosSistema
    End Function

    Public Sub HabilitarDeshabilitar(ByVal idPersonal As Integer, ByVal estado As Boolean) Implements IUsuarioBL.HabilitarDeshabilitar
        usuarioSistema.HabilitarDeshabilitar(idPersonal, estado)
    End Sub

    Public Function GetAllFromAsistentesUser() As System.Collections.Generic.List(Of BussinessEntities.Usuario) Implements IUsuarioBL.GetAllFromAsistentesUser
        Return usuarioSistema.GetAllFromAsistentesUser
    End Function

    Public Sub RestaurarPaswword(ByVal idPersonal As Integer) Implements IUsuarioBL.RestaurarPaswword
        usuarioSistema.RestaurarPaswword(idPersonal)
    End Sub
End Class

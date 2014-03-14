Imports SistFoncreagro.BussinessEntities
Public Interface IUsuarioRepository
    Function GetUsuarioByNombreUsuarioSistema(ByVal nombreUsuario As String) As Usuario
    Function GetAllFromPersonalSinUsuarioGetAllFromPersonalNotUser() As List(Of Usuario)
    Function GetAllFromAsistentesUser() As List(Of Usuario)
    Function GetAllFromUsuariosSistema() As List(Of Usuario)
    Sub HabilitarDeshabilitar(ByVal idPersonal As Int32, ByVal estado As Boolean)
    Sub ActualizarUsuarioRegistrado(ByVal usuario As Usuario)
    Sub RestaurarPaswword(ByVal idPersonal As Int32)
End Interface

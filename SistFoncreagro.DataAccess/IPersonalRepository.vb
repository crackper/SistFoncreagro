Imports SistFoncreagro.BussinessEntities
Public Interface IPersonalRepository
    Function GetAllFromPersonal() As List(Of Personal)
    Function GetPersonalByIdPersonal(ByVal idPersonal As Integer) As Personal
    Function GetPersonalByIdPersonal(ByVal idPersonal As Integer, ByVal argPersonal As ArgumentosPersonal) As Personal
    Function GetFiltrarPERSONALPorParametro(ByVal apeMat As String, ByVal apePat As String, ByVal nomb As String, ByVal di As String) As List(Of Personal)
    Function SavePersonal(ByVal Personal As Personal) As Int32
    Sub UpdateFotoPERSONAL(ByVal IdPersonal As Int32, ByVal ArchivoFoto As String)
    Sub UpdateCVPERSONAL(ByVal IdPersonal As Int32, ByVal ArchivoCV As String)
    Sub UpdateNIvelEducativo(ByVal IdNivelEducativo As Int32, ByVal IdPersonal As Int32)
    Sub UpdateArchivoCertificadoTipoSangre(ByVal CertificadoTipoSangre As String, ByVal IdPersonal As Int32)
    Sub DeletePersonal(ByVal id As String)
    '
    Function GetPERSONALActualmenteLaborandoByIdCategoria(ByVal IdCategoria As Integer) As System.Collections.Generic.List(Of BussinessEntities.Personal)
    'Function GetPERSONALALiquidadoPorRangoFecha(ByVal IdCategoria As Integer, ByVal fechaIni As DateTime, ByVal fechaFin As DateTime) As System.Collections.Generic.List(Of BussinessEntities.Personal)
    Function GetPERSONALALiquidadoPorRangoFecha(ByVal IdCategoria As Integer) As System.Collections.Generic.List(Of BussinessEntities.Personal)
    Function GetPERSONALSinVinculoLaboral() As System.Collections.Generic.List(Of BussinessEntities.Personal)
    Function GetPERSONALByIdCategoria(ByVal idCategoria As Integer) As System.Collections.Generic.List(Of Personal)
    Function GetPERSONALSinVinculoYConVinculoApartirDeUnaFecha(ByVal fechaIni As DateTime) As System.Collections.Generic.List(Of BussinessEntities.Personal)
    Function GetPersonalByFechaByIdProyecto(ByVal Fecha As DateTime, ByVal idProyecto As Int32) As List(Of Personal)
    Function GetPersonalByFechaIdPosicion(ByVal Fecha As DateTime, ByVal IdPosicion As Int32) As List(Of Personal)
    Function GetPersonalByFechaByIdRol(ByVal Fecha As DateTime, ByVal IdRol As Int32)
    Function GetPERSONALinControlAsistencia(ByVal Fecha As DateTime) As List(Of Personal)

    Function GetCertificadoTipoSangrePERSONALByIdPersonal(ByVal IdPersonal As Int32) As String
    Function GetAsignacionFamiliarByIdPersonal(ByVal Idpersonal As Int32) As Decimal
End Interface

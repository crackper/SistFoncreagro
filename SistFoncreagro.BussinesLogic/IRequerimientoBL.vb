Imports SistFoncreagro.BussinessEntities
Public Interface IRequerimientoBL
    Function GetAllFromRequerimientoByIdPersona(ByVal IdPersona As Int32) As List(Of Requerimiento)
    Function GetAllFromRequerimientoByIdReq(ByVal IdRequerimiento As Int32) As Requerimiento
    Function GetAllFromRequerimientoHabilitar() As List(Of Requerimiento)
    Function SaveRequerimiento(ByVal requerimiento As Requerimiento) As Integer
    Sub SolictarAprobacion(ByVal idRequerimiento As Int32)
    Sub EnviarLicitacion(ByVal IdReq As Int32, ByVal IdAsistenteReq As Int32)
    Sub AprobarRequerimiento(ByVal idRequerimiento As Int32, ByVal IdPersonal As Int32)
    Sub AnularRequerimiento(ByVal idRequerimiento As Int32, ByVal IdPersonal As Int32, ByVal Motivo As String, ByVal Tipo As Int32)
    Function GetAllFromRequerimientosAprobadosByIdComprador(ByVal IdPersonaComprador As Int32) As List(Of Requerimiento)
    Function GetAllFromREQUERIMIENTOSAprobadosLicitacionByIdAsistente(ByVal IdAsistente As Int32) As List(Of Requerimiento)
    Sub SaveDetalleRequerimiento(ByVal detalleRequerimiento As List(Of DetalleRequerimiento))
    Sub UpdateDetalleRequerimiento(ByVal detalleRequerimiento As List(Of DetalleRequerimiento))
    Function HabilitarCentroCosto(ByVal idRequerimiento As Int32, ByVal valor As Boolean) As Int32
    Function GetAllFromRequerimientoPorAprobarByIdResponsableAprobar(ByVal IdResponsableAprobar As Int32) As List(Of Requerimiento)
End Interface

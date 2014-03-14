Imports SistFoncreagro.DataAccess
Imports SistFoncreagro.BussinessEntities
Public Class RequerimientoBL : Implements IRequerimientoBL
    Dim factoryRepository As IRequerimientoRepository
    Public Sub New()
        factoryRepository = New RequerimientoRepository
    End Sub
    Public Function GetAllFromRequerimientoByIdPersona(ByVal IdPersona As Integer) As System.Collections.Generic.List(Of BussinessEntities.Requerimiento) Implements IRequerimientoBL.GetAllFromRequerimientoByIdPersona
        Return factoryRepository.GetAllFromRequerimientoByIdPersona(IdPersona)
    End Function

    Public Function GetAllFromRequerimientoByIdReq(ByVal IdRequerimiento As Integer) As BussinessEntities.Requerimiento Implements IRequerimientoBL.GetAllFromRequerimientoByIdReq
        Return factoryRepository.GetAllFromRequerimientoByIdReq(IdRequerimiento)
    End Function

    Public Function SaveRequerimiento(ByVal requerimiento As BussinessEntities.Requerimiento) As Integer Implements IRequerimientoBL.SaveRequerimiento
        Return factoryRepository.SaveRequerimiento(requerimiento)
    End Function

    Public Sub SolictarAprobacion(ByVal idRequerimiento As Integer) Implements IRequerimientoBL.SolictarAprobacion
        factoryRepository.SolictarAprobacion(idRequerimiento)
    End Sub

    Public Function GetAllFromRequerimientosAprobadosByIdComprador(ByVal IdPersonaComprador As Integer) As System.Collections.Generic.List(Of BussinessEntities.Requerimiento) Implements IRequerimientoBL.GetAllFromRequerimientosAprobadosByIdComprador
        Return factoryRepository.GetAllFromRequerimientosAprobadosByIdComprador(IdPersonaComprador)
    End Function
    Public Function GetAllFromREQUERIMIENTOSAprobadosLicitacionByIdAsistente(ByVal IdAsistente As Integer) As System.Collections.Generic.List(Of BussinessEntities.Requerimiento) Implements IRequerimientoBL.GetAllFromREQUERIMIENTOSAprobadosLicitacionByIdAsistente
        Return factoryRepository.GetAllFromREQUERIMIENTOSAprobadosLicitacionByIdAsistente(IdAsistente)
    End Function
    Public Sub SaveDetalleRequerimiento(ByVal detalleRequerimiento As System.Collections.Generic.List(Of BussinessEntities.DetalleRequerimiento)) Implements IRequerimientoBL.SaveDetalleRequerimiento
        factoryRepository.SaveDetalleRequerimiento(detalleRequerimiento)
    End Sub
    Public Function GetAllFromRequerimientoHabilitar() As System.Collections.Generic.List(Of BussinessEntities.Requerimiento) Implements IRequerimientoBL.GetAllFromRequerimientoHabilitar
        Return factoryRepository.GetAllFromRequerimientoHabilitar
    End Function

    Public Function HabilitarCentroCosto(ByVal idRequerimiento As Integer, ByVal valor As Boolean) As Integer Implements IRequerimientoBL.HabilitarCentroCosto
        Return factoryRepository.HabilitarCentroCosto(idRequerimiento, valor)
    End Function

    Public Sub AprobarRequerimiento(ByVal idRequerimiento As Integer, ByVal IdPersonal As Integer) Implements IRequerimientoBL.AprobarRequerimiento
        factoryRepository.AprobarRequerimiento(idRequerimiento, IdPersonal)
    End Sub

    Public Function GetAllFromRequerimientoPorAprobarByIdResponsableAprobar(ByVal IdResponsableAprobar As Integer) As System.Collections.Generic.List(Of BussinessEntities.Requerimiento) Implements IRequerimientoBL.GetAllFromRequerimientoPorAprobarByIdResponsableAprobar
        Return factoryRepository.GetAllFromRequerimientoPorAprobarByIdResponsableAprobar(IdResponsableAprobar)
    End Function

    Public Sub AnularRequerimiento(ByVal idRequerimiento As Integer, ByVal IdPersonal As Integer, ByVal Motivo As String, ByVal Tipo As Integer) Implements IRequerimientoBL.AnularRequerimiento
        factoryRepository.AnularRequerimiento(idRequerimiento, IdPersonal, Motivo, Tipo)
    End Sub

    Public Sub EnviarLicitacion(ByVal IdReq As Integer, ByVal IdAsistenteReq As Integer) Implements IRequerimientoBL.EnviarLicitacion
        factoryRepository.EnviarLicitacion(IdReq, IdAsistenteReq)
    End Sub

    Public Sub UpdateDetalleRequerimiento(ByVal detalleRequerimiento As System.Collections.Generic.List(Of BussinessEntities.DetalleRequerimiento)) Implements IRequerimientoBL.UpdateDetalleRequerimiento
        factoryRepository.UpdateDetalleRequerimiento(detalleRequerimiento)
    End Sub
End Class

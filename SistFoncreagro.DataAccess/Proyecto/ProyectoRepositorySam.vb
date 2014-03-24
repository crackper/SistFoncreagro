Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports SistFoncreagro.BussinessEntities
Imports System.Data

Partial Public Class ProyectoRepository : Inherits MasterDataAccess : Implements IProyectoRepository


    Dim _convenioFactory As IConvenioRepository
    Dim _componenteFactory As IComponenteRepository
    Dim _actividadFactory As IActividadRepository
    Dim _ccostosFactory As ICCostoRepository

    Public Function GetProyectoDtoyIdProyecto(idProyecto As Integer) As BussinessEntities.ProyectoDto Implements IProyectoRepository.GetProyectoDtoyIdProyecto
        _convenioFactory = New ConvenioRepository()

        Dim query = db.ExecuteSprocAccessor(Of ProyectoDto)("GetProyectoDtoyIdProyecto", idProyecto)

        Dim _proyecto = query.SingleOrDefault()

        _proyecto.Convenios = _convenioFactory.GetConveniosByIdProyecto(_proyecto.IdProyecto)

        Return _proyecto

    End Function

    Public Sub LoadComponentes(convenio As BussinessEntities.ConvenioDto) Implements IProyectoRepository.LoadComponentes
        _componenteFactory = New ComponenteRepository()

        convenio.Componentes = _componenteFactory.GetComponentesConvenioProyByIdComProy(convenio.IdConvProy)

    End Sub

    Public Sub LoadActividades(componente As BussinessEntities.ComponenteDto) Implements IProyectoRepository.LoadActividades
        _actividadFactory = New ActividadRepository
        componente.Actividades = _actividadFactory.GetActividadesByIdProycomp(componente.IdProyComp)

    End Sub

    Public Sub LoadCCostos(actividad As BussinessEntities.ActividadDto) Implements IProyectoRepository.LoadCCostos
        _ccostosFactory = New CCostoRepository()

        actividad.CCostos = _ccostosFactory.GetCCostoByIdProyAct(actividad.IdProyAct)
    End Sub
End Class

Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Partial Class ProyectoBL : Implements IProyectoBL

    Public Function GetProyectoDtoyIdProyecto(idProyecto As Integer) As BussinessEntities.ProyectoDto Implements IProyectoBL.GetProyectoDtoyIdProyecto
        Return factoryrepository.GetProyectoDtoyIdProyecto(idProyecto)
    End Function

    Public Sub LoadComponentes(convenio As BussinessEntities.ConvenioDto) Implements IProyectoBL.LoadComponentes
        factoryrepository.LoadComponentes(convenio)
    End Sub

    Public Sub LoadActividades(componente As BussinessEntities.ComponenteDto) Implements IProyectoBL.LoadActividades
        factoryrepository.LoadActividades(componente)
    End Sub

    Public Sub LoadCCostos(actividad As BussinessEntities.ActividadDto) Implements IProyectoBL.LoadCCostos
        factoryrepository.LoadCCostos(actividad)
    End Sub
End Class

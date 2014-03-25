Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Partial Class ProyectoBL : Implements IProyectoBL

    Public Function GetProyectoDtoyIdProyecto(idProyecto As Integer) As BussinessEntities.ProyectoDto Implements IProyectoBL.GetProyectoDtoyIdProyecto
        Return factoryrepository.GetProyectoDtoyIdProyecto(idProyecto)
    End Function

    Public Sub LoadComponentes(convenio As BussinessEntities.ConvenioDto) Implements IProyectoBL.LoadComponentes
        If convenio.Componentes.Count.Equals(0) Then
            factoryrepository.LoadComponentes(convenio)
        End If
    End Sub

    Public Sub LoadActividades(componente As BussinessEntities.ComponenteDto) Implements IProyectoBL.LoadActividades
        If componente.Actividades.Count.Equals(0) Then
            factoryrepository.LoadActividades(componente)
        End If
    End Sub

    Public Sub LoadCCostos(actividad As BussinessEntities.ActividadDto) Implements IProyectoBL.LoadCCostos
        If actividad.CCostos.Count.Equals(0) Then
            factoryrepository.LoadCCostos(actividad)
        End If
    End Sub
End Class

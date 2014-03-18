Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Partial Class ProyectoBL : Implements IProyectoBL


    Public Function GetProyectoDtoyIdProyecto(idProyecto As Integer) As BussinessEntities.ProyectoDto Implements IProyectoBL.GetProyectoDtoyIdProyecto
        Return factoryrepository.GetProyectoDtoyIdProyecto(idProyecto)
    End Function

    Public Sub LoadComponentes(convenio As BussinessEntities.ConvenioDto) Implements IProyectoBL.LoadComponentes
        factoryrepository.LoadComponentes(convenio)
    End Sub
End Class

Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class DatosPresupBL : Implements IDatosPresupBL

    Dim factoryrepository As IDatosPresupRepository

    Public Sub New()
        factoryrepository = New DatosPresupRepository
    End Sub

    Public Function GetDatosPresupByParameters(ByVal _IdProyecto As Integer, ByVal _IdEjerPresup As Integer, ByVal _Anio As Integer) As System.Collections.Generic.List(Of BussinessEntities.DatosPresup) Implements IDatosPresupBL.GetDatosPresupByParameters
        Return factoryrepository.GetDatosPresupByParameters(_IdProyecto, _IdEjerPresup, _Anio)
    End Function

    Public Sub CrearPresup(ByVal _IdProyecto As Integer, ByVal _IdEjerPresup As Integer) Implements IDatosPresupBL.CrearPresup
        factoryrepository.CrearPresup(_IdProyecto, _IdEjerPresup)
    End Sub
End Class

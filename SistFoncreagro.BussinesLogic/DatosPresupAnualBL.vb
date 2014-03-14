Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class DatosPresupAnualBL : Implements IDatosPresupAnualBL

    Dim factoryrepository As IDatosPresupAnualRepository

    Public Sub New()
        factoryrepository = New DatosPresupAnualRepository
    End Sub

    Public Function GetDatosPresupAnualByParameters(ByVal _IdProyecto As Integer, ByVal _IdEjerPresup As Integer, ByVal _Anio As Integer) As System.Collections.Generic.List(Of BussinessEntities.DatosPresupAnual) Implements IDatosPresupAnualBL.GetDatosPresupAnualByParameters
        Return factoryrepository.GetDatosPresupAnualByParameters(_IdProyecto, _IdEjerPresup, _Anio)
    End Function

    Public Sub CrearPresupAnual(ByVal _IdProyecto As Integer, ByVal _IdEjerPresup As Integer) Implements IDatosPresupAnualBL.CrearPresupAnual
        factoryrepository.CrearPresupAnual(_IdProyecto, _IdEjerPresup)
    End Sub
End Class

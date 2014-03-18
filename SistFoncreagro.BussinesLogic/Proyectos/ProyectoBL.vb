Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Partial Public Class ProyectoBL : Implements IProyectoBL

    Dim factoryrepository As IProyectoRepository

    Public Sub New()
        factoryrepository = New ProyectoRepository
    End Sub

    Public Function GetAllFromProyecto() As System.Collections.Generic.List(Of BussinessEntities.Proyecto) Implements IProyectoBL.GetAllFromProyecto
        Return factoryrepository.GetAllFromProyecto()
    End Function

    Public Function GetFromProyectoByIdProyecto(ByVal idproyecto As Integer) As BussinessEntities.Proyecto Implements IProyectoBL.GetFromProyectoByIdProyecto
        Return factoryrepository.GetFromProyectoByIdProyecto(idproyecto)
    End Function

    Public Function SaveProyecto(ByVal _Proyecto As BussinessEntities.Proyecto) As Integer Implements IProyectoBL.SaveProyecto
        Return factoryrepository.SaveProyecto(_Proyecto)
    End Function

    Public Function DeleteProyecto(ByVal id As Integer) As String Implements IProyectoBL.DeleteProyecto
        Return factoryrepository.DeleteProyecto(id)
    End Function

    Public Function GetFromProyectoByParameters(ByVal _Nombre As String, ByVal _Estado As String, ByVal _Responsable As String) As System.Collections.Generic.List(Of BussinessEntities.Proyecto) Implements IProyectoBL.GetFromProyectoByParameters
        Return factoryrepository.GetFromProyectoByParameters(_Nombre, _Estado, _Responsable)
    End Function
    Public Function GetPROYECTOBInTransaccion(ByVal Anio As Integer, ByVal Mes As Integer, ByVal Flag As String) As System.Collections.Generic.List(Of BussinessEntities.Proyecto) Implements IProyectoBL.GetPROYECTOBInTransaccion
        Return factoryrepository.GetPROYECTOBInTransaccion(Anio, Mes, Flag)
    End Function

    Public Function GetCodigoFromPROYECTO(ByVal IdProyecto As Integer) As BussinessEntities.Proyecto Implements IProyectoBL.GetCodigoFromPROYECTO
        Return factoryrepository.GetCodigoFromPROYECTO(IdProyecto)
    End Function

    Public Function GetAllFromProyectoDatosGenerales() As System.Collections.Generic.List(Of BussinessEntities.Proyecto) Implements IProyectoBL.GetAllFromProyectoDatosGenerales
        Return factoryrepository.GetAllFromProyectoDatosGenerales
    End Function

    Public Function GetProyectoVigente() As System.Collections.Generic.List(Of BussinessEntities.Proyecto) Implements IProyectoBL.GetProyectoVigente
        Return factoryrepository.GetProyectoVigente
    End Function
End Class

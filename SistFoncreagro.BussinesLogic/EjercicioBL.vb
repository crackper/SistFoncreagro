Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class EjercicioBL : Implements IEjercicioBL
    Dim factoryrepository As IEjercicioRepository

    Public Sub New()
        factoryrepository = New EjercicioRepository
    End Sub
    Public Function GetEJERCICIOByAnio(ByVal Anio As Integer) As BussinessEntities.Ejercicio Implements IEjercicioBL.GetEJERCICIOByAnio
        Return factoryrepository.GetEJERCICIOByAnio(Anio)
    End Function

    Public Function GetEstadoMes(ByVal Anio As Integer, ByVal Mes As Integer) As String Implements IEjercicioBL.GetEstadoMes
        Return factoryrepository.GetEstadoMes(Anio, Mes)
    End Function

    Public Function SaveEJERCICIO(ByVal _Ejercicio As BussinessEntities.Ejercicio) As Integer Implements IEjercicioBL.SaveEJERCICIO
        Return factoryrepository.SaveEJERCICIO(_Ejercicio)
    End Function

    Public Function VerifyExisteEJERCICIO(ByVal Anio As Integer) As Integer Implements IEjercicioBL.VerifyExisteEJERCICIO
        Return factoryrepository.VerifyExisteEJERCICIO(Anio)
    End Function
End Class

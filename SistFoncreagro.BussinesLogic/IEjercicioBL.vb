Imports SistFoncreagro.BussinessEntities
Public Interface IEjercicioBL
    Function GetEJERCICIOByAnio(ByVal Anio As Int32) As Ejercicio
    Function GetEstadoMes(ByVal Anio As Int32, ByVal Mes As Int32) As String
    Function SaveEJERCICIO(ByVal _Ejercicio As Ejercicio) As Int32
    Function VerifyExisteEJERCICIO(ByVal Anio As Int32) As Int32
End Interface

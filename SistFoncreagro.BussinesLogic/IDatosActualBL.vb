Imports SistFoncreagro.BussinessEntities

Public Interface IDatosActualBL
    Function GetAnioActual() As Int32
    Function GetMesActual(ByVal _Mes As Int32) As String
End Interface

Imports SistFoncreagro.BussinessEntities

Public Interface IDetraccionBL
 Function GetAllFromDetraccion() As List(Of Detraccion)
    Function GetDETRACCIONByIdDetraccion(ByVal idDetraccion As Int32) As Detraccion
    Sub SaveDetraccion(ByVal _Detraccion As Detraccion)
    Sub UpdateEstadoDETRACCION(ByVal idDetraccion As Int32)
End Interface

Imports SistFoncreagro.BussinessEntities
Public Interface IProyectoBL
    Function GetAllFromProyecto() As List(Of Proyecto)
    Function GetProyectoVigente() As List(Of Proyecto)
    Function GetFromProyectoByIdProyecto(ByVal idproyecto As Int32) As Proyecto
    Function GetFromProyectoByParameters(ByVal _Nombre As String, ByVal _Estado As String, ByVal _Responsable As String) As List(Of Proyecto)
    Function SaveProyecto(ByVal _Proyecto As Proyecto) As Int32
    Function DeleteProyecto(ByVal id As Int32) As String
    Function GetPROYECTOBInTransaccion(ByVal Anio As Int32, ByVal Mes As Int32, ByVal Flag As String) As List(Of Proyecto)
    Function GetCodigoFromPROYECTO(ByVal IdProyecto As Int32) As Proyecto
    Function GetAllFromProyectoDatosGenerales() As List(Of Proyecto)
End Interface

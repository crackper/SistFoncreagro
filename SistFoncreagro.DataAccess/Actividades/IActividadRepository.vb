Imports SistFoncreagro.BussinessEntities

Public Interface IActividadRepository
    Function GetAllFromActividad() As List(Of Actividad)
    Function GetFromActividadById(ByVal _id As Int32) As Actividad
    Function GetActividadByIdCompAndIdProyAndIdConv(ByVal _IdComp As Int32, ByVal _IdProy As Int32, ByVal _IdConv As Int32) As List(Of Actividad)
    Function SaveActividad(ByVal _Actividad As Actividad) As Int32
    Function DeleteActividad(ByVal _id As Int32) As String
    Function GetActividadesByIdProycomp(ByVal idProycomp As Int32) As List(Of ActividadDto)
End Interface

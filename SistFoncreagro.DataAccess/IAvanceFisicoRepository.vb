Imports SistFoncreagro.BussinessEntities

Public Interface IAvanceFisicoRepository
    Function GetAvanceFisicoByIdProyecto(ByVal _IdProyecto As Int32, ByVal _Mes As Int32) As List(Of AvanceFisico)
    Function SaveAvanceFisico(ByVal _AvanceFisico As AvanceFisico) As Int32
    Function DeleteAvanceFisico(ByVal _id As Int32) As String
    Sub NewAvanceFisico(ByVal _IdProyecto As Int32, ByVal _Anio As Int32, ByVal _Mes As Int32)

End Interface

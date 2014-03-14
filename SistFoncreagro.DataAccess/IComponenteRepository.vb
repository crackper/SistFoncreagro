Imports SistFoncreagro.BussinessEntities

Public Interface IComponenteRepository
    Function GetAllFromComponente() As List(Of Componente)
    Function GetFromComponenteById(ByVal _id As Int32) As Componente
    Function GetFromComponenteByIdConveProy(ByVal _id As Int32) As List(Of Componente)
    Function GetFromComponenteByIdProyAndIdConv(ByVal _IdProy As Int32, ByVal _IdConv As Int32) As List(Of Componente)
    Function SaveComponente(ByVal _Componente As Componente) As Int32
    Function DeleteComponente(ByVal _id As Int32) As String
End Interface

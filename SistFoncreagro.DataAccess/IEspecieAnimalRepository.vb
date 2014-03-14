Imports SistFoncreagro.BussinessEntities
Public Interface IEspecieAnimalRepository
    Function GetAllFromEspecieAnimal() As List(Of EspecieAnimal)
    Function GetEspecieAnimalByIdRaza(ByVal idRaza As Int32) As EspecieAnimal
End Interface

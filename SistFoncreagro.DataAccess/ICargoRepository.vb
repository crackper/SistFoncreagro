Imports SistFoncreagro.BussinessEntities
Public Interface ICargoRepository
    Function GetAllFromCargo() As List(Of Cargo)
    Function SaveCargo(ByVal cargo As Cargo) As Int32
    Function GetCARGOByNomCargo(ByVal NomCargo As String) As Cargo
    Function GetCargoByIdCargo(ByVal IdCargo As Int32) As Cargo
    Sub DeleteCargo(ByVal idCargo As Int32)

End Interface

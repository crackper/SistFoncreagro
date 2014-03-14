Imports SistFoncreagro.BussinessEntities
Public Interface ICargoBL
    Function GetAllFromCargo() As List(Of Cargo)
    Function SaveCargo(ByVal cargo As Cargo) As Int32
    Function GetCARGOByNomCargo(ByVal NomCargo As String) As Cargo
    Function GetCargoByIdCargo(ByVal IdCargo As Int32) As Cargo
    Function InsertCargoNomCargo(ByVal cargo As Cargo) As Collection 'Inserta un cargo siempre y cuando el nombre del cargo no exista
    'La colección devolvera el (0) el IdInsertado o IdEncontrado
    'y en la posición (1) un mensaje: "El nombre del cargo ya existe"
    'y en la posicion (2) una "I" si ha sido insertado "E" si ya existia
    Sub DeleteCargo(ByVal idCargo As Int32)
End Interface

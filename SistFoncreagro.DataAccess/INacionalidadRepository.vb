Imports SistFoncreagro.BussinessEntities
Public Interface INacionalidadRepository
    Function GetAllFromNacionalidad() As List(Of Nacionalidad)
    Function GetNacionalidadByIdNacionalidad(ByVal idNacionalidad As Int32) As Nacionalidad
    Sub SaveNacionalidad(ByVal nacionalidad As Nacionalidad)
    Sub DeleNacionalidad(ByVal idNacionalidad As Int32)

End Interface

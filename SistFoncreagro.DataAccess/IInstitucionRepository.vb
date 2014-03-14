Imports SistFoncreagro.BussinessEntities

Public Interface IInstitucionRepository
    Function GetInstitucionByIdconvenio(ByVal _id As Int32) As List(Of Institucion)
    Function SaveInstitucion(ByVal _Institucion As Institucion) As Int32
    Sub DeleteInstitucion(ByVal _id As Int32)
End Interface

Imports SistFoncreagro.BussinessEntities
Public Interface IGradoSalarialBL
    Function GetAllFromGRADOSALARIAL() As List(Of GradoSalarial)
    Function SaveGRADOSALARIAL(ByVal GradoSalarial As GradoSalarial) As Int32
    Function GetGradoSalarialByGrado(ByVal Grado As String) As GradoSalarial
    Sub DeleteGradoSalarial(ByVal idGradoSalarial As Int32)
    Function InsertGradoSalarialGrado(ByVal grado As GradoSalarial) As Collection 'Inserta un grado salarial siempre y cuando el nombre del cargo no exista
    'La colección devolvera el (0) el IdInsertado o IdEncontrado
    'y en la posición (1) un mensaje: "El nombre del cargo ya existe"
    'y en la posicion (2) una "I" si ha sido insertado "E" si ya existia

End Interface

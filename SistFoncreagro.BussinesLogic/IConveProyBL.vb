Imports SistFoncreagro.BussinessEntities

Public Interface IConveProyBL
    Function GetAllFromConveProy() As List(Of ConveProy)
    Function GetFromConveProyById(ByVal _id As Int32) As ConveProy
    Function GetFromConveProyByIdConvenio(ByVal _id As Int32) As List(Of ConveProy)
    Function GetFromConveProyByIdProyecto(ByVal _id As Int32) As List(Of ConveProy)
    Function GetFromConveProyByIdProyAndIdconv(ByVal _idProy As Int32, ByVal _idConv As Int32) As ConveProy
    Function SaveConveProy(ByVal _ConveProy As ConveProy) As Int32
    Function DeleteConveProy(ByVal _id As Int32) As String
End Interface

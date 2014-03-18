Imports SistFoncreagro.BussinessEntities

Public Interface IConvenioRepository

    Function GetAllFromConvenio() As List(Of Convenio)
    Function GetFromConvenioByIdConvenio(ByVal id As Int32) As Convenio
    Function GetFromConvenioByParameters(ByVal _Codigo As String, ByVal _Nombre As String, ByVal _Estado As String, ByVal _Fase As String) As List(Of Convenio)
    Function SaveConvenio(ByVal convenio As Convenio) As Int32
    Function DeleteConvenio(ByVal id As Int32) As String
    Function GetConveniosByIdProyecto(ByVal idProyecto As Int32) As List(Of ConvenioDto)
End Interface

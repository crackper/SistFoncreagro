﻿Imports SistFoncreagro.BussinessEntities

Public Interface IConvenioBL
    Function GetAllFromConvenio() As List(Of Convenio)
    Function GetFromConvenioByIdConvenio(ByVal id As Int32) As Convenio
    Function GetFromConvenioByParameters(ByVal _Codigo As String, ByVal _Nombre As String, ByVal _Estado As String, ByVal _Fase As String) As List(Of Convenio)
    Function SaveConvenio(ByVal _Convenio As Convenio) As Int32
    Function DeleteConvenio(ByVal id As Int32) As String
End Interface

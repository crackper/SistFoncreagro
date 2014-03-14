Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class ConvenioBL : Implements IConvenioBL

    Dim factoryrepository As IConvenioRepository

    Public Sub New()
        factoryrepository = New ConvenioRepository
    End Sub

    Public Function GetAllFromConvenio() As System.Collections.Generic.List(Of BussinessEntities.Convenio) Implements IConvenioBL.GetAllFromConvenio
        Return factoryrepository.GetAllFromConvenio()
    End Function

    Public Function SaveConvenio(ByVal _Convenio As BussinessEntities.Convenio) As Integer Implements IConvenioBL.SaveConvenio
        Return factoryrepository.SaveConvenio(_Convenio)
    End Function

    Public Function GetFromConvenioByIdConvenio(ByVal id As Integer) As BussinessEntities.Convenio Implements IConvenioBL.GetFromConvenioByIdConvenio
        Return factoryrepository.GetFromConvenioByIdConvenio(id)
    End Function

    Public Function DeleteConvenio(ByVal id As Integer) As String Implements IConvenioBL.DeleteConvenio
        Return factoryrepository.DeleteConvenio(id)
    End Function

    Public Function GetFromConvenioByParameters(ByVal _Codigo As String, ByVal _Nombre As String, ByVal _Estado As String, ByVal _Fase As String) As System.Collections.Generic.List(Of BussinessEntities.Convenio) Implements IConvenioBL.GetFromConvenioByParameters
        Return factoryrepository.GetFromConvenioByParameters(_Codigo, _Nombre, _Estado, _Fase)
    End Function
End Class

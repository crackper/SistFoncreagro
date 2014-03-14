Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ParametroLaboralBL : Implements IParametroLaboralBL
    Dim factoryrepository As IParametroLaboralRepository

    Public Sub New()
        factoryrepository = New ParametroLaboralRepository
    End Sub
    Public Sub DeletePARAMETROLABORAL(ByVal IdParametroLab As Integer) Implements IParametroLaboralBL.DeletePARAMETROLABORAL
        factoryrepository.DeletePARAMETROLABORAL(IdParametroLab)
    End Sub

    Public Function GetAllFromParametrosLaborales() As System.Collections.Generic.List(Of BussinessEntities.ParametrosLaborales) Implements IParametroLaboralBL.GetAllFromParametrosLaborales
        Return factoryrepository.GetAllFromParametrosLaborales
    End Function

    Public Function GetParametrosLaboralesByIdParametroLab(ByVal IdParametroLab As Integer) As BussinessEntities.ParametrosLaborales Implements IParametroLaboralBL.GetParametrosLaboralesByIdParametroLab
        Return factoryrepository.GetParametrosLaboralesByIdParametroLab(IdParametroLab)
    End Function

    Public Function SaveParametroLaborales(ByVal parametroLaboral As BussinessEntities.ParametrosLaborales) As Integer Implements IParametroLaboralBL.SaveParametroLaborales
        Return factoryrepository.SaveParametroLaborales(parametroLaboral)
    End Function

End Class

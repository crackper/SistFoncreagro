Imports SistFoncreagro.BussinessEntities
Public Interface IParametroLaboralBL
    Function GetAllFromParametrosLaborales() As List(Of ParametrosLaborales)
    Function GetParametrosLaboralesByIdParametroLab(ByVal IdParametroLab As Int32) As ParametrosLaborales
    Function SaveParametroLaborales(ByVal parametroLaboral As ParametrosLaborales) As Int32
    Sub DeletePARAMETROLABORAL(ByVal IdParametroLab As Int32)
End Interface

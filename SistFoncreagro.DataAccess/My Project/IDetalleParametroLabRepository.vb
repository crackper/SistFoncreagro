Imports SistFoncreagro.BussinessEntities
Public Interface IDetalleParametroLabRepository
    Function GetDetalleParametrosLabByIdParametroLab(ByVal IdParametroLab As Int32) As List(Of DetalleParametroLab)
    Function GetDetalleParametrosLabByIdDetalleParametroLab(ByVal IdDetalleParametroLab As Int32) As DetalleParametroLab
    Function GetDetalleParametrosLabVigenteByIdParametroLab(ByVal IdParametroLab As Int32) As DetalleParametroLab
    Function SaveDetalleParametroLab(ByVal DetalleParametroLab As DetalleParametroLab) As Int32
    Sub DeleteDetalleParametroLab(ByVal IdDetalleParametroLab As Int32)
End Interface

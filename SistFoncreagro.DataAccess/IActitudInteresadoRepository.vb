Imports SistFoncreagro.BussinessEntities
Public Interface IActitudInteresadoRepository
    Function GetACTITUDINTERESADOByIdActitud(ByVal IdActitud As Int32) As ActitudInteresado
    Sub DeleteACTITUDINTERESADO(ByVal IdActitud As Int32)
    Sub SaveACTITUDINTERESADO(ByVal _ActitudInteresado As ActitudInteresado)
    Function GetACTITUDINTERESADOByIdInteresado(ByVal IdInteresado As Int32)
    Function GetACTITUDINTERESADOByFecha(ByVal IdInteresado As Int32, ByVal FechaInicio As Date) As ActitudInteresado
End Interface

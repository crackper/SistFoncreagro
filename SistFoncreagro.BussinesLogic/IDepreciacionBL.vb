Imports SistFoncreagro.BussinessEntities
Public Interface IDepreciacionBL
    Sub SaveDEPRECIACION(ByVal _Depreciacion As Depreciacion)
    Function GetDEPRECIACIONByIdDepreciacion(ByVal IdDeprecicion As Int32) As Depreciacion
    Sub DeleteDEPRECIACION(ByVal IdDepreciacion As Int32)
    Sub GenerarDepreciacion(ByVal fechaContable As DateTime, ByVal usuario As Int32, ByVal ejercicio As Int32, ByVal mes As Int32, ByVal idProyecto As Int32)
End Interface

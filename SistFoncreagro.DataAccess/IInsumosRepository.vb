Imports SistFoncreagro.BussinessEntities
Public Interface IInsumosRepository
    Sub SaveINSUMOS(ByVal _Insumos As Insumos)
    Sub DeleteINSUMOS(ByVal IdInsumo As Int32)
    Function GetINSUMOSByIdControl(ByVal IdControl As Int32) As List(Of Insumos)
    Function GetINSUMOSByIdInsumo(ByVal IdInsumo As Int32) As Insumos
End Interface

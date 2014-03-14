Imports SistFoncreagro.BussinessEntities
Public Interface IProgramacionRepository
    Sub SavePROGRAMACION(ByVal _Programacion As Programacion)
    Sub GenerarProgramacionPoaTecnico(ByVal anio As Int32, ByVal IdProyecto As Int32)
    Sub SaveListaProgramacion(ByVal Programacion As List(Of Programacion))
End Interface

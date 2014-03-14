Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TareaBL : Implements ITareaBL
    Dim factoryrepository As ITareaRepository

    Public Sub New()
        factoryrepository = New TareaRepository
    End Sub

    Public Sub DeleteTAREA(IdTarea As Integer) Implements ITareaBL.DeleteTAREA
        factoryrepository.DeleteTAREA(IdTarea)
    End Sub

    Public Sub SaveTAREA(_Tarea As BussinessEntities.Tarea) Implements ITareaBL.SaveTAREA
        factoryrepository.SaveTAREA(_Tarea)
    End Sub
End Class

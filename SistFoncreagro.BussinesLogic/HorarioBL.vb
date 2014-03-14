Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class HorarioBL : Implements IHorarioBL

    Dim factoryrepository As IHorarioRepository

    Public Sub New()
        factoryrepository = New HorarioRepository
    End Sub

    Public Function GetHorarioByIdHorario(ByVal IdHorario As Integer, ByVal IdJornadaTrabajo As Integer) As BussinessEntities.Horario Implements IHorarioBL.GetHorarioByIdHorario
        Return factoryrepository.GetHorarioByIdHorario(IdHorario, IdJornadaTrabajo)
    End Function

    Public Function GetAllFromHORARIO() As System.Collections.Generic.List(Of BussinessEntities.Horario) Implements IHorarioBL.GetAllFromHORARIO
        Return factoryrepository.GetAllFromHORARIO()
    End Function
End Class

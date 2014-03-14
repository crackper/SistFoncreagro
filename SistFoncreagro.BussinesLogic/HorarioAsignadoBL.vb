Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class HorarioAsignadoBL : Inherits MasterDataAccess : Implements IHorarioAsignadoBL
    Dim factoryrepository As IHorarioAsignadoRepository

    Public Sub New()
        factoryrepository = New HorarioAsignadoRepository
    End Sub

    Public Function GetHorarioAsignadoByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Integer) As System.Collections.Generic.List(Of BussinessEntities.HorarioAsignado) Implements IHorarioAsignadoBL.GetHorarioAsignadoByIdPeriodoLaboral
        Return factoryrepository.GetHorarioAsignadoByIdPeriodoLaboral(IdPeriodoLaboral)
    End Function

    Public Function GetHorarioAsignadoByIdPeriodoLaboralAndByFecha(ByVal IdPeriodoLaboral As Integer, ByVal Fecha As Date) As BussinessEntities.HorarioAsignado Implements IHorarioAsignadoBL.GetHorarioAsignadoByIdPeriodoLaboralAndByFecha
        Return factoryrepository.GetHorarioAsignadoByIdPeriodoLaboralAndByFecha(IdPeriodoLaboral, Fecha)
    End Function

    Public Function SaveHORARIOASIGNADO(ByVal HorarioAsignado As BussinessEntities.HorarioAsignado) As Integer Implements IHorarioAsignadoBL.SaveHORARIOASIGNADO
        Return factoryrepository.SaveHORARIOASIGNADO(HorarioAsignado)
    End Function
End Class

Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TelefonoAsignadoBL : Implements ITelefonoAsignadoBL
    Dim factoryrepository As ITelefonoAsignadoRepository

    Public Sub New()
        factoryrepository = New TelefonoAsignado
    End Sub
    Public Sub DeleteTelefonoAsignado(ByVal IdAsignacionTelefono As Integer) Implements ITelefonoAsignadoBL.DeleteTelefonoAsignado
        factoryrepository.DeleteTelefonoAsignado(IdAsignacionTelefono)
    End Sub

    Public Function GetAllFromTelefonoAsignado() As System.Collections.Generic.List(Of BussinessEntities.TelefonoAsignado) Implements ITelefonoAsignadoBL.GetAllFromTelefonoAsignado
        Return factoryrepository.GetAllFromTelefonoAsignado
    End Function

    Public Function GetTelefonoAsignadoByIdAsignacionTelefono(ByVal IdAsignacionTelefono As Integer) As BussinessEntities.TelefonoAsignado Implements ITelefonoAsignadoBL.GetTelefonoAsignadoByIdAsignacionTelefono
        Return factoryrepository.GetTelefonoAsignadoByIdAsignacionTelefono(IdAsignacionTelefono)
    End Function

    Public Function GetTelefonoAsignadoByIdPeriodoLaboralByEstado(ByVal IdPeriodoLaboral As Integer, ByVal estado As Boolean) As System.Collections.Generic.List(Of BussinessEntities.TelefonoAsignado) Implements ITelefonoAsignadoBL.GetTelefonoAsignadoByIdPeriodoLaboralByEstado
        Return factoryrepository.GetTelefonoAsignadoByIdPeriodoLaboralByEstado(IdPeriodoLaboral, estado)
    End Function

    Public Function SaveTelefonoAsignado(ByVal telefonoAsignado As BussinessEntities.TelefonoAsignado) As Integer Implements ITelefonoAsignadoBL.SaveTelefonoAsignado
        Return factoryrepository.SaveTelefonoAsignado(telefonoAsignado)
    End Function
End Class

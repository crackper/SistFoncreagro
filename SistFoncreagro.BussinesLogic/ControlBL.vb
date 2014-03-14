Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ControlBL : Implements IControlBL
    Dim factoryrepository As IControlRepository
    Public Sub New()
        factoryrepository = New ControlRepository
    End Sub
    Public Sub DeleteCONTROL(ByVal IdControl As Integer) Implements IControlBL.DeleteCONTROL
        factoryrepository.DeleteCONTROL(IdControl)
    End Sub

    Public Function GetCONTROLByIdControl(ByVal IdControl As Integer) As BussinessEntities.Control Implements IControlBL.GetCONTROLByIdControl
        Return factoryrepository.GetCONTROLByIdControl(IdControl)
    End Function

    Public Function SaveCONTROL(ByVal _Control As BussinessEntities.Control) As Integer Implements IControlBL.SaveCONTROL
        Return factoryrepository.SaveCONTROL(_Control)
    End Function

    Public Function GetCONTROLByIdDetalleEje(ByVal IdDetalleEje As Integer) As System.Collections.Generic.List(Of BussinessEntities.Control) Implements IControlBL.GetCONTROLByIdDetalleEje
        Return factoryrepository.GetCONTROLByIdDetalleEje(IdDetalleEje)
    End Function

    Public Sub UpdateEstadoCONTROL(IdControl As Integer) Implements IControlBL.UpdateEstadoCONTROL
        factoryrepository.UpdateEstadoCONTROL(IdControl)
    End Sub

    Public Sub UpdateObservacionControl(IdControl As Integer, Observacion As String) Implements IControlBL.UpdateObservacionControl
        factoryrepository.UpdateObservacionControl(IdControl, Observacion)
    End Sub

    Public Sub ReprogramarActividad(IdControl As Integer, Fecha As Date, IdUsuario As Integer, Observacion As String) Implements IControlBL.ReprogramarActividad
        factoryrepository.ReprogramarActividad(IdControl, Fecha, IdUsuario, Observacion)
    End Sub

    Public Sub ReprogramarActividadGeneral(IdDetalleEje As Integer, Fecha As Date, IdUsuario As Integer, Observacion As String) Implements IControlBL.ReprogramarActividadGeneral
        factoryrepository.ReprogramarActividadGeneral(IdDetalleEje, Fecha, IdUsuario, Observacion)
    End Sub

    Public Sub CancelarActividad(IdControl As Integer, IdUsuario As Integer, Observacion As String) Implements IControlBL.CancelarActividad
        factoryrepository.CancelarActividad(IdControl, IdUsuario, Observacion)
    End Sub

    Public Sub CancelarActividadGeneral(IdDetalleEje As Integer, IdUsuario As Integer, Observacion As String) Implements IControlBL.CancelarActividadGeneral
        factoryrepository.CancelarActividadGeneral(IdDetalleEje, IdUsuario, Observacion)
    End Sub
End Class

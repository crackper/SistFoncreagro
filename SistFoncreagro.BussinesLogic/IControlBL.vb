Imports SistFoncreagro.BussinessEntities
Public Interface IControlBL
    Function SaveCONTROL(ByVal _Control As Control) As Int32
    Function GetCONTROLByIdDetalleEje(ByVal IdDetalleEje As Int32) As List(Of Control)
    Function GetCONTROLByIdControl(ByVal IdControl As Int32) As Control
    Sub DeleteCONTROL(ByVal IdControl As Int32)
    Sub UpdateEstadoCONTROL(ByVal IdControl As Int32)
    Sub UpdateObservacionControl(ByVal IdControl As Int32, Observacion As String)
    Sub ReprogramarActividad(ByVal IdControl As Int32, Fecha As Date, IdUsuario As Integer, Observacion As String)
    Sub ReprogramarActividadGeneral(ByVal IdDetalleEje As Int32, Fecha As Date, IdUsuario As Integer, Observacion As String)
    Sub CancelarActividad(ByVal IdControl As Int32, IdUsuario As Integer, Observacion As String)
    Sub CancelarActividadGeneral(ByVal IdDetalleEje As Int32, IdUsuario As Integer, Observacion As String)
End Interface

Imports SistFoncreagro.BussinessEntities
Public Class JornadaLaboralPeriodo
    Public Property IdJornadaLaboral As System.Nullable(Of Int32)
    Public Property IdPeriodoDeclaracion As System.Nullable(Of Int32)
    Public Property IdPeriodoLaboral As System.Nullable(Of Int32)
    Public Property DiasEfecTrabajados As System.Nullable(Of Decimal)
    Public Property DiasDescanso As System.Nullable(Of Decimal)
    Public Property DiasFeriados As System.Nullable(Of Decimal)
    Public Property HorasOrdinarias As System.Nullable(Of Decimal)
    Public Property HorasExtraordinarias25 As System.Nullable(Of Decimal)
    Public Property HorasExtraordinarias35 As System.Nullable(Of Decimal)
    Public Property DiasNoSubsidiados As System.Nullable(Of Decimal)
    Public Property DiasSubsidiados As System.Nullable(Of Decimal)

    Public Property listaAusenciaEntity As New List(Of AusenciaPeriodo)
End Class

Imports SistFoncreagro.BussinessEntities
Public Class PosicionCentroCosto
    Public Property IdPosicionCCostos As System.Nullable(Of Int32)
    Public Property IdPosicion As System.Nullable(Of Int32)
    Public Property IdCCosto As System.Nullable(Of Int32)
    Public Property FechaAsignacion As DateTime
    Public Property Porcentaje As System.Nullable(Of Decimal)
    Public Property MontoFijo As System.Nullable(Of Decimal)

    Public Property posicion As Posicion
    Public Property cCostos As CCosto
End Class

Public Class OrdenCentroCosto
    Public Property IdOrdenCentroCosto As Int32
    Public Property IdOrdenCompra As Int32
    Public Property IdCentroCosto As Int32
    Public Property Monto As Decimal
    Public Property Estado As String
    Public Property centroC As CCosto
    Public ReadOnly Property NombreCentroCosto As String
        Get
            Return centroC.CodigoElementoGasto & " - Monto: " & CStr(Monto).ToString & " - Estado: " & Estado
        End Get
    End Property
End Class

Public Class CtaBancariaProyecto
    Public Property IdCtaBancaria As Int32
    Public Property IdProyecto As Int32
    Public Property Descripcion As String
    Public Property Saldo As Nullable(Of Decimal)
    Public Property Proyecto As Proyecto
    Public Property Estado As String
    Public ReadOnly Property NomProyecto As String
        Get
            Return Proyecto.AreaProyecto

        End Get
    End Property
End Class

Public Class Proyecto
   
    Public Property IdProyecto As Int32
    Public Property Nombre As String
    Public Property IniProyProg As System.Nullable(Of DateTime)
    Public Property IniProyReal As System.Nullable(Of DateTime)
    Public Property FinProyProg As System.Nullable(Of DateTime)
    Public Property FinProyReal As System.Nullable(Of DateTime)
    Public Property Monto As Decimal
    Public Property Estado As String
    Public Property Alineamiento As String
    Public Property Programa As String
    Public Property Codigo As String
    Public Property IdResponsable As Int32
    Public Property TotalPresupuestado As Decimal
    Public Property TotalEjecutado As Decimal
    Public Property TotalComprometido As Decimal
    Public Property CodigoAdicional As String
    Public Property AliasProy As String

    Public Property _Personal As Personal

    Public ReadOnly Property NombreResponsable As String
        Get
            Return _Personal.nombreCompleto
        End Get
    End Property

    Public ReadOnly Property AreaProyecto As String
        Get
            Return Codigo & "-" & Nombre
        End Get
    End Property
End Class

Public Class ConveMarco
    Public Property IdConveMarco As Int32
    Public Property Codigo As String
    Public Property Nombre As String
    'Public Property _Adjuntos As List(Of AdjMonit)


    Public ReadOnly Property Marco As String
        Get
            Return Codigo + " " + Nombre
        End Get
    End Property
End Class

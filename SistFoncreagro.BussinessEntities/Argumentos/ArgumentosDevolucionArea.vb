Public Class ArgumentosDevolucionArea
    Public Property DevolverArea As Boolean
    Public Property ArgArea As ArgumentosArea

    Sub New(ByVal _devolverArea As Boolean, ByVal _argArea As ArgumentosArea)
        DevolverArea = _devolverArea
        ArgArea = _argArea
    End Sub
End Class

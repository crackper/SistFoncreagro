Public Class ArgumentosCoordinaParteProyecto
    Public Property DevolverProyecto As Boolean
    Public Property DevolverArea As ArgumentosDevolucionArea

    Sub New(ByVal _devolerProyecto As Boolean, ByVal _devolverArea As ArgumentosDevolucionArea)
        DevolverProyecto = _devolerProyecto
        DevolverArea = _devolverArea
    End Sub

End Class

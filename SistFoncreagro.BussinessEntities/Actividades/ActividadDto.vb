Public Class ActividadDto
    Public Sub New()
        CCostos = New List(Of CCostoDto)()
    End Sub

    Public Property IdProyAct As Int32
    Public Property IdProycomp As Int32
    Public Property Actividad As String
    Public Property Porcentaje As Decimal
    Public Property Codigo As String

    Public Property CCostos As List(Of CCostoDto)
End Class

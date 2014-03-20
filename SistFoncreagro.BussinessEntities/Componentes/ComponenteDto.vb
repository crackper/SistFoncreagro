Public Class ComponenteDto

    Public Sub New()
        Actividades = New List(Of ActividadDto)()
    End Sub

    Property IdProyComp As Int32
    Property IdConvProy As Int32
    Property IdComponente As Int32
    Property Componente As String
    Property Descripcion As String
    Property Porcentaje As Decimal

    Property Actividades As List(Of ActividadDto)
End Class

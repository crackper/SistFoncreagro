Public Class ConvenioDto
    Property IdConvProy As Int32
    Property IdConvenio As Int32
    Property IdProyecto As Int32
    Property Convenio As String
    Property MontoAprobado As Decimal

    Property Componentes As List(Of ComponenteDto)
End Class

Imports SistFoncreagro.BussinessEntities
Public Class DerechoHabiente
    Public Property IdDerechoHabiente As System.Nullable(Of Int32)
    Public Property IdPersonal As System.Nullable(Of Int32)
    Public Property IdVinculo As System.Nullable(Of Int32)
    Public Property Nombre As String
    Public Property ApePaterno As String
    Public Property ApeMaterno As String
    Public Property EstadoCivil As String
    Public Property FechaNacimiento As Date
    Public Property Discapacidad As System.Nullable(Of Boolean)
    Public Property Estudiando As System.Nullable(Of Boolean)
    Public Property Estado As String
    Public Property FechaConvivencia As System.Nullable(Of Date)
    Public Property IdTipoDI As System.Nullable(Of Int32)
    Public Property IdNacionalidad As System.Nullable(Of Int32)
    Public Property NroDI As String

    Public Property VinculoEntity As VinculoFamiliar
    Public Property NacionalidadEntity As Nacionalidad
    Public Property TipoDIEntity As TipoDocumentoIdentidad
End Class

Public Class DetalleConcepto
    Public Property IdDetalleConcepto As System.Nullable(Of Int32)
    Public Property IdConceptoPlanilla As System.Nullable(Of Int32)
    Public Property CodSunat As String
    Public Property Descripcion As String
    Public Property IdTipoConcepto As System.Nullable(Of Int32)
    Public Property CondicionValor As String

    Public Property ConceptoPlanillaEntity As ConceptoPlanilla
    Public Property TipoConceptoEntity As TipoConcepto

    Public Property FactorVigenteEntity As New Factor
    Public Property listaRemComputable As New List(Of REMUNERACIONCOMPUTABLE)
End Class

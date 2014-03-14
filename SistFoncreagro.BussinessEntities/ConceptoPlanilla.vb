Public Class ConceptoPlanilla
    Public Property IdConceptoPlanilla As System.Nullable(Of Int32)
    Public Property CodSunat As String
    Public Property Descripcion As String
    Public Property IdTipoConcepto As System.Nullable(Of Int32)

    Public Property TipoConceptoEntity As TipoConcepto

    Public ReadOnly Property Tipo As String
        Get
            Return TipoConceptoEntity.Tipo
        End Get
    End Property
End Class

Public Class TipoPlanilla
    Public Property IdTipoPlanilla As System.Nullable(Of Int32)
    Public Property NombrePlanilla As String
    Public Property Tipo As System.Nullable(Of Int32)
    Public Property listaTipoPlanillaTipotrabajador As New List(Of TipoPlanillaTipoTrabajador)

    Public Property TiposTrabajadorConcatenada As String

    Public ReadOnly Property NombreTipo As String
        Get
            Select Case Tipo
                Case 1
                    Return "Sueldo"
                Case 2
                    Return "Gratificaciones"
                Case 3
                    Return "Cts"
                Case 4
                    Return "Liquidaciones"
                Case Else
                    Return ""
            End Select
        End Get
    End Property

End Class

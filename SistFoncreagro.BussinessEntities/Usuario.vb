Public Class Usuario
    Public Property IdUsuario As Int32
    Public Property NombreUsuario As String
    Public Property NombrePersonalCompleto As String
    Public Property Estado As Boolean
    Public Property NroFalla As Int32

    Public ReadOnly Property EstadoNombre As String
        Get
            If Estado = True Then
                Return "Bloqueado"
            Else
                Return "Habilitado"
            End If
        End Get
    End Property
End Class

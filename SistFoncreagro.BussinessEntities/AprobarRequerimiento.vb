Public Class AprobarRequerimiento
    Public Property IdAprobarRequerimiento As Int32
    Public Property IdRol As Int32
    Public Property Orden As Int32
    Public Property AreaProyecto As Boolean
    Public Property aRol As ROL
    Public ReadOnly Property NombreRol As String
        Get
            Return aRol.NombreRol
        End Get
    End Property
End Class

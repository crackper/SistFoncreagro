Public Class RolPersonal
    Public Property IdRolPersonal As Int32
    Public Property IdRol As Int32
    Public Property IdPersonal As Int32
    Public Property IdProyecto As Int32
    Public Property Estado As Boolean
    Public Property Persona As Personal
    Public Property Proyecto As Proyecto

    Public ReadOnly Property NombrePersona As String
        Get
            Return Persona.nombreCompleto
        End Get
    End Property

    Public ReadOnly Property NombreProyecto As String
        Get
            If IdProyecto <> 0 Then
                Return Proyecto.AreaProyecto
            Else
                Return "-"
            End If
        End Get
    End Property
End Class

Public Class ProyectoArea
    Public Property IdProyectoArea As System.Nullable(Of Int32)
    Public Property IdProyecto As System.Nullable(Of Int32)
    Public Property IdArea As System.Nullable(Of Int32)

    Public Property proyectoEntity As New Proyecto
    Public Property AreaEntity As New Proyecto

    Public ReadOnly Property NombreProyecto As String
        Get
            Return proyectoEntity.Nombre
        End Get
    End Property

    Public ReadOnly Property NombreArea As Int32
        Get
            Return AreaEntity.Nombre
        End Get
    End Property

    Public ReadOnly Property CodAreaProyecto As String
        Get
            Return proyectoEntity.Codigo & " _ " & proyectoEntity.Nombre
        End Get
    End Property

    Public ReadOnly Property estadoProyecto As String
        Get
            Return proyectoEntity.Estado
        End Get
    End Property

End Class

Public Class CoordinaParteProyecto
    Public Property IdCoordinaProyecto As Int32
    Public Property IdProyecto As Int32
    Public Property IdArea As Int32

    Public Property proyecto As Proyecto
    Public Property Area As Proyecto

    Public ReadOnly Property NombreProyecto As String
        Get
            Return proyecto.Nombre
        End Get
    End Property
    'Public ReadOnly Property AliasProyecto As String
    '    Get
    '        Return proyecto.AliasProy
    '    End Get
    'End Property
    Public ReadOnly Property NombreArea As Int32
        Get
            Return Area.Nombre
        End Get
    End Property
    Public ReadOnly Property CodigoArea As Int32
        Get
            Return Area.Codigo
        End Get
    End Property


End Class

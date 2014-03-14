Public Class Posicion : Inherits Cargo
    Public Property IdPosicion As System.Nullable(Of Int32)
    Public Property Dependencia As System.Nullable(Of Int32)
    'Public Property cargo As Cargo ' como hereda de cargo, esto no es necesario
    Public Property Area As New Area '
    Public Property Archivo As String
    Public Property GradoSalarial As GradoSalarial '
    Public Property jefeInmediato As Posicion '(int32)
    Public Property Experiencia As System.Nullable(Of Decimal)
    Public Property FechaCreacion As DateTime
    Public Property Confianza As String
    Public Property EsJefeArea As Boolean

    Public Property ListaFunciones As List(Of Funciones)
    Public Property ListaFormacionRequerida As List(Of FormacionRequerida)
    Public Property ListaHabilidades As List(Of Habilidades)
    Public Property ListaRequesitosAdicionales As List(Of RequisitoAdicional)

    Public ReadOnly Property NombreArea As String
        Get
            Return Area.Nombre
        End Get
    End Property

    Public ReadOnly Property IdArea As System.Nullable(Of Int32)
        Get
            Return Area.IdArea
        End Get
    End Property

End Class

Public Class CargoArea : Inherits Cargo
    Public Property IdCargoArea As Int32
    Public Property Area As Area
    Public Property Archivo As String
    Public Property GradoSalarial As GradoSalarial
    'Public Property CargoSuperiorArea As CargoArea
    Public Property Experiencia As Decimal
    Public Property FechaCreacion As DateTime
    Public Property Confianza As String

    Public Property ListaFunciones As List(Of Funciones)
    Public Property ListaFormacionRequerida As List(Of FormacionRequerida)
    Public Property ListaHabilidades As List(Of Habilidades)
    Public Property ListaRequesitosAdicionales As List(Of RequisitoAdicional)

    Class FuncionesCargo
        Public Property idFuncion As Int16
        Public Property descripcion As String
    End Class


End Class

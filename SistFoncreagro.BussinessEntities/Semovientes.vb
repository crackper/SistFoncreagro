Public Class Semovientes
    Public Property IdSemoviente As Int32
    Public Property IdProyecto As Int32
    Public Property IdProyectoCPD As Int32
    Public Property AreteMicrochip As String
    Public Property AreteEstablo As String
    Public Property FechaNacimiento As System.Nullable(Of Date)
    Public Property EdadMeses As Int32
    Public Property Nombre As String
    Public Property IdRaza As Int32
    Public Property DescSemoviente As String
    Public Property IdSemovientePadre As System.Nullable(Of Int32)
    Public Property IdSemovienteMadre As System.Nullable(Of Int32)
    Public Property TipoIngreso As Int32
    Public Property IdOrigenSemoviente As String
    Public Property FechaRegistro As Date
    Public Property IdPlan As System.Nullable(Of Int32)
    Public Property Sexo As String
    Public Property Color As String
    Public Property especie As EspecieAnimal
    Public ReadOnly Property idEspecie As Int32
        Get
            Return especie.idespecieanimal
        End Get
    End Property
    Public ReadOnly Property nombreEspecie As String
        Get
            Return especie.especie
        End Get
    End Property
End Class

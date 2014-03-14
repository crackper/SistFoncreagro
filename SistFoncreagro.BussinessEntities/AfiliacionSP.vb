Public Class AfiliacionSP
    Public Property IdAfiliacionSP As System.Nullable(Of Int32)
    Public Property IdPersonal As System.Nullable(Of Int32)
    Public Property IdSistemaPensiones As System.Nullable(Of Int32)
    Public Property FechaAfiliacion As System.Nullable(Of Date)
    Public Property CUSPP As String
    Public Property Estado As Boolean

    Public Property SistemaDePensionesEntity As New SistemaDePensiones

    Public ReadOnly Property NombreSP As String
        Get
            Return SistemaDePensionesEntity.Descripcion
        End Get
    End Property

    Public ReadOnly Property FechaFormato As String
        Get
            Return String.Format("{0:dd/MM/yy}", FechaAfiliacion)
        End Get
    End Property
End Class


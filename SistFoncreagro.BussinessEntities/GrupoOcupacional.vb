Public Class GrupoOcupacional
    Public Property IdGrupoOcupacional As Int32
    Public Property Descripcion As String
    Public Property CodigoNO As String
    Public Property Disponible As Boolean

    Public ReadOnly Property CodigoDescripcion As String
        Get
            Return CodigoNO & " " & Descripcion
        End Get
    End Property
End Class

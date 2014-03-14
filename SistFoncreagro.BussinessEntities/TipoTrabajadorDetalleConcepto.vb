Public Class TipoTrabajadorDetalleConcepto
    Public Property IdTipoTDetConcepto As System.Nullable(Of Int32)
    Public Property IdTipoTrabajador As System.Nullable(Of Int32)
    Public Property IdCategoria As System.Nullable(Of Int32)
    Public Property IdDetalleConcepto As System.Nullable(Of Int32)

    Public Property tipoTrabajadorEntity As New TipoTrabajador
    Public Property categoriaRrhhEntity As New CategoriaRrhh
End Class

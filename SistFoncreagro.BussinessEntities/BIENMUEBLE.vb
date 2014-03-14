Public Class BIENMUEBLE
    Public Property IdBienMueble As Int32
    Public Property Codigo As String
    Public Property Tipo As String
    Public Property IdCatalogo As Int32
    Public Property IdPlanCuenta As Int32
    Public Property IdPlanDepreciacion As System.Nullable(Of Int32)
    Public Property IdPlanDepreciacion1 As System.Nullable(Of Int32)
    Public Property IdProyecto As Int32
    Public Property IdCCosto As System.Nullable(Of Int32)
    Public Property FechaIngreso As DateTime
    Public Property Costo As Decimal
    Public Property Estado As String
    Public Property IdProveedorCliente As System.Nullable(Of Int32)
    Public Property Descripcion As String
    Public Property IdTipoDocumento As System.Nullable(Of Int32)
    Public Property NroDocumento As System.Nullable(Of Int64)
    Public Property SerieDocumento As String
    Public Property IdMarca As System.Nullable(Of Int32)
    Public Property Modelo As String
    Public Property Serie As String
    Public Property Color As String
    Public Property Motor As String
    Public Property Placa As String
    Public Property Otro As String
    Public Property IdOficina As Int32
    Public Property IdBienPadre As System.Nullable(Of Int32)
    Public Property IdUsuario As Int32
    Public Property Donacion As String
    Public Property Validado As String
    Public Property Conservacion As String
    Public Property CodigoReferencia As String
    Public Property Catalogo As Catalogo
    Public Property Area As Proyecto
    ReadOnly Property Bien As String
        Get
            Return Codigo + " " + Catalogo.Descripcion + " - " + Area.Codigo + " - " + CodigoReferencia
        End Get
    End Property
End Class

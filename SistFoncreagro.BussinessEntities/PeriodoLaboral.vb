Public Class PeriodoLaboral
    Public Property IdPeriodoLaboral As System.Nullable(Of Int32)
    Public Property IdPersonal As System.Nullable(Of Int32)
    Public Property IdCategoria As System.Nullable(Of Int32)
    Public Property IdTipoTrabajador As System.Nullable(Of Int32)
    Public Property FechaInicio As System.Nullable(Of Date)
    Public Property FechaCese As System.Nullable(Of Date)
    Public Property IdDeclarante As System.Nullable(Of Int32)
    Public Property NroFotocheck As String
    Public Property EmailCoorporativo As String
    Public Property TelefCoorp As String
    Public Property Estado As String
    Public Property IdMotivoFinDePeriodo As System.Nullable(Of Int32)

    Public Property personal As Personal
    Public Property categoriaRrhh As CategoriaRrhh
    Public Property tipoTrabajador As TipoTrabajador
    Public Property declarante As Declarante
    Public Property motivoFinDePeriodo As MotivoFinDePeriodo

    Public Property ListaTelefonosAsignados As List(Of TelefonoAsignado)
    Public Property listaContratosConvenios As ContratoConvenio
    Public Property contratoActual As ContratoConvenio

End Class

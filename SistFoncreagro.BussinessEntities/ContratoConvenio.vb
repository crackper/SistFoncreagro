Public Class ContratoConvenio : Inherits TipoContrato
    Public Property IdContrato As System.Nullable(Of Int32)
    Public Property IdPeriodoLaboral As System.Nullable(Of Int32)
    'tipoContrato se hereda
    Public Property IdGrupoOcupacional As System.Nullable(Of Int32)
    Public Property NroContrato As String
    Public Property Archivo As String
    Public Property IdHorario As System.Nullable(Of Int32)
    Public Property Estado As String
    Public Property FechaFirma As System.Nullable(Of DateTime)
    Public Property FechaInicio As System.Nullable(Of DateTime)
    Public Property FechaTermino As System.Nullable(Of DateTime)
    Public Property IdCentro As System.Nullable(Of Int32)
    Public Property Renovacion As System.Nullable(Of Boolean)

    Public Property periodoLaboral As PeriodoLaboral
    Public Property horario As Horario
    Public Property tipoTrabajador As TipoTrabajador
    Public Property grupoOcupacionalEntity As GrupoOcupacional
    Public Property centroDeFormacionEducativa As CentroDeFormacionEducativa


    Public Property listaCondicionesContrato As List(Of CondicionesContrato)
    Public Property condicionesActualesDeContrato As CondicionesContrato
End Class

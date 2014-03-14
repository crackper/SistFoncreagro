Public Class Requerimiento
    Public Property IdRequerimiento As Int32
    Public Property IdProyectoArea As Int32
    Public Property IdCentroCosto As Int32
    Public Property IdMoneda As Int32
    Public Property Numero As String
    Public Property FechaRequerimiento As Date
    Public Property Tipo As String
    Public Property IdRequeridoPor As Int32
    Public Property Estado As String
    Public Property Sustento As String
    Public Property FechaEnvioAprobar As System.Nullable(Of Date)
    Public Property IdComprador As Int32
    Public Property Observacion As String
    Public Property Monto As Decimal
    Public Property Periodo As Boolean
    Public Property FechaInicioServicio As Date
    Public Property FechaFinServicio As Date
    Public Property Ruta As Boolean
    Public Property IdRutaOrigen As Int32
    Public Property IdRutaDestino As Int32
    Public Property ActivarCentroCosto As Boolean
    Public Property IdResponsableAprobar As Int32
    Public Property AbreviacionMoneda As String
    Public Property NombreRequiere As String
    Public Property CodigoArea As String
    Public Property NroAdjuntos As Int32
    Public Property personaComprador As Personal
    Public Property rutaRequerimientoOrigen As RutaRequerimiento
    Public Property rutaRequerimientoDestino As RutaRequerimiento
    Public Property proyecto As Proyecto
    Public Property detalleRequerimiento As List(Of DetalleRequerimiento)

    Public ReadOnly Property HabilitarCentroCosto As String
        Get
            If ActivarCentroCosto = True Then
                Return "Activado"
            Else
                Return "Desactivado"
            End If
        End Get
    End Property
End Class

﻿Public Class EstadoCotizacion
    'IdEstadoRequerimiento, IdRequerimiento, IdPersonal, FechaApruebaAnula, IdRol
    Public Property IdEstadoCotizacion As Int32
    Public Property IdCotizacion As Int32
    Public Property IdPersonal As Int32
    Public Property FechaApruebaAnula As System.Nullable(Of Date)
    Public Property IdRol As Int32
    Public Property persona As Personal
    Public ReadOnly Property NombrePersona As String
        Get
            Return persona.nombreCompleto
        End Get
    End Property
End Class
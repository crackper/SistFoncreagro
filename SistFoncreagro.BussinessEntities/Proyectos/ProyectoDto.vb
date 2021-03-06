﻿Public Class ProyectoDto

    Public Sub New()
        Convenios = New List(Of ConvenioDto)()
    End Sub

    Public Property IdProyecto As Int32
    Public Property Codigo As String
    Public Property Nombre As String
    Public Property AliasProy As String
    Public Property IniProyProg As System.Nullable(Of DateTime)
    Public Property FinProyProg As System.Nullable(Of DateTime)
    Public Property Estado As String
    Public Property Alineamiento As String
    Public Property Programa As String
    Public Property CodigoAdicional As String

    ''responsable
    Public Property IdResponsable As Int32
    Public Property Responsable As String

    ''Convenios
    Public Property Convenios As List(Of ConvenioDto)
End Class

Public Class DistribucionCCostosPersonal
    Public Property IdDistribucionCCP As System.Nullable(Of Int32)
    Public Property IdCCosto As System.Nullable(Of Int32)
    Public Property IdPeriodoLaboral As System.Nullable(Of Int32)
    Public Property AnioIni As String
    Public Property MesIni As String
    Public Property AnioFin As String
    Public Property MesFin As String
    Public Property CondicionMonto As String
    Public Property Valor As Decimal

    Public Property ElementoGastoEntity As ElementoGasto
    Public Property TipoGastoEntity As Clasificacion
    Public Property CCostoEntity As CCosto
    Public Property ProyectoEntity As Proyecto


    ReadOnly Property CodigoElementoGasto As String
        Get
            If Not CCostoEntity Is Nothing And Not ElementoGastoEntity Is Nothing Then
                Return CCostoEntity.Codigo & "-" & ElementoGastoEntity.NomElemGasto
            Else
                Return ""
            End If
        End Get
    End Property

    ReadOnly Property NombreCondicion As String
        Get
            Select Case CondicionMonto
                Case 0
                    Return "%"
                Case 1
                    Return "Fijo S/."
                Case 2
                    Return "Restante"
                Case Else
                    Return ""
            End Select

        End Get
    End Property

    ReadOnly Property IdProyecto As System.Nullable(Of Int32)
        Get
            If Not ProyectoEntity Is Nothing Then
                Return ProyectoEntity.IdProyecto
            Else
                Return Nothing
            End If
        End Get
    End Property

End Class

Public Class Rendicion
    Public Property IdRendicion As Int32
    Public Property Codigo As String
    Public Property Fecha As DateTime
    Public Property IdOpFinanciera As Int32
    Public Property Responsable As Int32
    Public Property Estado As String
    Public Property IdSubDiario As Int32
    Public Property IdProyecto As Int32
    Public Property Observacion As String
    Public Property Proyecto As Proyecto
    Public ReadOnly Property NomEstado As String
        Get
            Select Case Estado
                Case "1"
                    Return "Pendiente"
                Case "2"
                    Return "Para Aprobacion"
                Case "3"
                    Return "Aprobado"
                Case "4"
                    Return "Observado"
                Case "5"
                    Return "Anulado"
            End Select

        End Get
    End Property
    Public ReadOnly Property NomProyecto As String
        Get
            Return Proyecto.Codigo + " " + Proyecto.Nombre
        End Get
    End Property
End Class

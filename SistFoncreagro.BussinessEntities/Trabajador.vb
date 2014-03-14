Public Class Trabajador
    Inherits Personal

    Public Property PeriodoLaboralActual As PeriodoLaboral
    Public Property ContratoActual As ContratoConvenio 'llamo a los factory de contrato actual con el id de Periodo laboral
    Public Property CondicionesActualesDelContrato As CondicionesContrato 'llamo a los factory de PromocionRotacion con el id contrato

    Sub New(ByVal _idPersonal As Int32, ByVal _periodoLaboralActual As PeriodoLaboral)
        IdPersonal = IdPersonal
        PeriodoLaboralActual = _periodoLaboralActual

    End Sub

    'Public Property ContratoActual As ContratoConvenio
        'Get
        'Return
        'End Get
        'Set(ByVal value As ContratoConvenio)

        'End Set
    'End Property

End Class

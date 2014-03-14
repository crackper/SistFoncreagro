Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class CondicionesContratoBL : Implements ICondicionesContratoBL
    Dim factoryrepository As ICondicionesContratoRepository

    Public Sub New()
        factoryrepository = New CondicionesContratoRepository
    End Sub

    Public Sub DeleteCondicionContrato(ByVal idCondicion As Integer, ByVal idContrato As Integer, ByVal idPeriodoLaboral As Integer) Implements ICondicionesContratoBL.DeleteCondicionContrato
        factoryrepository.DeleteCondicionContrato(idCondicion, idContrato, idPeriodoLaboral)
    End Sub

    Public Function GetAllCondicionesContratoActual(ByVal argCondContrato As BussinessEntities.ArgumentosCondicionesContrato) As System.Collections.Generic.List(Of BussinessEntities.CondicionesContrato) Implements ICondicionesContratoBL.GetAllCondicionesContratoActual
        Return factoryrepository.GetAllCondicionesContratoActual(argCondContrato)
    End Function

    Public Function GetAllFromCondicionesContrato(ByVal argCondContrato As BussinessEntities.ArgumentosCondicionesContrato) As System.Collections.Generic.List(Of BussinessEntities.CondicionesContrato) Implements ICondicionesContratoBL.GetAllFromCondicionesContrato
        Return factoryrepository.GetAllFromCondicionesContrato(argCondContrato)
    End Function

    Public Function GetCondicionesContratoActualByIdContratoByIdPeriodo(ByVal idContratoConvenio As Integer, ByVal idPeriodoLaboral As Integer, ByVal argCondContrato As BussinessEntities.ArgumentosCondicionesContrato) As BussinessEntities.CondicionesContrato Implements ICondicionesContratoBL.GetCondicionesContratoActualByIdContratoByIdPeriodo
        Return factoryrepository.GetCondicionesContratoActualByIdContratoByIdPeriodo(idContratoConvenio, idPeriodoLaboral, argCondContrato)
    End Function

    Public Function GetCondicionesContratoByIdCondicionIdContratoByIdPeriodoLaboral(ByVal idCondicion As Integer, ByVal idContrato As Integer, ByVal idPeriodoLaboral As Integer, ByVal argCondContrato As BussinessEntities.ArgumentosCondicionesContrato) As BussinessEntities.CondicionesContrato Implements ICondicionesContratoBL.GetCondicionesContratoByIdCondicionIdContratoByIdPeriodoLaboral
        Return factoryrepository.GetCondicionesContratoByIdCondicionIdContratoByIdPeriodoLaboral(idCondicion, idContrato, idPeriodoLaboral, argCondContrato)
    End Function

    Public Function GetCondicionesContratoByIdContratoByIdPeriodoLaboral(ByVal idContratoConvenio As Integer, ByVal idPeriodoLaboral As Integer, ByVal argCondContrato As BussinessEntities.ArgumentosCondicionesContrato) As System.Collections.Generic.List(Of BussinessEntities.CondicionesContrato) Implements ICondicionesContratoBL.GetCondicionesContratoByIdContratoByIdPeriodoLaboral
        Return factoryrepository.GetCondicionesContratoByIdContratoByIdPeriodoLaboral(idContratoConvenio, idPeriodoLaboral, argCondContrato)
    End Function

    Public Function GetCondicionesContratoValidasByFechaByIdContratoByIdPeriodo(ByVal Fecha As Date, ByVal IdContrato As Integer, ByVal IdPeriodoLaboral As Integer, ByVal argCondContrato As BussinessEntities.ArgumentosCondicionesContrato) As BussinessEntities.CondicionesContrato Implements ICondicionesContratoBL.GetCondicionesContratoValidasByFechaByIdContratoByIdPeriodo
        Return factoryrepository.GetCondicionesContratoValidasByFechaByIdContratoByIdPeriodo(Fecha, IdContrato, IdPeriodoLaboral, argCondContrato)
    End Function

    Public Function GetCondicionesContratoValidasByFechaByIdPosicion(ByVal Fecha As Date, ByVal IdPosicion As Integer) As System.Collections.Generic.List(Of BussinessEntities.CondicionesContrato) Implements ICondicionesContratoBL.GetCondicionesContratoValidasByFechaByIdPosicion
        Return factoryrepository.GetCondicionesContratoValidasByFechaByIdPosicion(Fecha, IdPosicion)
    End Function

    Public Function SaveCondicionesContrato(ByVal condicionContrato As BussinessEntities.CondicionesContrato) As Integer Implements ICondicionesContratoBL.SaveCondicionesContrato
        Return factoryrepository.SaveCondicionesContrato(condicionContrato)
    End Function
End Class

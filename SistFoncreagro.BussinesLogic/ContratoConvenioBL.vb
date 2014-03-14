Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ContratoConvenioBL : Implements IContratoConvenioBL

    Dim factoryrepository As IContratoConvenioRepository

    Public Sub New()
        factoryrepository = New ContratoConvenioRepository
    End Sub

    Public Sub DeleteContratoConvenio(ByVal idContrato As Integer, ByVal idPeriodoLaboral As Integer) Implements IContratoConvenioBL.DeleteContratoConvenio
        factoryrepository.DeleteContratoConvenio(idContrato, idPeriodoLaboral)
    End Sub

    Public Function GetAllContratoConvenioActuales(ByVal argContrato As BussinessEntities.ArgumentosContrato) As System.Collections.Generic.List(Of BussinessEntities.ContratoConvenio) Implements IContratoConvenioBL.GetAllContratoConvenioActuales
        Return factoryrepository.GetAllContratoConvenioActuales(argContrato)
    End Function

    Public Function GetAllFromContratoConvenio(ByVal argContrato As BussinessEntities.ArgumentosContrato) As System.Collections.Generic.List(Of BussinessEntities.ContratoConvenio) Implements IContratoConvenioBL.GetAllFromContratoConvenio
        Return factoryrepository.GetAllFromContratoConvenio(argContrato)
    End Function

    Public Function GetContratoConvenioActualByIdPeriodoLaboral(ByVal idPeriodoLaboral As Integer, ByVal argContrato As BussinessEntities.ArgumentosContrato) As BussinessEntities.ContratoConvenio Implements IContratoConvenioBL.GetContratoConvenioActualByIdPeriodoLaboral
        Return factoryrepository.GetContratoConvenioActualByIdPeriodoLaboral(idPeriodoLaboral, argContrato)
    End Function

    Public Function GetContratosConveniosUltimoByIdPeriodoLaboral(ByVal idPeriodoLaboral As Integer, ByVal argContrato As BussinessEntities.ArgumentosContrato) As BussinessEntities.ContratoConvenio Implements IContratoConvenioBL.GetContratosConveniosUltimoByIdPeriodoLaboral
        Return factoryrepository.GetContratosConveniosUltimoByIdPeriodoLaboral(idPeriodoLaboral, argContrato)
    End Function

    Public Function GetContratoConvenioIdPeriodoLaboralAndIdContrato(ByVal idPeriodoLaboral As Integer, ByVal idContrato As Integer, ByVal argContrato As BussinessEntities.ArgumentosContrato) As BussinessEntities.ContratoConvenio Implements IContratoConvenioBL.GetContratoConvenioIdPeriodoLaboralAndIdContrato
        Return factoryrepository.GetContratoConvenioIdPeriodoLaboralAndIdContrato(idPeriodoLaboral, idContrato, argContrato)
    End Function

    Public Function GetContratoConveniosIdPeriodoLaboral(ByVal idPeriodoLaboral As Integer, ByVal argContrato As BussinessEntities.ArgumentosContrato) As System.Collections.Generic.List(Of BussinessEntities.ContratoConvenio) Implements IContratoConvenioBL.GetContratoConveniosIdPeriodoLaboral
        Return factoryrepository.GetContratoConveniosIdPeriodoLaboral(idPeriodoLaboral, argContrato)
    End Function

    Public Function GetContratosConveniosActivoByFechaAndIdPeriodoLaboral(ByVal Fecha As Date, ByVal IdPeriodoLaboral As Integer, ByVal argContrato As BussinessEntities.ArgumentosContrato) As BussinessEntities.ContratoConvenio Implements IContratoConvenioBL.GetContratosConveniosActivoByFechaAndIdPeriodoLaboral
        Return factoryrepository.GetContratosConveniosActivoByFechaAndIdPeriodoLaboral(Fecha, IdPeriodoLaboral, argContrato)
    End Function

    Public Function GetUltimaFechaContratoByIdPeriodoLaboral(ByVal fecha As String) As Object Implements IContratoConvenioBL.GetUltimaFechaContratoByIdPeriodoLaboral
        Return factoryrepository.GetUltimaFechaContratoByIdPeriodoLaboral(fecha)
    End Function

    Public Function SaveContratosConvenios(ByVal contratoConvenio As BussinessEntities.ContratoConvenio) As Integer Implements IContratoConvenioBL.SaveContratosConvenios
        Return factoryrepository.SaveContratosConvenios(contratoConvenio)
    End Function

    Public Sub UpdateContratoInEstadoByIdCotratoByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Integer, ByVal Estado As String) Implements IContratoConvenioBL.UpdateContratoInEstadoByIdCotratoByIdPeriodoLaboral
        factoryrepository.UpdateContratoInEstadoByIdCotratoByIdPeriodoLaboral(IdPeriodoLaboral, Estado)
    End Sub

    Public Sub UpdateArchivoContratos(ByVal IdPeriodoLaboral As Integer, ByVal IdContrato As Integer, ByVal Archivo As String) Implements IContratoConvenioBL.UpdateArchivoContratos
        factoryrepository.UpdateArchivoContratos(IdPeriodoLaboral, IdContrato, Archivo)
    End Sub

    Public Function GetArchivoContratosConveniosByIdPeriodoLaboralByIdContrato(ByVal IdPeriodoLaboral As Integer, ByVal IdContrato As Integer) As String Implements IContratoConvenioBL.GetArchivoContratosConveniosByIdPeriodoLaboralByIdContrato
        Return factoryrepository.GetArchivoContratosConveniosByIdPeriodoLaboralByIdContrato(IdPeriodoLaboral, IdContrato)
    End Function


End Class

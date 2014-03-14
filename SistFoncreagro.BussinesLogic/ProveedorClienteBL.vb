Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ProveedorClienteBL : Implements IProveedorClienteBL
    Dim factoryrepository As IProveedorClienteRepository
    Public Sub New()
        factoryrepository = New ProveedorClienteRepository
    End Sub
    Public Function GetAllFromProveedorCliente() As System.Collections.Generic.List(Of BussinessEntities.ProveedorCliente) Implements IProveedorClienteBL.GetAllFromProveedorCliente
        Return factoryrepository.GetAllFromProveedorCliente
    End Function

    Public Function GetAllFromProveedorClienteById(ByVal idProveedorCliente As Integer) As BussinessEntities.ProveedorCliente Implements IProveedorClienteBL.GetAllFromProveedorClienteById
        Return factoryrepository.GetAllFromProveedorClienteById(idProveedorCliente)
    End Function

    Public Function GetAllFromProveedorClienteByTipo(ByVal tipo As Integer) As System.Collections.Generic.List(Of BussinessEntities.ProveedorCliente) Implements IProveedorClienteBL.GetAllFromProveedorClienteByTipo
        Return factoryrepository.GetAllFromProveedorClienteByTipo(tipo)
    End Function

    Public Function GetProveedoresClienteInTransaccion(ByVal Anio As Integer, ByVal Mes As Integer, ByVal IdSubDiario As Integer) As System.Collections.Generic.List(Of BussinessEntities.ProveedorCliente) Implements IProveedorClienteBL.GetProveedoresClienteInTransaccion
        Return factoryrepository.GetProveedoresClienteInTransaccion(Anio, Mes, IdSubDiario)
    End Function

    Public Function SaveProveedorCliente(ByVal proveedorCliente As BussinessEntities.ProveedorCliente) As Boolean Implements IProveedorClienteBL.SaveProveedorCliente
        Return factoryrepository.SaveProveedorCliente(proveedorCliente)
    End Function

    Public Function GetAllFromProveedorClienteByParametro(ByVal parametro As String) As System.Collections.Generic.List(Of BussinessEntities.ProveedorCliente) Implements IProveedorClienteBL.GetAllFromProveedorClienteByParametro
        Return factoryrepository.GetAllFromProveedorClienteByParametro(parametro)
    End Function

    Public Sub DeleteProveedorCliente(ByVal idProveedorCliente As Integer) Implements IProveedorClienteBL.DeleteProveedorCliente
        factoryrepository.DeleteProveedorCliente(idProveedorCliente)
    End Sub
End Class

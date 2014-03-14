Imports SistFoncreagro.BussinessEntities
Public Interface IProveedorClienteBL
    Function GetProveedoresClienteInTransaccion(ByVal Anio As Int32, ByVal Mes As Int32, ByVal IdSubDiario As Int32) As List(Of ProveedorCliente)
    Function GetAllFromProveedorCliente() As List(Of ProveedorCliente)
    Function GetAllFromProveedorClienteByTipo(ByVal tipoProveedorCliente As Int32) As List(Of ProveedorCliente)
    Function GetAllFromProveedorClienteByParametro(ByVal parametro As String) As List(Of ProveedorCliente)
    Function GetAllFromProveedorClienteById(ByVal idProveedorCliente As Int32) As ProveedorCliente
    Function SaveProveedorCliente(ByVal proveedorCliente As ProveedorCliente) As Boolean
    Sub DeleteProveedorCliente(ByVal idProveedorCliente As Int32)
End Interface

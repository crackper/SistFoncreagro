Imports SistFoncreagro.BussinessEntities
Public Interface ILineaRepository
    Function GetAllFromLINEA() As List(Of Linea)
    Function GetLINEAByIdLinea(ByVal IdLinea As Int32) As Linea
    Function GetLINEAByIdTransaccion(ByVal IdTransaccion As Int32) As List(Of Linea)
    Function GetLINEAByIdTransaccionAndFlag(ByVal IdTransaccion As Int32) As List(Of Linea)
    Function GetNumeroRegistrosFromLINEA(ByVal IdTransaccion As Int32) As Int32
    Function GetNumeroRegistrosFromLINEA1(ByVal IdTransaccion As Int32) As Int32
    Function GetLINEACaja(ByVal Anio As Int32, ByVal IdProveedorCliente As Int32, ByVal Flag As String) As List(Of Linea)
    Function GetLINEACajaMasivos(ByVal Anio As Int32, ByVal Flag As String) As List(Of Linea)
    Function GetLINEAByRegistro(ByVal Registro As String, ByVal Coa As String, ByVal Cuenta As String) As Linea
    Function GetLINEADiario(ByVal Coa As Int32, ByVal OpFinan As Int32) As List(Of Linea)
    Function SaveLINEA(ByVal _Linea As Linea) As Int32
    Sub GenerarLINEA(ByVal IdTransaccion As Int32)
    Sub GenerarLINEACaja(ByVal IdTransaccion As Int32)
    Sub DeleteLINEA(ByVal IdLinea As Int32)
    Sub DeleteLINEAByFlag(ByVal IdTransaccion As Int32)
    Sub UpdateEstadoLINEA(ByVal IdLinea As Int32)
    Function GetTRANSACCIONByIdLinea(ByVal IdLinea As Int32) As Int32
    Sub UpdateMontosLINEA(ByVal idLinea As Int32, ByVal monto As Decimal)
End Interface

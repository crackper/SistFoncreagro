Imports SistFoncreagro.BussinessEntities
Public Interface IRolAsignadoRepository
    Function GetRolAsignadoByActivoByIdCondicionByContratoByIdPeriodo(ByVal Activo As Boolean, ByVal IdCondicion As Int32, ByVal IdContrato As Int32, ByVal IdPeriodo As Int32) As List(Of RolAsignado)
    Function SaveRolAsignado(ByVal rolAsignado As RolAsignado) As Int32
    Sub DeleteROLASIGNADO(ByVal IdRolAsignado As Int32, ByVal Idcondicion As Int32, ByVal IdContrato As Int32, ByVal IdPeriodo As Int32)
    Function GetRolAsignadoValidoByFechaByIdCondicionByContratoByIdPeriodo(ByVal Fecha As DateTime, ByVal IdCondicion As Int32, ByVal IdContrato As Int32, ByVal IdPeriodo As Int32) As List(Of RolAsignado)
    Function GetRolAsignadoValidoByFechaByIdRol(ByVal Fecha As DateTime, ByVal IdRol As Int32) As List(Of RolAsignado)
End Interface

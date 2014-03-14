Imports SistFoncreagro.BussinessEntities
Public Interface IOperacionFinancieraBL
    'Interfaz que permite trabajar con los metodos de operacion Financiera
    Function GetAllFromOperacionFinanciera() As List(Of OperacionFinanciera)
    Function GetOperacionFinancieraByIdOpFinaciera(ByVal IdOpFinanciera As Int32) As OperacionFinanciera
    Sub SaveOperacionFinanciera(ByVal _OperacionFinanciera As OperacionFinanciera)
    Sub DeleteOperacionFinanciera(ByVal IdOpFinanciera As Int32)

End Interface

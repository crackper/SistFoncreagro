Imports SistFoncreagro.BussinessEntities
Public Interface IInteresadosBL
    Function GetINTERESADOSByIdInteresado(ByVal IdInteresado As Int32) As Interesados
    Sub DeleteINTERESADOS(ByVal IdInteresado As Int32)
    Function SaveINTERESADO(ByVal _Interesados As Interesados) As Int32
    Function GetINTERESADOByParametro(ByVal Parametro As String) As List(Of Interesados)
    Function VerifyInteresado(dni As String) As Int32
    Function VerifyInteresado1(nombre As String) As Int32
End Interface

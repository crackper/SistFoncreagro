Imports SistFoncreagro.BussinessEntities
Public Interface IRolBL
    Function GetAllFromROL() As List(Of ROL)
    Function GetROLByIdRol(ByVal IdRol As Int32) As ROL
    Function SaveROL(ByVal rol As ROL) As Int32
    Sub DeleteROL(ByVal IdRol As Int32)
End Interface

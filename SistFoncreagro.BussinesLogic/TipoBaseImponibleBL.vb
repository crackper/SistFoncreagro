Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoBaseImponibleBL : Implements ITipoBaseImponibleBL
    Dim factoryrepository As ITipoBaseImponibleRepository

    Public Sub New()
        factoryrepository = New TipoBaseImponibleRepository
    End Sub

    Public Function GetAllFromTIPOBASEIMPONIBLE() As System.Collections.Generic.List(Of BussinessEntities.TipoBaseImponible) Implements ITipoBaseImponibleBL.GetAllFromTIPOBASEIMPONIBLE
        Return factoryrepository.GetAllFromTIPOBASEIMPONIBLE
    End Function
End Class

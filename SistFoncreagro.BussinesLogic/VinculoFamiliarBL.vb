Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class VinculoFamiliarBL : Implements IVinculoFamiliarBL
    Dim factoryrepository As IVinculoFamiliarRepository

    Public Sub New()
        factoryrepository = New VinculoFamiliarRepository
    End Sub
    Public Function GetAllFromVINCULOFAMILIAR() As System.Collections.Generic.List(Of BussinessEntities.VinculoFamiliar) Implements IVinculoFamiliarBL.GetAllFromVINCULOFAMILIAR
        Return factoryrepository.GetAllFromVINCULOFAMILIAR
    End Function
End Class

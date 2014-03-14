Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class EstadosFinancierosBL : Implements IEstadosFinancierosBL
    Dim factoryrepository As IEstadosFinancierosRepository
    Public Sub New()
        factoryrepository = New EstadosFinancierosRepository
    End Sub

    Public Function GetAllFromESTADOSFINANCIEROS() As System.Collections.Generic.List(Of BussinessEntities.EstadosFinancieros) Implements IEstadosFinancierosBL.GetAllFromESTADOSFINANCIEROS
        Return factoryrepository.GetAllFromESTADOSFINANCIEROS()
    End Function
End Class

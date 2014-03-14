Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class EstadosFinancierosRepository : Inherits MasterDataAccess : Implements IEstadosFinancierosRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of EstadosFinancieros)
        Dim lista As New List(Of EstadosFinancieros)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)

            While reader.Read
                Dim _EstadosFinancieros As New EstadosFinancieros() With
                {
                .Codigo = reader.GetValue(0),
                .Descripcion = reader.GetValue(1),
                .IdEstFinanciero = reader.GetValue(2)
                }

                lista.Add(_EstadosFinancieros)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function
    Public Function GetAllFromESTADOSFINANCIEROS() As System.Collections.Generic.List(Of BussinessEntities.EstadosFinancieros) Implements IEstadosFinancierosRepository.GetAllFromESTADOSFINANCIEROS
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromESTADOSFINANCIEROS")
        Return SelectObjectFactory(command)
    End Function
End Class

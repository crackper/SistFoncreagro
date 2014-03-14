Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class CargoBL : Implements ICargoBL

    Dim factoryrepository As ICargoRepository

    Public Sub New()
        factoryrepository = New CargoRepository
    End Sub

    Public Function GetAllFromCargo() As System.Collections.Generic.List(Of BussinessEntities.Cargo) Implements ICargoBL.GetAllFromCargo
        Return factoryrepository.GetAllFromCargo
    End Function

    Public Function SaveCargo(ByVal cargo As BussinessEntities.Cargo) As Int32 Implements ICargoBL.SaveCargo
        Return factoryrepository.SaveCargo(cargo)
    End Function

    Public Function GetCARGOByNomCargo(ByVal NomCargo As String) As Cargo Implements ICargoBL.GetCARGOByNomCargo
        Return factoryrepository.GetCARGOByNomCargo(NomCargo)
    End Function

    Public Function GetCargoByIdCargo(ByVal IdCargo As Integer) As BussinessEntities.Cargo Implements ICargoBL.GetCargoByIdCargo
        Return factoryrepository.GetCargoByIdCargo(IdCargo)
    End Function

    Public Function InsertCargoNomCargo(ByVal cargo As BussinessEntities.Cargo) As Microsoft.VisualBasic.Collection Implements ICargoBL.InsertCargoNomCargo
        Dim cargoEncontrado As New Cargo
        Dim coleccion As New Collection
        If cargo.IdCargo = 0 Then
            cargoEncontrado = GetCARGOByNomCargo(cargo.NomCargo)

            If cargoEncontrado Is Nothing Then
                Try
                    coleccion.Add(SaveCargo(cargo), "idCargo")
                    coleccion.Add("Registro " + cargo.NomCargo + "Insertado", "mensaje")
                    coleccion.Add("I", "condicion")
                Catch ex As Exception

                End Try

            Else
                coleccion.Add(cargoEncontrado.IdCargo, "idCargo")
                coleccion.Add("Ya existe un cargo con el ese nombre", "mensaje")
                coleccion.Add("E", "condicion")
            End If

        End If
        Return coleccion
    End Function

    Public Sub DeleteCargo(ByVal idCargo As Integer) Implements ICargoBL.DeleteCargo
        factoryrepository.DeleteCargo(idCargo)
    End Sub

End Class

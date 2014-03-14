Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class GradoSalarialBL : Implements IGradoSalarialBL
    Dim factoryrepository As IGradoSalarialRepository

    Public Sub New()
        factoryrepository = New GradoSalarialRepository
    End Sub
    Public Sub DeleteGradoSalarial(ByVal idGradoSalarial As Integer) Implements IGradoSalarialBL.DeleteGradoSalarial
        factoryrepository.DeleteGradoSalarial(idGradoSalarial)
    End Sub

    Public Function GetAllFromGRADOSALARIAL() As System.Collections.Generic.List(Of BussinessEntities.GradoSalarial) Implements IGradoSalarialBL.GetAllFromGRADOSALARIAL
        Return factoryrepository.GetAllFromGRADOSALARIAL()
    End Function

    Public Function GetGradoSalarialByGrado(ByVal Grado As String) As BussinessEntities.GradoSalarial Implements IGradoSalarialBL.GetGradoSalarialByGrado
        Return factoryrepository.GetGradoSalarialByGrado(Grado)
    End Function

    Public Function InsertGradoSalarialGrado(ByVal grado As BussinessEntities.GradoSalarial) As Microsoft.VisualBasic.Collection Implements IGradoSalarialBL.InsertGradoSalarialGrado
        Dim gradoEncontrado As New GradoSalarial
        Dim coleccion As New Collection
        If grado.IdGradoSalarial = 0 Then
            gradoEncontrado = GetGradoSalarialByGrado(grado.Grado)

            If gradoEncontrado Is Nothing Then
                Try
                    coleccion.Add(SaveGRADOSALARIAL(grado), "idGrado")
                    coleccion.Add("Registro " + grado.Grado + "Insertado", "mensaje")
                    coleccion.Add("I", "condicion")
                Catch ex As Exception

                End Try

            Else
                coleccion.Add(gradoEncontrado.IdGradoSalarial, "idGrado")
                coleccion.Add("Ya existe un cargo con el ese nombre", "mensaje")
                coleccion.Add("E", "condicion")
            End If

        End If
        Return coleccion

    End Function

    Public Function SaveGRADOSALARIAL(ByVal GradoSalarial As BussinessEntities.GradoSalarial) As Integer Implements IGradoSalarialBL.SaveGRADOSALARIAL
        Return factoryrepository.SaveGRADOSALARIAL(GradoSalarial)
    End Function
End Class

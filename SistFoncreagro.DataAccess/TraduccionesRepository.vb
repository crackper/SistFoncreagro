Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TraduccionesRepository : Inherits MasterDataAccess : Implements ITraduccionesRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Traducciones)
        Dim lista As New List(Of Traducciones)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Traducciones As New Traducciones() With
                {
                    .traducciones_eng = reader.GetValue(0),
                    .traducciones_esp = reader.GetValue(1)
                  }


                lista.Add(_Traducciones)
            End While
        End Using
        Return lista
    End Function
    Public Sub TraducirGrilla(ByVal sender As Object) Implements ITraduccionesRepository.TraducirGrilla
        Dim menu As Object = sender.FilterMenu
        Dim i As Integer
        For i = 0 To menu.Items.Count - 1
            'If Array.IndexOf(New String() {"GreaterThan", "LessThan", "GreaterThanOrEqualTo", "LessThanOrEqualTo", "IsNull", "NotIsNull", "Custom"}, menu.Items(i).Text) <> -1 Then
            'menu.Items(i).Visible = False
            'Else
            menu.Items(i).Text = Traducir(menu.Items(i).Text)
            'End If
        Next
    End Sub

    Public Function Traducir(ByVal IdTrad As String, Optional ByVal Idioma As String = "esp") As String Implements ITraduccionesRepository.Traducir
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTRADUCCIONES")
        Dim traduccion As String
        command.Parameters.AddWithValue("idTraducciones", IdTrad)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                traduccion = reader.GetValue(1)
            Else
                traduccion = reader.GetValue(0)

            End If

        End Using
        Return traduccion

    End Function
End Class

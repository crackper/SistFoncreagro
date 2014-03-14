Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class FuncionesRepository : Inherits MasterDataAccess : Implements IFuncionesRepository

    Public Function GetAllFromFUNCIONES() As System.Collections.Generic.List(Of BussinessEntities.Funciones) Implements IFuncionesRepository.GetAllFromFUNCIONES
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromREQUISITOADICIONAL")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFUNCIONESByIdFuncionAndIdPosicion(ByVal IdFuncion As Integer, ByVal IdPosicion As Integer) As BussinessEntities.Funciones Implements IFuncionesRepository.GetFUNCIONESByIdFuncionAndIdPosicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetFUNCIONESByIdFuncionAndIdPosicion")
        command.Parameters.AddWithValue("IdPosicion", IdPosicion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetFUNCIONESByIdPosicion(ByVal IdPosicion As Integer) As System.Collections.Generic.List(Of BussinessEntities.Funciones) Implements IFuncionesRepository.GetFUNCIONESByIdPosicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetFUNCIONESByIdPosicion")
        command.Parameters.AddWithValue("IdPosicion", IdPosicion)
        Return SelectObjectFactory(command)
    End Function

    Public Function SaveFUNCIONES(ByVal funciones As BussinessEntities.Funciones) As Integer Implements IFuncionesRepository.SaveFUNCIONES
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveFUNCIONES")
        command.Parameters.AddWithValue("IdFuncion", funciones.IdFuncion)
        command.Parameters.AddWithValue("IdPosicion", funciones.IdPosicion)
        command.Parameters.AddWithValue("Descripcion", funciones.Descripcion)

        'command.Parameters("idCargo").Direction = ParameterDirection.Output
        'MyBase.ExecuteNonQuery(command)
        Dim i As Int32
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If
            Else
                i = 0 'command.Parameters("idCargo").Value
            End If
        End Using
        Return i
        'command.ExecuteReader(CommandBehavior.SingleRow).Item(0)
    End Function

    Public Sub DeletefUNCIONES(ByVal idFuncion As Integer, ByVal IdPosicion As Integer) Implements IFuncionesRepository.DeletefUNCIONES

    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Funciones)
        Dim lista As New List(Of Funciones)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New Funciones
                If Not reader.IsDBNull(reader.GetOrdinal("IdPosicion")) Then
                    entity.IdPosicion = reader.GetValue(reader.GetOrdinal("IdPosicion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdFuncion")) Then
                    entity.IdFuncion = reader.GetValue(reader.GetOrdinal("IdFuncion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If
                
                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function
End Class

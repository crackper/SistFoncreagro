Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports SistFoncreagro.BussinessEntities

Public Class CatalogoRepository : Inherits MasterDataAccess : Implements ICatalogoRepository
    Dim unidadMedidaRepository As IUnidadMedidaRepository
    Dim clasificacionRepository As IClasificacionRepository
    Sub New()
        unidadMedidaRepository = New UnidadMedidaRepository
        clasificacionRepository = New ClasificacionRepository
    End Sub
    Public Sub DeleteCatalogo(ByVal idCatalogo As Integer) Implements ICatalogoRepository.DeleteCatalogo
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteCatalogo")
        command.Parameters.AddWithValue("IdCatalogo", idCatalogo)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Function GetAllFromCatalogoByIdCatalogo(ByVal idCatalogo As Integer) As BussinessEntities.Catalogo Implements ICatalogoRepository.GetAllFromCatalogoByIdCatalogo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCATALOGOByID")
        command.Parameters.AddWithValue("IdCatalogo", idCatalogo)
        Return SelectObjectFactoryCatalogo(command, True).SingleOrDefault
    End Function
    Public Function GetAllFromCatalogoByTipo(ByVal tipo As Integer) As System.Collections.Generic.List(Of BussinessEntities.Catalogo) Implements ICatalogoRepository.GetAllFromCatalogoByTipo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCATALOGOByTipo")
        command.Parameters.AddWithValue("TipoCatalogo", tipo)
        Return SelectObjectFactoryCatalogo(command, True)
    End Function
    Public Function GetAllFromCatalogoByParametro(ByVal tipo As Integer, ByVal parametro As String) As System.Collections.Generic.List(Of BussinessEntities.Catalogo) Implements ICatalogoRepository.GetAllFromCatalogoByParametro
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCatalogoByTipoByParametro")
        command.Parameters.AddWithValue("TipoCatalogo", tipo)
        command.Parameters.AddWithValue("Parametro", parametro)
        Return SelectObjectFactoryCatalogo(command, False)
    End Function

    Public Function GelAllFromProductosByParametro(ByVal Texto As String) As System.Collections.Generic.List(Of BussinessEntities.Catalogo) Implements ICatalogoRepository.GelAllFromProductosByParametro
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromProductosByParametro")
        command.Parameters.AddWithValue("Texto", Texto)
        Return SelectObjectFactoryCatalogo(command, False)
    End Function

    Public Sub SaveCatalogo(ByVal catalogo As BussinessEntities.Catalogo) Implements ICatalogoRepository.SaveCatalogo
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCatalogo")
        command.Parameters.AddWithValue("TipoCatalogo", catalogo.Tipo)
        command.Parameters.AddWithValue("Descripcion", catalogo.Descripcion)
        command.Parameters.AddWithValue("IdMarca", catalogo.IdMarca)
        command.Parameters.AddWithValue("IdUnidadMedida", catalogo.IdUnidadMedida)
        command.Parameters.AddWithValue("IdClasificacionGeneral", catalogo.IdClasificacionGeneral)
        command.Parameters.AddWithValue("PrecioCompra", catalogo.PrecioCompra)
        command.Parameters.AddWithValue("AfectoIgv", catalogo.AfectoIgv)
        command.Parameters.AddWithValue("IdMonedaCompra", catalogo.IdMonedaCompra)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Sub UpdateCatalogo(ByVal catalogo As BussinessEntities.Catalogo) Implements ICatalogoRepository.UpdateCatalogo
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateCatalogo")
        command.Parameters.AddWithValue("IdCatalogo", catalogo.IdCatalogo)
        command.Parameters.AddWithValue("Descripcion", catalogo.Descripcion)
        command.Parameters.AddWithValue("IdMarca", catalogo.IdMarca)
        command.Parameters.AddWithValue("IdUnidadMedida", catalogo.IdUnidadMedida)
        command.Parameters.AddWithValue("IdClasificacionGeneral", catalogo.IdClasificacionGeneral)
        command.Parameters.AddWithValue("PrecioCompra", catalogo.PrecioCompra)
        command.Parameters.AddWithValue("AfectoIgv", catalogo.AfectoIgv)
        command.Parameters.AddWithValue("IdMonedaCompra", catalogo.IdMonedaCompra)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Private Function SelectObjectFactoryCatalogo(ByVal command As SqlCommand, ByVal estado As Boolean) As List(Of Catalogo)
        Dim listaCatalogo As New List(Of Catalogo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim catalogo As New Catalogo()
                With catalogo
                    .IdCatalogo = reader.GetInt32(0)
                    .Tipo = reader.GetInt32(1)
                    .Codigo = reader.GetString(2)
                    .Descripcion = reader.GetString(3)
                    .IdMarca = reader.GetInt32(4)
                    .IdUnidadMedida = reader.GetInt32(5)
                    .IdClasificacionGeneral = reader.GetInt32(6)
                    .PrecioCompra = reader.GetDecimal(7)
                    .IdMonedaCompra = reader.GetInt32(8)
                    .AfectoIgv = reader.GetBoolean(9)
                End With
                If estado = True Then
                    catalogo.clasificacion = clasificacionRepository.GetFromClasificacionById(reader.GetInt32(6))
                End If
                If Not reader.IsDBNull(10) Then
                    catalogo.Observacion = reader.GetString(10)
                End If
                listaCatalogo.Add(catalogo)
            End While
        End Using
        Return listaCatalogo
    End Function

    Private Function SelectObjectFactoryCatalogoOfDetallerRequerimiento(ByVal command As SqlCommand) As List(Of Catalogo)
        Dim listaCatalogo As New List(Of Catalogo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim catalogo As New Catalogo
                With catalogo
                    .IdCatalogo = reader.GetInt32(0)
                    .Codigo = reader.GetString(1)
                    .Descripcion = reader.GetString(2)
                End With
                listaCatalogo.Add(catalogo)
            End While
        End Using
        Return listaCatalogo
    End Function

    Public Function GetAllFromCatalogoOfDetalleRequerimientoByParametro(ByVal idRequerimiento As Integer, ByVal parametro As String) As System.Collections.Generic.List(Of BussinessEntities.Catalogo) Implements ICatalogoRepository.GetAllFromCatalogoOfDetalleRequerimientoByParametro
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCatalogoOfDetalleRequerimientoByParametro")
        command.Parameters.AddWithValue("IdRequerimiento", idRequerimiento)
        command.Parameters.AddWithValue("Parametro", parametro)
        Return SelectObjectFactoryCatalogoOfDetallerRequerimiento(command)
    End Function
    Public Function GetAllFromCatalogoFullByParametro(ByVal parametro As String) As System.Collections.Generic.List(Of BussinessEntities.Catalogo) Implements ICatalogoRepository.GetAllFromCatalogoFullByParametro
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCatalogoFullByParametro")
        command.Parameters.AddWithValue("Parametro", parametro)
        Return SelectObjectFactoryCatalogo(command, False)
    End Function
End Class
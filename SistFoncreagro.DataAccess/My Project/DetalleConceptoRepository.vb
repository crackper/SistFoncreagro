Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class DetalleConceptoRepository : Inherits MasterDataAccess : Implements IDetalleConceptoRepository

    Public Sub DeleteDetalleConcepto(ByVal IdDetalleConcepto As Int32) Implements IDetalleConceptoRepository.DeleteDetalleConcepto
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDetalleConcepto")
        command.Parameters.AddWithValue("IdDetalleConcepto", IdDetalleConcepto)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetDetalleConceptoAportes() As System.Collections.Generic.List(Of BussinessEntities.DetalleConcepto) Implements IDetalleConceptoRepository.GetDetalleConceptoAportes
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDetalleConceptoAportes")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetDetalleConceptoByIdConceptoPlanilla(ByVal IdConceptoPlanilla As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleConcepto) Implements IDetalleConceptoRepository.GetDetalleConceptoByIdConceptoPlanilla
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDetalleConceptoByIdConceptoPlanilla")
        command.Parameters.AddWithValue("IdConceptoPlanilla", IdConceptoPlanilla)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetDetalleConceptoByIdDetalleConcepto(ByVal IdDetalleConcepto As Integer) As BussinessEntities.DetalleConcepto Implements IDetalleConceptoRepository.GetDetalleConceptoByIdDetalleConcepto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDetalleConceptoByIdDetalleConcepto")
        command.Parameters.AddWithValue("IdDetalleConcepto", IdDetalleConcepto)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetDetalleConceptoByIdTipoConcepto(ByVal IdTipoConcepto As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleConcepto) Implements IDetalleConceptoRepository.GetDetalleConceptoByIdTipoConcepto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDetalleConceptoByIdTipoConcepto")
        command.Parameters.AddWithValue("IdTipoConcepto", IdTipoConcepto)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetDetalleConceptoByCodTipoConcepto(ByVal Cod As String) As BussinessEntities.DetalleConcepto Implements IDetalleConceptoRepository.GetDetalleConceptoByCodTipoConcepto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDetalleConceptoByIdTipoConcepto")
        command.Parameters.AddWithValue("Cod", Cod)
        Return SelectObjectFactory2(command).SingleOrDefault
    End Function

    Public Function GetDetalleConceptoQueSonAportes() As System.Collections.Generic.List(Of BussinessEntities.DetalleConcepto) Implements IDetalleConceptoRepository.GetDetalleConceptoQueSonAportes
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDetalleConceptoQueSonAportes")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetDetalleConceptoQueSonIngresos() As System.Collections.Generic.List(Of BussinessEntities.DetalleConcepto) Implements IDetalleConceptoRepository.GetDetalleConceptoQueSonIngresos
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDetalleConceptoQueSonIngresos")
        Return SelectObjectFactory(command)
    End Function

    Public Function SaveDetalleConcepto(ByVal detalleConcepto As BussinessEntities.DetalleConcepto) As Integer Implements IDetalleConceptoRepository.SaveDetalleConcepto
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDetalleConcepto")
        command.Parameters.AddWithValue("IdDetalleConcepto", detalleConcepto.IdDetalleConcepto)
        command.Parameters.AddWithValue("IdConceptoPlanilla", detalleConcepto.IdConceptoPlanilla)
        command.Parameters.AddWithValue("IdTipoConcepto", detalleConcepto.IdTipoConcepto)
        command.Parameters.AddWithValue("CodSunat", detalleConcepto.CodSunat)
        command.Parameters.AddWithValue("Descripcion", detalleConcepto.Descripcion)
        command.Parameters.AddWithValue("CondicionValor", detalleConcepto.CondicionValor)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of DetalleConcepto)
        Dim lista As New List(Of DetalleConcepto)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New DetalleConcepto

                If Not reader.IsDBNull(reader.GetOrdinal("IdDetalleConcepto")) Then
                    entity.IdDetalleConcepto = reader.GetValue(reader.GetOrdinal("IdDetalleConcepto"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("CodSunat")) Then
                    entity.CodSunat = reader.GetValue(reader.GetOrdinal("CodSunat"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("CondicionValor")) Then
                    entity.CondicionValor = reader.GetValue(reader.GetOrdinal("CondicionValor"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdConceptoPlanilla")) Then
                    entity.IdConceptoPlanilla = reader.GetValue(reader.GetOrdinal("IdConceptoPlanilla"))
                    Dim conceptoPlanillaRepository As New ConceptoPlanillaRepository
                    Dim conceptoPlanilla As New ConceptoPlanilla
                    conceptoPlanilla = conceptoPlanillaRepository.GetConceptoPlanillaByIdConceptoPlanilla(entity.IdConceptoPlanilla)
                    entity.ConceptoPlanillaEntity = conceptoPlanilla
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoConcepto")) Then
                    entity.IdTipoConcepto = reader.GetValue(reader.GetOrdinal("IdTipoConcepto"))
                    Dim tipoConceptoRepository As New TipoConceptoRepository
                    Dim tipoConcepto As New TipoConcepto
                    tipoConcepto = tipoConceptoRepository.GetTIPOCONCEPTOByIdTipoConcepto(entity.IdTipoConcepto)
                    entity.TipoConceptoEntity = tipoConcepto
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

    Private Function SelectObjectFactory2(ByVal command As SqlCommand) As List(Of DetalleConcepto)
        Dim lista As New List(Of DetalleConcepto)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            Dim factorBL As New FactorRepository
            Dim RemuneracionComputableBL As New RemuneracionComputableRepository
            While reader.Read
                Dim entity As New DetalleConcepto

                If Not reader.IsDBNull(reader.GetOrdinal("IdDetalleConcepto")) Then
                    entity.IdDetalleConcepto = reader.GetValue(reader.GetOrdinal("IdDetalleConcepto"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("CodSunat")) Then
                    entity.CodSunat = reader.GetValue(reader.GetOrdinal("CodSunat"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("CondicionValor")) Then
                    entity.CondicionValor = reader.GetValue(reader.GetOrdinal("CondicionValor"))
                End If

                entity.FactorVigenteEntity = factorBL.GetFactorVigente(entity.IdDetalleConcepto)
                entity.listaRemComputable = RemuneracionComputableBL.GetRemuneracionComputableIdDetalleConcepto(entity.IdDetalleConcepto)

                'If Not reader.IsDBNull(reader.GetOrdinal("IdConceptoPlanilla")) Then
                '    entity.IdConceptoPlanilla = reader.GetValue(reader.GetOrdinal("IdConceptoPlanilla"))
                '    Dim conceptoPlanillaRepository As New ConceptoPlanillaRepository
                '    Dim conceptoPlanilla As New ConceptoPlanilla
                '    conceptoPlanilla = conceptoPlanillaRepository.GetConceptoPlanillaByIdConceptoPlanilla(entity.IdConceptoPlanilla)
                '    entity.ConceptoPlanillaEntity = conceptoPlanilla
                'End If

                'If Not reader.IsDBNull(reader.GetOrdinal("IdTipoConcepto")) Then
                '    entity.IdTipoConcepto = reader.GetValue(reader.GetOrdinal("IdTipoConcepto"))
                '    Dim tipoConceptoRepository As New TipoConceptoRepository
                '    Dim tipoConcepto As New TipoConcepto
                '    tipoConcepto = tipoConceptoRepository.GetTIPOCONCEPTOByIdTipoConcepto(entity.IdTipoConcepto)
                '    entity.TipoConceptoEntity = tipoConcepto
                'End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function


End Class

Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ConceptoPlanillaRepository : Inherits MasterDataAccess : Implements IConceptoPlanillaRepository

    Public Function GetAllFromConceptoPlanilla() As System.Collections.Generic.List(Of BussinessEntities.ConceptoPlanilla) Implements DataAccess.IConceptoPlanillaRepository.GetAllFromConceptoPlanilla
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromConceptoPlanilla")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetConceptoPlanillaByIdConceptoPlanilla(ByVal IdConceptoPlanillas As Integer) As BussinessEntities.ConceptoPlanilla Implements DataAccess.IConceptoPlanillaRepository.GetConceptoPlanillaByIdConceptoPlanilla
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetConceptoPlanillaByIdConceptoPlanilla")
        command.Parameters.AddWithValue("IdConceptoPlanilla", IdConceptoPlanillas)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetConceptoPlanillaByIdTipoConcepto(ByVal IdTipoConcepto As Integer) As System.Collections.Generic.List(Of BussinessEntities.ConceptoPlanilla) Implements DataAccess.IConceptoPlanillaRepository.GetConceptoPlanillaByIdTipoConcepto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetConceptoPlanillaByIdTipoConcepto")
        command.Parameters.AddWithValue("IdTipoConcepto", IdTipoConcepto)
        Return SelectObjectFactory(command)
    End Function
    Public Sub DeleteCONCEPTOPLANILLA(ByVal IdConceptoPlanilla As Integer) Implements IConceptoPlanillaRepository.DeleteCONCEPTOPLANILLA
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteCONCEPTOPLANILLA")
        command.Parameters.AddWithValue("IdConceptoPlanilla", IdConceptoPlanilla)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Function SaveConceptoPlanilla(ByVal conceptoPlanilla As ConceptoPlanilla) As Integer Implements DataAccess.IConceptoPlanillaRepository.SaveConceptoPlanilla
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveConceptoPlanilla")
        command.Parameters.AddWithValue("IdConceptoPlanilla", conceptoPlanilla.IdConceptoPlanilla)
        command.Parameters.AddWithValue("CodSunat", conceptoPlanilla.CodSunat)
        command.Parameters.AddWithValue("Descripcion", conceptoPlanilla.Descripcion)
        command.Parameters.AddWithValue("IdTipoConcepto", conceptoPlanilla.IdTipoConcepto)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ConceptoPlanilla)
        Dim lista As New List(Of ConceptoPlanilla)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New ConceptoPlanilla
                If Not reader.IsDBNull(reader.GetOrdinal("IdConceptoPlanilla")) Then
                    entity.IdConceptoPlanilla = reader.GetValue(reader.GetOrdinal("IdConceptoPlanilla"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoConcepto")) Then
                    entity.IdTipoConcepto = reader.GetValue(reader.GetOrdinal("IdTipoConcepto"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("CodSunat")) Then
                    entity.CodSunat = reader.GetValue(reader.GetOrdinal("CodSunat"))
                End If

                If entity.IdTipoConcepto.HasValue Then
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

End Class

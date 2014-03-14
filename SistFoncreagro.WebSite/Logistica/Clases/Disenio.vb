
Public Class Disenio
    Public Function ObtenerColorRequerimiento(ByVal est As String) As Drawing.Color
        Dim col As Drawing.Color
        If est = "Por Aprobar Ja" Then
            col = Drawing.Color.Blue
        ElseIf est = "Por Aprobar Adm" Then
            col = Drawing.Color.Chocolate
        ElseIf est = "Aprobado" Or est = "O/C" Then
            col = Drawing.Color.Green
        ElseIf est = "Anulado" Then
            col = Drawing.Color.Red
        ElseIf est = "Rechazado" Then
            col = Drawing.Color.Orange
        End If
        Return col
    End Function

    Public Function ObtenerColorOrdenCompra(ByVal est As String) As Drawing.Color
        Dim col As Drawing.Color
        If est = "Por Aprobar Cont" Then
            col = Drawing.Color.SlateGray
        ElseIf est = "Por Aprobar Ja" Then
            col = Drawing.Color.Blue
        ElseIf est = "Por Aprobar Adm" Then
            col = Drawing.Color.Chocolate
        ElseIf est = "Por Aprobar Dir" Then
            col = Drawing.Color.DarkCyan
        ElseIf est = "Aprobado" Then
            col = Drawing.Color.Green
        ElseIf est = "Anulado" Then
            col = Drawing.Color.Red
        ElseIf est = "Rechazado" Then
            col = Drawing.Color.Orange
        End If
        Return col
    End Function

    Public Sub Alerta(ByVal Mensaje As String, ByVal page As Page)
        Dim cj As String
        cj = "<script type='text/javascript'> " & _
             " radalert('" & Mensaje & "',400,100); " & _
             Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(page, GetType(Page), "xalerta", cj.ToString, False)
    End Sub

End Class

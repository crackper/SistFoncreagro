Public Class ArgumentosArea
    Public Property DevolverJefatura As Boolean
    Public Property DevolverProyectos As Boolean
    Public Property DevolverAreaSuperior As Integer '0:no , 1:devolver solo una vez, 2:devolver en cadena
    Public Property DevolverPosiciones As Boolean
    Public Property DevolverSubAreas As Integer '0:no , 1:devolver solo una vez, 2:devolver en cadena

    Sub New(ByVal _devolverJefatura As Boolean, ByVal _devolverProyectos As Boolean, ByVal _devolverAreaSuperior As Integer, ByVal _devolverPosiciones As Boolean, ByVal _devolverSubAreas As Integer)
        DevolverJefatura = _devolverJefatura
        DevolverProyectos = _devolverProyectos
        DevolverAreaSuperior = _devolverAreaSuperior
        DevolverPosiciones = _devolverPosiciones
        DevolverSubAreas = _devolverSubAreas
    End Sub

    'Class ArgAreaRecursivo
    '    Dim DevolverArea As Integer
    '    Dim ArgArea As ArgumentosArea
    'End Class


    ' argumentos para área superior
    ' 0: no
    ' 10000:Devuleve solo la siguiente superior y solo datos principales
    ' 20000:Devuelve el área superior en cadena.

    ' el uno ubicado en alguna posición devuelve el parametro que indica esa posición por ejemplo
    ' 11100: Devuelve el área superior siguiente con su correspondiente jefatura y los proyectos de esa área superior, pero no devuelve las posiciones ni las subareas del área superior. 
End Class


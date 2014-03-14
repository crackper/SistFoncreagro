Public Class Area
    Public Property IdArea As System.Nullable(Of Int32)
    Public Property CodArea As String
    Public Property Nombre As String
    Public Property TipoArea As String
    Public Property Dependencia As System.Nullable(Of Int32)
    Public Property IdDeclarante As System.Nullable(Of Int32)
    Public Property Nivel As System.Nullable(Of Int32)
    Public Property Administracion As Boolean
    Public Property ControlaProyectos As Boolean

    Public Property AreaSuperior As Area

    Public Property ListaPosiciones As List(Of Posicion)
    Public Property Jefatura As Posicion
    Public Property JefeDeArea As Personal 'esto no debe ser necesario ya que al obtener la posicion en jefatura podemos obtener a la persona que actualmente ocupa dicha posición

    Public Property ListaProyectos As List(Of Proyecto)
    Public Property ListaSubareas As List(Of Area)

    Public ReadOnly Property PosicionDeJefatura As String
        Get
            If Not Jefatura Is Nothing Then
                PosicionDeJefatura = Jefatura.NomCargo
            Else
                PosicionDeJefatura = "Posición no creada"
            End If
        End Get
    End Property

    Public ReadOnly Property NombreAreaSuperior As String
        Get
            If Not AreaSuperior Is Nothing Then
                NombreAreaSuperior = AreaSuperior.Nombre
            Else
                NombreAreaSuperior = ""
            End If
        End Get
    End Property

    Public ReadOnly Property NombreJefeArea As String
        Get
            NombreJefeArea = JefeDeArea.ApePaterno + " " + JefeDeArea.ApeMaterno + " " + JefeDeArea.Nombres
        End Get
    End Property

End Class

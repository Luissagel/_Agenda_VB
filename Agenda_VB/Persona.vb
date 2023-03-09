Public Class Persona
    Protected nombre As String
    Protected fechaNacimiento As DateTime?
    Public Property Nombr() As String
        Get
            Return nombre
        End Get
        Set(ByVal Value As String)
            nombre = Value
        End Set
    End Property
    Public Property FechaNacimient() As DateTime?
        Get
            Return fechaNacimiento
        End Get
        Set(ByVal Value As DateTime?)
            fechaNacimiento = Value
        End Set
    End Property
    Public ReadOnly Property Eda() As Integer
        Get
            Dim edad As Integer
            edad = (DateTime.Now.Year - fechaNacimiento.Value.Year)
            Return edad
        End Get
    End Property
    Private Function Persona()
        nombre = String.Empty
        fechaNacimiento = Nothing 'DateTime.MinValue
    End Function
    Private Function Persona(ByVal nombre As String, ByVal fechaNacimiento As DateTime?)
        Me.nombre = nombre
        Me.fechaNacimiento = fechaNacimiento
    End Function
    Public Overrides Function ToString() As String
        Return Nombr.ToUpper + " " + Eda
    End Function
End Class

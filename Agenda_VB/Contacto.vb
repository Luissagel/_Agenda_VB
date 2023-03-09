Public Class Contacto
    Inherits Persona
    Private telefono As String
	Public Property Telefon() As String
		Get
			Return telefono
		End Get
		Set(ByVal Value As String)
			telefono = Value.Replace(" ", "").Replace("-", "")
		End Set
	End Property
	Private correo As String
	Public Property Corre() As String
		Get
			Return correo
		End Get
		Set(ByVal value As String)
			correo = value
		End Set
	End Property
	Public Sub New()
		MyBase.New()
		telefono = String.Empty
	End Sub
	Public Sub New(ByVal nombre As String, ByVal fechaNacimiento As DateTime?, ByVal telefono As String)
		MyBase.New()
		Me.telefono = telefono
	End Sub
	Public Overrides Function ToString() As String
		Return MyBase.ToString() + " " + telefono + " " + correo
	End Function
End Class

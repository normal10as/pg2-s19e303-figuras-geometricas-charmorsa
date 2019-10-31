Public Class Circulo
    Inherits Figura
    Public Sub New(nombre As String, radio As Single)
        MyBase.New(nombre)
        Me.radio = radio
    End Sub
    Public Property radio As Single
    Public Overrides Function calcularArea() As Single
        ''Throw New NotImplementedException()
        Return Math.PI * Math.Pow(radio, 2)
    End Function
End Class

Public Class Rectangulo
    Inherits Figura
    Public Sub New(nombre As String, base As Single, altura As Single)
        MyBase.New(nombre)
        Me.base = base
        Me.altura = altura

    End Sub
    Public Property base As Single
    Public Property altura As Single

    Public Overrides Function calculArarea() As Single
        Return base * altura
    End Function
End Class

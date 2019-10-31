Public Class Cuadrado
    Inherits Figura
    Public Sub New(nombre As String, lado As Single)
        MyBase.New(nombre)
        Me.lado = lado
    End Sub
    Public Property lado As Single
    Public Overrides Function calcularArea() As Single
        Return (Math.Pow(lado, 2))
    End Function
End Class

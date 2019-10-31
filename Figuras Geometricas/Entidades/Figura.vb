Public MustInherit Class Figura
    Public Sub New(nombre As String)
        Me.nombre = nombre
    End Sub
    Private _nombre As String
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public MustOverride Function calcularArea() As Single
End Class

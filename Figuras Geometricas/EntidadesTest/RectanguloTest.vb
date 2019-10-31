Imports System
Imports Entidades
Module RectanguloTest
    Sub rectangulo()
        Dim rectangulo1 As Rectangulo
        rectangulo1 = New Rectangulo("Rectangulo", 5.4, 2.8)
        Console.WriteLine("Nombre: " & rectangulo1.nombre)
        Console.WriteLine("base: " & rectangulo1.base, "altura: " & rectangulo1.base)
        Console.WriteLine("Area rectangulo: " & rectangulo1.calculArarea())
    End Sub
End Module
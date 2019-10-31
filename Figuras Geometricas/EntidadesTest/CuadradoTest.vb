Imports System
Imports Entidades
Module CuadradoTest
    Sub cuadrado()
        Dim cuadrado1 As Cuadrado
        cuadrado1 = New Cuadrado("Cuadrado", 2.5)
        Console.WriteLine("Nombre: " & cuadrado1.nombre)
        Console.WriteLine("Lado: " & cuadrado1.lado)
        Console.WriteLine("Area cuadrado: " & cuadrado1.calcularArea())
    End Sub
End Module
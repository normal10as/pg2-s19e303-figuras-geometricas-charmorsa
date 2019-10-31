Imports System
Imports Entidades
Module TrianguloTest
    Sub triangulo()
        Dim triangulo1 As Triangulo
        triangulo1 = New Triangulo("Triangulo", 4.2, 5.5)
        Console.WriteLine("Nombre: " & triangulo1.nombre)
        Console.WriteLine("base: " & triangulo1.base, "altura: " & triangulo1.base)
        Console.WriteLine("Area del triangulo: " & triangulo1.calcularArea())

    End Sub
End Module
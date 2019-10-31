Imports System
Imports Entidades
Module CirculoTest
    Sub circulo()
        Dim circulo1 As Circulo
        circulo1 = New Circulo("Circulo", 1.8)
        Console.WriteLine("Nombre: " & circulo1.nombre)
        Console.WriteLine("radio: " & circulo1.radio)
        Console.WriteLine("Area circulo: " & circulo1.calcularArea())
    End Sub
End Module
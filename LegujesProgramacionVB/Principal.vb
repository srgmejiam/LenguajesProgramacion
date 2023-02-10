Module Principal
    Sub Main()
        Dim animales As List(Of Animal) = New List(Of Animal) From {
            New Perro With {.Nombre = "Fido"},
            New Gato With {.Nombre = "Mimi"},
            New Loro With {.Nombre = "Piolín"}
        }

        For Each animal In animales
            Console.WriteLine("El animal " & animal.Nombre & " hace:")
            animal.HacerRuido()
        Next
        Console.ReadLine()
    End Sub

End Module

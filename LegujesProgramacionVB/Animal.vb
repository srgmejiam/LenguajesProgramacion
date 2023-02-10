Public MustInherit Class Animal
    Public Property Nombre As String
    Public MustOverride Sub HacerRuido()
End Class

Public Class Perro
    Inherits Animal

    Public Overrides Sub HacerRuido()
        Console.WriteLine("Guau guau")
    End Sub
End Class

Public Class Gato
    Inherits Animal

    Public Overrides Sub HacerRuido()
        Console.WriteLine("Miau miau")
    End Sub
End Class

Public Class Loro
    Inherits Animal

    Public Overrides Sub HacerRuido()
        Console.WriteLine("Loro loro")
    End Sub
End Class


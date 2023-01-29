Imports System

Module Program
    Sub Main(args As String())
        Dim w As Integer
        Dim h, he As Integer
        Dim l, le As Integer
        Dim t, top As Integer

        ' Переменные для прямоугольника
        Console.WriteLine("Введите weight")
        w = Console.ReadLine()
        Console.WriteLine("Введите height")
        h = Console.ReadLine()
        Console.WriteLine("Введите координаты left")
        l = Console.ReadLine()
        Console.WriteLine("Введите координаты top")
        t = Console.ReadLine()

        ' Переменные для вертикальной линии
        Console.WriteLine("Введите height для вертикальной линии")
        he = Console.ReadLine()
        Console.WriteLine("Введите координаты left")
        le = Console.ReadLine()
        Console.WriteLine("Введите координаты top")
        top = Console.ReadLine()

        Console.SetCursorPosition(l, t)
        For j = 0 To h - 1
            For i As Integer = 0 To w - 1
                Console.Write("H")
            Next
            Console.SetCursorPosition(l, Console.GetCursorPosition().Top + 1)
        Next

        Console.SetCursorPosition(l, t)
        For j = 0 To he - 1
            For i As Integer = 0 To 1
                Console.Write("E")
            Next
            Console.SetCursorPosition(l, Console.GetCursorPosition().Left + 1)
        Next
    End Sub
End Module
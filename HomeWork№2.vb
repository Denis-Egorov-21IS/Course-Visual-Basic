Imports System

Module Program
    Sub Main(args As String())
        Dim num1, num2, result As Integer

        num1 = Console.ReadLine()
        num2 = Console.ReadLine()

        If num1 * num2 <= Int32.MaxValue Then
            result = num1 * num2
        Else
            Console.WriteLine("Переполнение памяти! Расчет выполнен для Num = {0}")
        End If

        Console.WriteLine("Num * Num = {0}", result)
    End Sub
End Module

Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter 5 numbers")
        Dim input(4) As Integer

        For i = 0 To 4
            input(i) = Console.ReadLine
        Next

        print(input)

        'Console.WriteLine("Enter 5 strings")

        'Dim strings(4) As String
        'For i = 0 To 4
        'Strings(i) = Console.ReadLine
        'Next

        'print(strings)

        If Not input(0) = 21 Then
            Console.WriteLine("Первый элемент это не 21")
        End If

    End Sub

    Sub print(list As Integer())
        For i = list.Length - 1 To 0 Step -1
            Console.WriteLine(list(i))
        Next
    End Sub

    Sub print(list As String())
        For i = list.Length - 1 To 0 Step -1
            Console.WriteLine(list(i))
        Next
    End Sub
End Module

Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter 5 numbers")
        Dim input(4) As Integer

        For i = 0 To 4
            input(i) = Console.ReadLine
        Next

        Dim num As Integer

        Console.WriteLine("Какое число искать")

        num = Console.ReadLine

        Console.WriteLine(find(input, num))

    End Sub

    Sub print(list As Integer())
        For i = 0 To list.Length - 1
            Console.WriteLine(list(i))
        Next
    End Sub
    Sub print(list As String())
        For i = 0 To list.Length - 1
            Console.WriteLine(list(i))
        Next
    End Sub

    Sub printReverse(list As Integer())
        For i = list.Length - 1 To 0 Step -1
            Console.WriteLine(list(i))
        Next
    End Sub

    Sub printReverse(list As String())
        For i = list.Length - 1 To 0 Step -1
            Console.WriteLine(list(i))
        Next
    End Sub

    Function find(list As Integer(), num As Integer) As Integer
        For i = 0 To list.Length - 1
            If list(i) = num Then
                find = i
                Exit Function
            End If
        Next
        find = -1
    End Function

End Module

Imports System
Imports System.Runtime.Intrinsics

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

        Dim min As Integer = input(0)
        Dim max As Integer = input(0)

        For i As Integer = 1 To input.Length - 1
            If (input(i) < min) Then
                min = input(i)
            End If

            If (input(i) > max) Then
                max = input(i)
            End If
        Next

        Console.WriteLine("Минимальное значение: {0}", min)
        Console.WriteLine("Максимальное значение: {0}", max)

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

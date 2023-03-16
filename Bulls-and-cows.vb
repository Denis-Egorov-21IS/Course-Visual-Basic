Imports System

Module Program
    Sub Main(args As String())
        Dim number As String
        Dim ver As String
        Randomize()
        number = Int((9000 * Rnd()) + 1000)

        Console.WriteLine(number)
        Console.WriteLine(CheckDublicates(number))

        Do
            ver = Console.ReadLine()
            For n As Integer = 0 To 3
                For i As Integer = 0 To 3
                    If ver.Chars(n) = number.Chars(i) Then
                        If i = n Then
                            Console.WriteLine("{0} цифра - бык", n + 1)
                        Else
                            Console.WriteLine("{0} цифра - корова", n + 1)
                        End If
                    End If
                Next
            Next
        Loop Until number = ver
    End Sub

    Function CheckDublicates(num As String) As Boolean
        CheckDublicates = False
        For m As Integer = 1 To 3
            For i As Integer = m To 3
                If num.Chars(m - 1) = num.Chars(i) Then
                    CheckDublicates = True
                    Exit Function
                End If
            Next
        Next
    End Function
End Module

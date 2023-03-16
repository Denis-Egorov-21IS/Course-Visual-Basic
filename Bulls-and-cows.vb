Imports System

Module Program
    Sub Main(args As String())
        Dim number As String = "1234"
        Dim ver As String

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
        For m As Integer = 0 To 2
            For i As Integer = m + 1 To 3
                If num.Chars(m) = num.Chars(i) Then
                    CheckDublicates = True
                End If
            Next
        Next
    End Function
End Module

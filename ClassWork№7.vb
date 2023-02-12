Imports System

Module Program
    Private brush As Char = "0"c
    Sub Main(args As String())
        Console.SetWindowSize(100, 50)
        Console.WriteLine("выберите задачу: 1 - HLine, 2 - VLine, 3 - FilRect, 4 - Rect")

        Dim N As Integer

        N = CInt(Console.ReadLine())

        Select Case N
            Case 1 : Hline(10, 10, 15)
            Case 2 : Vline(10, 10, 15)
            Case 3 : FilRect(5, 5, 10, 15)
            Case 4 : Rect(10, 10, 15, 20)
        End Select

        'If N = 1 Then
        '    Hline(10, 10, 15)
        'ElseIf N = 2 Then
        '    Vline(5, 5, 10)
        'ElseIf N = 3 Then
        '    FilRect(5, 5, 15, 10)
        'End If

        '    Hline(2, 2, 20)
        '    Vline(2, 2, 10)
        '    Hline(2, 10, 20)
        '    Vline(21, 2, 10)

        '    Console.WriteLine()

        Console.Read()
    End Sub

    Sub Rect(leftX As Byte, topY As Byte, width As Byte, heigth As Byte)

        Hline(leftX, topY, width)

        Vline(leftX, topY, heigth)

        Hline(leftX, topY + heigth - 1, width)

        Vline(leftX + width - 1, topY, heigth)

    End Sub

    'Построение n горизонтальных линий
    Sub Hline(leftX As Byte, topY As Byte, lent As Byte)
        Console.SetCursorPosition(leftX, topY)

        For i = 1 To lent

            Console.Write(brush)

        Next

    End Sub
    'Построение n вертикальных линий 
    Sub Vline(leftX As Byte, topY As Byte, width As Byte)

        Console.SetCursorPosition(leftX, topY)

        For i = 0 To width - 1
            Console.Write(brush)

            Console.SetCursorPosition(leftX, topY + i)
        Next
    End Sub
    Sub FilRect(leftX As Byte, topY As Byte, width As Byte, heigth As Byte)
        Console.SetCursorPosition(leftX, topY)

        For i As Byte = 1 To heigth
            Hline(leftX, topY + i, width)
        Next
    End Sub
End Module
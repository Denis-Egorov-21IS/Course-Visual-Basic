Imports System

Module Program
    Private brush As Char = "0"c
    Sub Main(args As String())
        Console.SetWindowSize(100, 50)

        Console.WriteLine("выберите задачу: 1 - HLine, 2 - VLine, 3 - FilRect, 4 - Rect, 5 - cells, 6 - ornament, 7 - rulers, 8 - ledder, 9 - chess")

        Dim N As Integer

        N = CInt(Console.ReadLine())

        Select Case N
            Case 1 : Hline(10, 10, 15)
            Case 2 : Vline(10, 10, 15)
            Case 3 : FilRect(5, 5, 10, 15)
            Case 4 : Rect(10, 10, 15, 20)
            Case 5
                Console.ForegroundColor = ConsoleColor.Red
                Console.BackgroundColor = ConsoleColor.Blue
                Console.SetCursorPosition(1, 1)
                Console.Clear()

                For i As Byte = 0 To 6
                    Hline(10, 5 * i + 8, 90)
                Next

                For i As Byte = 0 To 6
                    Vline(15 * i + 10, 8, 32)
                Next
            Case 6
                For j As Byte = 0 To 6
                    For i As Byte = 0 To 8
                        FilRect(10 * i + 10, 10 * j + 10, 4, 4)
                    Next
                Next
            Case 7
                For i As Byte = 0 To 8
                    Hline(5, 5 * i + 8, 90)
                Next
            Case 8 : Ledder(10, 10, 0, 0)
            Case 9 : ChessBoard(7, 10, 10)

        End Select

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

        For i As Byte = 0 To heigth - 1
            Hline(leftX, topY + i, width)
        Next
    End Sub

    Sub Ledder(leftX As Byte, topY As Byte, stepX As Byte, stepY As Byte)
        Console.SetCursorPosition(leftX, topY)
        For i = 1 To 10
            For j = 1 To i
                Console.Write(brush)
                Console.SetCursorPosition(Console.CursorLeft + stepX, Console.CursorTop)
            Next j
            Console.WriteLine()
            Console.SetCursorPosition(leftX, Console.CursorTop + stepY)
        Next i
    End Sub

    Sub ChessBoard(size As Byte, leftX As Byte, topY As Byte)
        For i = 0 To size
            For j = 0 To size
                If (i + j) Mod 2 = 0 Then
                    Console.ForegroundColor = ConsoleColor.Black
                Else
                    Console.ForegroundColor = ConsoleColor.White
                End If
                FilRect(leftX + j * 3, topY + i * 2, 3, 2)
            Next
        Next
    End Sub
End Module
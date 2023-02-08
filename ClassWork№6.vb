Imports System

Module Program
    Private brush As Char = "0"c
    Sub Main(args As String())
        Console.SetWindowSize(100, 50)

        HLine(2, 2, 20)
        HLine(10, 20, 20)
        FilRect(10, 30, 20, 20)

        Console.WriteLine()
    End Sub

    Sub HLine(leftX As Byte, topY As Byte, length As Byte)
        Console.SetCursorPosition(leftX, topY)
        For i = 1 To length
            Console.Write(brush)
        Next
        Console.SetCursorPosition(leftX, Console.GetCursorPosition().Top + 2)
    End Sub

    Sub TopVLine(leftX As Byte, topY As Byte)
        Console.SetCursorPosition(leftX, topY)
        For j = 1 To 4
            For i = 1 To 7
                Console.Write(brush)
                Console.SetCursorPosition(Console.GetCursorPosition().Left + 3, topY)
            Next
        Next
    End Sub

    Sub FilRect(leftX As Byte, topY As Byte, width As Byte, height As Byte)
        Console.SetCursorPosition(leftX, topY)
        For j = 0 To height - 1
            HLine(leftX, topY + j, width)
        Next
    End Sub
End Module
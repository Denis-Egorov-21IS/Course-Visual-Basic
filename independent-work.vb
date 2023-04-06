Imports System

Module Program
    Sub Main(args As String())
        Dim productName As String
        Dim clockSpeed As Integer
        Dim price As Double


        While True

            Console.WriteLine("Введите производителя процессора и его модель")
            productName = Console.ReadLine()

            If productName.ToLower() = "exit" Then
                Exit While
            End If

            Console.WriteLine("Введите тактовую частоту процессора")
            clockSpeed = Console.ReadLine()
            Console.WriteLine("Введите цену")
            price = Console.ReadLine()

            Console.WriteLine("Наименование, тактовая частота: {0}, {1} GHz", productName, clockSpeed)
            Console.WriteLine("Цена: {0} руб", FormatNumber(price, 2))
        End While
    End Sub
End Module
Imports System

Module Program
    Sub Main(args As String())
        Dim C As Integer
        Dim Pr As Integer = 1
        Do
            Console.Write("������� ���������:")
            C = Console.ReadLine()
            If C < Int32.MaxValue / Pr Then
                Pr = C * Pr
            Else
                Console.WriteLine("������������ ������")
                Exit Do
            End If

        Loop Until C = 1
        Console.WriteLine("������������ = {0}", Pr)
    End Sub
End Module

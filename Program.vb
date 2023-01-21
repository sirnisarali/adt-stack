Option Explicit On
Module Program
    Dim TopPointer As Integer
    Dim BasePointer As Integer = 0
    Dim stack() As String = {0, 0, 0, 0, 0}
    Dim stackfull = 5
    Dim MenuChoice As Integer = 0
    Sub Main(args As String())
        TopPointer = -1
        Do While MenuChoice <> 4
            Console.Clear()
            Console.WriteLine(" (1) to push to Stack")
            Console.WriteLine(" (2) to pop to Stack")
            Console.WriteLine(" (3) to print the stack")
            Console.WriteLine(" (4) to Exit")

            MenuChoice = Console.ReadLine

            Select Case MenuChoice
                Case 1 : Push()
                Case 2 : Pop()
                Case 3 : Print()
                Case 4
                Case Else
                    Console.WriteLine("Invalid choice. please try again")
            End Select
        Loop
        Console.ReadKey()

    End Sub

    Sub Pop()
        If TopPointer = BasePointer - 1 Then
            Console.WriteLine("Underflow")
            Console.ReadKey()
            Exit Sub
        Else
            Console.WriteLine(stack(TopPointer))
            TopPointer = TopPointer - 1
        End If

    End Sub

    Sub Push()
        Dim newVal As String
        Console.WriteLine("Enter new value")
        newVal = Console.ReadLine
        If TopPointer < stackfull - 1 Then
            TopPointer = TopPointer + 1
            Stack(TopPointer) = newVal
        Else
            Console.WriteLine("Over flow")
            Console.ReadKey()
            Exit Sub
        End If
    End Sub

    Sub Print()
        For i = 0 To TopPointer
            Console.WriteLine("-->" & Stack(i))
        Next
        Console.ReadKey()

    End Sub
End Module

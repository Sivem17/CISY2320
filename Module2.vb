Module Module1

    Sub Main()

        Dim marks As Integer = 75
        Dim grade As String

        Console.WriteLine(marks)

        Select Case marks
            Case 0 To 49
                grade = "F"
                Console.WriteLine(grade)
            Case 50 To 59
                grade = "D"
                Console.WriteLine(grade)
            Case 60 To 62
                grade = "C-*"
                Console.WriteLine(grade)
            Case 63 To 66
                grade = "C"
                Console.WriteLine(grade)
            Case 67 To 69
                grade = "C+"
                Console.WriteLine(grade)
            Case 70 To 72
                grade = "B-"
                Console.WriteLine(grade)
            Case 73 To 76
                grade = "B"
                Console.WriteLine(grade)
            Case 77 To 79
                grade = "B+"
                Console.WriteLine(grade)
            Case 80 To 84
                grade = "A-"
                Console.WriteLine(grade)
            Case 85 To 89
                grade = "A"
                Console.WriteLine(grade)
            Case 90 To 100
                grade = "A+"
                Console.WriteLine(grade)
        End Select

    End Sub

End Module

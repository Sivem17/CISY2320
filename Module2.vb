Module Module1

    Sub Main()
        Dim marks As Integer
        Dim grade As String
        marks = 88
        Console.WriteLine(marks)
        If (marks >= 90) And (marks <= 100) Then
            grade = "A+"
            Console.WriteLine(grade)
        ElseIf (marks >= 85) And (marks <= 89) Then
            grade = "A"
            Console.WriteLine(grade)
        ElseIf (marks >= 80) And (marks <= 84) Then
            grade = "A-"
            Console.WriteLine(grade)
        ElseIf (marks >= 77) And (marks <= 79) Then
            grade = "B+"
            Console.WriteLine(grade)
        ElseIf (marks >= 73) And (marks <= 76) Then
            grade = "B"
            Console.WriteLine(grade)
        ElseIf (marks >= 70) And (marks <= 72) Then
            grade = "B-"
            Console.WriteLine(grade)
        ElseIf (marks >= 67) And (marks <= 69) Then
            grade = "C+"
            Console.WriteLine(grade)
        ElseIf (marks >= 63) And (marks <= 66) Then
            grade = "C"
            Console.WriteLine(grade)
        ElseIf (marks >= 60) And (marks <= 62) Then
            grade = "C-"
            Console.WriteLine(grade)
        ElseIf (marks >= 50) And (marks <= 59) Then
            grade = "D"
            Console.WriteLine(grade)
        ElseIf (marks >= 0) And (marks <= 49) Then
            grade = "F"
            Console.WriteLine(grade)
        End If




    End Sub

End Module

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

Module Module1
    Sub main()
        Dim year As Integer
        year = 2019
        While (year <= 2043)
            If year Mod 100 = 0 AndAlso year Mod 400 = 0 Then
                Console.WriteLine(year)
            ElseIf year Mod 4 = 0 Then
                Console.WriteLine(year)
            End If
            year += 1
        End While
    End Sub
End Module
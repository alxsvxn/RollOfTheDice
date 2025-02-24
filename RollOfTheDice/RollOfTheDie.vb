Module RollOfTheDie

    Sub Main()
        Dim rolls(11) As Integer
        Dim rand As New Random()

        For i As Integer = 1 To 1000
            Dim die1 As Integer = RandomNumberBetween(1, 6)
            Dim die2 As Integer = RandomNumberBetween(1, 6)
            Dim sum As Integer = die1 + die2
            rolls(sum - 2) += 1 'since the lowest possible number is 2 this that into account
        Next


        Console.WriteLine("Roll Results")
        Console.WriteLine(StrDup(91, "-"))
        Console.Write("Dice Value:   ")
        For i As Integer = 2 To 12
            Console.Write(i.ToString().PadLeft(4) & "  |")
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(91, "-"))
        Console.Write("Times Rolled: ")

        For i As Integer = 0 To 10
            Console.Write(rolls(i).ToString().PadLeft(4) & "  |")
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(91, "-"))
    End Sub

    Function RandomNumberBetween(min As Integer, max As Integer) As Integer
        Dim temp As Single
        Randomize()

        temp = Rnd()
        temp *= max - min
        temp += min
        Return CInt(temp)

    End Function

End Module

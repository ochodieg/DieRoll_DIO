'D. Ivan Ochoa
'RCET0265
'Fall 2020
'Roll of the dice
'https://github.com/ochodieg/DieRoll_DIO
Option Strict Off
Option Explicit On
Module DieRoll_DIO
    Sub Main()
        Dim dieRoll As Integer
        Dim row As Integer
        Dim outPut(12) As Integer
        'Dim disPlay As String
        Console.SetWindowSize(125, 10)
        Console.WriteLine("Press enter to roll a pair of dice or press Q to quit")
        If Console.ReadKey().Key = ConsoleKey.Q Then
            Exit Sub
        End If
        Do
            Console.WriteLine("-2-------3--------4-------5-------6-------7-------8-------9-------1------11------12")
            For i = 1 To 1000
                dieRoll = GetRandomNumber(1, 11)
                outPut(dieRoll) += 1
            Next
            'For i = 2 To 12
            'disPlay = String.Format("{0, 10}", i) & "/"
            'Console.Write(disPlay)
            'Next
            'Console.WriteLine()
            'Console.Write(StrDup(250, "*"))
            'Console.WriteLine()
            'For i = 0 To 10
            '    disPlay = String.Format("{0, 10}", outPut(i)) & "/"
            '    Console.Write(disPlay)
            For i = 2 To 12
                'Console.Write(StrDup(250, "*"))
                Console.Write("|" & outPut(i) & "|" & vbTab)
            Next
            Console.WriteLine(vbNewLine)
            Console.WriteLine("Press enter to roll the dice again or press Q to quit")
            If Console.ReadKey().Key = ConsoleKey.Q Then
                Exit Sub
            End If
            Erase outPut
            ReDim outPut(12)
        Loop
    End Sub
    Function GetRandomNumber(ByVal min As Integer, ByVal max As Integer) As Integer
        Dim number As Single
        Randomize()
        number = CInt(Int(12 * Rnd()) + 1)
        number = ((max - min + 1) * Rnd()) + min
        Return CInt((number))
    End Function
End Module

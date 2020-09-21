

Option Strict Off

Option Explicit On


Module DieRoll_DIO

    Sub Main()


        Dim disPlay As String

        Dim dieRoll As Integer

        Dim outPut(12) As Integer

        Console.SetWindowSize(125, 10
                              )
        'command allows me to set the resolution of the console display. It had to be 
        'adjusted to fit seperation markers "*" and "/". Contribution by Luis Torres.


        Randomize()

        Do

            Console.WriteLine("Press enter for a random number or type capital Q to quit")

            If Console.ReadLine = "Q" Then Exit Sub


            For i = 1 To 1000

                dieRoll = CInt(GetdieRoll(1, 6))
                outPut(dieRoll - 2) += 1


            Next


            For i = 2 To 12

                disPlay = String.Format("{0, 10}", i) & "/"
                Console.Write(disPlay)


            Next

            Console.WriteLine()

            Console.Write(StrDup(250, "*"))

            Console.WriteLine()


            For i = 0 To 10

                disPlay = String.Format("{0, 10}", outPut(i)) & "/"
                Console.Write(disPlay)


            Next

            Console.ReadLine()

            Erase outPut

            ReDim outPut(12)

            Console.Clear()
        Loop

    End Sub


    Function GetdieRoll(ByVal minimum As Single,
        ByVal maximum As Single) As Single

        Dim rolleyBoye1 As Single

        Dim rolleyBoye2 As Single

        Dim dieSquad As Single

        Do
            rolleyBoye1 = (maximum * Rnd(
                ) + 0.3)

            rolleyBoye2 = (maximum * Rnd(
                ) + 0.7)

        Loop While rolleyBoye1 <
            minimum - 0.5 Or rolleyBoye1 >= maximum + 0.5 Or rolleyBoye2 <
            minimum - 0.5 Or rolleyBoye2 >= maximum + 0.5

        dieSquad = (CInt(rolleyBoye1
            ) + CInt(rolleyBoye2)
            )

        Return CInt(dieSquad
            )

        'this function completes the randomize feature. Contribution by Tim Rossiter

    End Function


End Module
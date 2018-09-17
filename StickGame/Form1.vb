Public Class frmStickGame
    ' Declare variables
    Dim sticksRemaining As Integer
    Dim sticks As String

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim message As String

        message = "Please choose how many matchsticks (between 5 and 50) to place on the pile"
        sticks = "||||||||||||||||||||||||||||||||||||||||||||||||||"

        ' We will use substring to display proper number of sticks

        sticksRemaining = CInt(InputBox(message))
        txtPileStatus.Text = sticks.Substring(0, sticksRemaining)

        ' Computer has to decide who goes first
        If sticksRemaining Mod 4 = 1 Then
            MessageBox.Show("Please start the game")
        Else
            MessageBox.Show("Computer starts the game")
        End If

    End Sub

    Private Sub ComputerTurn()
        Dim computerPick As Integer
        Dim sticksRemMod4 As Integer = sticksRemaining Mod 4

        Select Case sticksRemMod4
            Case 0
                computerPick = 3
            Case 2
                computerPick = 1
            Case 3
                computerPick = 2
        End Select
    End Sub


End Class

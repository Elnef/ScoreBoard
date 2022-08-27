Public Class frmMain

    Private Sub BtnInitProcess_Click(sender As Object, e As EventArgs) Handles BtnInitProcess.Click

        ' init matches list
        If ReadInitMatchList() Then
            ' Matches scheduled added correctly
            ShowMatchesList()
        Else
            ' Error adding matches scheduled
            Console.WriteLine("Matches information is incorrect")
        End If


    End Sub

    Private Sub BtnAddMatch_Click(sender As Object, e As EventArgs) Handles btnAddMatch.Click

        Dim newMatch As ScoreBoardManager.Match



    End Sub

    Private Sub ShowMatchesList()

        ' Create the arrays of labels
        Dim labelHome() As Label = {Label1, Label2, Label3, Label4, Label5}
        Dim labelAway() As Label = {Label6, Label7, Label8, Label9, Label10}

        Dim index As Integer = 0

        For Each score In scoreBoard
            labelHome(index).Text = score.MatchData.HomeTeam
            labelAway(index).Text = score.MatchData.AwayTeam
            index = index + 1
        Next

        txt1.Text = scoreBoard(0).MatchData.HomeTeam


    End Sub


End Class

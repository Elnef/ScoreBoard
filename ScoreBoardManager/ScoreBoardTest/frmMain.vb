Imports ScoreBoardManager
Public Class frmMain

    Private Sub BtnInitProcess_Click(sender As Object, e As EventArgs) Handles BtnInitProcess.Click

        ' init matches list
        InitMatchListFromMathScheduled()
        ' Matches scheduled added correctly
        ShowMatchesList()
        ShowFinishedMatchesList()

    End Sub

    Private Sub btnGenEvent_Click(sender As Object, e As EventArgs) Handles btnGenEvent.Click

        SendEvent()
        UpdateFinalScoreBoard()
        ShowMatchesList()
        ShowFinishedMatchesList()

    End Sub

    Private Sub ShowMatchesList()

        ' Create the arrays of labels and textbox
        Dim labelHome() As Label = {Label1, Label2, Label3, Label4, Label5}
        Dim labelAway() As Label = {Label6, Label7, Label8, Label9, Label10}
        Dim textHome() As TextBox = {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5}
        Dim textAway() As TextBox = {TextBox6, TextBox7, TextBox8, TextBox9, TextBox10}

        Dim index As Integer = 0

        ' For each match update the Live score frame
        For Each score In scoreBoard
            labelHome(index).Text = score.MatchData.HomeTeam
            labelAway(index).Text = score.MatchData.AwayTeam

            labelHome(index).Visible = True
            labelAway(index).Visible = True
            textHome(index).Visible = True
            textAway(index).Visible = True
            If score.IsStarted = False Then
                textHome(index).Text = score.MatchData.DateMatch.ToString("ddd")
                textAway(index).Text = score.MatchData.DateMatch.ToString("HH:mm")
                textHome(index).BackColor = Color.White
                textAway(index).BackColor = Color.White
            Else
                textHome(index).Text = score.HomeScore
                textAway(index).Text = score.AwayScore
            End If
            If score.IsFinished = True Then
                textHome(index).BackColor = Color.Green
                textAway(index).BackColor = Color.Green
            End If
            index += 1
        Next

    End Sub

    Private Sub ShowFinishedMatchesList()

        ' Create the arrays of labels and textbox
        Dim labelHome() As Label = {Label11, Label12, Label13, Label14, Label15}
        Dim labelAway() As Label = {Label16, Label17, Label18, Label19, Label20}
        Dim textHome() As TextBox = {TextBox11, TextBox12, TextBox13, TextBox14, TextBox15}
        Dim textAway() As TextBox = {TextBox16, TextBox17, TextBox18, TextBox19, TextBox20}

        Dim index As Integer = 0
        Dim indexToVisibility As Integer
        Dim matchesTotalNumber As Integer = scoreBoard.Count

        ' For each match update the Live score frame
        For Each score In finalScoreBoard
            labelHome(index).Text = score.MatchData.HomeTeam
            labelAway(index).Text = score.MatchData.AwayTeam
            textHome(index).Text = score.HomeScore
            textAway(index).Text = score.AwayScore
            labelHome(index).Visible = True
            labelAway(index).Visible = True
            textHome(index).Visible = True
            textAway(index).Visible = True
            index += 1
        Next

        If index < matchesTotalNumber Then
            For indexToVisibility = index To matchesTotalNumber - 1
                labelHome(indexToVisibility).Visible = False
                labelAway(indexToVisibility).Visible = False
                textHome(indexToVisibility).Visible = False
                textAway(indexToVisibility).Visible = False
            Next
        End If

    End Sub



End Class

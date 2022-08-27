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
            textHome(index).Text = score.HomeScore
            textAway(index).Text = score.AwayScore
            index += 1
        Next

    End Sub


End Class

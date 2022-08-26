Public Class frmMain
    Private Sub btAddMatch_Click(sender As Object, e As EventArgs) Handles btnAddMatch.Click

        Dim newMatch As ScoreBoardManager.match

        newMatch = ScoreBoardManager.scoreManager.InitMacth(Now, "Betis", "Sevilla")

        txtMatch1.Text = newMatch.homeTeam & " - " & newMatch.awayTeam

    End Sub
End Class

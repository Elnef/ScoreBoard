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
        txtMatch1.Text = scoreBoard.ToString

    End Sub


End Class

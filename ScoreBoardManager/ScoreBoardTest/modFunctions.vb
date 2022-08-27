Module modFunctions

    ' This is our global scoreBoard
    Public scoreBoard As New List(Of ScoreBoardManager.Match)

    ' 
    Public matchesScheduled As New List(Of ScoreBoardManager.MatchScheduled) From
        {
            New ScoreBoardManager.MatchScheduled With {.DateMatch = "2022-08-26T15:00:00Z", .HomeTeam = "Mexico", .AwayTeam = "Canada"},
            New ScoreBoardManager.MatchScheduled With {.DateMatch = "2022-08-26T16:00:00Z", .HomeTeam = "Spain", .AwayTeam = "Brazil"},
            New ScoreBoardManager.MatchScheduled With {.DateMatch = "2022-08-26T17:00:00Z", .HomeTeam = "Germany", .AwayTeam = "France"},
            New ScoreBoardManager.MatchScheduled With {.DateMatch = "2022-08-26T18:00:00Z", .HomeTeam = "Uruguay", .AwayTeam = "Italy"},
            New ScoreBoardManager.MatchScheduled With {.DateMatch = "2022-08-26T19:00:00Z", .HomeTeam = "Argentina", .AwayTeam = "Australia"}
        }

    Public Function ReadInitMatchList() As Boolean

        Dim match As ScoreBoardManager.Match
        Dim initCompleted = False
        'Dim scoreBoardTemp(matchesScheduled.Count) As ScoreBoardManager.Match
        'Dim scoreBoardTemp As New List(Of ScoreBoardManager.Match)

        Try
            If matchesScheduled.Count > 0 Then
                For Each matchScheduled In matchesScheduled
                    match = ScoreBoardManager.scoreManager.InitMacth(matchScheduled)
                    scoreBoard.Add(match)
                Next
                'scoreBoard = scoreBoardTemp
                initCompleted = True
            End If
        Catch ex As Exception
            Console.WriteLine("ReadInitMatchList Error: " & ex.Message)

        End Try

        Return initCompleted

    End Function

End Module

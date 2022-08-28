Module modFunctions

    ' This is our global scoreBoard
    Public scoreBoard As New List(Of ScoreBoardManager.Match)

    ' This is a simulated matches list
    Public matchesScheduled As New List(Of ScoreBoardManager.MatchScheduled) From
        {
            New ScoreBoardManager.MatchScheduled With {.DateMatch = "2022-08-26T15:00:00Z", .HomeTeam = "Mexico", .AwayTeam = "Canada"},
            New ScoreBoardManager.MatchScheduled With {.DateMatch = "2022-08-26T16:00:00Z", .HomeTeam = "Spain", .AwayTeam = "Brazil"},
            New ScoreBoardManager.MatchScheduled With {.DateMatch = "2022-08-26T17:00:00Z", .HomeTeam = "Germany", .AwayTeam = "France"},
            New ScoreBoardManager.MatchScheduled With {.DateMatch = "2022-08-26T18:00:00Z", .HomeTeam = "Uruguay", .AwayTeam = "Italy"},
            New ScoreBoardManager.MatchScheduled With {.DateMatch = "2022-08-26T19:00:00Z", .HomeTeam = "Argentina", .AwayTeam = "Australia"}
        }

    Public Sub InitMatchListFromMathScheduled()

        scoreBoard = ScoreBoardManager.ScoreBoardHandler.InitMatchList(matchesScheduled)

    End Sub

End Module

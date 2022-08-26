Module modFunctions

    Public matchesScheduled As New List(Of ScoreBoardManager.matchScheduled) From
        {
            New ScoreBoardManager.matchScheduled With {.dateMatch = "2022-08-26T15:00:00Z", .homeTeam = "Mexico", .awayTeam = "Canada"},
            New ScoreBoardManager.matchScheduled With {.dateMatch = "2022-08-26T16:00:00Z", .homeTeam = "Spain", .awayTeam = "Brazil"},
            New ScoreBoardManager.matchScheduled With {.dateMatch = "2022-08-26T17:00:00Z", .homeTeam = "Germany", .awayTeam = "France"},
            New ScoreBoardManager.matchScheduled With {.dateMatch = "2022-08-26T18:00:00Z", .homeTeam = "Uruguay", .awayTeam = "Italy"},
            New ScoreBoardManager.matchScheduled With {.dateMatch = "2022-08-26T19:00:00Z", .homeTeam = "Argentina", .awayTeam = "Australia"}
        }

    Public Function readInitMatchList() As List(Of ScoreBoardManager.match)

        Dim scoreBoard As List(Of ScoreBoardManager.match)
        Dim match As ScoreBoardManager.match

        Try
            If matchesScheduled.Count > 0 Then
                For Each matchScheduled In matchesScheduled
                    match = ScoreBoardManager.scoreManager.InitMacth(matchScheduled)
                    scoreBoard.Add(match)
                Next
            End If

        Catch ex As Exception


        End Try

        Return scoreBoard


    End Function

End Module

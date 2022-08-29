Imports ScoreBoardManager
Module modFunctions

    ' This is our global scoreBoard
    Public scoreBoard As New List(Of Match)

    ' This is a simulated matches list
    Public matchesScheduled As New List(Of MatchScheduled) From
        {
            New MatchScheduled With {.DateMatch = "2022-08-26T15:00:00Z", .HomeTeam = "Mexico", .AwayTeam = "Canada"},
            New MatchScheduled With {.DateMatch = "2022-08-26T16:00:00Z", .HomeTeam = "Spain", .AwayTeam = "Brazil"},
            New MatchScheduled With {.DateMatch = "2022-08-26T17:00:00Z", .HomeTeam = "Germany", .AwayTeam = "France"},
            New MatchScheduled With {.DateMatch = "2022-08-26T18:00:00Z", .HomeTeam = "Uruguay", .AwayTeam = "Italy"},
            New MatchScheduled With {.DateMatch = "2022-08-26T19:00:00Z", .HomeTeam = "Argentina", .AwayTeam = "Australia"}
        }

    Public eventIndex As Integer

    Public matchEventList As New List(Of MatchEvent) From
        {
            New MatchEvent With {.EventID = 1, .Team = "Mexico"},
            New MatchEvent With {.EventID = 3, .Team = "Canada"},
            New MatchEvent With {.EventID = 3, .Team = "Canada"},
            New MatchEvent With {.EventID = 1, .Team = "Spain"},
            New MatchEvent With {.EventID = 3, .Team = "Spain"},
            New MatchEvent With {.EventID = 3, .Team = "Spain"},
            New MatchEvent With {.EventID = 3, .Team = "Canada"},
            New MatchEvent With {.EventID = 3, .Team = "Spain"},
            New MatchEvent With {.EventID = 1, .Team = "Germany"},
            New MatchEvent With {.EventID = 3, .Team = "Brazil"},
            New MatchEvent With {.EventID = 3, .Team = "France"},
            New MatchEvent With {.EventID = 3, .Team = "Canada"},
            New MatchEvent With {.EventID = 3, .Team = "Sevilla"},
            New MatchEvent With {.EventID = 3, .Team = "Brazil"},
            New MatchEvent With {.EventID = 3, .Team = "Spain"},
            New MatchEvent With {.EventID = 3, .Team = "Germany"},
            New MatchEvent With {.EventID = 3, .Team = "Canada"},
            New MatchEvent With {.EventID = 2, .Team = "Canada"},
            New MatchEvent With {.EventID = 255, .Team = "Canada"},
            New MatchEvent With {.EventID = 3, .Team = "Spain"},
            New MatchEvent With {.EventID = 3, .Team = "Spain"},
            New MatchEvent With {.EventID = 3, .Team = "Spain"},
            New MatchEvent With {.EventID = 3, .Team = "France"},
            New MatchEvent With {.EventID = 3, .Team = "Spain"},
            New MatchEvent With {.EventID = 1, .Team = "Uruguay"},
            New MatchEvent With {.EventID = 3, .Team = "Spain"},
            New MatchEvent With {.EventID = 3, .Team = "Betis"},
            New MatchEvent With {.EventID = 3, .Team = "Spain"},
            New MatchEvent With {.EventID = 2, .Team = "Spain"},
            New MatchEvent With {.EventID = 3, .Team = "Uruguay"},
            New MatchEvent With {.EventID = 3, .Team = "Uruguay"},
            New MatchEvent With {.EventID = 3, .Team = "Uruguay"},
            New MatchEvent With {.EventID = 3, .Team = "Italy"},
            New MatchEvent With {.EventID = 3, .Team = "Uruguay"},
            New MatchEvent With {.EventID = 3, .Team = "Uruguay"},
            New MatchEvent With {.EventID = 3, .Team = "Germany"},
            New MatchEvent With {.EventID = 3, .Team = "Italy"},
            New MatchEvent With {.EventID = 3, .Team = "Italy"},
            New MatchEvent With {.EventID = 2, .Team = "Germany"},
            New MatchEvent With {.EventID = 3, .Team = "Italy"},
            New MatchEvent With {.EventID = 1, .Team = "Argentina"},
            New MatchEvent With {.EventID = 3, .Team = "Italy"},
            New MatchEvent With {.EventID = 3, .Team = "Argentina"},
            New MatchEvent With {.EventID = 3, .Team = "Italy"},
            New MatchEvent With {.EventID = 3, .Team = "Argentina"},
            New MatchEvent With {.EventID = 3, .Team = "Uruguay"},
            New MatchEvent With {.EventID = 2, .Team = "Uruguay"},
            New MatchEvent With {.EventID = 3, .Team = "Australia"},
            New MatchEvent With {.EventID = 2, .Team = "Argentina"},
            New MatchEvent With {.EventID = 2, .Team = "Argentina"}
        }

    ' Init score board from scheduled matches list
    Public Sub InitMatchListFromMathScheduled()

        scoreBoard = ScoreBoardHandler.InitMatchList(matchesScheduled)
        ' Reset event index
        eventIndex = 0

    End Sub

    ' Send event from event list to score board library
    Public Sub SendEvent()

        If (eventIndex < matchEventList.Count) Then
            scoreBoard = ScoreBoardHandler.EventHandler(matchEventList(eventIndex), scoreBoard)
            eventIndex += 1
        Else
            MsgBox("No more available events", MessageBoxIcon.Information)
        End If

    End Sub

End Module

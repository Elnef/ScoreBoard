Public Class ScoreBoardHandler

    'Create a new Match from a MatchSchedduled
    Public Shared Function InitMacth(matchAux As MatchScheduled) As Match

        Dim newMatch As New Match

        Try
            With newMatch
                .MatchData = matchAux
                .MinuteMatch = 0
                .HomeScore = 0
                .AwayScore = 0
                .IsFinished = False
                .IsValid = True
            End With

        Catch ex As Exception
            With newMatch
                .IsValid = False
            End With

        End Try

        Return newMatch

    End Function

    Public Shared Function InitMatchList(matchesScheduledList As List(Of MatchScheduled)) As List(Of Match)

        Dim match As ScoreBoardManager.Match
        Dim scoreBoardTemp As New List(Of Match)

        Try
            If matchesScheduledList.Count > 0 Then
                For Each matchScheduled In matchesScheduledList
                    match = InitMacth(matchScheduled)
                    scoreBoardTemp.Add(match)
                Next
            End If
        Catch ex As Exception
            Console.WriteLine("InitMatchList Error: " & ex.Message)

        End Try

        Return scoreBoardTemp

    End Function

End Class

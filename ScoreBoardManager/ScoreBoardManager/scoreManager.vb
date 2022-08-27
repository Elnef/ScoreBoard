Public Class ScoreManager

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


End Class

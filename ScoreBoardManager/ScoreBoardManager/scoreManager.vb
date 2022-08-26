Public Class scoreManager

    Public Shared Function InitMacth(matchAux As matchScheduled) As match

        Dim newMatch As New match

        Try
            With newMatch
                .matchData = matchAux
                .minuteMatch = 0
                .homeScore = 0
                .awayScore = 0
                .isFinished = False
                .isValid = True
            End With

        Catch ex As Exception
            With newMatch
                .isValid = False
            End With

        End Try

        Return newMatch

    End Function


End Class

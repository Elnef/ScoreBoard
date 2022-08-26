Public Class scoreManager

    Public Function InitMacth(dateTime As DateTime,
                              homeTeam As String,
                              awayTeam As String
                              ) As match

        Dim newMatch As New match

        Try
            With newMatch
                .dateMatch = dateTime
                .homeTeam = homeTeam
                .awayTeam = awayTeam
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

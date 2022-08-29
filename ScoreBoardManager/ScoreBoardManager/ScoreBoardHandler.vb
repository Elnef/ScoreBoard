Public Class ScoreBoardHandler

    'Create a new Match from a MatchSchedduled
    Public Shared Function InitMacth(matchAux As MatchScheduled) As Match

        Dim newMatch As New Match

        Try
            With newMatch
                .MatchData = matchAux
                .HomeScore = 0
                .AwayScore = 0
                .IsFinished = False
                .IsValid = True
            End With

        Catch ex As Exception
            With newMatch
                .IsValid = False
            End With
            MsgBox("Error InitMacth Function: " & ex.Message)
            My.Application.Log.WriteEntry("Error InitMacth Function: " & ex.Message)
        End Try

        Return newMatch

    End Function

    ' Create una new matches list from scheduled matches list
    Public Shared Function InitMatchList(matchesScheduledList As List(Of MatchScheduled)) As List(Of Match)

        Dim match As Match
        Dim scoreBoardTemp As New List(Of Match)

        Try
            If matchesScheduledList.Count > 0 Then
                For Each matchScheduled In matchesScheduledList
                    match = InitMacth(matchScheduled)
                    scoreBoardTemp.Add(match)
                Next
            End If
        Catch ex As Exception
            MsgBox("InitMatchList Function: " & ex.Message)
            My.Application.Log.WriteEntry("InitMatchList Function: " & ex.Message)
        End Try

        Return scoreBoardTemp

    End Function

    ' Handl a event received and modify score board 
    Public Shared Function EventHandler(eventReceived As MatchEvent, scoreBoard As List(Of Match)) As List(Of Match)

        Dim index As Integer

        Try
            With eventReceived
                index = scoreBoard.FindIndex(Function(board) board.MatchData.HomeTeam = .Team Or board.MatchData.AwayTeam = .Team)

                If (index <> -1) Then
                    Select Case .EventID
                        Case 1
                            ' Starting match
                            scoreBoard(index).IsStarted = True
                        Case 2
                            ' Match has finished
                            scoreBoard(index).IsFinished = True
                        Case 3
                            ' Goal
                            If .Team = scoreBoard(index).MatchData.HomeTeam Then
                                ' Home team goal
                                scoreBoard(index).HomeScore += 1
                            Else
                                scoreBoard(index).AwayScore += 1
                            End If
                        Case Else
                            ' EventId invalid. Return original scoreBoard without changes
                            MsgBox("EventId: " & .EventID & " invalid. Event received discarded")
                            My.Application.Log.WriteEntry("EventId: " & .EventID & " invalid. Event received discarded")

                    End Select
                Else
                    ' index = -1 indicate that eventReceived.Team is not present in our score board then
                    ' event invalid. Return original scoreBoard without changes
                    MsgBox("Team: " & .Team & " invalid. Event received discarded")
                    My.Application.Log.WriteEntry("Team: " & .Team & " invalid. Event received discarded")

                End If

            End With
        Catch ex As Exception
            MsgBox("Error EventHandler Function: " & ex.Message)
            My.Application.Log.WriteEntry("Error EventHandler Function: " & ex.Message)
        End Try

        Return scoreBoard

    End Function

End Class

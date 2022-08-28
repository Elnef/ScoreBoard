Public Class Match

    'Starting date and time
    Public Property MatchData As MatchScheduled

    'Match Minute
    Public Property MinuteMatch As Integer

    'Scores
    Public Property HomeScore As Integer

    Public Property AwayScore As Integer

    'Flag to match started
    Public Property IsStarted As Boolean

    'Flag to match finished
    Public Property IsFinished As Boolean

    'Flag to check if match is created correctly
    Public Property IsValid As Boolean

End Class

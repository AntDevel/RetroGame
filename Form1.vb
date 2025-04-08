Public Class Form1
    'choosing map properties
    Dim Gamestate As Integer = 0
    'Load Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Key Down For Movements
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case Gamestate
            Case 1
                'GravityMove
            Case 2
                'pacmanMove
            Case 3
                'flyMove
        End Select
    End Sub
    'Key Up for Movements
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case Gamestate
            Case 1
                'GravityMove
            Case 3
                'flyMove
        End Select
    End Sub
    'Change The map; NewLevel,TitleScreen,Pause, etc
    Private Sub MapChange()

    End Sub
    'Detect Win
    Private Sub WinDetect()

    End Sub
    'Lose
    Private Sub Lose()

    End Sub
    Private Sub levels()

    End Sub
    'Detect Danger
    Private Sub DangerDetect()

    End Sub

    'Platformer
    Private Sub GravityMovement()

    End Sub

    Private Sub MovingPlatforms()

    End Sub
    'Pacman
    Private Sub Coloring()

    End Sub
    Private Sub PacManMovement()

    End Sub
    Private Sub DirectionChange()

    End Sub
    Private Sub NPCMovement()

    End Sub
    'Flying
    Private Sub FlyingMovement()

    End Sub
    Private Sub Cloning()

    End Sub
    Private Sub CloneMoving()

    End Sub
End Class

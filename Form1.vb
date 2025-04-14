Public Class Form1
    'choosing map properties
    Dim Gamestate As Integer = 0
    Dim Choices As Integer = 0
    'KeyDown
    Dim w As Boolean = False
    Dim a As Boolean = False
    Dim s As Boolean = False
    Dim d As Boolean = False
    Dim grounded As Boolean = False
    Dim touching As Boolean
    Dim isJumping As Boolean

    'Load Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleScreen.Dock = DockStyle.Fill
        Map1.Dock = DockStyle.Fill
        PressToPlay.ForeColor = Color.White
        Dim TopBorder As New PictureBox With {
            .BackColor = Color.Blue,
            .Size = Map1Player.Size,
            .Left = Map1Player.Left,
            .Top = Map1Player.Top - Map1Player.Height
            }
        Dim BottomBorder As New PictureBox With {
            .BackColor = Color.Blue,
            .Size = Map1Player.Size,
            .Left = Map1Player.Left,
            .Top = Map1Player.Top + Map1Player.Height
            }
        Dim LeftBorder As New PictureBox With {
            .BackColor = Color.Blue,
            .Size = Map1Player.Size,
            .Left = Map1Player.Left - Map1Player.Width,
            .Top = Map1Player.Top
            }
        Dim RightBorder As New PictureBox With {
            .BackColor = Color.Blue,
            .Size = Map1Player.Size,
            .Left = Map1Player.Left + Map1Player.Width,
            .Top = Map1Player.Top
            }
        Map1.Controls.Add(RightBorder)
        Map1.Controls.Add(TopBorder)
        Map1.Controls.Add(LeftBorder)
        Map1.Controls.Add(BottomBorder)

    End Sub
    'Key Down For Movements
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case Gamestate
            Case 0

                For Each LabelControl As Control In TitleScreen.Controls

                    If e.KeyCode = Keys.S Then
                        If TypeOf LabelControl Is Label Then
                            LabelControl.ForeColor = Color.Black
                            If Choices < 7 Then
                                Choices += 1
                            Else
                                Choices = -1
                            End If

                        End If


                    End If
                    If e.KeyCode = Keys.W Then
                        If TypeOf LabelControl Is Label Then
                            LabelControl.ForeColor = Color.Black
                            If Choices > -1 Then
                                Choices -= 1
                            Else
                                Choices = 7
                            End If
                        End If


                    End If
                    'Loading the first Map
                    Select Case Choices
                        Case 0
                            PressToPlay.ForeColor = Color.White
                        Case 3
                            Settings.ForeColor = Color.White
                        Case 6
                            Quit.ForeColor = Color.White
                    End Select
                    PressToPlay.Text = Choices
                    If e.KeyCode = Keys.Enter Then
                        Select Case Choices
                            Case 0
                                TitleScreen.Enabled = False
                                TitleScreen.Visible = False
                                Map1.Visible = True
                                Map1.Enabled = True
                            Case 3

                            Case 6
                                Me.Close()
                        End Select


                    End If
                Next
            Case 1
                'GravityMove
                If e.KeyCode = Keys.W Then
                    w = True
                End If
                If e.KeyCode = Keys.A Then
                    a = True

                End If
                If e.KeyCode = Keys.D Then
                    d = True
                End If
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


                If e.KeyCode = Keys.A Then
                    a = False

                End If
                If e.KeyCode = Keys.D Then
                    d = False
                End If
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

    Private Sub MovingPlatforms(ByRef Player As PictureBox, ByRef Map As Panel)
        'Variables
        Dim PlayerX As Integer = Player.Location.X
        Dim PlayerY As Integer = Player.Location.Y
        Dim Velocity As Double = 0
        Dim MapX As Integer = Map.Location.X
        Dim MapY As Integer = Map.Location.Y
        Dim MapMove As Boolean

        'code

        If a Then
            PlayerX -= 5
        End If
        If d Then
            PlayerX += 5
        End If

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

    Private Sub PressToPlay_Click(sender As Object, e As EventArgs) Handles PressToPlay.Click

    End Sub
End Class


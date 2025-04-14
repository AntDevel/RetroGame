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
    Dim TopBorder As New PictureBox
    Dim BottomBorder As New PictureBox
    Dim LeftBorder As New PictureBox
    Dim RightBorder As New PictureBox

    'Load Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleScreen.Dock = DockStyle.Fill
        Map1.Dock = DockStyle.Fill
        PressToPlay.ForeColor = Color.White

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
                                Map1Timer.Start()
                                Gamestate = 1
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
    Private Sub PlatformMovement()

    End Sub

    Private Sub GravityMove(ByRef Player As PictureBox, ByRef Map As Panel)
        'Variables
        Dim PlayerX As Integer = Player.Left
        Dim PlayerY As Integer = Player.Top
        Dim Velocity As Double = 0
        Dim MapX As Integer = Map.Location.X
        Dim MapY As Integer = Map.Location.Y
        Dim MapMove As Boolean = True

        TopBorder.BackColor = Color.Blue
        TopBorder.Size = Player.Size
        TopBorder.Visible = False
        BottomBorder.BackColor = Color.Blue
        BottomBorder.Size = Player.Size
        BottomBorder.Visible = False
        LeftBorder.BackColor = Color.Blue
        LeftBorder.Size = Player.Size
        LeftBorder.Visible = False
        RightBorder.BackColor = Color.Blue
        RightBorder.Size = Player.Size
        RightBorder.Visible = False
        Map.Controls.Add(RightBorder)
        Map.Controls.Add(LeftBorder)
        Map.Controls.Add(TopBorder)
        Map.Controls.Add(BottomBorder)
        RightBorder.Location = New Point(Player.Left, Player.Top)
        LeftBorder.Location = New Point(Player.Left, Player.Top)
        BottomBorder.Location = New Point(Player.Left, Player.Top)
        TopBorder.Location = New Point(Player.Left, Player.Top)
        'code
        'key inputs and start movements
        If a AndAlso PlayerX > 0 Then
            PlayerX -= 5
        Else
            PlayerX += 5
        End If
        If d AndAlso PlayerX < Map.Width - Player.Width Then
            PlayerX += 5
        Else
            PlayerX -= 5
        End If
        If w AndAlso grounded Then
            Velocity = -10
            grounded = False
        End If
        If Not grounded Then
            Velocity += 0.5
            PlayerY += Velocity

        Else
            Velocity = 0
        End If
        'bordermove
        TopBorder.Location = New Point(Player.Left, Player.Top - Player.Height)
        BottomBorder.Location = New Point(Player.Left, Player.Top + Player.Height)
        LeftBorder.Location = New Point(Player.Left - Player.Width, Player.Top)
        RightBorder.Location = New Point(Player.Left + Player.Width, Player.Top)

        For Each ctrl As Control In Map.Controls
            If ctrl IsNot Player AndAlso Visible Then
                If BottomBorder.Bounds.IntersectsWith(ctrl.Bounds) Or PlayerY > Map.Width - Player.Width Then
                    grounded = True
                    Velocity = 0
                End If
            End If
        Next
        Player.Left = PlayerX
        Player.Top = PlayerY
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

    Private Sub Map1Timer_Tick(sender As Object, e As EventArgs) Handles Map1Timer.Tick
        GravityMove(Map1Player, Map1)
        Log.Text = Map1Player.Top
    End Sub
End Class


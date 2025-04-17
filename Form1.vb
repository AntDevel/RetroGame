Public Class Form1
    'choosing map properties
    Dim Gamestate As Integer = 0
    Dim Choices As Integer = 0
    'KeyDown
    Dim w As Boolean = False
    Dim a As Boolean = False
    Dim s As Boolean = False
    Dim d As Boolean = False
    Dim Velocity As Double = 0
    Dim grounded As Boolean = False
    Dim gravity As Double = 0.5
    Dim mapSize As Integer = Me.Width
    Dim mapMove As Boolean = False
    Dim mapLeft As Boolean = True
    Dim mapRight As Boolean = True
    Dim TopBorder As New PictureBox
    Dim BottomBorder As New PictureBox
    Dim LeftBorder As New PictureBox
    Dim RightBorder As New PictureBox
    Dim level As Integer = 0
    Dim Build As Boolean = True
    Dim MapX As Integer = 0
    'Load Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleScreen.Dock = DockStyle.Fill
        Me.WindowState = FormWindowState.Maximized


        PressToPlay.ForeColor = Color.White
        mapSize = Me.Width
        Dim task1 As Task = Task.Run(Sub() Map1Timer_Tick(sender, e))
        Dim task2 As Task = Task.Run(Sub() Timer1_Tick(sender, e))
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
                                Timer1.Start()
                                Gamestate = 1
                                Map1Player.Location = New Point(16, 510)
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
                    gravity = 0.5
                    If grounded Then
                        Velocity = -10
                        grounded = False

                    End If

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
                If e.KeyCode = Keys.W Then
                    w = False

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
        level += 1
        If level = 10 Then WinDetect()
    End Sub
    'Detect Danger
    Private Sub DangerDetect(ByRef Player As PictureBox, ByRef Map As Panel)
        Select Case level
            Case 0, 1, 2, 3
                Player.Location = New Point(10, 580)
                Map.Left = 0
        End Select
    End Sub

    'Platformer
    Private Sub PlatformMovement()

    End Sub

    Private Sub GravityMove(ByRef Player As PictureBox, ByRef Map As Panel)
        'Variables
        Dim PlayerX As Integer = Player.Left
        Dim PlayerY As Integer = Player.Top
        MapX = Map.Location.X
        Dim MapY As Integer = Map.Location.Y
        MapMove = False
        Dim aa As Boolean = True
        Dim dd As Boolean = True


        If Build Then
            TopBorder.BackColor = Color.Orange
            TopBorder.Width = Player.Width * 3 / 4
            TopBorder.Height = Player.Height / 2
            TopBorder.Enabled = False
            BottomBorder.BackColor = Color.Teal
            BottomBorder.Width = Player.Width * 3 / 4
            BottomBorder.Height = Player.Height / 2
            BottomBorder.Enabled = False
            LeftBorder.BackColor = Color.Yellow
            LeftBorder.Width = Player.Width / 4
            LeftBorder.Height = Player.Height * 3 / 4
            LeftBorder.Enabled = False
            RightBorder.BackColor = Color.Brown
            RightBorder.Width = Player.Width / 4
            RightBorder.Height = Player.Height * 3 / 4
            RightBorder.Enabled = False
            Map.Controls.Add(RightBorder)
            Map.Controls.Add(LeftBorder)
            Map.Controls.Add(TopBorder)
            Map.Controls.Add(BottomBorder)
            RightBorder.Location = New Point(Player.Left, Player.Top)
            LeftBorder.Location = New Point(Player.Left, Player.Top)
            BottomBorder.Location = New Point(Player.Left, Player.Top)
            TopBorder.Location = New Point(Player.Left, Player.Top)
            Build = False
        End If
        If (mapSize / 2) < PlayerX AndAlso PlayerX < Map.Width - (mapSize / 2) Then
            MapMove = True
        ElseIf PlayerX < mapSize / 2 Then
            MapX = 0

            mapMove = False
        ElseIf PlayerX > Map.Width - mapSize / 2 Then
            MapX = mapSize - Map.Width
            MapMove = False
        End If
        'detection
        For Each ctrl As Control In Map.Controls
            If ctrl IsNot Player AndAlso ctrl.Enabled = True AndAlso ctrl IsNot Map Then



                If BottomBorder.Bounds.IntersectsWith(ctrl.Bounds) AndAlso Player.Bounds.IntersectsWith(ctrl.Bounds) Then
                    PlayerY = ctrl.Top - Player.Height + 0.8
                    grounded = True
                    If w Then
                        Velocity = -10
                        gravity = 0.5
                    Else
                        Velocity = 0
                        gravity = 0
                    End If
                ElseIf PlayerY + Player.Height < Map.Height AndAlso Not BottomBorder.Bounds.IntersectsWith(ctrl.Bounds) AndAlso Not Player.Bounds.IntersectsWith(ctrl.Bounds) Then
                    grounded = False
                    gravity = 0.5
                End If
                'wasd move

                If Player.Bounds.IntersectsWith(ctrl.Bounds) Then
                    If TopBorder.Bounds.IntersectsWith(ctrl.Bounds) Then
                        Velocity = 0
                        PlayerY = ctrl.Top + ctrl.Height + 1

                    End If
                    If LeftBorder.Bounds.IntersectsWith(ctrl.Bounds) Then
                        aa = False
                        mapLeft = False
                    Else
                        aa = True
                        mapLeft = True
                    End If
                    If RightBorder.Bounds.IntersectsWith(ctrl.Bounds) Then
                        mapRight = False
                        dd = False
                    Else
                        dd = True
                        mapRight = True
                    End If
                    Select Case ctrl.BackColor
                        Case Color.Red, Color.DarkRed
                            DangerDetect(Player, Map)
                            PlayerX = Player.Left
                            PlayerY = Player.Top
                            MapX = Map.Left
                        Case Color.Green
                            levels()
                        Case Color.Blue
                            grounded = False
                            Velocity = -20
                            gravity = 0.5
                    End Select

                End If

            End If
        Next
        If a AndAlso PlayerX > 0 AndAlso aa Then
            PlayerX -= 8
        End If
        If d AndAlso PlayerX < Map.Width - Player.Width AndAlso dd Then
            PlayerX += 8
        End If
        'code
        'key inputs and start movements

        If Not grounded Then
            Velocity += gravity
            PlayerY += Velocity
        End If
        If PlayerY + Player.Height > Map.Height Then
            grounded = True

            If w Then
                Velocity = -10
                gravity = 0.5
            Else
                Velocity = 0

                PlayerY = Map.Height - Player.Height
            End If

        End If
        If grounded AndAlso w Then
            Velocity = -10
            grounded = False
            gravity = 0.5
        End If
        Player.Left = PlayerX
        Player.Top = PlayerY
        'bordermove
        TopBorder.Location = New Point(Player.Left + (TopBorder.Width / 8), Player.Top - 1 - Player.Height / 2)
        BottomBorder.Location = New Point(Player.Left + (BottomBorder.Width / 8), Player.Top + Player.Height + 1)
        LeftBorder.Location = New Point(Player.Left - Player.Width / 4, Player.Top + (LeftBorder.Height / 8))
        RightBorder.Location = New Point(Player.Left + Player.Width, Player.Top + (LeftBorder.Height / 8))
        Log.Text = MapX & MapMove & PlayerX & " " & mapSize
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
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If mapMove Then
            If mapLeft AndAlso a Then
                Map1.Left += 8
            ElseIf mapRight AndAlso d Then
                Map1.Left -= 8
            End If
        End If
        MapX = Map1.Left
    End Sub
End Class


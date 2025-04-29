Public Class Form1
    'choosing map properties
    Dim Gamestate As Integer = 0
    Dim Choices As Integer = 0
    Const speed As Integer = 5
    'KeyDown
    Dim b As Boolean = True
    Dim w As Boolean = False
    Dim a As Boolean = False
    Dim s As Boolean = False
    Dim d As Boolean = False
    Dim Velocity As Double = 0
    Dim grounded As Boolean = False
    Dim gravity As Double = 0.5
    Dim movingcount As Boolean = False
    Dim TopBorder As New PictureBox
    Dim BottomBorder As New PictureBox
    Dim LeftBorder As New PictureBox
    Dim RightBorder As New PictureBox
    Dim level As Integer = 0
    Dim Build As Boolean = True
    Dim platform As New List(Of Panel)()
    Dim Dangerplatform As New List(Of Panel)()
    Dim recs As New List(Of Rectangle)()
    Dim coins As Integer = 0
    Dim aaa As Boolean = True
    Dim ddd As Boolean = True
    'Load Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleScreen.Dock = DockStyle.Fill
        Me.WindowState = FormWindowState.Maximized
        Map1Barrier.Width = 1000
        PressToPlay.ForeColor = Color.White

        Dim task1 As Task = Task.Run(Sub() Map1Timer_Tick(sender, e))
        Dim task2 As Task = Task.Run(Sub() Platforms_Tick(sender, e))
        Dim task3 As Task = Task.Run(Sub() Rush_Tick(sender, e))
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
                    If e.KeyCode = Keys.Enter Then
                        Select Case Choices
                            Case 0
                                TitleScreen.Enabled = False
                                TitleScreen.Visible = False
                                Map1.Visible = True
                                Map1.Enabled = True
                                Map1Barrier.Visible = True
                                Map1Barrier.Enabled = True
                                Map1Timer.Start()
                                Platforms.Start()
                                PlatformAdd(Map1Player, Map1)
                                For Each ctrl As Control In Map1.Controls
                                    If ctrl.BackColor = Color.Tan Then
                                        ctrl.Enabled = False
                                        ctrl.Visible = False
                                    End If
                                Next

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
                If e.KeyCode = Keys.Space Then
                    w = True
                    gravity = 0.5
                    If grounded Then
                        Velocity = -12
                        grounded = False

                    End If

                End If
                If e.KeyCode = Keys.A Then
                    a = True

                End If
                If e.KeyCode = Keys.D Then
                    d = True
                End If
          
        End Select
    End Sub
    'Key Up for Movements
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case Gamestate
            Case 0

            Case 1
                'GravityMove


                If e.KeyCode = Keys.A Then
                    a = False

                End If
                If e.KeyCode = Keys.D Then
                    d = False
                End If
                If e.KeyCode = Keys.Space Then
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
    Private Sub Lava(ByRef Player As PictureBox, ByRef Map As Panel)
        For Each ctrl As Control In Map.Controls
            If ctrl.BackColor = Color.DarkOrange Then
                If ctrl.Bounds.IntersectsWith(Player.Bounds) Then
                    DangerDetect(Player, Map)


                Else
                    ctrl.Height += 10
                    ctrl.Top -= 10
                End If

            End If

        Next
    End Sub
    Private Sub levels()
        level += 1
        If level = 10 Then WinDetect()
        Select Case level
            Case 1
                Map1.Enabled = False

                Map1.Visible = False
                Map2.Visible = True
                Map2.Enabled = True
                Map2Player.Location = New Point(16, 510)
                PlatformAdd(Map2Player, Map2)
                For Each ctrl As Control In Map2.Controls
                    If ctrl.BackColor = Color.Tan Then
                        ctrl.Enabled = False
                        ctrl.Visible = False
                    End If
                Next
                Build = True
        End Select
    End Sub
    'Detect Danger
    Private Sub DangerDetect(ByRef Player As PictureBox, ByRef Map As Panel)
        Select Case level
            Case 0, 1, 2, 3

                For Each ctrl As Control In Map.Controls
                    If ctrl.BackColor = Color.DarkOrange Then

                        Map1Timer.Stop()
                        Rush.Stop()
                        Threading.Thread.Sleep(600)
                        Map1Timer.Start()
                        ctrl.Top = 780
                        ctrl.Height = 30
                    ElseIf ctrl.BackColor = Color.Gold Then
                        ctrl.Visible = True
                    End If
                Next
                Player.Location = New Point(10, 580)
                Map.Left = 0
                coins = 0
        End Select
    End Sub

    'Platformer
    Private Sub PlatformMovement(ByRef Player As PictureBox, ByRef Map As Panel)

        'variables
        For Each ctrl As Control In Map.Controls


            'forloop
            For Each plat In platform
                If plat.Enabled Then
                    Select Case plat.BackColor
                        Case Color.Gray, Color.DarkRed
                            If ctrl.BackColor = Color.Tan Or ctrl.BackColor = Color.Red Then
                                Select Case plat.Bounds.IntersectsWith(ctrl.Bounds)
                                    Case True
                                        If plat.BackColor = Color.Gray Then
                                            plat.BackColor = Color.DarkGray
                                        ElseIf plat.BackColor = Color.DarkRed Then
                                            plat.BackColor = Color.Maroon
                                        End If
                                        plat.Left = ctrl.Left + ctrl.Width
                                    Case False
                                        plat.Left -= 1
                                End Select
                            End If
                        Case Color.DarkGray, Color.Maroon
                            If ctrl.BackColor = Color.Tan Or ctrl.BackColor = Color.Red Then
                                Select Case plat.Bounds.IntersectsWith(ctrl.Bounds)
                                    Case True
                                        If plat.BackColor = Color.DarkGray Then
                                            plat.BackColor = Color.Gray
                                        ElseIf plat.BackColor = Color.Maroon Then
                                            plat.BackColor = Color.DarkRed
                                        End If

                                        plat.Left = ctrl.Left - plat.Width
                                    Case False
                                        plat.Left += 1
                                End Select
                            End If

                    End Select
                End If
            Next
        Next
        movingcount = True

    End Sub
    Private Sub PlatformAdd(ByRef Player As PictureBox, ByRef Map As Panel)
        'variables

        'forloop
        For Each ctrl As Control In Map.Controls
            If ctrl.Enabled Then
                Select Case ctrl.BackColor
                    Case Color.Gray, Color.DarkGray, Color.Maroon, Color.DarkRed
                        platform.Add(ctrl)

                End Select
            End If
        Next
    End Sub
    Private Sub GravityMove(ByRef Player As PictureBox, ByRef Map As Panel)
        'Variables
        Dim PlayerX As Integer = Player.Left
        Dim PlayerY As Integer = Player.Top
        Dim MapX As Integer = Map.Left
        Dim mapSize As Integer = Map1Barrier.Width
        Dim mapMove As Boolean = False
        Dim aa As Boolean = True
        Dim dd As Boolean = True
        TopBorder.Location = New Point(Player.Left + (TopBorder.Width / 8), Player.Top - 1 - Player.Height / 4)
        BottomBorder.Location = New Point(Player.Left + (BottomBorder.Width / 8), Player.Top + Player.Height + 1)
        LeftBorder.Location = New Point(Player.Left - Player.Width / 4, Player.Top + (LeftBorder.Height / 8))
        RightBorder.Location = New Point(Player.Left + Player.Width, Player.Top + (LeftBorder.Height / 8))
        movingcount -= 1
        If Build Then
            TopBorder.BackColor = Color.Orange
            TopBorder.Width = Player.Width * 3 / 4
            TopBorder.Height = Player.Height / 4
            TopBorder.Enabled = False
            TopBorder.Visible = b
            BottomBorder.BackColor = Color.Teal
            BottomBorder.Width = Player.Width * 3 / 4
            BottomBorder.Height = Player.Height / 4
            BottomBorder.Enabled = False
            BottomBorder.Visible = b
            LeftBorder.BackColor = Color.Yellow
            LeftBorder.Width = Player.Width / 4
            LeftBorder.Height = Player.Height * 3 / 4
            LeftBorder.Enabled = False
            LeftBorder.Visible = b
            RightBorder.BackColor = Color.Brown
            RightBorder.Width = Player.Width / 4
            RightBorder.Height = Player.Height * 3 / 4
            RightBorder.Enabled = False
            RightBorder.Visible = b

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
                'wasd move
                If BottomBorder.Bounds.IntersectsWith(ctrl.Bounds) AndAlso Player.Bounds.IntersectsWith(ctrl.Bounds) Then
                    PlayerY = ctrl.Top - Player.Height + 0.8
                    grounded = True
                    If w Then
                        Velocity = -12
                        gravity = 0.5
                    Else
                        Velocity = 0
                        gravity = 0
                    End If

                ElseIf PlayerY + Player.Height < Map.Height AndAlso Not BottomBorder.Bounds.IntersectsWith(ctrl.Bounds) AndAlso Not Player.Bounds.IntersectsWith(ctrl.Bounds) Then
                    grounded = False
                    gravity = 0.5
                End If
                If Player.Bounds.IntersectsWith(ctrl.Bounds) Then
                    If TopBorder.Bounds.IntersectsWith(ctrl.Bounds) Then
                        Velocity = 0
                        PlayerY = ctrl.Top + ctrl.Height + 1

                    End If
                    If LeftBorder.Bounds.IntersectsWith(ctrl.Bounds) Then
                        aa = False

                    End If
                    If RightBorder.Bounds.IntersectsWith(ctrl.Bounds) Then
                        dd = False

                    End If
                    Select Case ctrl.BackColor
                        Case Color.Red, Color.DarkRed, Color.DarkOrange

                            DangerDetect(Player, Map)
                            PlayerX = Player.Left
                            PlayerY = Player.Top
                            MapX = Map.Left
                        Case Color.Green
                            levels()
                        Case Color.Blue
                            grounded = False
                            Velocity = -25
                            gravity = 0.5

                    End Select

                End If

            End If
            If ctrl.Visible AndAlso ctrl.BackColor = Color.Gold AndAlso Player.Bounds.IntersectsWith(ctrl.Bounds) Then
                coins += 1
                If coins = 1 Then
                    Rush.Start()
                End If
                ctrl.Visible = False
            End If
        Next
        If a AndAlso PlayerX > 0 AndAlso aa Then

            PlayerX -= speed
            If mapMove Then MapX += speed
        End If
        If d AndAlso PlayerX < Map.Width - Player.Width AndAlso dd Then

            PlayerX += speed
            If mapMove Then MapX -= speed
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
        aaa = aa
        ddd = dd
        Map.Left = MapX
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
        Select Case level
            Case 0
                GravityMove(Map1Player, Map1)
            Case 1
                GravityMove(Map2Player, Map2)
        End Select

    End Sub

    Private Sub Platforms_Tick(sender As Object, e As EventArgs) Handles Platforms.Tick
        Select Case level
            Case 0
                PlatformMovement(Map1Player, Map1)
            Case 1
                PlatformMovement(Map2Player, Map2)
        End Select

    End Sub

    Private Sub Rush_Tick(sender As Object, e As EventArgs) Handles Rush.Tick
        Lava(Map2Player, Map2)
    End Sub
End Class


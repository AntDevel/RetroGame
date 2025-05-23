Public Class Form1
    'choosing map properties
    Dim Gamestate As Integer = 0
    Dim Choices As Integer = 0
    Dim speed As Integer = 5
    Dim jumpslip As Boolean = False
    'KeyDown
    Dim slip As Boolean = False
    Dim first As Boolean = True
    Dim p As Integer = 8
    Dim b As Boolean = False
    Dim w As Boolean = False
    Dim a As Boolean = False
    Dim s As Boolean = False
    Dim d As Boolean = False
    Dim mapMove As Boolean = False
    Dim aa As Boolean = True
    Dim dd As Boolean = True
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
    Dim platend As New List(Of Panel)()
    Dim coins As Integer = 0
    Dim aaa As Boolean = True
    Dim ddd As Boolean = True
    Dim v = -11
    Dim colorlist() As Color = {Color.DarkRed, Color.DarkGray, Color.Gray, Color.Maroon}
    Dim ss As Integer = 0
    Const num As Integer = 35
    Dim Xvel As Double = 0
    Dim runOne As Boolean = True
    Dim coded As Integer()
    Dim mapNum As New List(Of Label)
    Dim cod As String = ""
    Dim dfd As Boolean = True
    Dim asda As Boolean = True
    'Load Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ert As Integer = 340



        TitleScreen.Location = New Point(0, 0)
        Me.WindowState = FormWindowState.Maximized
        Map1Barrier.Width = 1000
        Console.WriteLine(PressToPlay.Location)
        PressToPlay.ForeColor = Color.White
        Quit.Text = "Quit"
        PressToPlay.Text = "Press Enter to Start"
        Settings.Text = "Settings"
        Quit.Location = New Point(ert, 500)
        PressToPlay.Location = New Point(ert, 400)
        Settings.Location = New Point(ert, 450)

        Map1.Left = 0
        Map1.Top -= 20
        Map2.Left = 0
        Map3.Left = 0
        Map1Player.Width = 40
        Map2Player.Width = 40
        Map1Player.Height = 40
        Map3Player.Height = 40
        Map3Player.Width = 40
        Map2Player.Height = 40
        Dim task1 As Task = Task.Run(Sub() Map1Timer_Tick(sender, e))
        Dim task2 As Task = Task.Run(Sub() Platforms_Tick(sender, e))
        Dim task3 As Task = Task.Run(Sub() Rush_Tick(sender, e))
        Dim task4 As Task = Task.Run(Sub() Bubbles_Tick(sender, e))
    End Sub
    'Key Down For Movements
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case Gamestate
            Case 0



                If e.KeyCode = Keys.S Or e.KeyCode = Keys.Down Then
                    If Choices < 2 Then
                        Choices += 1
                    Else
                        Choices = 0
                    End If

                End If


                If e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then

                    If Choices > 0 Then
                        Choices -= 1
                    Else
                        Choices = 2
                    End If
                End If
                'Loading the first Map


                Select Case Choices
                    Case 0

                        PressToPlay.ForeColor = Color.White
                        PressToPlay.Text = "Press Enter to Start Game"
                        Quit.Text = "Quit"
                        Settings.Text = "Settings"
                        Quit.ForeColor = Color.Black
                        Settings.ForeColor = Color.Black
                    Case 1
                        Settings.ForeColor = Color.White
                        Settings.Text = "Press Enter For Settings"
                        PressToPlay.Text = "Start"
                        Quit.Text = "Quit"
                        Quit.ForeColor = Color.Black
                        PressToPlay.ForeColor = Color.Black
                    Case 2
                        Quit.ForeColor = Color.White
                        Quit.Text = "Press Enter to Quit"
                        PressToPlay.Text = "Start"
                        Settings.Text = "Settings"
                        Settings.ForeColor = Color.Black
                        PressToPlay.ForeColor = Color.Black
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
                            If asda Then
                                mapNum.Add(Secret1)
                                mapNum.Add(Secret2)
                                mapNum.Add(s3)
                                mapNum.Add(s4)
                                mapNum.Add(s5)
                                mapNum.Add(s6)
                                mapNum.Add(s7)
                                mapNum.Add(s8)
                                mapNum.Add(s9)
                                mapNum.Add(s10)
                                asda = False
                            End If
                            Dim ran As New Random()
                            For Each m In mapNum
                                If TypeOf m Is Label AndAlso m.Enabled Then
                                    m.Text = ""
                                    m.Enabled = False
                                    m.Visible = False
                                    m.Text = ran.Next(0, 10)
                                End If
                            Next


                            For y As Integer = 0 To 1

                                Dim xv As Integer = ran.Next(0, 4)
                                If Not mapNum(xv).Visible Then
                                    mapNum(xv).Visible = True
                                    Log.Text += xv.ToString
                                Else

                                    Do Until Not mapNum(xv).Visible
                                        xv = ran.Next(0, 4)

                                    Loop
                                    mapNum(xv).Visible = True
                                    Log.Text += xv.ToString

                                End If
                                xv = ran.Next(4, 8)
                                If Not mapNum(xv).Visible Then
                                    mapNum(xv).Visible = True
                                    Log.Text += xv.ToString
                                Else

                                    Do Until Not mapNum(xv).Visible
                                        xv = ran.Next(4, 8)

                                    Loop
                                    mapNum(xv).Visible = True
                                    Log.Text += xv.ToString

                                End If
                                If dfd Then
                                    xv = ran.Next(8, 10)
                                    If Not mapNum(xv).Visible Then
                                        mapNum(xv).Visible = True
                                        Log.Text += xv.ToString
                                    Else

                                        Do Until Not mapNum(xv).Visible
                                            xv = ran.Next(8, 10)

                                        Loop
                                        mapNum(xv).Visible = True
                                        Log.Text += xv.ToString

                                    End If
                                    dfd = False
                                End If
                            Next

                            Gamestate = 1
                            Map1Player.Location = New Point(16, 510)
                            Map1.Left = 0
                        Case 1

                        Case 2
                            Me.Close()
                    End Select


                End If
            Case 1

                'GravityMove
                If e.KeyCode = Keys.Space Or e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then
                    w = True
                    gravity = 0.5
                    If grounded Then
                        Velocity = v
                        grounded = False

                    End If

                End If
                If e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
                    a = True

                End If
                If e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
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


                If e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
                    a = False

                End If
                If e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
                    d = False
                End If
                If e.KeyCode = Keys.Space Or e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then
                    w = False

                End If
            Case 3
                'flyMove
        End Select
    End Sub
    'Change The map; NewLevel,TitleScreen,Pause, etc

    'Detect Win
    Private Sub WinDetect()

    End Sub
    'Lose
    Private Sub Lava(ByRef Player As PictureBox, ByRef Map As Panel)
        For Each ctrl As Control In Map.Controls
            If ctrl.BackColor = Color.DarkOrange Then
                If ctrl.Bounds.IntersectsWith(Player.Bounds) Then
                    DangerDetect(Player, Map)
                ElseIf ctrl.Top > 385 Then
                    ctrl.Height += 10
                    ctrl.Top -= 10
                End If

            End If
            If coins = 10 Then
                walled.Visible = False
                walled.Enabled = False
            End If
        Next
    End Sub
    Private Sub levels()

        level += 1

        If level = 4 Then WinDetect()
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
                v = -10
                p = 5
                Build = True
                lock.Height = 640
            Case 2
                Map2Player.Location = New Point(16, 510)
                Map2.Enabled = False
                Map2.Visible = False
                Map3.Visible = True
                Map3.Enabled = True
                Map3Player.Location = New Point(16, 510)
                Bubbles.Start()
                PlatformAdd(Map3Player, Map3)
                pt1.Enabled = False
                For Each ctrl As Control In Map3.Controls
                  
                    If ctrl.BackColor = Color.Tan Then
                        ctrl.Enabled = False
                        ctrl.Visible = False
                    End If
                Next
                v = -11
                p = 5
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
                        ctrl.Top = 800
                        ctrl.Height = 30

                    ElseIf ctrl.BackColor = Color.Gold Then
                        ctrl.Visible = True
                    End If
                Next
                Player.Location = New Point(10, 580)
                Map.Left = 0
                pt1.Left = 1741
                runOne = True
                coins = 0
                pan.Location = New Point(725, 550)
                pan.BackColor = Color.Gray
                lock.Height = 640
                walled.Visible = True
                walled.Enabled = True
        End Select
    End Sub
    Dim asa As Boolean = True
    Dim bs As New List(Of Integer)
    Dim bs2 As New List(Of Integer)
    Dim bubs As New List(Of Object)
    Dim di As New List(Of Boolean)
    Private Sub BubbleMove(ByRef Map As Panel)
        If asa Then
            For Each bub In Map.Controls
                If TypeOf bub Is Panel Then
                    If bub.backcolor = Color.OrangeRed AndAlso Not bubs.Contains(bub) Then
                        Dim b As Integer = bub.top
                        Dim bb As Integer = bub.left
                        Dim d As Boolean = True
                        bubs.Add(bub)
                        bs.Add(b)
                        bs2.Add(bb)
                        di.Add(d)
                    End If
                End If
            Next
            asa = False
        End If
        For bub As Integer = 0 To bubs.Count - 1
            If di(bub) Then
                If bubs(bub).Top > bs(bub) - 60 Then

                    bubs(bub).Top -= 4
                    Randomize()
                    If bubs(bub).left < bs2(bub) - 10 Then
                        bubs(bub).left += CInt(Int((5 * Rnd()) + 1))
                    ElseIf bubs(bub).left < bs2(bub) + 10 Then
                        bubs(bub).left -= CInt(Int((5 * Rnd()) + 1))
                    End If
                ElseIf bubs(bub).Top > bs(bub) - 72 Then
                    bubs(bub).Top -= 4
                    bubs(bub).width += 4
                    bubs(bub).height += 4
                Else
                    di(bub) = False
                    bubs(bub).enabled = False
                    bubs(bub).visible = False
                End If
            Else
                If bubs(bub).Top < bs(bub) Then
                    bubs(bub).Top += 4
                Else
                    bubs(bub).left = bs2(bub)
                    bubs(bub).width -= 12
                    bubs(bub).height -= 12
                    di(bub) = True
                    bubs(bub).enabled = True
                    bubs(bub).visible = True
                End If

            End If
        Next

    End Sub

    'Platformer
    Private Sub PlatformMovement(ByRef Player As PictureBox, ByRef Map As Panel)

        'variables
        Platforms.Interval = 25
        If runOne AndAlso Map3Player.Left > 1240 Then
            pt1.Enabled = True
            runOne = False
        ElseIf runOne AndAlso Map3Player.Left < 1240 Then
            pt1.Enabled = False
        End If
        If Not platform.Contains(pt1) Then
            platform.Add(pt1)
        End If
        For Each ctrl As Control In Map.Controls

            'forloop

            For Each plat In platform


                If plat.Enabled Then
                    Select Case plat.BackColor
                        Case Color.Gray, Color.DarkRed
                            If (Not ctrl.Enabled AndAlso ctrl.BackColor = Color.Tan) Or (ctrl.BackColor = Color.Red AndAlso ctrl.Enabled) Then
                                Select Case plat.Bounds.IntersectsWith(ctrl.Bounds)
                                    Case True
                                        If plat.BackColor = Color.Gray Then
                                            plat.BackColor = Color.DarkGray
                                            If Not ss = num Then plat.Enabled = False
                                        ElseIf plat.BackColor = Color.DarkRed Then
                                            plat.BackColor = Color.Maroon
                                            If Not ss = num Then plat.Enabled = False
                                        End If

                                        plat.Left = ctrl.Left + ctrl.Width

                                End Select
                            End If
                        Case Color.DarkGray, Color.Maroon
                            If (Not ctrl.Enabled AndAlso ctrl.BackColor = Color.Tan) Or (ctrl.BackColor = Color.Red AndAlso ctrl.Enabled) Then
                                Select Case plat.Bounds.IntersectsWith(ctrl.Bounds)
                                    Case True
                                        If plat.BackColor = Color.DarkGray Then
                                            plat.BackColor = Color.Gray
                                            If Not ss = num Then plat.Enabled = False
                                        ElseIf plat.BackColor = Color.Maroon Then
                                            plat.BackColor = Color.DarkRed
                                            If Not ss = num Then plat.Enabled = False
                                        End If

                                        plat.Left = ctrl.Left - plat.Width

                                End Select
                            End If

                    End Select
                End If
            Next



        Next

        For Each plat In platform
            If plat.Enabled = False AndAlso ss = num Then
                If Not plat.Name = pt1.Name Then
                    plat.Enabled = True
                ElseIf plat.Name = pt1.Name AndAlso runOne = False Then
                    plat.Enabled = True
                End If
            End If
            If plat.Enabled Then

                Select Case plat.BackColor

                    Case Color.Gray, Color.DarkRed

                        plat.Left -= p

                    Case Color.DarkGray, Color.Maroon
                        plat.Left += p

                    Case Color.DimGray

                        'If dd AndAlso aa AndAlso Player.Bounds.IntersectsWith(plat.Bounds) AndAlso BottomBorder.Bounds.IntersectsWith(plat.Bounds) Then
                        'Player.Left += 3
                        '  If Map.Left Then Map.Left -= 3
                        '  End If
                End Select

            End If

        Next
        movingcount = True
        If Not ss = num Then
            ss += 1
        Else
            ss = 0
        End If


    End Sub
    '
    'BUTTON 
    '
    Dim tr As Integer = 0
    Dim buttonList As New List(Of Object)
    Dim addbtn As Boolean = True
    Dim buttonY() As Integer = {650, 485, 340}
    Dim pres As Boolean = True
    Private Sub buttons()
        If addbtn Then
            For Each ctrl As Control In Map3.Controls
                If ctrl.BackColor = Color.Gainsboro AndAlso TypeOf ctrl Is Panel Then
                    buttonList.Add(ctrl)
                End If
            Next
            addbtn = False
        End If
        For btn As Integer = 0 To buttonList.Count - 1
            If TypeOf buttonList(btn) Is Panel Then
                If Not BottomBorder.Bounds.IntersectsWith(buttonList(btn).bounds) AndAlso tr = 3 Then
                    Select Case buttonList(btn).top
                        Case buttonY(0) + 10
                            buttonList(btn).top = buttonY(0)
                            buttonList(btn).backcolor = Color.Gainsboro
                            pres = True
                        Case buttonY(1) + 10
                            buttonList(btn).top = buttonY(1)
                            buttonList(btn).backcolor = Color.Gainsboro
                            pres = True
                        Case buttonY(2) + 10
                            buttonList(btn).top = buttonY(2)
                            buttonList(btn).backcolor = Color.Gainsboro
                            pres = True
                    End Select
                ElseIf BottomBorder.Bounds.IntersectsWith(buttonList(btn).bounds) Then

                    Select Case buttonList(btn).top
                        Case buttonY(0)
                            buttonList(btn).top = buttonY(0) + 10
                            buttonList(btn).backcolor = Color.DimGray
                        Case buttonY(1)
                            buttonList(btn).top = buttonY(1) + 10
                            buttonList(btn).backcolor = Color.DimGray
                        Case buttonY(2)
                            buttonList(btn).top = buttonY(2) + 10
                            buttonList(btn).backcolor = Color.DimGray
                    End Select
                    Select Case buttonList(btn).name
                        Case Clear.Name
                            coded = {}
                        Case btn0.Name
                            If coded.Count < 5 Then
                                coded.Append(0)
                            End If
                        Case btn1.Name
                            If coded.Count < 5 Then
                                coded.Append(1)
                            End If
                        Case btn2.Name
                            If coded.Count < 5 Then
                                coded.Append(2)
                            End If
                        Case btn3.Name
                            If coded.Count < 5 Then
                                coded.Append(3)
                            End If
                        Case btn4.Name
                            If coded.Count < 5 Then
                                coded.Append(4)
                            End If
                        Case btn5.Name
                            If coded.Count < 5 Then
                                coded.Append(5)
                            End If
                        Case btn6.Name
                            If coded.Count < 5 Then
                                coded.Append(6)
                            End If
                        Case btn7.Name
                            If coded.Count < 5 Then
                                coded.Append(7)
                            End If
                        Case btn8.Name
                            If coded.Count < 5 Then
                                coded.Append(8)
                            End If
                        Case btn9.Name
                            If coded.Count < 5 Then
                                coded.Append(9)
                            End If
                    End Select

                End If
            End If
        Next
        If coded IsNot Nothing AndAlso coded.Count = 5 Then
            Map3.Enabled = False
            Map3.Visible = False
            TitleScreen.Enabled = True
            TitleScreen.Visible = True
            Platforms.Stop()
            Map1Timer.Stop()
            level = 0
            Gamestate = 0
            Build = True
            ppp.Text = "You win!"

        End If
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
        slip = False
        Dim pres As Boolean = True

        Dim direct As Boolean = False
        Dim once As Boolean = False
        mapMove = False
        aa = True
        dd = True
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
            lock.Height = 640
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

        If (mapSize / 2) < PlayerX + Xvel AndAlso PlayerX + Xvel < Map.Width - (mapSize / 2) Then
            mapMove = True
        ElseIf PlayerX < mapSize / 2 Then
            MapX = 0

            mapMove = False
        ElseIf PlayerX + Xvel > Map.Width - mapSize / 2 Then
            MapX = mapSize - Map.Width
            MapMove = False
        End If
        'detection

        For Each ctrl As Control In Map.Controls

            If ctrl IsNot Player AndAlso colorlist.Contains(ctrl.BackColor) Or ctrl.Enabled = True AndAlso ctrl IsNot Map Then
                'wasd move
                If BottomBorder.Bounds.IntersectsWith(ctrl.Bounds) AndAlso Player.Bounds.IntersectsWith(ctrl.Bounds) Then
                    PlayerY = ctrl.Top - Player.Height + 0.8
                    grounded = True

                    If w Then
                        Velocity = v
                        gravity = 0.5
                        If Not jumpslip Then slip = False
                        Xvel = Xvel
                    Else
                        Velocity = 0
                        gravity = 0
                    End If
                    If ctrl.BackColor = Color.Black Or ctrl.BackColor = Color.Gray Or ctrl.BackColor = Color.DarkGray Or ctrl.BackColor = Color.Gainsboro Then
                        Xvel = 0
                        slip = False
                        jumpslip = False
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
                        Xvel = 0
                    End If
                    If RightBorder.Bounds.IntersectsWith(ctrl.Bounds) Then
                        dd = False
                        Xvel = 0
                    End If
                    Select Case ctrl.BackColor
                        Case Color.Red, Color.DarkRed, Color.DarkOrange, Color.OrangeRed

                            DangerDetect(Player, Map)
                            PlayerX = Player.Left
                            PlayerY = Player.Top
                            MapX = Map.Left
                        Case Color.Green
                            levels()
                        Case Color.Blue
                            grounded = False
                            Velocity = -17
                            gravity = 0.5
                        Case Color.PowderBlue
                            slip = True
                            jumpslip = True


                        Case Color.Black, Color.Gray, Color.DarkGray, Color.Gainsboro
                            first = True
                            jumpslip = False
                            buttons()


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
            pres = False
            direct = False
            If Not slip Then
                Xvel = -5
            Else
                If first Then
                    Xvel = -5
                    first = False
                End If
                If Xvel > -speed - 1 Then
                    Xvel -= (speed + 1) / 5
                End If
            End If
        End If
            If d AndAlso PlayerX < Map.Width - Player.Width AndAlso dd Then
            pres = False
            direct = True
            If Not slip Then
                Xvel = 5

            Else
                If first Then
                    Xvel = 5
                    first = False
                End If
                If Xvel < speed + 1 Then
                    Xvel += (speed + 1) / 5
                End If
            End If
        End If
        'code
        If once AndAlso slip Then
            If direct Then
                Xvel = 5
            Else
                Xvel = -5
            End If
            once = False
        End If
        If pres Then
            If slip Then
                If Xvel < 0 Then
                    Xvel += (speed + 1) / 50
                ElseIf Xvel > 0 Then
                    Xvel -= (speed + 1) / 50
                End If
            Else
                If Xvel < 0 Then
                    Xvel += (speed + 1) / 20
                ElseIf Xvel > 0 Then
                    Xvel -= (speed + 1) / 20
                End If
            End If
        End If
            'key inputs and start movements

            If Not grounded Then
            Velocity += gravity
            PlayerY += Velocity
        End If
        If PlayerY + Player.Height > Map.Height Then
            grounded = True

            If w Then
                Velocity = v
                gravity = 0.5
                If Not jumpslip Then slip = False

            Else
                Velocity = 0

                PlayerY = Map.Height - Player.Height
            End If

        End If


        If grounded AndAlso w Then
            Velocity = v

            grounded = False
            gravity = 0.5
            If Not jumpslip Then slip = False
        End If
        If (PlayerX > lock.Left + lock.Width + 5 AndAlso level = 1 AndAlso Map.Enabled = True) Then
            lock.Height = 760
        End If
        aaa = aa
        ddd = dd
        If mapMove Then Map.Left = MapX - Xvel
        PlayerX += Xvel
        Player.Left = PlayerX
        Player.Top = PlayerY
        If Not coded Is Nothing Then
            Me.Text = coded.ToString
        End If
    End Sub
    'Pacman

    Private Sub Map1Timer_Tick(sender As Object, e As EventArgs) Handles Map1Timer.Tick
        Select Case level
            Case 0
                GravityMove(Map1Player, Map1)
            Case 1
                GravityMove(Map2Player, Map2)
            Case 2
                GravityMove(Map3Player, Map3)

        End Select
        Me.Text = cod
    End Sub

    Private Sub Platforms_Tick(sender As Object, e As EventArgs) Handles Platforms.Tick
        Select Case level
            Case 0
                PlatformMovement(Map1Player, Map1)

            Case 1
                PlatformMovement(Map2Player, Map2)
            Case 2
                PlatformMovement(Map3Player, Map3)

        End Select

    End Sub

    Private Sub Rush_Tick(sender As Object, e As EventArgs) Handles Rush.Tick
        Lava(Map2Player, Map2)
    End Sub

    Private Sub Bubbles_Tick(sender As Object, e As EventArgs) Handles Bubbles.Tick
        BubbleMove(Map3)
        If tr < 3 Then
            tr += 1
        Else
            tr = 0
        End If

    End Sub
End Class


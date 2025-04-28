<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TitleScreen = New System.Windows.Forms.Panel()
        Me.Quit = New System.Windows.Forms.Label()
        Me.Settings = New System.Windows.Forms.Label()
        Me.PressToPlay = New System.Windows.Forms.Label()
        Me.Map1Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Platforms = New System.Windows.Forms.Timer(Me.components)
        Me.Map1Player = New System.Windows.Forms.PictureBox()
        Me.Map1 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Log = New System.Windows.Forms.Label()
        Me.Map1Barrier = New System.Windows.Forms.Panel()
        Me.Map2 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Map2Player = New System.Windows.Forms.PictureBox()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Panel35 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.TitleScreen.SuspendLayout()
        CType(Me.Map1Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Map1.SuspendLayout()
        Me.Map1Barrier.SuspendLayout()
        Me.Map2.SuspendLayout()
        CType(Me.Map2Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleScreen
        '
        Me.TitleScreen.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TitleScreen.Controls.Add(Me.Quit)
        Me.TitleScreen.Controls.Add(Me.Settings)
        Me.TitleScreen.Controls.Add(Me.PressToPlay)
        Me.TitleScreen.Location = New System.Drawing.Point(0, 0)
        Me.TitleScreen.Name = "TitleScreen"
        Me.TitleScreen.Size = New System.Drawing.Size(99, 99)
        Me.TitleScreen.TabIndex = 0
        '
        'Quit
        '
        Me.Quit.AutoSize = True
        Me.Quit.Font = New System.Drawing.Font("Minecraftia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quit.Location = New System.Drawing.Point(369, 316)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(69, 36)
        Me.Quit.TabIndex = 0
        Me.Quit.Text = "Quit"
        '
        'Settings
        '
        Me.Settings.AutoSize = True
        Me.Settings.Font = New System.Drawing.Font("Minecraftia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settings.Location = New System.Drawing.Point(369, 269)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(78, 36)
        Me.Settings.TabIndex = 0
        Me.Settings.Text = "Help"
        '
        'PressToPlay
        '
        Me.PressToPlay.AutoSize = True
        Me.PressToPlay.Font = New System.Drawing.Font("Minecraftia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressToPlay.Location = New System.Drawing.Point(369, 233)
        Me.PressToPlay.Name = "PressToPlay"
        Me.PressToPlay.Size = New System.Drawing.Size(93, 36)
        Me.PressToPlay.TabIndex = 0
        Me.PressToPlay.Text = "Start"
        '
        'Map1Timer
        '
        Me.Map1Timer.Interval = 5
        '
        'Platforms
        '
        Me.Platforms.Interval = 20
        '
        'Map1Player
        '
        Me.Map1Player.BackColor = System.Drawing.Color.GreenYellow
        Me.Map1Player.Location = New System.Drawing.Point(110, 676)
        Me.Map1Player.Name = "Map1Player"
        Me.Map1Player.Size = New System.Drawing.Size(50, 50)
        Me.Map1Player.TabIndex = 0
        Me.Map1Player.TabStop = False
        '
        'Map1
        '
        Me.Map1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Map1.Controls.Add(Me.Panel16)
        Me.Map1.Controls.Add(Me.Panel14)
        Me.Map1.Controls.Add(Me.Panel13)
        Me.Map1.Controls.Add(Me.Panel12)
        Me.Map1.Controls.Add(Me.Panel15)
        Me.Map1.Controls.Add(Me.Panel11)
        Me.Map1.Controls.Add(Me.Panel10)
        Me.Map1.Controls.Add(Me.Panel9)
        Me.Map1.Controls.Add(Me.Panel8)
        Me.Map1.Controls.Add(Me.Panel7)
        Me.Map1.Controls.Add(Me.Panel6)
        Me.Map1.Controls.Add(Me.Panel5)
        Me.Map1.Controls.Add(Me.Panel4)
        Me.Map1.Controls.Add(Me.Panel3)
        Me.Map1.Controls.Add(Me.Panel2)
        Me.Map1.Controls.Add(Me.Panel1)
        Me.Map1.Controls.Add(Me.Log)
        Me.Map1.Controls.Add(Me.Map1Player)
        Me.Map1.Enabled = False
        Me.Map1.Location = New System.Drawing.Point(3, 11)
        Me.Map1.Name = "Map1"
        Me.Map1.Size = New System.Drawing.Size(4000, 827)
        Me.Map1.TabIndex = 1
        Me.Map1.Visible = False
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.Green
        Me.Panel16.Location = New System.Drawing.Point(525, 676)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(50, 108)
        Me.Panel16.TabIndex = 5
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Red
        Me.Panel14.Location = New System.Drawing.Point(1869, 736)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(36, 27)
        Me.Panel14.TabIndex = 6
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Tan
        Me.Panel13.Location = New System.Drawing.Point(1660, 575)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(23, 18)
        Me.Panel13.TabIndex = 10
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Tan
        Me.Panel12.Location = New System.Drawing.Point(934, 575)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(23, 18)
        Me.Panel12.TabIndex = 7
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.DarkGray
        Me.Panel15.Location = New System.Drawing.Point(1365, 575)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(100, 18)
        Me.Panel15.TabIndex = 8
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Tan
        Me.Panel11.Location = New System.Drawing.Point(137, 575)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(23, 18)
        Me.Panel11.TabIndex = 6
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Gray
        Me.Panel10.Location = New System.Drawing.Point(525, 575)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(214, 18)
        Me.Panel10.TabIndex = 5
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Maroon
        Me.Panel9.Location = New System.Drawing.Point(1647, 736)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(36, 27)
        Me.Panel9.TabIndex = 6
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Black
        Me.Panel8.Location = New System.Drawing.Point(1344, 759)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(752, 92)
        Me.Panel8.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Red
        Me.Panel7.Location = New System.Drawing.Point(1372, 736)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(36, 27)
        Me.Panel7.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Blue
        Me.Panel6.Location = New System.Drawing.Point(1068, 729)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(100, 18)
        Me.Panel6.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Red
        Me.Panel5.Location = New System.Drawing.Point(1213, 817)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(136, 10)
        Me.Panel5.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(769, 456)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(100, 18)
        Me.Panel4.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(610, 468)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(100, 18)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(525, 645)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(432, 18)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 759)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1214, 92)
        Me.Panel1.TabIndex = 2
        '
        'Log
        '
        Me.Log.AutoSize = True
        Me.Log.Location = New System.Drawing.Point(29, 34)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(39, 13)
        Me.Log.TabIndex = 1
        Me.Log.Text = "Label1"
        '
        'Map1Barrier
        '
        Me.Map1Barrier.BackColor = System.Drawing.Color.Black
        Me.Map1Barrier.Controls.Add(Me.Map2)
        Me.Map1Barrier.Controls.Add(Me.Map1)
        Me.Map1Barrier.Enabled = False
        Me.Map1Barrier.Location = New System.Drawing.Point(130, 0)
        Me.Map1Barrier.Name = "Map1Barrier"
        Me.Map1Barrier.Size = New System.Drawing.Size(4000, 1000)
        Me.Map1Barrier.TabIndex = 6
        Me.Map1Barrier.Visible = False
        '
        'Map2
        '
        Me.Map2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Map2.Controls.Add(Me.Panel20)
        Me.Map2.Controls.Add(Me.Panel35)
        Me.Map2.Controls.Add(Me.Panel34)
        Me.Map2.Controls.Add(Me.Panel33)
        Me.Map2.Controls.Add(Me.Panel24)
        Me.Map2.Controls.Add(Me.Panel32)
        Me.Map2.Controls.Add(Me.Panel17)
        Me.Map2.Controls.Add(Me.Panel19)
        Me.Map2.Controls.Add(Me.Panel21)
        Me.Map2.Controls.Add(Me.Panel22)
        Me.Map2.Controls.Add(Me.Panel23)
        Me.Map2.Controls.Add(Me.Panel25)
        Me.Map2.Controls.Add(Me.Panel26)
        Me.Map2.Controls.Add(Me.Panel27)
        Me.Map2.Controls.Add(Me.Panel28)
        Me.Map2.Controls.Add(Me.Panel29)
        Me.Map2.Controls.Add(Me.Panel30)
        Me.Map2.Controls.Add(Me.Panel31)
        Me.Map2.Controls.Add(Me.Label1)
        Me.Map2.Controls.Add(Me.Map2Player)
        Me.Map2.Enabled = False
        Me.Map2.Location = New System.Drawing.Point(3, 11)
        Me.Map2.Name = "Map2"
        Me.Map2.Size = New System.Drawing.Size(4000, 827)
        Me.Map2.TabIndex = 11
        Me.Map2.Visible = False
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Red
        Me.Panel17.Location = New System.Drawing.Point(1869, 736)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(36, 27)
        Me.Panel17.TabIndex = 6
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.Tan
        Me.Panel19.Location = New System.Drawing.Point(552, 550)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(23, 18)
        Me.Panel19.TabIndex = 7
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.Tan
        Me.Panel21.Location = New System.Drawing.Point(1663, 550)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(23, 18)
        Me.Panel21.TabIndex = 6
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.Gray
        Me.Panel22.Location = New System.Drawing.Point(725, 550)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(157, 18)
        Me.Panel22.TabIndex = 5
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.Maroon
        Me.Panel23.Location = New System.Drawing.Point(1647, 736)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(36, 27)
        Me.Panel23.TabIndex = 6
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.Blue
        Me.Panel26.Location = New System.Drawing.Point(341, 745)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(100, 18)
        Me.Panel26.TabIndex = 5
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.Red
        Me.Panel27.Location = New System.Drawing.Point(1213, 817)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(136, 10)
        Me.Panel27.TabIndex = 3
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.Black
        Me.Panel28.Location = New System.Drawing.Point(907, 493)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(469, 18)
        Me.Panel28.TabIndex = 4
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.Black
        Me.Panel29.Location = New System.Drawing.Point(904, 493)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(24, 89)
        Me.Panel29.TabIndex = 4
        '
        'Panel30
        '
        Me.Panel30.BackColor = System.Drawing.Color.Black
        Me.Panel30.Location = New System.Drawing.Point(448, 493)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(101, 309)
        Me.Panel30.TabIndex = 3
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.Black
        Me.Panel31.Location = New System.Drawing.Point(0, 759)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(1841, 92)
        Me.Panel31.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Map2Player
        '
        Me.Map2Player.BackColor = System.Drawing.Color.GreenYellow
        Me.Map2Player.Location = New System.Drawing.Point(110, 676)
        Me.Map2Player.Name = "Map2Player"
        Me.Map2Player.Size = New System.Drawing.Size(50, 50)
        Me.Map2Player.TabIndex = 0
        Me.Map2Player.TabStop = False
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.Red
        Me.Panel25.Location = New System.Drawing.Point(1414, 742)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(36, 27)
        Me.Panel25.TabIndex = 5
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.Red
        Me.Panel32.Location = New System.Drawing.Point(552, 742)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(652, 27)
        Me.Panel32.TabIndex = 6
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.Black
        Me.Panel24.Location = New System.Drawing.Point(1033, 455)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(65, 18)
        Me.Panel24.TabIndex = 5
        '
        'Panel33
        '
        Me.Panel33.BackColor = System.Drawing.Color.Black
        Me.Panel33.Location = New System.Drawing.Point(1167, 424)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(73, 18)
        Me.Panel33.TabIndex = 6
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.Black
        Me.Panel34.Location = New System.Drawing.Point(1292, 383)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(100, 18)
        Me.Panel34.TabIndex = 7
        '
        'Panel35
        '
        Me.Panel35.BackColor = System.Drawing.Color.Black
        Me.Panel35.Location = New System.Drawing.Point(1372, 396)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(24, 186)
        Me.Panel35.TabIndex = 5
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.Black
        Me.Panel20.Location = New System.Drawing.Point(1512, 265)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(24, 220)
        Me.Panel20.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(2884, 881)
        Me.Controls.Add(Me.Map1Barrier)
        Me.Controls.Add(Me.TitleScreen)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TitleScreen.ResumeLayout(False)
        Me.TitleScreen.PerformLayout()
        CType(Me.Map1Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Map1.ResumeLayout(False)
        Me.Map1.PerformLayout()
        Me.Map1Barrier.ResumeLayout(False)
        Me.Map2.ResumeLayout(False)
        Me.Map2.PerformLayout()
        CType(Me.Map2Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleScreen As Panel
    Friend WithEvents Quit As Label
    Friend WithEvents Settings As Label
    Friend WithEvents PressToPlay As Label
    Friend WithEvents Map1Timer As Timer
    Friend WithEvents Platforms As Timer
    Friend WithEvents Map1Player As PictureBox
    Friend WithEvents Map1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Map1Barrier As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Log As Label
    Friend WithEvents Map2 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Panel28 As Panel
    Friend WithEvents Panel29 As Panel
    Friend WithEvents Panel30 As Panel
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Map2Player As PictureBox
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel35 As Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Panel33 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Panel25 As Panel
End Class

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
        Me.Map1 = New System.Windows.Forms.Panel()
        Me.Log = New System.Windows.Forms.Label()
        Me.Map1Player = New System.Windows.Forms.PictureBox()
        Me.Map1Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TitleScreen.SuspendLayout()
        Me.Map1.SuspendLayout()
        CType(Me.Map1Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleScreen
        '
        Me.TitleScreen.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TitleScreen.Controls.Add(Me.Quit)
        Me.TitleScreen.Controls.Add(Me.Settings)
        Me.TitleScreen.Controls.Add(Me.PressToPlay)
        Me.TitleScreen.Location = New System.Drawing.Point(86, 52)
        Me.TitleScreen.Name = "TitleScreen"
        Me.TitleScreen.Size = New System.Drawing.Size(306, 224)
        Me.TitleScreen.TabIndex = 0
        '
        'Quit
        '
        Me.Quit.AutoSize = True
        Me.Quit.Location = New System.Drawing.Point(121, 145)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(39, 13)
        Me.Quit.TabIndex = 0
        Me.Quit.Text = "Label1"
        '
        'Settings
        '
        Me.Settings.AutoSize = True
        Me.Settings.Location = New System.Drawing.Point(121, 92)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(39, 13)
        Me.Settings.TabIndex = 0
        Me.Settings.Text = "Label1"
        '
        'PressToPlay
        '
        Me.PressToPlay.AutoSize = True
        Me.PressToPlay.Location = New System.Drawing.Point(121, 62)
        Me.PressToPlay.Name = "PressToPlay"
        Me.PressToPlay.Size = New System.Drawing.Size(39, 13)
        Me.PressToPlay.TabIndex = 0
        Me.PressToPlay.Text = "Label1"
        '
        'Map1
        '
        Me.Map1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Map1.Controls.Add(Me.PictureBox3)
        Me.Map1.Controls.Add(Me.PictureBox2)
        Me.Map1.Controls.Add(Me.PictureBox1)
        Me.Map1.Controls.Add(Me.Log)
        Me.Map1.Controls.Add(Me.Map1Player)
        Me.Map1.Enabled = False
        Me.Map1.Location = New System.Drawing.Point(0, 0)
        Me.Map1.Name = "Map1"
        Me.Map1.Size = New System.Drawing.Size(1050, 572)
        Me.Map1.TabIndex = 1
        Me.Map1.Visible = False
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
        'Map1Player
        '
        Me.Map1Player.BackColor = System.Drawing.Color.Red
        Me.Map1Player.Location = New System.Drawing.Point(110, 100)
        Me.Map1Player.Name = "Map1Player"
        Me.Map1Player.Size = New System.Drawing.Size(100, 50)
        Me.Map1Player.TabIndex = 0
        Me.Map1Player.TabStop = False
        '
        'Map1Timer
        '
        Me.Map1Timer.Interval = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Location = New System.Drawing.Point(426, 532)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 456)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Blue
        Me.PictureBox2.Location = New System.Drawing.Point(573, 686)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(178, 23)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.Location = New System.Drawing.Point(255, 456)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 456)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1398, 736)
        Me.Controls.Add(Me.Map1)
        Me.Controls.Add(Me.TitleScreen)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TitleScreen.ResumeLayout(False)
        Me.TitleScreen.PerformLayout()
        Me.Map1.ResumeLayout(False)
        Me.Map1.PerformLayout()
        CType(Me.Map1Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleScreen As Panel
    Friend WithEvents Map1 As Panel
    Friend WithEvents Map1Player As PictureBox
    Friend WithEvents Quit As Label
    Friend WithEvents Settings As Label
    Friend WithEvents PressToPlay As Label
    Friend WithEvents Map1Timer As Timer
    Friend WithEvents Log As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
